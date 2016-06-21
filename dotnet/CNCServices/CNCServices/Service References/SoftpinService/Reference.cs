﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CNCServices.SoftpinService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SoftpinService.SoftpinSoap")]
    public interface SoftpinSoap {
        
        // CODEGEN: Generating message contract since element name agentCode from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BuyCard", ReplyAction="*")]
        CNCServices.SoftpinService.BuyCardResponse BuyCard(CNCServices.SoftpinService.BuyCardRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BuyCard", ReplyAction="*")]
        System.Threading.Tasks.Task<CNCServices.SoftpinService.BuyCardResponse> BuyCardAsync(CNCServices.SoftpinService.BuyCardRequest request);
        
        // CODEGEN: Generating message contract since element name agentCode from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCard", ReplyAction="*")]
        CNCServices.SoftpinService.GetCardResponse GetCard(CNCServices.SoftpinService.GetCardRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCard", ReplyAction="*")]
        System.Threading.Tasks.Task<CNCServices.SoftpinService.GetCardResponse> GetCardAsync(CNCServices.SoftpinService.GetCardRequest request);
        
        // CODEGEN: Generating message contract since element name agentCode from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Topup", ReplyAction="*")]
        CNCServices.SoftpinService.TopupResponse Topup(CNCServices.SoftpinService.TopupRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Topup", ReplyAction="*")]
        System.Threading.Tasks.Task<CNCServices.SoftpinService.TopupResponse> TopupAsync(CNCServices.SoftpinService.TopupRequest request);
        
        // CODEGEN: Generating message contract since element name agentCode from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CheckTranTopup", ReplyAction="*")]
        CNCServices.SoftpinService.CheckTranTopupResponse CheckTranTopup(CNCServices.SoftpinService.CheckTranTopupRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CheckTranTopup", ReplyAction="*")]
        System.Threading.Tasks.Task<CNCServices.SoftpinService.CheckTranTopupResponse> CheckTranTopupAsync(CNCServices.SoftpinService.CheckTranTopupRequest request);
        
        // CODEGEN: Generating message contract since element name agentcode from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CheckCount", ReplyAction="*")]
        CNCServices.SoftpinService.CheckCountResponse CheckCount(CNCServices.SoftpinService.CheckCountRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CheckCount", ReplyAction="*")]
        System.Threading.Tasks.Task<CNCServices.SoftpinService.CheckCountResponse> CheckCountAsync(CNCServices.SoftpinService.CheckCountRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class BuyCardRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="BuyCard", Namespace="http://tempuri.org/", Order=0)]
        public CNCServices.SoftpinService.BuyCardRequestBody Body;
        
        public BuyCardRequest() {
        }
        
        public BuyCardRequest(CNCServices.SoftpinService.BuyCardRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class BuyCardRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string agentCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string data;
        
        public BuyCardRequestBody() {
        }
        
        public BuyCardRequestBody(string agentCode, string data) {
            this.agentCode = agentCode;
            this.data = data;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class BuyCardResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="BuyCardResponse", Namespace="http://tempuri.org/", Order=0)]
        public CNCServices.SoftpinService.BuyCardResponseBody Body;
        
        public BuyCardResponse() {
        }
        
        public BuyCardResponse(CNCServices.SoftpinService.BuyCardResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class BuyCardResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string BuyCardResult;
        
        public BuyCardResponseBody() {
        }
        
        public BuyCardResponseBody(string BuyCardResult) {
            this.BuyCardResult = BuyCardResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCardRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCard", Namespace="http://tempuri.org/", Order=0)]
        public CNCServices.SoftpinService.GetCardRequestBody Body;
        
        public GetCardRequest() {
        }
        
        public GetCardRequest(CNCServices.SoftpinService.GetCardRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetCardRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string agentCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string data;
        
        public GetCardRequestBody() {
        }
        
        public GetCardRequestBody(string agentCode, string data) {
            this.agentCode = agentCode;
            this.data = data;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCardResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCardResponse", Namespace="http://tempuri.org/", Order=0)]
        public CNCServices.SoftpinService.GetCardResponseBody Body;
        
        public GetCardResponse() {
        }
        
        public GetCardResponse(CNCServices.SoftpinService.GetCardResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetCardResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetCardResult;
        
        public GetCardResponseBody() {
        }
        
        public GetCardResponseBody(string GetCardResult) {
            this.GetCardResult = GetCardResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TopupRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Topup", Namespace="http://tempuri.org/", Order=0)]
        public CNCServices.SoftpinService.TopupRequestBody Body;
        
        public TopupRequest() {
        }
        
        public TopupRequest(CNCServices.SoftpinService.TopupRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class TopupRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string agentCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string data;
        
        public TopupRequestBody() {
        }
        
        public TopupRequestBody(string agentCode, string data) {
            this.agentCode = agentCode;
            this.data = data;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TopupResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="TopupResponse", Namespace="http://tempuri.org/", Order=0)]
        public CNCServices.SoftpinService.TopupResponseBody Body;
        
        public TopupResponse() {
        }
        
        public TopupResponse(CNCServices.SoftpinService.TopupResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class TopupResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string TopupResult;
        
        public TopupResponseBody() {
        }
        
        public TopupResponseBody(string TopupResult) {
            this.TopupResult = TopupResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CheckTranTopupRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CheckTranTopup", Namespace="http://tempuri.org/", Order=0)]
        public CNCServices.SoftpinService.CheckTranTopupRequestBody Body;
        
        public CheckTranTopupRequest() {
        }
        
        public CheckTranTopupRequest(CNCServices.SoftpinService.CheckTranTopupRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CheckTranTopupRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string agentCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string data;
        
        public CheckTranTopupRequestBody() {
        }
        
        public CheckTranTopupRequestBody(string agentCode, string data) {
            this.agentCode = agentCode;
            this.data = data;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CheckTranTopupResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CheckTranTopupResponse", Namespace="http://tempuri.org/", Order=0)]
        public CNCServices.SoftpinService.CheckTranTopupResponseBody Body;
        
        public CheckTranTopupResponse() {
        }
        
        public CheckTranTopupResponse(CNCServices.SoftpinService.CheckTranTopupResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CheckTranTopupResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string CheckTranTopupResult;
        
        public CheckTranTopupResponseBody() {
        }
        
        public CheckTranTopupResponseBody(string CheckTranTopupResult) {
            this.CheckTranTopupResult = CheckTranTopupResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CheckCountRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CheckCount", Namespace="http://tempuri.org/", Order=0)]
        public CNCServices.SoftpinService.CheckCountRequestBody Body;
        
        public CheckCountRequest() {
        }
        
        public CheckCountRequest(CNCServices.SoftpinService.CheckCountRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CheckCountRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string agentcode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string data;
        
        public CheckCountRequestBody() {
        }
        
        public CheckCountRequestBody(string agentcode, string data) {
            this.agentcode = agentcode;
            this.data = data;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CheckCountResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CheckCountResponse", Namespace="http://tempuri.org/", Order=0)]
        public CNCServices.SoftpinService.CheckCountResponseBody Body;
        
        public CheckCountResponse() {
        }
        
        public CheckCountResponse(CNCServices.SoftpinService.CheckCountResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CheckCountResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string CheckCountResult;
        
        public CheckCountResponseBody() {
        }
        
        public CheckCountResponseBody(string CheckCountResult) {
            this.CheckCountResult = CheckCountResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SoftpinSoapChannel : CNCServices.SoftpinService.SoftpinSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SoftpinSoapClient : System.ServiceModel.ClientBase<CNCServices.SoftpinService.SoftpinSoap>, CNCServices.SoftpinService.SoftpinSoap {
        
        public SoftpinSoapClient() {
        }
        
        public SoftpinSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SoftpinSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SoftpinSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SoftpinSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CNCServices.SoftpinService.BuyCardResponse CNCServices.SoftpinService.SoftpinSoap.BuyCard(CNCServices.SoftpinService.BuyCardRequest request) {
            return base.Channel.BuyCard(request);
        }
        
        public string BuyCard(string agentCode, string data) {
            CNCServices.SoftpinService.BuyCardRequest inValue = new CNCServices.SoftpinService.BuyCardRequest();
            inValue.Body = new CNCServices.SoftpinService.BuyCardRequestBody();
            inValue.Body.agentCode = agentCode;
            inValue.Body.data = data;
            CNCServices.SoftpinService.BuyCardResponse retVal = ((CNCServices.SoftpinService.SoftpinSoap)(this)).BuyCard(inValue);
            return retVal.Body.BuyCardResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CNCServices.SoftpinService.BuyCardResponse> CNCServices.SoftpinService.SoftpinSoap.BuyCardAsync(CNCServices.SoftpinService.BuyCardRequest request) {
            return base.Channel.BuyCardAsync(request);
        }
        
        public System.Threading.Tasks.Task<CNCServices.SoftpinService.BuyCardResponse> BuyCardAsync(string agentCode, string data) {
            CNCServices.SoftpinService.BuyCardRequest inValue = new CNCServices.SoftpinService.BuyCardRequest();
            inValue.Body = new CNCServices.SoftpinService.BuyCardRequestBody();
            inValue.Body.agentCode = agentCode;
            inValue.Body.data = data;
            return ((CNCServices.SoftpinService.SoftpinSoap)(this)).BuyCardAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CNCServices.SoftpinService.GetCardResponse CNCServices.SoftpinService.SoftpinSoap.GetCard(CNCServices.SoftpinService.GetCardRequest request) {
            return base.Channel.GetCard(request);
        }
        
        public string GetCard(string agentCode, string data) {
            CNCServices.SoftpinService.GetCardRequest inValue = new CNCServices.SoftpinService.GetCardRequest();
            inValue.Body = new CNCServices.SoftpinService.GetCardRequestBody();
            inValue.Body.agentCode = agentCode;
            inValue.Body.data = data;
            CNCServices.SoftpinService.GetCardResponse retVal = ((CNCServices.SoftpinService.SoftpinSoap)(this)).GetCard(inValue);
            return retVal.Body.GetCardResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CNCServices.SoftpinService.GetCardResponse> CNCServices.SoftpinService.SoftpinSoap.GetCardAsync(CNCServices.SoftpinService.GetCardRequest request) {
            return base.Channel.GetCardAsync(request);
        }
        
        public System.Threading.Tasks.Task<CNCServices.SoftpinService.GetCardResponse> GetCardAsync(string agentCode, string data) {
            CNCServices.SoftpinService.GetCardRequest inValue = new CNCServices.SoftpinService.GetCardRequest();
            inValue.Body = new CNCServices.SoftpinService.GetCardRequestBody();
            inValue.Body.agentCode = agentCode;
            inValue.Body.data = data;
            return ((CNCServices.SoftpinService.SoftpinSoap)(this)).GetCardAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CNCServices.SoftpinService.TopupResponse CNCServices.SoftpinService.SoftpinSoap.Topup(CNCServices.SoftpinService.TopupRequest request) {
            return base.Channel.Topup(request);
        }
        
        public string Topup(string agentCode, string data) {
            CNCServices.SoftpinService.TopupRequest inValue = new CNCServices.SoftpinService.TopupRequest();
            inValue.Body = new CNCServices.SoftpinService.TopupRequestBody();
            inValue.Body.agentCode = agentCode;
            inValue.Body.data = data;
            CNCServices.SoftpinService.TopupResponse retVal = ((CNCServices.SoftpinService.SoftpinSoap)(this)).Topup(inValue);
            return retVal.Body.TopupResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CNCServices.SoftpinService.TopupResponse> CNCServices.SoftpinService.SoftpinSoap.TopupAsync(CNCServices.SoftpinService.TopupRequest request) {
            return base.Channel.TopupAsync(request);
        }
        
        public System.Threading.Tasks.Task<CNCServices.SoftpinService.TopupResponse> TopupAsync(string agentCode, string data) {
            CNCServices.SoftpinService.TopupRequest inValue = new CNCServices.SoftpinService.TopupRequest();
            inValue.Body = new CNCServices.SoftpinService.TopupRequestBody();
            inValue.Body.agentCode = agentCode;
            inValue.Body.data = data;
            return ((CNCServices.SoftpinService.SoftpinSoap)(this)).TopupAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CNCServices.SoftpinService.CheckTranTopupResponse CNCServices.SoftpinService.SoftpinSoap.CheckTranTopup(CNCServices.SoftpinService.CheckTranTopupRequest request) {
            return base.Channel.CheckTranTopup(request);
        }
        
        public string CheckTranTopup(string agentCode, string data) {
            CNCServices.SoftpinService.CheckTranTopupRequest inValue = new CNCServices.SoftpinService.CheckTranTopupRequest();
            inValue.Body = new CNCServices.SoftpinService.CheckTranTopupRequestBody();
            inValue.Body.agentCode = agentCode;
            inValue.Body.data = data;
            CNCServices.SoftpinService.CheckTranTopupResponse retVal = ((CNCServices.SoftpinService.SoftpinSoap)(this)).CheckTranTopup(inValue);
            return retVal.Body.CheckTranTopupResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CNCServices.SoftpinService.CheckTranTopupResponse> CNCServices.SoftpinService.SoftpinSoap.CheckTranTopupAsync(CNCServices.SoftpinService.CheckTranTopupRequest request) {
            return base.Channel.CheckTranTopupAsync(request);
        }
        
        public System.Threading.Tasks.Task<CNCServices.SoftpinService.CheckTranTopupResponse> CheckTranTopupAsync(string agentCode, string data) {
            CNCServices.SoftpinService.CheckTranTopupRequest inValue = new CNCServices.SoftpinService.CheckTranTopupRequest();
            inValue.Body = new CNCServices.SoftpinService.CheckTranTopupRequestBody();
            inValue.Body.agentCode = agentCode;
            inValue.Body.data = data;
            return ((CNCServices.SoftpinService.SoftpinSoap)(this)).CheckTranTopupAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CNCServices.SoftpinService.CheckCountResponse CNCServices.SoftpinService.SoftpinSoap.CheckCount(CNCServices.SoftpinService.CheckCountRequest request) {
            return base.Channel.CheckCount(request);
        }
        
        public string CheckCount(string agentcode, string data) {
            CNCServices.SoftpinService.CheckCountRequest inValue = new CNCServices.SoftpinService.CheckCountRequest();
            inValue.Body = new CNCServices.SoftpinService.CheckCountRequestBody();
            inValue.Body.agentcode = agentcode;
            inValue.Body.data = data;
            CNCServices.SoftpinService.CheckCountResponse retVal = ((CNCServices.SoftpinService.SoftpinSoap)(this)).CheckCount(inValue);
            return retVal.Body.CheckCountResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CNCServices.SoftpinService.CheckCountResponse> CNCServices.SoftpinService.SoftpinSoap.CheckCountAsync(CNCServices.SoftpinService.CheckCountRequest request) {
            return base.Channel.CheckCountAsync(request);
        }
        
        public System.Threading.Tasks.Task<CNCServices.SoftpinService.CheckCountResponse> CheckCountAsync(string agentcode, string data) {
            CNCServices.SoftpinService.CheckCountRequest inValue = new CNCServices.SoftpinService.CheckCountRequest();
            inValue.Body = new CNCServices.SoftpinService.CheckCountRequestBody();
            inValue.Body.agentcode = agentcode;
            inValue.Body.data = data;
            return ((CNCServices.SoftpinService.SoftpinSoap)(this)).CheckCountAsync(inValue);
        }
    }
}