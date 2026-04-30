using System;
using System.Collections.Generic;
using System.Text;

namespace Patient_Outreach_Engine
{
    internal class Communicator : CommunicationInterface
    {
        public void ContactPatient(Patient patient)
        {
            Console.WriteLine($"{patient.GetName()} has been sent an automated appointment reminder through {patient.GetContactMethod()}.");
        }

        public void EscalatePatient(Patient patient)
        {
            Console.WriteLine($"{patient.GetName()} has not been sent a message, and has instead been escalated to a caseworker.");
        }
    }
}
