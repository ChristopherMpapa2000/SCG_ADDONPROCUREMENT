using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace AddonProcurement.Models.SCG
{
    public class TRN_GR_NO_REF_Entity
    {

        public static String TableName = "TRN_GR_NO_REF";

        public String GR_MAT_NO { get; set; }
        public String GR_MAT_DESC { get; set; }
        public String GR_MAT_TYPE { get; set; }
        public String GR_MAT_TYPE_DESC { get; set; }
        public String GR_PLANT_CODE { get; set; }
        public String GR_PLANT_DESC { get; set; }
        public String GR_SLOC { get; set; }
        public String GR_SLOC_DESC { get; set; }
        public Decimal GR_QTY { get; set; }
        public String GR_UNIT { get; set; }
        public String GR_POST_STATUS { get; set; }
        public String GR_POST_TEXT { get; set; }
        public String GR_MAT_DOC { get; set; }
        public DateTime GR_MAT_DOC_YEAR { get; set; }

        
    }
}