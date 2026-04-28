using System;
using System.Collections.Generic;
using System.Text;

namespace Patient_Outreach_Engine
{
    internal struct DispatchPacket
    {
        public bool m_shouldMessage { get; }
        public bool m_shouldRefer {  get; }
        public Patient.PreferredContact m_preferredContact { get; }
        public DispatchPacket(bool shouldMessage, bool shouldRefer, Patient.PreferredContact preferredContact)
        {
            m_shouldMessage = shouldMessage;
            m_shouldRefer = shouldRefer;
            m_preferredContact = preferredContact;
        }
    }
}
