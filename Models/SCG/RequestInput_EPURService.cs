using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddonProcurement.EPURServiceReference;

namespace AddonProcurement.Models.SCG
{
    public class RequestInput_EPURService
    {

        public DT_PODetailHeader PO_Header { get; set; }

        public List<DT_PODetailItem> List_POItem { get; set; }

        public DT_PODetailCondHeader PO_Cond_Header { get; set; }

        public List<DT_PODetailCondItem> List_CondItem { get; set; }

        public List<DT_PODetailAccAssignment> List_AccAss { get; set; }


        public DOHeader DO_Header { get; set; }

        public List<DOItem> DO_Item { get; set; }


    }
}
