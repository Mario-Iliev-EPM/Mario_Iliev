using APISpecFlowHT.DTO;
using NUnit.Framework;
using RestAutomationBL.Responses;
using RestAutomationBL.RestUtils;
using System;
using TechTalk.SpecFlow;

namespace APISpecFlowHT.StepDefinitions
{
    [Binding]
    public class AuthTokenStepDefinitions : RestClientBaseRequests
    {
        [Given(@"Create autgorization token")]
        public void CreateAuthToken()
        {
            var response = CreateToken();
            ScenarioContext.Current["response"] = response;
            
        }

        [Then(@"I assert that created token is not null")]
        public void ThenAssertTokenUsername()
        {
            var response = (AuthTokenResponseDTO)ScenarioContext.Current["response"];
            Assert.IsNotNull(response);
        }
    }
}
