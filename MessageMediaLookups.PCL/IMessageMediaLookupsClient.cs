/*
 * MessageMediaLookups.PCL
*/
using System;
using MessageMedia.Lookups.Controllers;

namespace MessageMedia.Lookups
{
    public partial interface IMessageMediaLookupsClient
    {

        /// <summary>
        /// Singleton access to Lookups controller
        /// </summary>
        ILookupsController Lookups { get;}

    }
}
