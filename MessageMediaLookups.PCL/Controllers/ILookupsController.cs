/*
 * MessageMediaLookups.PCL
*/
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIMATIC.SDK.Common;
using APIMATIC.SDK.Http.Request;
using APIMATIC.SDK.Http.Response;
using APIMATIC.SDK.Http.Client;

namespace MessageMedia.Lookups.Controllers
{
    public partial interface ILookupsController
    {
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
        Models.LookupAPhoneNumberResponse GetLookupAPhoneNumber(string phoneNumber, string options = null);

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
        Task<Models.LookupAPhoneNumberResponse> GetLookupAPhoneNumberAsync(string phoneNumber, string options = null);

    }
}
