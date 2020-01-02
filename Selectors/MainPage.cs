using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotiUITest.Selectors
{
    internal static class MainPage
    {
        internal static By BurgerButtonMenu = By.XPath("//*[@id=\"header\"]/div/div/div[1]/div/div[1]");
        internal static By OpenedBurgerMenu = By.XPath("//*[@id=\"page\"]/div/div/div[1]/div");
    }
}
