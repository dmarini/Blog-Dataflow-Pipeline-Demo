using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommonModels
{
    public class ShipDetail
    {
        public Guid ShipId { get; set; }
        public List<ShipItemInfo> Items { get; set; }
    }
}