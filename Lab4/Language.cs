using System;
namespace Lab4
{
    /// <summary>
    /// Класс, инкапсулирующий информацию о языке
    /// </summary>
    public interface Language
    {
        /// <summary>
        /// Метод, возвращающий текущий язык
        /// </summary>
        /// <returns>Возвращает текущий язык</returns>
        string GetLanguage();
    }
}
