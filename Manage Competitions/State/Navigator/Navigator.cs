using Manage_Competitions.Commands;
using Manage_Competitions.ViewModels;
using Manage_Competitions.Views.DialogWindows;
using Manage_Competitions.Views.MainApplicationViews.Windows;
using Models;
using Models.Services.DialogServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Manage_Competitions.State.Navigator
{
    enum ViewType { StartPage, CreateMasterPage}
    public class Navigator : NotifyModelBase, INavigator 
    {
        private ICommand _updateCurrentViewModel;
        private ICommand _initializeWorkSpaceWindow;
        private ManageCompetitionsBaseViewModel _currentViewModel;
        public ManageCompetitionsBaseViewModel CurrentViewModel
        {
            get => _currentViewModel;
            set
            {
                _currentViewModel = value;
                OnPropertyChanged();
            }
        }

        public Navigator()
        {
            CurrentViewModel = new StartPageViewModel(this);
        }

        public ICommand UpdateCurrentViewModel
        {
            get
            {
                 return _updateCurrentViewModel ??
                    (_updateCurrentViewModel = new RelayCommand(parametr =>
                    {
                        if (parametr is ViewType)
                        {
                            var viewType = (ViewType)parametr;
                            switch(viewType)
                            {
                                case ViewType.CreateMasterPage:
                                    CurrentViewModel = new CreateMasterPageViewModel(this);
                                    break;
                                case ViewType.StartPage:
                                    CurrentViewModel = new StartPageViewModel(this);
                                    break;
                            }
                        }
                    }));
            }
        }

        public ICommand InitializeWorkSpaceWindow => _initializeWorkSpaceWindow ??
                    (_initializeWorkSpaceWindow = new RelayCommand(parametr =>
                        {
                            var workSpaceWindow = new WorkSpaceWindow();
                            workSpaceWindow.Show();
                            var competition = (Competition)parametr;
                            workSpaceWindow.DataContext = new WorkSpaceWindowViewModel(competition);
                            Application.Current.MainWindow = workSpaceWindow;
                        }));

    }
}
