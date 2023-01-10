using RestAutomationBL.RestUtils;
using System;
using TechTalk.SpecFlow;

namespace APISpecFlowHT.StepDefinitions
{
    [Binding]
    public class DeleteBookingStepDefinitions : RestClientBaseRequests
    {
        [Given(@"I delete booking with id (.*)")]
        public void GivenIDeleteBooking(string id)
        {
            var response = DeleteBooking(id);
            Console.WriteLine("delete resp" + response);
        }
    }
}
