using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace DotiUITest.Tests
{
    [TestFixture]
    public class MainPageTest : BasePage
    {
        PageObject.MainPage mainPage = new PageObject.MainPage();
        [OneTimeSetUp]
        public void SetUp()
        {
            driver.Navigate().GoToUrl("https://www.doti.pl/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
        }
        [Test]
        public void goToFirmaWebsite()
        {
            mainPage.findAndClickMainLogo();
            Assert.AreEqual("https://www.doti.pl/", driver.Url);
        }
        [TearDown]
        public void tearDown()
        {
            driver.Quit();        }

    }
}
