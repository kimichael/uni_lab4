using System;
namespace Lab4.currencies
{
    /// <summary>
    /// Класс, реализующий денежную единицу юань
    /// </summary>
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
