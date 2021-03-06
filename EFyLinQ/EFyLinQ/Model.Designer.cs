﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("DemoNCRModel", "FK_Empleado_Puesto", "Puesto", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(EFyLinQ.Puesto), "Empleado", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(EFyLinQ.Empleado), true)]

#endregion

namespace EFyLinQ
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class DemoNCREntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new DemoNCREntities object using the connection string found in the 'DemoNCREntities' section of the application configuration file.
        /// </summary>
        public DemoNCREntities() : base("name=DemoNCREntities", "DemoNCREntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DemoNCREntities object.
        /// </summary>
        public DemoNCREntities(string connectionString) : base(connectionString, "DemoNCREntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DemoNCREntities object.
        /// </summary>
        public DemoNCREntities(EntityConnection connection) : base(connection, "DemoNCREntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Empleado> Empleadoes
        {
            get
            {
                if ((_Empleadoes == null))
                {
                    _Empleadoes = base.CreateObjectSet<Empleado>("Empleadoes");
                }
                return _Empleadoes;
            }
        }
        private ObjectSet<Empleado> _Empleadoes;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Puesto> Puestoes
        {
            get
            {
                if ((_Puestoes == null))
                {
                    _Puestoes = base.CreateObjectSet<Puesto>("Puestoes");
                }
                return _Puestoes;
            }
        }
        private ObjectSet<Puesto> _Puestoes;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Empleadoes EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToEmpleadoes(Empleado empleado)
        {
            base.AddObject("Empleadoes", empleado);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Puestoes EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToPuestoes(Puesto puesto)
        {
            base.AddObject("Puestoes", puesto);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DemoNCRModel", Name="Empleado")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Empleado : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Empleado object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="nombre">Initial value of the Nombre property.</param>
        /// <param name="puestoId">Initial value of the PuestoId property.</param>
        public static Empleado CreateEmpleado(global::System.String id, global::System.String nombre, global::System.Int32 puestoId)
        {
            Empleado empleado = new Empleado();
            empleado.Id = id;
            empleado.Nombre = nombre;
            empleado.PuestoId = puestoId;
            return empleado;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.String _Id;
        partial void OnIdChanging(global::System.String value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Nombre
        {
            get
            {
                return _Nombre;
            }
            set
            {
                OnNombreChanging(value);
                ReportPropertyChanging("Nombre");
                _Nombre = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Nombre");
                OnNombreChanged();
            }
        }
        private global::System.String _Nombre;
        partial void OnNombreChanging(global::System.String value);
        partial void OnNombreChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 PuestoId
        {
            get
            {
                return _PuestoId;
            }
            set
            {
                OnPuestoIdChanging(value);
                ReportPropertyChanging("PuestoId");
                _PuestoId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("PuestoId");
                OnPuestoIdChanged();
            }
        }
        private global::System.Int32 _PuestoId;
        partial void OnPuestoIdChanging(global::System.Int32 value);
        partial void OnPuestoIdChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("DemoNCRModel", "FK_Empleado_Puesto", "Puesto")]
        public Puesto Puesto
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Puesto>("DemoNCRModel.FK_Empleado_Puesto", "Puesto").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Puesto>("DemoNCRModel.FK_Empleado_Puesto", "Puesto").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Puesto> PuestoReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Puesto>("DemoNCRModel.FK_Empleado_Puesto", "Puesto");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Puesto>("DemoNCRModel.FK_Empleado_Puesto", "Puesto", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DemoNCRModel", Name="Puesto")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Puesto : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Puesto object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="descripcion">Initial value of the Descripcion property.</param>
        public static Puesto CreatePuesto(global::System.Int32 id, global::System.String descripcion)
        {
            Puesto puesto = new Puesto();
            puesto.Id = id;
            puesto.Descripcion = descripcion;
            return puesto;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Descripcion
        {
            get
            {
                return _Descripcion;
            }
            set
            {
                OnDescripcionChanging(value);
                ReportPropertyChanging("Descripcion");
                _Descripcion = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Descripcion");
                OnDescripcionChanged();
            }
        }
        private global::System.String _Descripcion;
        partial void OnDescripcionChanging(global::System.String value);
        partial void OnDescripcionChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("DemoNCRModel", "FK_Empleado_Puesto", "Empleado")]
        public EntityCollection<Empleado> Empleadoes
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Empleado>("DemoNCRModel.FK_Empleado_Puesto", "Empleado");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Empleado>("DemoNCRModel.FK_Empleado_Puesto", "Empleado", value);
                }
            }
        }

        #endregion

    }

    #endregion

    
}
