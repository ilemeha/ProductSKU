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
    public class UsableAllDevices
    {
        private IWebDriver _driver;
        public UsableAllDevices(IWebDriver driver) {
            _driver = driver;
        }
        private IWebElement NewQuickTestBtn => _driver.FindElement(By.XPath("//a[contains(text(),'New quick test')]"));
        private IWebElement TypePageName => _driver.FindElement(By.Id("editor-basic-name"));
        private IWebElement TypePageURL => _driver.FindElement(By.XPath("//fieldset[2]/div[2]/input"));
        private IWebElement LocateToDropdown => _driver.FindElement(By.XPath("//fieldset[@class='magical-dropdown dropdown']"));
        //private SelectElement PickUpDevice => new SelectElement(_driver.FindElement(By.XPath("//div[@class='dropdown device-picker-device open']/div[@class='dropdown-menu']/button[@class='dropdown-item'][2]/span[2]")));
        //*[@id="application-main-content"]/article/div[3]/div/div[2]/div/div[2]/div/div/fieldset[3]/div[2]/div[1]/div/button[4]/span[2]
        //dropdown device-picker-device open
        //1. Apple iPad 7th generation (iOS 13)
        //2. Apple iPad Pro 11 inches (iOS 13) .dropdown-item:nth-child(2) > .device-picker-picked-label
        //or //span[contains(.,'Apple iPad Pro 11 inches (iOS 13)')]
        //3.Apple iPhone 11 Pro (iOS 13)
        //4.Apple iPhone 11 Pro Max (iOS 13)
        //5. Apple iPhone 8 (iOS 13)
        //6.Chrome 78 (Windows)
        //7.Edge (Windows)
        //8. Firefox 53 (Windows)
        //9. Google Pixel 4
        //10.  Internet Explorer 11 (Windows)
        //11. OnePlus 7T Pro
        //12. Safari 13 (macOS)
        //13. Samsung A50
        //.14 Samsung Galaxy S10
        //15. UsableNet API HTTP Client
        //Btn "Create" - //*[@id="application-main-content"]/article/div[3]/div/div[2]/div/div[3]/button[2]
        //css=.btn-success  or xpath=//button[@type='submit']  or xpath=//button[contains(.,'Create')]
        //to click on link  css=.processing-success:nth-child(1) .link-tr-name  OR  linkText=MATY


        private IWebElement CreateBbtn => _driver.FindElement(By.XPath("//button[@type='submit']"));

        private IWebElement CopyRecentScanURL => _driver.FindElement(By.XPath("//a[@class='item-name-label']"));
      
        private IWebElement CloseRecentUrl => _driver.FindElement(By.XPath("//a[@title='Close editor']"));

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
           
           // var js = (IJavaScriptExecutor)_driver;
           // js.ExecuteScript("document.getElementById('dropdown-toggle-device-picker').dispatchEvent(new Event('mousedown'))");
            
            _driver.FindElement(By.Id("label-device-picker-11")).Click();
        }


        public string[] GetDevicesList()
        {
            var elements = _driver.FindElements(By.XPath("//a[contains(@id, 'label-device-picker-')]/span"));
            return elements.Select(element => element.Text).ToArray();
        }

        public void SelectDevice(int number)
        {
            var js = (IJavaScriptExecutor)_driver;
            js.ExecuteScript("document.getElementById('dropdown-toggle-device-picker').dispatchEvent(new Event('mousedown'))");
            _driver.FindElement(By.Id($"label-device-picker-{number}")).Click();
        }

        public void ClickCreateButton()
        {
            CreateBbtn.Click();
        }

        public void CopySaveURL()
        {
            CopyRecentScanURL.Click();
            
        }
        public void CloseIndividualPage()
        {
            CloseRecentUrl.Click();
        }



    }
}
