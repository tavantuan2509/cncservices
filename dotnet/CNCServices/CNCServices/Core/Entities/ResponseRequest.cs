using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CNCServices.Core.Entities
{
    public class ResponseRequest : BaseEntity
    {
        /**
         * Mô tả lỗi
         */
        public string msg { set; get; }
        /**
         * Mã giao dịch đối tác
         */
        public string tranid { set; get; }
        /**
         * Mã lỗi
         */
        public Int32 code { set; get; }
        /**
         * Danh sách thẻ
         */
        public string listCards { set; get; }
    }
    public class BuyCardResponse : BaseEntity
    {
        public string provider_code { set; get; }
    }
}