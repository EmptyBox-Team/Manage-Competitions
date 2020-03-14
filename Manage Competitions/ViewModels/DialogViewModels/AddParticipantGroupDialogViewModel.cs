using Manage_Competitions.Commands;
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
        public override string Title => throw new NotImplementedException();
        public WeightCategory WeightCategory { get; set; }
        public CompetitionSystemType CompetitionSystemType { get; set; }
        public ObservableCollection<Participant> Participants { get; set; }

        public event EventHandler<DialogCloseRequestedEventArgs> CloseRequested;

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }

        public ICommand OkCommand { get; }
        public ICommand CancelCommand { get; }

        public AddParticipantGroupDialogViewModel(ObservableCollection<Participant> participants)
        {
            Participants = participants;
        }

        public AddParticipantGroupDialogViewModel()
        {
            OkCommand = new RelayCommand(p => CloseRequested?.Invoke(this, new DialogCloseRequestedEventArgs(true)));
            CancelCommand = new RelayCommand(p => CloseRequested?.Invoke(this, new DialogCloseRequestedEventArgs(false)));
        }

    }
}
