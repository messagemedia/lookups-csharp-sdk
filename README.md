# Getting started

The MessageMedia Lookups API provides a number of endpoints for validating the phone numbers you’re sending to by checking their validity, type and carrier records.

## How to Build

The generated code uses the Newtonsoft Json.NET NuGet Package. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

1. Open the solution (MessageMediaLookups.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](https://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=MessageMediaLookups-CSharp&workspaceName=MessageMediaLookups&projectName=MessageMediaLookups.Tests)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

The following section explains how to use the MessageMediaLookups library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](https://apidocs.io/illustration/cs?step=addProject&workspaceFolder=MessageMediaLookups-CSharp&workspaceName=MessageMediaLookups&projectName=MessageMediaLookups.Tests)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](https://apidocs.io/illustration/cs?step=createProject&workspaceFolder=MessageMediaLookups-CSharp&workspaceName=MessageMediaLookups&projectName=MessageMediaLookups.Tests)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](https://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=MessageMediaLookups-CSharp&workspaceName=MessageMediaLookups&projectName=MessageMediaLookups.Tests)

### 3. Add reference of the library project

In order to use the MessageMediaLookups library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](https://apidocs.io/illustration/cs?step=addReference&workspaceFolder=MessageMediaLookups-CSharp&workspaceName=MessageMediaLookups&projectName=MessageMediaLookups.Tests)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` MessageMediaLookups.Tests ``` and click ``` OK ```. By doing this, we have added a reference of the ```MessageMediaLookups.Tests``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=createReference&workspaceFolder=MessageMediaLookups-CSharp&workspaceName=MessageMediaLookups&projectName=MessageMediaLookups.Tests)

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=addCode&workspaceFolder=MessageMediaLookups-CSharp&workspaceName=MessageMediaLookups&projectName=MessageMediaLookups.Tests)

## How to Test

The generated SDK also contain one or more Tests, which are contained in the Tests project.
In order to invoke these test cases, you will need *NUnit 3.0 Test Adapter Extension for Visual Studio*.
Once the SDK is complied, the test cases should appear in the Test Explorer window.
Here, you can click *Run All* to execute these test cases.

## Initialization

### Authentication
In order to setup authentication and initialization of the API client, you need the following information.

| Parameter | Description |
|-----------|-------------|
| basicAuthUserName | The username to use with basic authentication |
| basicAuthPassword | The password to use with basic authentication |



API client can be initialized as following.

```csharp
// Configuration parameters and credentials
string basicAuthUserName = "basicAuthUserName"; // The username to use with basic authentication
string basicAuthPassword = "basicAuthPassword"; // The password to use with basic authentication

MessageMediaLookupsClient client = new MessageMediaLookupsClient(basicAuthUserName, basicAuthPassword);
```



# Class Reference

## <a name="list_of_controllers"></a>List of Controllers

* [LookupsController](#lookups_controller)

## <a name="lookups_controller"></a>![Class: ](https://apidocs.io/img/class.png "MessageMedia.Lookups.Controllers.LookupsController") LookupsController

### Get singleton instance

The singleton instance of the ``` LookupsController ``` class can be accessed from the API Client.

```csharp
ILookupsController lookups = client.Lookups;
```

### <a name="get_lookup_a_phone_number"></a>![Method: ](https://apidocs.io/img/method.png "MessageMedia.Lookups.Controllers.LookupsController.GetLookupAPhoneNumber") GetLookupAPhoneNumber

> Use the Lookups API to find information about a phone number.
> A request to the lookups API has the following format:
> ```/v1/lookups/phone/{phone_number}?options={carrier,type}```
> The `{phone_number}` parameter is a required field and should be set to the phone number to be looked up.
> The options query parameter can also be used to request additional information about the phone number.
> By default, a request will only return the `country_code` and `phone_number` properties in the response.
> To request details about the the carrier, include `carrier` as a value of the options parameter.
> To request details about the type, include `type` as a value of the options parameter. To pass multiple values
> to the options parameter, use a comma separated list, i.e. `carrier,type`.
> A successful request to the lookups endpoint will return a response body as follows:
> ```json
> {
>   "country_code": "AU",
>   "phone_number": "+61491570156",
>   "type": "mobile",
>   "carrier": {
>     "name": "Telstra"
>   }
> }
> ```
> Each property in the response body is defined as follows:
> - ```country_code``` ISO ALPHA 2 country code of the phone number
> - ```phone_number``` E.164 formatted phone number
> - ```type``` The type of number. This can be ```"mobile"``` or ```"landline"```
> - ```carrier``` Holds information about the specific carrier (if available)
>   - ```name``` The carrier's name as reported by the network


```csharp
Task<Lookups.Models.LookupAPhoneNumberResponse> GetLookupAPhoneNumber(string phoneNumber, string options = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| phoneNumber |  ``` Required ```  | The phone number to be looked up |
| options |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string phoneNumber = "+61491570156";
string options = "carrier,type";

Lookups.Models.LookupAPhoneNumberResponse result = await lookups.GetLookupAPhoneNumber(phoneNumber, options);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 404 | Number was invalid |


[Back to List of Controllers](#list_of_controllers)



