using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace AddonProcurement.Models.SCG
{
    public class TRN_PO_Header_Entity
    {

        public static String TableName = "TRN_PO_Header";
        public struct FieldName
        {
            public const string PO_HEADER_ID = "PO_HEADER_ID";
            public const string PO_INTERFACE_NO = "PO_INTERFACE_NO";
            public const string PO_INTERFACE_NAME = "PO_INTERFACE_NAME";
            public const string PO_NO = "PO_NO";
            public const string PO_EPUR_NO = "PO_EPUR_NO";
            public const string PO_REVISION = "PO_REVISION";
            public const string PO_TYPE = "PO_TYPE";
            public const string PO_TAX_ID = "PO_TAX_ID";
            public const string PO_TAX_CODE = "PO_TAX_CODE";
            public const string PO_TYPE_DESC = "PO_TYPE_DESC";
            public const string PO_CREATE_BY = "PO_CREATE_BY";
            public const string PO_CREATE_BY_NAME = "PO_CREATE_BY_NAME";
            public const string PO_CREATE_BY_CONTACT = "PO_CREATE_BY_CONTACT";
            public const string PO_VENDOR = "PO_VENDOR";
            public const string PO_VENDOR_NAME = "PO_VENDOR_NAME";
            public const string PO_VENDOR_STREET = "PO_VENDOR_STREET";
            public const string PO_VENDOR_IND = "PO_VENDOR_IND";
            public const string PO_VENDOR_EMAIL = "PO_VENDOR_EMAIL";
            public const string PO_VENDOR_TEL = "PO_VENDOR_TEL";
            public const string PO_VENDOR_FAX = "PO_VENDOR_FAX";
            public const string PO_VENDOR_EXTENSION = "PO_VENDOR_EXTENSION";
            public const string PO_VENDOR_POSTAL = "PO_VENDOR_POSTAL";        //------------------------------NEW
            public const string PO_VENDOR_CITY = "PO_VENDOR_CITY";            //------------------------------NEW
            //public const string PO_VENDOR_POSTALCITY = "PO_VENDOR_POSTALCITY";//    ------------------------------OLD
            public const string PO_VENDOR_COUNTRY = "PO_VENDOR_COUNTRY";
            public const string PO_DOC_DATE = "PO_DOC_DATE";
            public const string PO_PAYMENT_TERM = "PO_PAYMENT_TERM";
            public const string PO_PAYMENT_TERM_DESC = "PO_PAYMENT_TERM_DESC";
            public const string PO_INCOTERM = "PO_INCOTERM";
            public const string PO_INCOTERM_DESC = "PO_INCOTERM_DESC";
            public const string PO_SHIPTO_ADDRESS = "PO_SHIPTO_ADDRESS";
            public const string PO_CONTACT_PERSON = "PO_CONTACT_PERSON";
            public const string PO_CONTACT_NO = "PO_CONTACT_NO";
            public const string PO_ACCT_ASSGT = "PO_ACCT_ASSGT";
            public const string PO_CURR = "PO_CURR";
            public const string PO_EXCH = "PO_EXCH";
            public const string PO_HEADER_NOTE = "PO_HEADER_NOTE";
            public const string PO_PUR_ORG = "PO_PUR_ORG";
            public const string PO_PUR_GRP = "PO_PUR_GRP";
            public const string PO_PUR_GRP_CODE = "PO_PUR_GRP_CODE";
            public const string PO_PUR_GRP_NAME = "PO_PUR_GRP_NAME";
            public const string PO_PUR_GRP_EMAIL = "PO_PUR_GRP_EMAIL";
            public const string PO_COM_CODE = "PO_COM_CODE";
            public const string PO_COM_NAME = "PO_COM_NAME";
            public const string PO_REL1 = "PO_REL1";
            public const string PO_REL_TXT1 = "PO_REL_TXT1";
            public const string PO_CURR_LEVEL = "PO_CURR_LEVEL";
            public const string PO_TOTAL = "PO_TOTAL";
            public const string PO_TOTAL_IDR = "PO_TOTAL_IDR";
            public const string PO_REMARK = "PO_REMARK";
            public const string CURRENTACTIVITY = "CURRENTACTIVITY";
            public const string RESPONSIBLE = "RESPONSIBLE";
            public const string STATUS = "STATUS";
            public const string ResponsibleName = "ResponsibleName";
            public const string ApproveLevel = "ApproveLevel";
        }
        public int PO_HEADER_ID { get; set; }
        public string PO_INTERFACE_NO { get; set; }
        public string PO_INTERFACE_NAME { get; set; }
        public string PO_NO { get; set; }
        public string PO_EPUR_NO { get; set; }
        public int PO_REVISION { get; set; }
        public string PO_TYPE { get; set; }
        public string PO_TYPE_DESC { get; set; }
        public string PO_TAX_ID { get; set; }
        public string PO_TAX_CODE { get; set; }
        public string PO_CREATE_BY { get; set; }
        public string PO_CREATE_BY_NAME { get; set; }
        public string PO_CREATE_BY_CONTACT { get; set; }
        public string PO_VENDOR { get; set; }
        public string PO_VENDOR_NAME { get; set; }
        public string PO_VENDOR_STREET { get; set; }
        public string PO_VENDOR_IND { get; set; }
        public string PO_VENDOR_EMAIL { get; set; }
        public string PO_VENDOR_TEL { get; set; }
        public string PO_VENDOR_FAX { get; set; }
        public string PO_VENDOR_EXTENSION { get; set; }
        public string PO_VENDOR_POSTAL { get; set; }      //------------------------------NEW
        public string PO_VENDOR_CITY { get; set; }        //------------------------------NEW
        //public string PO_VENDOR_POSTALCITY { get; set; }//  ------------------------------OLD
        public string PO_VENDOR_COUNTRY { get; set; }
        public DateTime PO_DOC_DATE { get; set; }
        public string PO_PAYMENT_TERM { get; set; }
        public string PO_PAYMENT_TERM_DESC { get; set; }
        public string PO_INCOTERM { get; set; }
        public string PO_INCOTERM_DESC { get; set; }
        public string PO_SHIPTO_ADDRESS { get; set; }
        public string PO_CONTACT_PERSON { get; set; }
        public string PO_CONTACT_NO { get; set; }
        public string PO_ACCT_ASSGT { get; set; }
        public string PO_CURR { get; set; }
        public Decimal PO_EXCH { get; set; }
        public string PO_HEADER_NOTE { get; set; }
        public string PO_PUR_ORG { get; set; }
        public string PO_PUR_GRP { get; set; }
        public string PO_PUR_GRP_CODE { get; set; }
        public string PO_PUR_GRP_NAME { get; set; }
        public string PO_PUR_GRP_EMAIL { get; set; }
        public string PO_COM_CODE { get; set; }
        public string PO_COM_NAME { get; set; }
        public string PO_REL1 { get; set; }
        public string PO_REL_TXT1 { get; set; }
        public string PO_CURR_LEVEL { get; set; }
        public Decimal PO_TOTAL { get; set; }
        public Decimal PO_TOTAL_IDR { get; set; }
        public string PO_TRANSPORT { get; set; }
        public string PO_REMARK { get; set; }
        public string CURRENTACTIVITY { get; set; }
        public string RESPONSIBLE { get; set; }
        public string STATUS { get; set; }
        public string ResponsibleName { get; set; }
        public int ApproveLevel { get; set; }

        public string PO_PLANT_DESC { get; set; }



    }
}