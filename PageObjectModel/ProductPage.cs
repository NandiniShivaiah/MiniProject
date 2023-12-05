using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NykaaMiniProject.PageObjectModel
{
    internal class ProductPage
    {
        /*IWebDriver? driver;

        public ProductPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }


       /* [FindsBy(How = How.XPath, Using = "(img[@class='css-11gn9r6'])[1]")]////button[@aria-label='Kebab menu']"
        private IWebElement? SelectProduct { get; set; }*/
        //[@class='css-11gn9r6'])[1]

       /* [FindsBy(How = How.XPath, Using = "(//span[text()='Add to Bag']//parent::button)[1]")]
        private IWebElement? AddProduct { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@class='css-aesrxy']")]
        private IWebElement? AddToBag { get; set; }

        public void SelectProductLink()
        {
            IWebElement selectProduct = driver.FindElement(By.XPath("(//*[@class='css-11gn9r6'])[1]")); //+ "[" + num + "]"));
            selectProduct?.Click();
        }

        public CartPage AddProductLink()
        {
            AddProduct?.Click();
             
            return new CartPage(driver);
        }*/

    }
}
 