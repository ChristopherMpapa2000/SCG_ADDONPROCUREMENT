using AddonProcurement.SI_RefPO_EPURServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddonProcurement.Models.SCG
{
    public class RequestInput_SI_RefPO
    {

        public DT_RefPOHeader GR_Header { get; set; }

        public List<DT_RefPOItem> List_GRItem { get; set; }




    }
}
