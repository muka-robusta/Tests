using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Tester1
{
    public class PageObjectUsage
    {
        private readonly IWebDriver driver;
        private readonly string url = "https://emn178.github.io/online-tools";

        public PageObjectUsage(IWebDriver browser)
        {
            this.driver = browser;
            this.driver.Manage().Window.Maximize();
            
        }
        [FindsBy(How = How.XPath, Using = "//*[@id=\"input\"]")]
        public IWebElement InputDecodedField;
        
        [FindsBy(How = How.XPath, Using = "//*[@id=\"output\"]")]
        public IWebElement OutputEncodedField;
        
        public string EncodingType; // sufix-for-url field 

        /*
         *    Simple example how can i decrease same code using only one function
         */
        public PageObjectUsage encode(string what, string by) // cover many of my tests
        {
            string direct_url = url + "/" + by;
            this.driver.Navigate().GoToUrl(direct_url);
            InputDecodedField.SendKeys(what);
            return this;
        }

    }
}