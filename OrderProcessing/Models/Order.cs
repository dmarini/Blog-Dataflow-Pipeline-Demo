using CommonModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    public class Order
    {
        public Guid OrderId { get; set; }
        public CarrierType Carrier { get; set; }
        public List<OrderItem> Items { get; set; }
    }
}
