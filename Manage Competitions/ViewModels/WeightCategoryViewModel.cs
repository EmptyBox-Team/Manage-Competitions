using Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Competitions.ViewModels
{
    public class WeightCategoryViewModel : ManageCompetitionsBaseViewModel
    {

        private ObservableCollection<Participant> _participants;

        public WeightCategory WeightCategory { get; set; }

        public override string Title => "Весовая категория";

        public ObservableCollection<Participant> Participants { get; set; }

        public override bool IsValid()
        {
            return true;
        }

        

    }
}
