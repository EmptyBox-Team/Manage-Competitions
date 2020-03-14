using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Models
{
    public class Participant : INotifyPropertyChanged
    {

        #region Private_props
        private int _Number;
        private string _Rank;
        private string _Gender;
        private string _FirstName;
        private string _LastName;
        private DateTime _Birthday;
        private int _Weight;
        private int _Score;
        private int _CountOfWin;
        private int _CountOfLosing;
        #endregion

        #region Public_props
        public int Number
        {
            get => _Number; 
            set
            {
                _Number = value;
                OnPropertyChanged();
            }
        }
        public string Rank
        {
            get => _Rank;
            set
            {
                _Rank = value;
                OnPropertyChanged();
            }
        }
        public string Gender 
        { 
            get => _Gender; 
            set
            {
                _Gender = value;
                OnPropertyChanged();
            }
        }
        public string FirstName 
        {
            get => _FirstName;
            set
            {
                _FirstName = value;
                OnPropertyChanged();
            }
        }
        public string LastName 
        { 
            get => _LastName;
            set
            {
                _LastName = value;
                OnPropertyChanged();
            }
        }
        public DateTime Birthday
        {
            get => _Birthday;
            set
            {
                _Birthday = value;
                OnPropertyChanged();
            }
        }
        public int Weight
        {
            get => _Weight;
            set
            {
                _Weight = value;
                OnPropertyChanged();
            }
        }
        public int Score 
        {
            get => _Score;
            set
            {
                _Score = value;
                OnPropertyChanged();
            }
        }
        public int CountOfWin 
        {
            get => _CountOfWin;
            set
            {
                _CountOfWin = value;
                OnPropertyChanged();
            }
        }
        public int CountOfLosing
        {
            get => _CountOfWin;
            set
            {
                _CountOfWin = value;
                OnPropertyChanged();
            }
        }
        #endregion



        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
