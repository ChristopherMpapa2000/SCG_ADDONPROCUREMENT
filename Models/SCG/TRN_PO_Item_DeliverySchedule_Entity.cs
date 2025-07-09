using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace AddonProcurement.Models.SCG
{
    public class TRN_PO_Item_DeliverySchedule_Entity
    {

        public static String TableName = "TRN_PO_Item_DeliverySchedule";
        public static String ViewName = "PO_Item_DeliverySchedule_VIEW";

        public struct FieldName
        {
            public const string PODELISCHENO = "PODELISCHENO";
            public const string PO_ITEM_ID = "PO_ITEM_ID";
            public const string DELIVERYDATE = "DELIVERYDATE";
            public const string TIMEPERIOD = "TIMEPERIOD";
            public const string DELIVERYQTY = "DELIVERYQTY";
        }

        public int PODELISCHENO { get; set; }
        public int PO_ITEM_ID { get; set; }
        public DateTime DELIVERYDATE { get; set; }
        public string TIMEPERIOD { get; set; }
        public Decimal DELIVERYQTY { get; set; }

        public Boolean CanDelete_CustomField_ { get; set; }


    }
}