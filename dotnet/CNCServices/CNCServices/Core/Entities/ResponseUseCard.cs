using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CNCServices.Core.Entities
{
    public class ResponseUseCard : BaseEntity
    {
        /**
         * Mã lỗi
         */
        public string code { set; get; }
        /**
         * Mô tả lỗi
         */
        public string msg { set; get; }
        /**
         * Mã giao dịch
         */
        public string tranid { set; get; }
        /**
         * Mệnh giá
         */
        public Int32 amount { set; get; }
    }
}