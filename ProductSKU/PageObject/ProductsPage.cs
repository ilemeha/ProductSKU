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
    public class ProductsPage
    {
        private IWebDriver _driver;
        public ProductsPage(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement InputSKUinFilter => _driver.FindElement(By.XPath("(//li[@class='search_container']//input[@name='q'])[2]"));
        private IWebElement TitleSearch => _driver.FindElement(By.XPath("//h1[contains(.,'Search')]/parent::div"));
        private IList<IWebElement> ProductTitle => _driver.FindElements(By.XPath("//div[@class='h5 sub_title']/a"));

        //*[@id="shopify-section-product-template"]/div[1]/div[2]/div/div/div[1]/div[2]/p[2]/span[1]/span/span

        /*public string VerifyPageOpened()
        {
            return PageTitleVerify.Text;
        }    */
        // Type Prduct SKU in Search filter field
        public void SearchSKUNumber(string product)
        {
            InputSKUinFilter.SendKeys(product);

            InputSKUinFilter.SendKeys(Keys.Enter);
        }

        public string VerifySearchTitle()
        {
            return TitleSearch.Text;
        }

        public int GetSearchResultProductsCount()
        {
            return ProductTitle.Count;
        }

        public void OpenFirstSearchResult()
        {
            ProductTitle.First().Click();
        }
    }

}
