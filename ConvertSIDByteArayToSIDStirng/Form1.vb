Option Strict On

Imports System.Collections.ObjectModel
Imports System.Text

'https://pcsxcetrasupport3.wordpress.com/2011/12/19/converting-a-sid-in-array-of-bytes-to-string-version-in-vb-net/
'https://www.codeproject.com/Articles/303160/Converting-a-SID-in-Array-of-bytes-to-String-versi#_comments
'License: https://www.codeproject.com/info/cpol10.aspx

Public Class Form1

    Private SectionsTextBoxes As List(Of List(Of TextBox))
    Private CommonTextBoxes As List(Of TextBox)

    Private Sub MyInit()

        CommonTextBoxes = New List(Of TextBox) From {
            tbRevision, tbSubIDCount,
            tbIA1, tbIA2, tbIA3, tbIA4, tbIA5, tbIA6
            }

        SectionsTextBoxes = New List(Of List(Of TextBox)) From
            {
            New List(Of TextBox) From {tb1ID1, tb1ID2, tb1ID3, tb1ID4},
            New List(Of TextBox) From {tb2ID1, tb2ID2, tb2ID3, tb2ID4},
            New List(Of TextBox) From {tb3ID1, tb3ID2, tb3ID3, tb3ID4},
            New List(Of TextBox) From {tb4ID1, tb4ID2, tb4ID3, tb4ID4},
            New List(Of TextBox) From {tb5ID1, tb5ID2, tb5ID3, tb5ID4}
            }
    End Sub

    Private Sub btnConvert_Click(sender As System.Object,
             e As System.EventArgs) Handles btnConvert.Click
        Try
            Dim b2Sid = New TransformBytesToSID_pcsxcetrasupport3(tbInputString.Text)

            tbOutputString.Text = b2Sid.SID
            UISections(b2Sid.SectionCount, b2Sid.Bytes)

        Catch ex As TransformBytesToSID_pcsxcetrasupport3.CountTooHigh
            MsgBox(ex.Message,
                   MsgBoxStyle.Information, "Sub ID Count To High")
        Catch ex As Exception
            If String.IsNullOrEmpty(tbInputString.Text) Then
                MsgBox("Please insert the SID to Convert",
                   MsgBoxStyle.Information, "Error, Missing SID")
            Else
                MsgBox(ex.Message, MsgBoxStyle.Information,
                        "Some Kind Of Error Happened")
            End If
        End Try
    End Sub

    Private Sub UISections(sectionCount As Integer, SidByteCol As IList(Of Byte))
        For index = 0 To 7
            CommonTextBoxes(index).Text = SidByteCol(index).ToString()
        Next

        For index = 0 To sectionCount - 1
            SetSectionBox(index, SidByteCol)
        Next

        ' clear remaining section text boxes
        For index = sectionCount To SectionsTextBoxes.Count - 1
            SetTextBoxesToX(SectionsTextBoxes(index))
        Next
    End Sub

    Private Sub SetTextBoxesToX(tbs As List(Of TextBox))
        For Each tb In tbs
            tb.Text = "x"
        Next
    End Sub

    Private Sub SetSectionBox(section As Integer, SidByteCol As IList(Of Byte))
        Dim byteIndex = 8 + (section * 4)
        For i = 0 To 3
            SectionsTextBoxes(section)(i).Text = SidByteCol(byteIndex + i).ToString()
        Next
    End Sub

    Private Sub lblAbout_Click(sender As System.Object,
                 e As System.EventArgs) Handles lblAbout.Click
        AboutBox1.Show()
    End Sub
    Private Sub lnklblSelfAdsiorg_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblSelfAdsiorg.LinkClicked
        Const selfAdsiUrl = "http://www.selfadsi.org/deep-inside/microsoft-sid-attributes.htm"
        Process.Start("Iexplore", selfAdsiUrl)
    End Sub
    Private Sub tbInputString_TextChanged(sender As Object, e As EventArgs) Handles tbInputString.TextChanged
        Try
            tbOutputString.Clear()

            For Each tb In Me.CommonTextBoxes
                tb.Clear()
            Next
            For Each tb In From section In SectionsTextBoxes
                           From tbBox In section Select tbBox
                tb.Clear()
            Next

            Dim SidByteCol = SidHelper.GetSidByteCol(tbInputString.Text)

            Dim colCount As Integer
            colCount = SidByteCol.Count
            If colCount < 2 Then
                Return
            End If
            Dim b1 = SidByteCol(0)         ' Revision Number           1 byte
            Dim b2 = SidByteCol(1)         ' Sub ID Count              1 byte
            lblArrayCount.Text = "SID Length = " & colCount.ToString
            'Below Checks the the proper amount of bytes
            'are present for the given SID Sub Count
            If b2 = 1 And colCount > 12 Then
                MsgBox("Please Double Check your Input String Length" &
                   vbNewLine & "Sub Id Count Should be 1 and Byte count should be 12",
                   MsgBoxStyle.Information, "Input Verification Error 1")

            ElseIf b2 = 2 And colCount > 16 Then
                MsgBox("Please Double Check your Input String Length" & vbNewLine &
                   "Sub Id Count Should be 2 and Byte count should be 16",
                   MsgBoxStyle.Information, "Input Verification Error 2")

            ElseIf b2 = 3 And colCount > 20 Then
                MsgBox("Please Double Check your Input String Length" &
                   vbNewLine & "Sub Id Count Should be 3 and Byte count should be 20",
                   MsgBoxStyle.Information, "Input Verification Error 3")

            ElseIf b2 = 4 And colCount > 24 Then
                MsgBox("Please Double Check your Input String Length" &
                   vbNewLine & "Sub Id Count Should be 4 and Byte count should be 24",
                   MsgBoxStyle.Information, "Input Verification Error 4")

            ElseIf b2 = 5 And colCount > 28 Then
                MsgBox("Please Double Check your Input String Length" &
                  vbNewLine & "Sub Id Count Should be 5 and Byte count should be 28",
                  MsgBoxStyle.Information, "Input Verification Error 5")

            ElseIf colCount > 28 Then
                MsgBox("Please Double Check your Input String Length" &
                  vbNewLine & "Sub Id Count Should be 5 or less " &
                  "and Byte count should be 28 or less",
                  MsgBoxStyle.Information,
                  "Input Verification Error To Many Bytes")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information,
               "Some Error happened while Checking SID Length")
        End Try
    End Sub

End Class