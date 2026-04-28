using System;
using System.Collections.Generic;
using System.Text;

namespace Patient_Outreach_Engine
{
    internal class Patient
    {
        public enum RiskLevel { Low, Medium, High };
        public enum PreferredContact { Mobile, Email, SMS, Mail, Private};
        private string name;
        private RiskLevel currentRisk;
        private PreferredContact contactMethod;
        private string lastNotes;

        /// <summary>
        /// this constructor creates a patient as a data entry into the database
        /// </summary>
        /// <param name="_name"></param>
        /// <param name="_currentRisk">High risk patients may not benefit from a text from this system</param>
        /// <param name="_contactMethod">patients preferred contact method, if private then they are treated the same as someone who is high risk</param>
        /// <param name="_lastNotes">additional possible information about the patient</param>
        public Patient(string _name, RiskLevel _currentRisk, PreferredContact _contactMethod, string _lastNotes)
        {
            name = _name;
            currentRisk = _currentRisk;
            contactMethod = _contactMethod;
            lastNotes = _lastNotes;
        }
    }
}
