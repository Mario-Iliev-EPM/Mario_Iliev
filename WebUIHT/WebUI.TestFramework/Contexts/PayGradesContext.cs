using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebUI.TestFramework.Helpers;
using WebUI.TestFramework.Pages;

namespace WebUI.TestFramework.Contexts
{
    public class PayGradesContext
    {
        private readonly PayGradesPage _payGradesPage;
       
        
        public PayGradesContext(IWebDriver driver)
        {
            _payGradesPage = new PayGradesPage(driver);
           
        }
        public void ClickAddButton()
        {
            _payGradesPage.AddButton.Click();
        }
        public void PopulateNameField(string name)
        {
            _payGradesPage.NameTextField.Clear();
            _payGradesPage.NameTextField.SendKeys(name);
        }
        public void ClickSaveButton()
        {
            _payGradesPage.SaveButton.Click();
        }
        public void ClickCurrenciesAddButton()
        {
            _payGradesPage.CurrenciesAddButton.Click();
        }
        public void SelectCurrency()
        {
            _payGradesPage.CurrencyOpen.Click();
            _payGradesPage.BGLevCurrency.Click();
        }
   
        public void PopulateSalariesFields(string minSalary, string maxSalary)
        {           
            _payGradesPage.MinimumSalaryTextField.Clear();
            _payGradesPage.MinimumSalaryTextField.SendKeys(minSalary);
            _payGradesPage.MaximumSelaryTextField.Clear();
            _payGradesPage.MaximumSelaryTextField.SendKeys(maxSalary);
        } 
        public void EnterMaxSalary(string maxSalary)
        {
            _payGradesPage.MaximumSelaryTextField.Clear();
            _payGradesPage.MaximumSelaryTextField.SendKeys(maxSalary);
        }
        public void ClickCurrencySaveOrCancel(string button)
        {
            if (button == "save")
            {
                _payGradesPage.CurrencySaveButton.Click();
            }else if (button == "cancel")
            {
                _payGradesPage.CurrencyCancelButton.Click();
            }
        }
        public string GetMinSalaryValue()
        {
            return _payGradesPage.MinimumSalaryField.Text;
        }
          public string GetMaxSalaryValue()
        {
            return _payGradesPage.MaximumSalaryField.Text;
        }
        public string NoRecordsMessage()
        {
            return _payGradesPage.NoRecordsMessage.Text;
        }
    }
}
