using NUnit.Framework;
using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DotiUITest.Tests
{
    [TestFixture]
    public class MainPageTest
    {
        ChromeDriver driver;      
        [OneTimeSetUp]
        public void SetUp()
        {
            this.driver= new ChromeDriver(@"C:\Visual Studio Code Project\DotiUITest\Driver\");
            driver.Navigate().GoToUrl("http://magia.hosting5.okinet.pl/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
        }
        [Test]
        public void OpenMainMenu()
        {
            PageObject.MainPage mainPage = new PageObject.MainPage(driver);
            mainPage.findAndClickBurgerMenu();
            Thread.Sleep(5000);
            Assert.IsTrue(mainPage.BurgerMenuIsOpened());
        }
        [TearDown]
        public void tearDown()
        {
            driver.Quit();        
        }

    }
}
