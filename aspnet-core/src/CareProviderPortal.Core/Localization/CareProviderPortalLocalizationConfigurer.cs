using System.Reflection;
using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace CareProviderPortal.Localization
{
    public static class CareProviderPortalLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(
                    CareProviderPortalConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(CareProviderPortalLocalizationConfigurer).GetAssembly(),
                        "CareProviderPortal.Localization.CareProviderPortal"
                    )
                )
            );
        }
    }
}