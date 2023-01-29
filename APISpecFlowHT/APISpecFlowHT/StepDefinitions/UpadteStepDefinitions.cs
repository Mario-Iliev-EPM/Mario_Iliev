using APISpecFlowHT.DTO;
using NUnit.Framework;
using RestAutomationBL.Responses;
using RestAutomationBL.RestUtils;
using System;
using TechTalk.SpecFlow;

namespace APISpecFlowHT.StepDefinitions
{
    [Binding]
    public class UpadteStepDefinitions : RestClientBaseRequests
    {
        [Given(@"Update booking with id (.*)")]
        public void UpdateBookingRequest(string id)
        {
            CreateToken();
            var response = UpdateBooking(id);
           
            ScenarioContext.Current["response"] = response;
        }

        [Then(@"I assert that booking (.*) has the same name as in the update request")]
        public void ThenIAssertThatBookingHasTheSameNameAsInTheUpdateRequest(string id)
        {
            var response = (UpdateBookingResponse)ScenarioContext.Current["response"];
           
            var booking = GetBookingById(id);
            Assert.AreEqual(booking.firstname, response.Firstname);
        }
    }
}
