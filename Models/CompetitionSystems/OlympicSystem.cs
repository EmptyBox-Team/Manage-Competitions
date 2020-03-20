using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Models.CompetitionSystems
{
    public class OlympicSystem : ICompetitionSystem
    {
        public IEnumerable<Participant> Participants { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IList<IRound> Rounds { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public WeightCategory WeightCategory { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event PropertyChangedEventHandler PropertyChanged;

        public void GroupParticipants()
        {
            throw new NotImplementedException();
        }
    }
}
