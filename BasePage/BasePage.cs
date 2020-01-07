using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;

namespace MagiaKaszmiruUITest
{
    public class BasePage
    {
        ChromeDriver driver;
        public BasePage(ChromeDriver driver)
        {
            this.driver = driver;
        }      

        public void findAndClickElement(By selector)
        {
            driver.FindElement(selector).Click();
        }
        public void findAndSetValue(By selector, string value)
        {
            driver.FindElement(selector).SendKeys(value);
        }
        public void findElement(By selector)
        {
            driver.FindElement(selector);
        }
        public bool elementIsDisplayed(By selector)
        {
            if (driver.FindElement(selector).Displayed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}