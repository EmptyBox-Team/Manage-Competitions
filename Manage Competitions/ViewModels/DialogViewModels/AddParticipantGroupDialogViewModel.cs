using Manage_Competitions.Commands;
using Manage_Competitions.Services.EnumItemSourceServices;
using Models;
using Models.CompetitionSystems;
using Models.Services.DialogServices;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Manage_Competitions.ViewModels.DialogViewModels
{
    public class AddParticipantGroupDialogViewModel : ManageCompetitionsBaseViewModel, IDialogRequestClose
    {

        private int _heightWindow;
        private ObservableCollection<Participant> _participants;
        private ObservableCollection<Participant> _groupParticipants;
        private int _gridHeight;
        private CompetitionSystemType _competitionSystemType;

        public override string Title => throw new NotImplementedException();
        private WeightCategory _weightCategory;

        public int FirstWeight
        {
            get => _weightCategory.First;
            set
            {
                _weightCategory.First = value;
                OnPropertyChanged();
            }
        }

        public int SecondWeigth
        {
            get => _weightCategory.Last;
            set
            {
                _weightCategory.Last = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Participant> GroupParticipants
        {
            get => _groupParticipants;
            private set
            {
                _groupParticipants = value;
                OnPropertyChanged();
            }
        }

        public event EventHandler<DialogCloseRequestedEventArgs> CloseRequested;

        public int HeightWindow
        {
            get => _heightWindow;
            set
            {
                _heightWindow = value;
                OnPropertyChanged();
            }
        }

        public int GridHeight
        {
            get => _gridHeight;
            set
            {
                _gridHeight = value;
                OnPropertyChanged();           
            }
        }


        public override bool IsValid()
        {
            throw new NotImplementedException();
        }

        public CompetitionSystemType SelectedSection { get { return _competitionSystemType; } set { _competitionSystemType = value; OnPropertyChanged(); } }

        public ICommand OkCommand { get => new RelayCommand(p => CloseRequested?.Invoke(this, new DialogCloseRequestedEventArgs(true))); }
        public ICommand CancelCommand { get => new RelayCommand(p => CloseRequested?.Invoke(this, new DialogCloseRequestedEventArgs(false))); }

        public ICommand ApplyWeight
        {
            get => new RelayCommand(p => 
            {
                var gp = _participants.Where(x => (x.Weight >= FirstWeight && x.Weight <= SecondWeigth));
                GroupParticipants = new ObservableCollection<Participant>();
                foreach (Participant item in gp)
                    GroupParticipants.Add(item);
                GridHeight = 100 + gp.Count() * 20;
                HeightWindow = 200 + GridHeight;
            });
        }

        public ICompetitionSystem GetCompetitionSystem()
        {
            switch (SelectedSection)
            {
                case CompetitionSystemType.CIRCLE_TYPE:
                    return new CircleСompetition { Participants = GroupParticipants, WeightCategory = _weightCategory };
                case CompetitionSystemType.OLIMPICK_SYSTEM:
                    return new OlympicSystem { Participants = GroupParticipants, WeightCategory = _weightCategory };
                case CompetitionSystemType.RETIREMEMTAFTER_TWO_LOSSES_SYSTEM:
                    return new RetirementAfterTwoLossesSystem { Participants = GroupParticipants, WeightCategory = _weightCategory };
            }
            return null;
        }

        public AddParticipantGroupDialogViewModel(ObservableCollection<Participant> participants)
        {
            _participants = participants;
            HeightWindow = 200;
            SelectedSection = CompetitionSystemType.CIRCLE_TYPE;
        }
    }
}
