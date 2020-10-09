using Abp.AutoMapper;
using Metech.SimpleWebApp.Authentication.External;

namespace Metech.SimpleWebApp.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
