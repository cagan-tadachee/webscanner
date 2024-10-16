﻿using System.Threading.Tasks;
using webscanner.Models.TokenAuth;
using webscanner.Web.Controllers;
using Shouldly;
using Xunit;

namespace webscanner.Web.Tests.Controllers
{
    public class HomeController_Tests: webscannerWebTestBase
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