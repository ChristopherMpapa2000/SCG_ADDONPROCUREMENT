using AddonProcurement.SI_StockMove_EINVServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddonProcurement.Models.SCG
{
    public class RequestInput_SI_StockMove
    {

        public DT_StockMoveHeader StockMoveHeader { get; set; }

        public List<DT_StockMoveItem> List_StockMoveItem { get; set; }


    }
}
