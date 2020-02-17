using System;
using System.Collections.Generic;
using System.Text;

namespace REDDE.v1.Model
{
    public class PayLoad
    {
        /// <summary>
        /// amount
        /// </summary>
        public double amount { get; set; }
        /// <summary>
        /// AppId provided by WIGAL
        /// </summary>
        public int appid { get; set; }
        /// <summary>
        /// client reference for transaction
        /// </summary>
        public string clientreference { get; set; }
        /// <summary>
        /// transaction id
        /// </summary>
        public string clienttransid { get; set; }
        /// <summary>
        /// transaction description
        /// </summary>
        public string description { get; set; }
        /// <summary>
        /// your nickname or service nickname
        /// </summary>
        public string nickname { get; set; }
        /// <summary>
        /// payment option eg: (MTN, AIRTELTIGO etc)
        /// </summary>
        public string paymentoption { get; set; }
        /// <summary>
        /// wallet number or mobile number
        /// </summary>
        public string walletnumber { get; set; }
    }
}
