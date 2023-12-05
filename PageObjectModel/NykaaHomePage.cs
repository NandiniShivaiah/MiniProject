using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NykaaMiniProject.PageObjectModel
{
    internal class NykaaHomePage
    {
        IWebDriver? driver;
        public NykaaHomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.Name, Using = "search-suggestions-nykaa")]
        private IWebElement? SearchBar { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Kebab menu']")]         //button[@aria-label='Kebab menu'])]
        private IWebElement? SignInButton { get; set; }

        /*[FindsBy(How = How.XPath, Using = "//button[@type='button']//*[name()='svg']")]          //button[@type='button']//*[name()='svg']")]
        private IWebElement? AddToBag { get; set; }*/

        [FindsBy(How = How.XPath, Using = "//a[@title='logo']//*[name()='svg']")]////button[@aria-label='Kebab menu']"
        private IWebElement? Logo { get; set; }

        [FindsBy(How = How.XPath, Using = "(//img[@class='css-11gn9r6'])[1]")]////button[@aria-label='Kebab menu']"
        private IWebElement? SelectProduct { get; set; }//(//*[@class='css-11gn9r6'])[1]"  (img[@class='css-11gn9r6'])[1]

        [FindsBy(How = How.XPath, Using = "(//span[text()='Add to Bag']//parent::button)[1]")]      //*[@id='app']/div[1]/div[2]/div[1]/div[2]/div/div[1]/div[5]/div[1]/div/button")]////button[@aria-label='Kebab menu']"
        private IWebElement? AddToBag { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='css-aesrxy']")]////button[@aria-label='Kebab menu']"
        private IWebElement? AddToCart { get; set; }


        /*   [FindsBy(How = How.XPath, Using = "//*[@id='app']/div/div/div[3]/div/div/div/div[2]/button")]////button[@aria-label='Kebab menu']"
           private IWebElement? ProceedButton { get; set; }
        */

        public void ClickSelectProduct()
        {
            SelectProduct?.Click();
        }

       public void ClickAddToBag()
        {
            //AddToBag = driver.FindElement(By.XPath("(//span[text()='Add to Bag']//parent::button)[1]"));
            AddToBag?.Click();
        }
      


        public void ClickOnCart()
        {
            AddToCart?.Click();
        }

        /*   public void ClickProceedButton()
            {

                ProceedButton?.Click();
                 WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                 IWebElement proceedButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@class='css-15vhhhd e25lf6d4']")));                   //button[@class='css-1h4559r e8tshxd0'][1]              //div[contains(@class,'footer')]//following::button)));
                
        // IWebElement proceedButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='app']/div/div/div[3]/div/div/div/div[2]/button")));


    }*/
    
      
        public void ClickOnSearchBar()
        {
            SearchBar?.Click();
        }

       /* public void ClickOnSearchButton()
        {
            SearchBar?.Click();
        }*/
        public void ClickOnSignInButton()
        {
            SignInButton?.Click();
        }

     /*  public void ClickOnAddToBag()
        {
            AddToBag?.Click();
        }*/

        public void ClickOnLogo()
        {
            Logo?.Click();
        }

        public void SearchInput(string pname)         //void
        {
            SearchBar?.SendKeys(pname);
            SearchBar?.SendKeys(Keys.Enter);
           // return new ProductPage(driver);

        }


        public bool CheckNavbarElemetsStatus(string url)
        {
            try
            {
                var request = (System.Net.HttpWebRequest)
                    System.Net.WebRequest.Create(url);
                request.Method = "HEAD";
                using (var response = request.GetResponse())
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        internal object ClickOnSignIn()
        {
            throw new NotImplementedException();
        }
    }
}
        

