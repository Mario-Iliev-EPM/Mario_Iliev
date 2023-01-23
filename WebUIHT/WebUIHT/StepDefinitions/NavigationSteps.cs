using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace WebUIHT.StepDefinitions
{
    [Binding]
    public class NavigationSteps
    {
        private IWebDriver _driver;
        public NavigationSteps(ScenarioContext context)
        {
            _driver = context.Get<IWebDriver>("Driver");
        }
        [Given(@"I navigate to the application")]
        public void INavigateToTheApplication()
        {
            _driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");
        }

    }
}
