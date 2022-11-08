using System.Collections.Generic;

namespace CareProviderPortal.DynamicEntityProperties
{
    public interface IDynamicEntityPropertyDefinitionAppService
    {
        List<string> GetAllAllowedInputTypeNames();

        List<string> GetAllEntities();
    }
}
