using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using Microsoft.Extensions.Options;
using SAUCEDEMOUITASK.Drivers;
using BoDi;
using System.ComponentModel;

namespace SDEMOUITASK.Hooks
{
    [Binding]
    public sealed class Hooks:DriversHelpers
    {
        IWebDriver? driver;
        IObjectContainer container;

        public Hooks(IObjectContainer _container)
        {
            container = _container;
        }


        [BeforeScenario]
        public void FirstBeforeScenario()
        {

            //add package webManagerDriver
            //chromedriver 
            // selenium package 
            //selenium support 
            //var options = new ChromeOptions();
            //options.AddArguments("start-maximized", "incognito");
            //driver = new ChromeDriver(options);
            //Thread.Sleep(1000);
            //driver.Navigate().GoToUrl(url);
           
            
            
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                container.RegisterInstanceAs<IWebDriver>(driver);
                //Assert.True(driver.Url.Contains("tfl"));
                Thread.Sleep(1000);
            






        }

        [AfterScenario]
        public void AfterScenario()
        {
            if (driver != null)
            {
                driver.Quit();
            }
            driver = null;
        }
    }
}
