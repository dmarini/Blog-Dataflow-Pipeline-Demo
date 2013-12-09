using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommonModels
{
    public class ItemTrackingInfo
    {
        public Guid Sku { get; set; }
        public string TrackingNumber { get; set; }
    }
}