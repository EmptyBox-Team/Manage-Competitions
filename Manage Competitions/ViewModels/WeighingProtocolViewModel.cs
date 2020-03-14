using Manage_Competitions.Commands;
using Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Manage_Competitions.ViewModels
{
    public class WeighingProtocolViewModel : ManageCompetitionsBaseViewModel
    {
        private ObservableCollection<Participant> _participants;
        private ICommand _addParticipant;
        private ICommand _deleteParticipant;
        private Participant _selectedParticipant;
        public override string Title => throw new NotImplementedException();

        public ObservableCollection<Participant> Participants
        {
            get => _participants;
            set
            {
                _participants = value;
                OnPropertyChanged();
            }
        }
        
        public WeighingProtocolViewModel(ObservableCollection<Participant> participants)
        {
            _participants = participants;
        }

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }

        public ICommand AddParticipant
        {
            get => _addParticipant ??
                (_addParticipant = new RelayCommand(parametr =>
                {
                    Participants.Add(new Participant());
                }));
        }

        public ICommand DeleteParticipant
        {
            get => _deleteParticipant ??
                (_deleteParticipant = new RelayCommand(parametr =>
                {
                    Participants.Remove(_selectedParticipant);
                }));
        }

        public WeighingProtocolViewModel()
        {
            _participants = new ObservableCollection<Participant>();
            _participants.Add(new Participant
            {
                FirstName = "Иванов",
                Number = 1,
                Rank = "Мастер",
                Gender = "Мужской",
                Weight = 60

            });
            _participants.Add(new Participant
            {
                FirstName = "Иванов",
                Number = 1,
                Rank = "Мастер",
                Gender = "Мужской",
                Weight = 60

            });
            _participants.Add(new Participant
            {
                FirstName = "Иванов",
                Number = 1,
                Rank = "Мастер",
                Gender = "Мужской",
                Weight = 60

            });
            _participants.Add(new Participant
            {
                FirstName = "Иванов",
                Number = 1,
                Rank = "Мастер",
                Gender = "Мужской",
                Weight = 60

            });
            _participants.Add(new Participant
            {
                FirstName = "Иванов",
                Number = 1,
                Rank = "Мастер",
                Gender = "Мужской",
                Weight = 60

            });
            _participants.Add(new Participant
            {
                FirstName = "Иванов",
                Number = 1,
                Rank = "Мастер",
                Gender = "Мужской",
                Weight = 60

            });
        }
    }
}
