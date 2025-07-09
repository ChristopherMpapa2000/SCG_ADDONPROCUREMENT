using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace AddonProcurement.Models
{
    internal class BindingClient
    {
        public BasicHttpBinding Binding { get; set; }
        public EndpointAddress Endpoint { get; set; }
    }
}
