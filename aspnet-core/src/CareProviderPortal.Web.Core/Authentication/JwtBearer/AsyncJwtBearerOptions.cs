using System.Collections.Generic;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace CareProviderPortal.Web.Authentication.JwtBearer
{
    public class AsyncJwtBearerOptions : JwtBearerOptions
    {
        public readonly List<IAsyncSecurityTokenValidator> AsyncSecurityTokenValidators;
        
        private readonly CareProviderPortalAsyncJwtSecurityTokenHandler _defaultAsyncHandler = new CareProviderPortalAsyncJwtSecurityTokenHandler();

        public AsyncJwtBearerOptions()
        {
            AsyncSecurityTokenValidators = new List<IAsyncSecurityTokenValidator>() {_defaultAsyncHandler};
        }
    }

}
