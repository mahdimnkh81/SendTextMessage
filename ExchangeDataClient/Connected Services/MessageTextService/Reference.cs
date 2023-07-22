﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExchangeDataClient.MessageTextService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SendTextModel", Namespace="http://schemas.datacontract.org/2004/07/ExchangeData.DAL.ExchangeDataModel")]
    [System.SerializableAttribute()]
    public partial class SendTextModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageHeadingField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneNumberField;
        
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
        public string Date {
            get {
                return this.DateField;
            }
            set {
                if ((object.ReferenceEquals(this.DateField, value) != true)) {
                    this.DateField = value;
                    this.RaisePropertyChanged("Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Id {
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
        public string MessageHeading {
            get {
                return this.MessageHeadingField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageHeadingField, value) != true)) {
                    this.MessageHeadingField = value;
                    this.RaisePropertyChanged("MessageHeading");
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
        public string PhoneNumber {
            get {
                return this.PhoneNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneNumberField, value) != true)) {
                    this.PhoneNumberField = value;
                    this.RaisePropertyChanged("PhoneNumber");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MessageTextService.IExchangeMessageService")]
    public interface IExchangeMessageService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExchangeMessageService/GetBy", ReplyAction="http://tempuri.org/IExchangeMessageService/GetByResponse")]
        ExchangeDataClient.MessageTextService.SendTextModel GetBy(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExchangeMessageService/GetBy", ReplyAction="http://tempuri.org/IExchangeMessageService/GetByResponse")]
        System.Threading.Tasks.Task<ExchangeDataClient.MessageTextService.SendTextModel> GetByAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExchangeMessageService/GetAll", ReplyAction="http://tempuri.org/IExchangeMessageService/GetAllResponse")]
        ExchangeDataClient.MessageTextService.SendTextModel[] GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExchangeMessageService/GetAll", ReplyAction="http://tempuri.org/IExchangeMessageService/GetAllResponse")]
        System.Threading.Tasks.Task<ExchangeDataClient.MessageTextService.SendTextModel[]> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExchangeMessageService/SaveMessage", ReplyAction="http://tempuri.org/IExchangeMessageService/SaveMessageResponse")]
        bool SaveMessage(ExchangeDataClient.MessageTextService.SendTextModel message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExchangeMessageService/SaveMessage", ReplyAction="http://tempuri.org/IExchangeMessageService/SaveMessageResponse")]
        System.Threading.Tasks.Task<bool> SaveMessageAsync(ExchangeDataClient.MessageTextService.SendTextModel message);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IExchangeMessageServiceChannel : ExchangeDataClient.MessageTextService.IExchangeMessageService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ExchangeMessageServiceClient : System.ServiceModel.ClientBase<ExchangeDataClient.MessageTextService.IExchangeMessageService>, ExchangeDataClient.MessageTextService.IExchangeMessageService {
        
        public ExchangeMessageServiceClient() {
        }
        
        public ExchangeMessageServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ExchangeMessageServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ExchangeMessageServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ExchangeMessageServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ExchangeDataClient.MessageTextService.SendTextModel GetBy(int id) {
            return base.Channel.GetBy(id);
        }
        
        public System.Threading.Tasks.Task<ExchangeDataClient.MessageTextService.SendTextModel> GetByAsync(int id) {
            return base.Channel.GetByAsync(id);
        }
        
        public ExchangeDataClient.MessageTextService.SendTextModel[] GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<ExchangeDataClient.MessageTextService.SendTextModel[]> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public bool SaveMessage(ExchangeDataClient.MessageTextService.SendTextModel message) {
            return base.Channel.SaveMessage(message);
        }
        
        public System.Threading.Tasks.Task<bool> SaveMessageAsync(ExchangeDataClient.MessageTextService.SendTextModel message) {
            return base.Channel.SaveMessageAsync(message);
        }
    }
}