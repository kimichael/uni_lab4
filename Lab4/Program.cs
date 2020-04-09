using System;
using Lab4.language_factory;
using Lab4.languages;

namespace Lab4
{
    /// <summary>
    /// Класс, отвечающий за четвертую лабораторную работу по ТРПО
    /// </summary>
    class Program
    {
        /// <summary>
        /// Точка входа для приложения
        /// </summary>
        /// <param name="args">Список аргументов командной строки</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Lab4");
            Console.WriteLine("Choose your language/Выберите язык (ru/de/ch)");
            LanguageFactory factory;
            switch (Console.ReadLine())
            {
                case "ru":
                    factory = new RussianFactory();
                    break;
                case "de":
                    factory = new GermanFactory();
                    break;
                case "ch":
                    factory = new ChineseFactory();
                    break;
                default:
                    throw new ArgumentException("Unknown language");
            }
            Currency currency = factory.GetCurrency();
            Language language = factory.GetLanguage();
            Resources resources = factory.GetResources();
            Console.WriteLine($"Currency is {currency.GetName()}, sign = {currency.GetName()}");
            Console.WriteLine($"Language us {language.GetLanguage()}");
            Console.WriteLine($"Application name is {resources.GetApplicationName()}");
        }
    }
}
