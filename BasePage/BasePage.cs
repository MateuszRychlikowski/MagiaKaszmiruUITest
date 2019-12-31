using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;

namespace DotiUITest
{
    public class BasePage
    {
        public ChromeDriver driver;
        public BasePage()
        {
            this.driver = new ChromeDriver(@"C:\Visual Studio Code Project\DotiUITest\Driver\");
        }

        public void findAndClickElement(By selector)
        {
            driver.FindElement(selector).Click();
        }
        public void findAndSetValue(By selector, string value)
        {
            driver.FindElement(selector).SendKeys(value);
        }
    }
}