using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InterFloraWebAPI.Models
{
    public class Customer
    {
        public string CustomerID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Order> Orders { get; set; }
        public DateTime TimeSent { get; set; }
        public DateTime TimeUpdated { get; set; }
    }
}