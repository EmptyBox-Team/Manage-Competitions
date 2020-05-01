using Models.CompetitionSystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Competitions.Services.CompetitionSistemFactory
{
    public interface ICompetitionSystemFactory
    {
        ICompetitionSystem Create();
    }
}
