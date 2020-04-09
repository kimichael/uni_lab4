using System;
namespace Lab4
{
    public abstract class LanguageFactory
    {
        public abstract Language GetLanguage();

        public abstract Currency GetCurrency();

        public abstract Resources GetResources();
    }
}
