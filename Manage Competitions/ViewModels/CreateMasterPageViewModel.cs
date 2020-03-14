using GalaSoft.MvvmLight.Command;
using Manage_Competitions.State.Navigator;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Competitions.ViewModels
{
    public class CreateMasterPageViewModel : ManageCompetitionsBaseViewModel
    {
        private INavigator _navigator;

        public string Name
        {
            get => Competition.Name;
            set
            {
                Competition.Name = value;
                OnPropertyChanged(); 
            }
        }

        public string MainJudje
        {
            get => Competition.MainJudje;
            set
            {
                Competition.MainJudje = value;
                OnPropertyChanged();
            }
        }

        public string MainSecretaty
        {
            get => Competition.MainSecretaty;
            set
            {
                Competition.MainSecretaty = value;
                OnPropertyChanged();
            }
        }

        public string Place
        {
            get => Competition.Place;
            set
            {
                Competition.Place = value;
                OnPropertyChanged();
            }
        }

        public Competition Competition { get; }

        public override string Title => "Создать новое соревнование";
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

        public CreateMasterPageViewModel(INavigator navigator)
        {
            Navigator = navigator;
            Competition = new Competition();
        }
    }
}
