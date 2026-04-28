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
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Initialising validation of patient contact");
            foreach (Patient patient in database)
            {
                ValidatePatient(patient);
            }
        }
        /// <summary>
        /// takes a patient, and determines how to contact the dispatcher
        /// </summary>
        /// <param name="patient"></param>
        public void ValidatePatient(Patient patient)
        {
            Console.WriteLine("---------------------");
            Console.WriteLine($"Validating {patient.GetName()}");
            switch (patient.GetCurrentRisk())
            {
                case Patient.RiskLevel.Low:
                case Patient.RiskLevel.Medium:
                    Console.WriteLine($"{patient.GetName()} is {patient.GetCurrentRisk} risk, contact method will be considered.");
                    break;
                case Patient.RiskLevel.High:
                    Console.WriteLine($"{patient.GetName()} is High risk, {patient.GetName()} will be referred to caseworker.");
                    m_dispatcher.DispatchController(new DispatchPacket(false, true));
                    return;
                default:
                    break;
            }
            switch (patient.GetContactMethod())
            {
                case Patient.PreferredContact.Mobile:
                    break;
                case Patient.PreferredContact.Email:
                    break;
                case Patient.PreferredContact.SMS:
                    break;
                case Patient.PreferredContact.Mail:
                    break;
                case Patient.PreferredContact.Private:
                    break;
                default:
                    break;
            }
        }
    }
}
