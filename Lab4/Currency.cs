using System;
namespace Lab4
{
    public interface Currency
    {
        /// <summary>
        /// Метод, возвращающий знак денежной единицы
        /// </summary>
        /// <returns>Возвращает знак денежной единицы</returns>
        string GetSign();

        /// <summary>
        /// Метод, возвращающий название денежной единицы
        /// </summary>
        /// <returns>Возвращает название денежной единицы</returns>
        string GetName();
    }
}
