

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightSwitchApplication
{
    #region Entities
    
    /// <summary>
    /// No Modeled Description Available
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    public sealed partial class Appointment : global::Microsoft.LightSwitch.Framework.Base.EntityObject<global::LightSwitchApplication.Appointment, global::LightSwitchApplication.Appointment.DetailsClass>
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new instance of the Appointment entity.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Appointment()
            : this(null)
        {
        }
    
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Appointment(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.Appointment> entitySet)
            : base(entitySet)
        {
            global::LightSwitchApplication.Appointment.DetailsClass.Initialize(this);
        }
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Appointment_Created();
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Appointment_AllowSaveWithErrors(ref bool result);
    
        #endregion
    
        #region Private Properties
        
        /// <summary>
        /// Gets the Application object for this application.  The Application object provides access to active screens, methods to open screens and access to the current user.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::Microsoft.LightSwitch.IApplication<global::LightSwitchApplication.DataWorkspace> Application
        {
            get
            {
                return global::LightSwitchApplication.Application.Current;
            }
        }
        
        /// <summary>
        /// Gets the containing data workspace.  The data workspace provides access to all data sources in the application.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::LightSwitchApplication.DataWorkspace DataWorkspace
        {
            get
            {
                return (global::LightSwitchApplication.DataWorkspace)this.Details.EntitySet.Details.DataService.Details.DataWorkspace;
            }
        }
        
        #endregion
    
        #region Public Properties
    
        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public int Id
        {
            get
            {
                return global::LightSwitchApplication.Appointment.DetailsClass.GetValue(this, global::LightSwitchApplication.Appointment.DetailsClass.PropertySetProperties.Id);
            }
            set
            {
                global::LightSwitchApplication.Appointment.DetailsClass.SetValue(this, global::LightSwitchApplication.Appointment.DetailsClass.PropertySetProperties.Id, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Id_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Id_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Id_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.DateTime AppointmentTime
        {
            get
            {
                return global::LightSwitchApplication.Appointment.DetailsClass.GetValue(this, global::LightSwitchApplication.Appointment.DetailsClass.PropertySetProperties.AppointmentTime);
            }
            set
            {
                global::LightSwitchApplication.Appointment.DetailsClass.SetValue(this, global::LightSwitchApplication.Appointment.DetailsClass.PropertySetProperties.AppointmentTime, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void AppointmentTime_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void AppointmentTime_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void AppointmentTime_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public short AppointmentType
        {
            get
            {
                return global::LightSwitchApplication.Appointment.DetailsClass.GetValue(this, global::LightSwitchApplication.Appointment.DetailsClass.PropertySetProperties.AppointmentType);
            }
            set
            {
                global::LightSwitchApplication.Appointment.DetailsClass.SetValue(this, global::LightSwitchApplication.Appointment.DetailsClass.PropertySetProperties.AppointmentType, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void AppointmentType_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void AppointmentType_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void AppointmentType_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string DoctorNotes
        {
            get
            {
                return global::LightSwitchApplication.Appointment.DetailsClass.GetValue(this, global::LightSwitchApplication.Appointment.DetailsClass.PropertySetProperties.DoctorNotes);
            }
            set
            {
                global::LightSwitchApplication.Appointment.DetailsClass.SetValue(this, global::LightSwitchApplication.Appointment.DetailsClass.PropertySetProperties.DoctorNotes, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void DoctorNotes_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void DoctorNotes_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void DoctorNotes_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::LightSwitchApplication.Patient Patient
        {
            get
            {
                return global::LightSwitchApplication.Appointment.DetailsClass.GetValue(this, global::LightSwitchApplication.Appointment.DetailsClass.PropertySetProperties.Patient);
            }
            set
            {
                global::LightSwitchApplication.Appointment.DetailsClass.SetValue(this, global::LightSwitchApplication.Appointment.DetailsClass.PropertySetProperties.Patient, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Patient_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Patient_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Patient_Changed();

        #endregion
    
        #region Details Class
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public sealed class DetailsClass : global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<
                global::LightSwitchApplication.Appointment,
                global::LightSwitchApplication.Appointment.DetailsClass,
                global::LightSwitchApplication.Appointment.DetailsClass.IImplementation,
                global::LightSwitchApplication.Appointment.DetailsClass.PropertySet,
                global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.Appointment, global::LightSwitchApplication.Appointment.DetailsClass>,
                global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.Appointment, global::LightSwitchApplication.Appointment.DetailsClass>>
        {
    
            static DetailsClass()
            {
                var initializeEntry = global::LightSwitchApplication.Appointment.DetailsClass.PropertySetProperties.Id;
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.Appointment, global::LightSwitchApplication.Appointment.DetailsClass>.Entry
                __AppointmentEntry = new global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.Appointment, global::LightSwitchApplication.Appointment.DetailsClass>.Entry(
                    global::LightSwitchApplication.Appointment.DetailsClass.__Appointment_CreateNew,
                    global::LightSwitchApplication.Appointment.DetailsClass.__Appointment_Created,
                    global::LightSwitchApplication.Appointment.DetailsClass.__Appointment_AllowSaveWithErrors);
            private static global::LightSwitchApplication.Appointment __Appointment_CreateNew(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.Appointment> es)
            {
                return new global::LightSwitchApplication.Appointment(es);
            }
            private static void __Appointment_Created(global::LightSwitchApplication.Appointment e)
            {
                e.Appointment_Created();
            }
            private static bool __Appointment_AllowSaveWithErrors(global::LightSwitchApplication.Appointment e)
            {
                bool result = false;
                e.Appointment_AllowSaveWithErrors(ref result);
                return result;
            }
    
            public DetailsClass() : base()
            {
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.Appointment, global::LightSwitchApplication.Appointment.DetailsClass> Commands
            {
                get
                {
                    return base.Commands;
                }
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.Appointment, global::LightSwitchApplication.Appointment.DetailsClass> Methods
            {
                get
                {
                    return base.Methods;
                }
            }
    
            public new global::LightSwitchApplication.Appointment.DetailsClass.PropertySet Properties
            {
                get
                {
                    return base.Properties;
                }
            }
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class PropertySet : global::Microsoft.LightSwitch.Details.Framework.Base.EntityPropertySet<global::LightSwitchApplication.Appointment, global::LightSwitchApplication.Appointment.DetailsClass>
            {
    
                public PropertySet() : base()
                {
                }
    
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Appointment, global::LightSwitchApplication.Appointment.DetailsClass, int> Id
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Appointment.DetailsClass.PropertySetProperties.Id) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Appointment, global::LightSwitchApplication.Appointment.DetailsClass, int>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Appointment, global::LightSwitchApplication.Appointment.DetailsClass, global::System.DateTime> AppointmentTime
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Appointment.DetailsClass.PropertySetProperties.AppointmentTime) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Appointment, global::LightSwitchApplication.Appointment.DetailsClass, global::System.DateTime>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Appointment, global::LightSwitchApplication.Appointment.DetailsClass, short> AppointmentType
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Appointment.DetailsClass.PropertySetProperties.AppointmentType) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Appointment, global::LightSwitchApplication.Appointment.DetailsClass, short>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Appointment, global::LightSwitchApplication.Appointment.DetailsClass, string> DoctorNotes
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Appointment.DetailsClass.PropertySetProperties.DoctorNotes) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Appointment, global::LightSwitchApplication.Appointment.DetailsClass, string>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.Appointment, global::LightSwitchApplication.Appointment.DetailsClass, global::LightSwitchApplication.Patient> Patient
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Appointment.DetailsClass.PropertySetProperties.Patient) as global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.Appointment, global::LightSwitchApplication.Appointment.DetailsClass, global::LightSwitchApplication.Patient>;
                    }
                }
                
            }
    
            #pragma warning disable 109
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            public interface IImplementation : global::Microsoft.LightSwitch.Internal.IEntityImplementation
            {
                new int Id { get; set; }
                new global::System.DateTime AppointmentTime { get; set; }
                new short AppointmentType { get; set; }
                new string DoctorNotes { get; set; }
                new global::Microsoft.LightSwitch.Internal.IEntityImplementation Patient { get; set; }
            }
            #pragma warning restore 109
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal class PropertySetProperties
            {
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Appointment, global::LightSwitchApplication.Appointment.DetailsClass, int>.Entry
                    Id = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Appointment, global::LightSwitchApplication.Appointment.DetailsClass, int>.Entry(
                        "Id",
                        global::LightSwitchApplication.Appointment.DetailsClass.PropertySetProperties._Id_Stub,
                        global::LightSwitchApplication.Appointment.DetailsClass.PropertySetProperties._Id_ComputeIsReadOnly,
                        global::LightSwitchApplication.Appointment.DetailsClass.PropertySetProperties._Id_Validate,
                        global::LightSwitchApplication.Appointment.DetailsClass.PropertySetProperties._Id_GetImplementationValue,
                        global::LightSwitchApplication.Appointment.DetailsClass.PropertySetProperties._Id_SetImplementationValue,
                        global::LightSwitchApplication.Appointment.DetailsClass.PropertySetProperties._Id_OnValueChanged);
                private static void _Id_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Appointment.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Appointment, global::LightSwitchApplication.Appointment.DetailsClass, int>.Data> c, global::LightSwitchApplication.Appointment.DetailsClass d, object sf)
                {
                    c(d, ref d._Id, sf);
                }
                private static bool _Id_ComputeIsReadOnly(global::LightSwitchApplication.Appointment e)
                {
                    bool result = false;
                    e.Id_IsReadOnly(ref result);
                    return result;
                }
                private static void _Id_Validate(global::LightSwitchApplication.Appointment e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Id_Validate(r);
                }
                private static int _Id_GetImplementationValue(global::LightSwitchApplication.Appointment.DetailsClass d)
                {
                    return d.ImplementationEntity.Id;
                }
                private static void _Id_SetImplementationValue(global::LightSwitchApplication.Appointment.DetailsClass d, int v)
                {
                    d.ImplementationEntity.Id = v;
                }
                private static void _Id_OnValueChanged(global::LightSwitchApplication.Appointment e)
                {
                    e.Id_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Appointment, global::LightSwitchApplication.Appointment.DetailsClass, global::System.DateTime>.Entry
                    AppointmentTime = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Appointment, global::LightSwitchApplication.Appointment.DetailsClass, global::System.DateTime>.Entry(
                        "AppointmentTime",
                        global::LightSwitchApplication.Appointment.DetailsClass.PropertySetProperties._AppointmentTime_Stub,
                        global::LightSwitchApplication.Appointment.DetailsClass.PropertySetProperties._AppointmentTime_ComputeIsReadOnly,
                        global::LightSwitchApplication.Appointment.DetailsClass.PropertySetProperties._AppointmentTime_Validate,
                        global::LightSwitchApplication.Appointment.DetailsClass.PropertySetProperties._AppointmentTime_GetImplementationValue,
                        global::LightSwitchApplication.Appointment.DetailsClass.PropertySetProperties._AppointmentTime_SetImplementationValue,
                        global::LightSwitchApplication.Appointment.DetailsClass.PropertySetProperties._AppointmentTime_OnValueChanged);
                private static void _AppointmentTime_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Appointment.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Appointment, global::LightSwitchApplication.Appointment.DetailsClass, global::System.DateTime>.Data> c, global::LightSwitchApplication.Appointment.DetailsClass d, object sf)
                {
                    c(d, ref d._AppointmentTime, sf);
                }
                private static bool _AppointmentTime_ComputeIsReadOnly(global::LightSwitchApplication.Appointment e)
                {
                    bool result = false;
                    e.AppointmentTime_IsReadOnly(ref result);
                    return result;
                }
                private static void _AppointmentTime_Validate(global::LightSwitchApplication.Appointment e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.AppointmentTime_Validate(r);
                }
                private static global::System.DateTime _AppointmentTime_GetImplementationValue(global::LightSwitchApplication.Appointment.DetailsClass d)
                {
                    return d.ImplementationEntity.AppointmentTime;
                }
                private static void _AppointmentTime_SetImplementationValue(global::LightSwitchApplication.Appointment.DetailsClass d, global::System.DateTime v)
                {
                    d.ImplementationEntity.AppointmentTime = global::LightSwitchApplication.Appointment.DetailsClass.ClearDateTimeKind(v);
                }
                private static void _AppointmentTime_OnValueChanged(global::LightSwitchApplication.Appointment e)
                {
                    e.AppointmentTime_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Appointment, global::LightSwitchApplication.Appointment.DetailsClass, short>.Entry
                    AppointmentType = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Appointment, global::LightSwitchApplication.Appointment.DetailsClass, short>.Entry(
                        "AppointmentType",
                        global::LightSwitchApplication.Appointment.DetailsClass.PropertySetProperties._AppointmentType_Stub,
                        global::LightSwitchApplication.Appointment.DetailsClass.PropertySetProperties._AppointmentType_ComputeIsReadOnly,
                        global::LightSwitchApplication.Appointment.DetailsClass.PropertySetProperties._AppointmentType_Validate,
                        global::LightSwitchApplication.Appointment.DetailsClass.PropertySetProperties._AppointmentType_GetImplementationValue,
                        global::LightSwitchApplication.Appointment.DetailsClass.PropertySetProperties._AppointmentType_SetImplementationValue,
                        global::LightSwitchApplication.Appointment.DetailsClass.PropertySetProperties._AppointmentType_OnValueChanged);
                private static void _AppointmentType_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Appointment.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Appointment, global::LightSwitchApplication.Appointment.DetailsClass, short>.Data> c, global::LightSwitchApplication.Appointment.DetailsClass d, object sf)
                {
                    c(d, ref d._AppointmentType, sf);
                }
                private static bool _AppointmentType_ComputeIsReadOnly(global::LightSwitchApplication.Appointment e)
                {
                    bool result = false;
                    e.AppointmentType_IsReadOnly(ref result);
                    return result;
                }
                private static void _AppointmentType_Validate(global::LightSwitchApplication.Appointment e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.AppointmentType_Validate(r);
                }
                private static short _AppointmentType_GetImplementationValue(global::LightSwitchApplication.Appointment.DetailsClass d)
                {
                    return d.ImplementationEntity.AppointmentType;
                }
                private static void _AppointmentType_SetImplementationValue(global::LightSwitchApplication.Appointment.DetailsClass d, short v)
                {
                    d.ImplementationEntity.AppointmentType = v;
                }
                private static void _AppointmentType_OnValueChanged(global::LightSwitchApplication.Appointment e)
                {
                    e.AppointmentType_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Appointment, global::LightSwitchApplication.Appointment.DetailsClass, string>.Entry
                    DoctorNotes = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Appointment, global::LightSwitchApplication.Appointment.DetailsClass, string>.Entry(
                        "DoctorNotes",
                        global::LightSwitchApplication.Appointment.DetailsClass.PropertySetProperties._DoctorNotes_Stub,
                        global::LightSwitchApplication.Appointment.DetailsClass.PropertySetProperties._DoctorNotes_ComputeIsReadOnly,
                        global::LightSwitchApplication.Appointment.DetailsClass.PropertySetProperties._DoctorNotes_Validate,
                        global::LightSwitchApplication.Appointment.DetailsClass.PropertySetProperties._DoctorNotes_GetImplementationValue,
                        global::LightSwitchApplication.Appointment.DetailsClass.PropertySetProperties._DoctorNotes_SetImplementationValue,
                        global::LightSwitchApplication.Appointment.DetailsClass.PropertySetProperties._DoctorNotes_OnValueChanged);
                private static void _DoctorNotes_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Appointment.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Appointment, global::LightSwitchApplication.Appointment.DetailsClass, string>.Data> c, global::LightSwitchApplication.Appointment.DetailsClass d, object sf)
                {
                    c(d, ref d._DoctorNotes, sf);
                }
                private static bool _DoctorNotes_ComputeIsReadOnly(global::LightSwitchApplication.Appointment e)
                {
                    bool result = false;
                    e.DoctorNotes_IsReadOnly(ref result);
                    return result;
                }
                private static void _DoctorNotes_Validate(global::LightSwitchApplication.Appointment e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.DoctorNotes_Validate(r);
                }
                private static string _DoctorNotes_GetImplementationValue(global::LightSwitchApplication.Appointment.DetailsClass d)
                {
                    return d.ImplementationEntity.DoctorNotes;
                }
                private static void _DoctorNotes_SetImplementationValue(global::LightSwitchApplication.Appointment.DetailsClass d, string v)
                {
                    d.ImplementationEntity.DoctorNotes = v;
                }
                private static void _DoctorNotes_OnValueChanged(global::LightSwitchApplication.Appointment e)
                {
                    e.DoctorNotes_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.Appointment, global::LightSwitchApplication.Appointment.DetailsClass, global::LightSwitchApplication.Patient>.Entry
                    Patient = new global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.Appointment, global::LightSwitchApplication.Appointment.DetailsClass, global::LightSwitchApplication.Patient>.Entry(
                        "Patient",
                        global::LightSwitchApplication.Appointment.DetailsClass.PropertySetProperties._Patient_Stub,
                        global::LightSwitchApplication.Appointment.DetailsClass.PropertySetProperties._Patient_ComputeIsReadOnly,
                        global::LightSwitchApplication.Appointment.DetailsClass.PropertySetProperties._Patient_Validate,
                        global::LightSwitchApplication.Appointment.DetailsClass.PropertySetProperties._Patient_GetCoreImplementationValue,
                        global::LightSwitchApplication.Appointment.DetailsClass.PropertySetProperties._Patient_GetImplementationValue,
                        global::LightSwitchApplication.Appointment.DetailsClass.PropertySetProperties._Patient_SetImplementationValue,
                        global::LightSwitchApplication.Appointment.DetailsClass.PropertySetProperties._Patient_Refresh,
                        global::LightSwitchApplication.Appointment.DetailsClass.PropertySetProperties._Patient_OnValueChanged);
                private static void _Patient_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Appointment.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.Appointment, global::LightSwitchApplication.Appointment.DetailsClass, global::LightSwitchApplication.Patient>.Data> c, global::LightSwitchApplication.Appointment.DetailsClass d, object sf)
                {
                    c(d, ref d._Patient, sf);
                }
                private static bool _Patient_ComputeIsReadOnly(global::LightSwitchApplication.Appointment e)
                {
                    bool result = false;
                    e.Patient_IsReadOnly(ref result);
                    return result;
                }
                private static void _Patient_Validate(global::LightSwitchApplication.Appointment e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Patient_Validate(r);
                }
                private static global::Microsoft.LightSwitch.Internal.IEntityImplementation _Patient_GetCoreImplementationValue(global::LightSwitchApplication.Appointment.DetailsClass d)
                {
                    return d.ImplementationEntity.Patient;
                }
                private static global::LightSwitchApplication.Patient _Patient_GetImplementationValue(global::LightSwitchApplication.Appointment.DetailsClass d)
                {
                    return d.GetImplementationValue<global::LightSwitchApplication.Patient, global::LightSwitchApplication.Patient.DetailsClass>(global::LightSwitchApplication.Appointment.DetailsClass.PropertySetProperties.Patient, ref d._Patient);
                }
                private static void _Patient_SetImplementationValue(global::LightSwitchApplication.Appointment.DetailsClass d, global::LightSwitchApplication.Patient v)
                {
                    d.SetImplementationValue(global::LightSwitchApplication.Appointment.DetailsClass.PropertySetProperties.Patient, ref d._Patient, (i, ev) => i.Patient = ev, v);
                }
                private static void _Patient_Refresh(global::LightSwitchApplication.Appointment.DetailsClass d)
                {
                    d.RefreshNavigationProperty(global::LightSwitchApplication.Appointment.DetailsClass.PropertySetProperties.Patient, ref d._Patient);
                }
                private static void _Patient_OnValueChanged(global::LightSwitchApplication.Appointment e)
                {
                    e.Patient_Changed();
                }
    
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Appointment, global::LightSwitchApplication.Appointment.DetailsClass, int>.Data _Id;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Appointment, global::LightSwitchApplication.Appointment.DetailsClass, global::System.DateTime>.Data _AppointmentTime;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Appointment, global::LightSwitchApplication.Appointment.DetailsClass, short>.Data _AppointmentType;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Appointment, global::LightSwitchApplication.Appointment.DetailsClass, string>.Data _DoctorNotes;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty<global::LightSwitchApplication.Appointment, global::LightSwitchApplication.Appointment.DetailsClass, global::LightSwitchApplication.Patient>.Data _Patient;
            
        }
    
        #endregion
    }
    
    #endregion
}
