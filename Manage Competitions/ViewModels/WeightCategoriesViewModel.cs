using Manage_Competitions.Commands;
using Manage_Competitions.ViewModels.DialogViewModels;
using Models;
using Models.Services.DialogServices;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Manage_Competitions.Views.DialogWindows;
using Models.CompetitionSystems;

namespace Manage_Competitions.ViewModels
{
    public class WeightCategoriesViewModel : ManageCompetitionsBaseViewModel
    {
        public override string Title => "Категории участников";
        private ICommand _addCategory;
        private IDialogService _dialogService;
        private ObservableCollection<ICompetitionSystem> _competitions;
        private ObservableCollection<Participant> _participants;

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<ICompetitionSystem> Competitions
        {
            get => _competitions;
            set 
            {
                _competitions = value;
                OnPropertyChanged();
            }
        }

        private void DisplayAddDialogWindow()
        {
            var viewModel = new AddParticipantGroupDialogViewModel(_participants);
            bool? result = _dialogService.ShowDialog(viewModel);
            if (result.HasValue)
            {
                _competitions.Add(viewModel.GetCompetitionSystem());
            }
        }        

        public ICommand AddCategory
        {
            get
            {
                return _addCategory ??
                    (_addCategory = new RelayCommand(parametr =>
                    {
                        DisplayAddDialogWindow();
                    }));
            }
        }

        public WeightCategoriesViewModel(IDialogService dialogServices, ObservableCollection<Participant> participants, ObservableCollection<ICompetitionSystem> competitions)
        {
            _dialogService = dialogServices;
            _participants = participants;
            _competitions = competitions;
        }
    }
}
