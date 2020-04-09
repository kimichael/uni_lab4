using System;
namespace Lab4
{
    public abstract class LanguageFactory
    {
        /// <summary>
        /// Метод, возвращающий объект для выдачи текущего языка
        /// </summary>
        /// <returns>Возвращает объект Language, который содержит информацию о текущем языке</returns>
        public abstract Language GetLanguage();

        /// <summary>
        /// Метод, возвращающий объект для выдачи текущей денежной единицы
        /// </summary>
        /// <returns>Возвращает объект Currency, который содержит информацию по денежной единице фабрики</returns>
        public abstract Currency GetCurrency();

        /// <summary>
        /// Метод, возвращающий объект для выдачи строк, нужного для приложения
        /// </summary>
        /// <returns>Возвращает объект Resources, который содержит строки языка фабрики</returns>
        public abstract Resources GetResources();
    }
}
