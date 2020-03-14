using Manage_Competitions.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Manage_Competitions.State.Navigator
{
    public interface INavigator
    {
        ManageCompetitionsBaseViewModel CurrentViewModel { get; set; }
        ICommand UpdateCurrentViewModel { get; }
    }
}
