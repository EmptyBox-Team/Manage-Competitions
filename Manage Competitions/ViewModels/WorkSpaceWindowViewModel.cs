using Manage_Competitions.State.Navigator;
using Models;
using Models.CompetitionSystems;
using Models.Services.DialogServices;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Competitions.ViewModels
{
    public class WorkSpaceWindowViewModel : ManageCompetitionsBaseViewModel
    {

        private Competition _contest;


        public string ContestName => _contest.Name;
        public string ContestPlace => _contest.Place;
        public ObservableCollection<ICompetitionSystem> CompetitionSystems { get; set; }
        public ObservableCollection<Participant> Participants { get; set; }
        public ObservableCollection<IRound> Rounds { get; set; }

        public WorkSpaceWindowViewModel(Competition contest)
        {
            _contest = contest;
            NavigationMenu = new NavigationMenu(_contest);
        }

        public override string Title => throw new NotImplementedException();
        public Competition MainContest
        {
            get => _contest;
            set
            {
                _contest = value;
                OnPropertyChanged();
            }
        }

        public INavigator NavigationMenu { get; set; }

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }

    }
}
