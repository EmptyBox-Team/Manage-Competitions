using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Round : IRound
    {
        public IDictionary<Participant, Participant> Rivals
        {
            get => _Rivals;
            set
            {
                _Rivals = value;
            }
        }
        private IDictionary<Participant, Participant> _Rivals;

        public Round()
        {
            _Rivals = new Dictionary<Participant, Participant>();
        }

        public void GroupParticipants(List<Participant> participants)
        {
            if ((participants.Count % 2) == 0)
            {
                for (int i = 0; i < participants.Count; i++)
                {
                    _Rivals.Add(participants[i], participants[participants.Count - 1 - i]);
                }
            }
            else
            {
                for (int i = 0; i < participants.Count - 1; i++)
                {
                    _Rivals.Add(participants[i], participants[participants.Count - 2 - i]);
                }
            }
        }
    }
}
