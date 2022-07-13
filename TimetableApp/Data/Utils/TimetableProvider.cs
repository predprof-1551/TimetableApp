using TimetableApp.Data.Database;
using TimetableApp.Utils;

namespace TimetableApp.Data.Utils;

public class TimetableProvider : ITimetableProvider
{
    public Task<IEnumerable<Timetable>> GetTimetablesAsync(DateOnly dateStart, DateOnly dateEnd)
    {
        throw new NotImplementedException();
    }

    public Task<Timetable> CreateTimetableAsync(TimetableBuilder timetableBuilder)
    {
        throw new NotImplementedException();
    }

    public Task<Timetable> EditTimetableAsync(long timetableId, TimetableEditor editor)
    {
        throw new NotImplementedException();
    }

    public Task DeleteTimetableAsync(long timetableId)
    {
        throw new NotImplementedException();
    }
}