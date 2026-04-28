using System;
using System.Collections.Generic;
using System.Text;
using static Patient_Outreach_Engine.Patient;

namespace Patient_Outreach_Engine
{
    internal class Database
    {
        private List<Patient> m_data = new List<Patient>();

        /// <summary>
        /// Constructor generates database on object creation as this program doesn't use a real database
        /// </summary>
        public Database()
        {
            GenerateDatabase();
        }

        public List<Patient> GetData()
        {
            return m_data;
        }

        /// <summary>
        /// generates a preset database of patients including all the database patient information
        /// </summary>
        void GenerateDatabase()
        {
            m_data = new List<Patient>
            {
                new Patient("John Doe", RiskLevel.Low, PreferredContact.Email, "Routine checkup scheduled."),
                new Patient("Jane Smith", RiskLevel.High, PreferredContact.Mobile, "Requires immediate follow-up."),
                new Patient("Michael Brown", RiskLevel.Medium, PreferredContact.SMS, "Patient prefers afternoon texts."),
                new Patient("Emily Davis", RiskLevel.Low, PreferredContact.Private, "Strict privacy requested."),
                new Patient("William Wilson", RiskLevel.High, PreferredContact.Mail, "Paper records only."),
                new Patient("Olivia Taylor", RiskLevel.Medium, PreferredContact.Email, "Pending lab results."),
                new Patient("James Anderson", RiskLevel.Low, PreferredContact.Mobile, "No known allergies."),
                new Patient("Sophia Thomas", RiskLevel.High, PreferredContact.Private, "Contact via guardian only."),
                new Patient("Robert Jackson", RiskLevel.Medium, PreferredContact.SMS, "Follow-up in 2 weeks."),
                new Patient("Isabella White", RiskLevel.Low, PreferredContact.Mail, "Patient relocated recently."),
                new Patient("David Harris", RiskLevel.High, PreferredContact.Email, "High risk due to history."),
                new Patient("Mia Martin", RiskLevel.Medium, PreferredContact.Mobile, "Needs physical therapy."),
                new Patient("Joseph Thompson", RiskLevel.Low, PreferredContact.SMS, "Stable condition."),
                new Patient("Charlotte Garcia", RiskLevel.High, PreferredContact.Private, "Confidentiality is priority."),
                new Patient("Charles Martinez", RiskLevel.Medium, PreferredContact.Mail, "Hard of hearing, use mail."),
                new Patient("Amelia Robinson", RiskLevel.Low, PreferredContact.Email, "New patient registration."),
                new Patient("Christopher Clark", RiskLevel.High, PreferredContact.Mobile, "Urgent medication review."),
                new Patient("Evelyn Rodriguez", RiskLevel.Medium, PreferredContact.SMS, "Dietary plan discussed."),
                new Patient("Daniel Lewis", RiskLevel.Low, PreferredContact.Private, "Sensitive data handling."),
                new Patient("Ava Lee", RiskLevel.High, PreferredContact.Mail, "Standard post preferred.")
            };
        }

        public void PrintDataBase()
        {
            foreach (var item in m_data)
            {
                Console.WriteLine(item.PrintEntry());
            }
        }
    }
}
