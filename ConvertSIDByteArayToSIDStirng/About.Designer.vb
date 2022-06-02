Imports ConvertSIDByteArayToSIDStirng.My

Imports Microsoft.VisualBasic.CompilerServices

Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

<DesignerGenerated()>
Partial Public Class AboutBox1
    Inherits Form

    <AccessedThroughProperty("TableLayoutPanel")>
    Private _TableLayoutPanel As TableLayoutPanel

    <AccessedThroughProperty("LogoPictureBox")>
    Private _LogoPictureBox As PictureBox

    <AccessedThroughProperty("LabelProductName")>
    Private _LabelProductName As Label

    <AccessedThroughProperty("LabelVersion")>
    Private _LabelVersion As Label

    <AccessedThroughProperty("LabelCompanyName")>
    Private _LabelCompanyName As Label

    <AccessedThroughProperty("TextBoxDescription")>
    Private _TextBoxDescription As TextBox

    <AccessedThroughProperty("OKButton")>
    Private _OKButton As Button

    <AccessedThroughProperty("LabelCopyright")>
    Private _LabelCopyright As Label

    Private components As IContainer

    Friend Overridable Property TableLayoutPanel() As TableLayoutPanel
        <DebuggerNonUserCode()>
        Get
            Return Me._TableLayoutPanel
        End Get
        <DebuggerNonUserCode()>
        <MethodImpl(MethodImplOptions.Synchronized)>
        Set(value As TableLayoutPanel)
            Me._TableLayoutPanel = value
        End Set
    End Property

    Friend Overridable Property LogoPictureBox() As PictureBox
        <DebuggerNonUserCode()>
        Get
            Return Me._LogoPictureBox
        End Get
        <DebuggerNonUserCode()>
        <MethodImpl(MethodImplOptions.Synchronized)>
        Set(value As PictureBox)
            Me._LogoPictureBox = value
        End Set
    End Property

    Friend Overridable Property LabelProductName() As Label
        <DebuggerNonUserCode()>
        Get
            Return Me._LabelProductName
        End Get
        <DebuggerNonUserCode()>
        <MethodImpl(MethodImplOptions.Synchronized)>
        Set(value As Label)
            Me._LabelProductName = value
        End Set
    End Property

    Friend Overridable Property LabelVersion() As Label
        <DebuggerNonUserCode()>
        Get
            Return Me._LabelVersion
        End Get
        <DebuggerNonUserCode()>
        <MethodImpl(MethodImplOptions.Synchronized)>
        Set(value As Label)
            Me._LabelVersion = value
        End Set
    End Property

    Friend Overridable Property LabelCompanyName() As Label
        <DebuggerNonUserCode()>
        Get
            Return Me._LabelCompanyName
        End Get
        <DebuggerNonUserCode()>
        <MethodImpl(MethodImplOptions.Synchronized)>
        Set(value As Label)
            Me._LabelCompanyName = value
        End Set
    End Property

    Friend Overridable Property TextBoxDescription() As TextBox
        <DebuggerNonUserCode()>
        Get
            Return Me._TextBoxDescription
        End Get
        <DebuggerNonUserCode()>
        <MethodImpl(MethodImplOptions.Synchronized)>
        Set(value As TextBox)
            Me._TextBoxDescription = value
        End Set
    End Property

    Friend Overridable Property OKButton() As Button
        <DebuggerNonUserCode()>
        Get
            Return Me._OKButton
        End Get
        <DebuggerNonUserCode()>
        <MethodImpl(MethodImplOptions.Synchronized)>
        Set(value As Button)
            Dim value2 As EventHandler = AddressOf Me.OKButton_Click
            If Me._OKButton IsNot Nothing Then
                RemoveHandler Me._OKButton.Click, value2
            End If
            Me._OKButton = value
            If Me._OKButton IsNot Nothing Then
                AddHandler Me._OKButton.Click, value2
            End If
        End Set
    End Property

    Friend Overridable Property LabelCopyright() As Label
        <DebuggerNonUserCode()>
        Get
            Return Me._LabelCopyright
        End Get
        <DebuggerNonUserCode()>
        <MethodImpl(MethodImplOptions.Synchronized)>
        Set(value As Label)
            Me._LabelCopyright = value
        End Set
    End Property

    <DebuggerNonUserCode()>
    Public Sub New()
        AddHandler MyBase.Load, AddressOf Me.AboutBox1_Load
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
        Dim componentResourceManager As ComponentResourceManager = New ComponentResourceManager(GetType(AboutBox1))
        Me.TableLayoutPanel = New TableLayoutPanel()
        Me.LogoPictureBox = New PictureBox()
        Me.LabelProductName = New Label()
        Me.LabelVersion = New Label()
        Me.LabelCopyright = New Label()
        Me.LabelCompanyName = New Label()
        Me.TextBoxDescription = New TextBox()
        Me.OKButton = New Button()
        Me.TableLayoutPanel.SuspendLayout()
        CType(Me.LogoPictureBox, ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.TableLayoutPanel.ColumnCount = 2
        Me.TableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.0F))
        Me.TableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 67.0F))
        Me.TableLayoutPanel.Controls.Add(Me.LogoPictureBox, 0, 0)
        Me.TableLayoutPanel.Controls.Add(Me.LabelProductName, 1, 0)
        Me.TableLayoutPanel.Controls.Add(Me.LabelVersion, 1, 1)
        Me.TableLayoutPanel.Controls.Add(Me.LabelCopyright, 1, 2)
        Me.TableLayoutPanel.Controls.Add(Me.LabelCompanyName, 1, 3)
        Me.TableLayoutPanel.Controls.Add(Me.TextBoxDescription, 1, 4)
        Me.TableLayoutPanel.Controls.Add(Me.OKButton, 1, 5)
        Me.TableLayoutPanel.Dock = DockStyle.Fill
        Dim arg_18E_0 As Control = Me.TableLayoutPanel
        Dim location As Point = New Point(9, 9)
        arg_18E_0.Location = location
        Me.TableLayoutPanel.Name = "TableLayoutPanel"
        Me.TableLayoutPanel.RowCount = 6
        Me.TableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 10.0F))
        Me.TableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 10.0F))
        Me.TableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 10.0F))
        Me.TableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 10.0F))
        Me.TableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        Me.TableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 10.0F))
        Dim arg_26F_0 As Control = Me.TableLayoutPanel
        Dim size As Size = New Size(396, 258)
        arg_26F_0.Size = size
        Me.TableLayoutPanel.TabIndex = 0
        Me.LogoPictureBox.Dock = DockStyle.Fill
        Me.LogoPictureBox.Image = CType(componentResourceManager.GetObject("LogoPictureBox.Image"), Image)
        Dim arg_2B7_0 As Control = Me.LogoPictureBox
        location = New Point(3, 3)
        arg_2B7_0.Location = location
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.TableLayoutPanel.SetRowSpan(Me.LogoPictureBox, 6)
        Dim arg_2F3_0 As Control = Me.LogoPictureBox
        size = New Size(124, 252)
        arg_2F3_0.Size = size
        Me.LogoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        Me.LabelProductName.Dock = DockStyle.Fill
        Dim arg_33C_0 As Control = Me.LabelProductName
        location = New Point(136, 0)
        arg_33C_0.Location = location
        Dim arg_353_0 As Control = Me.LabelProductName
        Dim padding As Padding = New Padding(6, 0, 3, 0)
        arg_353_0.Margin = padding
        Dim arg_369_0 As Control = Me.LabelProductName
        size = New Size(0, 17)
        arg_369_0.MaximumSize = size
        Me.LabelProductName.Name = "LabelProductName"
        Dim arg_393_0 As Control = Me.LabelProductName
        size = New Size(257, 17)
        arg_393_0.Size = size
        Me.LabelProductName.TabIndex = 0
        Me.LabelProductName.Text = "Product Name"
        Me.LabelProductName.TextAlign = ContentAlignment.MiddleLeft
        Me.LabelVersion.Dock = DockStyle.Fill
        Dim arg_3E2_0 As Control = Me.LabelVersion
        location = New Point(136, 25)
        arg_3E2_0.Location = location
        Dim arg_3F9_0 As Control = Me.LabelVersion
        padding = New Padding(6, 0, 3, 0)
        arg_3F9_0.Margin = padding
        Dim arg_40F_0 As Control = Me.LabelVersion
        size = New Size(0, 17)
        arg_40F_0.MaximumSize = size
        Me.LabelVersion.Name = "LabelVersion"
        Dim arg_439_0 As Control = Me.LabelVersion
        size = New Size(257, 17)
        arg_439_0.Size = size
        Me.LabelVersion.TabIndex = 0
        Me.LabelVersion.Text = "Version"
        Me.LabelVersion.TextAlign = ContentAlignment.MiddleLeft
        Me.LabelCopyright.Dock = DockStyle.Fill
        Dim arg_488_0 As Control = Me.LabelCopyright
        location = New Point(136, 50)
        arg_488_0.Location = location
        Dim arg_49F_0 As Control = Me.LabelCopyright
        padding = New Padding(6, 0, 3, 0)
        arg_49F_0.Margin = padding
        Dim arg_4B5_0 As Control = Me.LabelCopyright
        size = New Size(0, 17)
        arg_4B5_0.MaximumSize = size
        Me.LabelCopyright.Name = "LabelCopyright"
        Dim arg_4DF_0 As Control = Me.LabelCopyright
        size = New Size(257, 17)
        arg_4DF_0.Size = size
        Me.LabelCopyright.TabIndex = 0
        Me.LabelCopyright.Text = "Copyright"
        Me.LabelCopyright.TextAlign = ContentAlignment.MiddleLeft
        Me.LabelCompanyName.Dock = DockStyle.Fill
        Dim arg_52E_0 As Control = Me.LabelCompanyName
        location = New Point(136, 75)
        arg_52E_0.Location = location
        Dim arg_545_0 As Control = Me.LabelCompanyName
        padding = New Padding(6, 0, 3, 0)
        arg_545_0.Margin = padding
        Dim arg_55B_0 As Control = Me.LabelCompanyName
        size = New Size(0, 17)
        arg_55B_0.MaximumSize = size
        Me.LabelCompanyName.Name = "LabelCompanyName"
        Dim arg_585_0 As Control = Me.LabelCompanyName
        size = New Size(257, 17)
        arg_585_0.Size = size
        Me.LabelCompanyName.TabIndex = 0
        Me.LabelCompanyName.Text = "Company Name"
        Me.LabelCompanyName.TextAlign = ContentAlignment.MiddleLeft
        Me.TextBoxDescription.Dock = DockStyle.Fill
        Dim arg_5D4_0 As Control = Me.TextBoxDescription
        location = New Point(136, 103)
        arg_5D4_0.Location = location
        Dim arg_5EB_0 As Control = Me.TextBoxDescription
        padding = New Padding(6, 3, 3, 3)
        arg_5EB_0.Margin = padding
        Me.TextBoxDescription.Multiline = True
        Me.TextBoxDescription.Name = "TextBoxDescription"
        Me.TextBoxDescription.[ReadOnly] = True
        Me.TextBoxDescription.ScrollBars = ScrollBars.Both
        Dim arg_639_0 As Control = Me.TextBoxDescription
        size = New Size(257, 123)
        arg_639_0.Size = size
        Me.TextBoxDescription.TabIndex = 0
        Me.TextBoxDescription.TabStop = False
        Me.TextBoxDescription.Text = componentResourceManager.GetString("TextBoxDescription.Text")
        Me.OKButton.Anchor = (AnchorStyles.Bottom Or AnchorStyles.Right)
        Me.OKButton.DialogResult = DialogResult.Cancel
        Dim arg_69D_0 As Control = Me.OKButton
        location = New Point(318, 232)
        arg_69D_0.Location = location
        Me.OKButton.Name = "OKButton"
        Dim arg_6C4_0 As Control = Me.OKButton
        size = New Size(75, 23)
        arg_6C4_0.Size = size
        Me.OKButton.TabIndex = 0
        Me.OKButton.Text = "&OK"
        Dim autoScaleDimensions As SizeF = New SizeF(6.0F, 13.0F)
        Me.AutoScaleDimensions = autoScaleDimensions
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.CancelButton = Me.OKButton
        size = New Size(414, 276)
        Me.ClientSize = size
        Me.Controls.Add(Me.TableLayoutPanel)
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AboutBox1"
        padding = New Padding(9)
        Me.Padding = padding
        Me.ShowInTaskbar = False
        Me.StartPosition = FormStartPosition.CenterParent
        Me.Text = "AboutBox1"
        Me.TableLayoutPanel.ResumeLayout(False)
        Me.TableLayoutPanel.PerformLayout()
        CType(Me.LogoPictureBox, ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Private Sub AboutBox1_Load(sender As Object, e As EventArgs)
        Dim arg As String
        If Operators.CompareString(MyProject.Application.Info.Title, "", False) <> 0 Then
            arg = MyProject.Application.Info.Title
        Else
            arg = Path.GetFileNameWithoutExtension(MyProject.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("About {0}", arg)
        Me.LabelProductName.Text = MyProject.Application.Info.ProductName
        Me.LabelVersion.Text = String.Format("Version {0}", MyProject.Application.Info.Version.ToString())
        Me.LabelCopyright.Text = MyProject.Application.Info.Copyright
        Me.LabelCompanyName.Text = MyProject.Application.Info.CompanyName
        Me.TextBoxDescription.Text = MyProject.Application.Info.Description
    End Sub


End Class

