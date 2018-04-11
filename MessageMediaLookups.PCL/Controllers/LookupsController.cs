/*
 * MessageMediaLookups.PCL
*/
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using APIMATIC.SDK.Common;
using APIMATIC.SDK.Http.Request;
using APIMATIC.SDK.Http.Response;
using APIMATIC.SDK.Http.Client;

namespace MessageMedia.Lookups.Controllers
{
    public partial class LookupsController: BaseController, ILookupsController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static LookupsController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static LookupsController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new LookupsController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Use the Lookups API to find information about a phone number.
        /// A request to the lookups API has the following format:
        /// ```/v1/lookups/phone/{phone_number}?options={carrier,type}```
        /// The `{phone_number}` parameter is a required field and should be set to the phone number to be looked up.
        /// The options query parameter can also be used to request additional information about the phone number.
        /// By default, a request will only return the `country_code` and `phone_number` properties in the response.
        /// To request details about the the carrier, include `carrier` as a value of the options parameter.
        /// To request details about the type, include `type` as a value of the options parameter. To pass multiple values
        /// to the options parameter, use a comma separated list, i.e. `carrier,type`.
        /// A successful request to the lookups endpoint will return a response body as follows:
        /// ```json
        /// {
        ///   "country_code": "AU",
        ///   "phone_number": "+61491570156",
        ///   "type": "mobile",
        ///   "carrier": {
        ///     "name": "Telstra"
        ///   }
        /// }
        /// ```
        /// Each property in the response body is defined as follows:
        /// - ```country_code``` ISO ALPHA 2 country code of the phone number
        /// - ```phone_number``` E.164 formatted phone number
        /// - ```type``` The type of number. This can be ```"mobile"``` or ```"landline"```
        /// - ```carrier``` Holds information about the specific carrier (if available)
        ///   - ```name``` The carrier's name as reported by the network
        /// </summary>
        /// <param name="phoneNumber">Required parameter: The phone number to be looked up</param>
        /// <param name="options">Optional parameter: Example: </param>
        /// <return>Returns the Models.LookupAPhoneNumberResponse response from the API call</return>
        public Models.LookupAPhoneNumberResponse GetLookupAPhoneNumber(string phoneNumber, string options = null)
        {
            Task<Models.LookupAPhoneNumberResponse> t = GetLookupAPhoneNumberAsync(phoneNumber, options);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Use the Lookups API to find information about a phone number.
        /// A request to the lookups API has the following format:
        /// ```/v1/lookups/phone/{phone_number}?options={carrier,type}```
        /// The `{phone_number}` parameter is a required field and should be set to the phone number to be looked up.
        /// The options query parameter can also be used to request additional information about the phone number.
        /// By default, a request will only return the `country_code` and `phone_number` properties in the response.
        /// To request details about the the carrier, include `carrier` as a value of the options parameter.
        /// To request details about the type, include `type` as a value of the options parameter. To pass multiple values
        /// to the options parameter, use a comma separated list, i.e. `carrier,type`.
        /// A successful request to the lookups endpoint will return a response body as follows:
        /// ```json
        /// {
        ///   "country_code": "AU",
        ///   "phone_number": "+61491570156",
        ///   "type": "mobile",
        ///   "carrier": {
        ///     "name": "Telstra"
        ///   }
        /// }
        /// ```
        /// Each property in the response body is defined as follows:
        /// - ```country_code``` ISO ALPHA 2 country code of the phone number
        /// - ```phone_number``` E.164 formatted phone number
        /// - ```type``` The type of number. This can be ```"mobile"``` or ```"landline"```
        /// - ```carrier``` Holds information about the specific carrier (if available)
        ///   - ```name``` The carrier's name as reported by the network
        /// </summary>
        /// <param name="phoneNumber">Required parameter: The phone number to be looked up</param>
        /// <param name="options">Optional parameter: Example: </param>
        /// <return>Returns the Models.LookupAPhoneNumberResponse response from the API call</return>
        public async Task<Models.LookupAPhoneNumberResponse> GetLookupAPhoneNumberAsync(string phoneNumber, string options = null)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v1/lookups/phone/{phone_number}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "phone_number", phoneNumber }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "options", options }
            },ArrayDeserializationFormat,ParameterSeparator);


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "messagemedia-lookups-csharp-sdk-1.0.1" },
                { "accept", "application/json" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if (_response.StatusCode == 404)
                throw new APIException(@"Number was invalid", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.LookupAPhoneNumberResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
}
