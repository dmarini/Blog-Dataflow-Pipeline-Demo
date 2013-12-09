using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommonModels
{
    public class ItemTrackingDetail
    {
        public ItemTrackingDetail()
        {
            Items = new List<ItemTrackingInfo>();
        }

        public string CarrierName { get; set; }
        public Guid ShippingId { get; set; }
        public List<ItemTrackingInfo> Items { get; set; }
    }
}