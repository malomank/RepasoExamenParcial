﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Practica2.ServiceReference2 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Persona", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLibrary2")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Practica2.ServiceReference2.Profesor))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Practica2.ServiceReference2.Alumno))]
    public partial class Persona : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodigoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CorreoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DniField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TelefonoField;
        
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
        public int Codigo {
            get {
                return this.CodigoField;
            }
            set {
                if ((this.CodigoField.Equals(value) != true)) {
                    this.CodigoField = value;
                    this.RaisePropertyChanged("Codigo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Correo {
            get {
                return this.CorreoField;
            }
            set {
                if ((object.ReferenceEquals(this.CorreoField, value) != true)) {
                    this.CorreoField = value;
                    this.RaisePropertyChanged("Correo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Dni {
            get {
                return this.DniField;
            }
            set {
                if ((this.DniField.Equals(value) != true)) {
                    this.DniField = value;
                    this.RaisePropertyChanged("Dni");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Telefono {
            get {
                return this.TelefonoField;
            }
            set {
                if ((this.TelefonoField.Equals(value) != true)) {
                    this.TelefonoField = value;
                    this.RaisePropertyChanged("Telefono");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Profesor", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLibrary2")]
    [System.SerializableAttribute()]
    public partial class Profesor : Practica2.ServiceReference2.Persona {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Alumno", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLibrary2")]
    [System.SerializableAttribute()]
    public partial class Alumno : Practica2.ServiceReference2.Persona {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CicloField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CreditosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Practica2.ServiceReference2.Especialidad EspecialidadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Practica2.ServiceReference2.Reunion[] ListaReunionesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Practica2.ServiceReference2.Profesor TutorField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Ciclo {
            get {
                return this.CicloField;
            }
            set {
                if ((this.CicloField.Equals(value) != true)) {
                    this.CicloField = value;
                    this.RaisePropertyChanged("Ciclo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Creditos {
            get {
                return this.CreditosField;
            }
            set {
                if ((this.CreditosField.Equals(value) != true)) {
                    this.CreditosField = value;
                    this.RaisePropertyChanged("Creditos");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Practica2.ServiceReference2.Especialidad Especialidad {
            get {
                return this.EspecialidadField;
            }
            set {
                if ((object.ReferenceEquals(this.EspecialidadField, value) != true)) {
                    this.EspecialidadField = value;
                    this.RaisePropertyChanged("Especialidad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Practica2.ServiceReference2.Reunion[] ListaReuniones {
            get {
                return this.ListaReunionesField;
            }
            set {
                if ((object.ReferenceEquals(this.ListaReunionesField, value) != true)) {
                    this.ListaReunionesField = value;
                    this.RaisePropertyChanged("ListaReuniones");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Practica2.ServiceReference2.Profesor Tutor {
            get {
                return this.TutorField;
            }
            set {
                if ((object.ReferenceEquals(this.TutorField, value) != true)) {
                    this.TutorField = value;
                    this.RaisePropertyChanged("Tutor");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Especialidad", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLibrary2")]
    [System.SerializableAttribute()]
    public partial class Especialidad : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodigoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
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
        public int Codigo {
            get {
                return this.CodigoField;
            }
            set {
                if ((this.CodigoField.Equals(value) != true)) {
                    this.CodigoField = value;
                    this.RaisePropertyChanged("Codigo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Reunion", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLibrary2")]
    [System.SerializableAttribute()]
    public partial class Reunion : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Practica2.ServiceReference2.Alumno AlumnoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Practica2.ServiceReference2.Profesor ProfesorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SugerenciasField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TemaField;
        
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
        public Practica2.ServiceReference2.Alumno Alumno {
            get {
                return this.AlumnoField;
            }
            set {
                if ((object.ReferenceEquals(this.AlumnoField, value) != true)) {
                    this.AlumnoField = value;
                    this.RaisePropertyChanged("Alumno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Fecha {
            get {
                return this.FechaField;
            }
            set {
                if ((this.FechaField.Equals(value) != true)) {
                    this.FechaField = value;
                    this.RaisePropertyChanged("Fecha");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Practica2.ServiceReference2.Profesor Profesor {
            get {
                return this.ProfesorField;
            }
            set {
                if ((object.ReferenceEquals(this.ProfesorField, value) != true)) {
                    this.ProfesorField = value;
                    this.RaisePropertyChanged("Profesor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sugerencias {
            get {
                return this.SugerenciasField;
            }
            set {
                if ((object.ReferenceEquals(this.SugerenciasField, value) != true)) {
                    this.SugerenciasField = value;
                    this.RaisePropertyChanged("Sugerencias");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Tema {
            get {
                return this.TemaField;
            }
            set {
                if ((object.ReferenceEquals(this.TemaField, value) != true)) {
                    this.TemaField = value;
                    this.RaisePropertyChanged("Tema");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProfesorTutor", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLibrary2")]
    [System.SerializableAttribute()]
    public partial class ProfesorTutor : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodigoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Practica2.ServiceReference2.Alumno[] ListaAlumnoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Practica2.ServiceReference2.Reunion[] ListaReunionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Practica2.ServiceReference2.Profesor ProfesorField;
        
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
        public int Codigo {
            get {
                return this.CodigoField;
            }
            set {
                if ((this.CodigoField.Equals(value) != true)) {
                    this.CodigoField = value;
                    this.RaisePropertyChanged("Codigo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Practica2.ServiceReference2.Alumno[] ListaAlumno {
            get {
                return this.ListaAlumnoField;
            }
            set {
                if ((object.ReferenceEquals(this.ListaAlumnoField, value) != true)) {
                    this.ListaAlumnoField = value;
                    this.RaisePropertyChanged("ListaAlumno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Practica2.ServiceReference2.Reunion[] ListaReunion {
            get {
                return this.ListaReunionField;
            }
            set {
                if ((object.ReferenceEquals(this.ListaReunionField, value) != true)) {
                    this.ListaReunionField = value;
                    this.RaisePropertyChanged("ListaReunion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Practica2.ServiceReference2.Profesor Profesor {
            get {
                return this.ProfesorField;
            }
            set {
                if ((object.ReferenceEquals(this.ProfesorField, value) != true)) {
                    this.ProfesorField = value;
                    this.RaisePropertyChanged("Profesor");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.IGestorTutoria")]
    public interface IGestorTutoria {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestorTutoria/agregarAlumno", ReplyAction="http://tempuri.org/IGestorTutoria/agregarAlumnoResponse")]
        void agregarAlumno(Practica2.ServiceReference2.Alumno alumno);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestorTutoria/agregarAlumno", ReplyAction="http://tempuri.org/IGestorTutoria/agregarAlumnoResponse")]
        System.Threading.Tasks.Task agregarAlumnoAsync(Practica2.ServiceReference2.Alumno alumno);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestorTutoria/agregarReunion", ReplyAction="http://tempuri.org/IGestorTutoria/agregarReunionResponse")]
        void agregarReunion(Practica2.ServiceReference2.Alumno alumno, Practica2.ServiceReference2.Profesor profesor, System.DateTime fecha, string tema, string sugerencia);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestorTutoria/agregarReunion", ReplyAction="http://tempuri.org/IGestorTutoria/agregarReunionResponse")]
        System.Threading.Tasks.Task agregarReunionAsync(Practica2.ServiceReference2.Alumno alumno, Practica2.ServiceReference2.Profesor profesor, System.DateTime fecha, string tema, string sugerencia);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestorTutoria/buscarAlumno", ReplyAction="http://tempuri.org/IGestorTutoria/buscarAlumnoResponse")]
        Practica2.ServiceReference2.Alumno buscarAlumno(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestorTutoria/buscarAlumno", ReplyAction="http://tempuri.org/IGestorTutoria/buscarAlumnoResponse")]
        System.Threading.Tasks.Task<Practica2.ServiceReference2.Alumno> buscarAlumnoAsync(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestorTutoria/buscarTutor", ReplyAction="http://tempuri.org/IGestorTutoria/buscarTutorResponse")]
        Practica2.ServiceReference2.ProfesorTutor buscarTutor(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGestorTutoria/buscarTutor", ReplyAction="http://tempuri.org/IGestorTutoria/buscarTutorResponse")]
        System.Threading.Tasks.Task<Practica2.ServiceReference2.ProfesorTutor> buscarTutorAsync(int codigo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGestorTutoriaChannel : Practica2.ServiceReference2.IGestorTutoria, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GestorTutoriaClient : System.ServiceModel.ClientBase<Practica2.ServiceReference2.IGestorTutoria>, Practica2.ServiceReference2.IGestorTutoria {
        
        public GestorTutoriaClient() {
        }
        
        public GestorTutoriaClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GestorTutoriaClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GestorTutoriaClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GestorTutoriaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void agregarAlumno(Practica2.ServiceReference2.Alumno alumno) {
            base.Channel.agregarAlumno(alumno);
        }
        
        public System.Threading.Tasks.Task agregarAlumnoAsync(Practica2.ServiceReference2.Alumno alumno) {
            return base.Channel.agregarAlumnoAsync(alumno);
        }
        
        public void agregarReunion(Practica2.ServiceReference2.Alumno alumno, Practica2.ServiceReference2.Profesor profesor, System.DateTime fecha, string tema, string sugerencia) {
            base.Channel.agregarReunion(alumno, profesor, fecha, tema, sugerencia);
        }
        
        public System.Threading.Tasks.Task agregarReunionAsync(Practica2.ServiceReference2.Alumno alumno, Practica2.ServiceReference2.Profesor profesor, System.DateTime fecha, string tema, string sugerencia) {
            return base.Channel.agregarReunionAsync(alumno, profesor, fecha, tema, sugerencia);
        }
        
        public Practica2.ServiceReference2.Alumno buscarAlumno(int codigo) {
            return base.Channel.buscarAlumno(codigo);
        }
        
        public System.Threading.Tasks.Task<Practica2.ServiceReference2.Alumno> buscarAlumnoAsync(int codigo) {
            return base.Channel.buscarAlumnoAsync(codigo);
        }
        
        public Practica2.ServiceReference2.ProfesorTutor buscarTutor(int codigo) {
            return base.Channel.buscarTutor(codigo);
        }
        
        public System.Threading.Tasks.Task<Practica2.ServiceReference2.ProfesorTutor> buscarTutorAsync(int codigo) {
            return base.Channel.buscarTutorAsync(codigo);
        }
    }
}
