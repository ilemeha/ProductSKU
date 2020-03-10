using NUnit.Framework;
using ProductSKU.PageObject;
using ProductSKU.WebDriver;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using System.Threading;
using OpenQA.Selenium.Interactions;
using System.Windows;
using System.IO;
using ProductSKU.Configuration;

namespace ProductSKU.TestsScripts
{
    [TestFixture]
    public class GradiatorTestSKUCA
    {
        private static void Retry(Action action)
        {
            for (var retryNumber = 0; retryNumber < 3; retryNumber++)
            {
                try
                {
                    action();
                    break;
                }
                catch (Exception)
                {
                    if (retryNumber == 2) throw;
                    Thread.Sleep(TimeSpan.FromSeconds(2));
                }
            }
        }

        [Test]
        public void VerifyGradiatorTestSKUCA()
        {
            var pageLoadDelay = TimeSpan.FromSeconds(5);

            var pathToSkuFile = @"C:\Users\Iryna Lemeha\Downloads\Feb Sale Price Sheet - GDR - Sheet1.csv";
            var rows = File.ReadAllLines(pathToSkuFile).Skip(1).ToArray();

            var errors = new List<string>();

            using (var driver = DriverUtils.CreateWebDriver())
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(8);

                driver.Navigate().GoToUrl(Config.GetUrl());
                var products = new ProductsPageCA(driver);
                //rows.Length
                for (var rowNumber = 0; rowNumber < rows.Length; rowNumber++)
                {
                    var row = rows[rowNumber];
                    var cells = row.Split(',').Select(x => x.Trim()).ToArray();
                    var sku = cells[0];
                    var msrp = cells[1];
                    var salePrice = cells[2];
                    //Console.WriteLine($"Row #{rowNumber + 2}; SKU={sku};  salePrice={salePrice}");

                    //Thread.Sleep(TimeSpan.FromSeconds(1));
                    Thread.Sleep(pageLoadDelay);

                    products.SearchSKUNumber(sku);
                    //Thread.Sleep(pageLoadDelay);
                    //products.ClearSKUNumber();
                    //Retry(() => products.SearchSKUNumber(sku));
                    Thread.Sleep(pageLoadDelay); // we have to wait for the search results to refresh

                    var searchResultProductsCount = Convert.ToInt32(products.GetResultNumbers());
                    if (searchResultProductsCount == 0)
                    {
                        
                        //noResultsRows.Add(rowNumber, sku);
                        errors.Add($"NO Results in row #{rowNumber + 2}; SKU={sku}");
                        products.ClearSKUNumber();
                        continue;
                    }
                   
                    products.ClearSKUNumber();

                    if (searchResultProductsCount != 1)
                    {
                        errors.Add($"More than one product in search results #{rowNumber + 2}; SKU={sku}");
                        
                        continue;
                    }
                   // Thread.Sleep(pageLoadDelay);
                    products.OpenFirstSearchResult();
                
               

                    Thread.Sleep(1000);

                    var productDetailsPage = new ProductDetailsPageCA(driver);

                    var skuNumberFound = false;
                    var colorOptions = productDetailsPage.GetColorOptions();
                    for (var i = 0; i < colorOptions.Count; i++)
                    {
                        if (i > 0)
                            colorOptions[i].Click();
                        var productDetailsSKUNumber = productDetailsPage.GetProductDetailsSKUNumber();
                        if (productDetailsSKUNumber == sku)
                        {
                            skuNumberFound = true;
                            break;
                        }
                    }

                    if(!skuNumberFound)
                    {
                        errors.Add($"Wrong product details SKU in row #{rowNumber + 2}; SKU={sku}; Check if multiple colors exist.");
                        continue;
                    }

                    var productDetailsCurrentPrice = productDetailsPage.GetProductDetailsCurrentPrice();
                    if (productDetailsCurrentPrice != salePrice)
                    {
                        errors.Add($"Wrong sale price in row #{rowNumber + 2}; SKU={sku}; price on page was={productDetailsCurrentPrice}, expected price={salePrice}");
                    }
                }
            }

            //foreach(var pair in noResultsRows)
            //{
            //    var rowNumber = pair.Key;
            //    var sku = pair.Value;
            //    Console.WriteLine($"NO Results in row #{rowNumber + 2}; SKU={sku}");
            //}

            foreach (var error in errors)
            {
                Console.WriteLine(error);
            }

            if (errors.Any())
            {
                Assert.Fail("Error(s) exist, see console output for details.");
            }
        }
    }
}
