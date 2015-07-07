﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assignment5WebApplication1.WCFMessageService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Message", Namespace="http://schemas.datacontract.org/2004/07/Assignment5WcfService")]
    [System.SerializableAttribute()]
    public partial class Message : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ReceiverIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SenderIdField;
        
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
        public string Content {
            get {
                return this.ContentField;
            }
            set {
                if ((object.ReferenceEquals(this.ContentField, value) != true)) {
                    this.ContentField = value;
                    this.RaisePropertyChanged("Content");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ReceiverId {
            get {
                return this.ReceiverIdField;
            }
            set {
                if ((object.ReferenceEquals(this.ReceiverIdField, value) != true)) {
                    this.ReceiverIdField = value;
                    this.RaisePropertyChanged("ReceiverId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SenderId {
            get {
                return this.SenderIdField;
            }
            set {
                if ((object.ReferenceEquals(this.SenderIdField, value) != true)) {
                    this.SenderIdField = value;
                    this.RaisePropertyChanged("SenderId");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WCFMessageService.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/sendMessage", ReplyAction="http://tempuri.org/IService1/sendMessageResponse")]
        void sendMessage(string senderId, string receiverId, string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/sendMessage", ReplyAction="http://tempuri.org/IService1/sendMessageResponse")]
        System.Threading.Tasks.Task sendMessageAsync(string senderId, string receiverId, string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/receiveMsg", ReplyAction="http://tempuri.org/IService1/receiveMsgResponse")]
        Assignment5WebApplication1.WCFMessageService.Message[] receiveMsg(string receiverId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/receiveMsg", ReplyAction="http://tempuri.org/IService1/receiveMsgResponse")]
        System.Threading.Tasks.Task<Assignment5WebApplication1.WCFMessageService.Message[]> receiveMsgAsync(string receiverId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Assignment5WebApplication1.WCFMessageService.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Assignment5WebApplication1.WCFMessageService.IService1>, Assignment5WebApplication1.WCFMessageService.IService1 {
        
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
        
        public void sendMessage(string senderId, string receiverId, string message) {
            base.Channel.sendMessage(senderId, receiverId, message);
        }
        
        public System.Threading.Tasks.Task sendMessageAsync(string senderId, string receiverId, string message) {
            return base.Channel.sendMessageAsync(senderId, receiverId, message);
        }
        
        public Assignment5WebApplication1.WCFMessageService.Message[] receiveMsg(string receiverId) {
            return base.Channel.receiveMsg(receiverId);
        }
        
        public System.Threading.Tasks.Task<Assignment5WebApplication1.WCFMessageService.Message[]> receiveMsgAsync(string receiverId) {
            return base.Channel.receiveMsgAsync(receiverId);
        }
    }
}
