using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebUI.TestFramework.Pages;

namespace WebUI.TestFramework.Contexts
{
    public class BaseContext
        
    {
        private readonly BasePage _basePage;
        private readonly IWebDriver _driver;
        public BaseContext(IWebDriver driver)
        {
            _basePage = new BasePage(driver);
            _driver = driver;
        }

        public bool IsPageLoaded()
        {
            var searchTextField = new WebDriverWait(_driver, TimeSpan.FromSeconds(10)).Until(d => _basePage.SearchTextField); 
            return _basePage.SearchTextField != null && _basePage.SearchTextField.Displayed;
        }

        public void AdminTabClick()
        {
            _basePage.AdminTab.Click();
        }
    }
}
