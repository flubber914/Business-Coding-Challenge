using System;
using System.Collections.Generic;
using System.Text;

namespace Patient_Outreach_Engine
{
    internal class Dispatcher
    {
        CommunicationInterface m_communication;
        /// <summary>
        /// connects to interface on creation
        /// </summary>
        public Dispatcher(CommunicationInterface communication)
        {
            m_communication = communication;
        }

        public void DispatchController(List<DispatchPacket> packets)
        {
            foreach (var item in packets)
            {
                if (item.m_shouldMessage)
                {
                    m_communication.ContactPatient(item.m_patient);
                }
                else if(item.m_shouldRefer)
                {
                    m_communication.EscalatePatient(item.m_patient);
                }
                else
                {
                    Console.WriteLine($"Message will not be sent to {item.m_patient.GetName()}");
                }
            }
        }
    };
}
