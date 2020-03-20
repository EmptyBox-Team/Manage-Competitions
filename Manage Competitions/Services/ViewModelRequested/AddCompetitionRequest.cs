using Models.CompetitionSystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Competitions.Services.ViewModelRequested
{
    public interface IAddCompetitionRequest
    {
        event EventHandler<AddCompetitionSysyemActionArgs> CloseRequested;
    }

    public class AddCompetitionSysyemActionArgs : EventArgs
    {
        public AddCompetitionSysyemActionArgs(ICompetitionSystem competitionSystem)
        {
            CompetitonSystem = competitionSystem;
        }

        public ICompetitionSystem CompetitonSystem { get; set; }

    }
}
