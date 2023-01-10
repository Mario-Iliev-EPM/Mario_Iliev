I crated A SpecFlow project for the WebApi home task.
I have added .feature files in BDD format and step definitions as well.
I have used RestSharp 108.0.3 for crating the rest requests and Newtonsoft.Json 9.0.1 for Serialization and Deserialization and Nunit 3.13.3.
My Home task is divided in two projects one for the tests("APISpecFlowTest") and one for the respons clases and request bodies("RestAutomationBL").
I have made the request bodies clases into a folder named Requests and the responses are in folder Responses
In a folder named "RestBaseRequests" is my class "RestClientBaseRequests" in witch I have created the Requests mathods and Payload as wels as restClient.
My step definition classes inherited "RestClientBaseRequests" so that I can call the request methods without need of creating an instance of the class.
I have add and generate Allure report.
The folder "PostmanCollection" contains a json file with the collection with request that I created in Postman. 