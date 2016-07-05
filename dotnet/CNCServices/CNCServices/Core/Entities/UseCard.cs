using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CNCServices.Core.Entities
{
    public class UseCard : BaseEntity
    {
        /**
        * mã đối tác
        */
        public string agentcode { set; get; }
        /**
         * Mã đơn vị phát hành thẻ
         */
        public string catecode { set; get; }
        /**
         * Mã giao dịch đối tác
         */
        public string tranid { set; get; }
        /**
         * Mã thẻ
         */
        public string cardcode { set; get; }
        /**
         * serial thẻ
         */
        public string cardserial { set; get; }
    }
}