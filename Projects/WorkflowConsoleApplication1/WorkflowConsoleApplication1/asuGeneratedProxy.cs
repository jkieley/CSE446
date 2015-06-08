﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IAsuService")]
public interface IAsuService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/secretNumber", ReplyAction="http://tempuri.org/IService/secretNumberResponse")]
    int secretNumber(int lower, int upper);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/secretNumber", ReplyAction="http://tempuri.org/IService/secretNumberResponse")]
    System.Threading.Tasks.Task<int> secretNumberAsync(int lower, int upper);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/checkNumber", ReplyAction="http://tempuri.org/IService/checkNumberResponse")]
    string checkNumber(int userNum, int secretNum);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/checkNumber", ReplyAction="http://tempuri.org/IService/checkNumberResponse")]
    System.Threading.Tasks.Task<string> checkNumberAsync(int userNum, int secretNum);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IServiceChannel : IAsuService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class AsuServiceClient : System.ServiceModel.ClientBase<IAsuService>, IAsuService
{
    
    public AsuServiceClient()
    {
    }
    
    public AsuServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public AsuServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public AsuServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public AsuServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public int secretNumber(int lower, int upper)
    {
        return base.Channel.secretNumber(lower, upper);
    }
    
    public System.Threading.Tasks.Task<int> secretNumberAsync(int lower, int upper)
    {
        return base.Channel.secretNumberAsync(lower, upper);
    }
    
    public string checkNumber(int userNum, int secretNum)
    {
        return base.Channel.checkNumber(userNum, secretNum);
    }
    
    public System.Threading.Tasks.Task<string> checkNumberAsync(int userNum, int secretNum)
    {
        return base.Channel.checkNumberAsync(userNum, secretNum);
    }
}
