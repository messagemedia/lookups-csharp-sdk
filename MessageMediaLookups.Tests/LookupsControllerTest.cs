/*
 * MessageMediaLookups.Tests
 *
 * This file was automatically generated for MessageMedia by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using APIMATIC.SDK.Common; 
using APIMATIC.SDK.Http.Client;
using APIMATIC.SDK.Http.Response;
using MessageMedia.Lookups.Helpers;
using NUnit.Framework;
using MessageMedia.Lookups;
using MessageMedia.Lookups.Controllers;

namespace MessageMedia.Lookups
{
    [TestFixture]
    public class LookupsControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests)
        /// </summary>
        private static ILookupsController controller;

        /// <summary>
        /// Setup test class
        /// </summary>
        [SetUp]
        public static void SetUpClass()
        {
            controller = GetClient().Lookups;
        }

        /// <summary>
        /// Use the Lookups API to find information about a phone number.
        ///A request to the lookups API has the following format:
        ///```/v1/lookups/phone/{phone_number}?options={carrier,type}```
        ///The `{phone_number}` parameter is a required field and should be set to the phone number to be looked up.
        ///The options query parameter can also be used to request additional information about the phone number.
        ///By default, a request will only return the `country_code` and `phone_number` properties in the response.
        ///To request details about the the carrier, include `carrier` as a value of the options parameter.
        ///To request details about the type, include `type` as a value of the options parameter. To pass multiple values
        ///to the options parameter, use a comma separated list, i.e. `carrier,type`.
        ///A successful request to the lookups endpoint will return a response body as follows:
        ///```json
        ///{
        ///  "country_code": "AU",
        ///  "phone_number": "+61491570156",
        ///  "type": "mobile",
        ///  "carrier": {
        ///    "name": "Telstra"
        ///  }
        ///}
        ///```
        ///Each property in the response body is defined as follows:
        ///- ```country_code``` ISO ALPHA 2 country code of the phone number
        ///- ```phone_number``` E.164 formatted phone number
        ///- ```type``` The type of number. This can be ```"mobile"``` or ```"landline"```
        ///- ```carrier``` Holds information about the specific carrier (if available)
        ///  - ```name``` The carrier's name as reported by the network 
        /// </summary>
        [Test]
        public async Task TestLookupAPhoneNumber() 
        {
            // Parameters for the API call
            string phoneNumber = "+61491570156";
            string options = "carrier,type";

            // Perform API call
            Lookups.Models.LookupAPhoneNumberResponse result = null;

            try
            {
                result = await controller.GetLookupAPhoneNumberAsync(phoneNumber, options);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, httpCallBackHandler.Response.StatusCode,
                    "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", null);

            Assert.IsTrue(TestHelper.AreHeadersProperSubsetOf (
                    headers, httpCallBackHandler.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
                                    
            Assert.AreEqual("{\"carrier\":{\"name\":\"AU Landline Carrier\"},\"country_code\":\"AU\",\"phone_number\":\"+61491570156\",\"type\":\"MOBILE\"}", 
                    TestHelper.ConvertStreamToString(httpCallBackHandler.Response.RawBody),
                    "Response body should match exactly (string literal match)");
        }

    }
}
