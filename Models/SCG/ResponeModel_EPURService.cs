using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddonProcurement.EPURServiceReference;

namespace AddonProcurement.Models.SCG
{
    public class ResponeModel_EPURService
    {

        public ResponeModel_EPURService()
        {
            @return = new EpurReturn();
        }

        public string TYPE { get; set; }
        public string MESSAGE { get; set; }
        public string EKKO_EBELN { get; set; }
        public string Send_to_RMM { get; set; }

        public EpurReturn @return { get; set; }

        public class ErrorDetail
        {
            public string TYPE { get; set; }
            public string MESSAGE { get; set; }
            public string EKKO_EBELN { get; set; }
            public string Send_to_RMM { get; set; }
        }

    }
}
