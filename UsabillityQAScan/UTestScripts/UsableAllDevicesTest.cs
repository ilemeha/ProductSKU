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
    public class UsableAllDevicesTest
    {
        [Test]
         public void UsableAllDevices()
         {
             var loginInfo = new LoginData();

             using (var driver = DriverUtils.CreateWebDriver())
             {
                 driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                 driver.Navigate().GoToUrl(Config.GetUrl());
                    
                 var loginAccessPage = new LogIn(driver);
                 loginAccessPage.FillOutLoginData(loginInfo);
                 loginAccessPage.ClickLoginButton();
                 Thread.Sleep(2000);
                
                 var dashboardPage = new UsableAllDevices(driver);

                 dashboardPage.ClickNewQuickTestButton();
                // Thread.Sleep(1000);

                
                var devices = dashboardPage.GetDevicesList();
                // dashboardPage.ClickCreateButton();

                 for (var deviceNumber = 0; deviceNumber < devices.Length; deviceNumber++)
                 {
                   // dashboardPage.ClickNewQuickTestButton();
                    //Thread.Sleep(1000);

                    dashboardPage.TypeProjectName("MTG Test Landing Page");
                    Thread.Sleep(2000);
                    dashboardPage.TypeProjectURL("https://www.maytag.com/faux-stage/dual-power-filtration.html");

                    Thread.Sleep(2000);
                    dashboardPage.SelectDevice(deviceNumber);

                    Thread.Sleep(2000);

                    dashboardPage.ClickCreateButton();
                    Thread.Sleep(20000);

                 }

                
            }
        }
    }
}
