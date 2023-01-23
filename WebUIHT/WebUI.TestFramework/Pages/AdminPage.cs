using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebUI.TestFramework.Pages
{
    public class AdminPage
    {
        private readonly IWebDriver _driver;
        public AdminPage(IWebDriver driver)
        {
            _driver = driver;
        }
        public IWebElement JobButton => _driver.FindElement(By.XPath("//span[text()='Job ']"));
        public IWebElement PayGrades => _driver.FindElement(By.XPath("//a[text()='Pay Grades']"));
        public IWebElement PayGradeButton => _driver.FindElement(By.XPath("//a[text()='Pay Grades']"));
        
       
    }
}
