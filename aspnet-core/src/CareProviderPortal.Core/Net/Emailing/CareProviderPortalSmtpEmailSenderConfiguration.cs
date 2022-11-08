using Abp.Configuration;
using Abp.Net.Mail;
using Abp.Net.Mail.Smtp;
using Abp.Runtime.Security;

namespace CareProviderPortal.Net.Emailing
{
    public class CareProviderPortalSmtpEmailSenderConfiguration : SmtpEmailSenderConfiguration
    {
        public CareProviderPortalSmtpEmailSenderConfiguration(ISettingManager settingManager) : base(settingManager)
        {

        }

        public override string Password => SimpleStringCipher.Instance.Decrypt(GetNotEmptySettingValue(EmailSettingNames.Smtp.Password));
    }
}