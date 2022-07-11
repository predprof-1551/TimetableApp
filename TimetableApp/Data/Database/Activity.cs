using System;
using System.Collections.Generic;

namespace TimetableApp.Data.Database
{
    public partial class Activity
    {
        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public byte Rcolor { get; set; }
        public byte Gcolor { get; set; }
        public byte Bcolor { get; set; }
        public TimeSpan TimeStart { get; set; }
        public long TimetableId { get; set; }
        public TimeSpan TimeEnd { get; set; }

        public virtual Timetable Timetable { get; set; } = null!;
    }
}
