using System;
using System.Collections.Generic;
using System.Text;

namespace StageTimer
{
    [Serializable]
    class TimeSlotEventList
    {
        public List<TimeSlotEvent> TimeSlotEvents { get; set; } = new List<TimeSlotEvent>();

        public void LoadFile(string filePath)
        {

        }

        public void SaveFile(string filePath)
        {

        }
    }

    [Serializable]
    class TimeSlotEvent
    {
        public DateTime StartTime { get; set; } = DateTime.Now;
        public DateTime EndTime { get; set; } = DateTime.Now.AddHours(1);
        public String Name { get; set; } = "Act Name";
        public int WarningTime { get; set; } = 5;
    }
}
