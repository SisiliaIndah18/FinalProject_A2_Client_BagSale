﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientBagSale.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Produk", Namespace="http://schemas.datacontract.org/2004/07/BagSale")]
    [System.SerializableAttribute()]
    public partial class Produk : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DeksripsiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IDProdukField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int KuotaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NamaProdukField;
        
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
        public string Deksripsi {
            get {
                return this.DeksripsiField;
            }
            set {
                if ((object.ReferenceEquals(this.DeksripsiField, value) != true)) {
                    this.DeksripsiField = value;
                    this.RaisePropertyChanged("Deksripsi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IDProduk {
            get {
                return this.IDProdukField;
            }
            set {
                if ((object.ReferenceEquals(this.IDProdukField, value) != true)) {
                    this.IDProdukField = value;
                    this.RaisePropertyChanged("IDProduk");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Kuota {
            get {
                return this.KuotaField;
            }
            set {
                if ((this.KuotaField.Equals(value) != true)) {
                    this.KuotaField = value;
                    this.RaisePropertyChanged("Kuota");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NamaProduk {
            get {
                return this.NamaProdukField;
            }
            set {
                if ((object.ReferenceEquals(this.NamaProdukField, value) != true)) {
                    this.NamaProdukField = value;
                    this.RaisePropertyChanged("NamaProduk");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Pemesanan", Namespace="http://schemas.datacontract.org/2004/07/BagSale")]
    [System.SerializableAttribute()]
    public partial class Pemesanan : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IDTransaksiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int JumlahTransaksiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NamaCustomerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NoTelponField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProdukField;
        
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
        public string IDTransaksi {
            get {
                return this.IDTransaksiField;
            }
            set {
                if ((object.ReferenceEquals(this.IDTransaksiField, value) != true)) {
                    this.IDTransaksiField = value;
                    this.RaisePropertyChanged("IDTransaksi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int JumlahTransaksi {
            get {
                return this.JumlahTransaksiField;
            }
            set {
                if ((this.JumlahTransaksiField.Equals(value) != true)) {
                    this.JumlahTransaksiField = value;
                    this.RaisePropertyChanged("JumlahTransaksi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NamaCustomer {
            get {
                return this.NamaCustomerField;
            }
            set {
                if ((object.ReferenceEquals(this.NamaCustomerField, value) != true)) {
                    this.NamaCustomerField = value;
                    this.RaisePropertyChanged("NamaCustomer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NoTelpon {
            get {
                return this.NoTelponField;
            }
            set {
                if ((object.ReferenceEquals(this.NoTelponField, value) != true)) {
                    this.NoTelponField = value;
                    this.RaisePropertyChanged("NoTelpon");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Produk {
            get {
                return this.ProdukField;
            }
            set {
                if ((object.ReferenceEquals(this.ProdukField, value) != true)) {
                    this.ProdukField = value;
                    this.RaisePropertyChanged("Produk");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DataRegister", Namespace="http://schemas.datacontract.org/2004/07/BagSale")]
    [System.SerializableAttribute()]
    public partial class DataRegister : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string usernameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string passwordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string kategoriField;
        
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
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string username {
            get {
                return this.usernameField;
            }
            set {
                if ((object.ReferenceEquals(this.usernameField, value) != true)) {
                    this.usernameField = value;
                    this.RaisePropertyChanged("username");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public string password {
            get {
                return this.passwordField;
            }
            set {
                if ((object.ReferenceEquals(this.passwordField, value) != true)) {
                    this.passwordField = value;
                    this.RaisePropertyChanged("password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public string kategori {
            get {
                return this.kategoriField;
            }
            set {
                if ((object.ReferenceEquals(this.kategoriField, value) != true)) {
                    this.kategoriField = value;
                    this.RaisePropertyChanged("kategori");
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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/pemesanan", ReplyAction="http://tempuri.org/IService1/pemesananResponse")]
        string pemesanan(string IDTransaksi, string NamaCustomer, string NoTelpon, int JumlahPemesanan, string IDProduk);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/pemesanan", ReplyAction="http://tempuri.org/IService1/pemesananResponse")]
        System.Threading.Tasks.Task<string> pemesananAsync(string IDTransaksi, string NamaCustomer, string NoTelpon, int JumlahPemesanan, string IDProduk);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/editPemesanan", ReplyAction="http://tempuri.org/IService1/editPemesananResponse")]
        string editPemesanan(string IDTransaksi, string Namacustomer, string No_telpon);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/editPemesanan", ReplyAction="http://tempuri.org/IService1/editPemesananResponse")]
        System.Threading.Tasks.Task<string> editPemesananAsync(string IDTransaksi, string Namacustomer, string No_telpon);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deletePemesanan", ReplyAction="http://tempuri.org/IService1/deletePemesananResponse")]
        string deletePemesanan(string IDTransaksi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deletePemesanan", ReplyAction="http://tempuri.org/IService1/deletePemesananResponse")]
        System.Threading.Tasks.Task<string> deletePemesananAsync(string IDTransaksi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Produk", ReplyAction="http://tempuri.org/IService1/ProdukResponse")]
        ClientBagSale.ServiceReference1.Produk[] Produk();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Produk", ReplyAction="http://tempuri.org/IService1/ProdukResponse")]
        System.Threading.Tasks.Task<ClientBagSale.ServiceReference1.Produk[]> ProdukAsync();
        
        // CODEGEN: Generating message contract since the wrapper name (Pemesanan) of message PemesananRequest does not match the default value (Pemesanan1)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Pemesanan", ReplyAction="http://tempuri.org/IService1/PemesananResponse")]
        ClientBagSale.ServiceReference1.PemesananResponse Pemesanan1(ClientBagSale.ServiceReference1.PemesananRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Pemesanan", ReplyAction="http://tempuri.org/IService1/PemesananResponse")]
        System.Threading.Tasks.Task<ClientBagSale.ServiceReference1.PemesananResponse> Pemesanan1Async(ClientBagSale.ServiceReference1.PemesananRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Login", ReplyAction="http://tempuri.org/IService1/LoginResponse")]
        string Login(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Login", ReplyAction="http://tempuri.org/IService1/LoginResponse")]
        System.Threading.Tasks.Task<string> LoginAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Register", ReplyAction="http://tempuri.org/IService1/RegisterResponse")]
        string Register(string username, string password, string kategori);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Register", ReplyAction="http://tempuri.org/IService1/RegisterResponse")]
        System.Threading.Tasks.Task<string> RegisterAsync(string username, string password, string kategori);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateRegister", ReplyAction="http://tempuri.org/IService1/UpdateRegisterResponse")]
        string UpdateRegister(string username, string password, string kategori, int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateRegister", ReplyAction="http://tempuri.org/IService1/UpdateRegisterResponse")]
        System.Threading.Tasks.Task<string> UpdateRegisterAsync(string username, string password, string kategori, int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteRegister", ReplyAction="http://tempuri.org/IService1/DeleteRegisterResponse")]
        string DeleteRegister(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteRegister", ReplyAction="http://tempuri.org/IService1/DeleteRegisterResponse")]
        System.Threading.Tasks.Task<string> DeleteRegisterAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DataRegist", ReplyAction="http://tempuri.org/IService1/DataRegistResponse")]
        ClientBagSale.ServiceReference1.DataRegister[] DataRegist();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DataRegist", ReplyAction="http://tempuri.org/IService1/DataRegistResponse")]
        System.Threading.Tasks.Task<ClientBagSale.ServiceReference1.DataRegister[]> DataRegistAsync();
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Pemesanan", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class PemesananRequest {
        
        public PemesananRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="PemesananResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class PemesananResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public ClientBagSale.ServiceReference1.Pemesanan[] PemesananResult;
        
        public PemesananResponse() {
        }
        
        public PemesananResponse(ClientBagSale.ServiceReference1.Pemesanan[] PemesananResult) {
            this.PemesananResult = PemesananResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : ClientBagSale.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ClientBagSale.ServiceReference1.IService1>, ClientBagSale.ServiceReference1.IService1 {
        
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
        
        public string pemesanan(string IDTransaksi, string NamaCustomer, string NoTelpon, int JumlahPemesanan, string IDProduk) {
            return base.Channel.pemesanan(IDTransaksi, NamaCustomer, NoTelpon, JumlahPemesanan, IDProduk);
        }
        
        public System.Threading.Tasks.Task<string> pemesananAsync(string IDTransaksi, string NamaCustomer, string NoTelpon, int JumlahPemesanan, string IDProduk) {
            return base.Channel.pemesananAsync(IDTransaksi, NamaCustomer, NoTelpon, JumlahPemesanan, IDProduk);
        }
        
        public string editPemesanan(string IDTransaksi, string Namacustomer, string No_telpon) {
            return base.Channel.editPemesanan(IDTransaksi, Namacustomer, No_telpon);
        }
        
        public System.Threading.Tasks.Task<string> editPemesananAsync(string IDTransaksi, string Namacustomer, string No_telpon) {
            return base.Channel.editPemesananAsync(IDTransaksi, Namacustomer, No_telpon);
        }
        
        public string deletePemesanan(string IDTransaksi) {
            return base.Channel.deletePemesanan(IDTransaksi);
        }
        
        public System.Threading.Tasks.Task<string> deletePemesananAsync(string IDTransaksi) {
            return base.Channel.deletePemesananAsync(IDTransaksi);
        }
        
        public ClientBagSale.ServiceReference1.Produk[] Produk() {
            return base.Channel.Produk();
        }
        
        public System.Threading.Tasks.Task<ClientBagSale.ServiceReference1.Produk[]> ProdukAsync() {
            return base.Channel.ProdukAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClientBagSale.ServiceReference1.PemesananResponse ClientBagSale.ServiceReference1.IService1.Pemesanan1(ClientBagSale.ServiceReference1.PemesananRequest request) {
            return base.Channel.Pemesanan1(request);
        }
        
        public ClientBagSale.ServiceReference1.Pemesanan[] Pemesanan1() {
            ClientBagSale.ServiceReference1.PemesananRequest inValue = new ClientBagSale.ServiceReference1.PemesananRequest();
            ClientBagSale.ServiceReference1.PemesananResponse retVal = ((ClientBagSale.ServiceReference1.IService1)(this)).Pemesanan1(inValue);
            return retVal.PemesananResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClientBagSale.ServiceReference1.PemesananResponse> ClientBagSale.ServiceReference1.IService1.Pemesanan1Async(ClientBagSale.ServiceReference1.PemesananRequest request) {
            return base.Channel.Pemesanan1Async(request);
        }
        
        public System.Threading.Tasks.Task<ClientBagSale.ServiceReference1.PemesananResponse> Pemesanan1Async() {
            ClientBagSale.ServiceReference1.PemesananRequest inValue = new ClientBagSale.ServiceReference1.PemesananRequest();
            return ((ClientBagSale.ServiceReference1.IService1)(this)).Pemesanan1Async(inValue);
        }
        
        public string Login(string username, string password) {
            return base.Channel.Login(username, password);
        }
        
        public System.Threading.Tasks.Task<string> LoginAsync(string username, string password) {
            return base.Channel.LoginAsync(username, password);
        }
        
        public string Register(string username, string password, string kategori) {
            return base.Channel.Register(username, password, kategori);
        }
        
        public System.Threading.Tasks.Task<string> RegisterAsync(string username, string password, string kategori) {
            return base.Channel.RegisterAsync(username, password, kategori);
        }
        
        public string UpdateRegister(string username, string password, string kategori, int id) {
            return base.Channel.UpdateRegister(username, password, kategori, id);
        }
        
        public System.Threading.Tasks.Task<string> UpdateRegisterAsync(string username, string password, string kategori, int id) {
            return base.Channel.UpdateRegisterAsync(username, password, kategori, id);
        }
        
        public string DeleteRegister(string username) {
            return base.Channel.DeleteRegister(username);
        }
        
        public System.Threading.Tasks.Task<string> DeleteRegisterAsync(string username) {
            return base.Channel.DeleteRegisterAsync(username);
        }
        
        public ClientBagSale.ServiceReference1.DataRegister[] DataRegist() {
            return base.Channel.DataRegist();
        }
        
        public System.Threading.Tasks.Task<ClientBagSale.ServiceReference1.DataRegister[]> DataRegistAsync() {
            return base.Channel.DataRegistAsync();
        }
    }
}
