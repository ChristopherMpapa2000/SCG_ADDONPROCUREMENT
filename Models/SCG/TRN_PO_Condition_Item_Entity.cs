using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace AddonProcurement.Models.SCG
{
    public class TRN_PO_Condition_Item_Entity
    {

        public static String TableName = "TRN_PO_Condition_Item";
        public struct FieldName
        {
            public const string CONITEM_ID = "CONITEM_ID";
            public const string PO_ITEM_ID = "PO_ITEM_ID";
            public const string PO_COND_ITEM = "PO_COND_ITEM";
            public const string PO_COND_TP = "PO_COND_TP";
            public const string PO_COND_DESC = "PO_COND_DESC";
            public const string PO_COND_RT = "PO_COND_RT";
            public const string PO_COND_CURR = "PO_COND_CURR";
            public const string PO_COND_PRC_UNIT = "PO_COND_PRC_UNIT";
            public const string PO_COND_UNIT = "PO_COND_UNIT";
            public const string PO_COND_VEN = "PO_COND_VEN";
            public const string PO_COND_AMNT = "PO_COND_AMNT";
            public const string PO_COND_TYPE_HEAD = "PO_COND_TYPE_HEAD";
            public const string PO_COND_TYPE_ITEM = "PO_COND_TYPE_ITEM";
        }

        public int CONITEM_ID { get; set; }
        public int PO_ITEM_ID { get; set; }
        public string PO_COND_ITEM { get; set; }
        public string PO_COND_TP { get; set; }
        public string PO_COND_DESC { get; set; }
        public Decimal PO_COND_RT { get; set; }
        public string PO_COND_CURR { get; set; }
        public Decimal PO_COND_PRC_UNIT { get; set; }
        public string PO_COND_UNIT { get; set; }
        public string PO_COND_VEN { get; set; }
        public Decimal PO_COND_AMNT { get; set; }
        public Boolean PO_COND_TYPE_HEAD { get; set; }
        public Boolean PO_COND_TYPE_ITEM { get; set; }


        //---------------------_CustomField_-----------------------//
        public string PO_ITEM_NO_CustomField_ { get; set; }
        public string GUID_CustomField_ { get; set; }
        public string CalType_CustomField_ { get; set; }
        public Decimal PO_QTY_CustomField_ { get; set; }
        //---------------------_CustomField_-----------------------//



    }
}