﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JazzFaxGatewayStatus.FaxGateway {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FaxDto", Namespace="http://schemas.datacontract.org/2004/07/UBC.Services.FaxService.Api.Data.Dto")]
    [System.SerializableAttribute()]
    public partial class FaxDto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BillInfoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ClientFaxReferenceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ClientKeyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private JazzFaxGatewayStatus.FaxGateway.FaxAttachmentDto[] FaxAttachmentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int FaxRecordIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] SaltField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ToFaxNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ToNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool UseCoverSheetField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BillInfo {
            get {
                return this.BillInfoField;
            }
            set {
                if ((object.ReferenceEquals(this.BillInfoField, value) != true)) {
                    this.BillInfoField = value;
                    this.RaisePropertyChanged("BillInfo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ClientFaxReference {
            get {
                return this.ClientFaxReferenceField;
            }
            set {
                if ((object.ReferenceEquals(this.ClientFaxReferenceField, value) != true)) {
                    this.ClientFaxReferenceField = value;
                    this.RaisePropertyChanged("ClientFaxReference");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ClientKey {
            get {
                return this.ClientKeyField;
            }
            set {
                if ((object.ReferenceEquals(this.ClientKeyField, value) != true)) {
                    this.ClientKeyField = value;
                    this.RaisePropertyChanged("ClientKey");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public JazzFaxGatewayStatus.FaxGateway.FaxAttachmentDto[] FaxAttachment {
            get {
                return this.FaxAttachmentField;
            }
            set {
                if ((object.ReferenceEquals(this.FaxAttachmentField, value) != true)) {
                    this.FaxAttachmentField = value;
                    this.RaisePropertyChanged("FaxAttachment");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int FaxRecordId {
            get {
                return this.FaxRecordIdField;
            }
            set {
                if ((this.FaxRecordIdField.Equals(value) != true)) {
                    this.FaxRecordIdField = value;
                    this.RaisePropertyChanged("FaxRecordId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Salt {
            get {
                return this.SaltField;
            }
            set {
                if ((object.ReferenceEquals(this.SaltField, value) != true)) {
                    this.SaltField = value;
                    this.RaisePropertyChanged("Salt");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ToFaxNumber {
            get {
                return this.ToFaxNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.ToFaxNumberField, value) != true)) {
                    this.ToFaxNumberField = value;
                    this.RaisePropertyChanged("ToFaxNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ToName {
            get {
                return this.ToNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ToNameField, value) != true)) {
                    this.ToNameField = value;
                    this.RaisePropertyChanged("ToName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool UseCoverSheet {
            get {
                return this.UseCoverSheetField;
            }
            set {
                if ((this.UseCoverSheetField.Equals(value) != true)) {
                    this.UseCoverSheetField = value;
                    this.RaisePropertyChanged("UseCoverSheet");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
                }
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FaxAttachmentDto", Namespace="http://schemas.datacontract.org/2004/07/UBC.Services.FaxService.Api.Data.Dto.Docu" +
        "ment")]
    [System.SerializableAttribute()]
    public partial class FaxAttachmentDto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AttachmentNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AttachmentTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] DataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AttachmentName {
            get {
                return this.AttachmentNameField;
            }
            set {
                if ((object.ReferenceEquals(this.AttachmentNameField, value) != true)) {
                    this.AttachmentNameField = value;
                    this.RaisePropertyChanged("AttachmentName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AttachmentType {
            get {
                return this.AttachmentTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.AttachmentTypeField, value) != true)) {
                    this.AttachmentTypeField = value;
                    this.RaisePropertyChanged("AttachmentType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Data {
            get {
                return this.DataField;
            }
            set {
                if ((object.ReferenceEquals(this.DataField, value) != true)) {
                    this.DataField = value;
                    this.RaisePropertyChanged("Data");
                }
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StatusDto", Namespace="http://schemas.datacontract.org/2004/07/UBC.Services.FaxService.Api.Data.Dto")]
    [System.SerializableAttribute()]
    public partial class StatusDto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ClientFaxReferenceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ClientKeyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private JazzFaxGatewayStatus.FaxGateway.FaxErrorStatus FaxErrorStatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int FaxRecordIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private JazzFaxGatewayStatus.FaxGateway.FaxStatus FaxStatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int HandleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] SaltField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ClientFaxReference {
            get {
                return this.ClientFaxReferenceField;
            }
            set {
                if ((object.ReferenceEquals(this.ClientFaxReferenceField, value) != true)) {
                    this.ClientFaxReferenceField = value;
                    this.RaisePropertyChanged("ClientFaxReference");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ClientKey {
            get {
                return this.ClientKeyField;
            }
            set {
                if ((object.ReferenceEquals(this.ClientKeyField, value) != true)) {
                    this.ClientKeyField = value;
                    this.RaisePropertyChanged("ClientKey");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public JazzFaxGatewayStatus.FaxGateway.FaxErrorStatus FaxErrorStatus {
            get {
                return this.FaxErrorStatusField;
            }
            set {
                if ((this.FaxErrorStatusField.Equals(value) != true)) {
                    this.FaxErrorStatusField = value;
                    this.RaisePropertyChanged("FaxErrorStatus");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int FaxRecordId {
            get {
                return this.FaxRecordIdField;
            }
            set {
                if ((this.FaxRecordIdField.Equals(value) != true)) {
                    this.FaxRecordIdField = value;
                    this.RaisePropertyChanged("FaxRecordId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public JazzFaxGatewayStatus.FaxGateway.FaxStatus FaxStatus {
            get {
                return this.FaxStatusField;
            }
            set {
                if ((this.FaxStatusField.Equals(value) != true)) {
                    this.FaxStatusField = value;
                    this.RaisePropertyChanged("FaxStatus");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Handle {
            get {
                return this.HandleField;
            }
            set {
                if ((this.HandleField.Equals(value) != true)) {
                    this.HandleField = value;
                    this.RaisePropertyChanged("Handle");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Salt {
            get {
                return this.SaltField;
            }
            set {
                if ((object.ReferenceEquals(this.SaltField, value) != true)) {
                    this.SaltField = value;
                    this.RaisePropertyChanged("Salt");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
                }
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FaxErrorStatus", Namespace="http://schemas.datacontract.org/2004/07/UBC.Services.FaxService.Api.Helpers")]
    public enum FaxErrorStatus : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        fecNone = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        fecBusy = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        fecTransmissionError = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        fecPoorQuality = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        fecNoAnswer = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        fecBadFCS = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        fecBadConvert = 6,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        fecMakeFCS = 7,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        fecCantSchedule = 8,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        fecUnknown = 9,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        fecHuman = 10,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        fecGroup2 = 11,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        fecLocalInUse = 12,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        fecLineProblem = 13,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        fecBadPaper = 14,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        fecBadSignature = 15,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        fecNoSignatureAuthorization = 16,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        fecDiscarded = 18,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        fecBadPhone = 19,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        fecInvalidCode = 21,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        fecBadCode = 22,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        fecBadOCR = 23,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        fecBadPrint = 24,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        fecNoLibraryDocumentAuthorization = 25,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        fecViewStar1 = 26,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        fecDisapproved = 27,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        fecEmailDeliveryError = 28,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        fecGetStatusAttemptsExhausted = 29,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        fecNotFound = 99,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FaxStatus", Namespace="http://schemas.datacontract.org/2004/07/UBC.Services.FaxService.Api.Helpers")]
    public enum FaxStatus : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        fsUnborn = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        fsNeedsFCS = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        fsNeedsConversion = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        fsNeedsToBeSent = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        fsInConversion = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        fsInSend = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Successful = 6,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        fsManualFCS = 7,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        fsInSchedule = 8,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Failed = 9,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        fsDuplicate = 10,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Error = 11,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        fsNeedsAttention = 12,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        fsNeedsAttachment = 13,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        fsHeldForPreview = 14,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        fsInOCR = 15,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        fsInPrint = 16,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        fsQueuedForPrinting = 17,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        fsQueuedForOCR = 18,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        fsInValidation = 19,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        fsInApproval = 20,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        fsNotFound = 99,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="FaxGateway.IFaxService")]
    public interface IFaxService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFaxService/SendFax", ReplyAction="http://tempuri.org/IFaxService/SendFaxResponse")]
        int SendFax(string clientKey, JazzFaxGatewayStatus.FaxGateway.FaxDto fax);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFaxService/SendFax", ReplyAction="http://tempuri.org/IFaxService/SendFaxResponse")]
        System.Threading.Tasks.Task<int> SendFaxAsync(string clientKey, JazzFaxGatewayStatus.FaxGateway.FaxDto fax);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFaxService/GetFaxStatus", ReplyAction="http://tempuri.org/IFaxService/GetFaxStatusResponse")]
        JazzFaxGatewayStatus.FaxGateway.StatusDto[] GetFaxStatus(string clientKey, int[] FaxRecordId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFaxService/GetFaxStatus", ReplyAction="http://tempuri.org/IFaxService/GetFaxStatusResponse")]
        System.Threading.Tasks.Task<JazzFaxGatewayStatus.FaxGateway.StatusDto[]> GetFaxStatusAsync(string clientKey, int[] FaxRecordId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFaxServiceChannel : JazzFaxGatewayStatus.FaxGateway.IFaxService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FaxServiceClient : System.ServiceModel.ClientBase<JazzFaxGatewayStatus.FaxGateway.IFaxService>, JazzFaxGatewayStatus.FaxGateway.IFaxService {
        
        public FaxServiceClient() {
        }
        
        public FaxServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FaxServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FaxServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FaxServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int SendFax(string clientKey, JazzFaxGatewayStatus.FaxGateway.FaxDto fax) {
            return base.Channel.SendFax(clientKey, fax);
        }
        
        public System.Threading.Tasks.Task<int> SendFaxAsync(string clientKey, JazzFaxGatewayStatus.FaxGateway.FaxDto fax) {
            return base.Channel.SendFaxAsync(clientKey, fax);
        }
        
        public JazzFaxGatewayStatus.FaxGateway.StatusDto[] GetFaxStatus(string clientKey, int[] FaxRecordId) {
            return base.Channel.GetFaxStatus(clientKey, FaxRecordId);
        }
        
        public System.Threading.Tasks.Task<JazzFaxGatewayStatus.FaxGateway.StatusDto[]> GetFaxStatusAsync(string clientKey, int[] FaxRecordId) {
            return base.Channel.GetFaxStatusAsync(clientKey, FaxRecordId);
        }
    }
}
