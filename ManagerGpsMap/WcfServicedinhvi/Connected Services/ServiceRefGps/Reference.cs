﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfServicedinhvi.ServiceRefGps {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/TTASService")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Resp_Login", Namespace="http://schemas.datacontract.org/2004/07/TTASService")]
    [System.SerializableAttribute()]
    public partial class Resp_Login : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Group_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string KpiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string User_groupField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
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
        public string Group_id {
            get {
                return this.Group_idField;
            }
            set {
                if ((object.ReferenceEquals(this.Group_idField, value) != true)) {
                    this.Group_idField = value;
                    this.RaisePropertyChanged("Group_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Kpi {
            get {
                return this.KpiField;
            }
            set {
                if ((object.ReferenceEquals(this.KpiField, value) != true)) {
                    this.KpiField = value;
                    this.RaisePropertyChanged("Kpi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Status {
            get {
                return this.StatusField;
            }
            set {
                if ((this.StatusField.Equals(value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string User_group {
            get {
                return this.User_groupField;
            }
            set {
                if ((object.ReferenceEquals(this.User_groupField, value) != true)) {
                    this.User_groupField = value;
                    this.RaisePropertyChanged("User_group");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Resp_Theodoitructuyen", Namespace="http://schemas.datacontract.org/2004/07/TTASService")]
    [System.SerializableAttribute()]
    public partial class Resp_Theodoitructuyen : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WcfServicedinhvi.ServiceRefGps.dto_theodoitructuyen[] List_theodoiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StatusField;
        
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
        public WcfServicedinhvi.ServiceRefGps.dto_theodoitructuyen[] List_theodoi {
            get {
                return this.List_theodoiField;
            }
            set {
                if ((object.ReferenceEquals(this.List_theodoiField, value) != true)) {
                    this.List_theodoiField = value;
                    this.RaisePropertyChanged("List_theodoi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Status {
            get {
                return this.StatusField;
            }
            set {
                if ((this.StatusField.Equals(value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="dto_theodoitructuyen", Namespace="http://schemas.datacontract.org/2004/07/DP.Data.DTO")]
    [System.SerializableAttribute()]
    public partial class dto_theodoitructuyen : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Ad1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Ad2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Ad3Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Car_typeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Company_managerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Company_nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Day_distanceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DevidField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DevimeiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DevnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DevstatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Driver_codeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Driver_dateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Driver_phoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DrivernameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HotlineField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LatitudeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LongitudeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Number_open_doorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Route_timeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SpeedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string System_expire_dateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Time_expiredField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TrktimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
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
        public string Ad1 {
            get {
                return this.Ad1Field;
            }
            set {
                if ((object.ReferenceEquals(this.Ad1Field, value) != true)) {
                    this.Ad1Field = value;
                    this.RaisePropertyChanged("Ad1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ad2 {
            get {
                return this.Ad2Field;
            }
            set {
                if ((object.ReferenceEquals(this.Ad2Field, value) != true)) {
                    this.Ad2Field = value;
                    this.RaisePropertyChanged("Ad2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ad3 {
            get {
                return this.Ad3Field;
            }
            set {
                if ((object.ReferenceEquals(this.Ad3Field, value) != true)) {
                    this.Ad3Field = value;
                    this.RaisePropertyChanged("Ad3");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Car_type {
            get {
                return this.Car_typeField;
            }
            set {
                if ((object.ReferenceEquals(this.Car_typeField, value) != true)) {
                    this.Car_typeField = value;
                    this.RaisePropertyChanged("Car_type");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Company_manager {
            get {
                return this.Company_managerField;
            }
            set {
                if ((object.ReferenceEquals(this.Company_managerField, value) != true)) {
                    this.Company_managerField = value;
                    this.RaisePropertyChanged("Company_manager");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Company_name {
            get {
                return this.Company_nameField;
            }
            set {
                if ((object.ReferenceEquals(this.Company_nameField, value) != true)) {
                    this.Company_nameField = value;
                    this.RaisePropertyChanged("Company_name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Day_distance {
            get {
                return this.Day_distanceField;
            }
            set {
                if ((object.ReferenceEquals(this.Day_distanceField, value) != true)) {
                    this.Day_distanceField = value;
                    this.RaisePropertyChanged("Day_distance");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Devid {
            get {
                return this.DevidField;
            }
            set {
                if ((object.ReferenceEquals(this.DevidField, value) != true)) {
                    this.DevidField = value;
                    this.RaisePropertyChanged("Devid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Devimei {
            get {
                return this.DevimeiField;
            }
            set {
                if ((object.ReferenceEquals(this.DevimeiField, value) != true)) {
                    this.DevimeiField = value;
                    this.RaisePropertyChanged("Devimei");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Devname {
            get {
                return this.DevnameField;
            }
            set {
                if ((object.ReferenceEquals(this.DevnameField, value) != true)) {
                    this.DevnameField = value;
                    this.RaisePropertyChanged("Devname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Devstatus {
            get {
                return this.DevstatusField;
            }
            set {
                if ((object.ReferenceEquals(this.DevstatusField, value) != true)) {
                    this.DevstatusField = value;
                    this.RaisePropertyChanged("Devstatus");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Driver_code {
            get {
                return this.Driver_codeField;
            }
            set {
                if ((object.ReferenceEquals(this.Driver_codeField, value) != true)) {
                    this.Driver_codeField = value;
                    this.RaisePropertyChanged("Driver_code");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Driver_date {
            get {
                return this.Driver_dateField;
            }
            set {
                if ((object.ReferenceEquals(this.Driver_dateField, value) != true)) {
                    this.Driver_dateField = value;
                    this.RaisePropertyChanged("Driver_date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Driver_phone {
            get {
                return this.Driver_phoneField;
            }
            set {
                if ((object.ReferenceEquals(this.Driver_phoneField, value) != true)) {
                    this.Driver_phoneField = value;
                    this.RaisePropertyChanged("Driver_phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Drivername {
            get {
                return this.DrivernameField;
            }
            set {
                if ((object.ReferenceEquals(this.DrivernameField, value) != true)) {
                    this.DrivernameField = value;
                    this.RaisePropertyChanged("Drivername");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Hotline {
            get {
                return this.HotlineField;
            }
            set {
                if ((object.ReferenceEquals(this.HotlineField, value) != true)) {
                    this.HotlineField = value;
                    this.RaisePropertyChanged("Hotline");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Latitude {
            get {
                return this.LatitudeField;
            }
            set {
                if ((object.ReferenceEquals(this.LatitudeField, value) != true)) {
                    this.LatitudeField = value;
                    this.RaisePropertyChanged("Latitude");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Longitude {
            get {
                return this.LongitudeField;
            }
            set {
                if ((object.ReferenceEquals(this.LongitudeField, value) != true)) {
                    this.LongitudeField = value;
                    this.RaisePropertyChanged("Longitude");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Number_open_door {
            get {
                return this.Number_open_doorField;
            }
            set {
                if ((object.ReferenceEquals(this.Number_open_doorField, value) != true)) {
                    this.Number_open_doorField = value;
                    this.RaisePropertyChanged("Number_open_door");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Route_time {
            get {
                return this.Route_timeField;
            }
            set {
                if ((object.ReferenceEquals(this.Route_timeField, value) != true)) {
                    this.Route_timeField = value;
                    this.RaisePropertyChanged("Route_time");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Speed {
            get {
                return this.SpeedField;
            }
            set {
                if ((object.ReferenceEquals(this.SpeedField, value) != true)) {
                    this.SpeedField = value;
                    this.RaisePropertyChanged("Speed");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string System_expire_date {
            get {
                return this.System_expire_dateField;
            }
            set {
                if ((object.ReferenceEquals(this.System_expire_dateField, value) != true)) {
                    this.System_expire_dateField = value;
                    this.RaisePropertyChanged("System_expire_date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Time_expired {
            get {
                return this.Time_expiredField;
            }
            set {
                if ((object.ReferenceEquals(this.Time_expiredField, value) != true)) {
                    this.Time_expiredField = value;
                    this.RaisePropertyChanged("Time_expired");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Trktime {
            get {
                return this.TrktimeField;
            }
            set {
                if ((object.ReferenceEquals(this.TrktimeField, value) != true)) {
                    this.TrktimeField = value;
                    this.RaisePropertyChanged("Trktime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceRefGps.TTASIService")]
    public interface TTASIService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TTASIService/GetData", ReplyAction="http://tempuri.org/TTASIService/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TTASIService/GetData", ReplyAction="http://tempuri.org/TTASIService/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TTASIService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/TTASIService/GetDataUsingDataContractResponse")]
        WcfServicedinhvi.ServiceRefGps.CompositeType GetDataUsingDataContract(WcfServicedinhvi.ServiceRefGps.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TTASIService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/TTASIService/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<WcfServicedinhvi.ServiceRefGps.CompositeType> GetDataUsingDataContractAsync(WcfServicedinhvi.ServiceRefGps.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TTASIService/fn_login", ReplyAction="http://tempuri.org/TTASIService/fn_loginResponse")]
        WcfServicedinhvi.ServiceRefGps.Resp_Login fn_login(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TTASIService/fn_login", ReplyAction="http://tempuri.org/TTASIService/fn_loginResponse")]
        System.Threading.Tasks.Task<WcfServicedinhvi.ServiceRefGps.Resp_Login> fn_loginAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TTASIService/fn_theodoitructuyen", ReplyAction="http://tempuri.org/TTASIService/fn_theodoitructuyenResponse")]
        WcfServicedinhvi.ServiceRefGps.Resp_Theodoitructuyen fn_theodoitructuyen(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TTASIService/fn_theodoitructuyen", ReplyAction="http://tempuri.org/TTASIService/fn_theodoitructuyenResponse")]
        System.Threading.Tasks.Task<WcfServicedinhvi.ServiceRefGps.Resp_Theodoitructuyen> fn_theodoitructuyenAsync(string username);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface TTASIServiceChannel : WcfServicedinhvi.ServiceRefGps.TTASIService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TTASIServiceClient : System.ServiceModel.ClientBase<WcfServicedinhvi.ServiceRefGps.TTASIService>, WcfServicedinhvi.ServiceRefGps.TTASIService {
        
        public TTASIServiceClient() {
        }
        
        public TTASIServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TTASIServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TTASIServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TTASIServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public WcfServicedinhvi.ServiceRefGps.CompositeType GetDataUsingDataContract(WcfServicedinhvi.ServiceRefGps.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<WcfServicedinhvi.ServiceRefGps.CompositeType> GetDataUsingDataContractAsync(WcfServicedinhvi.ServiceRefGps.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public WcfServicedinhvi.ServiceRefGps.Resp_Login fn_login(string username, string password) {
            return base.Channel.fn_login(username, password);
        }
        
        public System.Threading.Tasks.Task<WcfServicedinhvi.ServiceRefGps.Resp_Login> fn_loginAsync(string username, string password) {
            return base.Channel.fn_loginAsync(username, password);
        }
        
        public WcfServicedinhvi.ServiceRefGps.Resp_Theodoitructuyen fn_theodoitructuyen(string username) {
            return base.Channel.fn_theodoitructuyen(username);
        }
        
        public System.Threading.Tasks.Task<WcfServicedinhvi.ServiceRefGps.Resp_Theodoitructuyen> fn_theodoitructuyenAsync(string username) {
            return base.Channel.fn_theodoitructuyenAsync(username);
        }
    }
}