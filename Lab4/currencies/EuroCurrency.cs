using System;
namespace Lab4.currencies
{
    /// <summary>
    /// Класс, реализующий денежную единицу евро
    /// </summary>
    public class EuroCurrency : Currency
    {
        public string GetName()
        {
            return "EUR";
        }

        public string GetSign()
        {
            return "€";
        }
    }
}
