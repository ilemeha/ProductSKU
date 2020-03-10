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
        private IList<IWebElement> ProductPluginTitle => _driver.FindElements(By.XPath("//div[@class='isp_product_info']/a/div[@class='isp_product_title']"));
        //private IList<IWebElement> ProductPluginTitle => _driver.FindElements(By.XPath("//div[2]/a/div"));
        
        //private IList<IWebElement> ProductPluginTitle => _driver.FindElements(By.XPath("//*[@id='isp_search_results_container']/li/div[2]/a/div"));
        private IWebElement ProductTitle2 => _driver.FindElement(By.XPath("//div[@class='h5 sub_title']/a"));
        private IWebElement ResultNumbers => _driver.FindElement(By.Id("isp_results_summary_total_results"));
        



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
        
        public string GetResultNumbers()
        {
            return ResultNumbers.Text;
        }

        public int GetSearchResultProductsCount()
        {
            return ProductPluginTitle.Count;

        }
     
        public void OpenFirstSearchResult()
        {
            ProductPluginTitle.First().Click();
        }

        public void GotoProductPage()
        {
            ProductTitle2.Click();
        }
    }

}
