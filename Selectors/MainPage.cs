using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotiUITest.Selectors
{
    internal static class MainPage
    {
        internal static By CompanyLogoButton = By.XPath("//*/html/body/div[3]/div[1]/nav/a");
        internal static By CompanyButton = By.XPath("/html/body/div[3]/div[1]/nav/div[2]/div/ul[1]/li[1]/a/span[1]");
    }
}
