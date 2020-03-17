using NUnit.Framework;
using OpenQA.Selenium;
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
    public class DashboardTest
    {
        [Test]
         public void Dashboard()
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
                    Thread.Sleep(2000);
                    var dashboardPage = new DashboardPage(driver);
                    dashboardPage.ClickNewQuickTestButton();
                    Thread.Sleep(2000);
                    dashboardPage.TypeProjectName("MTG Test Landing Page");
                    Thread.Sleep(2000);
                    dashboardPage.TypeProjectURL("https://www.maytag.com/faux-stage/dual-power-filtration.html");

                Thread.Sleep(2000);
                dashboardPage.SelectDevice();


               Thread.Sleep(5000);
                //dashboardPage.SelectDeviceDropdown("Chrome 78 (Windows)");

                //IList<IWebElement> devicesPickOne = DevicePickUp.Options;
                // for (int i = 0; i < devicesPickOne.Count; i++)
                // { devicesPickOne[i].Click(); }

                //dashboardPage.ClickSubmitButton();
                //Thread.Sleep(80000);
                //dashboardPage.CopySaveURL();
                //Thread.Sleep(5000);
                //dashboardPage.CloseIndividualPage();
                //Thread.Sleep(5000);
            }
         }
    }
}
