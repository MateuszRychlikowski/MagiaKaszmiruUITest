using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Chrome;
using MagiaKaszmiruUITest.Selectors;

namespace MagiaKaszmiruUITest.PageObject
{
    class MainPage : BasePage
    {
        ChromeDriver chromeDriver;
        public MainPage(ChromeDriver driver) : base(driver)
        {
            this.chromeDriver = driver;
        }

        public void findAndClickBurgerMenu()
        {
            chromeDriver.FindElement(Selectors.MainPage.BurgerButtonMenu).Click();
        }
        public bool BurgerMenuIsOpened()
        {
            if (elementIsDisplayed(Selectors.MainPage.OpenedBurgerMenu))
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
