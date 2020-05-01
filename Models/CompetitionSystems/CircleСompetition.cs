using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Models.CompetitionSystems
{
    public class CircleСompetition : ICompetitionSystem
    {

        #region Private_Properties
        private List<Participant> _participants;
        private IList<IRound> _rounds;
        private WeightCategory _weightCategory;
        #endregion

        #region Private_Metods
        private void ShiftParticipants()
        {
            List<Participant> temp = new List<Participant>();
            temp.Add(_participants[0]);
            temp.Add(_participants[_participants.Count - 1]);
            for (int i = 2; i < _participants.Count; i++)
            {
                temp.Add(_participants[i - 1]);
            }
            _participants.Clear();
            _participants.AddRange(temp);
        }
        #endregion

        public IEnumerable<Participant> Participants { get => _participants;  }
        public IList<IRound> Rounds { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public WeightCategory WeightCategory { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        IEnumerable<Participant> ICompetitionSystem.Participants { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event PropertyChangedEventHandler PropertyChanged;

        public void GroupParticipants()
        {
            throw new NotImplementedException();
        }
    }
}
