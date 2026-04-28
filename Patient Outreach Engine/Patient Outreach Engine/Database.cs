using System;
using System.Collections.Generic;
using System.Text;

namespace Patient_Outreach_Engine
{
    internal class Database
    {
        List<Patient> m_database = new List<Patient>();

        /// <summary>
        /// Constructor generates database on object creation as this program doesn't use a real database
        /// </summary>
        public Database()
        {
            GenerateDatabase();
        }

        /// <summary>
        /// generates a preset database of patients including all the database patient information
        /// </summary>
        void GenerateDatabase()
        {
            m_database = new List<Patient>
            {

            };
        }
    }
}
