using System.Threading.Tasks;
using Metech.SimpleWebApp.Models.TokenAuth;
using Metech.SimpleWebApp.Web.Controllers;
using Shouldly;
using Xunit;

namespace Metech.SimpleWebApp.Web.Tests.Controllers
{
    public class HomeController_Tests: SimpleWebAppWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}