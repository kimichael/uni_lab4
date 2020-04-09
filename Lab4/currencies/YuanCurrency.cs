using System;
namespace Lab4.currencies
{
    public class YuanCurrency : Currency
    {
        public string GetName()
        {
            return "CNY";
        }

        public string GetSign()
        {
            return "¥";
        }
    }
}
