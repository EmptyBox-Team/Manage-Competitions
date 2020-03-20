using Manage_Competitions.State.Navigator;
using Manage_Competitions.ViewModels;
using Manage_Competitions.ViewModels.DialogViewModels;
using Manage_Competitions.Views.DialogWindows;
using Models;
using Models.Services.DialogServices;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Manage_Competitions.Services
{
    public class WeighingProtocolBuilder
    {
        private Competition _competition;

        public WeighingProtocolBuilder(Competition competition)
        {
            _competition = competition;
        }

        private WeighingProtocolViewModel weighingProtocolPage()
        {
            var weighingProtocolViewModel = new WeighingProtocolViewModel((ObservableCollection<Participant>)_competition.Participants);
            return weighingProtocolViewModel;
        }

        private WeightCategoriesViewModel competitionСoursePage()
        {
            var mainWindow = Application.Current.MainWindow;
            IDialogService dialogService = new DialogService(mainWindow);
            dialogService.Register<AddParticipantGroupDialogViewModel, AddCompetitionSystemDialog>();
            var weightCategoriesViewModell = new WeightCategoriesViewModel(dialogService, (ObservableCollection<Participant>)_competition.Participants);
            return weightCategoriesViewModell;
        }

        public ManageCompetitionsBaseViewModel Do(Pages page)
        {
            switch(page)
            {
                case Pages.HomePage:
                    break;
                case Pages.WeighingProtocolPage:
                    return weighingProtocolPage();
                case Pages.CompetitionСoursePage:
                    return competitionСoursePage();
                default:
                    return null;
            }
            return null;
        }
    } 
}
