using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddonProcurement.Models.SCG
{
    public class RequestInput_SI_POCreate
    {

        public  TRN_PO_Header_Entity PO_Header { get; set; }
        public List<TRN_PO_Condition_Header_Entity> List_CondHead { get; set; }
        public List<TRN_PO_Item_Entity> List_POItem { get; set; }
        public List<TRN_PO_Condition_Item_Entity> List_CondItem { get; set; }
        public List<TRN_PO_Item_AcctAssgt_Entity> List_AcctAssgt { get; set; }
        public List<TRN_PO_Item_DeliverySchedule_Entity> List_Delivery { get; set; }




    }
}
