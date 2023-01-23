using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebUI.TestFramework.Pages
{
    public class PayGradesPage
    {
        private readonly IWebDriver _driver;
        public PayGradesPage(IWebDriver driver)
        {
            _driver = driver;
        }
        public IWebElement AddButton => _driver.FindElement(By.XPath("//button[@class='oxd-button oxd-button--medium oxd-button--secondary']"));
        public IWebElement NameTextField => _driver.FindElement(By.XPath("//div[@class='oxd-grid-item oxd-grid-item--gutters']//input[@class='oxd-input oxd-input--active']"));
        public IWebElement SaveButton => _driver.FindElement(By.XPath("//button[text()=' Save ']"));
        public IWebElement CurrenciesAddButton => _driver.FindElement(By.XPath("//button[text()=' Add ']"));
        public IWebElement CurrencyOpen => _driver.FindElement(By.XPath("//div[@class='oxd-select-text-input']"));
        public IWebElement BGLevCurrency => _driver.FindElement(By.XPath("//span[text()='BGL - Bulgarian Lev']"));
        public IWebElement MinimumSalaryTextField => _driver.FindElement(By.XPath("//label[contains(text(),'Minimum Salary')]//..//..//input"));
        public IWebElement MaximumSelaryTextField => _driver.FindElement(By.XPath("//label[contains(text(),'Maximum Salary')]//..//..//input"));
        public IWebElement CurrencySaveButton => _driver.FindElement(By.XPath("//h6[text()='Add Currency']//..//button[@type='submit']"));
        public IWebElement CurrencyCancelButton => _driver.FindElement(By.XPath("//h6[text()='Add Currency']//..//button[text()=' Cancel ']"));
        public IWebElement MinimumSalaryField => _driver.FindElement(By.XPath("//div[@class='oxd-table-body']//div[@class='oxd-table-row oxd-table-row--with-border']/div[3]"));
        public IWebElement MaximumSalaryField => _driver.FindElement(By.XPath("//div[@class='oxd-table-body']//div[@class='oxd-table-row oxd-table-row--with-border']/div[4]"));
        public IWebElement NoRecordsMessage => _driver.FindElement(By.XPath("//span[text()='No Records Found']"));

      public  IWebElement DeleteButton => _driver.FindElement(By.XPath("//div[text()='TestUser']//..//..//button[@type='button']"));
       public IWebElement AgreeDeleteButton => _driver.FindElement(By.XPath("//button[text()=' Yes, Delete ']"));
    }
}
