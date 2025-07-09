using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace AddonProcurement.Models.SCG
{
    public class STOCK_FOR_MANUAL_VIEW_Entity
    {

        public static String TableName = "STOCK_FOR_MANUAL_VIEW";


        public String PLANT_CODE { get; set; }
        public String MAT_NO { get; set; }
        public String MAT_DESC { get; set; }
        public String MAT_TYPE { get; set; }
        public String MAT_TYPE_DESC { get; set; }
        public Decimal QTY { get; set; }
        public String UNIT { get; set; }
        

    }
}