﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientPatZyg.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ToyWcf", Namespace="http://schemas.datacontract.org/2004/07/WcfService1")]
    [System.SerializableAttribute()]
    public partial class ToyWcf : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ValueField;
        
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
        public int Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Value {
            get {
                return this.ValueField;
            }
            set {
                if ((this.ValueField.Equals(value) != true)) {
                    this.ValueField = value;
                    this.RaisePropertyChanged("Value");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IToyService")]
    public interface IToyService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IToyService/GetToy", ReplyAction="http://tempuri.org/IToyService/GetToyResponse")]
        ClientPatZyg.ServiceReference1.ToyWcf GetToy(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IToyService/GetToy", ReplyAction="http://tempuri.org/IToyService/GetToyResponse")]
        System.Threading.Tasks.Task<ClientPatZyg.ServiceReference1.ToyWcf> GetToyAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IToyService/CreateToy", ReplyAction="http://tempuri.org/IToyService/CreateToyResponse")]
        string CreateToy(ClientPatZyg.ServiceReference1.ToyWcf toyWcf);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IToyService/CreateToy", ReplyAction="http://tempuri.org/IToyService/CreateToyResponse")]
        System.Threading.Tasks.Task<string> CreateToyAsync(ClientPatZyg.ServiceReference1.ToyWcf toyWcf);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IToyServiceChannel : ClientPatZyg.ServiceReference1.IToyService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ToyServiceClient : System.ServiceModel.ClientBase<ClientPatZyg.ServiceReference1.IToyService>, ClientPatZyg.ServiceReference1.IToyService {
        
        public ToyServiceClient() {
        }
        
        public ToyServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ToyServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ToyServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ToyServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ClientPatZyg.ServiceReference1.ToyWcf GetToy(string name) {
            return base.Channel.GetToy(name);
        }
        
        public System.Threading.Tasks.Task<ClientPatZyg.ServiceReference1.ToyWcf> GetToyAsync(string name) {
            return base.Channel.GetToyAsync(name);
        }
        
        public string CreateToy(ClientPatZyg.ServiceReference1.ToyWcf toyWcf) {
            return base.Channel.CreateToy(toyWcf);
        }
        
        public System.Threading.Tasks.Task<string> CreateToyAsync(ClientPatZyg.ServiceReference1.ToyWcf toyWcf) {
            return base.Channel.CreateToyAsync(toyWcf);
        }
    }
}
