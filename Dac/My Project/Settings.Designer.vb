﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.1008
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "Funcionalidad para autoguardar de My.Settings"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(ByVal sender As Global.System.Object, ByVal e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Etiquetas\Interface\Interface\bin"& _ 
            "\Debug\BaseEtiquetas.mdb")>  _
        Public ReadOnly Property BaseEtiquetasConnectionString() As String
            Get
                Return CType(Me("BaseEtiquetasConnectionString"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\BaseEtiquetas.mdb")>  _
        Public ReadOnly Property BaseEtiquetasConnectionString1() As String
            Get
                Return CType(Me("BaseEtiquetasConnectionString1"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=""C:\Documents and Settings\Administr"& _ 
            "ador\Escritorio\Etiquetas\Interface\Interface\bin\Debug\BaseEtiquetas.mdb""")>  _
        Public ReadOnly Property BaseEtiquetasConnectionString2() As String
            Get
                Return CType(Me("BaseEtiquetasConnectionString2"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=""C:\Documents and Settings\Administr"& _ 
            "ador\Escritorio\Etiquetas\Etiquetas\Interface\Interface\bin\Debug\BaseEtiquetas."& _ 
            "mdb""")>  _
        Public ReadOnly Property BaseEtiquetasConnectionString3() As String
            Get
                Return CType(Me("BaseEtiquetasConnectionString3"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=""C:\Documents and Settings\Administr"& _ 
            "ador\Escritorio\Etiquetas\Etiquetas\Etiquetas\Interface\Interface\bin\Debug\Base"& _ 
            "Etiquetas.mdb""")>  _
        Public ReadOnly Property BaseEtiquetasConnectionString4() As String
            Get
                Return CType(Me("BaseEtiquetasConnectionString4"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\DsCaja.mdf;Integrated S"& _ 
            "ecurity=True;User Instance=True")>  _
        Public ReadOnly Property DsCajaConnectionString() As String
            Get
                Return CType(Me("DsCajaConnectionString"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=""C:\Documents and Settings\Administr"& _ 
            "ador\Escritorio\Martin\Programacion\Etiquetas\Etiquetas\Etiquetas\Interface\Inte"& _ 
            "rface\bin\Debug\BaseEtiquetas.mdb""")>  _
        Public ReadOnly Property BaseEtiquetasConnectionString5() As String
            Get
                Return CType(Me("BaseEtiquetasConnectionString5"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\Servidordb\FRIGO\Produccion.mdb")>  _
        Public ReadOnly Property ProduccionConnectionString() As String
            Get
                Return CType(Me("ProduccionConnectionString"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\AUXILIAR.MDB")>  _
        Public ReadOnly Property AUXILIARConnectionString() As String
            Get
                Return CType(Me("AUXILIARConnectionString"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=""\\servidordb\Sistemas\BaseAuxChrono"& _ 
            "s.mdb""")>  _
        Public ReadOnly Property BaseAuxChronosConnectionString() As String
            Get
                Return CType(Me("BaseAuxChronosConnectionString"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\servidordb\FRIGO\Personal.mdb")>  _
        Public ReadOnly Property PersonalConnectionString() As String
            Get
                Return CType(Me("PersonalConnectionString"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=""\\servidordb\Sistemas\BaseEtiquetas"& _ 
            ".mdb""")>  _
        Public ReadOnly Property BaseEtiquetasConnectionString6() As String
            Get
                Return CType(Me("BaseEtiquetasConnectionString6"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=F:\Martin\Programacion\Etiquetas\Eti"& _ 
            "quetas\Etiquetas\Interface\Interface\bin\Debug\caravanas.mdb")>  _
        Public ReadOnly Property caravanasConnectionString() As String
            Get
                Return CType(Me("caravanasConnectionString"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\servidordb\Sistemas\caravanas.mdb")>  _
        Public ReadOnly Property caravanasConnectionString1() As String
            Get
                Return CType(Me("caravanasConnectionString1"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Martin\Documents\Martin\Fri"& _ 
            "goYi\Interface\Interface\bin\Debug\BaseEtiquetas.mdb")>  _
        Public ReadOnly Property BaseEtiquetasConnectionString7() As String
            Get
                Return CType(Me("BaseEtiquetasConnectionString7"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Traza\Traza_Uru_Data.mdf;Integrated "& _ 
            "Security=True;Connect Timeout=30;User Instance=True")>  _
        Public ReadOnly Property Traza_Uru_DataConnectionString() As String
            Get
                Return CType(Me("Traza_Uru_DataConnectionString"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=""C:\Users\Martin\Documents\Martin\Si"& _ 
            "stema Trazabilidad\Trazabilidad\Interface\Interface\bin\x86\Debug\TrazaUru.mdb""")>  _
        Public ReadOnly Property TrazaUruConnectionString() As String
            Get
                Return CType(Me("TrazaUruConnectionString"),String)
            End Get
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.Dac.My.MySettings
            Get
                Return Global.Dac.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
