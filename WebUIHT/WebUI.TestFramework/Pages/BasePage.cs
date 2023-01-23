using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebUI.TestFramework.Pages
{
    public class BasePage
    {
        private readonly IWebDriver _driver;
        public BasePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement SearchTextField => _driver.FindElement(By.CssSelector(".oxd-input"));

        public IWebElement AdminTab => _driver.FindElement(By.XPath("//span[text()='Admin']"));
    }
}
