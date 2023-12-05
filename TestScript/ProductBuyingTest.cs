using Nykaa.Utilities;
using NykaaMiniProject.PageObjectModel;
using OpenQA.Selenium;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NykaaMiniProject.TestScript
{
    [TestFixture]
    internal class ProductBuyingTest:CoreCodes
    {
        [Test]
        public void BuyProductTest()
        {
            var homePage = new NykaaHomePage(driver);

            driver.Navigate().Refresh();

            homePage.SearchInput("mac");
            Thread.Sleep(4000);

            homePage.ClickSelectProduct();
            List<string> lstWindow = driver.WindowHandles.ToList();

            foreach (var i in lstWindow)
            {
                Console.WriteLine("Switching to window: " + i);
                driver.SwitchTo().Window(i);
            }
            Thread.Sleep(2000);
            driver.Navigate().Refresh();
            homePage.ClickAddToBag();
            Thread.Sleep(2000);
            homePage.ClickOnCart();

            Thread.Sleep(5000);
        }

       /*NykaaHomePage? homePage;
        ProductPage? productPage;
        CartPage? cartPage;
        [Test, Category("End-to-End Testing")]


        public void CartOperationsTest()
        {
            string? curDir = Directory.GetParent(@"../../../").FullName;
            string? fileName = curDir + "/Log/logs_" +
                DateTime.Now.ToString("dd/'cart'-ddMMyyyy-hhmmss") + ".txt";

            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File(fileName, rollingInterval: RollingInterval.Day)
                .CreateLogger();

            homePage = new NykaaHomePage(driver);

            productPage= new ProductPage(driver);

            productPage = homePage.SearchInput("mac");

           
            Log.Information("Searched-Text");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            productPage.SelectProductLink();
            Log.Information("Selected Product");


            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            productPage.SelectProductLink();
            Log.Information("Selected Product");

            cartPage = productPage.AddProductLink();
            Log.Information("Clicked on the  Add product button");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            cartPage.AddToCartClickOn();
            Log.Information("Clicked on the  Cart button");
            
            cartPage.ClickOnAddToBag();
            Log.Information("Clicked on the  Cart button");


           /* try
            {
                //Screenshots();
                Assert.IsTrue(driver.FindElement(By.XPath("//*[@class='css-qpc3fc e1xdieeb0']")).Text.Contains("cart_body"));

                LogTestResult("CartPageTest ", "Cart Page Test success");

            }
            catch (AssertionException ex)
            {
                LogTestResult("CartPageTest  ", "Cart Page Test failure", $"Cart Page Test failed \n Exception: {ex.Message}");

            }*/

           // Log.CloseAndFlush();





        
    }
}
