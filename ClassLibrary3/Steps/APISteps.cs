using AventStack.ExtentReports;
using AventStack.ExtentReports.Configuration;
using AventStack.ExtentReports.Reporter;
using ClassLibrary3.UpdatedBody;
using ClassLibrary3.Utility;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp.Serialization.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;


namespace ClassLibrary3.Steps
{
    [Binding]
    public class APISteps
    {

        
        public Hashtable servicedetails = new Hashtable();
        public Hashtable paramdetails = new Hashtable();
        public Hashtable ProcessedServicedetails = new Hashtable();
        public static Hashtable parameter = new Hashtable();
        public List<string> Servicelogger = new List<string>();
        private object str;
        public string RequestUrl;
        public string Urlsuffix;
        public string ContentType;
        public string MethodType;
        public string Requestbody;
        public string Connectionvalues;
        public JObject jsonObj;
        public string ServiceName;
        private object _scenarioContext;
        public string Params;
        private object context;
        public static JsonClass.getemployeesRequest getemployeesRequestObj;
        public static JsonClass.getemployeesResponse getemployeesResponseObj;
        public static JsonClass.postCreateuserRequest postCreateuserRequestObj;
        public static JsonClass.postCreateuserResponse postCreateuserResponseObj;
        public static RestSharp.IRestResponse response;
        public static string getemployeesjson;
        public static string json1;
        public static string json;
        public object APIUtils { get; private set; }
        public static string run_typ;
        public static string environment;
        public static string default_browser;
        public static string ServiceDetailsForReport;
        public static string createuserjson;
        public static StreamReader reader;
        private object dt;
        public static string ServiceBody;

        [Given(@"RestService ""(.*)"" with config in ""(.*)"" Json file")]
        public void GivenRestServiceInJsonStaringFile(string serviceName, string fileNam)
        {   
            // Create Request Json Class object as per the service name with the help of json request string and json request enum class. 
            
            switch (serviceName)
            {
                case "getemployees":
                    reader = new StreamReader(@"C:\Users\amitava.chowdhary\source\repos\ClassLibrary3\ClassLibrary3\ServiceDetailsJSONString\getemployees.json");
                    getemployeesjson = reader.ReadToEnd();
                    getemployeesRequestObj = JsonConvert.DeserializeObject<JsonClass.getemployeesRequest>(getemployeesjson);
                    break;
                case "createuser":
                    reader = new StreamReader(@"C:\Users\amitava.chowdhary\source\repos\ClassLibrary3\ClassLibrary3\ServiceDetailsJSONString\createuser.Json");
                    createuserjson = reader.ReadToEnd();
                    postCreateuserRequestObj = JsonConvert.DeserializeObject<JsonClass.postCreateuserRequest>(createuserjson);
                    break;
                default:
                    System.Diagnostics.Debug.WriteLine("No Data");
                    break;
            }
        }

     


