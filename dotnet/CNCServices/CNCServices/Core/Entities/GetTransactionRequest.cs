using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CNCServices.Core.Entities
{
    public class GetTransactionRequest : BaseEntity
    {
        /**
         * mã đối tác
         */
        public string agentcode { set; get; }
        /**
         * Mã giao dịch đối tác
         */
        public string tranid { set; get; }        
    }    
}