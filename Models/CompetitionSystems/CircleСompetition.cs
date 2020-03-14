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
        private List<Participant> _Participants;
        private List<Round> _Rounds;
        #endregion

        #region Private_Metods
        private void ShiftParticipants()
        {
            List<Participant> temp = new List<Participant>();
            temp.Add(_Participants[0]);
            temp.Add(_Participants[_Participants.Count - 1]);
            for (int i = 2; i < _Participants.Count; i++)
            {
                temp.Add(_Participants[i - 1]);
            }
            _Participants.Clear();
            _Participants.AddRange(temp);
        }
        #endregion
        public IEnumerable<Participant> Participants { get => _Participants; set => throw new NotImplementedException(); }
        public IEnumerable<IRound> Rounds { get => _Rounds; set => throw new NotImplementedException(); }
        public WeightCategory WeightCategory { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event PropertyChangedEventHandler PropertyChanged;
        public void GroupParticipants()
        {
          if ((_Participants.Count % 2) == 0)
                {
                    for (int i = 0; i < _Participants.Count - 1; i++)
                    {
                        _Rounds.Add(new Round());
                        _Rounds[i].GroupParticipants(_Participants);
                        ShiftParticipants();
                    }
                }
        }

        public void AddRound()
        {

        }

        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
