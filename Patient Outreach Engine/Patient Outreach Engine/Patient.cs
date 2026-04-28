using System;
using System.Collections.Generic;
using System.Text;

namespace Patient_Outreach_Engine
{
    internal class Patient
    {
        public enum RiskLevel { Low, Medium, High };
        public enum PreferredContact { Mobile, Email, SMS, Mail, Private};
        private string m_name;
        private RiskLevel m_currentRisk;
        private PreferredContact m_contactMethod;
        private string m_lastNotes;

        /// <summary>
        /// this constructor creates a patient as a data entry into the database
        /// </summary>
        /// <param name="_name"></param>
        /// <param name="_currentRisk">High risk patients may not benefit from a text from this system</param>
        /// <param name="_contactMethod">patients preferred contact method, if private then they are treated the same as someone who is high risk</param>
        /// <param name="_lastNotes">additional possible information about the patient</param>
        public Patient(string _name, RiskLevel _currentRisk, PreferredContact _contactMethod, string _lastNotes)
        {
            m_name = _name;
            m_currentRisk = _currentRisk;
            m_contactMethod = _contactMethod;
            m_lastNotes = _lastNotes;
        }

        /// <summary>
        /// returns private patient m_name member field
        /// </summary>
        /// <returns>m_name</returns>
        public string GetName()
        {
            return m_name;
        }

        /// <summary>
        /// returns private patient m_currentRisk member field
        /// </summary>
        /// <returns>m_currentRisk</returns>
        public RiskLevel GetCurrentRisk()
        {
            return m_currentRisk;
        }

        /// <summary>
        /// returns private m_contactMethod member field
        /// </summary>
        /// <returns>m_contactMethod</returns>
        public PreferredContact GetContactMethod()
        {
            return m_contactMethod;
        }

        /// <summary>
        /// return private m_lastNotes member field
        /// </summary>
        /// <returns>m_lastNotes</returns>
        public string GetlastNotes()
        {
            return m_lastNotes;
        }
        /// <summary>
        /// prints out the entries trying hard to make it orderly for a database
        /// </summary>
        /// <returns>string containing </returns>
        public string PrintEntry()
        {
            return $"| Name: {m_name,-20} | Current Risk: {m_currentRisk,-10} | Contact Method: {m_contactMethod, -10} | Last Notes: {m_lastNotes, -80} |";
        }
    }
}
