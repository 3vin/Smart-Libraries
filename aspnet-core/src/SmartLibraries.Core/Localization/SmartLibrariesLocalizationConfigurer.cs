using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace SmartLibraries.Localization
{
    public static class SmartLibrariesLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(SmartLibrariesConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(SmartLibrariesLocalizationConfigurer).GetAssembly(),
                        "SmartLibraries.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
