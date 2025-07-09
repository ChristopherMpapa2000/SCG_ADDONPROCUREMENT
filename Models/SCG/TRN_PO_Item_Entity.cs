using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace AddonProcurement.Models.SCG
{
    public class TRN_PO_Item_Entity
    {

        public static String TableName = "TRN_PO_Item";
        public struct FieldName
        {
            public const string PO_ITEM_ID = "PO_ITEM_ID";
            public const string PO_HEADER_ID = "PO_HEADER_ID";
            public const string PR_ITEM_ID = "PR_ITEM_ID";
            public const string PO_ITEM_NO = "PO_ITEM_NO";
            public const string PO_DEL_IND = "PO_DEL_IND";
            public const string PO_ACC_CAT = "PO_ACC_CAT";
            public const string PO_MAT_NO = "PO_MAT_NO";
            public const string PO_MAT_SHORT_TXT = "PO_MAT_SHORT_TXT";
            public const string PO_MAT_TYPE = "PO_MAT_TYPE";
            public const string PO_MAT_TYPE_DESC = "PO_MAT_TYPE_DESC";
            public const string PO_MAT_GROUP = "PO_MAT_GROUP";
            public const string PO_MAT_GROUP_DESC = "PO_MAT_GROUP_DESC";
            public const string PO_OVERTOL = "PO_OVERTOL";
            public const string PO_UNDERTOL = "PO_UNDERTOL";
            public const string PO_QTY = "PO_QTY";
            public const string PO_ORDER_UNIT = "PO_ORDER_UNIT";
            public const string PO_DEL_DATE = "PO_DEL_DATE";
            public const string PO_NET_PRICE = "PO_NET_PRICE";
            public const string PO_CONV_OUN = "PO_CONV_OUN";
            public const string PO_CONV_OPU = "PO_CONV_OPU";
            public const string PO_PRICE_PER_UNI = "PO_PRICE_PER_UNI";
            public const string PO_NET_VELUE = "PO_NET_VELUE";
            public const string PO_AREA = "PO_AREA";
            public const string PO_AREA_DESC = "PO_AREA_DESC";
            public const string PO_PLANT = "PO_PLANT";
            public const string PO_PLANT_DESC = "PO_PLANT_DESC";
            public const string PO_SLOC = "PO_SLOC";
            public const string PO_SLOC_DESC = "PO_SLOC_DESC";
            public const string PO_PURGRP = "PO_PURGRP";
            public const string PO_PURGRP_NAME = "PO_PURGRP_NAME";
            public const string PO_SAPPURGRP = "PO_SAPPURGRP";
            public const string PO_VAT_VALUE = "PO_VAT_VALUE";
            public const string PR_NO = "PR_NO";
            public const string PR_EPUR_NO = "PR_EPUR_NO";
            public const string PR_ITEM_NO = "PR_ITEM_NO";
            public const string PO_ITEM_TEXT = "PO_ITEM_TEXT";
            public const string PO_TAXCODE = "PO_TAXCODE";
            public const string PO_DELIVERY_COMP = "PO_DELIVERY_COMP";
            public const string PO_FINAL_INV = "PO_FINAL_INV";
            public const string PO_APPROVE_ITEM = "PO_APPROVE_ITEM";
            public const string TABLE_NAME = "TRN_PO_ITEM";
        }

        public int PO_ITEM_ID { get; set; }
        public int PO_HEADER_ID { get; set; }
        public int PR_ITEM_ID { get; set; }
        public string PO_ITEM_NO { get; set; }
        public string PO_DEL_IND { get; set; }
        public string PO_ACC_CAT { get; set; }
        public string PO_MAT_NO { get; set; }
        public string PO_MAT_SHORT_TXT { get; set; }
        public string PO_MAT_TYPE { get; set; }
        public string PO_MAT_TYPE_DESC { get; set; }
        public string PO_MAT_GROUP { get; set; }
        public string PO_MAT_GROUP_DESC { get; set; }
        public Decimal PO_OVERTOL { get; set; }
        public Decimal PO_UNDERTOL { get; set; }
        public Decimal PO_QTY { get; set; }
        public string PO_ORDER_UNIT { get; set; }
        public DateTime PO_DEL_DATE { get; set; }
        public Decimal PO_NET_PRICE { get; set; }
        public Decimal PO_CONV_OUN { get; set; }
        public Decimal PO_CONV_OPU { get; set; }
        public Decimal PO_PRICE_PER_UNI { get; set; }
        public Decimal PO_NET_VELUE { get; set; }
        public string PO_AREA { get; set; }
        public string PO_AREA_DESC { get; set; }
        public string PO_PLANT { get; set; }
        public string PO_PLANT_DESC { get; set; }
        public string PO_SLOC { get; set; }
        public string PO_SLOC_DESC { get; set; }
        public string PO_PURGRP { get; set; }
        public string PO_PURGRP_NAME { get; set; }
        public string PO_SAPPURGRP { get; set; }
        public Decimal PO_VAT_VALUE { get; set; }
        public string PR_NO { get; set; }
        public string PR_EPUR_NO { get; set; }
        public string PR_ITEM_NO { get; set; }
        public string PO_ITEM_TEXT { get; set; }
        public string PO_TAXCODE { get; set; }
        public Boolean PO_DELIVERY_COMP { get; set; }
        public Boolean PO_FINAL_INV { get; set; }
        public Boolean PO_APPROVE_ITEM { get; set; }

        public Decimal Disc_CustomField_ { get; set; }


    }
}