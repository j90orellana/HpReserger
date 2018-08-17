﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HPReserger.ServerBetaFactura {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://service.sunat.gob.pe", ConfigurationName="ServerBetaFactura.billService")]
    public interface billService {
        
        // CODEGEN: El parámetro 'status' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="urn:getStatus", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="status")]
        HPReserger.ServerBetaFactura.getStatusResponse getStatus(HPReserger.ServerBetaFactura.getStatusRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:getStatus", ReplyAction="*")]
        System.Threading.Tasks.Task<HPReserger.ServerBetaFactura.getStatusResponse> getStatusAsync(HPReserger.ServerBetaFactura.getStatusRequest request);
        
        // CODEGEN: El parámetro 'applicationResponse' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="urn:sendBill", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="applicationResponse")]
        HPReserger.ServerBetaFactura.sendBillResponse sendBill(HPReserger.ServerBetaFactura.sendBillRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:sendBill", ReplyAction="*")]
        System.Threading.Tasks.Task<HPReserger.ServerBetaFactura.sendBillResponse> sendBillAsync(HPReserger.ServerBetaFactura.sendBillRequest request);
        
        // CODEGEN: El parámetro 'ticket' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="urn:sendPack", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="ticket")]
        HPReserger.ServerBetaFactura.sendPackResponse sendPack(HPReserger.ServerBetaFactura.sendPackRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:sendPack", ReplyAction="*")]
        System.Threading.Tasks.Task<HPReserger.ServerBetaFactura.sendPackResponse> sendPackAsync(HPReserger.ServerBetaFactura.sendPackRequest request);
        
        // CODEGEN: El parámetro 'ticket' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="urn:sendSummary", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="ticket")]
        HPReserger.ServerBetaFactura.sendSummaryResponse sendSummary(HPReserger.ServerBetaFactura.sendSummaryRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:sendSummary", ReplyAction="*")]
        System.Threading.Tasks.Task<HPReserger.ServerBetaFactura.sendSummaryResponse> sendSummaryAsync(HPReserger.ServerBetaFactura.sendSummaryRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://service.sunat.gob.pe")]
    public partial class statusResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private byte[] contentField;
        
        private string statusCodeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary", Order=0)]
        public byte[] content {
            get {
                return this.contentField;
            }
            set {
                this.contentField = value;
                this.RaisePropertyChanged("content");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string statusCode {
            get {
                return this.statusCodeField;
            }
            set {
                this.statusCodeField = value;
                this.RaisePropertyChanged("statusCode");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getStatus", WrapperNamespace="http://service.sunat.gob.pe", IsWrapped=true)]
    public partial class getStatusRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ticket;
        
        public getStatusRequest() {
        }
        
        public getStatusRequest(string ticket) {
            this.ticket = ticket;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getStatusResponse", WrapperNamespace="http://service.sunat.gob.pe", IsWrapped=true)]
    public partial class getStatusResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public HPReserger.ServerBetaFactura.statusResponse status;
        
        public getStatusResponse() {
        }
        
        public getStatusResponse(HPReserger.ServerBetaFactura.statusResponse status) {
            this.status = status;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="sendBill", WrapperNamespace="http://service.sunat.gob.pe", IsWrapped=true)]
    public partial class sendBillRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string fileName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary")]
        public byte[] contentFile;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string partyType;
        
        public sendBillRequest() {
        }
        
        public sendBillRequest(string fileName, byte[] contentFile, string partyType) {
            this.fileName = fileName;
            this.contentFile = contentFile;
            this.partyType = partyType;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="sendBillResponse", WrapperNamespace="http://service.sunat.gob.pe", IsWrapped=true)]
    public partial class sendBillResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary")]
        public byte[] applicationResponse;
        
        public sendBillResponse() {
        }
        
        public sendBillResponse(byte[] applicationResponse) {
            this.applicationResponse = applicationResponse;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="sendPack", WrapperNamespace="http://service.sunat.gob.pe", IsWrapped=true)]
    public partial class sendPackRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string fileName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary")]
        public byte[] contentFile;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string partyType;
        
        public sendPackRequest() {
        }
        
        public sendPackRequest(string fileName, byte[] contentFile, string partyType) {
            this.fileName = fileName;
            this.contentFile = contentFile;
            this.partyType = partyType;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="sendPackResponse", WrapperNamespace="http://service.sunat.gob.pe", IsWrapped=true)]
    public partial class sendPackResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ticket;
        
        public sendPackResponse() {
        }
        
        public sendPackResponse(string ticket) {
            this.ticket = ticket;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="sendSummary", WrapperNamespace="http://service.sunat.gob.pe", IsWrapped=true)]
    public partial class sendSummaryRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string fileName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary")]
        public byte[] contentFile;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string partyType;
        
        public sendSummaryRequest() {
        }
        
        public sendSummaryRequest(string fileName, byte[] contentFile, string partyType) {
            this.fileName = fileName;
            this.contentFile = contentFile;
            this.partyType = partyType;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="sendSummaryResponse", WrapperNamespace="http://service.sunat.gob.pe", IsWrapped=true)]
    public partial class sendSummaryResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ticket;
        
        public sendSummaryResponse() {
        }
        
        public sendSummaryResponse(string ticket) {
            this.ticket = ticket;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface billServiceChannel : HPReserger.ServerBetaFactura.billService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class billServiceClient : System.ServiceModel.ClientBase<HPReserger.ServerBetaFactura.billService>, HPReserger.ServerBetaFactura.billService {
        
        public billServiceClient() {
        }
        
        public billServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public billServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public billServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public billServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        HPReserger.ServerBetaFactura.getStatusResponse HPReserger.ServerBetaFactura.billService.getStatus(HPReserger.ServerBetaFactura.getStatusRequest request) {
            return base.Channel.getStatus(request);
        }
        
        public HPReserger.ServerBetaFactura.statusResponse getStatus(string ticket) {
            HPReserger.ServerBetaFactura.getStatusRequest inValue = new HPReserger.ServerBetaFactura.getStatusRequest();
            inValue.ticket = ticket;
            HPReserger.ServerBetaFactura.getStatusResponse retVal = ((HPReserger.ServerBetaFactura.billService)(this)).getStatus(inValue);
            return retVal.status;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<HPReserger.ServerBetaFactura.getStatusResponse> HPReserger.ServerBetaFactura.billService.getStatusAsync(HPReserger.ServerBetaFactura.getStatusRequest request) {
            return base.Channel.getStatusAsync(request);
        }
        
        public System.Threading.Tasks.Task<HPReserger.ServerBetaFactura.getStatusResponse> getStatusAsync(string ticket) {
            HPReserger.ServerBetaFactura.getStatusRequest inValue = new HPReserger.ServerBetaFactura.getStatusRequest();
            inValue.ticket = ticket;
            return ((HPReserger.ServerBetaFactura.billService)(this)).getStatusAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        HPReserger.ServerBetaFactura.sendBillResponse HPReserger.ServerBetaFactura.billService.sendBill(HPReserger.ServerBetaFactura.sendBillRequest request) {
            return base.Channel.sendBill(request);
        }
        
        public byte[] sendBill(string fileName, byte[] contentFile, string partyType) {
            HPReserger.ServerBetaFactura.sendBillRequest inValue = new HPReserger.ServerBetaFactura.sendBillRequest();
            inValue.fileName = fileName;
            inValue.contentFile = contentFile;
            inValue.partyType = partyType;
            HPReserger.ServerBetaFactura.sendBillResponse retVal = ((HPReserger.ServerBetaFactura.billService)(this)).sendBill(inValue);
            return retVal.applicationResponse;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<HPReserger.ServerBetaFactura.sendBillResponse> HPReserger.ServerBetaFactura.billService.sendBillAsync(HPReserger.ServerBetaFactura.sendBillRequest request) {
            return base.Channel.sendBillAsync(request);
        }
        
        public System.Threading.Tasks.Task<HPReserger.ServerBetaFactura.sendBillResponse> sendBillAsync(string fileName, byte[] contentFile, string partyType) {
            HPReserger.ServerBetaFactura.sendBillRequest inValue = new HPReserger.ServerBetaFactura.sendBillRequest();
            inValue.fileName = fileName;
            inValue.contentFile = contentFile;
            inValue.partyType = partyType;
            return ((HPReserger.ServerBetaFactura.billService)(this)).sendBillAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        HPReserger.ServerBetaFactura.sendPackResponse HPReserger.ServerBetaFactura.billService.sendPack(HPReserger.ServerBetaFactura.sendPackRequest request) {
            return base.Channel.sendPack(request);
        }
        
        public string sendPack(string fileName, byte[] contentFile, string partyType) {
            HPReserger.ServerBetaFactura.sendPackRequest inValue = new HPReserger.ServerBetaFactura.sendPackRequest();
            inValue.fileName = fileName;
            inValue.contentFile = contentFile;
            inValue.partyType = partyType;
            HPReserger.ServerBetaFactura.sendPackResponse retVal = ((HPReserger.ServerBetaFactura.billService)(this)).sendPack(inValue);
            return retVal.ticket;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<HPReserger.ServerBetaFactura.sendPackResponse> HPReserger.ServerBetaFactura.billService.sendPackAsync(HPReserger.ServerBetaFactura.sendPackRequest request) {
            return base.Channel.sendPackAsync(request);
        }
        
        public System.Threading.Tasks.Task<HPReserger.ServerBetaFactura.sendPackResponse> sendPackAsync(string fileName, byte[] contentFile, string partyType) {
            HPReserger.ServerBetaFactura.sendPackRequest inValue = new HPReserger.ServerBetaFactura.sendPackRequest();
            inValue.fileName = fileName;
            inValue.contentFile = contentFile;
            inValue.partyType = partyType;
            return ((HPReserger.ServerBetaFactura.billService)(this)).sendPackAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        HPReserger.ServerBetaFactura.sendSummaryResponse HPReserger.ServerBetaFactura.billService.sendSummary(HPReserger.ServerBetaFactura.sendSummaryRequest request) {
            return base.Channel.sendSummary(request);
        }
        
        public string sendSummary(string fileName, byte[] contentFile, string partyType) {
            HPReserger.ServerBetaFactura.sendSummaryRequest inValue = new HPReserger.ServerBetaFactura.sendSummaryRequest();
            inValue.fileName = fileName;
            inValue.contentFile = contentFile;
            inValue.partyType = partyType;
            HPReserger.ServerBetaFactura.sendSummaryResponse retVal = ((HPReserger.ServerBetaFactura.billService)(this)).sendSummary(inValue);
            return retVal.ticket;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<HPReserger.ServerBetaFactura.sendSummaryResponse> HPReserger.ServerBetaFactura.billService.sendSummaryAsync(HPReserger.ServerBetaFactura.sendSummaryRequest request) {
            return base.Channel.sendSummaryAsync(request);
        }
        
        public System.Threading.Tasks.Task<HPReserger.ServerBetaFactura.sendSummaryResponse> sendSummaryAsync(string fileName, byte[] contentFile, string partyType) {
            HPReserger.ServerBetaFactura.sendSummaryRequest inValue = new HPReserger.ServerBetaFactura.sendSummaryRequest();
            inValue.fileName = fileName;
            inValue.contentFile = contentFile;
            inValue.partyType = partyType;
            return ((HPReserger.ServerBetaFactura.billService)(this)).sendSummaryAsync(inValue);
        }
    }
}