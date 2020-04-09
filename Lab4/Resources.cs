using System;
namespace Lab4
{
    /// <summary>
    /// Класс, инкапсулирующий информацию о строковых ресурсах
    /// </summary>
    public interface Resources
    {
        /// <summary>
        /// Метод, возвращающий название приложения
        /// </summary>
        /// <returns>Возвращает название приложения</returns>
        string GetApplicationName();
    }
}
