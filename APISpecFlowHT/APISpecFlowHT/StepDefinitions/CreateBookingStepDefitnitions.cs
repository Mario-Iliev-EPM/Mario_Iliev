using NUnit.Framework;
using RestAutomationBL.Responses;
using RestAutomationBL.RestUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace APISpecFlowHT.StepDefinitions
{
    [Binding]
    public class CreateBookingStepDefitnitions : RestClientBaseRequests
    {
        [Given(@"I create post request for booking")]
        public void GivenICreatePostRequestForBooking()
        {
            CreateToken();
            var response = PostBooking();
            ScenarioContext.Current["response"] = response;
        }

        [Then(@"Assert created booking by id (.*)")]
        public void ThenAssertCreatedBookingById(int id)
        {
            var response = (Root)ScenarioContext.Current["response"];
          
            Assert.AreEqual(id, response.bookingid);
        }

    }
}
