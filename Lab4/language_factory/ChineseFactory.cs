using System;
using Lab4.currencies;
using Lab4.languages;
using Lab4.resources;

namespace Lab4.language_factory
{
    public class ChineseFactory : LanguageFactory
    {
        public override Currency GetCurrency()
        {
            return new YuanCurrency();
        }

        public override Language GetLanguage()
        {
            return new ChineseLanguage();
        }

        public override Resources GetResources()
        {
            return new ChineseResources();
        }
    }
}
