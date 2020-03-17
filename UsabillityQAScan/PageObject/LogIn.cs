using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsabillityQAScan.TestData;

namespace UsabillityQAScan.PageObject
{
    public class LogIn

    {

        private IWebDriver _driver;

        public LogIn(IWebDriver driver)
        {
            _driver = driver;
        }
        private IWebElement LoginInput => _driver.FindElement(By.Id("login-email"));
        private IWebElement PasswordInput => _driver.FindElement(By.Id("login-password"));
        private IWebElement ClickLogin => _driver.FindElement(By.XPath("*//form/fieldset[3]/button"));
       
        public void FillOutLoginData(LoginData logInf)
        {
            LoginInput.SendKeys(logInf.LoginName);
            PasswordInput.SendKeys(logInf.LoginPassw);

        }
        public void ClickLoginButton()
        {
            ClickLogin.Click();
        }



    }

}
