using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace SchoolAwesome.Localization
{
    public static class SchoolAwesomeLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(SchoolAwesomeConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(SchoolAwesomeLocalizationConfigurer).GetAssembly(),
                        "SchoolAwesome.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
