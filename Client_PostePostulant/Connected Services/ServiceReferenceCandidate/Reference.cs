﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client_PostePostulant.ServiceReferenceCandidate {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Postulant", Namespace="http://schemas.datacontract.org/2004/07/WCFRestFul_Postulant")]
    [System.SerializableAttribute()]
    public partial class Postulant : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CourrielField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LangagesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomField;
        
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
        public string Courriel {
            get {
                return this.CourrielField;
            }
            set {
                if ((object.ReferenceEquals(this.CourrielField, value) != true)) {
                    this.CourrielField = value;
                    this.RaisePropertyChanged("Courriel");
                }
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
        public string Langages {
            get {
                return this.LangagesField;
            }
            set {
                if ((object.ReferenceEquals(this.LangagesField, value) != true)) {
                    this.LangagesField = value;
                    this.RaisePropertyChanged("Langages");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nom {
            get {
                return this.NomField;
            }
            set {
                if ((object.ReferenceEquals(this.NomField, value) != true)) {
                    this.NomField = value;
                    this.RaisePropertyChanged("Nom");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceCandidate.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetById", ReplyAction="http://tempuri.org/IService/GetByIdResponse")]
        Client_PostePostulant.ServiceReferenceCandidate.Postulant GetById(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetById", ReplyAction="http://tempuri.org/IService/GetByIdResponse")]
        System.Threading.Tasks.Task<Client_PostePostulant.ServiceReferenceCandidate.Postulant> GetByIdAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAll", ReplyAction="http://tempuri.org/IService/GetAllResponse")]
        Client_PostePostulant.ServiceReferenceCandidate.Postulant[] GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAll", ReplyAction="http://tempuri.org/IService/GetAllResponse")]
        System.Threading.Tasks.Task<Client_PostePostulant.ServiceReferenceCandidate.Postulant[]> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetByLangages", ReplyAction="http://tempuri.org/IService/GetByLangagesResponse")]
        Client_PostePostulant.ServiceReferenceCandidate.Postulant[] GetByLangages(string nbMatch, string lPostes);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetByLangages", ReplyAction="http://tempuri.org/IService/GetByLangagesResponse")]
        System.Threading.Tasks.Task<Client_PostePostulant.ServiceReferenceCandidate.Postulant[]> GetByLangagesAsync(string nbMatch, string lPostes);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Count", ReplyAction="http://tempuri.org/IService/CountResponse")]
        int Count();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Count", ReplyAction="http://tempuri.org/IService/CountResponse")]
        System.Threading.Tasks.Task<int> CountAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Add", ReplyAction="http://tempuri.org/IService/AddResponse")]
        void Add(Client_PostePostulant.ServiceReferenceCandidate.Postulant postulant);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Add", ReplyAction="http://tempuri.org/IService/AddResponse")]
        System.Threading.Tasks.Task AddAsync(Client_PostePostulant.ServiceReferenceCandidate.Postulant postulant);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Delete", ReplyAction="http://tempuri.org/IService/DeleteResponse")]
        void Delete(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Delete", ReplyAction="http://tempuri.org/IService/DeleteResponse")]
        System.Threading.Tasks.Task DeleteAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Update", ReplyAction="http://tempuri.org/IService/UpdateResponse")]
        void Update(string id, Client_PostePostulant.ServiceReferenceCandidate.Postulant postulant);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Update", ReplyAction="http://tempuri.org/IService/UpdateResponse")]
        System.Threading.Tasks.Task UpdateAsync(string id, Client_PostePostulant.ServiceReferenceCandidate.Postulant postulant);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : Client_PostePostulant.ServiceReferenceCandidate.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<Client_PostePostulant.ServiceReferenceCandidate.IService>, Client_PostePostulant.ServiceReferenceCandidate.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Client_PostePostulant.ServiceReferenceCandidate.Postulant GetById(string id) {
            return base.Channel.GetById(id);
        }
        
        public System.Threading.Tasks.Task<Client_PostePostulant.ServiceReferenceCandidate.Postulant> GetByIdAsync(string id) {
            return base.Channel.GetByIdAsync(id);
        }
        
        public Client_PostePostulant.ServiceReferenceCandidate.Postulant[] GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<Client_PostePostulant.ServiceReferenceCandidate.Postulant[]> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public Client_PostePostulant.ServiceReferenceCandidate.Postulant[] GetByLangages(string nbMatch, string lPostes) {
            return base.Channel.GetByLangages(nbMatch, lPostes);
        }
        
        public System.Threading.Tasks.Task<Client_PostePostulant.ServiceReferenceCandidate.Postulant[]> GetByLangagesAsync(string nbMatch, string lPostes) {
            return base.Channel.GetByLangagesAsync(nbMatch, lPostes);
        }
        
        public int Count() {
            return base.Channel.Count();
        }
        
        public System.Threading.Tasks.Task<int> CountAsync() {
            return base.Channel.CountAsync();
        }
        
        public void Add(Client_PostePostulant.ServiceReferenceCandidate.Postulant postulant) {
            base.Channel.Add(postulant);
        }
        
        public System.Threading.Tasks.Task AddAsync(Client_PostePostulant.ServiceReferenceCandidate.Postulant postulant) {
            return base.Channel.AddAsync(postulant);
        }
        
        public void Delete(string id) {
            base.Channel.Delete(id);
        }
        
        public System.Threading.Tasks.Task DeleteAsync(string id) {
            return base.Channel.DeleteAsync(id);
        }
        
        public void Update(string id, Client_PostePostulant.ServiceReferenceCandidate.Postulant postulant) {
            base.Channel.Update(id, postulant);
        }
        
        public System.Threading.Tasks.Task UpdateAsync(string id, Client_PostePostulant.ServiceReferenceCandidate.Postulant postulant) {
            return base.Channel.UpdateAsync(id, postulant);
        }
    }
}
