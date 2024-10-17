using System.Threading.Tasks;
using webScanner.Models.TokenAuth;
using webScanner.Web.Controllers;
using Shouldly;
using Xunit;

namespace webScanner.Web.Tests.Controllers
{
    public class HomeController_Tests: webScannerWebTestBase
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