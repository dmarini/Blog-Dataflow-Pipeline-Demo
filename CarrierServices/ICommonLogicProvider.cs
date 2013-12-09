
using CommonModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CarrierServices
{
    internal interface ICommonLogicProvider
    {
        IEnumerable<ItemTrackingDetail> ProcessShipDetails(List<ShipDetail> shipDetails, string carrierName);
    }
}
