//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyQuanKemWCF.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/WCFBanKem")]
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Ice_cream", Namespace="http://schemas.datacontract.org/2004/07/WCFBanKem")]
    [System.SerializableAttribute()]
    public partial class Ice_cream : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int numberorderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal priceField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int numberorder {
            get {
                return this.numberorderField;
            }
            set {
                if ((this.numberorderField.Equals(value) != true)) {
                    this.numberorderField = value;
                    this.RaisePropertyChanged("numberorder");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal price {
            get {
                return this.priceField;
            }
            set {
                if ((this.priceField.Equals(value) != true)) {
                    this.priceField = value;
                    this.RaisePropertyChanged("price");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        QuanLyQuanKemWCF.ServiceReference1.CompositeType GetDataUsingDataContract(QuanLyQuanKemWCF.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<QuanLyQuanKemWCF.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(QuanLyQuanKemWCF.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getIceCream", ReplyAction="http://tempuri.org/IService1/getIceCreamResponse")]
        QuanLyQuanKemWCF.ServiceReference1.Ice_cream[] getIceCream();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getIceCream", ReplyAction="http://tempuri.org/IService1/getIceCreamResponse")]
        System.Threading.Tasks.Task<QuanLyQuanKemWCF.ServiceReference1.Ice_cream[]> getIceCreamAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addIceCream", ReplyAction="http://tempuri.org/IService1/addIceCreamResponse")]
        int addIceCream(QuanLyQuanKemWCF.ServiceReference1.Ice_cream i);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addIceCream", ReplyAction="http://tempuri.org/IService1/addIceCreamResponse")]
        System.Threading.Tasks.Task<int> addIceCreamAsync(QuanLyQuanKemWCF.ServiceReference1.Ice_cream i);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/editIceCream", ReplyAction="http://tempuri.org/IService1/editIceCreamResponse")]
        int editIceCream(QuanLyQuanKemWCF.ServiceReference1.Ice_cream i);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/editIceCream", ReplyAction="http://tempuri.org/IService1/editIceCreamResponse")]
        System.Threading.Tasks.Task<int> editIceCreamAsync(QuanLyQuanKemWCF.ServiceReference1.Ice_cream i);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deleteIceCream", ReplyAction="http://tempuri.org/IService1/deleteIceCreamResponse")]
        int deleteIceCream(QuanLyQuanKemWCF.ServiceReference1.Ice_cream i);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deleteIceCream", ReplyAction="http://tempuri.org/IService1/deleteIceCreamResponse")]
        System.Threading.Tasks.Task<int> deleteIceCreamAsync(QuanLyQuanKemWCF.ServiceReference1.Ice_cream i);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/datKem", ReplyAction="http://tempuri.org/IService1/datKemResponse")]
        int datKem(QuanLyQuanKemWCF.ServiceReference1.Ice_cream i);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/datKem", ReplyAction="http://tempuri.org/IService1/datKemResponse")]
        System.Threading.Tasks.Task<int> datKemAsync(QuanLyQuanKemWCF.ServiceReference1.Ice_cream i);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/banduoc", ReplyAction="http://tempuri.org/IService1/banduocResponse")]
        QuanLyQuanKemWCF.ServiceReference1.Ice_cream[] banduoc();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/banduoc", ReplyAction="http://tempuri.org/IService1/banduocResponse")]
        System.Threading.Tasks.Task<QuanLyQuanKemWCF.ServiceReference1.Ice_cream[]> banduocAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/tonlai", ReplyAction="http://tempuri.org/IService1/tonlaiResponse")]
        QuanLyQuanKemWCF.ServiceReference1.Ice_cream[] tonlai();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/tonlai", ReplyAction="http://tempuri.org/IService1/tonlaiResponse")]
        System.Threading.Tasks.Task<QuanLyQuanKemWCF.ServiceReference1.Ice_cream[]> tonlaiAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/findIceCream", ReplyAction="http://tempuri.org/IService1/findIceCreamResponse")]
        QuanLyQuanKemWCF.ServiceReference1.Ice_cream[] findIceCream(QuanLyQuanKemWCF.ServiceReference1.Ice_cream i);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/findIceCream", ReplyAction="http://tempuri.org/IService1/findIceCreamResponse")]
        System.Threading.Tasks.Task<QuanLyQuanKemWCF.ServiceReference1.Ice_cream[]> findIceCreamAsync(QuanLyQuanKemWCF.ServiceReference1.Ice_cream i);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : QuanLyQuanKemWCF.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<QuanLyQuanKemWCF.ServiceReference1.IService1>, QuanLyQuanKemWCF.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public QuanLyQuanKemWCF.ServiceReference1.CompositeType GetDataUsingDataContract(QuanLyQuanKemWCF.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<QuanLyQuanKemWCF.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(QuanLyQuanKemWCF.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public QuanLyQuanKemWCF.ServiceReference1.Ice_cream[] getIceCream() {
            return base.Channel.getIceCream();
        }
        
        public System.Threading.Tasks.Task<QuanLyQuanKemWCF.ServiceReference1.Ice_cream[]> getIceCreamAsync() {
            return base.Channel.getIceCreamAsync();
        }
        
        public int addIceCream(QuanLyQuanKemWCF.ServiceReference1.Ice_cream i) {
            return base.Channel.addIceCream(i);
        }
        
        public System.Threading.Tasks.Task<int> addIceCreamAsync(QuanLyQuanKemWCF.ServiceReference1.Ice_cream i) {
            return base.Channel.addIceCreamAsync(i);
        }
        
        public int editIceCream(QuanLyQuanKemWCF.ServiceReference1.Ice_cream i) {
            return base.Channel.editIceCream(i);
        }
        
        public System.Threading.Tasks.Task<int> editIceCreamAsync(QuanLyQuanKemWCF.ServiceReference1.Ice_cream i) {
            return base.Channel.editIceCreamAsync(i);
        }
        
        public int deleteIceCream(QuanLyQuanKemWCF.ServiceReference1.Ice_cream i) {
            return base.Channel.deleteIceCream(i);
        }
        
        public System.Threading.Tasks.Task<int> deleteIceCreamAsync(QuanLyQuanKemWCF.ServiceReference1.Ice_cream i) {
            return base.Channel.deleteIceCreamAsync(i);
        }
        
        public int datKem(QuanLyQuanKemWCF.ServiceReference1.Ice_cream i) {
            return base.Channel.datKem(i);
        }
        
        public System.Threading.Tasks.Task<int> datKemAsync(QuanLyQuanKemWCF.ServiceReference1.Ice_cream i) {
            return base.Channel.datKemAsync(i);
        }
        
        public QuanLyQuanKemWCF.ServiceReference1.Ice_cream[] banduoc() {
            return base.Channel.banduoc();
        }
        
        public System.Threading.Tasks.Task<QuanLyQuanKemWCF.ServiceReference1.Ice_cream[]> banduocAsync() {
            return base.Channel.banduocAsync();
        }
        
        public QuanLyQuanKemWCF.ServiceReference1.Ice_cream[] tonlai() {
            return base.Channel.tonlai();
        }
        
        public System.Threading.Tasks.Task<QuanLyQuanKemWCF.ServiceReference1.Ice_cream[]> tonlaiAsync() {
            return base.Channel.tonlaiAsync();
        }
        
        public QuanLyQuanKemWCF.ServiceReference1.Ice_cream[] findIceCream(QuanLyQuanKemWCF.ServiceReference1.Ice_cream i) {
            return base.Channel.findIceCream(i);
        }
        
        public System.Threading.Tasks.Task<QuanLyQuanKemWCF.ServiceReference1.Ice_cream[]> findIceCreamAsync(QuanLyQuanKemWCF.ServiceReference1.Ice_cream i) {
            return base.Channel.findIceCreamAsync(i);
        }
    }
}
