using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace CNCServices.Core.Entities
{
    public class BaseEntity
    {        
        public String toString()
        {
            return (new JavaScriptSerializer()).Serialize(this);            
        }
    }
}