using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Models.CompetitionSystems
{
    public class RetirementAfterTwoLossesSystem : ICompetitionSystem
    {
        public CategoryParticipants Category { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IEnumerable<Participant> Participants { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IEnumerable<IRound> Rounds { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public WeightCategory WeightCategory { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        IList<IRound> ICompetitionSystem.Rounds { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event PropertyChangedEventHandler PropertyChanged;

        public void GroupParticipants()
        {
            throw new NotImplementedException();
        }
    }
}
