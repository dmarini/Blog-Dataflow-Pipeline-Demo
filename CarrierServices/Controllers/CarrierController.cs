using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CarrierServices.Controllers
{
    public abstract class CarrierController : ApiController
    {
        private readonly ICommonLogicProvider _logicProvider;

        internal ICommonLogicProvider LogicProvider
        {
            get { return _logicProvider; }
        }

        internal CarrierController()
        {
            _logicProvider = new DefaultCommonLogicProvider();
        }
        protected abstract string CarrierName
        {
            get;
        }
    }
}
