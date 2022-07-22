using TimetableApp.Data.Database;
using TimetableApp.Utils;

namespace TimetableApp.Data.Utils;

public class TimetableProvider : ITimetableProvider
{
    public Task<IEnumerable<Timetable>> GetTimetablesAsync(DateOnly dateStart, DateOnly dateEnd)
    {
        using TimetableDbContext db = new TimetableDbContext();

        var getTimetable = new List<Timetable>();
        var date = dateStart;

        while (dateStart <= date && date <= dateEnd)
        {
            var TimetableExemplar = db.Timetables.FirstOrDefault(item => item.Date == new DateTime(date.Year, date.Month, date.Day));
            if (TimetableExemplar != null)
            {
                getTimetable.Add(TimetableExemplar);
            }
            date.AddDays(1);
        }

        return Task.FromResult<IEnumerable<Timetable>>(getTimetable);
    }

    public Task<Timetable> CreateTimetableAsync(TimetableBuilder timetableBuilder)
    {
        using TimetableDbContext db = new TimetableDbContext();

        var timetables = db.Timetables.Select(item => item).ToArray();
        var timetableExemplar = timetableBuilder.Build();

        if (TimetablesConflictDetector.ConflictExists(timetableExemplar, timetables))
        {
            db.Timetables.Add(timetableExemplar);
            db.SaveChanges();
        }

        return Task.FromResult(timetableExemplar);
    }

    public Task<Timetable> EditTimetableAsync(long timetableId, TimetableEditor editor)
    {
        using TimetableDbContext db = new TimetableDbContext();

        var TimetableExemplar = db.Timetables.FirstOrDefault(item => item.Id == timetableId);

        editor.Edit(TimetableExemplar);
        db.Timetables.Update(TimetableExemplar);
        db.SaveChanges();

        return Task.FromResult(TimetableExemplar);
    }

    public Task DeleteTimetableAsync(long timetableId)
    {
        using TimetableDbContext db = new TimetableDbContext();

        var TimetableExemplar = db.Timetables.FirstOrDefault(item => item.Id == timetableId);
        db.Timetables.Remove(TimetableExemplar);
        db.SaveChanges();

        return Task.FromResult(TimetableExemplar);
    }
}