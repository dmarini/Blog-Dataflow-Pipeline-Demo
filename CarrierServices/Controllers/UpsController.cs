using CommonModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CarrierServices.Controllers
{
    public class UpsController : CarrierController
    {
        protected override string CarrierName
        {
            get { return "UPS"; }
        }

        public List<ItemTrackingDetail> Post([FromBody]List<ShipDetail> shipDetails)
        {
            return LogicProvider.ProcessShipDetails(shipDetails, CarrierName).ToList();
        }
    }
}
