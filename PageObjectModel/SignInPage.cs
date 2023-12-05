using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NykaaMiniProject.PageObjectModel
{

    internal class SignInPage
    {
        IWebDriver driver;
        public SignInPage(IWebDriver driver)
        {

            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Kebab menu']")]
        private IWebElement? SignInButton { get; set; }

        [FindsBy(How = How.Name, Using = "emailMobile")]
        private IWebElement? MobileNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@id='submitVerification']")]
        [CacheLookup]
        private IWebElement? LoginProceed { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[text()='Sign in with Mobile / Email']")]
        private IWebElement? SignInWIthMobileOrEmail { get; set; }

       /* [FindsBy(How = How.XPath, Using = "//*[@id='otpField']")]
        private IWebElement? OTP { get; set; }*/


        
        public void ClickOnSignInButton()
        {
            SignInButton?.Click();
        }

        public void ClickOnSignInUsingSignInWithMobileOrEmailButton()
        {
            //((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", SignInWIthMobileOrEmail);
            SignInWIthMobileOrEmail?.Click();

        }

        public void MobileNumberInputCheck(string mobnum)
        {
            MobileNumber?.SendKeys(mobnum);
        }

        public void MobileNumberInputClear()
        {
            MobileNumber?.Clear();
        }

        public void ClickOnLoginProceedButton()
        {
            //((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", ClickOnLoginProceedButton);
            LoginProceed?.Click();
        }

       /* public void OTPInput(string num)
        {
            OTP?.SendKeys(num);
        }*/


    }
}
