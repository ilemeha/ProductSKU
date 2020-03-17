using NUnit.Framework;
using PUsabillityQAScan.WebDriver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UsabillityQAScan.Configuration;
using UsabillityQAScan.PageObject;
using UsabillityQAScan.TestData;

namespace UsabillityQAScan.UTestScripts
{
    [TestFixture]
    public class LoginTest
    {
        [Test]
         public void LoginInPage()
         {
          var loginInfo = new LoginData();

             using (var driver = DriverUtils.CreateWebDriver())
             {
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                    driver.Navigate().GoToUrl(Config.GetUrl());
                    //driver.Navigate().GoToUrl(Config.GetUrl(driver));

                    var loginAccessPage = new LogIn(driver);
                    loginAccessPage.FillOutLoginData(loginInfo);
                    loginAccessPage.ClickLoginButton();
                   // loginAccessPage.GetClientPageTitle().ShouldBe("Clients");
                    //loginAccessPage.GetAdminLink().ShouldBe("admin");
                   // loginAccessPage.ClickLogoutButton();
                  //  loginAccessPage.CheckLoginPageTitle().ShouldBe("Login");

                    //TODO: this is useless. Plese remove.
                   Thread.Sleep(5000);
                
             }
         }
    }
}
