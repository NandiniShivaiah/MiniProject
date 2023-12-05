
using Nykaa.Utilities;
using NykaaMiniProject.PageObjectModel;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace NykaaMiniProject.TestScript
{
    [TestFixture]
    internal class NykaaHomePageTest : CoreCodes
    {
        NykaaHomePage? homePage;
        [Test, Category("Smoke Test")]

        public void HeaderElementsTest()
        {

            string? curDir = Directory.GetParent(@"../../../").FullName;
            string? fileName = curDir + "/logs/log_" +
                DateTime.Now.ToString("dd/'header'-ddMMyyyy-hhmmss") + ".txt";

            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File(fileName, rollingInterval: RollingInterval.Day)
                .CreateLogger();
            driver.Navigate().Refresh();

            homePage = new NykaaHomePage(driver);

            homePage.ClickOnLogo();
            // Screenshots();
            Log.Information("Clicked On Logo");

            homePage.ClickOnSignInButton();


            Log.Information("Clicked On Sign In Button");

            homePage.ClickOnSearchBar();
            //Screenshots();
            Log.Information("Clicked On search-bar");



          /*    try
               {
                   //Screenshots();
                   Assert.That(driver.Url.Contains("Search On Nykaa"));
                   Thread.Sleep(3000);
                       LogTestResult("HeaderElementsTest ", "Header Elements Test for search success");
               }
               catch (AssertionException ex)
               {
                   LogTestResult("HeaderElementsTest  ", "Header Elements Test for search failure", $"Header Elements Test for search failed \n Exception: {ex.Message}");
               }

               homePage.ClickOnSignInButton();

               Log.Information("Clicked On SignIn button");

               try
               {
                   //Screenshots();
                   Assert.IsTrue(driver.FindElement(By.XPath("//*[@id=\"header_id\"]/div[2]/div/div[2]/div[1]/div[1]/button"
                                   )).Text == "Login/Create Account", $"Test Failed for Login/Create Account");

                                   Thread.Sleep(10000);


                                   LogTestResult(" Login/Create Account Test ", "Login/Create Account  success");
             
                   Assert.IsTrue(driver.FindElement(By.XPath("//button[text()='Sign in with Mobile / Email']"
                   )).Text == "SigninwithMobile/Email", $"Test Failed for Login/Register");

                   Thread.Sleep(10000);


                   LogTestResult(" Login/Register Test ", "Login/Register  success");



               }
               catch (AssertionException ex)
               {
                   LogTestResult("HeaderElementsTest  ", "Header Elements Test for login failure", $"Header Elements Test for login failed \n Exception: {ex.Message}");
               }


               homePage.ClickOnAddToBag();

               Log.Information("Clicked On Cart button");
               try
               {
                   //Screenshots();
                   Assert.That(driver.FindElement(By.XPath("  //div[@class='header-layout css-1h9leo3 e13w5ra50']")).Text.Equals("Your Shopping Bag is empty"));
                   LogTestResult("HeaderElementsTest ", "Header Elements Test for cart success");
               }
               catch (AssertionException ex)
               {
                   LogTestResult("HeaderElementsTest  ", "Header Elements Test for cart failure", $"Header Elements Test for cart failed \n Exception: {ex.Message}");
               }


               Log.CloseAndFlush();



           }*/



        }


    }
}
