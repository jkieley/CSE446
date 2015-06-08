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
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IService")]
public interface IWorkFlowService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SecretNumber", ReplyAction="http://tempuri.org/IService/SecretNumberResponse")]
    [return: System.ServiceModel.MessageParameterAttribute(Name="res")]
    int SecretNumber(int lower, int upper);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SecretNumber", ReplyAction="http://tempuri.org/IService/SecretNumberResponse")]
    [return: System.ServiceModel.MessageParameterAttribute(Name="res")]
    System.Threading.Tasks.Task<int> SecretNumberAsync(int lower, int upper);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IServiceChannel2 : IWorkFlowService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class WorkflowServiceClient : System.ServiceModel.ClientBase<IWorkFlowService>, IWorkFlowService
{
    
    public WorkflowServiceClient()
    {
    }
    
    public WorkflowServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public WorkflowServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public WorkflowServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public WorkflowServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public int SecretNumber(int lower, int upper)
    {
        return base.Channel.SecretNumber(lower, upper);
    }
    
    public System.Threading.Tasks.Task<int> SecretNumberAsync(int lower, int upper)
    {
        return base.Channel.SecretNumberAsync(lower, upper);
    }
}
