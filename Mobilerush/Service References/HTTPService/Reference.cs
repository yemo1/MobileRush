﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mobilerush.Web.HTTPService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="HTTPService.HeaderIndexSoap")]
    public interface HeaderIndexSoap {
        
        // CODEGEN: Generating message contract since element name MSISDN_HEADERResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MSISDN_HEADER", ReplyAction="*")]
        Mobilerush.Web.HTTPService.MSISDN_HEADERResponse MSISDN_HEADER(Mobilerush.Web.HTTPService.MSISDN_HEADERRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MSISDN_HEADER", ReplyAction="*")]
        System.Threading.Tasks.Task<Mobilerush.Web.HTTPService.MSISDN_HEADERResponse> MSISDN_HEADERAsync(Mobilerush.Web.HTTPService.MSISDN_HEADERRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class MSISDN_HEADERRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="MSISDN_HEADER", Namespace="http://tempuri.org/", Order=0)]
        public Mobilerush.Web.HTTPService.MSISDN_HEADERRequestBody Body;
        
        public MSISDN_HEADERRequest() {
        }
        
        public MSISDN_HEADERRequest(Mobilerush.Web.HTTPService.MSISDN_HEADERRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class MSISDN_HEADERRequestBody {
        
        public MSISDN_HEADERRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class MSISDN_HEADERResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="MSISDN_HEADERResponse", Namespace="http://tempuri.org/", Order=0)]
        public Mobilerush.Web.HTTPService.MSISDN_HEADERResponseBody Body;
        
        public MSISDN_HEADERResponse() {
        }
        
        public MSISDN_HEADERResponse(Mobilerush.Web.HTTPService.MSISDN_HEADERResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class MSISDN_HEADERResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string MSISDN_HEADERResult;
        
        public MSISDN_HEADERResponseBody() {
        }
        
        public MSISDN_HEADERResponseBody(string MSISDN_HEADERResult) {
            this.MSISDN_HEADERResult = MSISDN_HEADERResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface HeaderIndexSoapChannel : Mobilerush.Web.HTTPService.HeaderIndexSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HeaderIndexSoapClient : System.ServiceModel.ClientBase<Mobilerush.Web.HTTPService.HeaderIndexSoap>, Mobilerush.Web.HTTPService.HeaderIndexSoap {
        
        public HeaderIndexSoapClient() {
        }
        
        public HeaderIndexSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HeaderIndexSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HeaderIndexSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HeaderIndexSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Mobilerush.Web.HTTPService.MSISDN_HEADERResponse Mobilerush.Web.HTTPService.HeaderIndexSoap.MSISDN_HEADER(Mobilerush.Web.HTTPService.MSISDN_HEADERRequest request) {
            return base.Channel.MSISDN_HEADER(request);
        }
        
        public string MSISDN_HEADER() {
            Mobilerush.Web.HTTPService.MSISDN_HEADERRequest inValue = new Mobilerush.Web.HTTPService.MSISDN_HEADERRequest();
            inValue.Body = new Mobilerush.Web.HTTPService.MSISDN_HEADERRequestBody();
            Mobilerush.Web.HTTPService.MSISDN_HEADERResponse retVal = ((Mobilerush.Web.HTTPService.HeaderIndexSoap)(this)).MSISDN_HEADER(inValue);
            return retVal.Body.MSISDN_HEADERResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Mobilerush.Web.HTTPService.MSISDN_HEADERResponse> Mobilerush.Web.HTTPService.HeaderIndexSoap.MSISDN_HEADERAsync(Mobilerush.Web.HTTPService.MSISDN_HEADERRequest request) {
            return base.Channel.MSISDN_HEADERAsync(request);
        }
        
        public System.Threading.Tasks.Task<Mobilerush.Web.HTTPService.MSISDN_HEADERResponse> MSISDN_HEADERAsync() {
            Mobilerush.Web.HTTPService.MSISDN_HEADERRequest inValue = new Mobilerush.Web.HTTPService.MSISDN_HEADERRequest();
            inValue.Body = new Mobilerush.Web.HTTPService.MSISDN_HEADERRequestBody();
            return ((Mobilerush.Web.HTTPService.HeaderIndexSoap)(this)).MSISDN_HEADERAsync(inValue);
        }
    }
}
