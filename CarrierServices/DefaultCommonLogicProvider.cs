using CommonModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CarrierServices
{
    public class DefaultCommonLogicProvider : ICommonLogicProvider
    {
        public IEnumerable<ItemTrackingDetail> ProcessShipDetails(List<ShipDetail> shipDetails, string carrierName)
        {
            foreach (var shipDetail in shipDetails)
            {
                var trackingDetail = new ItemTrackingDetail
                {
                    CarrierName = carrierName,
                    ShippingId = shipDetail.ShipId
                };

                foreach (var item in shipDetail.Items)
                    trackingDetail.Items.Add(new ItemTrackingInfo
                        {
                            Sku = item.Sku,
                            TrackingNumber = GenerateTrackingNumber()
                        });

                yield return trackingDetail;
            }
        }

        private string GenerateTrackingNumber()
        {
            return Guid.NewGuid().ToString().Replace("-", "");
        }
    }
}
