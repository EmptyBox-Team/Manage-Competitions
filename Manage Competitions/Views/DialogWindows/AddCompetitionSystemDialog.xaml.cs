using Models.Services.DialogServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Manage_Competitions.Views.DialogWindows
{
    /// <summary>
    /// Логика взаимодействия для AddCompetitionSystemDialog.xaml
    /// </summary>
    public partial class AddCompetitionSystemDialog : Window, IDialog
    {
        public AddCompetitionSystemDialog()
        {
            InitializeComponent();
        }
    }
}
