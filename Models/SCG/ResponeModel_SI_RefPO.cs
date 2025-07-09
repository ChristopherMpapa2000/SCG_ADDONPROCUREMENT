using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddonProcurement.Models.SCG
{
    public class ResponeModel_SI_RefPO
    {
        public ResponeModel_SI_RefPO()
        {
            @return = new List<ErrorDetail>();
        }

        public string TYPE { get; set; }
        public string MESSAGE { get; set; }
        public string MJAHR { get; set; }
        public string MBLNR { get; set; }

        public List<ErrorDetail> @return { get; set; }
        public class ErrorDetail
        {
            public string TYPE { get; set; }
            public string MESSAGE { get; set; }
            public string MJAHR { get; set; }
            public string MBLNR { get; set; }
        }

    }
}
