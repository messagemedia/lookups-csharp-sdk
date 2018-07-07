# MessageMedia Lookups C# SDK
[![Travis Build Status](https://api.travis-ci.org/messagemedia/lookups-csharp-sdk.svg?branch=master)](https://travis-ci.org/messagemedia/lookups-csharp-sdk)
[![Pull Requests Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg?style=flat)](http://makeapullrequest.com)
[![NuGet version](https://badge.fury.io/nu/MessageMedia.SDK.Lookups.svg)](https://badge.fury.io/nu/MessageMedia.SDK.Lookups)

The MessageMedia Lookups API provides a number of endpoints for validating the phone numbers you’re sending to by checking their validity, type and carrier records.

![Isometric](https://developers.messagemedia.com/wp-content/uploads/2017/11/lookups-api.png)

## Table of Contents
* [Authentication](#closed_lock_with_key-authentication)
* [Errors](#interrobang-errors)
* [Information](#newspaper-information)
  * [Slack and Mailing List](#slack-and-mailing-list)
  * [Bug Reports](#bug-reports)
  * [Contributing](#contributing)
* [Installation](#star-installation)
* [Get Started](#clapper-get-started)
* [API Documentation](#closed_book-api-documentation)
* [Need help?](#confused-need-help)
* [License](#page_with_curl-license)

## :closed_lock_with_key: Authentication

Authentication is done via API keys. Sign up at https://developers.messagemedia.com/register/ to get your API keys.

Requests are authenticated using HTTP Basic Auth or HMAC. Provide your API key as the auth_user_name and API secret as the auth_password.

## :interrobang: Errors

Our API returns standard HTTP success or error status codes. For errors, we will also include extra information about what went wrong encoded in the response as JSON. The most common status codes are listed below.

#### HTTP Status Codes

| Code      | Title       | Description |
|-----------|-------------|-------------|
| 400 | Invalid Request | The request was invalid |
| 401 | Unauthorized | Your API credentials are invalid |
| 403 | Disabled feature | Feature not enabled |
| 404 | Not Found |	The resource does not exist |
| 50X | Internal Server Error | An error occurred with our API |

## :newspaper: Information

#### Slack and Mailing List

If you have any questions, comments, or concerns, please join our Slack channel:
https://developers.messagemedia.com/collaborate/slack/

Alternatively you can email us at:
developers@messagemedia.com

#### Bug reports

If you discover a problem with the SDK, we would like to know about it. You can raise an [issue](https://github.com/messagemedia/signingkeys-nodejs-sdk/issues) or send an email to: developers@messagemedia.com

#### Contributing

We welcome your thoughts on how we could best provide you with SDKs that would simplify how you consume our services in your application. You can fork and create pull requests for any features you would like to see or raise an [issue](https://github.com/messagemedia/signingkeys-nodejs-sdk/issues)


## :star: Installation
Install via NuGet by:

PM> Install-Package MessageMedia.SDK.Lookups

Alternatively, right-click on your solution and click "Manage NuGet Packages...", then click browse and search for MessageMedia.

Visual Studio Mac:
Project -> Add NuGet Packages -> Search for 'MessageMedia'

## :clapper: Get Started
It's easy to get started. Simply enter the API Key and secret you obtained from the [MessageMedia Developers Portal](https://developers.messagemedia.com) into the code snippet below and a mobile number you wish to send to.

### Lookup a number
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
            Console.WriteLine("Carrier: " + result.Carrier);
            Console.WriteLine("Country code: " + result.CountryCode);
            Console.WriteLine("Phone number: " + result.PhoneNumber);
            Console.WriteLine("Type: " + result.Type);
            Console.ReadLine();
        }
    }
}
```

## :closed_book: API Reference Documentation
Check out the [full API documentation](https://developers.messagemedia.com/code/lookups-api-documentation/) for more detailed information.

## :confused: Need help?
Please contact developer support at developers@messagemedia.com or check out the developer portal at [developers.messagemedia.com](https://developers.messagemedia.com/)

## :page_with_curl: License
Apache License. See the [LICENSE](LICENSE) file.
