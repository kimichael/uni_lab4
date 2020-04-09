using System;
namespace Lab4.currencies
{
    /// <summary>
    /// Класс, реализующий денежную единицу рубль
    /// </summary>
    public class RubleCurrency : Currency
    {
        public string GetName()
        {
            return "RUB";
        }

        public string GetSign()
        {
            return "₽";
        }
    }
}
