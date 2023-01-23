using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebUI.TestFramework.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver _driver;
        public LoginPage(IWebDriver driver)
        {
           _driver = driver;
        }

        public IWebElement UsernameTextField => _driver.FindElement(By.CssSelector("input[name=username]"));
        public IWebElement PasswordTextField => _driver.FindElement(By.CssSelector("input[name=password]"));
        public IWebElement LoginButton => _driver.FindElement(By.CssSelector("button[class*=login]"));
    }
}
