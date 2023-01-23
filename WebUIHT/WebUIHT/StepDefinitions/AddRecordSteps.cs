using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using WebUI.TestFramework.Contexts;
using WebUI.TestFramework.Helpers;
using WebUITests.Utils;

namespace WebUITests.StepDefinitions
{
    [Binding]
    public class AddRecordSteps
    {
        private readonly IWebDriver _driver;
        private readonly AdminContext _adminContext;
        private readonly PayGradesContext _payGradesContext;
        private readonly BaseContext _baseContext;
        private readonly HelperMethods _helperMethods;

        public AddRecordSteps(ScenarioContext context)
        {
            _driver = context.Get<IWebDriver>("Driver");
            _adminContext = new AdminContext(_driver);
            _payGradesContext = new PayGradesContext(_driver);
            _baseContext = new BaseContext(_driver);
            _helperMethods = new HelperMethods(_driver);
        }


        [When(@"I add New Record with name and save changes")]
        public void WhenIAddNewRecordWithNameAndSaveChanges(Table table)
        {
            _baseContext.AdminTabClick();
            _adminContext.JobButtonClick();
            _adminContext.ClickPayGradeButton();
            _payGradesContext.ClickAddButton();
            var credentials = table.CreateSet<Credentials>();
            foreach (var userData in credentials)
                _payGradesContext.PopulateNameField(userData.Name);
            _payGradesContext.ClickSaveButton();
        }

        [When(@"I add assigned currency, with minimum salary value (.*) and maximum value (.*) and click (.*) button")]
        public void SaveNewRecord(string minSalary, string maxSalary, string button)
        {
            _payGradesContext.ClickCurrenciesAddButton();
            _payGradesContext.SelectCurrency();

            _payGradesContext.PopulateSalariesFields(minSalary, maxSalary);

            _payGradesContext.ClickCurrencySaveOrCancel(button);
        }

        [Then(@"My changes are visible")]
        public void ThenMyChangesAreVisible()
        {
            string actualMinimumSalary = _payGradesContext.GetMinSalaryValue();
            string actualMaximumSalary = _payGradesContext.GetMaxSalaryValue();
            string expectedMin = "1.00";
            string expectedMax = "5.00";
            Assert.AreEqual(expectedMin, actualMinimumSalary);
            Assert.AreEqual(expectedMax, actualMaximumSalary);

        }

        [When(@"I add assigned currency, select currency, with minimum salary (.*) and maximum salary (.*) and click (.*) button")]
        public void CancelNewRecord(string minSalary, string maxSalary, string button)
        {
            _payGradesContext.ClickCurrenciesAddButton();
            _payGradesContext.SelectCurrency();


            _payGradesContext.PopulateSalariesFields(minSalary, maxSalary);

            _payGradesContext.ClickCurrencySaveOrCancel(button);
        }

        [Then(@"Data is not visible on the Paygrades pages")]
        public void ThenDataIsNotVisibleOnThePaygradesPages()
        {
            string expected = "No Records Found";
            string actual = _payGradesContext.NoRecordsMessage();
            Assert.AreEqual(expected, actual);
        }

    }
}