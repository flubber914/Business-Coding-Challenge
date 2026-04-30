using System;
using System.Collections.Generic;
using System.Text;

namespace Patient_Outreach_Engine
{
    internal interface CommunicationInterface
    {
        void ContactPatient(Patient patient);
        void EscalatePatient(Patient patient);
    }
}
