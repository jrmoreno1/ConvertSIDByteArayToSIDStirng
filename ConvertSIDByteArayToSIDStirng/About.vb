Imports System.IO

Imports ConvertSIDByteArayToSIDStirng.My


'https://www.codeproject.com/Articles/303160/Converting-a-SID-in-Array-of-bytes-to-String-versi#_comments
'License: https://www.codeproject.com/info/cpol10.aspx

'1,5,0,0,0,0,0,5,21,0,0,0,213,142,2,34,86,100,158,107,112,120,52,41,246,3,0,0
'1,2,0,0,0,0,0,5,32,0,0,0,32,2,0,0
Partial Public Class AboutBox1

    Private Sub AboutBox1_Load(sender As Object, e As EventArgs)
        Dim arg As String
        If MyProject.Application.Info.Title <> "" Then
            arg = MyProject.Application.Info.Title
        Else
            arg = Path.GetFileNameWithoutExtension(MyProject.Application.Info.AssemblyName)
        End If
        Me.Text = $"About {arg}"
        Me.LabelProductName.Text = MyProject.Application.Info.ProductName
        Me.LabelVersion.Text = $"Version {MyProject.Application.Info.Version.ToString()}"
        Me.LabelCopyright.Text = MyProject.Application.Info.Copyright
        Me.LabelCompanyName.Text = MyProject.Application.Info.CompanyName
        Me.TextBoxDescription.Text = MyProject.Application.Info.Description
    End Sub


    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub
End Class