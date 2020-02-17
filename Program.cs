using System;


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
            Redde red = new Redde(api_key, app_id);

            //Client Reference
            string client_ref = red.clientReferenceNumber(6);

            //Client ID
            string client_id = red.randomClientID(6);

            Console.WriteLine(red.receiveMoney(0.52, "233274323816", client_ref, client_id, "AIRTELTIGO", "", "KAZITRIPS"));

        }

}

}
