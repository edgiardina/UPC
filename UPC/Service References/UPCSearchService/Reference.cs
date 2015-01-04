﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UPC.UPCSearchService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://searchupc.com/", ConfigurationName="UPCSearchService.UPCSearchSoap")]
    public interface UPCSearchSoap {
        
        // CODEGEN: Generating message contract since element name upc from namespace http://searchupc.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://searchupc.com/GetProduct", ReplyAction="*")]
        UPC.UPCSearchService.GetProductResponse GetProduct(UPC.UPCSearchService.GetProductRequest request);
        
        // CODEGEN: Generating message contract since element name upc from namespace http://searchupc.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://searchupc.com/GetProductJSON", ReplyAction="*")]
        UPC.UPCSearchService.GetProductJSONResponse GetProductJSON(UPC.UPCSearchService.GetProductJSONRequest request);
        
        // CODEGEN: Generating message contract since element name upc from namespace http://searchupc.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://searchupc.com/Validate", ReplyAction="*")]
        UPC.UPCSearchService.ValidateResponse Validate(UPC.UPCSearchService.ValidateRequest request);
        
        // CODEGEN: Generating message contract since element name upce from namespace http://searchupc.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://searchupc.com/ConvertToUPCA", ReplyAction="*")]
        UPC.UPCSearchService.ConvertToUPCAResponse ConvertToUPCA(UPC.UPCSearchService.ConvertToUPCARequest request);
        
        // CODEGEN: Generating message contract since element name upc from namespace http://searchupc.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://searchupc.com/GenerateBarcode", ReplyAction="*")]
        UPC.UPCSearchService.GenerateBarcodeResponse GenerateBarcode(UPC.UPCSearchService.GenerateBarcodeRequest request);
        
        // CODEGEN: Generating message contract since element name upc from namespace http://searchupc.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://searchupc.com/SuggestProduct", ReplyAction="*")]
        UPC.UPCSearchService.SuggestProductResponse SuggestProduct(UPC.UPCSearchService.SuggestProductRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetProductRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetProduct", Namespace="http://searchupc.com/", Order=0)]
        public UPC.UPCSearchService.GetProductRequestBody Body;
        
        public GetProductRequest() {
        }
        
        public GetProductRequest(UPC.UPCSearchService.GetProductRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://searchupc.com/")]
    public partial class GetProductRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string upc;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string accesstoken;
        
        public GetProductRequestBody() {
        }
        
        public GetProductRequestBody(string upc, string accesstoken) {
            this.upc = upc;
            this.accesstoken = accesstoken;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetProductResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetProductResponse", Namespace="http://searchupc.com/", Order=0)]
        public UPC.UPCSearchService.GetProductResponseBody Body;
        
        public GetProductResponse() {
        }
        
        public GetProductResponse(UPC.UPCSearchService.GetProductResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://searchupc.com/")]
    public partial class GetProductResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetProductResult;
        
        public GetProductResponseBody() {
        }
        
        public GetProductResponseBody(string GetProductResult) {
            this.GetProductResult = GetProductResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetProductJSONRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetProductJSON", Namespace="http://searchupc.com/", Order=0)]
        public UPC.UPCSearchService.GetProductJSONRequestBody Body;
        
        public GetProductJSONRequest() {
        }
        
        public GetProductJSONRequest(UPC.UPCSearchService.GetProductJSONRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://searchupc.com/")]
    public partial class GetProductJSONRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string upc;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string accesstoken;
        
        public GetProductJSONRequestBody() {
        }
        
        public GetProductJSONRequestBody(string upc, string accesstoken) {
            this.upc = upc;
            this.accesstoken = accesstoken;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetProductJSONResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetProductJSONResponse", Namespace="http://searchupc.com/", Order=0)]
        public UPC.UPCSearchService.GetProductJSONResponseBody Body;
        
        public GetProductJSONResponse() {
        }
        
        public GetProductJSONResponse(UPC.UPCSearchService.GetProductJSONResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://searchupc.com/")]
    public partial class GetProductJSONResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetProductJSONResult;
        
        public GetProductJSONResponseBody() {
        }
        
        public GetProductJSONResponseBody(string GetProductJSONResult) {
            this.GetProductJSONResult = GetProductJSONResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ValidateRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Validate", Namespace="http://searchupc.com/", Order=0)]
        public UPC.UPCSearchService.ValidateRequestBody Body;
        
        public ValidateRequest() {
        }
        
        public ValidateRequest(UPC.UPCSearchService.ValidateRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://searchupc.com/")]
    public partial class ValidateRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string upc;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string accesstoken;
        
        public ValidateRequestBody() {
        }
        
        public ValidateRequestBody(string upc, string accesstoken) {
            this.upc = upc;
            this.accesstoken = accesstoken;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ValidateResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ValidateResponse", Namespace="http://searchupc.com/", Order=0)]
        public UPC.UPCSearchService.ValidateResponseBody Body;
        
        public ValidateResponse() {
        }
        
        public ValidateResponse(UPC.UPCSearchService.ValidateResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://searchupc.com/")]
    public partial class ValidateResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ValidateResult;
        
        public ValidateResponseBody() {
        }
        
        public ValidateResponseBody(string ValidateResult) {
            this.ValidateResult = ValidateResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConvertToUPCARequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ConvertToUPCA", Namespace="http://searchupc.com/", Order=0)]
        public UPC.UPCSearchService.ConvertToUPCARequestBody Body;
        
        public ConvertToUPCARequest() {
        }
        
        public ConvertToUPCARequest(UPC.UPCSearchService.ConvertToUPCARequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://searchupc.com/")]
    public partial class ConvertToUPCARequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string upce;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string accesstoken;
        
        public ConvertToUPCARequestBody() {
        }
        
        public ConvertToUPCARequestBody(string upce, string accesstoken) {
            this.upce = upce;
            this.accesstoken = accesstoken;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConvertToUPCAResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ConvertToUPCAResponse", Namespace="http://searchupc.com/", Order=0)]
        public UPC.UPCSearchService.ConvertToUPCAResponseBody Body;
        
        public ConvertToUPCAResponse() {
        }
        
        public ConvertToUPCAResponse(UPC.UPCSearchService.ConvertToUPCAResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://searchupc.com/")]
    public partial class ConvertToUPCAResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ConvertToUPCAResult;
        
        public ConvertToUPCAResponseBody() {
        }
        
        public ConvertToUPCAResponseBody(string ConvertToUPCAResult) {
            this.ConvertToUPCAResult = ConvertToUPCAResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GenerateBarcodeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GenerateBarcode", Namespace="http://searchupc.com/", Order=0)]
        public UPC.UPCSearchService.GenerateBarcodeRequestBody Body;
        
        public GenerateBarcodeRequest() {
        }
        
        public GenerateBarcodeRequest(UPC.UPCSearchService.GenerateBarcodeRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://searchupc.com/")]
    public partial class GenerateBarcodeRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string upc;
        
        public GenerateBarcodeRequestBody() {
        }
        
        public GenerateBarcodeRequestBody(string upc) {
            this.upc = upc;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GenerateBarcodeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GenerateBarcodeResponse", Namespace="http://searchupc.com/", Order=0)]
        public UPC.UPCSearchService.GenerateBarcodeResponseBody Body;
        
        public GenerateBarcodeResponse() {
        }
        
        public GenerateBarcodeResponse(UPC.UPCSearchService.GenerateBarcodeResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://searchupc.com/")]
    public partial class GenerateBarcodeResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GenerateBarcodeResult;
        
        public GenerateBarcodeResponseBody() {
        }
        
        public GenerateBarcodeResponseBody(string GenerateBarcodeResult) {
            this.GenerateBarcodeResult = GenerateBarcodeResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SuggestProductRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SuggestProduct", Namespace="http://searchupc.com/", Order=0)]
        public UPC.UPCSearchService.SuggestProductRequestBody Body;
        
        public SuggestProductRequest() {
        }
        
        public SuggestProductRequest(UPC.UPCSearchService.SuggestProductRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://searchupc.com/")]
    public partial class SuggestProductRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string upc;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string productnamewithmanufacturer;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string productattribute;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string accesstoken;
        
        public SuggestProductRequestBody() {
        }
        
        public SuggestProductRequestBody(string upc, string productnamewithmanufacturer, string productattribute, string accesstoken) {
            this.upc = upc;
            this.productnamewithmanufacturer = productnamewithmanufacturer;
            this.productattribute = productattribute;
            this.accesstoken = accesstoken;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SuggestProductResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SuggestProductResponse", Namespace="http://searchupc.com/", Order=0)]
        public UPC.UPCSearchService.SuggestProductResponseBody Body;
        
        public SuggestProductResponse() {
        }
        
        public SuggestProductResponse(UPC.UPCSearchService.SuggestProductResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://searchupc.com/")]
    public partial class SuggestProductResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string SuggestProductResult;
        
        public SuggestProductResponseBody() {
        }
        
        public SuggestProductResponseBody(string SuggestProductResult) {
            this.SuggestProductResult = SuggestProductResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface UPCSearchSoapChannel : UPC.UPCSearchService.UPCSearchSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UPCSearchSoapClient : System.ServiceModel.ClientBase<UPC.UPCSearchService.UPCSearchSoap>, UPC.UPCSearchService.UPCSearchSoap {
        
        public UPCSearchSoapClient() {
        }
        
        public UPCSearchSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UPCSearchSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UPCSearchSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UPCSearchSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        UPC.UPCSearchService.GetProductResponse UPC.UPCSearchService.UPCSearchSoap.GetProduct(UPC.UPCSearchService.GetProductRequest request) {
            return base.Channel.GetProduct(request);
        }
        
        public string GetProduct(string upc, string accesstoken) {
            UPC.UPCSearchService.GetProductRequest inValue = new UPC.UPCSearchService.GetProductRequest();
            inValue.Body = new UPC.UPCSearchService.GetProductRequestBody();
            inValue.Body.upc = upc;
            inValue.Body.accesstoken = accesstoken;
            UPC.UPCSearchService.GetProductResponse retVal = ((UPC.UPCSearchService.UPCSearchSoap)(this)).GetProduct(inValue);
            return retVal.Body.GetProductResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        UPC.UPCSearchService.GetProductJSONResponse UPC.UPCSearchService.UPCSearchSoap.GetProductJSON(UPC.UPCSearchService.GetProductJSONRequest request) {
            return base.Channel.GetProductJSON(request);
        }
        
        public string GetProductJSON(string upc, string accesstoken) {
            UPC.UPCSearchService.GetProductJSONRequest inValue = new UPC.UPCSearchService.GetProductJSONRequest();
            inValue.Body = new UPC.UPCSearchService.GetProductJSONRequestBody();
            inValue.Body.upc = upc;
            inValue.Body.accesstoken = accesstoken;
            UPC.UPCSearchService.GetProductJSONResponse retVal = ((UPC.UPCSearchService.UPCSearchSoap)(this)).GetProductJSON(inValue);
            return retVal.Body.GetProductJSONResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        UPC.UPCSearchService.ValidateResponse UPC.UPCSearchService.UPCSearchSoap.Validate(UPC.UPCSearchService.ValidateRequest request) {
            return base.Channel.Validate(request);
        }
        
        public string Validate(string upc, string accesstoken) {
            UPC.UPCSearchService.ValidateRequest inValue = new UPC.UPCSearchService.ValidateRequest();
            inValue.Body = new UPC.UPCSearchService.ValidateRequestBody();
            inValue.Body.upc = upc;
            inValue.Body.accesstoken = accesstoken;
            UPC.UPCSearchService.ValidateResponse retVal = ((UPC.UPCSearchService.UPCSearchSoap)(this)).Validate(inValue);
            return retVal.Body.ValidateResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        UPC.UPCSearchService.ConvertToUPCAResponse UPC.UPCSearchService.UPCSearchSoap.ConvertToUPCA(UPC.UPCSearchService.ConvertToUPCARequest request) {
            return base.Channel.ConvertToUPCA(request);
        }
        
        public string ConvertToUPCA(string upce, string accesstoken) {
            UPC.UPCSearchService.ConvertToUPCARequest inValue = new UPC.UPCSearchService.ConvertToUPCARequest();
            inValue.Body = new UPC.UPCSearchService.ConvertToUPCARequestBody();
            inValue.Body.upce = upce;
            inValue.Body.accesstoken = accesstoken;
            UPC.UPCSearchService.ConvertToUPCAResponse retVal = ((UPC.UPCSearchService.UPCSearchSoap)(this)).ConvertToUPCA(inValue);
            return retVal.Body.ConvertToUPCAResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        UPC.UPCSearchService.GenerateBarcodeResponse UPC.UPCSearchService.UPCSearchSoap.GenerateBarcode(UPC.UPCSearchService.GenerateBarcodeRequest request) {
            return base.Channel.GenerateBarcode(request);
        }
        
        public string GenerateBarcode(string upc) {
            UPC.UPCSearchService.GenerateBarcodeRequest inValue = new UPC.UPCSearchService.GenerateBarcodeRequest();
            inValue.Body = new UPC.UPCSearchService.GenerateBarcodeRequestBody();
            inValue.Body.upc = upc;
            UPC.UPCSearchService.GenerateBarcodeResponse retVal = ((UPC.UPCSearchService.UPCSearchSoap)(this)).GenerateBarcode(inValue);
            return retVal.Body.GenerateBarcodeResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        UPC.UPCSearchService.SuggestProductResponse UPC.UPCSearchService.UPCSearchSoap.SuggestProduct(UPC.UPCSearchService.SuggestProductRequest request) {
            return base.Channel.SuggestProduct(request);
        }
        
        public string SuggestProduct(string upc, string productnamewithmanufacturer, string productattribute, string accesstoken) {
            UPC.UPCSearchService.SuggestProductRequest inValue = new UPC.UPCSearchService.SuggestProductRequest();
            inValue.Body = new UPC.UPCSearchService.SuggestProductRequestBody();
            inValue.Body.upc = upc;
            inValue.Body.productnamewithmanufacturer = productnamewithmanufacturer;
            inValue.Body.productattribute = productattribute;
            inValue.Body.accesstoken = accesstoken;
            UPC.UPCSearchService.SuggestProductResponse retVal = ((UPC.UPCSearchService.UPCSearchSoap)(this)).SuggestProduct(inValue);
            return retVal.Body.SuggestProductResult;
        }
    }
}