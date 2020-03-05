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
    public class ProductsPageCA
    {
        private IWebDriver _driver;
        public ProductsPageCA(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement InputSKUinFilter => _driver.FindElement(By.XPath("(//li[@class='search_container']//input[@name='q'])[2]"));
        private IWebElement TitleSearch => _driver.FindElement(By.XPath("//h1[contains(.,'Search')]/parent::div"));
        // private IList<IWebElement> ProductTitle => _driver.FindElements(By.XPath("//div[@class='isp_product_info']/a"));
        private IList<IWebElement> ProductTitle => _driver.FindElements(By.ClassName("isp_product_info"));


        // Type Prduct SKU in Search filter field
        public void SearchSKUNumber(string product)
        {
            InputSKUinFilter.SendKeys(product);

            InputSKUinFilter.SendKeys(Keys.Enter);

        }
        public void ClearSKUNumber() 
        { 
            InputSKUinFilter.Clear();
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
