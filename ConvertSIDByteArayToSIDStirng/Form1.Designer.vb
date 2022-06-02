Imports ConvertSIDByteArayToSIDStirng.My

Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms


<DesignerGenerated()>
Partial Public Class Form1
    Inherits Form

    Private components As IContainer

    <AccessedThroughProperty("btnConvert")>
    Private _btnConvert As Button

    <AccessedThroughProperty("lblInputString")>
    Private _lblInputString As Label

    <AccessedThroughProperty("tbInputString")>
    Private _tbInputString As TextBox

    <AccessedThroughProperty("lblRevision")>
    Private _lblRevision As Label

    <AccessedThroughProperty("tbRevision")>
    Private _tbRevision As TextBox

    <AccessedThroughProperty("lblSubIDCount")>
    Private _lblSubIDCount As Label

    <AccessedThroughProperty("tbSubIDCount")>
    Private _tbSubIDCount As TextBox

    <AccessedThroughProperty("lblIdentifierAuthority")>
    Private _lblIdentifierAuthority As Label

    <AccessedThroughProperty("tbIA1")>
    Private _tbIA1 As TextBox

    <AccessedThroughProperty("tbIA2")>
    Private _tbIA2 As TextBox

    <AccessedThroughProperty("tbIA3")>
    Private _tbIA3 As TextBox

    <AccessedThroughProperty("tbIA4")>
    Private _tbIA4 As TextBox

    <AccessedThroughProperty("tbIA5")>
    Private _tbIA5 As TextBox

    <AccessedThroughProperty("tbIA6")>
    Private _tbIA6 As TextBox

    <AccessedThroughProperty("lblSubID1")>
    Private _lblSubID1 As Label

    <AccessedThroughProperty("tb1ID4")>
    Private _tb1ID4 As TextBox

    <AccessedThroughProperty("tb1ID3")>
    Private _tb1ID3 As TextBox

    <AccessedThroughProperty("tb1ID2")>
    Private _tb1ID2 As TextBox

    <AccessedThroughProperty("tb1ID1")>
    Private _tb1ID1 As TextBox

    <AccessedThroughProperty("tb2ID4")>
    Private _tb2ID4 As TextBox

    <AccessedThroughProperty("tb2ID3")>
    Private _tb2ID3 As TextBox

    <AccessedThroughProperty("tb2ID2")>
    Private _tb2ID2 As TextBox

    <AccessedThroughProperty("tb2ID1")>
    Private _tb2ID1 As TextBox

    <AccessedThroughProperty("tb3ID4")>
    Private _tb3ID4 As TextBox

    <AccessedThroughProperty("tb3ID3")>
    Private _tb3ID3 As TextBox

    <AccessedThroughProperty("tb3ID2")>
    Private _tb3ID2 As TextBox

    <AccessedThroughProperty("tb3ID1")>
    Private _tb3ID1 As TextBox

    <AccessedThroughProperty("tb4ID4")>
    Private _tb4ID4 As TextBox

    <AccessedThroughProperty("tb4ID3")>
    Private _tb4ID3 As TextBox

    <AccessedThroughProperty("tb4ID2")>
    Private _tb4ID2 As TextBox

    <AccessedThroughProperty("tb4ID1")>
    Private _tb4ID1 As TextBox

    <AccessedThroughProperty("lblSubID2")>
    Private _lblSubID2 As Label

    <AccessedThroughProperty("SubID3")>
    Private _SubID3 As Label

    <AccessedThroughProperty("lblSubID4")>
    Private _lblSubID4 As Label

    <AccessedThroughProperty("tb5ID1")>
    Private _tb5ID1 As TextBox

    <AccessedThroughProperty("tb5ID2")>
    Private _tb5ID2 As TextBox

    <AccessedThroughProperty("tb5ID3")>
    Private _tb5ID3 As TextBox

    <AccessedThroughProperty("tb5ID4")>
    Private _tb5ID4 As TextBox

    <AccessedThroughProperty("lblSubID5")>
    Private _lblSubID5 As Label

    <AccessedThroughProperty("lblOutput")>
    Private _lblOutput As Label

    <AccessedThroughProperty("tbOutputString")>
    Private _tbOutputString As TextBox

    <AccessedThroughProperty("lblAbout")>
    Private _lblAbout As Label

    <AccessedThroughProperty("lnklblSelfAdsiorg")>
    Private _lnklblSelfAdsiorg As LinkLabel

    <AccessedThroughProperty("lblArrayCount")>
    Private _lblArrayCount As Label

    Friend Overridable Property btnConvert() As Button
        <DebuggerNonUserCode()>
        Get
            Return Me._btnConvert
        End Get
        <DebuggerNonUserCode()>
        <MethodImpl(MethodImplOptions.Synchronized)>
        Set(value As Button)
            Dim value2 As EventHandler = AddressOf Me.btnConvert_Click
            If Me._btnConvert IsNot Nothing Then
                RemoveHandler Me._btnConvert.Click, value2
            End If
            Me._btnConvert = value
            If Me._btnConvert IsNot Nothing Then
                AddHandler Me._btnConvert.Click, value2
            End If
        End Set
    End Property

    Friend Overridable Property lblInputString() As Label
        <DebuggerNonUserCode()>
        Get
            Return Me._lblInputString
        End Get
        <DebuggerNonUserCode()>
        <MethodImpl(MethodImplOptions.Synchronized)>
        Set(value As Label)
            Me._lblInputString = value
        End Set
    End Property

    Friend Overridable Property tbInputString() As TextBox
        <DebuggerNonUserCode()>
        Get
            Return Me._tbInputString
        End Get
        <DebuggerNonUserCode()>
        <MethodImpl(MethodImplOptions.Synchronized)>
        Set(value As TextBox)
            Dim value2 As EventHandler = AddressOf Me.tbInputString_TextChanged
            If Me._tbInputString IsNot Nothing Then
                RemoveHandler Me._tbInputString.TextChanged, value2
            End If
            Me._tbInputString = value
            If Me._tbInputString IsNot Nothing Then
                AddHandler Me._tbInputString.TextChanged, value2
            End If
        End Set
    End Property

    Friend Overridable Property lblRevision() As Label
        <DebuggerNonUserCode()>
        Get
            Return Me._lblRevision
        End Get
        <DebuggerNonUserCode()>
        <MethodImpl(MethodImplOptions.Synchronized)>
        Set(value As Label)
            Me._lblRevision = value
        End Set
    End Property

    Friend Overridable Property tbRevision() As TextBox
        <DebuggerNonUserCode()>
        Get
            Return Me._tbRevision
        End Get
        <DebuggerNonUserCode()>
        <MethodImpl(MethodImplOptions.Synchronized)>
        Set(value As TextBox)
            Me._tbRevision = value
        End Set
    End Property

    Friend Overridable Property lblSubIDCount() As Label
        <DebuggerNonUserCode()>
        Get
            Return Me._lblSubIDCount
        End Get
        <DebuggerNonUserCode()>
        <MethodImpl(MethodImplOptions.Synchronized)>
        Set(value As Label)
            Me._lblSubIDCount = value
        End Set
    End Property

    Friend Overridable Property tbSubIDCount() As TextBox
        <DebuggerNonUserCode()>
        Get
            Return Me._tbSubIDCount
        End Get
        <DebuggerNonUserCode()>
        <MethodImpl(MethodImplOptions.Synchronized)>
        Set(value As TextBox)
            Me._tbSubIDCount = value
        End Set
    End Property

    Friend Overridable Property lblIdentifierAuthority() As Label
        <DebuggerNonUserCode()>
        Get
            Return Me._lblIdentifierAuthority
        End Get
        <DebuggerNonUserCode()>
        <MethodImpl(MethodImplOptions.Synchronized)>
        Set(value As Label)
            Me._lblIdentifierAuthority = value
        End Set
    End Property

    Friend Overridable Property tbIA1() As TextBox
        <DebuggerNonUserCode()>
        Get
            Return Me._tbIA1
        End Get
        <DebuggerNonUserCode()>
        <MethodImpl(MethodImplOptions.Synchronized)>
        Set(value As TextBox)
            Me._tbIA1 = value
        End Set
    End Property

    Friend Overridable Property tbIA2() As TextBox
        <DebuggerNonUserCode()>
        Get
            Return Me._tbIA2
        End Get
        <DebuggerNonUserCode()>
        <MethodImpl(MethodImplOptions.Synchronized)>
        Set(value As TextBox)
            Me._tbIA2 = value
        End Set
    End Property

    Friend Overridable Property tbIA3() As TextBox
        <DebuggerNonUserCode()>
        Get
            Return Me._tbIA3
        End Get
        <DebuggerNonUserCode()>
        <MethodImpl(MethodImplOptions.Synchronized)>
        Set(value As TextBox)
            Me._tbIA3 = value
        End Set
    End Property

    Friend Overridable Property tbIA4() As TextBox
        <DebuggerNonUserCode()>
        Get
            Return Me._tbIA4
        End Get
        <DebuggerNonUserCode()>
        <MethodImpl(MethodImplOptions.Synchronized)>
        Set(value As TextBox)
            Me._tbIA4 = value
        End Set
    End Property

    Friend Overridable Property tbIA5() As TextBox
        <DebuggerNonUserCode()>
        Get
            Return Me._tbIA5
        End Get
        <DebuggerNonUserCode()>
        <MethodImpl(MethodImplOptions.Synchronized)>
        Set(value As TextBox)
            Me._tbIA5 = value
        End Set
    End Property

    Friend Overridable Property tbIA6() As TextBox
        <DebuggerNonUserCode()>
        Get
            Return Me._tbIA6
        End Get
        <DebuggerNonUserCode()>
        <MethodImpl(MethodImplOptions.Synchronized)>
        Set(value As TextBox)
            Me._tbIA6 = value
        End Set
    End Property

    Friend Overridable Property lblSubID1() As Label
        <DebuggerNonUserCode()>
        Get
            Return Me._lblSubID1
        End Get
        <DebuggerNonUserCode()>
        <MethodImpl(MethodImplOptions.Synchronized)>
        Set(value As Label)
            Me._lblSubID1 = value
        End Set
    End Property

    Friend Overridable Property tb1ID4() As TextBox
        <DebuggerNonUserCode()>
        Get
            Return Me._tb1ID4
        End Get
        <DebuggerNonUserCode()>
        <MethodImpl(MethodImplOptions.Synchronized)>
        Set(value As TextBox)
            Me._tb1ID4 = value
        End Set
    End Property

    Friend Overridable Property tb1ID3() As TextBox
        <DebuggerNonUserCode()>
        Get
            Return Me._tb1ID3
        End Get
        <DebuggerNonUserCode()>
        <MethodImpl(MethodImplOptions.Synchronized)>
        Set(value As TextBox)
            Me._tb1ID3 = value
        End Set
    End Property

    Friend Overridable Property tb1ID2() As TextBox
        <DebuggerNonUserCode()>
        Get
            Return Me._tb1ID2
        End Get
        <DebuggerNonUserCode()>
        <MethodImpl(MethodImplOptions.Synchronized)>
        Set(value As TextBox)
            Me._tb1ID2 = value
        End Set
    End Property

    Friend Overridable Property tb1ID1() As TextBox
        <DebuggerNonUserCode()>
        Get
            Return Me._tb1ID1
        End Get
        <DebuggerNonUserCode()>
        <MethodImpl(MethodImplOptions.Synchronized)>
        Set(value As TextBox)
            Me._tb1ID1 = value
        End Set
    End Property

    Friend Overridable Property tb2ID4() As TextBox
        <DebuggerNonUserCode()>
        Get
            Return Me._tb2ID4
        End Get
        <DebuggerNonUserCode()>
        <MethodImpl(MethodImplOptions.Synchronized)>
        Set(value As TextBox)
            Me._tb2ID4 = value
        End Set
    End Property

    Friend Overridable Property tb2ID3() As TextBox
        <DebuggerNonUserCode()>
        Get
            Return Me._tb2ID3
        End Get
        <DebuggerNonUserCode()>
        <MethodImpl(MethodImplOptions.Synchronized)>
        Set(value As TextBox)
            Me._tb2ID3 = value
        End Set
    End Property

    Friend Overridable Property tb2ID2() As TextBox
        <DebuggerNonUserCode()>
        Get
            Return Me._tb2ID2
        End Get
        <DebuggerNonUserCode()>
        <MethodImpl(MethodImplOptions.Synchronized)>
        Set(value As TextBox)
            Me._tb2ID2 = value
        End Set
    End Property

    Friend Overridable Property tb2ID1() As TextBox
        <DebuggerNonUserCode()>
        Get
            Return Me._tb2ID1
        End Get
        <DebuggerNonUserCode()>
        <MethodImpl(MethodImplOptions.Synchronized)>
        Set(value As TextBox)
            Me._tb2ID1 = value
        End Set
    End Property

    Friend Overridable Property tb3ID4() As TextBox
        <DebuggerNonUserCode()>
        Get
            Return Me._tb3ID4
        End Get
        <DebuggerNonUserCode()>
        <MethodImpl(MethodImplOptions.Synchronized)>
        Set(value As TextBox)
            Me._tb3ID4 = value
        End Set
    End Property

    Friend Overridable Property tb3ID3() As TextBox
        <DebuggerNonUserCode()>
        Get
            Return Me._tb3ID3
        End Get
        <DebuggerNonUserCode()>
        <MethodImpl(MethodImplOptions.Synchronized)>
        Set(value As TextBox)
            Me._tb3ID3 = value
        End Set
    End Property

    Friend Overridable Property tb3ID2() As TextBox
        <DebuggerNonUserCode()>
        Get
            Return Me._tb3ID2
        End Get
        <DebuggerNonUserCode()>
        <MethodImpl(MethodImplOptions.Synchronized)>
        Set(value As TextBox)
            Me._tb3ID2 = value
        End Set
    End Property

    Friend Overridable Property tb3ID1() As TextBox
        <DebuggerNonUserCode()>
        Get
            Return Me._tb3ID1
        End Get
        <DebuggerNonUserCode()>
        <MethodImpl(MethodImplOptions.Synchronized)>
        Set(value As TextBox)
            Me._tb3ID1 = value
        End Set
    End Property

    Friend Overridable Property tb4ID4() As TextBox
        <DebuggerNonUserCode()>
        Get
            Return Me._tb4ID4
        End Get
        <DebuggerNonUserCode()>
        <MethodImpl(MethodImplOptions.Synchronized)>
        Set(value As TextBox)
            Me._tb4ID4 = value
        End Set
    End Property

    Friend Overridable Property tb4ID3() As TextBox
        <DebuggerNonUserCode()>
        Get
            Return Me._tb4ID3
        End Get
        <DebuggerNonUserCode()>
        <MethodImpl(MethodImplOptions.Synchronized)>
        Set(value As TextBox)
            Me._tb4ID3 = value
        End Set
    End Property

    Friend Overridable Property tb4ID2() As TextBox
        <DebuggerNonUserCode()>
        Get
            Return Me._tb4ID2
        End Get
        <DebuggerNonUserCode()>
        <MethodImpl(MethodImplOptions.Synchronized)>
        Set(value As TextBox)
            Me._tb4ID2 = value
        End Set
    End Property

    Friend Overridable Property tb4ID1() As TextBox
        <DebuggerNonUserCode()>
        Get
            Return Me._tb4ID1
        End Get
        <DebuggerNonUserCode()>
        <MethodImpl(MethodImplOptions.Synchronized)>
        Set(value As TextBox)
            Me._tb4ID1 = value
        End Set
    End Property

    Friend Overridable Property lblSubID2() As Label
        <DebuggerNonUserCode()>
        Get
            Return Me._lblSubID2
        End Get
        <DebuggerNonUserCode()>
        <MethodImpl(MethodImplOptions.Synchronized)>
        Set(value As Label)
            Me._lblSubID2 = value
        End Set
    End Property

    Friend Overridable Property SubID3() As Label
        <DebuggerNonUserCode()>
        Get
            Return Me._SubID3
        End Get
        <DebuggerNonUserCode()>
        <MethodImpl(MethodImplOptions.Synchronized)>
        Set(value As Label)
            Me._SubID3 = value
        End Set
    End Property

    Friend Overridable Property lblSubID4() As Label
        <DebuggerNonUserCode()>
        Get
            Return Me._lblSubID4
        End Get
        <DebuggerNonUserCode()>
        <MethodImpl(MethodImplOptions.Synchronized)>
        Set(value As Label)
            Me._lblSubID4 = value
        End Set
    End Property

    Friend Overridable Property tb5ID1() As TextBox
        <DebuggerNonUserCode()>
        Get
            Return Me._tb5ID1
        End Get
        <DebuggerNonUserCode()>
        <MethodImpl(MethodImplOptions.Synchronized)>
        Set(value As TextBox)
            Me._tb5ID1 = value
        End Set
    End Property

    Friend Overridable Property tb5ID2() As TextBox
        <DebuggerNonUserCode()>
        Get
            Return Me._tb5ID2
        End Get
        <DebuggerNonUserCode()>
        <MethodImpl(MethodImplOptions.Synchronized)>
        Set(value As TextBox)
            Me._tb5ID2 = value
        End Set
    End Property

    Friend Overridable Property tb5ID3() As TextBox
        <DebuggerNonUserCode()>
        Get
            Return Me._tb5ID3
        End Get
        <DebuggerNonUserCode()>
        <MethodImpl(MethodImplOptions.Synchronized)>
        Set(value As TextBox)
            Me._tb5ID3 = value
        End Set
    End Property

    Friend Overridable Property tb5ID4() As TextBox
        <DebuggerNonUserCode()>
        Get
            Return Me._tb5ID4
        End Get
        <DebuggerNonUserCode()>
        <MethodImpl(MethodImplOptions.Synchronized)>
        Set(value As TextBox)
            Me._tb5ID4 = value
        End Set
    End Property

    Friend Overridable Property lblSubID5() As Label
        <DebuggerNonUserCode()>
        Get
            Return Me._lblSubID5
        End Get
        <DebuggerNonUserCode()>
        <MethodImpl(MethodImplOptions.Synchronized)>
        Set(value As Label)
            Me._lblSubID5 = value
        End Set
    End Property

    Friend Overridable Property lblOutput() As Label
        <DebuggerNonUserCode()>
        Get
            Return Me._lblOutput
        End Get
        <DebuggerNonUserCode()>
        <MethodImpl(MethodImplOptions.Synchronized)>
        Set(value As Label)
            Me._lblOutput = value
        End Set
    End Property

    Friend Overridable Property tbOutputString() As TextBox
        <DebuggerNonUserCode()>
        Get
            Return Me._tbOutputString
        End Get
        <DebuggerNonUserCode()>
        <MethodImpl(MethodImplOptions.Synchronized)>
        Set(value As TextBox)
            Me._tbOutputString = value
        End Set
    End Property

    Friend Overridable Property lblAbout() As Label
        <DebuggerNonUserCode()>
        Get
            Return Me._lblAbout
        End Get
        <DebuggerNonUserCode()>
        <MethodImpl(MethodImplOptions.Synchronized)>
        Set(value As Label)
            Dim value2 As EventHandler = AddressOf Me.lblAbout_Click
            If Me._lblAbout IsNot Nothing Then
                RemoveHandler Me._lblAbout.Click, value2
            End If
            Me._lblAbout = value
            If Me._lblAbout IsNot Nothing Then
                AddHandler Me._lblAbout.Click, value2
            End If
        End Set
    End Property

    Friend Overridable Property lnklblSelfAdsiorg() As LinkLabel
        <DebuggerNonUserCode()>
        Get
            Return Me._lnklblSelfAdsiorg
        End Get
        <DebuggerNonUserCode()>
        <MethodImpl(MethodImplOptions.Synchronized)>
        Set(value As LinkLabel)
            Dim value2 As LinkLabelLinkClickedEventHandler = AddressOf Me.lnklblSelfAdsiorg_LinkClicked
            If Me._lnklblSelfAdsiorg IsNot Nothing Then
                RemoveHandler Me._lnklblSelfAdsiorg.LinkClicked, value2
            End If
            Me._lnklblSelfAdsiorg = value
            If Me._lnklblSelfAdsiorg IsNot Nothing Then
                AddHandler Me._lnklblSelfAdsiorg.LinkClicked, value2
            End If
        End Set
    End Property

    Friend Overridable Property lblArrayCount() As Label
        <DebuggerNonUserCode()>
        Get
            Return Me._lblArrayCount
        End Get
        <DebuggerNonUserCode()>
        <MethodImpl(MethodImplOptions.Synchronized)>
        Set(value As Label)
            Me._lblArrayCount = value
        End Set
    End Property

    <DebuggerNonUserCode()>
    Public Sub New()
        Me.InitializeComponent()
    End Sub

    <DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso Me.components IsNot Nothing Then
                Me.components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    <DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim componentResourceManager As ComponentResourceManager = New ComponentResourceManager(GetType(Form1))
        Me.btnConvert = New Button()
        Me.lblInputString = New Label()
        Me.tbInputString = New TextBox()
        Me.lblRevision = New Label()
        Me.tbRevision = New TextBox()
        Me.lblSubIDCount = New Label()
        Me.tbSubIDCount = New TextBox()
        Me.lblIdentifierAuthority = New Label()
        Me.tbIA1 = New TextBox()
        Me.tbIA2 = New TextBox()
        Me.tbIA3 = New TextBox()
        Me.tbIA4 = New TextBox()
        Me.tbIA5 = New TextBox()
        Me.tbIA6 = New TextBox()
        Me.lblSubID1 = New Label()
        Me.tb1ID4 = New TextBox()
        Me.tb1ID3 = New TextBox()
        Me.tb1ID2 = New TextBox()
        Me.tb1ID1 = New TextBox()
        Me.tb2ID4 = New TextBox()
        Me.tb2ID3 = New TextBox()
        Me.tb2ID2 = New TextBox()
        Me.tb2ID1 = New TextBox()
        Me.tb3ID4 = New TextBox()
        Me.tb3ID3 = New TextBox()
        Me.tb3ID2 = New TextBox()
        Me.tb3ID1 = New TextBox()
        Me.tb4ID4 = New TextBox()
        Me.tb4ID3 = New TextBox()
        Me.tb4ID2 = New TextBox()
        Me.tb4ID1 = New TextBox()
        Me.lblSubID2 = New Label()
        Me.SubID3 = New Label()
        Me.lblSubID4 = New Label()
        Me.tb5ID1 = New TextBox()
        Me.tb5ID2 = New TextBox()
        Me.tb5ID3 = New TextBox()
        Me.tb5ID4 = New TextBox()
        Me.lblSubID5 = New Label()
        Me.lblOutput = New Label()
        Me.tbOutputString = New TextBox()
        Me.lblAbout = New Label()
        Me.lnklblSelfAdsiorg = New LinkLabel()
        Me.lblArrayCount = New Label()
        Me.SuspendLayout()
        Dim arg_20C_0 As Control = Me.btnConvert
        Dim location As Point = New Point(35, 32)
        arg_20C_0.Location = location
        Dim arg_220_0 As Control = Me.btnConvert
        Dim margin As Padding = New Padding(4)
        arg_220_0.Margin = margin
        Me.btnConvert.Name = "btnConvert"
        Dim arg_247_0 As Control = Me.btnConvert
        Dim size As Size = New Size(100, 28)
        arg_247_0.Size = size
        Me.btnConvert.TabIndex = 0
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        Me.lblInputString.AutoSize = True
        Me.lblInputString.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Dim arg_2AF_0 As Control = Me.lblInputString
        location = New Point(48, 82)
        arg_2AF_0.Location = location
        Dim arg_2C6_0 As Control = Me.lblInputString
        margin = New Padding(4, 0, 4, 0)
        arg_2C6_0.Margin = margin
        Me.lblInputString.Name = "lblInputString"
        Dim arg_2F0_0 As Control = Me.lblInputString
        size = New Size(161, 16)
        arg_2F0_0.Size = size
        Me.lblInputString.TabIndex = 1
        Me.lblInputString.Text = "Input Byte Array String"
        Dim arg_323_0 As Control = Me.tbInputString
        location = New Point(51, 113)
        arg_323_0.Location = location
        Dim arg_337_0 As Control = Me.tbInputString
        margin = New Padding(4)
        arg_337_0.Margin = margin
        Me.tbInputString.Name = "tbInputString"
        Dim arg_361_0 As Control = Me.tbInputString
        size = New Size(708, 22)
        arg_361_0.Size = size
        Me.tbInputString.TabIndex = 2
        Me.lblRevision.AutoSize = True
        Me.lblRevision.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Dim arg_3B0_0 As Control = Me.lblRevision
        location = New Point(48, 170)
        arg_3B0_0.Location = location
        Me.lblRevision.Name = "lblRevision"
        Dim arg_3D7_0 As Control = Me.lblRevision
        size = New Size(69, 16)
        arg_3D7_0.Size = size
        Me.lblRevision.TabIndex = 3
        Me.lblRevision.Text = "Revision"
        Dim arg_40D_0 As Control = Me.tbRevision
        location = New Point(123, 168)
        arg_40D_0.Location = location
        Me.tbRevision.MaxLength = 10
        Me.tbRevision.Name = "tbRevision"
        Dim arg_441_0 As Control = Me.tbRevision
        size = New Size(30, 22)
        arg_441_0.Size = size
        Me.tbRevision.TabIndex = 4
        Me.lblSubIDCount.AutoSize = True
        Me.lblSubIDCount.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Dim arg_493_0 As Control = Me.lblSubIDCount
        location = New Point(175, 171)
        arg_493_0.Location = location
        Me.lblSubIDCount.Name = "lblSubIDCount"
        Dim arg_4BA_0 As Control = Me.lblSubIDCount
        size = New Size(97, 16)
        arg_4BA_0.Size = size
        Me.lblSubIDCount.TabIndex = 5
        Me.lblSubIDCount.Text = "Sub ID Count"
        Dim arg_4F3_0 As Control = Me.tbSubIDCount
        location = New Point(288, 167)
        arg_4F3_0.Location = location
        Me.tbSubIDCount.Name = "tbSubIDCount"
        Dim arg_51A_0 As Control = Me.tbSubIDCount
        size = New Size(30, 22)
        arg_51A_0.Size = size
        Me.tbSubIDCount.TabIndex = 6
        Me.lblIdentifierAuthority.AutoSize = True
        Me.lblIdentifierAuthority.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Dim arg_56C_0 As Control = Me.lblIdentifierAuthority
        location = New Point(373, 171)
        arg_56C_0.Location = location
        Me.lblIdentifierAuthority.Name = "lblIdentifierAuthority"
        Dim arg_596_0 As Control = Me.lblIdentifierAuthority
        size = New Size(128, 16)
        arg_596_0.Size = size
        Me.lblIdentifierAuthority.TabIndex = 7
        Me.lblIdentifierAuthority.Text = "IdentifierAuthority"
        Dim arg_5CF_0 As Control = Me.tbIA1
        location = New Point(520, 168)
        arg_5CF_0.Location = location
        Me.tbIA1.Name = "tbIA1"
        Dim arg_5F6_0 As Control = Me.tbIA1
        size = New Size(30, 22)
        arg_5F6_0.Size = size
        Me.tbIA1.TabIndex = 8
        Me.tbIA1.Text = "IA1"
        Dim arg_62F_0 As Control = Me.tbIA2
        location = New Point(564, 168)
        arg_62F_0.Location = location
        Me.tbIA2.Name = "tbIA2"
        Dim arg_656_0 As Control = Me.tbIA2
        size = New Size(30, 22)
        arg_656_0.Size = size
        Me.tbIA2.TabIndex = 9
        Me.tbIA2.Text = "IA2"
        Dim arg_690_0 As Control = Me.tbIA3
        location = New Point(608, 167)
        arg_690_0.Location = location
        Me.tbIA3.Name = "tbIA3"
        Dim arg_6B7_0 As Control = Me.tbIA3
        size = New Size(30, 22)
        arg_6B7_0.Size = size
        Me.tbIA3.TabIndex = 10
        Me.tbIA3.Text = "IA3"
        Dim arg_6F1_0 As Control = Me.tbIA4
        location = New Point(652, 168)
        arg_6F1_0.Location = location
        Me.tbIA4.Name = "tbIA4"
        Dim arg_718_0 As Control = Me.tbIA4
        size = New Size(30, 22)
        arg_718_0.Size = size
        Me.tbIA4.TabIndex = 11
        Me.tbIA4.Text = "IA4"
        Dim arg_752_0 As Control = Me.tbIA5
        location = New Point(696, 168)
        arg_752_0.Location = location
        Me.tbIA5.Name = "tbIA5"
        Dim arg_779_0 As Control = Me.tbIA5
        size = New Size(30, 22)
        arg_779_0.Size = size
        Me.tbIA5.TabIndex = 12
        Me.tbIA5.Text = "IA5"
        Dim arg_7B3_0 As Control = Me.tbIA6
        location = New Point(740, 168)
        arg_7B3_0.Location = location
        Me.tbIA6.Name = "tbIA6"
        Dim arg_7DA_0 As Control = Me.tbIA6
        size = New Size(30, 22)
        arg_7DA_0.Size = size
        Me.tbIA6.TabIndex = 13
        Me.tbIA6.Text = "IA6"
        Me.lblSubID1.AutoSize = True
        Me.lblSubID1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Dim arg_83A_0 As Control = Me.lblSubID1
        location = New Point(48, 216)
        arg_83A_0.Location = location
        Me.lblSubID1.Name = "lblSubID1"
        Dim arg_861_0 As Control = Me.lblSubID1
        size = New Size(66, 16)
        arg_861_0.Size = size
        Me.lblSubID1.TabIndex = 14
        Me.lblSubID1.Text = "Sub ID 1"
        Dim arg_898_0 As Control = Me.tb1ID4
        location = New Point(120, 213)
        arg_898_0.Location = location
        Me.tb1ID4.Name = "tb1ID4"
        Dim arg_8BF_0 As Control = Me.tb1ID4
        size = New Size(30, 22)
        arg_8BF_0.Size = size
        Me.tb1ID4.TabIndex = 15
        Me.tb1ID4.Text = "ID4"
        Dim arg_8F9_0 As Control = Me.tb1ID3
        location = New Point(164, 213)
        arg_8F9_0.Location = location
        Me.tb1ID3.Name = "tb1ID3"
        Dim arg_920_0 As Control = Me.tb1ID3
        size = New Size(30, 22)
        arg_920_0.Size = size
        Me.tb1ID3.TabIndex = 16
        Me.tb1ID3.Text = "ID3"
        Dim arg_95A_0 As Control = Me.tb1ID2
        location = New Point(208, 213)
        arg_95A_0.Location = location
        Me.tb1ID2.Name = "tb1ID2"
        Dim arg_981_0 As Control = Me.tb1ID2
        size = New Size(30, 22)
        arg_981_0.Size = size
        Me.tb1ID2.TabIndex = 17
        Me.tb1ID2.Text = "ID2"
        Dim arg_9BB_0 As Control = Me.tb1ID1
        location = New Point(252, 213)
        arg_9BB_0.Location = location
        Me.tb1ID1.Name = "tb1ID1"
        Dim arg_9E2_0 As Control = Me.tb1ID1
        size = New Size(30, 22)
        arg_9E2_0.Size = size
        Me.tb1ID1.TabIndex = 18
        Me.tb1ID1.Text = "ID1"
        Dim arg_A19_0 As Control = Me.tb2ID4
        location = New Point(120, 255)
        arg_A19_0.Location = location
        Me.tb2ID4.Name = "tb2ID4"
        Dim arg_A40_0 As Control = Me.tb2ID4
        size = New Size(30, 22)
        arg_A40_0.Size = size
        Me.tb2ID4.TabIndex = 19
        Me.tb2ID4.Text = "ID4"
        Dim arg_A7A_0 As Control = Me.tb2ID3
        location = New Point(164, 255)
        arg_A7A_0.Location = location
        Me.tb2ID3.Name = "tb2ID3"
        Dim arg_AA1_0 As Control = Me.tb2ID3
        size = New Size(30, 22)
        arg_AA1_0.Size = size
        Me.tb2ID3.TabIndex = 20
        Me.tb2ID3.Text = "ID3"
        Dim arg_ADB_0 As Control = Me.tb2ID2
        location = New Point(208, 255)
        arg_ADB_0.Location = location
        Me.tb2ID2.Name = "tb2ID2"
        Dim arg_B02_0 As Control = Me.tb2ID2
        size = New Size(30, 22)
        arg_B02_0.Size = size
        Me.tb2ID2.TabIndex = 21
        Me.tb2ID2.Text = "ID2"
        Dim arg_B3C_0 As Control = Me.tb2ID1
        location = New Point(252, 255)
        arg_B3C_0.Location = location
        Me.tb2ID1.Name = "tb2ID1"
        Dim arg_B63_0 As Control = Me.tb2ID1
        size = New Size(30, 22)
        arg_B63_0.Size = size
        Me.tb2ID1.TabIndex = 22
        Me.tb2ID1.Text = "ID1"
        Dim arg_B9A_0 As Control = Me.tb3ID4
        location = New Point(120, 297)
        arg_B9A_0.Location = location
        Me.tb3ID4.Name = "tb3ID4"
        Dim arg_BC1_0 As Control = Me.tb3ID4
        size = New Size(30, 22)
        arg_BC1_0.Size = size
        Me.tb3ID4.TabIndex = 23
        Me.tb3ID4.Text = "ID4"
        Dim arg_BFB_0 As Control = Me.tb3ID3
        location = New Point(164, 297)
        arg_BFB_0.Location = location
        Me.tb3ID3.Name = "tb3ID3"
        Dim arg_C22_0 As Control = Me.tb3ID3
        size = New Size(30, 22)
        arg_C22_0.Size = size
        Me.tb3ID3.TabIndex = 24
        Me.tb3ID3.Text = "ID3"
        Dim arg_C5C_0 As Control = Me.tb3ID2
        location = New Point(208, 297)
        arg_C5C_0.Location = location
        Me.tb3ID2.Name = "tb3ID2"
        Dim arg_C83_0 As Control = Me.tb3ID2
        size = New Size(30, 22)
        arg_C83_0.Size = size
        Me.tb3ID2.TabIndex = 25
        Me.tb3ID2.Text = "ID2"
        Dim arg_CBD_0 As Control = Me.tb3ID1
        location = New Point(252, 297)
        arg_CBD_0.Location = location
        Me.tb3ID1.Name = "tb3ID1"
        Dim arg_CE4_0 As Control = Me.tb3ID1
        size = New Size(30, 22)
        arg_CE4_0.Size = size
        Me.tb3ID1.TabIndex = 26
        Me.tb3ID1.Text = "ID1"
        Dim arg_D1B_0 As Control = Me.tb4ID4
        location = New Point(120, 339)
        arg_D1B_0.Location = location
        Me.tb4ID4.Name = "tb4ID4"
        Dim arg_D42_0 As Control = Me.tb4ID4
        size = New Size(30, 22)
        arg_D42_0.Size = size
        Me.tb4ID4.TabIndex = 27
        Me.tb4ID4.Text = "ID4"
        Dim arg_D7C_0 As Control = Me.tb4ID3
        location = New Point(164, 339)
        arg_D7C_0.Location = location
        Me.tb4ID3.Name = "tb4ID3"
        Dim arg_DA3_0 As Control = Me.tb4ID3
        size = New Size(30, 22)
        arg_DA3_0.Size = size
        Me.tb4ID3.TabIndex = 28
        Me.tb4ID3.Text = "ID3"
        Dim arg_DDD_0 As Control = Me.tb4ID2
        location = New Point(208, 339)
        arg_DDD_0.Location = location
        Me.tb4ID2.Name = "tb4ID2"
        Dim arg_E04_0 As Control = Me.tb4ID2
        size = New Size(30, 22)
        arg_E04_0.Size = size
        Me.tb4ID2.TabIndex = 29
        Me.tb4ID2.Text = "ID2"
        Dim arg_E3E_0 As Control = Me.tb4ID1
        location = New Point(252, 339)
        arg_E3E_0.Location = location
        Me.tb4ID1.Name = "tb4ID1"
        Dim arg_E65_0 As Control = Me.tb4ID1
        size = New Size(30, 22)
        arg_E65_0.Size = size
        Me.tb4ID1.TabIndex = 30
        Me.tb4ID1.Text = "ID1"
        Me.lblSubID2.AutoSize = True
        Me.lblSubID2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Dim arg_EC5_0 As Control = Me.lblSubID2
        location = New Point(48, 258)
        arg_EC5_0.Location = location
        Me.lblSubID2.Name = "lblSubID2"
        Dim arg_EEC_0 As Control = Me.lblSubID2
        size = New Size(66, 16)
        arg_EEC_0.Size = size
        Me.lblSubID2.TabIndex = 31
        Me.lblSubID2.Text = "Sub ID 2"
        Me.SubID3.AutoSize = True
        Me.SubID3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Dim arg_F4C_0 As Control = Me.SubID3
        location = New Point(48, 300)
        arg_F4C_0.Location = location
        Me.SubID3.Name = "SubID3"
        Dim arg_F73_0 As Control = Me.SubID3
        size = New Size(66, 16)
        arg_F73_0.Size = size
        Me.SubID3.TabIndex = 32
        Me.SubID3.Text = "Sub ID 3"
        Me.lblSubID4.AutoSize = True
        Me.lblSubID4.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Dim arg_FD3_0 As Control = Me.lblSubID4
        location = New Point(48, 342)
        arg_FD3_0.Location = location
        Me.lblSubID4.Name = "lblSubID4"
        Dim arg_FFA_0 As Control = Me.lblSubID4
        size = New Size(66, 16)
        arg_FFA_0.Size = size
        Me.lblSubID4.TabIndex = 33
        Me.lblSubID4.Text = "Sub ID 4"
        Dim arg_1034_0 As Control = Me.tb5ID1
        location = New Point(252, 381)
        arg_1034_0.Location = location
        Me.tb5ID1.Name = "tb5ID1"
        Dim arg_105B_0 As Control = Me.tb5ID1
        size = New Size(30, 22)
        arg_105B_0.Size = size
        Me.tb5ID1.TabIndex = 38
        Me.tb5ID1.Text = "ID1"
        Dim arg_1095_0 As Control = Me.tb5ID2
        location = New Point(208, 381)
        arg_1095_0.Location = location
        Me.tb5ID2.Name = "tb5ID2"
        Dim arg_10BC_0 As Control = Me.tb5ID2
        size = New Size(30, 22)
        arg_10BC_0.Size = size
        Me.tb5ID2.TabIndex = 37
        Me.tb5ID2.Text = "ID2"
        Dim arg_10F6_0 As Control = Me.tb5ID3
        location = New Point(164, 381)
        arg_10F6_0.Location = location
        Me.tb5ID3.Name = "tb5ID3"
        Dim arg_111D_0 As Control = Me.tb5ID3
        size = New Size(30, 22)
        arg_111D_0.Size = size
        Me.tb5ID3.TabIndex = 36
        Me.tb5ID3.Text = "ID3"
        Dim arg_1154_0 As Control = Me.tb5ID4
        location = New Point(120, 381)
        arg_1154_0.Location = location
        Me.tb5ID4.Name = "tb5ID4"
        Dim arg_117B_0 As Control = Me.tb5ID4
        size = New Size(30, 22)
        arg_117B_0.Size = size
        Me.tb5ID4.TabIndex = 35
        Me.tb5ID4.Text = "ID4"
        Me.lblSubID5.AutoSize = True
        Me.lblSubID5.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Dim arg_11DB_0 As Control = Me.lblSubID5
        location = New Point(48, 384)
        arg_11DB_0.Location = location
        Me.lblSubID5.Name = "lblSubID5"
        Dim arg_1202_0 As Control = Me.lblSubID5
        size = New Size(66, 16)
        arg_1202_0.Size = size
        Me.lblSubID5.TabIndex = 39
        Me.lblSubID5.Text = "Sub ID 5"
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Dim arg_1262_0 As Control = Me.lblOutput
        location = New Point(51, 440)
        arg_1262_0.Location = location
        Me.lblOutput.Name = "lblOutput"
        Dim arg_1289_0 As Control = Me.lblOutput
        size = New Size(125, 16)
        arg_1289_0.Size = size
        Me.lblOutput.TabIndex = 40
        Me.lblOutput.Text = "Output SID String"
        Me.tbOutputString.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Dim arg_12DD_0 As Control = Me.tbOutputString
        location = New Point(54, 473)
        arg_12DD_0.Location = location
        Me.tbOutputString.Name = "tbOutputString"
        Dim arg_1307_0 As Control = Me.tbOutputString
        size = New Size(705, 26)
        arg_1307_0.Size = size
        Me.tbOutputString.TabIndex = 41
        Me.lblAbout.AutoSize = True
        Dim arg_133A_0 As Control = Me.lblAbout
        location = New Point(737, 32)
        arg_133A_0.Location = location
        Me.lblAbout.Name = "lblAbout"
        Dim arg_1361_0 As Control = Me.lblAbout
        size = New Size(43, 16)
        arg_1361_0.Size = size
        Me.lblAbout.TabIndex = 42
        Me.lblAbout.Text = "About"
        Me.lnklblSelfAdsiorg.AutoSize = True
        Dim arg_13A4_0 As Control = Me.lnklblSelfAdsiorg
        location = New Point(605, 38)
        arg_13A4_0.Location = location
        Me.lnklblSelfAdsiorg.Name = "lnklblSelfAdsiorg"
        Dim arg_13CB_0 As Control = Me.lnklblSelfAdsiorg
        size = New Size(78, 16)
        arg_13CB_0.Size = size
        Me.lnklblSelfAdsiorg.TabIndex = 43
        Me.lnklblSelfAdsiorg.TabStop = True
        Me.lnklblSelfAdsiorg.Text = "selfadsi.org"
        Me.lblArrayCount.AutoSize = True
        Dim arg_141A_0 As Control = Me.lblArrayCount
        location = New Point(605, 82)
        arg_141A_0.Location = location
        Me.lblArrayCount.Name = "lblArrayCount"
        Dim arg_1441_0 As Control = Me.lblArrayCount
        size = New Size(93, 16)
        arg_1441_0.Size = size
        Me.lblArrayCount.TabIndex = 44
        Me.lblArrayCount.Text = "SID Length = 0"
        Dim autoScaleDimensions As SizeF = New SizeF(8.0F, 16.0F)
        Me.AutoScaleDimensions = autoScaleDimensions
        Me.AutoScaleMode = AutoScaleMode.Font
        size = New Size(827, 581)
        Me.ClientSize = size
        Me.Controls.Add(Me.lblArrayCount)
        Me.Controls.Add(Me.lnklblSelfAdsiorg)
        Me.Controls.Add(Me.lblAbout)
        Me.Controls.Add(Me.tbOutputString)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.lblSubID5)
        Me.Controls.Add(Me.tb5ID1)
        Me.Controls.Add(Me.tb5ID2)
        Me.Controls.Add(Me.tb5ID3)
        Me.Controls.Add(Me.tb5ID4)
        Me.Controls.Add(Me.lblSubID4)
        Me.Controls.Add(Me.SubID3)
        Me.Controls.Add(Me.lblSubID2)
        Me.Controls.Add(Me.tb4ID1)
        Me.Controls.Add(Me.tb4ID2)
        Me.Controls.Add(Me.tb4ID3)
        Me.Controls.Add(Me.tb4ID4)
        Me.Controls.Add(Me.tb3ID1)
        Me.Controls.Add(Me.tb3ID2)
        Me.Controls.Add(Me.tb3ID3)
        Me.Controls.Add(Me.tb3ID4)
        Me.Controls.Add(Me.tb2ID1)
        Me.Controls.Add(Me.tb2ID2)
        Me.Controls.Add(Me.tb2ID3)
        Me.Controls.Add(Me.tb2ID4)
        Me.Controls.Add(Me.tb1ID1)
        Me.Controls.Add(Me.tb1ID2)
        Me.Controls.Add(Me.tb1ID3)
        Me.Controls.Add(Me.tb1ID4)
        Me.Controls.Add(Me.lblSubID1)
        Me.Controls.Add(Me.tbIA6)
        Me.Controls.Add(Me.tbIA5)
        Me.Controls.Add(Me.tbIA4)
        Me.Controls.Add(Me.tbIA3)
        Me.Controls.Add(Me.tbIA2)
        Me.Controls.Add(Me.tbIA1)
        Me.Controls.Add(Me.lblIdentifierAuthority)
        Me.Controls.Add(Me.tbSubIDCount)
        Me.Controls.Add(Me.lblSubIDCount)
        Me.Controls.Add(Me.tbRevision)
        Me.Controls.Add(Me.lblRevision)
        Me.Controls.Add(Me.tbInputString)
        Me.Controls.Add(Me.lblInputString)
        Me.Controls.Add(Me.btnConvert)
        Me.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0)
        Me.FormBorderStyle = FormBorderStyle.Fixed3D
        Me.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Icon)
        margin = New Padding(4)
        Me.Margin = margin
        Me.Name = "Form1"
        Me.Text = "SID Converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

End Class

