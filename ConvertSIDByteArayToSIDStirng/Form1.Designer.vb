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

    Private WithEvents btnConvert As Button

    Private WithEvents lblInputString As Label

    Private WithEvents tbInputString As TextBox

    Private WithEvents lblRevision As Label

    Private WithEvents tbRevision As TextBox

    Private WithEvents lblSubIDCount As Label

    Private WithEvents tbSubIDCount As TextBox

    Private WithEvents lblIdentifierAuthority As Label

    Private WithEvents tbIA1 As TextBox

    Private WithEvents tbIA2 As TextBox

    Private WithEvents tbIA3 As TextBox

    Private WithEvents tbIA4 As TextBox

    Private WithEvents tbIA5 As TextBox

    Private WithEvents tbIA6 As TextBox

    Private WithEvents lblSubID1 As Label

    Private WithEvents tb1ID4 As TextBox

    Private WithEvents tb1ID3 As TextBox

    Private WithEvents tb1ID2 As TextBox

    Private WithEvents tb1ID1 As TextBox

    Private WithEvents tb2ID4 As TextBox

    Private WithEvents tb2ID3 As TextBox

    Private WithEvents tb2ID2 As TextBox

    Private WithEvents tb2ID1 As TextBox

    Private WithEvents tb3ID4 As TextBox

    Private WithEvents tb3ID3 As TextBox

    Private WithEvents tb3ID2 As TextBox

    Private WithEvents tb3ID1 As TextBox

    Private WithEvents tb4ID4 As TextBox

    Private WithEvents tb4ID3 As TextBox

    Private WithEvents tb4ID2 As TextBox

    Private WithEvents tb4ID1 As TextBox

    Private WithEvents lblSubID2 As Label

    Private WithEvents SubID3 As Label

    Private WithEvents lblSubID4 As Label

    Private WithEvents tb5ID1 As TextBox

    Private WithEvents tb5ID2 As TextBox

    Private WithEvents tb5ID3 As TextBox

    Private WithEvents tb5ID4 As TextBox

    Private WithEvents lblSubID5 As Label

    Private WithEvents lblOutput As Label

    Private WithEvents tbOutputString As TextBox

    Private WithEvents lblAbout As Label

    Private WithEvents lnklblSelfAdsiorg As LinkLabel

    Private WithEvents lblArrayCount As Label



    <DebuggerNonUserCode()>
    Public Sub New()
        Me.InitializeComponent()
        MyInit()
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

        Dim location As Point = New Point(35, 32)
        Me.btnConvert.Location = New Point(35, 32)

        btnConvert.Margin = New Padding(4)
        Me.btnConvert.Name = "btnConvert"

        Me.btnConvert.Size = New Size(100, 28)
        Me.btnConvert.TabIndex = 0
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        Me.lblInputString.AutoSize = True
        Me.lblInputString.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0)


        Me.lblInputString.Location = New Point(48, 82)

        Me.lblInputString.Margin = New Padding(4, 0, 4, 0)
        Me.lblInputString.Name = "lblInputString"

        Me.lblInputString.Size = New Size(161, 16)
        Me.lblInputString.TabIndex = 1
        Me.lblInputString.Text = "Input Byte Array String"
        Me.tbInputString.Location = New Point(51, 113)

        Me.tbInputString.Margin = New Padding(4)
        Me.tbInputString.Name = "tbInputString"

        Me.tbInputString.Size = New Size(708, 22)
        Me.tbInputString.TabIndex = 2
        Me.lblRevision.AutoSize = True
        Me.lblRevision.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0)

        lblRevision.Location = New Point(48, 170)
        Me.lblRevision.Name = "lblRevision"

        Me.lblRevision.Size = New Size(69, 16)
        Me.lblRevision.TabIndex = 3
        Me.lblRevision.Text = "Revision"

        Me.tbRevision.Location = New Point(123, 168)
        Me.tbRevision.MaxLength = 10
        Me.tbRevision.Name = "tbRevision"

        Me.tbRevision.Size = New Size(30, 22)
        Me.tbRevision.TabIndex = 4
        Me.lblSubIDCount.AutoSize = True
        Me.lblSubIDCount.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Me.lblSubIDCount.Location = New Point(175, 171)
        Me.lblSubIDCount.Name = "lblSubIDCount"

        Me.lblSubIDCount.Size = New Size(97, 16)
        Me.lblSubIDCount.TabIndex = 5
        Me.lblSubIDCount.Text = "Sub ID Count"


        Me.tbSubIDCount.Location = New Point(288, 167)
        Me.tbSubIDCount.Name = "tbSubIDCount"

        Me.tbSubIDCount.Size = New Size(30, 22)
        Me.tbSubIDCount.TabIndex = 6
        Me.lblIdentifierAuthority.AutoSize = True
        Me.lblIdentifierAuthority.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0)


        Me.lblIdentifierAuthority.Location = New Point(373, 171)
        Me.lblIdentifierAuthority.Name = "lblIdentifierAuthority"

        Me.lblIdentifierAuthority.Size = New Size(128, 16)
        Me.lblIdentifierAuthority.TabIndex = 7
        Me.lblIdentifierAuthority.Text = "IdentifierAuthority"


        Me.tbIA1.Location = New Point(520, 168)
        Me.tbIA1.Name = "tbIA1"


        Me.tbIA1.Size = New Size(30, 22)
        Me.tbIA1.TabIndex = 8
        Me.tbIA1.Text = "IA1"

        Me.tbIA2.Location = New Point(564, 168)
        Me.tbIA2.Name = "tbIA2"

        Me.tbIA2.Size = New Size(30, 22)
        Me.tbIA2.TabIndex = 9
        Me.tbIA2.Text = "IA2"

        Me.tbIA3.Location = New Point(608, 167)
        Me.tbIA3.Name = "tbIA3"


        Me.tbIA3.Size = New Size(30, 22)
        Me.tbIA3.TabIndex = 10
        Me.tbIA3.Text = "IA3"

        Me.tbIA4.Location = New Point(652, 168)
        Me.tbIA4.Name = "tbIA4"


        Me.tbIA4.Size = New Size(30, 22)
        Me.tbIA4.TabIndex = 11
        Me.tbIA4.Text = "IA4"


        Me.tbIA5.Location = New Point(696, 168)
        Me.tbIA5.Name = "tbIA5"

        Me.tbIA5.Size = New Size(30, 22)
        Me.tbIA5.TabIndex = 12
        Me.tbIA5.Text = "IA5"

        Me.tbIA6.Location = New Point(740, 168)
        Me.tbIA6.Name = "tbIA6"

        Me.tbIA6.Size = New Size(30, 22)
        Me.tbIA6.TabIndex = 13
        Me.tbIA6.Text = "IA6"
        Me.lblSubID1.AutoSize = True
        Me.lblSubID1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0)

        Me.lblSubID1.Location = New Point(48, 216)
        Me.lblSubID1.Name = "lblSubID1"

        Me.lblSubID1.Size = New Size(66, 16)
        Me.lblSubID1.TabIndex = 14
        Me.lblSubID1.Text = "Sub ID 1"

        Me.tb1ID4.Location = New Point(120, 213)
        Me.tb1ID4.Name = "tb1ID4"

        Me.tb1ID4.Size = New Size(30, 22)
        Me.tb1ID4.TabIndex = 15
        Me.tb1ID4.Text = "ID4"

        Me.tb1ID3.Location = New Point(164, 213)
        Me.tb1ID3.Name = "tb1ID3"

        Me.tb1ID3.Size = New Size(30, 22)
        Me.tb1ID3.TabIndex = 16
        Me.tb1ID3.Text = "ID3"

        Me.tb1ID2.Location = New Point(208, 213)
        Me.tb1ID2.Name = "tb1ID2"

        Me.tb1ID2.Size = New Size(30, 22)
        Me.tb1ID2.TabIndex = 17
        Me.tb1ID2.Text = "ID2"

        Me.tb1ID1.Location = New Point(252, 213)
        Me.tb1ID1.Name = "tb1ID1"

        Me.tb1ID1.Size = New Size(30, 22)
        Me.tb1ID1.TabIndex = 18
        Me.tb1ID1.Text = "ID1"

        Me.tb2ID4.Location = New Point(120, 255)
        Me.tb2ID4.Name = "tb2ID4"

        Me.tb2ID4.Size = New Size(30, 22)
        Me.tb2ID4.TabIndex = 19
        Me.tb2ID4.Text = "ID4"

        Me.tb2ID3.Location = New Point(164, 255)
        Me.tb2ID3.Name = "tb2ID3"

        Me.tb2ID3.Size = New Size(30, 22)
        Me.tb2ID3.TabIndex = 20
        Me.tb2ID3.Text = "ID3"

        Me.tb2ID2.Location = New Point(208, 255)
        Me.tb2ID2.Name = "tb2ID2"

        Me.tb2ID2.Size = New Size(30, 22)
        Me.tb2ID2.TabIndex = 21
        Me.tb2ID2.Text = "ID2"

        Me.tb2ID1.Location = New Point(252, 255)
        Me.tb2ID1.Name = "tb2ID1"

        Me.tb2ID1.Size = New Size(30, 22)
        Me.tb2ID1.TabIndex = 22
        Me.tb2ID1.Text = "ID1"

        Me.tb3ID4.Location = New Point(120, 297)
        Me.tb3ID4.Name = "tb3ID4"

        Me.tb3ID4.Size = New Size(30, 22)
        Me.tb3ID4.TabIndex = 23
        Me.tb3ID4.Text = "ID4"

        Me.tb3ID3.Location = New Point(164, 297)
        Me.tb3ID3.Name = "tb3ID3"

        Me.tb3ID3.Size = New Size(30, 22)
        Me.tb3ID3.TabIndex = 24
        Me.tb3ID3.Text = "ID3"

        Me.tb3ID2.Location = New Point(208, 297)
        Me.tb3ID2.Name = "tb3ID2"

        Me.tb3ID2.Size = New Size(30, 22)
        Me.tb3ID2.TabIndex = 25
        Me.tb3ID2.Text = "ID2"

        Me.tb3ID1.Location = New Point(252, 297)
        Me.tb3ID1.Name = "tb3ID1"

        Me.tb3ID1.Size = New Size(30, 22)
        Me.tb3ID1.TabIndex = 26
        Me.tb3ID1.Text = "ID1"

        Me.tb4ID4.Location = New Point(120, 339)
        Me.tb4ID4.Name = "tb4ID4"

        Me.tb4ID4.Size = New Size(30, 22)
        Me.tb4ID4.TabIndex = 27
        Me.tb4ID4.Text = "ID4"

        Me.tb4ID3.Location = New Point(164, 339)
        Me.tb4ID3.Name = "tb4ID3"

        Me.tb4ID3.Size = New Size(30, 22)
        Me.tb4ID3.TabIndex = 28
        Me.tb4ID3.Text = "ID3"

        Me.tb4ID2.Location = New Point(208, 339)
        Me.tb4ID2.Name = "tb4ID2"

        Me.tb4ID2.Size = New Size(30, 22)
        Me.tb4ID2.TabIndex = 29
        Me.tb4ID2.Text = "ID2"

        Me.tb4ID1.Location = New Point(252, 339)
        Me.tb4ID1.Name = "tb4ID1"

        Me.tb4ID1.Size = New Size(30, 22)
        Me.tb4ID1.TabIndex = 30
        Me.tb4ID1.Text = "ID1"
        Me.lblSubID2.AutoSize = True
        Me.lblSubID2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0)

        Me.lblSubID2.Location = New Point(48, 258)
        Me.lblSubID2.Name = "lblSubID2"

        Me.lblSubID2.Size = New Size(66, 16)
        Me.lblSubID2.TabIndex = 31
        Me.lblSubID2.Text = "Sub ID 2"
        Me.SubID3.AutoSize = True
        Me.SubID3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0)

        Me.SubID3.Location = New Point(48, 300)
        Me.SubID3.Name = "SubID3"

        Me.SubID3.Size = New Size(66, 16)
        Me.SubID3.TabIndex = 32
        Me.SubID3.Text = "Sub ID 3"
        Me.lblSubID4.AutoSize = True
        Me.lblSubID4.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0)

        Me.lblSubID4.Location = New Point(48, 342)
        Me.lblSubID4.Name = "lblSubID4"

        Me.lblSubID4.Size = New Size(66, 16)
        Me.lblSubID4.TabIndex = 33
        Me.lblSubID4.Text = "Sub ID 4"

        Me.tb5ID1.Location = New Point(252, 381)
        Me.tb5ID1.Name = "tb5ID1"

        Me.tb5ID1.Size = New Size(30, 22)
        Me.tb5ID1.TabIndex = 38
        Me.tb5ID1.Text = "ID1"

        Me.tb5ID2.Location = New Point(208, 381)
        Me.tb5ID2.Name = "tb5ID2"

        Me.tb5ID2.Size = New Size(30, 22)
        Me.tb5ID2.TabIndex = 37
        Me.tb5ID2.Text = "ID2"

        Me.tb5ID3.Location = New Point(164, 381)
        Me.tb5ID3.Name = "tb5ID3"

        Me.tb5ID3.Size = New Size(30, 22)
        Me.tb5ID3.TabIndex = 36
        Me.tb5ID3.Text = "ID3"

        Me.tb5ID4.Location = New Point(120, 381)
        Me.tb5ID4.Name = "tb5ID4"

        Me.tb5ID4.Size = New Size(30, 22)
        Me.tb5ID4.TabIndex = 35
        Me.tb5ID4.Text = "ID4"
        Me.lblSubID5.AutoSize = True
        Me.lblSubID5.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0)

        Me.lblSubID5.Location = New Point(48, 384)
        Me.lblSubID5.Name = "lblSubID5"

        Me.lblSubID5.Size = New Size(66, 16)
        Me.lblSubID5.TabIndex = 39
        Me.lblSubID5.Text = "Sub ID 5"
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0)

        Me.lblOutput.Location = New Point(51, 440)
        Me.lblOutput.Name = "lblOutput"

        Me.lblOutput.Size = New Size(125, 16)
        Me.lblOutput.TabIndex = 40
        Me.lblOutput.Text = "Output SID String"
        Me.tbOutputString.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point, 0)

        Me.tbOutputString.Location = New Point(54, 473)
        Me.tbOutputString.Name = "tbOutputString"

        Me.tbOutputString.Size = New Size(705, 26)
        Me.tbOutputString.TabIndex = 41
        Me.lblAbout.AutoSize = True

        Me.lblAbout.Location = New Point(737, 32)
        Me.lblAbout.Name = "lblAbout"

        Me.lblAbout.Size = New Size(43, 16)
        Me.lblAbout.TabIndex = 42
        Me.lblAbout.Text = "About"
        Me.lnklblSelfAdsiorg.AutoSize = True

        Me.lnklblSelfAdsiorg.Location = New Point(605, 38)
        Me.lnklblSelfAdsiorg.Name = "lnklblSelfAdsiorg"

        Me.lnklblSelfAdsiorg.Size = New Size(78, 16)
        Me.lnklblSelfAdsiorg.TabIndex = 43
        Me.lnklblSelfAdsiorg.TabStop = True
        Me.lnklblSelfAdsiorg.Text = "selfadsi.org"
        Me.lblArrayCount.AutoSize = True

        Me.lblArrayCount.Location = New Point(605, 82)
        Me.lblArrayCount.Name = "lblArrayCount"

        Me.lblArrayCount.Size = New Size(93, 16)
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
        Me.Icon = My.Resources.this1

        Me.Margin = New Padding(4)
        Me.Name = "Form1"
        Me.Text = "SID Converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

End Class

