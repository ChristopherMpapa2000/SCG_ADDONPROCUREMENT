using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace AddonProcurement.Models.SCG
{
    public class TRN_GI_Item_Entity
    {

        public static String TableName = "TRN_GI_Item";


        public int GI_HEADER_ID { get; set; }
        public String GI_ITEM_NO { get; set; }
        public String GI_MAT_NO { get; set; }
        public String GI_MAT_DESC { get; set; }
        public String GI_MAT_TYPE { get; set; }
        public String GI_MAT_TYPE_DESC { get; set; }
        public String GI_MAT_UNIT { get; set; }
        public Decimal GI_STOCK_QTY { get; set; }
        public Decimal GI_RESERVED_QTY { get; set; }
        public Decimal GI_AVAILABLE_QTY { get; set; }     
        public Decimal GI_QTY { get; set; }
        public Boolean GI_APPROVE_ITEM { get; set; }
        public Boolean GI_POST { get; set; }
        public String GI_POST_STATUS { get; set; }
        public String GI_POST_TEXT { get; set; }
        public String GI_MAT_DOC { get; set; }
        public DateTime GI_MAT_DOC_YEAR { get; set; }
        public int GI_MAT_DOC_ITEM_NO { get; set; }
 

    }
}