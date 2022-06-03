Option Strict On

Imports System.Collections.ObjectModel
Imports System.Text

'https://www.codeproject.com/Articles/303160/Converting-a-SID-in-Array-of-bytes-to-String-versi#_comments
'License: https://www.codeproject.com/info/cpol10.aspx

'1,5,0,0,0,0,0,5,21,0,0,0,213,142,2,34,86,100,158,107,112,120,52,41,246,3,0,0 
'S-1-5-21-570592981-1805542486-691304560-1014

'1,5,0,255,255,255,255,255,21,0,0,0,213,142,2,34,86,100,158,107,112,120,52,41,246,3,0,0 
'S-1-1099511627775-21-570592981-1805542486-691304560-1014

'1,2,0,0,0,0,0,5,32,0,0,0,32,2,0,0
'S-1-5-32-544

'1,2,0,0,0,0,0,5,32,0,0,0,34,2,0,0
'S-1-5-32-546

Public Class Form1

    Private Sub btnConvert_Click(ByVal sender As System.Object,
            ByVal e As System.EventArgs) Handles btnConvert.Click

        Try
            Dim SidByteCol = GetSidByteCol()

            Dim b1 = SidByteCol(0)         ' Revision Number           1 byte (should always be 1)
            Dim b2 = SidByteCol(1)         ' Sub ID Count              1 byte
            If b2 = 1 Then
                tbOutputString.Text = sCount1(SidByteCol, AddressOf UICount1)
            ElseIf b2 = 2 Then
                tbOutputString.Text = sCount2(SidByteCol, AddressOf UICount2)
            ElseIf b2 = 3 Then
                tbOutputString.Text = sCount3(SidByteCol, AddressOf UICount3)
            ElseIf b2 = 4 Then
                tbOutputString.Text = sCount4(SidByteCol, AddressOf UICount4)
            ElseIf b2 = 5 Then
                tbOutputString.Text = sCount5(SidByteCol, AddressOf UICount5)
            ElseIf b2 > 5 Then
                MsgBox("This program only works for " &
               "SID's with 1-5 Sub Authority's" & vbNewLine &
               "Your Sub ID = " & b2.ToString,
               MsgBoxStyle.Information, "Sub ID Count To High")
            End If
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
    Private Function sCount1(SidByteCol As ICollection(Of Byte), updateUI As Action(Of ICollection(Of Byte))) As String
        Try
            updateUI?.Invoke(SidByteCol)

            Dim b1 As Double = SidByteCol(0)         ' Revision Number           1 byte
            Dim strIAMath = GetStrIaMath(SidByteCol)
            Dim Sub1Math = GetSub1Math(SidByteCol)

            Return $"S-{b1}-{strIAMath}-{Sub1Math}"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Some Kind Of Error Happened")
        End Try
        Return ""
    End Function

    Private Sub UICount1(SidByteCol As ICollection(Of Byte))
        SetBoxesSub1(SidByteCol)

        ClearBoxesSub2()
        ClearBoxesSub3()
        ClearBoxesSub4()
        ClearBoxesSub5()
    End Sub

    Private Sub ClearBoxesSub2()

        ' Text boxes Sub 2
        tb2ID1.Text = "x"
        tb2ID2.Text = "x"
        tb2ID3.Text = "x"
        tb2ID4.Text = "x"
    End Sub

    Private Function sCount2(SidByteCol As ICollection(Of Byte), updateUI As Action(Of ICollection(Of Byte))) As String
        Try
            updateUI?.Invoke(SidByteCol)

            Dim b1 As Double = SidByteCol(0)         ' Revision Number           1 byte
            Dim strIAMath = GetStrIaMath(SidByteCol)
            Dim Sub1Math = GetSub1Math(SidByteCol)
            Dim Sub2Math = GetSub2Math(SidByteCol)

            Return $"S-{b1}-{strIAMath}-{Sub1Math}-{Sub2Math}"

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Some Kind Of Error Happened")
        End Try

        Return ""
    End Function

    Private Sub UICount2(SidByteCol As ICollection(Of Byte))

        SetBoxesSub1(SidByteCol)

        SetBoxesSub2(SidByteCol)

        ClearBoxesSub3()
        ClearBoxesSub4()
        ClearBoxesSub5()

    End Sub

    Private Sub ClearBoxesSub3()

        ' Text boxes Sub 3
        tb3ID1.Text = "x"
        tb3ID2.Text = "x"
        tb3ID3.Text = "x"
        tb3ID4.Text = "x"
    End Sub

    Private Sub ClearBoxesSub4()

        ' Text boxes Sub 4
        tb4ID1.Text = "x"
        tb4ID2.Text = "x"
        tb4ID3.Text = "x"
        tb4ID4.Text = "x"
    End Sub

    Private Function sCount3(SidByteCol As ICollection(Of Byte), updateUI As Action(Of ICollection(Of Byte))) As String
        Try
            updateUI?.Invoke(SidByteCol)

            Dim b1 As Double = SidByteCol(0)         ' Revision Number           1 byte
            Dim strIAMath = GetStrIaMath(SidByteCol)
            Dim Sub1Math = GetSub1Math(SidByteCol)
            Dim Sub2Math = GetSub2Math(SidByteCol)
            Dim Sub3Math = GetSub3Math(SidByteCol)

            Return $"S-{b1}-{strIAMath}-{Sub1Math}-{Sub2Math}-{Sub3Math}"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Some Kind Of Error Happened")
        End Try
        Return ""
    End Function

    Private Sub UICount3(SidByteCol As ICollection(Of Byte))
        SetBoxesSub1(SidByteCol)

        SetBoxesSub2(SidByteCol)
        SetBoxesSub3(SidByteCol)

        ClearBoxesSub4()
        ClearBoxesSub5()
    End Sub

    Private Function sCount4(SidByteCol As ICollection(Of Byte), updateUI As Action(Of ICollection(Of Byte))) As String
        Try
            updateUI?.Invoke(SidByteCol)

            Dim b1 As Double = SidByteCol(0)         ' Revision Number           1 byte     
            Dim strIAMath = GetStrIaMath(SidByteCol)
            Dim Sub1Math = GetSub1Math(SidByteCol)
            Dim Sub2Math = GetSub2Math(SidByteCol)
            Dim Sub3Math = GetSub3Math(SidByteCol)
            Dim Sub4Math = GetSub4Math(SidByteCol)

            Return $"S-{b1}-{strIAMath}-{Sub1Math}-{Sub2Math}-{Sub3Math}-{Sub4Math}"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Some Kind Of Error Happened")
        End Try
        Return ""
    End Function

    Private Sub UICount4(SidByteCol As ICollection(Of Byte))
        SetBoxesSub1(SidByteCol)

        SetBoxesSub2(SidByteCol)
        SetBoxesSub3(SidByteCol)
        SetBoxesSub4(SidByteCol)
        ClearBoxesSub5()
    End Sub

    Private Sub ClearBoxesSub5()

        ' Text boxes Sub 5
        tb5ID1.Text = "x"
        tb5ID2.Text = "x"
        tb5ID3.Text = "x"
        tb5ID4.Text = "x" 'IA Math
    End Sub

    Private Function sCount5(SidByteCol As ICollection(Of Byte), updateUI As Action(Of ICollection(Of Byte))) As String
        Try
            updateUI?.Invoke(SidByteCol)

            Dim b1 As Double = SidByteCol(0)         ' Revision Number           1 byte
            Dim strIAMath = GetStrIaMath(SidByteCol)
            Dim Sub1Math = GetSub1Math(SidByteCol)
            Dim Sub2Math = GetSub2Math(SidByteCol)
            Dim Sub3Math = GetSub3Math(SidByteCol)
            Dim Sub4Math = GetSub4Math(SidByteCol)
            Dim sub5Math = GetSub5Math(SidByteCol)

            Return $"S-{b1}-{strIAMath}-{Sub1Math}-{Sub2Math}-{Sub3Math}-{Sub4Math}-{sub5Math}"

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Some Kind Of Error Happened")
        End Try
        Return ""
    End Function

    Private Function GetSub5Math(SidByteCol As ICollection(Of Byte)) As Double

        Dim sub5Math As Double
        sub5Math = SidByteCol(27)                      ' Starts From The Right
        sub5Math = sub5Math * 256 + SidByteCol(26)
        sub5Math = sub5Math * 256 + SidByteCol(25)
        sub5Math = sub5Math * 256 + SidByteCol(24)
        Return sub5Math
    End Function

    Private Function GetSub4Math(SidByteCol As ICollection(Of Byte)) As Double

        Dim Sub4Math As Double
        Sub4Math = SidByteCol(23)                     ' Starts From The Right
        Sub4Math = Sub4Math * 256 + SidByteCol(22)
        Sub4Math = Sub4Math * 256 + SidByteCol(21)
        Sub4Math = Sub4Math * 256 + SidByteCol(20)
        Return Sub4Math
    End Function

    Private Function GetSub3Math(SidByteCol As ICollection(Of Byte)) As Double

        Dim Sub3Math As Double
        Sub3Math = SidByteCol(19)                     ' Starts From The Right
        Sub3Math = Sub3Math * 256 + SidByteCol(18)
        Sub3Math = Sub3Math * 256 + SidByteCol(17)
        Sub3Math = Sub3Math * 256 + SidByteCol(16)
        Return Sub3Math
    End Function

    Private Function GetSub2Math(SidByteCol As ICollection(Of Byte)) As Double

        Dim Sub2Math As Double
        Sub2Math = SidByteCol(15)                     ' Starts From The Right
        Sub2Math = (Sub2Math * 256) + SidByteCol(14)
        Sub2Math = (Sub2Math * 256) + SidByteCol(13)
        Sub2Math = (Sub2Math * 256) + SidByteCol(12)   ' Sub Authority 2           4 bytes
        Return Sub2Math
    End Function

    Private Function GetSub1Math(SidByteCol As ICollection(Of Byte)) As Double

        Dim Sub1Math As Double
        Sub1Math = SidByteCol(11)                      ' Starts From The Right
        Sub1Math = (Sub1Math * 256) + SidByteCol(10)
        Sub1Math = (Sub1Math * 256) + SidByteCol(9)
        Sub1Math = (Sub1Math * 256) + SidByteCol(8)    ' Sub Authority 1           4 bytes (8,9,10,11)  
        Return Sub1Math
    End Function

    Private Function GetStrIaMath(SidByteCol As ICollection(Of Byte)) As Double
        'IA Math
        Dim strIAMath As Double
        strIAMath = SidByteCol(2)
        strIAMath = strIAMath * 256 + SidByteCol(3) '65792
        strIAMath = strIAMath * 256 + SidByteCol(4) '16843008
        strIAMath = strIAMath * 256 + SidByteCol(5) '4311810304
        strIAMath = strIAMath * 256 + SidByteCol(6)
        strIAMath = strIAMath * 256 + SidByteCol(7) ' 6 'Start Sub 1
        Return strIAMath
    End Function

    Private Sub UICount5(SidByteCol As ICollection(Of Byte))
        SetBoxesSub1(SidByteCol)
        SetBoxesSub2(SidByteCol)
        SetBoxesSub3(SidByteCol)
        SetBoxesSub4(SidByteCol)
        SetBoxesSub5(SidByteCol)

        'Sub ID Count = 5 then All 28 Bytes will be used.
    End Sub

    Private Sub SetBoxesSub5(SidByteCol As ICollection(Of Byte))

        ' Text boxes Sub 5
        tb5ID1.Text = SidByteCol(24).ToString()
        tb5ID2.Text = SidByteCol(25).ToString()
        tb5ID3.Text = SidByteCol(26).ToString()
        tb5ID4.Text = SidByteCol(27).ToString()
    End Sub

    Private Sub SetBoxesSub4(SidByteCol As ICollection(Of Byte))

        ' Text boxes Sub 4
        tb4ID1.Text = SidByteCol(20).ToString()
        tb4ID2.Text = SidByteCol(21).ToString()
        tb4ID3.Text = SidByteCol(22).ToString()
        tb4ID4.Text = SidByteCol(23).ToString()
    End Sub

    Private Sub SetBoxesSub3(SidByteCol As ICollection(Of Byte))

        ' Text boxes Sub 3
        tb3ID1.Text = SidByteCol(16).ToString()
        tb3ID2.Text = SidByteCol(17).ToString()
        tb3ID3.Text = SidByteCol(18).ToString()
        tb3ID4.Text = SidByteCol(19).ToString()
    End Sub

    Private Sub SetBoxesSub2(SidByteCol As ICollection(Of Byte))

        ' Text boxes Sub 2
        tb2ID1.Text = SidByteCol(12).ToString()
        tb2ID2.Text = SidByteCol(13).ToString()
        tb2ID3.Text = SidByteCol(14).ToString()
        tb2ID4.Text = SidByteCol(15).ToString()
    End Sub

    Private Sub SetBoxesSub1(SidByteCol As ICollection(Of Byte))

        tbRevision.Text = SidByteCol(0).ToString()
        tbSubIDCount.Text = SidByteCol(1).ToString()
        'Text boxes SID_IDENTIFIER_AUTHORITY
        tbIA1.Text = SidByteCol(2).ToString()
        tbIA2.Text = SidByteCol(3).ToString()
        tbIA3.Text = SidByteCol(4).ToString()
        tbIA4.Text = SidByteCol(5).ToString()
        tbIA5.Text = SidByteCol(6).ToString()
        tbIA6.Text = SidByteCol(7).ToString()
        'Text boxes sub 1
        tb1ID1.Text = SidByteCol(8).ToString()
        tb1ID2.Text = SidByteCol(9).ToString()
        tb1ID3.Text = SidByteCol(10).ToString()
        tb1ID4.Text = SidByteCol(11).ToString()
    End Sub

    Private Sub lblAbout_Click(sender As System.Object,
                 e As System.EventArgs) Handles lblAbout.Click
        AboutBox1.Show()
    End Sub
    Private Sub lnklblSelfAdsiorg_LinkClicked(sender As System.Object,
             e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnklblSelfAdsiorg.LinkClicked
        Process.Start("Iexplore",
          "http://www.selfadsi.org/deep-inside/microsoft-sid-attributes.htm")
    End Sub
    Private Sub tbInputString_TextChanged(sender As System.Object,
             e As System.EventArgs) Handles tbInputString.TextChanged
        Try
            tbOutputString.Clear()
            tbRevision.Clear()
            tbSubIDCount.Clear()

            tbIA1.Clear()
            tbIA2.Clear()
            tbIA3.Clear()
            tbIA4.Clear()
            tbIA5.Clear()
            tbIA6.Clear()
            'Text boxes sub 1            tb1ID1.Clear()
            tb1ID2.Clear()
            tb1ID3.Clear()
            tb1ID4.Clear()

            ' Text boxes Sub 2            tb2ID1.Clear()
            tb2ID2.Clear()
            tb2ID3.Clear()
            tb2ID4.Clear()
            ' Text boxes Sub 3            tb3ID1.Clear()
            tb3ID2.Clear()
            tb3ID3.Clear()
            tb3ID4.Clear()
            ' Text boxes Sub 4            tb4ID1.Clear()
            tb4ID2.Clear()
            tb4ID3.Clear()
            tb4ID4.Clear()
            ' Tex boxes Sub 5            tb5ID1.Clear()
            tb5ID2.Clear()
            tb5ID3.Clear()
            tb5ID4.Clear()

            Dim b1, b2 As Double
            Dim SidByteCol = GetSidByteCol()

            Dim colcnt As Integer
            colcnt = SidByteCol.Count
            b1 = SidByteCol(0)         ' Revision Number           1 byte
            b2 = SidByteCol(1)         ' Sub ID Count              1 byte
            lblArrayCount.Text = "SID Length = " & colcnt.ToString
            'Below Checks the the proper amount of bytes
            'are present for the given SID Sub Count
            If b2 = 1 And colcnt <> 12 Then
                MsgBox("Please Double Check your Input String Length" &
                   vbNewLine & "Sub Id Count Should be 1 and Byte count should be 12",
                   MsgBoxStyle.Information, "Input Verification Error 1")

            ElseIf b2 = 2 And colcnt <> 16 Then
                MsgBox("Please Double Check your Input String Length" & vbNewLine &
                   "Sub Id Count Should be 2 and Byte count should be 16",
                   MsgBoxStyle.Information, "Input Verification Error 2")

            ElseIf b2 = 3 And colcnt <> 20 Then
                MsgBox("Please Double Check your Input String Length" &
                   vbNewLine & "Sub Id Count Should be 3 and Byte count should be 20",
                   MsgBoxStyle.Information, "Input Verification Error 3")

            ElseIf b2 = 4 And colcnt <> 24 Then
                MsgBox("Please Double Check your Input String Length" &
                   vbNewLine & "Sub Id Count Should be 4 and Byte count should be 24",
                   MsgBoxStyle.Information, "Input Verification Error 4")

            ElseIf b2 = 5 And colcnt <> 28 Then
                MsgBox("Please Double Check your Input String Length" &
                  vbNewLine & "Sub Id Count Should be 5 and Byte count should be 28",
                  MsgBoxStyle.Information, "Input Verification Error 5")

            ElseIf colcnt > 28 Then
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

    Private Function GetSidByteCol() As ICollection(Of Byte)

        Dim RawSid As String
        RawSid = tbInputString.Text.Replace(" ", "")
        Dim SidByteCol As New Collection(Of Byte)
        Dim TrmdRawSID As String = RawSid.TrimEnd(","c)
        Dim stary() As String = Split(TrmdRawSID, ",", -1)

        For Each strByte In stary
            SidByteCol.Add(CByte(strByte))
        Next
        Return SidByteCol
    End Function
End Class