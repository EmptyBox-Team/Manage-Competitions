using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace Models.Services.DialogServices
{
    public interface IDialog
    {
        object DataContext { get; set; }
        bool? DialogResult { get; set; }
        Window Owner { get; set; }
        bool? ShowDialog();
        void Close();
    }
}
