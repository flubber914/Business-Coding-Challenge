using System;
using System.Collections.Generic;
using System.Text;

namespace Patient_Outreach_Engine
{
    internal class Validator
    {
        Dispatcher m_dispatcher;
        /// <summary>
        /// set the dispatcher on ititialisation in constructor
        /// </summary>
        /// <param name="_dispatcher"></param>
        public Validator(Dispatcher _dispatcher)
        {
            m_dispatcher = _dispatcher;
        }
        /// <summary>
        /// takes a database, for each member within that database, determine Dispatcher outcome and send to dispatcher
        /// </summary>
        /// <param name="database">database of patients created within database class in all cases for this demonstration</param>
        public void ValidateTable(List<Patient> database)
        {
            List<DispatchPacket> packets = new List<DispatchPacket>();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Initialising validation of patient contact");
            foreach (Patient patient in database)
            {
                packets.Add(ValidatePatient(patient));
            }
            Console.WriteLine("Validation complete, sending to dispatcher");
            Console.WriteLine("------------------------------------");
            m_dispatcher.DispatchController(packets);
        }
        /// <summary>
        /// takes a patient, and determines how to contact the dispatcher
        /// </summary>
        /// <param name="patient"></param>
        private DispatchPacket ValidatePatient(Patient patient)
        {
            try
            {
                Console.WriteLine("---------------------");
                Console.WriteLine($"Validating {patient.GetName()}");
                switch (patient.GetCurrentRisk())
                {
                    case Patient.RiskLevel.Low:
                    case Patient.RiskLevel.Medium:
                        Console.WriteLine($"{patient.GetName()} is {patient.GetCurrentRisk()} risk, contact method will be considered.");
                        break;
                    case Patient.RiskLevel.High:
                        Console.WriteLine($"{patient.GetName()} is High risk, {patient.GetName()} will be referred to caseworker.");
                        return new DispatchPacket(false, true, patient);
                    default:
                        throw new ArgumentOutOfRangeException($"{patient.GetCurrentRisk()} is not a valid risk level");
                }
                switch (patient.GetContactMethod())
                {
                    case Patient.PreferredContact.Mobile:
                    case Patient.PreferredContact.Email:
                    case Patient.PreferredContact.SMS:
                    case Patient.PreferredContact.Mail:
                        return new DispatchPacket(true, false, patient);
                    case Patient.PreferredContact.Private:
                        return new DispatchPacket(false, false, patient);
                    default:
                        throw new ArgumentOutOfRangeException($"{patient.GetContactMethod()} is not a valid contact method");
                }
            }
            catch 
            {
                Console.WriteLine("Patient information invalid, adding empty packet to list, follow up on invalid information.");
                return new DispatchPacket();
            }
        }
    }
}
