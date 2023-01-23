using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebUI.TestFramework.Contexts;
using WebUI.TestFramework.Pages;

namespace WebUI.TestFramework.Helpers
{
    public class HelperMethods
    {

        private readonly PayGradesPage _payGradesPage;
        private readonly AdminContext _adminContext;

        private readonly IWebDriver _driver;
        public HelperMethods(IWebDriver driver)
        {
            _payGradesPage = new PayGradesPage(driver);
            _adminContext = new AdminContext(driver);
            _driver = driver;
        }
       
        public void DeleteCreatedData()
        {
            _adminContext.JobButtonClick();
            _adminContext.ClickPayGradeButton();
            _payGradesPage.DeleteButton.Click();
            _payGradesPage.AgreeDeleteButton.Click();
        }
    }
}
