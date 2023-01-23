using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;
using WebUI.TestFramework.Helpers;

namespace WebUIHT
{
    [Binding]
    public class Hooks
    {
        private IWebDriver _driver;
        private readonly ScenarioContext scenarioContext;
        public Hooks(ScenarioContext context)
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            _driver = new ChromeDriver();
            scenarioContext = context;
        }

        [BeforeScenario]
        public void SetUpDriver()
        {

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            _driver.Manage().Window.Maximize();
            scenarioContext["Driver"] = _driver;
        }
        [AfterScenario("Record", Order = -1)]
        public void DeleteCreatedData()
        {
           HelperMethods help = new HelperMethods(_driver);
            help.DeleteCreatedData();
        }
        [AfterScenario (Order =999)]
        public void StopDriver()
        {
            _driver.Close();
            _driver.Dispose();
        }
       
    }
}
