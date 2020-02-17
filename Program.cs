using System;
using REDDE.v1.Model;
using REDDE.v1.Services;


namespace CSHARP
{
     class Program
    {
        static void Main(string[] args)
        {
            //Enter App ID
            int app_id = 1098;

            //Enter Api Key
            string api_key = "BDGpL9D2Q7VnzqhPCU68f66zjAchhsNbmVbJNvAcD8B8hmEdnH";

            //Create an instance of Redde Package
            Transactions red = new Transactions(api_key, app_id);

            //Client Reference
            string client_ref = ReddeUtilities.ClientReferenceNumber(6);

            //Client ID
            string client_id = ReddeUtilities.RandomClientTransactionID(6);

            //Payload object
            var payload = new PayLoad
            {
                amount = 0.5,
                clientreference = client_ref,
                clienttransid = client_id,
                description = "Testing of Api",
                nickname = "WIGAL",
                paymentoption = "AIRTELTIGO",
                walletnumber = "233274323816"
            };
            

            Console.WriteLine(red.SendMoney(payload));

        }

}

}
