using System;
using System.Collections.Generic;
using System.Text;

namespace StageTimer
{
   [Serializable]
    class TimeSlotEventList
    {
        
    }

    [Serializable]
    class TimeSlotEvent
    {
        DateTime StartTime;
        DateTime EndTime;
        String Name;
        int WarningTime;
    }
}
