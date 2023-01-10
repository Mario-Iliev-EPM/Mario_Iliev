using APISpecFlowHT.DTO;
using Newtonsoft.Json;
using NUnit.Framework;
using RestAutomationBL.RestUtils;
using RestSharp;
using System;
using System.Net;
using TechTalk.SpecFlow;

namespace APISpecFlowHT.StepDefinitions
{
    [Binding]
    public class GetBookingStepDefinitions : RestClientBaseRequests
    {
        [Given(@"I create new GET request by id (.*)")]
        public void GetBookingRequest(string id)
        {

            var response = GetBookingById(id);
            ScenarioContext.Current["response"] = response;
        }

     
        [Then(@"Assert get request by first name (.*)")]
        public void ThenAssertSomething(string firstName)
        {
            var response = (GetBookingResponseDTO)ScenarioContext.Current["response"];
            Assert.AreEqual(firstName, response.firstname);
        }

    }
}
