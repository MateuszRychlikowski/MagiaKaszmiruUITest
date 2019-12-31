using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Chrome;
using DotiUITest.Selectors;

namespace DotiUITest.PageObject
{
    class MainPage :BasePage
    {
        public void findAndClickMainLogo()
        {
            findAndClickElement(Selectors.MainPage.CompanyLogoButton);
        }
    }
}
