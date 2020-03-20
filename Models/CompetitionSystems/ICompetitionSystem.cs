using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Models.CompetitionSystems
{
    public interface ICompetitionSystem : INotifyPropertyChanged
    {
        IEnumerable<Participant> Participants { get; set; }
        IEnumerable<IRound> Rounds { get; set; }
        void GroupParticipants();
        WeightCategory WeightCategory { get; set; }
    }
}
