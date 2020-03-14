using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Manage_Competitions.Commands;
using Manage_Competitions.State.Navigator;

namespace Manage_Competitions.ViewModels
{
    public class StartPageViewModel : ManageCompetitionsBaseViewModel
    {
        private INavigator _navigator;
        public override string Title => "Start Page";
        public override bool IsValid() => true;
        public INavigator Navigator
        {
            get => _navigator;
            set
            {
                _navigator = value;
                OnPropertyChanged();
            }
        }

        public StartPageViewModel(INavigator navigator)
        {
            Navigator = navigator;
        }

    }
}
