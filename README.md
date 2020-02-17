# redde-sdk-CSharp
<img src="https://www.reddeonline.com/assets/images/redde-logo.png" width=400>


# redde-sdk-CSharp
REDDE CSharp SDK that allows merchants to receive, send, check transaction status, and perform lots of payment transactions.

Before you can have access to APIs you need to register and create an [Account](https://app.reddeonline.com/register) on reddeonline. Header for all request should have {"apikey": "string"}: and this API key will be sent to merchant when their app configuration is setup for them by Wigal.

For more information on documentation go to developers.reddeonline.com

* [Installation](#installation)
* [Usage](#usage)
* [Examples](#examples)

## Installation
To use this library you'll need to have created a [Redde account](https://app.reddeonline.com/register).                     
Clone or download the repository 
```
git clone https://github.com/wigalsolutionsltd/redde-sdk-CSharp.git

```


## Usage

Enter your API key and App ID which was provided to you by the Redde Team:

```c#

#Import REDDE SDK into your project and add this to the imports to your .cs file
using Redde.v1.Services;
using Redde.V1.Model;

#Replace App ID with your App ID
int app_id = 349009;

#Enter Api Key
string api_key = "";


#Create an instance of Redde Class
Transactions red = new Transactions(api_key, app_id);

#Client Reference
string client_ref = ReddeUtilities.RandomClientTransactionID(6)

#Client ID
string client_id = ReddeUtilities.RandomClientTransactionID(6);


``` 


## Examples

#### Receiving money from Customer or Client

To use the API to recieve money from a customer, the ReceiveMoney() method will be used which takes takes the PayLoad object with required arguments which are: **amount, payment option(which is network type(MTN, AIRTELTIGO, VODAFONE)), phone number, client reference, client id, description, nickname** respectively.

```c#

#Import REDDE SDK into your project and add this to the imports to your .cs file
using Redde.v1.Services;
using Redde.V1.Model;

#Replace App ID with your App ID
int app_id = 349009;

#Enter Api Key
string api_key = "";


#Create an instance of Redde Class
Transactions red = new Transactions(api_key, app_id);

#Client Reference
string client_ref = ReddeUtilities.RandomClientTransactionID(6)

#Client ID
string client_id = ReddeUtilities.RandomClientTransactionID(6);

#PayLoad Object
var payload = new PayLoad
{
   amount = 0.5,
   clientreference = client_ref,
   clienttransid = client_id,
   description = "Testing of Api",
   nickname = "WIGALS",
   paymentoption = "VODAFONE",
   walletnumber = "233200000000"
};

Console.WriteLine(red.ReceiveMoney(payload));


```


#### Sending money to a Customer or Client

To use the API to recieve money from a customer, the SendMoney() method will be used which takes takes the PayLoad object with required arguments which are: **amount, payment option(which is network type(MTN, AIRTELTIGO, VODAFONE)), phone number, client reference, client id, description, nickname** respectively.

```c#


#Enter App ID
int app_id = 349009;

#Enter Api Key
string api_key = "";

#Create an instance of Redde Class
Transactions red = new Transactions(api_key, app_id);

#Client Reference
string client_ref = ReddeUtilities.RandomClientTransactionID(6)

#Client ID
string client_id = ReddeUtilities.RandomClientTransactionID(6);

#PayLoad Object
var payload = new PayLoad
{
   amount = 0.5,
   clientreference = client_ref,
   clienttransid = client_id,
   description = "Testing of Api",
   nickname = "WIGALS",
   paymentoption = "VODAFONE",
   walletnumber = "233200000000"
};

Console.WriteLine(red.SendMoney(payload));

```

## Callbacks

You need to setup your callback URL for the apps we create for you on Redde

1. Login to your Redde account
2. Click on the Apps link on the navigation bar
3. You will see your list of apps in a table. Click on the modify button
4. Add your callback url(s) for both the Receive Callback URL and Cash Out Callback URL
5. Apply changes and you are all set.

Most APIs implement callbacks for easy tracking of api transactions so try and implement it to keep track of the API transactions.
```c#

//Callback Url Endpoint

```

# License
This library is released under the MIT License