using TimetableApp.Data.Database;
using TimetableApp.Utils;

namespace TimetableApp.Data.Utils;

public interface ITimetableProvider
{
    Task<IEnumerable<Timetable>> GetTimetablesAsync(DateOnly dateStart, DateOnly dateEnd);
    Task<Timetable> CreateTimetableAsync(TimetableBuilder timetableBuilder);    
    Task<Timetable> EditTimetableAsync(long timetableId, TimetableEditor editor);
    Task DeleteTimetableAsync(long timetableId);
}