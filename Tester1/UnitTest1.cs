using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;


namespace Tester1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://google.com");
            driver.FindElementById("hplogo").Click();
        }

        [TestMethod]
        public void RegisterTest()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.artlebedev.ru/case/");
            driver.FindElementByCssSelector("textarea#source").Click();
            driver.FindElementByXPath("//textarea[@id=\"source\"]").SendKeys("fAlse reGGister");
            string text = driver.FindElementByXPath("//textarea[@id=\"target\"]").GetAttribute("value");
            driver.Close();
            Assert.IsTrue(text == "false reggister");
        }


        [TestMethod]
        public void GenerateSHA256()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://timestampgenerator.com/tools/sha256-generator");
            driver.FindElementByXPath("//textarea[@id=\"source\"]").Click();
            driver.FindElementByXPath("//textarea[@id=\"source\"]").SendKeys("Hey there");
            driver.FindElementByXPath("//*[@id=\"app\"]/div[2]/main/div[1]/div[1]/div[2]/div[2]/form/button");
            
        }

        [TestMethod]
        public void FindSquareEquationTest()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.calc.ru/resheniye_kvadratnykh_uravneniy.html");
            driver.FindElementByXPath("//*[@id=\"a\"]").SendKeys("");
            
        }
    }
}