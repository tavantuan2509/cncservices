using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CNCServices.Core.Entities
{
    public class CheckCountResponse : BaseEntity
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
         * Danh sách số lượng thẻ còn theo nhà cung cấp
         */
        public string listprovider { set; get; }
    }
}