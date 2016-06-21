using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CNCServices.Core.Entities
{
    public class ResponseTopup : BaseEntity
    {
        /**
     * Mã lỗi
     */
        public Int32 code { set; get; }
        /**
         * Mô tả lỗi
         */
        public string msg { set; get; }
        /**
         * mã giao dịch
         */
        public string tranid { set; get; }
    }
}