using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public interface IRound
    {
        IDictionary<Participant, Participant> Rivals { get; set; }
    }
}
