using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ds028414_MIS4200.Models
{
    public class order
    {
        public int orderID { get; set; }
        public int studentID { get; set; }
        public virtual student student { get; set; }
        public DateTime orderDate { get; set; }
    }
}