    [Then(@"I call ""(.*)"" service ""(.*)"" with modified parameter with updated body ""(.*)"" as ""(.*)""")]
    public void ThenICallServiceWithModifiedParameterWithUpdatedBodyAs(string serviceType, string serviceName, string updatedBody, string flag, Table table)
    {
        ServiceDetailsForReport = "";


            switch (serviceName)
            {
                case "getemployees":

                    // Process Request object class with modified filed parameter provided in data set

                    var getemployeesjson1 = APIUtil.CallServiceWithModifiedParameter( table, getemployeesjson);
                    getemployeesRequestObj = JsonConvert.DeserializeObject<JsonClass.getemployeesRequest>(getemployeesjson1.ToString());

                    // call services with respective data setup and get the response 

                    RestApiHelper.SetUrl(getemployeesRequestObj.RequestUrl + getemployeesRequestObj.Urlsuffix);
                    RestApiHelper.CreateReqyest(getemployeesRequestObj.ContentType, getemployeesRequestObj.Connectionvalues, getemployeesRequestObj.MethodType, getemployeesRequestObj.RequestBody);

                    response = RestApiHelper.getResponse();
                    jsonObj = JObject.Parse(response.Content);
                    json = jsonObj.ToString();

                    // create response object class as per the service name with the help of json response string and json response enum class. 

                    getemployeesResponseObj = JsonConvert.DeserializeObject<JsonClass.getemployeesResponse>(json);

                    // create logger to prinit the service details 

                    Console.WriteLine("#################################################################");
                    Console.WriteLine("Service Details for the service : " + getemployeesRequestObj.ServiceName);
                    Console.WriteLine("#################################################################");
                    Console.WriteLine("Urlsuffix  : " + getemployeesRequestObj.Urlsuffix);
                    Console.WriteLine("Connectionvalues : " + getemployeesRequestObj.Connectionvalues);
                    Console.WriteLine("ContentType : " + getemployeesRequestObj.ContentType);
                    Console.WriteLine("MethodType : " + getemployeesRequestObj.MethodType);
                    Console.WriteLine("RequestUrl : " + getemployeesRequestObj.RequestUrl);
                    Console.WriteLine("RequestBody : " + getemployeesRequestObj.RequestBody);
                    Console.WriteLine("Response : " + response.Content.ToString());
                    Console.WriteLine("#################################################################");

                    // create ServiceDetailsForReport string in order to create the custom report

                    ServiceDetailsForReport = "[#### Service Details for the service ####] ==>> " + getemployeesRequestObj.ServiceName + " [#####   RequestUrl  #####] ==>> " + getemployeesRequestObj.RequestUrl + "  [#####  Response #####]  ==>> " + response.Content.ToString();
                    break;

                case "createuser":

                    var createuserjson1 = APIUtil.CallServiceWithModifiedParameter(table, createuserjson);
                    postCreateuserRequestObj = JsonConvert.DeserializeObject<JsonClass.postCreateuserRequest>(createuserjson1);

                    if (flag.ToString().Equals("True"))
                    {
                        string body = UpdatedBodyProcess.GetQuery(updatedBody);
                        JObject json = JObject.Parse(body);
                        ServiceBody = Newtonsoft.Json.JsonConvert.SerializeObject(json);
                    }
                    else
                    {
                        ServiceBody = Newtonsoft.Json.JsonConvert.SerializeObject(postCreateuserRequestObj.RequestBody);
                    }
                               
                    RestApiHelper.SetUrl(postCreateuserRequestObj.RequestUrl + postCreateuserRequestObj.Urlsuffix);
                    RestApiHelper.CreateReqyest(postCreateuserRequestObj.ContentType, postCreateuserRequestObj.Connectionvalues, postCreateuserRequestObj.MethodType, ServiceBody);

                    response = RestApiHelper.getResponse();
                    jsonObj = JObject.Parse(response.Content);
                    json = jsonObj.ToString();


                    string RequestBodyString = Newtonsoft.Json.JsonConvert.SerializeObject(postCreateuserRequestObj.RequestBody);

                    postCreateuserResponseObj = JsonConvert.DeserializeObject<JsonClass.postCreateuserResponse>(json);
                    Console.WriteLine("#################################################################");
                    Console.WriteLine("Service Details for the service : " + postCreateuserRequestObj.ServiceName);
                    Console.WriteLine("#################################################################");
                    Console.WriteLine("Urlsuffix  : " + postCreateuserRequestObj.Urlsuffix);
                    Console.WriteLine("Connectionvalues : " + postCreateuserRequestObj.Connectionvalues);
                    Console.WriteLine("ContentType : " + postCreateuserRequestObj.ContentType);
                    Console.WriteLine("MethodType : " + postCreateuserRequestObj.MethodType);
                    Console.WriteLine("RequestUrl : " + postCreateuserRequestObj.RequestUrl);
                    Console.WriteLine("RequestBody : " + RequestBodyString);
                    Console.WriteLine("Response : " + response.Content.ToString());
                    Console.WriteLine("#################################################################");


                    ServiceDetailsForReport = "[#### Service Details for the service ####] ==>> " + postCreateuserRequestObj.ServiceName + "  [#####   RequestUrl  #####] ==>> " + postCreateuserRequestObj.RequestUrl + "  [#####  RequestBody #####] ==>> " + RequestBodyString + "  [#####  Response #####]  ==>> " + response.Content.ToString();

                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }



        }
        
       



        [Given(@"verify response should return (.*) as statuscode")]
        public void GivenVerifyResponseShouldReturnAsStatuscodeAsync(String status)
        {
            // Verify the status of the response 

            response = RestApiHelper.getResponse();
            if (response.StatusCode.Equals(status))
            {
                Console.Write("Test Passed");
            }


        }

        [Then(@"verify following response values")]
        public void ThenVerifyFollowingResponseValues(Table table)
        {
            // Verify the reponse value by verifyGivenNodeValue function

            ServiceDetailsForReport = "";
            response = RestApiHelper.getResponse();
            jsonObj = JObject.Parse(response.Content);
            RestApiHelper.verifyGivenNodeValue(table, jsonObj);


        }


       


        [Given(@"I have (.*) client database details")]
        public void GivenIHaveClientDatabaseDetails(string DBName)
        {
            DatabaseUtil.setClient(DBName);
        }


        [Given(@"I execute Select Query ""(.*)""")]
        public void GivenIExecuteSelectQuery(string Query)
        {
            parameter.Add("EmpName", "amit");
            DatabaseUtil.executeQuery(Query);
        }


        [Then(@"verify from executed query")]
        public void ThenVerifyFromExecutedQuery(Table table)
        {
            DatabaseUtil.verifyDataInTable(table);
        }

        [Then(@"I verify fields in database")]
        public void ThenIVerifyFieldsInDatabase(Table table )
        {
          
            DatabaseUtil.verifyDataField(table);

        }

    }
}
