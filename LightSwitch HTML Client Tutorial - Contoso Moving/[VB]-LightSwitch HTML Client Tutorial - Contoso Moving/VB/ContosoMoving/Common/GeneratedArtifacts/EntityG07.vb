﻿
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports __InventoryItem = LightSwitchApplication.InventoryItem

Namespace LightSwitchApplication

    #Region "Entities"
    
    ''' <summary>
    ''' No Modeled Description Available
    ''' </summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
    Public NotInheritable Partial Class InventoryItem
        Inherits Global.Microsoft.LightSwitch.Framework.Base.EntityObject(Of __InventoryItem, __InventoryItem.DetailsClass)
    
        #Region "Constructors"
    
        ''' <summary>
        ''' Initializes a new instance of the InventoryItem entity.
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Sub New()
            Me.New(Nothing)
        End Sub
    
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Sub New(entitySet As Global.Microsoft.LightSwitch.Framework.EntitySet(Of __InventoryItem))
            MyBase.New(entitySet)
            
            __InventoryItem.DetailsClass.Initialize(Me)
        End Sub
    
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub InventoryItem_Created()
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub InventoryItem_AllowSaveWithErrors(ByRef result As Boolean)
        End Sub
    
        #End Region
    
        #Region "Private Properties"
        
        ''' <summary>
        ''' Gets the Application object for this application.  The Application object provides access to active screens, methods to open screens and access to the current user.
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Private ReadOnly Property Application As Global.Microsoft.LightSwitch.IApplication(Of Global.LightSwitchApplication.DataWorkspace)
            Get
                Return Global.LightSwitchApplication.Application.Current
            End Get
        End Property
        
        ''' <summary>
        ''' Gets the containing data workspace.  The data workspace provides access to all data sources in the application.
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Private ReadOnly Property DataWorkspace As Global.LightSwitchApplication.DataWorkspace
            Get
                Return DirectCast(Me.Details.EntitySet.Details.DataService.Details.DataWorkspace, Global.LightSwitchApplication.DataWorkspace)
            End Get
        End Property
        
        #End Region
    
        #Region "Public Properties"
    
        ''' <summary>
        ''' No Modeled Description Available
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Property Id As Integer
            Get
                Return __InventoryItem.DetailsClass.GetValue(Me, __InventoryItem.DetailsClass.PropertySetProperties.Id)
            End Get
            Set
                __InventoryItem.DetailsClass.SetValue(Me, __InventoryItem.DetailsClass.PropertySetProperties.Id, Value)
            End Set
        End Property
        
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Id_IsReadOnly(ByRef result As Boolean)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Id_Validate(ByVal results As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Id_Changed()
        End Sub

        ''' <summary>
        ''' No Modeled Description Available
        ''' </summary>
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Property RowVersion As Byte()
            Get
                Return __InventoryItem.DetailsClass.GetValue(Me, __InventoryItem.DetailsClass.PropertySetProperties.RowVersion)
            End Get
            Set
                __InventoryItem.DetailsClass.SetValue(Me, __InventoryItem.DetailsClass.PropertySetProperties.RowVersion, Value)
            End Set
        End Property
        
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub RowVersion_IsReadOnly(ByRef result As Boolean)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub RowVersion_Validate(ByVal results As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub RowVersion_Changed()
        End Sub

        ''' <summary>
        ''' No Modeled Description Available
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Property Name As String
            Get
                Return __InventoryItem.DetailsClass.GetValue(Me, __InventoryItem.DetailsClass.PropertySetProperties.Name)
            End Get
            Set
                __InventoryItem.DetailsClass.SetValue(Me, __InventoryItem.DetailsClass.PropertySetProperties.Name, Value)
            End Set
        End Property
        
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Name_IsReadOnly(ByRef result As Boolean)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Name_Validate(ByVal results As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Name_Changed()
        End Sub

        ''' <summary>
        ''' No Modeled Description Available
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Property Quantity As Integer
            Get
                Return __InventoryItem.DetailsClass.GetValue(Me, __InventoryItem.DetailsClass.PropertySetProperties.Quantity)
            End Get
            Set
                __InventoryItem.DetailsClass.SetValue(Me, __InventoryItem.DetailsClass.PropertySetProperties.Quantity, Value)
            End Set
        End Property
        
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Quantity_IsReadOnly(ByRef result As Boolean)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Quantity_Validate(ByVal results As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Quantity_Changed()
        End Sub

        ''' <summary>
        ''' No Modeled Description Available
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Property Room As Global.LightSwitchApplication.Room
            Get
                Return __InventoryItem.DetailsClass.GetValue(Me, __InventoryItem.DetailsClass.PropertySetProperties.Room)
            End Get
            Set
                __InventoryItem.DetailsClass.SetValue(Me, __InventoryItem.DetailsClass.PropertySetProperties.Room, Value)
            End Set
        End Property
        
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Room_IsReadOnly(ByRef result As Boolean)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Room_Validate(ByVal results As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Room_Changed()
        End Sub

        #End Region
    
        #Region "Details Class"
    
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")> _
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public NotInheritable Class DetailsClass
            Inherits Global.Microsoft.LightSwitch.Details.Framework.Base.EntityDetails(Of _
                __InventoryItem, _
                __InventoryItem.DetailsClass, _
                __InventoryItem.DetailsClass.IImplementation, _
                __InventoryItem.DetailsClass.PropertySet, _
                Global.Microsoft.LightSwitch.Details.Framework.EntityCommandSet(Of __InventoryItem, __InventoryItem.DetailsClass), _
                Global.Microsoft.LightSwitch.Details.Framework.EntityMethodSet(Of __InventoryItem, __InventoryItem.DetailsClass))
    
            Shared Sub New()
                Dim initializeEntry = __InventoryItem.DetailsClass.PropertySetProperties.Id
            End Sub
    
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private Shared ReadOnly __InventoryItemEntry As Global.Microsoft.LightSwitch.Details.Framework.Base.EntityDetails(Of __InventoryItem, __InventoryItem.DetailsClass).Entry = _
                New Global.Microsoft.LightSwitch.Details.Framework.Base.EntityDetails(Of __InventoryItem, __InventoryItem.DetailsClass).Entry( _
                    AddressOf __InventoryItem.DetailsClass.__InventoryItem_CreateNew, _
                    AddressOf __InventoryItem.DetailsClass.__InventoryItem_Created, _
                    AddressOf __InventoryItem.DetailsClass.__InventoryItem_AllowSaveWithErrors)
            Private Shared Function __InventoryItem_CreateNew(es As Global.Microsoft.LightSwitch.Framework.EntitySet(Of __InventoryItem)) As __InventoryItem
                Return New __InventoryItem(es)
            End Function
            Private Shared Sub __InventoryItem_Created(e As __InventoryItem)
                e.InventoryItem_Created()
            End Sub
            Private Shared Function __InventoryItem_AllowSaveWithErrors(e As __InventoryItem) As Boolean
                Dim result As Boolean = False
                e.InventoryItem_AllowSaveWithErrors(result)
                Return result
            End Function
    
            Public Sub New()
                MyBase.New()
            End Sub
    
            Public ReadOnly Shadows Property Commands As Global.Microsoft.LightSwitch.Details.Framework.EntityCommandSet(Of __InventoryItem, __InventoryItem.DetailsClass)
                Get
                    Return MyBase.Commands
                End Get
            End Property
    
            Public ReadOnly Shadows Property Methods As Global.Microsoft.LightSwitch.Details.Framework.EntityMethodSet(Of __InventoryItem, __InventoryItem.DetailsClass)
                Get
                    Return MyBase.Methods
                End Get
            End Property
    
            Public ReadOnly Shadows Property Properties As __InventoryItem.DetailsClass.PropertySet
                Get
                    Return MyBase.Properties
                End Get
            End Property
    
            <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
            <Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")> _
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
            <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            Public NotInheritable Class PropertySet
                Inherits Global.Microsoft.LightSwitch.Details.Framework.Base.EntityPropertySet(Of __InventoryItem, __InventoryItem.DetailsClass)
    
                Public Sub New()
                    MyBase.New()
                End Sub
    
                Public ReadOnly Property Id As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __InventoryItem, __InventoryItem.DetailsClass, Integer)
                    Get
                        Return TryCast(
                            MyBase.GetItem(__InventoryItem.DetailsClass.PropertySetProperties.Id),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __InventoryItem, __InventoryItem.DetailsClass, Integer))
                    End Get
                End Property
                
                Public ReadOnly Property RowVersion As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __InventoryItem, __InventoryItem.DetailsClass, Byte())
                    Get
                        Return TryCast(
                            MyBase.GetItem(__InventoryItem.DetailsClass.PropertySetProperties.RowVersion),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __InventoryItem, __InventoryItem.DetailsClass, Byte()))
                    End Get
                End Property
                
                Public ReadOnly Property Name As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __InventoryItem, __InventoryItem.DetailsClass, String)
                    Get
                        Return TryCast(
                            MyBase.GetItem(__InventoryItem.DetailsClass.PropertySetProperties.Name),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __InventoryItem, __InventoryItem.DetailsClass, String))
                    End Get
                End Property
                
                Public ReadOnly Property Quantity As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __InventoryItem, __InventoryItem.DetailsClass, Integer)
                    Get
                        Return TryCast(
                            MyBase.GetItem(__InventoryItem.DetailsClass.PropertySetProperties.Quantity),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __InventoryItem, __InventoryItem.DetailsClass, Integer))
                    End Get
                End Property
                
                Public ReadOnly Property Room As Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __InventoryItem, __InventoryItem.DetailsClass, Global.LightSwitchApplication.Room)
                    Get
                        Return TryCast(
                            MyBase.GetItem(__InventoryItem.DetailsClass.PropertySetProperties.Room),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __InventoryItem, __InventoryItem.DetailsClass, Global.LightSwitchApplication.Room))
                    End Get
                End Property
                
            End Class
    
            <Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")> _
            Public Interface IImplementation
                Inherits Global.Microsoft.LightSwitch.Internal.IEntityImplementation
    
                Shadows Property Id As Integer
                Shadows Property RowVersion As Byte()
                Shadows Property Name As String
                Shadows Property Quantity As Integer
                Shadows Property Room As Global.Microsoft.LightSwitch.Internal.IEntityImplementation
    
            End Interface
    
            <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
            <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            Friend Class PropertySetProperties
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly Id As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __InventoryItem, __InventoryItem.DetailsClass, Integer).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __InventoryItem, __InventoryItem.DetailsClass, Integer).Entry( _
                        "Id", _
                        AddressOf __InventoryItem.DetailsClass.PropertySetProperties._Id_Stub, _
                        AddressOf __InventoryItem.DetailsClass.PropertySetProperties._Id_ComputeIsReadOnly, _
                        AddressOf __InventoryItem.DetailsClass.PropertySetProperties._Id_Validate, _
                        AddressOf __InventoryItem.DetailsClass.PropertySetProperties._Id_GetImplementationValue, _
                        AddressOf __InventoryItem.DetailsClass.PropertySetProperties._Id_SetImplementationValue, _
                        AddressOf __InventoryItem.DetailsClass.PropertySetProperties._Id_OnValueChanged)
                Private Shared Sub _Id_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __InventoryItem.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __InventoryItem, __InventoryItem.DetailsClass, Integer).Data), d As __InventoryItem.DetailsClass, sf As Object)
                    c(d, d._Id, sf)
                End Sub
                Private Shared Function _Id_ComputeIsReadOnly(e As __InventoryItem) As Boolean
                    Dim result As Boolean = False
                    e.Id_IsReadOnly(result)
                    Return result
                End Function
                Private Shared Sub _Id_Validate(e As __InventoryItem, r As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
                    e.Id_Validate(r)
                End Sub
                Private Shared Function _Id_GetImplementationValue(d As __InventoryItem.DetailsClass) As Integer
                    Return d.ImplementationEntity.Id
                End Function
                Private Shared Sub _Id_SetImplementationValue(d As __InventoryItem.DetailsClass, v As Integer)
                    d.ImplementationEntity.Id = v
                End Sub
                Private Shared Sub _Id_OnValueChanged(e As __InventoryItem)
                    e.Id_Changed()
                End Sub
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly RowVersion As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __InventoryItem, __InventoryItem.DetailsClass, Byte()).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __InventoryItem, __InventoryItem.DetailsClass, Byte()).Entry( _
                        "RowVersion", _
                        AddressOf __InventoryItem.DetailsClass.PropertySetProperties._RowVersion_Stub, _
                        AddressOf __InventoryItem.DetailsClass.PropertySetProperties._RowVersion_ComputeIsReadOnly, _
                        AddressOf __InventoryItem.DetailsClass.PropertySetProperties._RowVersion_Validate, _
                        AddressOf __InventoryItem.DetailsClass.PropertySetProperties._RowVersion_GetImplementationValue, _
                        AddressOf __InventoryItem.DetailsClass.PropertySetProperties._RowVersion_SetImplementationValue, _
                        AddressOf __InventoryItem.DetailsClass.PropertySetProperties._RowVersion_OnValueChanged)
                Private Shared Sub _RowVersion_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __InventoryItem.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __InventoryItem, __InventoryItem.DetailsClass, Byte()).Data), d As __InventoryItem.DetailsClass, sf As Object)
                    c(d, d._RowVersion, sf)
                End Sub
                Private Shared Function _RowVersion_ComputeIsReadOnly(e As __InventoryItem) As Boolean
                    Dim result As Boolean = False
                    e.RowVersion_IsReadOnly(result)
                    Return result
                End Function
                Private Shared Sub _RowVersion_Validate(e As __InventoryItem, r As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
                    e.RowVersion_Validate(r)
                End Sub
                Private Shared Function _RowVersion_GetImplementationValue(d As __InventoryItem.DetailsClass) As Byte()
                    Return d.ImplementationEntity.RowVersion
                End Function
                Private Shared Sub _RowVersion_SetImplementationValue(d As __InventoryItem.DetailsClass, v As Byte())
                    d.ImplementationEntity.RowVersion = v
                End Sub
                Private Shared Sub _RowVersion_OnValueChanged(e As __InventoryItem)
                    e.RowVersion_Changed()
                End Sub
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly Name As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __InventoryItem, __InventoryItem.DetailsClass, String).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __InventoryItem, __InventoryItem.DetailsClass, String).Entry( _
                        "Name", _
                        AddressOf __InventoryItem.DetailsClass.PropertySetProperties._Name_Stub, _
                        AddressOf __InventoryItem.DetailsClass.PropertySetProperties._Name_ComputeIsReadOnly, _
                        AddressOf __InventoryItem.DetailsClass.PropertySetProperties._Name_Validate, _
                        AddressOf __InventoryItem.DetailsClass.PropertySetProperties._Name_GetImplementationValue, _
                        AddressOf __InventoryItem.DetailsClass.PropertySetProperties._Name_SetImplementationValue, _
                        AddressOf __InventoryItem.DetailsClass.PropertySetProperties._Name_OnValueChanged)
                Private Shared Sub _Name_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __InventoryItem.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __InventoryItem, __InventoryItem.DetailsClass, String).Data), d As __InventoryItem.DetailsClass, sf As Object)
                    c(d, d._Name, sf)
                End Sub
                Private Shared Function _Name_ComputeIsReadOnly(e As __InventoryItem) As Boolean
                    Dim result As Boolean = False
                    e.Name_IsReadOnly(result)
                    Return result
                End Function
                Private Shared Sub _Name_Validate(e As __InventoryItem, r As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
                    e.Name_Validate(r)
                End Sub
                Private Shared Function _Name_GetImplementationValue(d As __InventoryItem.DetailsClass) As String
                    Return d.ImplementationEntity.Name
                End Function
                Private Shared Sub _Name_SetImplementationValue(d As __InventoryItem.DetailsClass, v As String)
                    d.ImplementationEntity.Name = v
                End Sub
                Private Shared Sub _Name_OnValueChanged(e As __InventoryItem)
                    e.Name_Changed()
                End Sub
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly Quantity As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __InventoryItem, __InventoryItem.DetailsClass, Integer).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __InventoryItem, __InventoryItem.DetailsClass, Integer).Entry( _
                        "Quantity", _
                        AddressOf __InventoryItem.DetailsClass.PropertySetProperties._Quantity_Stub, _
                        AddressOf __InventoryItem.DetailsClass.PropertySetProperties._Quantity_ComputeIsReadOnly, _
                        AddressOf __InventoryItem.DetailsClass.PropertySetProperties._Quantity_Validate, _
                        AddressOf __InventoryItem.DetailsClass.PropertySetProperties._Quantity_GetImplementationValue, _
                        AddressOf __InventoryItem.DetailsClass.PropertySetProperties._Quantity_SetImplementationValue, _
                        AddressOf __InventoryItem.DetailsClass.PropertySetProperties._Quantity_OnValueChanged)
                Private Shared Sub _Quantity_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __InventoryItem.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __InventoryItem, __InventoryItem.DetailsClass, Integer).Data), d As __InventoryItem.DetailsClass, sf As Object)
                    c(d, d._Quantity, sf)
                End Sub
                Private Shared Function _Quantity_ComputeIsReadOnly(e As __InventoryItem) As Boolean
                    Dim result As Boolean = False
                    e.Quantity_IsReadOnly(result)
                    Return result
                End Function
                Private Shared Sub _Quantity_Validate(e As __InventoryItem, r As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
                    e.Quantity_Validate(r)
                End Sub
                Private Shared Function _Quantity_GetImplementationValue(d As __InventoryItem.DetailsClass) As Integer
                    Return d.ImplementationEntity.Quantity
                End Function
                Private Shared Sub _Quantity_SetImplementationValue(d As __InventoryItem.DetailsClass, v As Integer)
                    d.ImplementationEntity.Quantity = v
                End Sub
                Private Shared Sub _Quantity_OnValueChanged(e As __InventoryItem)
                    e.Quantity_Changed()
                End Sub
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly Room As Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __InventoryItem, __InventoryItem.DetailsClass, Global.LightSwitchApplication.Room).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __InventoryItem, __InventoryItem.DetailsClass, Global.LightSwitchApplication.Room).Entry( _
                        "Room", _
                        AddressOf __InventoryItem.DetailsClass.PropertySetProperties._Room_Stub, _
                        AddressOf __InventoryItem.DetailsClass.PropertySetProperties._Room_ComputeIsReadOnly, _
                        AddressOf __InventoryItem.DetailsClass.PropertySetProperties._Room_Validate, _
                        AddressOf __InventoryItem.DetailsClass.PropertySetProperties._Room_GetCoreImplementationValue, _
                        AddressOf __InventoryItem.DetailsClass.PropertySetProperties._Room_GetImplementationValue, _
                        AddressOf __InventoryItem.DetailsClass.PropertySetProperties._Room_SetImplementationValue, _
                        AddressOf __InventoryItem.DetailsClass.PropertySetProperties._Room_Refresh, _
                        AddressOf __InventoryItem.DetailsClass.PropertySetProperties._Room_OnValueChanged)
                Private Shared Sub _Room_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __InventoryItem.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __InventoryItem, __InventoryItem.DetailsClass, Global.LightSwitchApplication.Room).Data), d As __InventoryItem.DetailsClass, sf As Object)
                    c(d, d._Room, sf)
                End Sub
                Private Shared Function _Room_ComputeIsReadOnly(e As __InventoryItem) As Boolean
                    Dim result As Boolean = False
                    e.Room_IsReadOnly(result)
                    Return result
                End Function
                Private Shared Sub _Room_Validate(e As __InventoryItem, r As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
                    e.Room_Validate(r)
                End Sub
                Private Shared Function _Room_GetCoreImplementationValue(d as __InventoryItem.DetailsClass) As Global.Microsoft.LightSwitch.Internal.IEntityImplementation
                    Return d.ImplementationEntity.Room
                End Function
                Private Shared Function _Room_GetImplementationValue(d as __InventoryItem.DetailsClass) As Global.LightSwitchApplication.Room
                    Return d.GetImplementationValue(Of Global.LightSwitchApplication.Room, Global.LightSwitchApplication.Room.DetailsClass)(__InventoryItem.DetailsClass.PropertySetProperties.Room, d._Room)
                End Function
                Private Shared Sub _Room_SetImplementationValue(d As __InventoryItem.DetailsClass, v As Global.LightSwitchApplication.Room)
                    d.SetImplementationValue(__InventoryItem.DetailsClass.PropertySetProperties.Room, d._Room, Sub(i, ev) i.Room = ev, v)
                End Sub
                Private Shared Sub _Room_Refresh(d As __InventoryItem.DetailsClass)
                    d.RefreshNavigationProperty(__InventoryItem.DetailsClass.PropertySetProperties.Room, d._Room)
                End Sub
                Private Shared Sub _Room_OnValueChanged(e As __InventoryItem)
                    e.Room_Changed()
                End Sub
    
            End Class
    
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _Id As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __InventoryItem, __InventoryItem.DetailsClass, Integer).Data
            
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _RowVersion As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __InventoryItem, __InventoryItem.DetailsClass, Byte()).Data
            
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _Name As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __InventoryItem, __InventoryItem.DetailsClass, String).Data
            
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _Quantity As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __InventoryItem, __InventoryItem.DetailsClass, Integer).Data
            
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _Room As Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __InventoryItem, __InventoryItem.DetailsClass, Global.LightSwitchApplication.Room).Data
            
        End Class
    
        #End Region
    
    End Class
    
    #End Region
End Namespace
