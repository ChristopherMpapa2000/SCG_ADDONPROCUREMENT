using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace AddonProcurement.Models.SCG
{

    public class TRN_PO_Item_AcctAssgt_Entity
    {
        public static String TableName = "TRN_PO_Item_AcctAssgt";
        public struct FieldName
        {
            public const string ACCTASSGT_ID = "ACCTASSGT_ID";
            public const string PO_ITEM_ID = "PO_ITEM_ID";
            public const string PO_NO = "PO_NO";
            public const string PO_ITEM_NO = "PO_ITEM_NO";
            public const string PO_QTY = "PO_QTY";
            public const string PO_PERCENT = "PO_PERCENT";
            public const string PO_GL_ACC_NO = "PO_GL_ACC_NO";
            public const string PO_BA_NO = "PO_BA_NO";
            public const string PO_ASSET_NO = "PO_ASSET_NO";
            public const string PO_ASSETSUB_NO = "PO_ASSETSUB_NO";
            public const string PO_COST_CTR_NO = "PO_COST_CTR_NO";
            public const string PO_ORDER_NO = "PO_ORDER_NO";
        }

        public int ACCTASSGT_ID { get; set; }
        public int PO_ITEM_ID { get; set; }
        public string PO_NO { get; set; }
        public string PO_ITEM_NO { get; set; }
        public Decimal PO_QTY { get; set; }
        public Decimal PO_PERCENT { get; set; }
        public string PO_GL_ACC_NO { get; set; }
        public string PO_BA_NO { get; set; }
        public string PO_ASSET_NO { get; set; }
        public string PO_ASSETSUB_NO { get; set; }
        public string PO_COST_CTR_NO { get; set; }
        public string PO_ORDER_NO { get; set; }

    }
}