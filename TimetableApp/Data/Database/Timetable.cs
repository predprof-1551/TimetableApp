using System;
using System.Collections.Generic;

namespace TimetableApp.Data.Database
{
    public partial class Timetable
    {
        public Timetable()
        {
            Activities = new HashSet<Activity>();
        }

        public long Id { get; set; }
        public string? Description { get; set; }
        public DateTime Date { get; set; }
        public int RetryRate { get; set; }

        public virtual ICollection<Activity> Activities { get; set; }
    }
}
