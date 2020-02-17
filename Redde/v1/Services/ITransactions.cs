using REDDE.v1.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace REDDE.v1.Services
{
    public interface ITransactions
    {
        /// <summary>
        /// receive money from client
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        string ReceiveMoney(PayLoad model);
        /// <summary>
        /// send money to client
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        string SendMoney(PayLoad model);
    }
}
