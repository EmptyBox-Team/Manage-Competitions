using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace Models.Services.DialogServices
{
    public class DialogService : IDialogService, IDialogRequestClose
    {
        private readonly Window _owner;

        public DialogService(Window owner)
        {
            _owner = owner;
            Mappings = new Dictionary<Type, Type>();
        }

        public IDictionary<Type, Type> Mappings { get; }

        public event EventHandler<DialogCloseRequestedEventArgs> CloseRequested;

        public void Register<TViewModel, TView>()
            where TViewModel : IDialogRequestClose where TView : IDialog

        {
            if (Mappings.ContainsKey(typeof(TViewModel)))
            {
                throw new ArgumentException($"Type {typeof(TViewModel)} is already mapped to type {typeof(TView)} ");
            }

            Mappings.Add(typeof(TViewModel), typeof(TView));
        }

        public bool? ShowDialog<TViewModel>(TViewModel viewModel) where TViewModel : IDialogRequestClose
        {
            Type viewType = Mappings[typeof(TViewModel)];

            IDialog dialog = (IDialog)Activator.CreateInstance(viewType);

            EventHandler<DialogCloseRequestedEventArgs> handler = null;

            handler = (sender, e) =>
            {
                viewModel.CloseRequested -= handler;

                if (e.DialogResult.HasValue)
                {
                    dialog.DialogResult = e.DialogResult;
                }
                else
                {
                    dialog.Close();
                }

                viewModel.CloseRequested += handler;
                dialog.DataContext = viewModel;
                dialog.Owner = _owner;
            };
            return dialog.ShowDialog();
        }
    }
}
