using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Metech.SimpleWebApp.Localization
{
    public static class SimpleWebAppLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(SimpleWebAppConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(SimpleWebAppLocalizationConfigurer).GetAssembly(),
                        "Metech.SimpleWebApp.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
