using Newtonsoft.Json;
using REDDE.v1.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace REDDE.v1.Services
{
    public class Transactions : ITransactions
    {
        private string _apiKey;
        private int _appID;

        private string _url = "https://api.reddeonline.com/v1/";



        /// <summary>
        /// initialize transaction object
        /// </summary>
        /// <param name="ApiKey">ApiKey received from redde/wigal</param>
        /// <param name="AppID">AppID received from redde/wigal</param>
        public Transactions(string ApiKey, int AppID)
        {
            _apiKey = ApiKey;
            _appID = AppID;
        }
        public string ReceiveMoney(PayLoad model)
        {
            try
            {
                var _receive_url = string.Format("{0}receive", _url);
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(_receive_url);
                httpWebRequest.ContentType = "application/json; charset=utf-8";
                httpWebRequest.Method = "POST";
                httpWebRequest.Headers.Add("ApiKey", this._apiKey);

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = JsonConvert.SerializeObject(model, Formatting.Indented);
                    streamWriter.Write(json);
                    streamWriter.Flush();
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var responseText = streamReader.ReadToEnd();
                    return responseText.ToString();
                }
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }

        public string SendMoney(PayLoad model)
        {
            try
            {
                string cashout_url = string.Format("{0}cashout", _url);

                var httpWebRequest = (HttpWebRequest)WebRequest.Create(cashout_url);
                httpWebRequest.ContentType = "application/json; charset=utf-8";
                httpWebRequest.Method = "POST";
                httpWebRequest.Headers.Add("ApiKey", this._apiKey);

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = JsonConvert.SerializeObject(model, Formatting.Indented);
                    streamWriter.Write(json);
                    streamWriter.Flush();
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var responseText = streamReader.ReadToEnd();
                    return responseText.ToString();
                }


            }
            catch (WebException ex)
            {
                return ex.Message;
            }
        }
    }
}
