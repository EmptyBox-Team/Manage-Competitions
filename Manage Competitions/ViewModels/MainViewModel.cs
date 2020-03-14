using Manage_Competitions.Commands;
using Manage_Competitions.State.Navigator;
using Manage_Competitions.Views;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Competitions.ViewModels
{
    public class MainViewModel : NotifyModelBase
    {
        private INavigator _navigator;
        public INavigator Navigator
        {
            get => _navigator;
            set
            {
                _navigator = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            Navigator = new Navigator();
            Navigator.CurrentViewModel = new StartPageViewModel(Navigator);
        }
    }
}
