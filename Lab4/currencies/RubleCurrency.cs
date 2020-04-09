using System;
namespace Lab4.currencies
{
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
