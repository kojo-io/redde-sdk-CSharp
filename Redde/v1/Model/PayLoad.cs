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
        public double Amount { get; set; }
        /// <summary>
        /// AppId provided by WIGAL
        /// </summary>
        public int AppId { get; set; }
        /// <summary>
        /// client reference for transaction
        /// </summary>
        public string ClientReference { get; set; }
        /// <summary>
        /// transaction id
        /// </summary>
        public string ClientTransactionId { get; set; }
        /// <summary>
        /// transaction description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// your nickname or service nickname
        /// </summary>
        public string Nickname { get; set; }
        /// <summary>
        /// payment option eg: (MTN, AIRTELTIGO etc)
        /// </summary>
        public string PaymentOption { get; set; }
        /// <summary>
        /// wallet number or mobile number
        /// </summary>
        public string WalletNumber { get; set; }
    }
}
