﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("ChooseDefaultPrinter.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Checkmark_16x() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Checkmark_16x", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to MIT License
        '''
        '''Copyright (c) 2017 Luke Barone
        '''
        '''Permission is hereby granted, free of charge, to any person obtaining a copy
        '''of this software and associated documentation files (the &quot;Software&quot;), to deal
        '''in the Software without restriction, including without limitation the rights
        '''to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
        '''copies of the Software, and to permit persons to whom the Software is
        '''furnished to do so, subject to the following conditions:
        '''
        '''The above copyright no [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property LICENSE() As String
            Get
                Return ResourceManager.GetString("LICENSE", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property PrintStatusBar1_16x() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("PrintStatusBar1_16x", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Question_16x() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Question_16x", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Default Printer README
        '''======================
        '''
        '''(C) 2017 by Luke Barone. Licensed under MIT License (see end)
        '''
        '''I - Introduction
        '''----------------
        '''
        '''I wrote this program for new systems running Windows 10, and having many printers installed. I am hoping that it is an easier way to choose your default printer, as opposed to the new PC Settings method, or letting Windows 10 choose for you. This has been known to be buggy in certain instances. If this is not the easy way of choosing a default printer, then [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property README() As String
            Get
                Return ResourceManager.GetString("README", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Refresh_16x() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Refresh_16x", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
    End Module
End Namespace
