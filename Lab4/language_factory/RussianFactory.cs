using System;
using Lab4.currencies;
using Lab4.languages;
using Lab4.resources;

namespace Lab4.language_factory
{
    public class RussianFactory : LanguageFactory
    {
        public override Currency GetCurrency()
        {
            return new RubleCurrency();
        }

        public override Language GetLanguage()
        {
            return new RussianLanguage();
        }

        public override Resources GetResources()
        {
            return new RussianResources();
        }
    }
}
