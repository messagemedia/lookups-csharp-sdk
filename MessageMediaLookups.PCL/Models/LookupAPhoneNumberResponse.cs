/*
 * MessageMediaLookups.PCL
 *
 * This file was automatically generated for MessageMedia by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using APIMATIC.SDK.Common;


namespace MessageMedia.Lookups.Models
{
    public class LookupAPhoneNumberResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string countryCode;
        private string phoneNumber;
        private string type;
        private object carrier;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("country_code")]
        public string CountryCode 
        { 
            get 
            {
                return this.countryCode; 
            } 
            set 
            {
                this.countryCode = value;
                onPropertyChanged("CountryCode");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("phone_number")]
        public string PhoneNumber 
        { 
            get 
            {
                return this.phoneNumber; 
            } 
            set 
            {
                this.phoneNumber = value;
                onPropertyChanged("PhoneNumber");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("type")]
        public string Type 
        { 
            get 
            {
                return this.type; 
            } 
            set 
            {
                this.type = value;
                onPropertyChanged("Type");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("carrier")]
        public object Carrier 
        { 
            get 
            {
                return this.carrier; 
            } 
            set 
            {
                this.carrier = value;
                onPropertyChanged("Carrier");
            }
        }
    }
} 