﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AddonProcurement.SI_CanceServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:scg.co.th:CBMR:EPURCHASING:STOCK", ConfigurationName="SI_CanceServiceReference.SI_Cancel")]
    public interface SI_Cancel {
        
        // CODEGEN: Generating message contract since the operation SI_Cancel is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://sap.com/xi/WebService/soap1.1", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        AddonProcurement.SI_CanceServiceReference.SI_CancelResponse SI_Cancel(AddonProcurement.SI_CanceServiceReference.SI_CancelRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sap.com/xi/WebService/soap1.1", ReplyAction="*")]
        System.Threading.Tasks.Task<AddonProcurement.SI_CanceServiceReference.SI_CancelResponse> SI_CancelAsync(AddonProcurement.SI_CanceServiceReference.SI_CancelRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:scg.co.th:CBMR:EPURCHASING:STOCK")]
    public partial class DT_Cancel : object, System.ComponentModel.INotifyPropertyChanged {
        
        private DT_CancelDocument documentField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public DT_CancelDocument Document {
            get {
                return this.documentField;
            }
            set {
                this.documentField = value;
                this.RaisePropertyChanged("Document");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:scg.co.th:CBMR:EPURCHASING:STOCK")]
    public partial class DT_CancelDocument : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string pST_DTField;
        
        private string mBLNRField;
        
        private string mJAHRField;
        
        private string uSNAMEField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string PST_DT {
            get {
                return this.pST_DTField;
            }
            set {
                this.pST_DTField = value;
                this.RaisePropertyChanged("PST_DT");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string MBLNR {
            get {
                return this.mBLNRField;
            }
            set {
                this.mBLNRField = value;
                this.RaisePropertyChanged("MBLNR");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string MJAHR {
            get {
                return this.mJAHRField;
            }
            set {
                this.mJAHRField = value;
                this.RaisePropertyChanged("MJAHR");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string USNAME {
            get {
                return this.uSNAMEField;
            }
            set {
                this.uSNAMEField = value;
                this.RaisePropertyChanged("USNAME");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:scg.co.th:CBMR:EPURCHASING:STOCK")]
    public partial class DT_Return : object, System.ComponentModel.INotifyPropertyChanged {
        
        private DT_ReturnReturn returnField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public DT_ReturnReturn Return {
            get {
                return this.returnField;
            }
            set {
                this.returnField = value;
                this.RaisePropertyChanged("Return");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:scg.co.th:CBMR:EPURCHASING:STOCK")]
    public partial class DT_ReturnReturn : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string tYPEField;
        
        private string mESSAGEField;
        
        private string mBLNRField;
        
        private string mJAHRField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string TYPE {
            get {
                return this.tYPEField;
            }
            set {
                this.tYPEField = value;
                this.RaisePropertyChanged("TYPE");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string MESSAGE {
            get {
                return this.mESSAGEField;
            }
            set {
                this.mESSAGEField = value;
                this.RaisePropertyChanged("MESSAGE");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string MBLNR {
            get {
                return this.mBLNRField;
            }
            set {
                this.mBLNRField = value;
                this.RaisePropertyChanged("MBLNR");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string MJAHR {
            get {
                return this.mJAHRField;
            }
            set {
                this.mJAHRField = value;
                this.RaisePropertyChanged("MJAHR");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SI_CancelRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:scg.co.th:CBMR:EPURCHASING:STOCK", Order=0)]
        public AddonProcurement.SI_CanceServiceReference.DT_Cancel MT_Cancel;
        
        public SI_CancelRequest() {
        }
        
        public SI_CancelRequest(AddonProcurement.SI_CanceServiceReference.DT_Cancel MT_Cancel) {
            this.MT_Cancel = MT_Cancel;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SI_CancelResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:scg.co.th:CBMR:EPURCHASING:STOCK", Order=0)]
        public AddonProcurement.SI_CanceServiceReference.DT_Return MT_Return;
        
        public SI_CancelResponse() {
        }
        
        public SI_CancelResponse(AddonProcurement.SI_CanceServiceReference.DT_Return MT_Return) {
            this.MT_Return = MT_Return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SI_CancelChannel : AddonProcurement.SI_CanceServiceReference.SI_Cancel, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SI_CancelClient : System.ServiceModel.ClientBase<AddonProcurement.SI_CanceServiceReference.SI_Cancel>, AddonProcurement.SI_CanceServiceReference.SI_Cancel {
        
        public SI_CancelClient() {
        }
        
        public SI_CancelClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SI_CancelClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SI_CancelClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SI_CancelClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AddonProcurement.SI_CanceServiceReference.SI_CancelResponse AddonProcurement.SI_CanceServiceReference.SI_Cancel.SI_Cancel(AddonProcurement.SI_CanceServiceReference.SI_CancelRequest request) {
            return base.Channel.SI_Cancel(request);
        }
        
        public AddonProcurement.SI_CanceServiceReference.DT_Return SI_Cancel(AddonProcurement.SI_CanceServiceReference.DT_Cancel MT_Cancel) {
            AddonProcurement.SI_CanceServiceReference.SI_CancelRequest inValue = new AddonProcurement.SI_CanceServiceReference.SI_CancelRequest();
            inValue.MT_Cancel = MT_Cancel;
            AddonProcurement.SI_CanceServiceReference.SI_CancelResponse retVal = ((AddonProcurement.SI_CanceServiceReference.SI_Cancel)(this)).SI_Cancel(inValue);
            return retVal.MT_Return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<AddonProcurement.SI_CanceServiceReference.SI_CancelResponse> AddonProcurement.SI_CanceServiceReference.SI_Cancel.SI_CancelAsync(AddonProcurement.SI_CanceServiceReference.SI_CancelRequest request) {
            return base.Channel.SI_CancelAsync(request);
        }
        
        public System.Threading.Tasks.Task<AddonProcurement.SI_CanceServiceReference.SI_CancelResponse> SI_CancelAsync(AddonProcurement.SI_CanceServiceReference.DT_Cancel MT_Cancel) {
            AddonProcurement.SI_CanceServiceReference.SI_CancelRequest inValue = new AddonProcurement.SI_CanceServiceReference.SI_CancelRequest();
            inValue.MT_Cancel = MT_Cancel;
            return ((AddonProcurement.SI_CanceServiceReference.SI_Cancel)(this)).SI_CancelAsync(inValue);
        }
    }
}
