using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using CareProviderPortal.Authorization.Users;
using CareProviderPortal.MultiTenancy;

namespace CareProviderPortal.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}