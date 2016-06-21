using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CNCServices.Core.Entities
{
    public class CheckCountRequest : BaseEntity
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
         * Mệnh giá
         */
        public Int32 amount { set; get; }        
    }
}