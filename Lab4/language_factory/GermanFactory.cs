using System;
using Lab4.currencies;
using Lab4.languages;
using Lab4.resources;

namespace Lab4.language_factory
{
    public class GermanFactory : LanguageFactory
    {
        public override Currency GetCurrency()
        {
            return new EuroCurrency();
        }

        public override Language GetLanguage()
        {
            return new GermanLanguage();
        }

        public override Resources GetResources()
        {
            return new GermanResources();
        }
    }
}
