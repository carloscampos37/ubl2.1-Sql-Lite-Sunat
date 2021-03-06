﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OpenInvoicePeru.ServicioSunat.Soap.Consultas {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://service.sunat.gob.pe", ConfigurationName="Consultas.billService")]
    public interface billService {
        
        // CODEGEN: El parámetro 'status' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="urn:getStatus", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="status")]
        OpenInvoicePeru.ServicioSunat.Soap.Consultas.getStatusResponse getStatus(OpenInvoicePeru.ServicioSunat.Soap.Consultas.getStatusRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:getStatus", ReplyAction="*")]
        System.Threading.Tasks.Task<OpenInvoicePeru.ServicioSunat.Soap.Consultas.getStatusResponse> getStatusAsync(OpenInvoicePeru.ServicioSunat.Soap.Consultas.getStatusRequest request);
        
        // CODEGEN: El parámetro 'statusCdr' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="urn:getStatusCdr", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="statusCdr")]
        OpenInvoicePeru.ServicioSunat.Soap.Consultas.getStatusCdrResponse getStatusCdr(OpenInvoicePeru.ServicioSunat.Soap.Consultas.getStatusCdrRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:getStatusCdr", ReplyAction="*")]
        System.Threading.Tasks.Task<OpenInvoicePeru.ServicioSunat.Soap.Consultas.getStatusCdrResponse> getStatusCdrAsync(OpenInvoicePeru.ServicioSunat.Soap.Consultas.getStatusCdrRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://service.sunat.gob.pe")]
    public partial class statusResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private byte[] contentField;
        
        private string statusCodeField;
        
        private string statusMessageField;
        
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string statusMessage {
            get {
                return this.statusMessageField;
            }
            set {
                this.statusMessageField = value;
                this.RaisePropertyChanged("statusMessage");
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
        public string rucComprobante;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string tipoComprobante;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string serieComprobante;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int numeroComprobante;
        
        public getStatusRequest() {
        }
        
        public getStatusRequest(string rucComprobante, string tipoComprobante, string serieComprobante, int numeroComprobante) {
            this.rucComprobante = rucComprobante;
            this.tipoComprobante = tipoComprobante;
            this.serieComprobante = serieComprobante;
            this.numeroComprobante = numeroComprobante;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getStatusResponse", WrapperNamespace="http://service.sunat.gob.pe", IsWrapped=true)]
    public partial class getStatusResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public OpenInvoicePeru.ServicioSunat.Soap.Consultas.statusResponse status;
        
        public getStatusResponse() {
        }
        
        public getStatusResponse(OpenInvoicePeru.ServicioSunat.Soap.Consultas.statusResponse status) {
            this.status = status;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getStatusCdr", WrapperNamespace="http://service.sunat.gob.pe", IsWrapped=true)]
    public partial class getStatusCdrRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string rucComprobante;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string tipoComprobante;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string serieComprobante;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int numeroComprobante;
        
        public getStatusCdrRequest() {
        }
        
        public getStatusCdrRequest(string rucComprobante, string tipoComprobante, string serieComprobante, int numeroComprobante) {
            this.rucComprobante = rucComprobante;
            this.tipoComprobante = tipoComprobante;
            this.serieComprobante = serieComprobante;
            this.numeroComprobante = numeroComprobante;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getStatusCdrResponse", WrapperNamespace="http://service.sunat.gob.pe", IsWrapped=true)]
    public partial class getStatusCdrResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public OpenInvoicePeru.ServicioSunat.Soap.Consultas.statusResponse statusCdr;
        
        public getStatusCdrResponse() {
        }
        
        public getStatusCdrResponse(OpenInvoicePeru.ServicioSunat.Soap.Consultas.statusResponse statusCdr) {
            this.statusCdr = statusCdr;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface billServiceChannel : OpenInvoicePeru.ServicioSunat.Soap.Consultas.billService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class billServiceClient : System.ServiceModel.ClientBase<OpenInvoicePeru.ServicioSunat.Soap.Consultas.billService>, OpenInvoicePeru.ServicioSunat.Soap.Consultas.billService {
        
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
        OpenInvoicePeru.ServicioSunat.Soap.Consultas.getStatusResponse OpenInvoicePeru.ServicioSunat.Soap.Consultas.billService.getStatus(OpenInvoicePeru.ServicioSunat.Soap.Consultas.getStatusRequest request) {
            return base.Channel.getStatus(request);
        }
        
        public OpenInvoicePeru.ServicioSunat.Soap.Consultas.statusResponse getStatus(string rucComprobante, string tipoComprobante, string serieComprobante, int numeroComprobante) {
            OpenInvoicePeru.ServicioSunat.Soap.Consultas.getStatusRequest inValue = new OpenInvoicePeru.ServicioSunat.Soap.Consultas.getStatusRequest();
            inValue.rucComprobante = rucComprobante;
            inValue.tipoComprobante = tipoComprobante;
            inValue.serieComprobante = serieComprobante;
            inValue.numeroComprobante = numeroComprobante;
            OpenInvoicePeru.ServicioSunat.Soap.Consultas.getStatusResponse retVal = ((OpenInvoicePeru.ServicioSunat.Soap.Consultas.billService)(this)).getStatus(inValue);
            return retVal.status;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<OpenInvoicePeru.ServicioSunat.Soap.Consultas.getStatusResponse> OpenInvoicePeru.ServicioSunat.Soap.Consultas.billService.getStatusAsync(OpenInvoicePeru.ServicioSunat.Soap.Consultas.getStatusRequest request) {
            return base.Channel.getStatusAsync(request);
        }
        
        public System.Threading.Tasks.Task<OpenInvoicePeru.ServicioSunat.Soap.Consultas.getStatusResponse> getStatusAsync(string rucComprobante, string tipoComprobante, string serieComprobante, int numeroComprobante) {
            OpenInvoicePeru.ServicioSunat.Soap.Consultas.getStatusRequest inValue = new OpenInvoicePeru.ServicioSunat.Soap.Consultas.getStatusRequest();
            inValue.rucComprobante = rucComprobante;
            inValue.tipoComprobante = tipoComprobante;
            inValue.serieComprobante = serieComprobante;
            inValue.numeroComprobante = numeroComprobante;
            return ((OpenInvoicePeru.ServicioSunat.Soap.Consultas.billService)(this)).getStatusAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        OpenInvoicePeru.ServicioSunat.Soap.Consultas.getStatusCdrResponse OpenInvoicePeru.ServicioSunat.Soap.Consultas.billService.getStatusCdr(OpenInvoicePeru.ServicioSunat.Soap.Consultas.getStatusCdrRequest request) {
            return base.Channel.getStatusCdr(request);
        }
        
        public OpenInvoicePeru.ServicioSunat.Soap.Consultas.statusResponse getStatusCdr(string rucComprobante, string tipoComprobante, string serieComprobante, int numeroComprobante) {
            OpenInvoicePeru.ServicioSunat.Soap.Consultas.getStatusCdrRequest inValue = new OpenInvoicePeru.ServicioSunat.Soap.Consultas.getStatusCdrRequest();
            inValue.rucComprobante = rucComprobante;
            inValue.tipoComprobante = tipoComprobante;
            inValue.serieComprobante = serieComprobante;
            inValue.numeroComprobante = numeroComprobante;
            OpenInvoicePeru.ServicioSunat.Soap.Consultas.getStatusCdrResponse retVal = ((OpenInvoicePeru.ServicioSunat.Soap.Consultas.billService)(this)).getStatusCdr(inValue);
            return retVal.statusCdr;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<OpenInvoicePeru.ServicioSunat.Soap.Consultas.getStatusCdrResponse> OpenInvoicePeru.ServicioSunat.Soap.Consultas.billService.getStatusCdrAsync(OpenInvoicePeru.ServicioSunat.Soap.Consultas.getStatusCdrRequest request) {
            return base.Channel.getStatusCdrAsync(request);
        }
        
        public System.Threading.Tasks.Task<OpenInvoicePeru.ServicioSunat.Soap.Consultas.getStatusCdrResponse> getStatusCdrAsync(string rucComprobante, string tipoComprobante, string serieComprobante, int numeroComprobante) {
            OpenInvoicePeru.ServicioSunat.Soap.Consultas.getStatusCdrRequest inValue = new OpenInvoicePeru.ServicioSunat.Soap.Consultas.getStatusCdrRequest();
            inValue.rucComprobante = rucComprobante;
            inValue.tipoComprobante = tipoComprobante;
            inValue.serieComprobante = serieComprobante;
            inValue.numeroComprobante = numeroComprobante;
            return ((OpenInvoicePeru.ServicioSunat.Soap.Consultas.billService)(this)).getStatusCdrAsync(inValue);
        }
    }
}
