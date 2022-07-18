using TimetableApp.Data.Database;

namespace TimetableApp.Utils;

/// <summary>
/// Позволяет создать новый объект класса <see cref="Timetable"/>
/// </summary>
public class TimetableBuilder
{
    /// <summary>
    /// Добавляет описание к расписанию
    /// </summary>
    /// <param name="description">Описание</param>
    public TimetableBuilder WithDescription(string description)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Добавляет активность к расписанию
    /// </summary>
    /// <param name="activity">Построитель активности</param>
    public TimetableBuilder WithActivity(ActivityBuilder activity)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Добавляет зацикливание к расписанию
    /// </summary>
    /// <param name="retryRate">Период зацикливания</param>
    public TimetableBuilder WithRetry(int retryRate)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Добавляет точку начала расписания в виде даты. От нее и будет отчитываться зацикливание
    /// </summary>
    /// <param name="date">Дата начала</param>
    public TimetableBuilder WithDate(DateOnly date)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Создает новый объект класса <see cref="Timetable"/> на основе использованных методов ранее
    /// </summary>
    public Timetable Build()
    {
        throw new NotImplementedException();
    }
}