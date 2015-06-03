using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InterFloraWebAPI.Models
{
    public class Order
    {
        public string OrderId { get; set; }
        public string OrderName { get; set; }
        public string OrderEmail { get; set; }
        public string DeliveryAddress { get; set; }
        public int Price { get; set; }
        public DateTime TimeSent { get; set; }
    }
}