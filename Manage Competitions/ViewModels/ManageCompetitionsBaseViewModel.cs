using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Competitions.ViewModels
{
    public abstract class ManageCompetitionsBaseViewModel : NotifyModelBase
    {
        public abstract string Title { get; }
        public abstract bool IsValid();
        bool _isCurrentPage;
        public bool IsCurrentPage
        {
            get
            {
                return _isCurrentPage;
            }
            set
            {
                if (value == _isCurrentPage)
                    return;
                _isCurrentPage = value;
                OnPropertyChanged();
            }
        }

    }
}
