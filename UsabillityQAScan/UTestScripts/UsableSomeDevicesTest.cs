using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using UsabillityQAScan.WebDriver;
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
    public class UsableSomeDevicesTest
    {
        [Test]
         public void UsableSomeDevices()
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
                
                 var dashboardPage = new UsableSomeDevices(driver);
                 var pageName = "Its Test8-032320";
                 var pageURL = "https://www.kitchenaid.com/countertop-appliances/blenders/blender-products.html";

                //Desktop runs
                // Console.WriteLine($"Desktop");
                // Console.WriteLine($"Chrome 78 (Windows)");
                //dashboardPage.ClickNewQuickTestButton();
                // dashboardPage.TypeProjectName(pageName);
                // Thread.Sleep(1000);
                // dashboardPage.TypeProjectURL(pageURL);
                // Thread.Sleep(1000);
                // dashboardPage.ClickDropdownButton();
                // Thread.Sleep(2000);
                // dashboardPage.ClickCreateButton();
                // Thread.Sleep(70000);
                // dashboardPage.OpenScanedPageName();
                // Thread.Sleep(3000);
                // dashboardPage.CloseScanedPage();
                // Thread.Sleep(3000);

                //Console.WriteLine($"Edge (Windows)");
                //dashboardPage.ClickNewQuickTestButton();
                // dashboardPage.TypeProjectName(pageName);
                // Thread.Sleep(1000);
                // dashboardPage.TypeProjectURL(pageURL);
                // Thread.Sleep(1000);
                // dashboardPage.ClickDropdownButton1();
                // Thread.Sleep(2000);
                // dashboardPage.ClickCreateButton();
                // Thread.Sleep(70000);
                // dashboardPage.OpenScanedPageName();
                // Thread.Sleep(3000);
                // dashboardPage.CloseScanedPage();
                // Thread.Sleep(3000);

                //Console.WriteLine($"Firefox 53 (Windows)");
                //dashboardPage.ClickNewQuickTestButton();
                //dashboardPage.TypeProjectName(pageName);
                //Thread.Sleep(1000);
                //dashboardPage.TypeProjectURL(pageURL);
                //Thread.Sleep(1000);
                //dashboardPage.ClickDropdownButton2();
                //Thread.Sleep(2000);
                //dashboardPage.ClickCreateButton();
                //Thread.Sleep(70000);
                //dashboardPage.OpenScanedPageName();
                //Thread.Sleep(3000);
                //dashboardPage.CloseScanedPage();
                //Thread.Sleep(3000);

                //Console.WriteLine($"Internet Explorer 11 (Windows)");
                //dashboardPage.ClickNewQuickTestButton();
                //dashboardPage.TypeProjectName(pageName);
                //Thread.Sleep(1000);
                //dashboardPage.TypeProjectURL(pageURL);
                //Thread.Sleep(2000);
                //dashboardPage.ClickDropdownButton3();
                //Thread.Sleep(2000);
                //dashboardPage.ClickCreateButton();
                //Thread.Sleep(70000);
                //dashboardPage.OpenScanedPageName();
                //Thread.Sleep(5000);
                //dashboardPage.CloseScanedPage();
                //Thread.Sleep(5000);

                Console.WriteLine($"Safari 13 (macOS)");
                dashboardPage.ClickNewQuickTestButton();
                dashboardPage.TypeProjectName(pageName);
                Thread.Sleep(1000);
                dashboardPage.TypeProjectURL(pageURL);
                Thread.Sleep(1000);
                dashboardPage.ClickDropdownButton4();
                Thread.Sleep(2000);
                dashboardPage.ClickCreateButton();
                Thread.Sleep(70000);
                dashboardPage.OpenScanedPageName();
                Thread.Sleep(3000);
                dashboardPage.CloseScanedPage();
                Thread.Sleep(3000);

                // Mobile and Ipads
                //Console.WriteLine($"Mobile devices and iPads");
                //Console.WriteLine($"Apple iPad 7th generation (iOS 13");
                //dashboardPage.ClickNewQuickTestButton();
                //dashboardPage.TypeProjectName(pageName);
                //Thread.Sleep(1000);
                //dashboardPage.TypeProjectURL(pageURL);
                //Thread.Sleep(1000);
                //dashboardPage.ClickDropdownButton5();
                //Thread.Sleep(2000);
                //dashboardPage.ClickCreateButton();
                //Thread.Sleep(70000);
                //dashboardPage.OpenScanedPageName();
                //Thread.Sleep(3000);
                //dashboardPage.CloseScanedPage();
                //Thread.Sleep(2000);

                //Console.WriteLine($"Apple iPad Pro 11 inches (iOS 13) ");
                //dashboardPage.ClickNewQuickTestButton();
                //dashboardPage.TypeProjectName(pageName);
                //Thread.Sleep(1000);
                //dashboardPage.TypeProjectURL(pageURL);
                //Thread.Sleep(1000);
                //dashboardPage.ClickDropdownButton6();
                //Thread.Sleep(2000);
                //dashboardPage.ClickCreateButton();
                //Thread.Sleep(70000);
                //dashboardPage.OpenScanedPageName();
                //Thread.Sleep(3000);
                //dashboardPage.CloseScanedPage();
                //Thread.Sleep(2000);

                Console.WriteLine($"Apple iPhone 11 Pro (iOS 13) ");
                dashboardPage.ClickNewQuickTestButton();
                dashboardPage.TypeProjectName(pageName);
                Thread.Sleep(1000);
                dashboardPage.TypeProjectURL(pageURL);
                Thread.Sleep(1000);
                dashboardPage.ClickDropdownButton7();
                Thread.Sleep(2000);
                dashboardPage.ClickCreateButton();
                Thread.Sleep(70000);
                dashboardPage.OpenScanedPageName();
                Thread.Sleep(3000);
                dashboardPage.CloseScanedPage();
                Thread.Sleep(2000);

                //Console.WriteLine($"Apple iPhone 11 Pro Max (iOS 13)");
                //dashboardPage.ClickNewQuickTestButton();
                //dashboardPage.TypeProjectName(pageName);
                //Thread.Sleep(1000);
                //dashboardPage.TypeProjectURL(pageURL);
                //Thread.Sleep(1000);
                //dashboardPage.ClickDropdownButton8();
                //Thread.Sleep(2000);
                //dashboardPage.ClickCreateButton();
                //Thread.Sleep(70000);
                //dashboardPage.OpenScanedPageName();
                //Thread.Sleep(3000);
                //dashboardPage.CloseScanedPage();
                //Thread.Sleep(2000);

                //Console.WriteLine($"Apple iPhone 8 (iOS 13)");
                //dashboardPage.ClickNewQuickTestButton();
                //dashboardPage.TypeProjectName(pageName);
                //Thread.Sleep(1000);
                //dashboardPage.TypeProjectURL(pageURL);
                //Thread.Sleep(1000);
                //dashboardPage.ClickDropdownButton9();
                //Thread.Sleep(2000);
                //dashboardPage.ClickCreateButton();
                //Thread.Sleep(70000);
                //dashboardPage.OpenScanedPageName();
                //Thread.Sleep(3000);
                //dashboardPage.CloseScanedPage();
                //Thread.Sleep(3000);

                //Console.WriteLine($"Google Pixel 4");
                //dashboardPage.ClickNewQuickTestButton();
                //dashboardPage.TypeProjectName(pageName);
                //Thread.Sleep(1000);
                //dashboardPage.TypeProjectURL(pageURL);
                //Thread.Sleep(1000);
                //dashboardPage.ClickDropdownButton10();
                //Thread.Sleep(2000);
                //dashboardPage.ClickCreateButton();
                //Thread.Sleep(70000);
                //dashboardPage.OpenScanedPageName();
                //Thread.Sleep(3000);
                //dashboardPage.CloseScanedPage();
                //Thread.Sleep(2000);

                //Console.WriteLine($"Samsung A50");
                //dashboardPage.ClickNewQuickTestButton();
                //dashboardPage.TypeProjectName(pageName);
                //Thread.Sleep(1000);
                //dashboardPage.TypeProjectURL(pageURL);
                //Thread.Sleep(1000);
                //dashboardPage.ClickDropdownButton12();
                //Thread.Sleep(2000);
                //dashboardPage.ClickCreateButton();
                //Thread.Sleep(70000);
                //dashboardPage.OpenScanedPageName();
                //Thread.Sleep(3000);
                //dashboardPage.CloseScanedPage();
                //Thread.Sleep(2000);

                //Console.WriteLine($"Samsung Galaxy S10");
                //dashboardPage.ClickNewQuickTestButton();
                //dashboardPage.TypeProjectName(pageName);
                //Thread.Sleep(1000);
                //dashboardPage.TypeProjectURL(pageURL);
                //Thread.Sleep(1000);
                //dashboardPage.ClickDropdownButton13();
                //Thread.Sleep(2000);
                //dashboardPage.ClickCreateButton();
                //Thread.Sleep(70000);
                //dashboardPage.OpenScanedPageName();
                //Thread.Sleep(3000);
                //dashboardPage.CloseScanedPage();
                //Thread.Sleep(2000);
                //Console.WriteLine($"Row #{rowNumber + 2}; SKU={sku};  salePrice={salePrice}");



            }
        }
    }
}
