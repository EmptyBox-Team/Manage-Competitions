using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Manage_Competitions.Services.EnumItemSourceServices
{
    public enum CompetitionSystemType
    {
        [Description("Круговая система")]
        CIRCLE_TYPE,
        [Description("Система с выбыванием после двух поражений")]
        RETIREMEMTAFTER_TWO_LOSSES_SYSTEM,
        [Description("Олимпийская система")]
        OLIMPICK_SYSTEM
    }
}
