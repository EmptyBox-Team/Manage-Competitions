using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Linq;
using System.Collections.Specialized;
using Models.CompetitionSystems;

namespace Models
{
    public class Competition : NotifyModelBase
    {
        #region Private_prop
        private ObservableCollection<ICompetitionSystem> _competitions;
        private ObservableCollection<Participant> _participants;
        private string _name;
        private string _place;
        private DateTime _startTime;
        private DateTime _finishTime;
        private string _mainJudje;
        private string _mainSecretary;
        #endregion

        public ICollection<ICompetitionSystem> Competitions
        {
            get => _competitions;
        }
        public ICollection<Participant> Participants
        {
            get => _participants;
        }
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }
        public string Place
        {
            get => _place;
            set
            {
                _place = value;
                OnPropertyChanged();
            }
        }
        public DateTime StartTime
        {
            get => _startTime;
            set
            {
                _startTime = value;
                OnPropertyChanged();
            }
        }
        public DateTime FinishTime
        {
            get => _finishTime;
            set
            {
                _finishTime = value;
                OnPropertyChanged();
            }
        }
        public string MainJudje
        {
            get => _mainJudje;
            set
            {
                _mainJudje = value;
                OnPropertyChanged();
            }
        }
        public string MainSecretaty
        {
            get => _mainSecretary;
            set
            {
                _mainSecretary = value;
                OnPropertyChanged();
            }
        }

        public Competition()
        {
            _competitions = new ObservableCollection<ICompetitionSystem>();
            _participants = new ObservableCollection<Participant>();
        }

        public void AddCompetionWieghtGroup(WeightCategory weight)
        {
            //var participants = Participants.Where(x => (x.Weight <= weight.Last && x.Weight >= weight.First)).ToList();
            //switch(competitionSystemType)
            //{
            //    case CompetitionSystemType.CIRCLE_TYPE:
            //        Competitions.Add(new CircleСompetition{ Participants = participants});
            //        break;
            //    case CompetitionSystemType.RETIREMEMTAFTER_TWO_LOSSES_SYSTEM:
            //        Competitions.Add(new RetirementAfterTwoLossesSystem { Participants = participants });
            //        break;
            //}
        }

        public void AddParticipant(Participant participant)
        {
            Participants.Add(participant);
        }

    }
}
