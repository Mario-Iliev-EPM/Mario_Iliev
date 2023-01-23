using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebUI.TestFramework.Pages;

namespace WebUI.TestFramework.Contexts
{
    public class LoginContext
    {
        private readonly LoginPage _Loginpage;
        public LoginContext(IWebDriver driver)
        {
            _Loginpage = new LoginPage(driver);
        }

        public void Login (string username, string password)
        {
            _Loginpage.UsernameTextField.SendKeys(username);
            _Loginpage.PasswordTextField.SendKeys(password); 
            _Loginpage.LoginButton.Click();
        }
    }
}
