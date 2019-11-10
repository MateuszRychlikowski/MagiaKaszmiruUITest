using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Chrome;

namespace DotiUITest.PageObject
{
    class MainPage : BasePage
    {

        [OneTimeSetUp]
        public void Setup()
        {

        }

        [Test]
        public void openMainWebsite()
        {

            driver.Navigate().GoToUrl("https://www.doti.pl/");
            Assert.Pass();
        }

        [TearDown]
        public void tearDown()
        {
            driver.Close();
        }


    }
}
