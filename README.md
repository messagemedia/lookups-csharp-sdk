# MessageMedia Lookups C# SDK
[![Travis Build Status](https://api.travis-ci.org/messagemedia/lookups-csharp-sdk.svg?branch=master)](https://travis-ci.org/messagemedia/lookups-csharp-sdk)
[![nuget](https://img.shields.io/badge/nuget-v1.0.0-blue.svg)](https://www.nuget.org/packages/MessageMedia.SDK.Lookups/)

The MessageMedia Lookups API provides a number of endpoints for validating the phone numbers you’re sending to by checking their validity, type and carrier records.

## ⭐️ Installing via NuGet
Install via NuGet by:

PM> Install-Package MessageMedia.SDK.Lookups

Alternatively, right-click on your solution and click "Manage NuGet Packages...", then click browse and search for MessageMedia.

Visual Studio Mac:
Project -> Add NuGet Packages -> Search for 'MessageMedia'

## 🎬 Get Started
It's easy to get started. Simply enter the API Key and secret you obtained from the [MessageMedia Developers Portal](https://developers.messagemedia.com) into the code snippet below and a mobile number you wish to send to.

### 👀 Lookup a number
```csharp
using System;
using MessageMedia.Lookups;
using MessageMedia.Lookups.Controllers;
using MessageMedia.Lookups.Models;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string basicAuthUserName = "API_KEY"; // The username to use with basic authentication
            string basicAuthPassword = "API_SECRET"; // The password to use with basic authentication

            MessageMediaLookupsClient client = new MessageMediaLookupsClient(basicAuthUserName, basicAuthPassword);

            string phone_number = "MOBILE_NUMBER";
            string options = "carrier,type";

            LookupAPhoneNumberResponse result = client.Lookups.GetLookupAPhoneNumber(phone_number, options);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
```

## 📕 Documentation
Check out the [full API documentation](DOCUMENTATION.md) for more detailed information.

## 😕 Got Stuck?
Please contact developer support at developers@messagemedia.com or check out the developer portal at [developers.messagemedia.com](https://developers.messagemedia.com/)

## 📃 License
Apache License. See the [LICENSE](LICENSE) file.
