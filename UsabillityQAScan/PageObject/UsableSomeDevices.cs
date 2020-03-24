using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UsabillityQAScan.PageObject
{
    public class UsableSomeDevices
    {
        private IWebDriver _driver;
        public UsableSomeDevices(IWebDriver driver) {
            _driver = driver;
        }
        private IWebElement WhirlpoolBtn => _driver.FindElement(By.XPath("//a[contains(text(),'Whirlpool')]"));
        
        private IWebElement NewQuickTestBtn => _driver.FindElement(By.XPath("//a[contains(text(),'New quick test')]"));
        private IWebElement TypePageName => _driver.FindElement(By.Id("editor-basic-name"));
        private IWebElement TypePageURL => _driver.FindElement(By.XPath("//fieldset[2]/div[2]/input"));
        private IWebElement LocateToDropdown => _driver.FindElement(By.XPath("//fieldset[@class='magical-dropdown dropdown']"));
        //Desktop
        //0.Chrome 78 (Windows)
        //1.Edge (Windows)
        //2. Firefox 53 (Windows)
        //3.  Internet Explorer 11 (Windows)'
        //4. Safari 13 (macOS)
        //Mobile
        //5.Apple iPad 7th generation (iOS 13)
        //6. Apple iPad Pro 11 inches (iOS 13) 
        //7.Apple iPhone 11 Pro (iOS 13)
        //8.Apple iPhone 11 Pro Max (iOS 13)
        //9. Apple iPhone 8 (iOS 13)
        //10. Google Pixel 4
        //11. OnePlus 7T Pro
        //12. Samsung A50
        //13. Samsung Galaxy S10
        //14. UsableNet API HTTP Client

        private IWebElement CreateBbtn => _driver.FindElement(By.XPath("//button[@type='submit']"));

        private IWebElement ScanedPageName => _driver.FindElement(By.XPath("//a[@class='item-name-label']"));
      
        private IWebElement CloseRecentUrl => _driver.FindElement(By.XPath("//a[@title='Close editor']"));

        public void ClickWhirpoolButton()
        {
            WhirlpoolBtn.Click();
        }

        public void ClickNewQuickTestButton()
        {
            NewQuickTestBtn.Click();
        }
        public void TypeProjectName(string project1)
        {
            TypePageName.SendKeys(project1);
        }

        public void TypeProjectURL(string projectURL)
        {
            TypePageURL.SendKeys(projectURL);
        }
        public void ClickDropdownButton()
        {
            LocateToDropdown.Click();
            Thread.Sleep(2000);
            _driver.FindElement(By.Id("label-device-picker-0")).Click();
        }
        public void ClickDropdownButton1()
        {
            LocateToDropdown.Click();
            Thread.Sleep(2000);
            _driver.FindElement(By.Id("label-device-picker-1")).Click();
        }

        public void ClickDropdownButton2()
        {
            LocateToDropdown.Click();
            Thread.Sleep(2000);
            _driver.FindElement(By.Id("label-device-picker-2")).Click();
        }
        public void ClickDropdownButton3()
        {
            LocateToDropdown.Click();
            Thread.Sleep(2000);
            _driver.FindElement(By.Id("label-device-picker-3")).Click();
        }
        public void ClickDropdownButton4()
        {
            LocateToDropdown.Click();
            Thread.Sleep(2000);
            _driver.FindElement(By.Id("label-device-picker-4")).Click();
        }
        //Mobile
        public void ClickDropdownButton5()
        {
            LocateToDropdown.Click();
            Thread.Sleep(2000);
            _driver.FindElement(By.Id("label-device-picker-5")).Click();
        }
        public void ClickDropdownButton6()
        {
            LocateToDropdown.Click();
            Thread.Sleep(2000);
            _driver.FindElement(By.Id("label-device-picker-6")).Click();
        }
        public void ClickDropdownButton7()
        {
            LocateToDropdown.Click();
            Thread.Sleep(2000);
            _driver.FindElement(By.Id("label-device-picker-7")).Click();
        }
        public void ClickDropdownButton8()
        {
            LocateToDropdown.Click();
            Thread.Sleep(2000);
            _driver.FindElement(By.Id("label-device-picker-8")).Click();
        }
        public void ClickDropdownButton9()
        {
            LocateToDropdown.Click();
            Thread.Sleep(2000);
            _driver.FindElement(By.Id("label-device-picker-9")).Click();
        }
        public void ClickDropdownButton10()
        {
            LocateToDropdown.Click();
            Thread.Sleep(2000);
            _driver.FindElement(By.Id("label-device-picker-10")).Click();
        }
        public void ClickDropdownButton12()
        {
            LocateToDropdown.Click();
            Thread.Sleep(2000);
            _driver.FindElement(By.Id("label-device-picker-12")).Click();
        }
        public void ClickDropdownButton13()
        {
            LocateToDropdown.Click();
            Thread.Sleep(2000);
            _driver.FindElement(By.Id("label-device-picker-13")).Click();
        }
        public void ClickCreateButton()
        {
            CreateBbtn.Click();
        }

        public void OpenScanedPageName()
        {
            ScanedPageName.Click();
            string url = _driver.Url;
            Console.WriteLine($" {url} ");
        }
        public void CloseScanedPage()
        {
            CloseRecentUrl.Click();
        }



    }
}
