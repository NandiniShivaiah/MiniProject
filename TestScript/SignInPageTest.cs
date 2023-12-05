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
    internal class SignInPageTest : CoreCodes
    {

        /* public void SignInTest()
         {
              var signIn = new SignInPage(driver);



              signIn.ClickOnSignInUsingSignInWithMobileOrEmailButton();
              Log.Information("Clicked on SignInUsingSignInWithMobileOrEmailButton");


              Thread.Sleep(3000);
              Assert.That(driver.Url.Contains("auth"));
              signIn.MobileNumberInputCheck("9845437361");
              Thread.Sleep(3000);
              signIn.ClickOnLoginProceedButton();
              Log.Information("Clicked On ProceedButton");
              Assert.That(driver.Url.Contains("auth"));
             // signIn.OTPInput("num");*/

        SignInPage signinPage;
        [Test, Category("Smoke Test"), Order(1)]
        [TestCase("9845437361")]
        public void ValidPhoneNumberLoginTest(string input)
        {
            driver.Navigate().GoToUrl("https://www.nykaa.com");
            string? curDir = Directory.GetParent(@"../../../").FullName;
            string? fileName = curDir + "/Log/logs_" +
                DateTime.Now.ToString("dd/'login-page'-ddMMyyyy-hhmmss") + ".txt";

            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File(fileName, rollingInterval: RollingInterval.Day)
                .CreateLogger();

            driver.Navigate().Refresh();

            signinPage = new SignInPage(driver);

            signinPage.ClickOnSignInButton();
            Log.Information("Clicked on signin button");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            signinPage.ClickOnSignInUsingSignInWithMobileOrEmailButton();
            Log.Information("Click On SignInWithMobileOrEmailButton");



            signinPage.ClickOnLoginProceedButton();
            Log.Information("Clicked on proceed button");

            signinPage.MobileNumberInputCheck(input);
            Log.Information("Entered Phone number");






            try
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
                Assert.IsFalse(driver.FindElement(By.XPath("//*[@name='emailMobile']")).Text.Contains("success checkmark"));

                LogTestResult("ValidPhoneNumberLoginTest ", "Valid PhoneNumber Login Test success");
                // ITakesScreenshot();

            }
            catch (AssertionException ex)
            {
                LogTestResult("ValidPhoneNumberLoginTest ", "Valid PhoneNumber Login Test failure", $"ValidPhoneNumberLoginTest failed \n Exception: {ex.Message}");

            }
            Log.CloseAndFlush();
        }
    }
}


        /* [Test, Category("Regression Test")]
         [Order(2)]
         public void InvalidPhoneNumberLoginTest()
         {

             string? curDir = Directory.GetParent(@"../../../").FullName;
             string? fileName = curDir + "/logs/log_" +
                 DateTime.Now.ToString("dd/'login-page-invalid'-ddMMyyyy-hhmmss") + ".txt";

             Log.Logger = new LoggerConfiguration()
                 .WriteTo.Console()
                 .WriteTo.File(fileName, rollingInterval: RollingInterval.Day)
                 .CreateLogger();

             driver.Navigate().Refresh();


             string? currDir = Directory.GetParent(@"../../../")?.FullName;
             string? excelFilePath = currDir + "/testData/InputData.xlsx";
             string? sheetName = "LoginData";
             List<CreateAccount> excelDataList = ExcelUtilities.ReadExcelData(excelFilePath, sheetName);

             signinPage = new SignInPage(driver);

             signinPage.ClickOnSignInUsingSignInWithMobileOrEmailButton();
             Log.Information("Clicked on login button");

             foreach (var excelData in excelDataList)
             {
                 string? mobnumber = excelData?.MobileNumber;
                 if (mobnumber == null)
                 {
                     Console.WriteLine("The phone number cannot be null");
                 }
                 else
                 {
                     Log.Information($"Logging for : {mobnumber}");
                     driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

                     signinPage.MobileNumberInputCheck(mobnumber);
                     Log.Information("Entered Phone number");

                     signinPage.ClickOnSendOtpButton();

                     try
                     {

                         IWebElement errorElement = driver.FindElement(By.XPath("//div[contains(@class, 'youama-ajaxlogin-error') and contains(text(), 'This is not a valid mobile number!')]"));

                         string actualErrorMessage = errorElement.Text;

                         Screenshots();

                         Assert.That(actualErrorMessage == "This is not a valid mobile number!");

                         LogTestResult("InvalidPhoneNumberLoginTest ", "Invalid PhoneNumber Login Test success");

                     }
                     catch (AssertionException ex)
                     {
                         LogTestResult("InvalidPhoneNumberLoginTest ", "Invalid PhoneNumber Login Test failure", $"InvalidPhoneNumberLoginTest failed \n Exception: {ex.Message}");

                     }

                     loginPage.PhoneNumberInputClear();
                 }



             }*/

 


















    

