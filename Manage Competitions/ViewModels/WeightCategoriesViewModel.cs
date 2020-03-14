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
        private ObservableCollection<ICompetitionSystem> _weightCategories;
        public ObservableCollection<WeightCategoryViewModel> WeightCategoryViewModels { get; } = new ObservableCollection<WeightCategoryViewModel>();
        public ObservableCollection<Participant> Participants { get; set; }

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }

        private void DisplayAddDialogWindow()
        {
            var viewModel = new AddParticipantGroupDialogViewModel(Participants);
            var view = new AddCompetitionSystemDialog { DataContext = viewModel};
            bool? result = view.ShowDialog();

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

        public WeightCategoriesViewModel(IDialogService dialogServices)
        {
            //_weightCategories = weightCategories;
            _dialogService = dialogServices;

            WeightCategoryViewModels.Add(new WeightCategoryViewModel());
            WeightCategoryViewModels.Add(new WeightCategoryViewModel());
            WeightCategoryViewModels.Add(new WeightCategoryViewModel());
            WeightCategoryViewModels.Add(new WeightCategoryViewModel());
            WeightCategoryViewModels.Add(new WeightCategoryViewModel());
            WeightCategoryViewModels.Add(new WeightCategoryViewModel());
            WeightCategoryViewModels.Add(new WeightCategoryViewModel());
            WeightCategoryViewModels.Add(new WeightCategoryViewModel());
            WeightCategoryViewModels.Add(new WeightCategoryViewModel());
            WeightCategoryViewModels.Add(new WeightCategoryViewModel());
            WeightCategoryViewModels.Add(new WeightCategoryViewModel());

        }
    }
}
