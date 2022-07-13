using TimetableApp.Data.Database;

namespace TimetableApp.Utils;

/// <summary>
/// Позволяет создать новый объект класса <see cref="Activity"/>
/// </summary>
public class ActivityBuilder
{
    /// <summary>
    /// Добавляет название к активности
    /// </summary>
    /// <param name="name">Название активности</param>
    public ActivityBuilder WithName(string name)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Добавляет описание к активности
    /// </summary>
    /// <param name="description">Описание активности</param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public ActivityBuilder WithDescription(string description)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Устанавливает цвет активности
    /// </summary>
    /// <param name="r">Красный байт</param>
    /// <param name="g">Зеленый байт</param>
    /// <param name="b">Синий байт</param>
    public ActivityBuilder WithColor(byte r, byte g, byte b)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Устанавливает время начала активности
    /// </summary>
    /// <param name="time">Время</param>
    public ActivityBuilder WithTimeStart(TimeOnly time)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Устанавливает время окончания активности
    /// </summary>
    /// <param name="time">Время</param>
    public ActivityBuilder WithTimeEnd(TimeOnly time)
    {
        throw new NotImplementedException();
    }
    
    /// <summary>
    /// Создает новый экземляр класса <see cref="Activity"/> на основе использования использованных методов
    /// </summary>
    public Activity Build()
    {
        throw new NotImplementedException();
    }
}