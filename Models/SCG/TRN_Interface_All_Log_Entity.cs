using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace AddonProcurement.Models.SCG
{
    public class TRN_Interface_All_Log_Entity
    {
        public static String TableName = "TRN_Interface_All_Log";


        #region Struct...
        /// <summary>
        /// 
        /// </summary>
        public struct FieldName
        {
            /// <summary>
            /// 
            /// </summary>
            public const string LogID = "LogID";
            /// <summary>
            /// 
            /// </summary>
            public const string LogProcess = "LogProcess";
            /// <summary>
            /// 
            /// </summary>
            public const string LogValue = "LogValue";
            /// <summary>
            /// 
            /// </summary>
            public const string LogDate = "LogDate";
        }

        #endregion

        #region Fields...
        private int fLogID;
        private String fLogProcess;
        private String fLogValue;
        private DateTime fLogDate;
        #endregion

        #region Properties...

        /// <summary>
        /// 
        /// </summary>
        public int LogID
        {
            get
            {
                return fLogID;
            }

            set
            {
                fLogID = value;
            }

        }

        /// <summary>
        /// 
        /// </summary>
        public String LogProcess
        {
            get
            {
                return fLogProcess;
            }

            set
            {
                fLogProcess = value;
            }

        }

        /// <summary>
        /// 
        /// </summary>
        public String LogValue
        {
            get
            {
                return fLogValue;
            }

            set
            {
                fLogValue = value;
            }

        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime LogDate
        {
            get
            {
                return fLogDate;
            }

            set
            {
                fLogDate = value;
            }

        }

        #endregion

    }
}