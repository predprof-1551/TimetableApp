using TimetableApp.Data.Database;

namespace TimetableApp;

public static class TimetableExtensions
{
    /// <summary>
    /// Вычисляет дату через определенное количество циклов
    /// </summary>
    /// <param name="timetable">Исходное расписание для вычислений</param>
    /// <param name="cycles">Количество циклов</param>
    /// <returns>Дата</returns>
    public static DateOnly CalculateByRetryDate(this Timetable timetable, int cycles)
    {
        var result = timetable.Date.AddDays(cycles * timetable.RetryRate);
        return new DateOnly(result.Year, result.Month, result.Day);
    }

    /// <summary>
    /// Проверяет наличие даты в расписании
    /// </summary>
    /// <param name="timetable">Исходное расписание для вычислений</param>
    /// <param name="date">Дата для проверки</param>
    /// <returns>True, если расписание содержит дату</returns>
    public static bool ContainsDate(this Timetable timetable, DateTime date)
    {
        var startOfYear = new DateTime(timetable.Date.Year, 1, 1); // 1 января
        var deltaMain = (date.Date - startOfYear).TotalDays;

        var fun = deltaMain / timetable.RetryRate;

        return Math.Abs(Math.Floor(fun) - fun) < 0.0001;
    }
}