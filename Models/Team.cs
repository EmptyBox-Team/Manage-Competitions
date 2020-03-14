using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Team 
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public IEnumerable<Participant> Participants { get; set; }
    }
}
