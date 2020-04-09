using System;
namespace Lab4.currencies
{
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
