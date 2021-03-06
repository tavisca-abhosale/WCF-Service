﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Test.UserService
{
    using System.Runtime.Serialization;
    using System;


    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "User", Namespace = "http://schemas.datacontract.org/2004/07/WCFUserService.DataContract")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long IdField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName
        {
            get
            {
                return this.FirstNameField;
            }
            set
            {
                this.FirstNameField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName
        {
            get
            {
                return this.LastNameField;
            }
            set
            {
                this.LastNameField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username
        {
            get
            {
                return this.UsernameField;
            }
            set
            {
                this.UsernameField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName = "Test.UserService.IUserService")]
    public interface IUserService
    {

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IUserService/GetUser", ReplyAction = "http://tempuri.org/IUserService/GetUserResponse")]
        Test.UserService.User GetUser(long value);

        [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://tempuri.org/IUserService/GetUser", ReplyAction = "http://tempuri.org/IUserService/GetUserResponse")]
        System.IAsyncResult BeginGetUser(long value, System.AsyncCallback callback, object asyncState);

        Test.UserService.User EndGetUser(System.IAsyncResult result);
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUserServiceChannel : Test.UserService.IUserService, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserServiceClient : System.ServiceModel.ClientBase<Test.UserService.IUserService>, Test.UserService.IUserService
    {

        public UserServiceClient()
        {
        }

        public UserServiceClient(string endpointConfigurationName) :
            base(endpointConfigurationName)
        {
        }

        public UserServiceClient(string endpointConfigurationName, string remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public UserServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public UserServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
        {
        }

        public Test.UserService.User GetUser(long value)
        {
            return base.Channel.GetUser(value);
        }

        public System.IAsyncResult BeginGetUser(long value, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginGetUser(value, callback, asyncState);
        }

        public Test.UserService.User EndGetUser(System.IAsyncResult result)
        {
            return base.Channel.EndGetUser(result);
        }
    }
}
