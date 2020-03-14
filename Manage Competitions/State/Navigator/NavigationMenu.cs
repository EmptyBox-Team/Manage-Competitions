using Manage_Competitions.Commands;
using Manage_Competitions.Services;
using Manage_Competitions.ViewModels;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Manage_Competitions.State.Navigator
{
    public enum Pages {HomePage, WeighingProtocolPage, CompetitionСoursePage, EditCompetitionPage }
    public class NavigationMenu : NotifyModelBase,  INavigator
    {
        private ManageCompetitionsBaseViewModel _currentViewModel;
        private ICommand _updateCurrentViewModel;
        private Competition _competition;

        public ManageCompetitionsBaseViewModel CurrentViewModel 
        { 
            get 
            {
                return _currentViewModel;
            }
            set
            {
                _currentViewModel = value;
                OnPropertyChanged();
            }
        }

        public NavigationMenu(Competition сompetition)
        {
            _competition = сompetition;
        }

        public ICommand UpdateCurrentViewModel
        {
            get
            {
                    return _updateCurrentViewModel ??
                    (_updateCurrentViewModel = new RelayCommand(parametr =>
                    {
                        if (parametr is Pages)
                        {
                            var page = (Pages)parametr;
                            CurrentViewModel = new WeighingProtocolBuilder(_competition).Do(page);
                        }
                    }));
            }
        }

    }
}
