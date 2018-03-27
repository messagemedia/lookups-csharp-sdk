# MessageMedia Lookups C# SDK

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
* Destination numbers (`destination_number`) should be in the [E.164](http://en.wikipedia.org/wiki/E.164) format. For example, `+61491570156`.
```csharp
using System;
using MessageMedia.Messages;
using MessageMedia.Messages.Controllers;
using MessageMedia.Messages.Models;

namespace TestCSharpSDK
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configure your credentials (Note, these can be pulled from the environment variables as well)
            String basicAuthUserName = "YOUR_API_KEY";
            String basicAuthPassword = "YOUR_API_SECRET";
            bool useHmacAuthentication = false; //Change this to true if you are using HMAC keys
            
            // Instantiate the client
            MessageMediaMessagesClient client = new MessageMediaMessagesClient(basicAuthUserName, basicAuthPassword, useHmacAuthentication);
            IMessagesController messages = client.Messages;

            // Perform API call
            string bodyValue = @"{
                                   ""messages"":[
                                      {
                                         ""content"":""Greetings from MessageMedia!"",
                                         ""destination_number"":""YOUR_MOBILE_NUMBER""
                                      }
                                   ]
                                }";

            var body = Newtonsoft.Json.JsonConvert.DeserializeObject<MessageMedia.Messages.Models.SendMessagesRequest>(bodyValue);

            MessageMedia.Messages.Models.SendMessagesResponse result = messages.CreateSendMessages(body);
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
