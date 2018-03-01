/*
 * MessageMediaLookups.PCL
 *
 * This file was automatically generated for MessageMedia by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using MessageMedia.Lookups.Controllers;
using APIMATIC.SDK.Http.Client;
using APIMATIC.SDK.Common;

namespace MessageMedia.Lookups
{
    public partial class MessageMediaLookupsClient: IMessageMediaLookupsClient
    {

        /// <summary>
        /// Singleton access to Lookups controller
        /// </summary>
        public ILookupsController Lookups
        {
            get
            {
                return LookupsController.Instance;
            }
        }
        /// <summary>
        /// The shared http client to use for all API calls
        /// </summary>
        public IHttpClient SharedHttpClient
        {
            get
            {
                return BaseController.ClientInstance;
            }
            set
            {
                BaseController.ClientInstance = value;
            }        
        }
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        public MessageMediaLookupsClient() { }

        /// <summary>
        /// Client initialization constructor
        /// </summary>
        public MessageMediaLookupsClient(string basicAuthUserName, string basicAuthPassword)
        {
            Configuration.BasicAuthUserName = basicAuthUserName;
            Configuration.BasicAuthPassword = basicAuthPassword;
        }
        #endregion
    }
}