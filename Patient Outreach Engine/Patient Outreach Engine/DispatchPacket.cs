using System;
using System.Collections.Generic;
using System.Text;

namespace Patient_Outreach_Engine
{
    internal struct DispatchPacket
    {
        public bool m_shouldMessage { get; }
        public bool m_shouldRefer {  get; }
        public Patient m_patient {  get; }

        /// <summary>
        /// This struct constructor sets information to be sent by the validator to the dispatch,
        /// using this struct, information can be send in bulk rather than multiple individual sets of information
        /// </summary>
        /// <param name="shouldMessage">whether patient should be messaged</param>
        /// <param name="shouldRefer">whether patient should be referred to a worker</param>
        /// <param name="preferredContact">the method which should be used if patient should be messaged</param>
        public DispatchPacket(bool shouldMessage, bool shouldRefer, Patient patient)
        {
            m_shouldMessage = shouldMessage;
            m_shouldRefer = shouldRefer;
            m_patient = patient;
        }
    }
}
