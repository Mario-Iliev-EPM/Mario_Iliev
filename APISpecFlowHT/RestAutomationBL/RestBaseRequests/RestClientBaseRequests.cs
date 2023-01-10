using APISpecFlowHT.DTO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestAutomationBL.Requests;
using RestAutomationBL.Responses;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace RestAutomationBL.RestUtils
{
    public class RestClientBaseRequests
    {
        static RestClient restClient = new RestClient("https://restful-booker.herokuapp.com");
        static RestRequest restRequest;


        public static RestRequest createRequest(string resource, Method method)
        {
            if (restRequest == null)
            {
                return new RestRequest(resource, method);
            }
            else { return restRequest; }
        }

        public static GetBookingResponseDTO GetBookingById(string id)
        {
            restRequest = createRequest("/booking/"+id, Method.Get);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.RequestFormat = DataFormat.Json;

            RestResponse response = restClient.Execute(restRequest);

            HttpStatusCode statusCode = response.StatusCode;
            Assert.AreEqual(HttpStatusCode.OK, statusCode);

            return JsonConvert.DeserializeObject<GetBookingResponseDTO>(response.Content);
        }

        public static AuthTokenResponseDTO CreateToken()
        {
            restRequest = createRequest("/auth", Method.Post);
            restRequest.AddHeader("Content-Type", "application/json");

            var payload = CreateAuthPayload();
            restRequest.AddBody(payload);

            RestResponse response = restClient.Execute(restRequest);
            HttpStatusCode statusCode = response.StatusCode;
            Assert.AreEqual(HttpStatusCode.OK, statusCode);

            return JsonConvert.DeserializeObject<AuthTokenResponseDTO>(response.Content);
        }

        private static string CreateAuthPayload()
        {
            AuthenticationTokenDTO createPayload = new AuthenticationTokenDTO();
            createPayload.username = "admin";
            createPayload.password = "password123";

            return JsonConvert.SerializeObject(createPayload);
        }

        public static Root PostBooking()
        {
            restRequest = createRequest("/booking", Method.Post);
            restRequest.AddHeader("Content-Type", "application/json");
            restRequest.AddHeader("Accept", "application/json");


            var payload = CreateBookingPayload();
            restRequest.AddBody(payload);

            RestResponse response = restClient.Execute(restRequest);
            HttpStatusCode statusCode = response.StatusCode;
            Assert.AreEqual(HttpStatusCode.OK, statusCode);
           
            return JsonConvert.DeserializeObject<Root>(response.Content);
        }

        private static string CreateBookingPayload()
        {
           CreateBookingRootDTO createPayload = new CreateBookingRootDTO();
            Bookingdates bd = new Bookingdates();

            createPayload.firstname = "Jim";
            createPayload.lastname = "Brown";
            createPayload.totalprice = 111;
            createPayload.depositpaid = true;
            bd.checkin = "2018-1-1";
            bd.checkout = "2019-1-1";
            createPayload.additionalneeds = "Breakfast";

            return JsonConvert.SerializeObject(createPayload);
        }

        public static Root DeleteBooking(string id)
        {
            restRequest = createRequest("booking/" + id, Method.Delete);
            restRequest.AddHeader ("Content-Type", "application/json");
            restRequest.AddHeader("Authorization", "Basic");


            RestResponse response = restClient.Execute(restRequest);
            HttpStatusCode statusCode = response.StatusCode;
            Assert.AreEqual(HttpStatusCode.OK, statusCode);
            Console.WriteLine("satatus code is " + statusCode);
            return JsonConvert.DeserializeObject<Root>(response.Content);
        }

        public static UpdateBookingResponse UpdateBooking()
        {
            restRequest = createRequest("/booking/:id", Method.Patch);
            restRequest.AddParameter("id", "1", ParameterType.UrlSegment);
            restRequest.AddHeader("Content-Type", "application/json");
            restRequest.AddHeader("Accept", "application/json");
            restRequest.AddHeader("Authorization", "Basic");
            
            var payload = UpdateBookingPayload();
            restRequest.AddBody(payload);

            RestResponse response = restClient.Execute(restRequest);
            HttpStatusCode statusCode = response.StatusCode;
            Assert.AreEqual(HttpStatusCode.OK, statusCode);
            

            return JsonConvert.DeserializeObject<UpdateBookingResponse>(response.Content);
        }

        private static string UpdateBookingPayload()
        {
           UpdateBookingDTO createPayload = new UpdateBookingDTO();

            createPayload.firstname = "James";
            createPayload.lastname = "Brown";

            return JsonConvert.SerializeObject(createPayload);
        }
    }
}
