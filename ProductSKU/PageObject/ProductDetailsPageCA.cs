using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProductSKU.PageObject
{
    public class ProductDetailsPageCA
    {
        private IWebDriver _driver;

        public ProductDetailsPageCA(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement VerifySKU => _driver.FindElement(By.XPath("//p[@class='sku']/span"));
        private IWebElement CurrentPrice => _driver.FindElement(By.XPath("//span[@class='current_price']/span[@class='money']"));
        private IList<IWebElement> ColorOptions => _driver.FindElements(By.CssSelector(".section.product_section.clearfix.js-product_section .swatch_options .color.available"));

        public string GetProductDetailsSKUNumber()
        {
            return VerifySKU.Text;
        }

        public string GetProductDetailsCurrentPrice()
        {
            return CurrentPrice.Text;
        }

        public IList<IWebElement> GetColorOptions()
        {
            return ColorOptions;
        }
    }
}
