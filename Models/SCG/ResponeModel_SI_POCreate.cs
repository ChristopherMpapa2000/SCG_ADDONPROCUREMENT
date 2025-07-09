using AddonProcurement.SI_POCreateServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddonProcurement.Models.SCG
{
    public class ResponeModel_SI_POCreate
    {

        public ResponeModel_SI_POCreate()
        {
            @return = new DT_POReturn();
        }
        public string TYPE { get; set; }
        public string MESSAGE { get; set; }
        public string PO_NO { get; set; }
        public string PO_CURR { get; set; }
        public string PO_EXCH { get; set; }
        public string PO_TOTAL { get; set; }

        public DT_POReturn @return { get; set; }

        public class ErrorDetail
        {
            public string TYPE { get; set; }
            public string MESSAGE { get; set; }
            public string PO_NO { get; set; }
            public string PO_CURR { get; set; }
            public string PO_EXCH { get; set; }
            public string PO_TOTAL { get; set; }

        }

    }
}
