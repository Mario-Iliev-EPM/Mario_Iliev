using RestAutomationBL.RestUtils;
using System;
using TechTalk.SpecFlow;

namespace APISpecFlowHT.StepDefinitions
{
    [Binding]
    public class UpadteStepDefinitions : RestClientBaseRequests
    {
        [Given(@"Update booking")]
        public void UpdateBookingRequest()
        {
            var response = UpdateBooking();
            Console.WriteLine("update step def resp" + response);
           
           
            
        }
    }
}
