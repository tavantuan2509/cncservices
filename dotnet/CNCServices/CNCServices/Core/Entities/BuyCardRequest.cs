using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CNCServices.Core.Entities
{
    public class BuyCardRequest : BaseEntity
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
         * Mệnh giá
         */
        public Int32 amount { set; get; }
        /**
         * Số lượng
         */
        public Int32 quantity { set; get; }
    }
}