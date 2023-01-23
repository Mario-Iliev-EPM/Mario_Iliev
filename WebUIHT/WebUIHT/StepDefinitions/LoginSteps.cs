using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebUI.TestFramework.Contexts;
using WebUI.TestFramework.Pages;
using WebUITests.Utils;

namespace WebUIHT.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        private readonly IWebDriver _driver;
        private readonly LoginContext _loginContext;
        private readonly BaseContext _baseContext;
        public LoginSteps(ScenarioContext context)
        {
            _driver = context.Get<IWebDriver>("Driver");
            _loginContext = new LoginContext(_driver);
            _baseContext = new BaseContext(_driver);   
        }

        [When(@"I log in as admin user")]
        public void ILogInAsAdminUser(Table table)
        {
            var credentials = table.CreateSet<Credentials>();
            foreach (var userData in credentials)
            {
                _loginContext.Login(userData.Username, userData.Password);
            }
        }

        [Then(@"I successfully logged in")]
        public void ISuccessfullyLoggedIn()
        {
            var actual = _baseContext.IsPageLoaded();
            Assert.That(actual, Is.True);
        }

    }
}
