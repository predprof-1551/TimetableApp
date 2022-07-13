using TimetableApp.Data.Database;

namespace TimetableApp.Utils;

public class TimetableEditor
{
    /// <summary>
    /// Указывает на то, что описание расписания изменилось
    /// </summary>
    /// <param name="description">Новое описание</param>
    public TimetableEditor WithDescription(string description)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Добавляет новую активность к расписанию
    /// </summary>
    /// <param name="activity"></param>
    public TimetableEditor WithActivity(ActivityBuilder activity)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Удаляет активность из расписания
    /// </summary>
    /// <param name="activity">Объект, который нужно удалить</param>
    public TimetableEditor WithoutActivity(Activity activity)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Изменяет период зацикливания
    /// </summary>
    /// <param name="retryRate">Новый период зацикливания</param>
    public TimetableEditor WithRetry(int retryRate)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Изменяет дату начала отсчета
    /// </summary>
    /// <param name="date">Новая дата</param>
    public TimetableEditor WithDate(DateOnly date)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Изменяет существущий объект в соответствии с методами
    /// </summary>
    /// <param name="timetable">Расписание</param>
    public void Edit(Timetable timetable)
    {
        throw new NotImplementedException();
    }
}