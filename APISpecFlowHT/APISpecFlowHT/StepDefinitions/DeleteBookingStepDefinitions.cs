using NUnit.Framework;
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
            CreateToken();

            var response = DeleteBooking(id);
            Console.WriteLine("delete resp" + response);
        }
        [Then(@"I assert that there is no booking with id (.*)")]
        public void IAssertThatThereIsNoBookingWithId(string id)
        {
          var booking =  GetBookingById(id);
           booking.firstname.Should().BeNull();
        }

    }
}
