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
    public class AdminContext
    {
        private readonly AdminPage _adminPage;
        
        public AdminContext(IWebDriver driver)
        {
            _adminPage = new AdminPage(driver);
            
        }
        public void JobButtonClick()
        {
            _adminPage.JobButton.Click();
        }
        public void ClickPayGradeButton()
        {
            _adminPage.PayGradeButton.Click();
        }
    }
}
