Imports ConvertSIDByteArayToSIDStirng.My

Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Public Class Form1
    Private Sub btnConvert_Click(sender As Object, e As EventArgs)
        ' The following expression was wrapped in a checked-statement
        Try
            Dim text As String = Me.tbInputString.Text
            Dim collection As Collection = New Collection()
            Dim expression As String = text.TrimEnd(New Char() {","c})
            Dim array As String() = Strings.Split(expression, ",", -1, CompareMethod.Binary)
            Dim array2 As String() = array
            For i As Integer = 0 To array2.Length - 1
                Dim item As String = array2(i)
                collection.Add(item, Nothing, Nothing, Nothing)
            Next
            Dim text2 As String = Conversions.ToString(collection(1))
            Dim text3 As String = Conversions.ToString(collection(2))
            If Conversions.ToDouble(text3) = 1.0 Then
                Me.sCount1()
            ElseIf Conversions.ToDouble(text3) = 2.0 Then
                Me.sCount2()
            ElseIf Conversions.ToDouble(text3) = 3.0 Then
                Me.sCount3()
            ElseIf Conversions.ToDouble(text3) = 4.0 Then
                Me.sCount4()
            ElseIf Conversions.ToDouble(text3) = 5.0 Then
                Me.sCount5()
            ElseIf Conversions.ToDouble(text3) > 5.0 Then
                Interaction.MsgBox("This program only works for SID's with 1-5 Sub Authority's" & vbCrLf & "Your Sub ID = " + text3.ToString(), MsgBoxStyle.Information, "Sub ID Count To High")
            End If
        Catch expr_136 As Exception
            ProjectData.SetProjectError(expr_136)
            Dim ex As Exception = expr_136
            If Operators.CompareString(Me.tbInputString.Text, Nothing, False) = 0 Then
                Interaction.MsgBox("Please insert the SID to Convert", MsgBoxStyle.Information, "Error, Missing SID")
            Else
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Information, "Some Kind Of Error Happened")
            End If
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub sCount1()
        Try
            Dim text As String = Me.tbInputString.Text
            Dim collection As Collection = New Collection()
            Dim expression As String = text.TrimEnd(New Char() {","c})
            Dim array As String() = Strings.Split(expression, ",", -1, CompareMethod.Binary)
            Dim array2 As String() = array
            Dim text2 As String
            Dim text5 As String
            Dim text6 As String
            Dim text7 As String
            Dim text8 As String
            Dim text9 As String
            Dim text10 As String
            Dim text11 As String
            Dim text12 As String
            Dim text13 As String
            Dim text14 As String
            ' The following expression was wrapped in a checked-statement
            For i As Integer = 0 To array2.Length - 1
                Dim item As String = array2(i)
                collection.Add(item, Nothing, Nothing, Nothing)
            Next
            text2 = Conversions.ToString(collection(1))
            Dim text3 As String = Conversions.ToString(collection(2))
            Dim text4 As String = Conversions.ToString(collection(3))
            text5 = Conversions.ToString(collection(4))
            text6 = Conversions.ToString(collection(5))
            text7 = Conversions.ToString(collection(6))
            text8 = Conversions.ToString(collection(7))
            text9 = Conversions.ToString(collection(8))
            text10 = Conversions.ToString(collection(9))
            text11 = Conversions.ToString(collection(10))
            text12 = Conversions.ToString(collection(11))
            text13 = Conversions.ToString(collection(12))
            Me.tbRevision.Text = text2
            Me.tbSubIDCount.Text = text3
            Me.tbIA1.Text = text4
            Me.tbIA2.Text = text5
            Me.tbIA3.Text = text6
            Me.tbIA4.Text = text7
            Me.tbIA5.Text = text8
            Me.tbIA6.Text = text9
            Me.tb1ID1.Text = text10
            Me.tb1ID2.Text = text11
            Me.tb1ID3.Text = text12
            Me.tb1ID4.Text = text13
            Me.tb2ID1.Text = "x"
            Me.tb2ID2.Text = "x"
            Me.tb2ID3.Text = "x"
            Me.tb2ID4.Text = "x"
            Me.tb3ID1.Text = "x"
            Me.tb3ID2.Text = "x"
            Me.tb3ID3.Text = "x"
            Me.tb3ID4.Text = "x"
            Me.tb4ID1.Text = "x"
            Me.tb4ID2.Text = "x"
            Me.tb4ID3.Text = "x"
            Me.tb4ID4.Text = "x"
            Me.tb5ID1.Text = "x"
            Me.tb5ID2.Text = "x"
            Me.tb5ID3.Text = "x"
            Me.tb5ID4.Text = "x"
            text14 = text4
            text14 = Conversions.ToString(Conversions.ToDouble(text14) * 256.0 + Conversions.ToDouble(text5))
            text14 = Conversions.ToString(Conversions.ToDouble(text14) * 256.0 + Conversions.ToDouble(text6))
            text14 = Conversions.ToString(Conversions.ToDouble(text14) * 256.0 + Conversions.ToDouble(text7))
            text14 = Conversions.ToString(Conversions.ToDouble(text14) * 256.0 + Conversions.ToDouble(text8))
            text14 = Conversions.ToString(Conversions.ToDouble(text14) * 256.0 + Conversions.ToDouble(text9))
            Dim text15 As String = text13
            text15 = Conversions.ToString(Conversions.ToDouble(text15) * 256.0 + Conversions.ToDouble(text12))
            text15 = Conversions.ToString(Conversions.ToDouble(text15) * 256.0 + Conversions.ToDouble(text11))
            text15 = Conversions.ToString(Conversions.ToDouble(text15) * 256.0 + Conversions.ToDouble(text10))
            Dim text16 As String = String.Concat(New String() {"S-", text2, "-", text14, "-", text15})
            Me.tbOutputString.Text = text16
        Catch expr_404 As Exception
            ProjectData.SetProjectError(expr_404)
            Dim ex As Exception = expr_404
            Interaction.MsgBox(ex.Message, MsgBoxStyle.Information, "Some Kind Of Error Happened")
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub sCount2()
        Try
            Dim text As String = Me.tbInputString.Text
            Dim collection As Collection = New Collection()
            Dim expression As String = text.TrimEnd(New Char() {","c})
            Dim array As String() = Strings.Split(expression, ",", -1, CompareMethod.Binary)
            Dim array2 As String() = array
            Dim text2 As String
            Dim text5 As String
            Dim text6 As String
            Dim text7 As String
            Dim text8 As String
            Dim text9 As String
            Dim text10 As String
            Dim text11 As String
            Dim text12 As String
            Dim text13 As String
            Dim text14 As String
            Dim text15 As String
            Dim text16 As String
            Dim text17 As String
            Dim text18 As String
            ' The following expression was wrapped in a checked-statement
            For i As Integer = 0 To array2.Length - 1
                Dim item As String = array2(i)
                collection.Add(item, Nothing, Nothing, Nothing)
            Next
            text2 = Conversions.ToString(collection(1))
            Dim text3 As String = Conversions.ToString(collection(2))
            Dim text4 As String = Conversions.ToString(collection(3))
            text5 = Conversions.ToString(collection(4))
            text6 = Conversions.ToString(collection(5))
            text7 = Conversions.ToString(collection(6))
            text8 = Conversions.ToString(collection(7))
            text9 = Conversions.ToString(collection(8))
            text10 = Conversions.ToString(collection(9))
            text11 = Conversions.ToString(collection(10))
            text12 = Conversions.ToString(collection(11))
            text13 = Conversions.ToString(collection(12))
            text14 = Conversions.ToString(collection(13))
            text15 = Conversions.ToString(collection(14))
            text16 = Conversions.ToString(collection(15))
            text17 = Conversions.ToString(collection(16))
            Me.tbRevision.Text = text2
            Me.tbSubIDCount.Text = text3
            Me.tbIA1.Text = text4
            Me.tbIA2.Text = text5
            Me.tbIA3.Text = text6
            Me.tbIA4.Text = text7
            Me.tbIA5.Text = text8
            Me.tbIA6.Text = text9
            Me.tb1ID1.Text = text10
            Me.tb1ID2.Text = text11
            Me.tb1ID3.Text = text12
            Me.tb1ID4.Text = text13
            Me.tb2ID1.Text = text14
            Me.tb2ID2.Text = text15
            Me.tb2ID3.Text = text16
            Me.tb2ID4.Text = text17
            Me.tb3ID1.Text = "x"
            Me.tb3ID2.Text = "x"
            Me.tb3ID3.Text = "x"
            Me.tb3ID4.Text = "x"
            Me.tb4ID1.Text = "x"
            Me.tb4ID2.Text = "x"
            Me.tb4ID3.Text = "x"
            Me.tb4ID4.Text = "x"
            Me.tb5ID1.Text = "x"
            Me.tb5ID2.Text = "x"
            Me.tb5ID3.Text = "x"
            Me.tb5ID4.Text = "x"
            text18 = text4
            text18 = Conversions.ToString(Conversions.ToDouble(text18) * 256.0 + Conversions.ToDouble(text5))
            text18 = Conversions.ToString(Conversions.ToDouble(text18) * 256.0 + Conversions.ToDouble(text6))
            text18 = Conversions.ToString(Conversions.ToDouble(text18) * 256.0 + Conversions.ToDouble(text7))
            text18 = Conversions.ToString(Conversions.ToDouble(text18) * 256.0 + Conversions.ToDouble(text8))
            text18 = Conversions.ToString(Conversions.ToDouble(text18) * 256.0 + Conversions.ToDouble(text9))
            Dim text19 As String = text13
            text19 = Conversions.ToString(Conversions.ToDouble(text19) * 256.0 + Conversions.ToDouble(text12))
            text19 = Conversions.ToString(Conversions.ToDouble(text19) * 256.0 + Conversions.ToDouble(text11))
            text19 = Conversions.ToString(Conversions.ToDouble(text19) * 256.0 + Conversions.ToDouble(text10))
            Dim text20 As String = text17
            text20 = Conversions.ToString(Conversions.ToDouble(text20) * 256.0 + Conversions.ToDouble(text16))
            text20 = Conversions.ToString(Conversions.ToDouble(text20) * 256.0 + Conversions.ToDouble(text15))
            text20 = Conversions.ToString(Conversions.ToDouble(text20) * 256.0 + Conversions.ToDouble(text14))
            Dim text21 As String = String.Concat(New String() {"S-", text2, "-", text18, "-", text19, "-", text20})
            Me.tbOutputString.Text = text21
        Catch expr_4AB As Exception
            ProjectData.SetProjectError(expr_4AB)
            Dim ex As Exception = expr_4AB
            Interaction.MsgBox(ex.Message, MsgBoxStyle.Information, "Some Kind Of Error Happened")
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub sCount3()
        Try
            Dim text As String = Me.tbInputString.Text
            Dim collection As Collection = New Collection()
            Dim expression As String = text.TrimEnd(New Char() {","c})
            Dim array As String() = Strings.Split(expression, ",", -1, CompareMethod.Binary)
            Dim array2 As String() = array
            Dim text2 As String
            Dim text5 As String
            Dim text6 As String
            Dim text7 As String
            Dim text8 As String
            Dim text9 As String
            Dim text10 As String
            Dim text11 As String
            Dim text12 As String
            Dim text13 As String
            Dim text14 As String
            Dim text15 As String
            Dim text16 As String
            Dim text17 As String
            Dim text18 As String
            Dim text19 As String
            Dim text20 As String
            Dim text21 As String
            Dim text22 As String
            ' The following expression was wrapped in a checked-statement
            For i As Integer = 0 To array2.Length - 1
                Dim item As String = array2(i)
                collection.Add(item, Nothing, Nothing, Nothing)
            Next
            text2 = Conversions.ToString(collection(1))
            Dim text3 As String = Conversions.ToString(collection(2))
            Dim text4 As String = Conversions.ToString(collection(3))
            text5 = Conversions.ToString(collection(4))
            text6 = Conversions.ToString(collection(5))
            text7 = Conversions.ToString(collection(6))
            text8 = Conversions.ToString(collection(7))
            text9 = Conversions.ToString(collection(8))
            text10 = Conversions.ToString(collection(9))
            text11 = Conversions.ToString(collection(10))
            text12 = Conversions.ToString(collection(11))
            text13 = Conversions.ToString(collection(12))
            text14 = Conversions.ToString(collection(13))
            text15 = Conversions.ToString(collection(14))
            text16 = Conversions.ToString(collection(15))
            text17 = Conversions.ToString(collection(16))
            text18 = Conversions.ToString(collection(17))
            text19 = Conversions.ToString(collection(18))
            text20 = Conversions.ToString(collection(19))
            text21 = Conversions.ToString(collection(20))
            Me.tbRevision.Text = text2
            Me.tbSubIDCount.Text = text3
            Me.tbIA1.Text = text4
            Me.tbIA2.Text = text5
            Me.tbIA3.Text = text6
            Me.tbIA4.Text = text7
            Me.tbIA5.Text = text8
            Me.tbIA6.Text = text9
            Me.tb1ID1.Text = text10
            Me.tb1ID2.Text = text11
            Me.tb1ID3.Text = text12
            Me.tb1ID4.Text = text13
            Me.tb2ID1.Text = text14
            Me.tb2ID2.Text = text15
            Me.tb2ID3.Text = text16
            Me.tb2ID4.Text = text17
            Me.tb3ID1.Text = text18
            Me.tb3ID2.Text = text19
            Me.tb3ID3.Text = text20
            Me.tb3ID4.Text = text21
            Me.tb4ID1.Text = "x"
            Me.tb4ID2.Text = "x"
            Me.tb4ID3.Text = "x"
            Me.tb4ID4.Text = "x"
            Me.tb5ID1.Text = "x"
            Me.tb5ID2.Text = "x"
            Me.tb5ID3.Text = "x"
            Me.tb5ID4.Text = "x"
            text22 = text4
            text22 = Conversions.ToString(Conversions.ToDouble(text22) * 256.0 + Conversions.ToDouble(text5))
            text22 = Conversions.ToString(Conversions.ToDouble(text22) * 256.0 + Conversions.ToDouble(text6))
            text22 = Conversions.ToString(Conversions.ToDouble(text22) * 256.0 + Conversions.ToDouble(text7))
            text22 = Conversions.ToString(Conversions.ToDouble(text22) * 256.0 + Conversions.ToDouble(text8))
            text22 = Conversions.ToString(Conversions.ToDouble(text22) * 256.0 + Conversions.ToDouble(text9))
            Dim text23 As String = text13
            text23 = Conversions.ToString(Conversions.ToDouble(text23) * 256.0 + Conversions.ToDouble(text12))
            text23 = Conversions.ToString(Conversions.ToDouble(text23) * 256.0 + Conversions.ToDouble(text11))
            text23 = Conversions.ToString(Conversions.ToDouble(text23) * 256.0 + Conversions.ToDouble(text10))
            Dim text24 As String = text17
            text24 = Conversions.ToString(Conversions.ToDouble(text24) * 256.0 + Conversions.ToDouble(text16))
            text24 = Conversions.ToString(Conversions.ToDouble(text24) * 256.0 + Conversions.ToDouble(text15))
            text24 = Conversions.ToString(Conversions.ToDouble(text24) * 256.0 + Conversions.ToDouble(text14))
            Dim text25 As String = text21
            text25 = Conversions.ToString(Conversions.ToDouble(text25) * 256.0 + Conversions.ToDouble(text20))
            text25 = Conversions.ToString(Conversions.ToDouble(text25) * 256.0 + Conversions.ToDouble(text19))
            text25 = Conversions.ToString(Conversions.ToDouble(text25) * 256.0 + Conversions.ToDouble(text18))
            Dim text26 As String = String.Concat(New String() {"S-", text2, "-", text22, "-", text23, "-", text24, "-", text25})
            Me.tbOutputString.Text = text26
        Catch expr_554 As Exception
            ProjectData.SetProjectError(expr_554)
            Dim ex As Exception = expr_554
            Interaction.MsgBox(ex.Message, MsgBoxStyle.Information, "Some Kind Of Error Happened")
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub sCount4()
        Try
            Dim text As String = Me.tbInputString.Text
            Dim collection As Collection = New Collection()
            Dim expression As String = text.TrimEnd(New Char() {","c})
            Dim array As String() = Strings.Split(expression, ",", -1, CompareMethod.Binary)
            Dim array2 As String() = array
            Dim text2 As String
            Dim text5 As String
            Dim text6 As String
            Dim text7 As String
            Dim text8 As String
            Dim text9 As String
            Dim text10 As String
            Dim text11 As String
            Dim text12 As String
            Dim text13 As String
            Dim text14 As String
            Dim text15 As String
            Dim text16 As String
            Dim text17 As String
            Dim text18 As String
            Dim text19 As String
            Dim text20 As String
            Dim text21 As String
            Dim text22 As String
            Dim text23 As String
            Dim text24 As String
            Dim text25 As String
            Dim text26 As String
            ' The following expression was wrapped in a checked-statement
            For i As Integer = 0 To array2.Length - 1
                Dim item As String = array2(i)
                collection.Add(item, Nothing, Nothing, Nothing)
            Next
            text2 = Conversions.ToString(collection(1))
            Dim text3 As String = Conversions.ToString(collection(2))
            Dim text4 As String = Conversions.ToString(collection(3))
            text5 = Conversions.ToString(collection(4))
            text6 = Conversions.ToString(collection(5))
            text7 = Conversions.ToString(collection(6))
            text8 = Conversions.ToString(collection(7))
            text9 = Conversions.ToString(collection(8))
            text10 = Conversions.ToString(collection(9))
            text11 = Conversions.ToString(collection(10))
            text12 = Conversions.ToString(collection(11))
            text13 = Conversions.ToString(collection(12))
            text14 = Conversions.ToString(collection(13))
            text15 = Conversions.ToString(collection(14))
            text16 = Conversions.ToString(collection(15))
            text17 = Conversions.ToString(collection(16))
            text18 = Conversions.ToString(collection(17))
            text19 = Conversions.ToString(collection(18))
            text20 = Conversions.ToString(collection(19))
            text21 = Conversions.ToString(collection(20))
            text22 = Conversions.ToString(collection(21))
            text23 = Conversions.ToString(collection(22))
            text24 = Conversions.ToString(collection(23))
            text25 = Conversions.ToString(collection(24))
            Me.tbRevision.Text = text2
            Me.tbSubIDCount.Text = text3
            Me.tbIA1.Text = text4
            Me.tbIA2.Text = text5
            Me.tbIA3.Text = text6
            Me.tbIA4.Text = text7
            Me.tbIA5.Text = text8
            Me.tbIA6.Text = text9
            Me.tb1ID1.Text = text10
            Me.tb1ID2.Text = text11
            Me.tb1ID3.Text = text12
            Me.tb1ID4.Text = text13
            Me.tb2ID1.Text = text14
            Me.tb2ID2.Text = text15
            Me.tb2ID3.Text = text16
            Me.tb2ID4.Text = text17
            Me.tb3ID1.Text = text18
            Me.tb3ID2.Text = text19
            Me.tb3ID3.Text = text20
            Me.tb3ID4.Text = text21
            Me.tb4ID1.Text = text22
            Me.tb4ID2.Text = text23
            Me.tb4ID3.Text = text24
            Me.tb4ID4.Text = text25
            Me.tb5ID1.Text = "x"
            Me.tb5ID2.Text = "x"
            Me.tb5ID3.Text = "x"
            Me.tb5ID4.Text = "x"
            text26 = text4
            text26 = Conversions.ToString(Conversions.ToDouble(text26) * 256.0 + Conversions.ToDouble(text5))
            text26 = Conversions.ToString(Conversions.ToDouble(text26) * 256.0 + Conversions.ToDouble(text6))
            text26 = Conversions.ToString(Conversions.ToDouble(text26) * 256.0 + Conversions.ToDouble(text7))
            text26 = Conversions.ToString(Conversions.ToDouble(text26) * 256.0 + Conversions.ToDouble(text8))
            text26 = Conversions.ToString(Conversions.ToDouble(text26) * 256.0 + Conversions.ToDouble(text9))
            Dim text27 As String = text13
            text27 = Conversions.ToString(Conversions.ToDouble(text27) * 256.0 + Conversions.ToDouble(text12))
            text27 = Conversions.ToString(Conversions.ToDouble(text27) * 256.0 + Conversions.ToDouble(text11))
            text27 = Conversions.ToString(Conversions.ToDouble(text27) * 256.0 + Conversions.ToDouble(text10))
            Dim text28 As String = text17
            text28 = Conversions.ToString(Conversions.ToDouble(text28) * 256.0 + Conversions.ToDouble(text16))
            text28 = Conversions.ToString(Conversions.ToDouble(text28) * 256.0 + Conversions.ToDouble(text15))
            text28 = Conversions.ToString(Conversions.ToDouble(text28) * 256.0 + Conversions.ToDouble(text14))
            Dim text29 As String = text21
            text29 = Conversions.ToString(Conversions.ToDouble(text29) * 256.0 + Conversions.ToDouble(text20))
            text29 = Conversions.ToString(Conversions.ToDouble(text29) * 256.0 + Conversions.ToDouble(text19))
            text29 = Conversions.ToString(Conversions.ToDouble(text29) * 256.0 + Conversions.ToDouble(text18))
            Dim text30 As String = text25
            text30 = Conversions.ToString(Conversions.ToDouble(text30) * 256.0 + Conversions.ToDouble(text24))
            text30 = Conversions.ToString(Conversions.ToDouble(text30) * 256.0 + Conversions.ToDouble(text23))
            text30 = Conversions.ToString(Conversions.ToDouble(text30) * 256.0 + Conversions.ToDouble(text22))
            Dim text31 As String = String.Concat(New String() {"S-", text2, "-", text26, "-", text27, "-", text28, "-", text29, "-", text30})
            Me.tbOutputString.Text = text31
        Catch expr_5FD As Exception
            ProjectData.SetProjectError(expr_5FD)
            Dim ex As Exception = expr_5FD
            Interaction.MsgBox(ex.Message, MsgBoxStyle.Information, "Some Kind Of Error Happened")
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub sCount5()
        Try
            Dim text As String = Me.tbInputString.Text
            Dim collection As Collection = New Collection()
            Dim expression As String = text.TrimEnd(New Char() {","c})
            Dim array As String() = Strings.Split(expression, ",", -1, CompareMethod.Binary)
            Dim array2 As String() = array
            Dim text2 As String
            Dim text5 As String
            Dim text6 As String
            Dim text7 As String
            Dim text8 As String
            Dim text9 As String
            Dim text10 As String
            Dim text11 As String
            Dim text12 As String
            Dim text13 As String
            Dim text14 As String
            Dim text15 As String
            Dim text16 As String
            Dim text17 As String
            Dim text18 As String
            Dim text19 As String
            Dim text20 As String
            Dim text21 As String
            Dim text22 As String
            Dim text23 As String
            Dim text24 As String
            Dim text25 As String
            Dim text26 As String
            Dim text27 As String
            Dim text28 As String
            Dim text29 As String
            Dim text30 As String
            ' The following expression was wrapped in a checked-statement
            For i As Integer = 0 To array2.Length - 1
                Dim item As String = array2(i)
                collection.Add(item, Nothing, Nothing, Nothing)
            Next
            text2 = Conversions.ToString(collection(1))
            Dim text3 As String = Conversions.ToString(collection(2))
            Dim text4 As String = Conversions.ToString(collection(3))
            text5 = Conversions.ToString(collection(4))
            text6 = Conversions.ToString(collection(5))
            text7 = Conversions.ToString(collection(6))
            text8 = Conversions.ToString(collection(7))
            text9 = Conversions.ToString(collection(8))
            text10 = Conversions.ToString(collection(9))
            text11 = Conversions.ToString(collection(10))
            text12 = Conversions.ToString(collection(11))
            text13 = Conversions.ToString(collection(12))
            text14 = Conversions.ToString(collection(13))
            text15 = Conversions.ToString(collection(14))
            text16 = Conversions.ToString(collection(15))
            text17 = Conversions.ToString(collection(16))
            text18 = Conversions.ToString(collection(17))
            text19 = Conversions.ToString(collection(18))
            text20 = Conversions.ToString(collection(19))
            text21 = Conversions.ToString(collection(20))
            text22 = Conversions.ToString(collection(21))
            text23 = Conversions.ToString(collection(22))
            text24 = Conversions.ToString(collection(23))
            text25 = Conversions.ToString(collection(24))
            text26 = Conversions.ToString(collection(25))
            text27 = Conversions.ToString(collection(26))
            text28 = Conversions.ToString(collection(27))
            text29 = Conversions.ToString(collection(28))
            Me.tbRevision.Text = text2
            Me.tbSubIDCount.Text = text3
            Me.tbIA1.Text = text4
            Me.tbIA2.Text = text5
            Me.tbIA3.Text = text6
            Me.tbIA4.Text = text7
            Me.tbIA5.Text = text8
            Me.tbIA6.Text = text9
            Me.tb1ID1.Text = text10
            Me.tb1ID2.Text = text11
            Me.tb1ID3.Text = text12
            Me.tb1ID4.Text = text13
            Me.tb2ID1.Text = text14
            Me.tb2ID2.Text = text15
            Me.tb2ID3.Text = text16
            Me.tb2ID4.Text = text17
            Me.tb3ID1.Text = text18
            Me.tb3ID2.Text = text19
            Me.tb3ID3.Text = text20
            Me.tb3ID4.Text = text21
            Me.tb4ID1.Text = text22
            Me.tb4ID2.Text = text23
            Me.tb4ID3.Text = text24
            Me.tb4ID4.Text = text25
            Me.tb5ID1.Text = text26
            Me.tb5ID2.Text = text27
            Me.tb5ID3.Text = text28
            Me.tb5ID4.Text = text29
            text30 = text4
            text30 = Conversions.ToString(Conversions.ToDouble(text30) * 256.0 + Conversions.ToDouble(text5))
            text30 = Conversions.ToString(Conversions.ToDouble(text30) * 256.0 + Conversions.ToDouble(text6))
            text30 = Conversions.ToString(Conversions.ToDouble(text30) * 256.0 + Conversions.ToDouble(text7))
            text30 = Conversions.ToString(Conversions.ToDouble(text30) * 256.0 + Conversions.ToDouble(text8))
            text30 = Conversions.ToString(Conversions.ToDouble(text30) * 256.0 + Conversions.ToDouble(text9))
            Dim text31 As String = text13
            text31 = Conversions.ToString(Conversions.ToDouble(text31) * 256.0 + Conversions.ToDouble(text12))
            text31 = Conversions.ToString(Conversions.ToDouble(text31) * 256.0 + Conversions.ToDouble(text11))
            text31 = Conversions.ToString(Conversions.ToDouble(text31) * 256.0 + Conversions.ToDouble(text10))
            Dim text32 As String = text17
            text32 = Conversions.ToString(Conversions.ToDouble(text32) * 256.0 + Conversions.ToDouble(text16))
            text32 = Conversions.ToString(Conversions.ToDouble(text32) * 256.0 + Conversions.ToDouble(text15))
            text32 = Conversions.ToString(Conversions.ToDouble(text32) * 256.0 + Conversions.ToDouble(text14))
            Dim text33 As String = text21
            text33 = Conversions.ToString(Conversions.ToDouble(text33) * 256.0 + Conversions.ToDouble(text20))
            text33 = Conversions.ToString(Conversions.ToDouble(text33) * 256.0 + Conversions.ToDouble(text19))
            text33 = Conversions.ToString(Conversions.ToDouble(text33) * 256.0 + Conversions.ToDouble(text18))
            Dim text34 As String = text25
            text34 = Conversions.ToString(Conversions.ToDouble(text34) * 256.0 + Conversions.ToDouble(text24))
            text34 = Conversions.ToString(Conversions.ToDouble(text34) * 256.0 + Conversions.ToDouble(text23))
            text34 = Conversions.ToString(Conversions.ToDouble(text34) * 256.0 + Conversions.ToDouble(text22))
            Dim text35 As String = text29
            text35 = Conversions.ToString(Conversions.ToDouble(text35) * 256.0 + Conversions.ToDouble(text28))
            text35 = Conversions.ToString(Conversions.ToDouble(text35) * 256.0 + Conversions.ToDouble(text27))
            text35 = Conversions.ToString(Conversions.ToDouble(text35) * 256.0 + Conversions.ToDouble(text26))
            Dim text36 As String = String.Concat(New String() {"S-", text2, "-", text30, "-", text31, "-", text32, "-", text33, "-", text34, "-", text35})
            Me.tbOutputString.Text = text36
        Catch expr_6A6 As Exception
            ProjectData.SetProjectError(expr_6A6)
            Dim ex As Exception = expr_6A6
            Interaction.MsgBox(ex.Message, MsgBoxStyle.Information, "Some Kind Of Error Happened")
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub lblAbout_Click(sender As Object, e As EventArgs)
        MyProject.Forms.AboutBox1.Show()
    End Sub

    Private Sub lnklblSelfAdsiorg_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Process.Start("Iexplore", "http://www.selfadsi.org/deep-inside/microsoft-sid-attributes.htm")
    End Sub

    Private Sub tbInputString_TextChanged(sender As Object, e As EventArgs)
        ' The following expression was wrapped in a checked-statement
        Try
            Me.tbOutputString.Clear()
            Me.tbRevision.Clear()
            Me.tbSubIDCount.Clear()
            Me.tbIA1.Clear()
            Me.tbIA2.Clear()
            Me.tbIA3.Clear()
            Me.tbIA4.Clear()
            Me.tbIA5.Clear()
            Me.tbIA6.Clear()
            Me.tb1ID1.Clear()
            Me.tb1ID2.Clear()
            Me.tb1ID3.Clear()
            Me.tb1ID4.Clear()
            Me.tb2ID1.Clear()
            Me.tb2ID2.Clear()
            Me.tb2ID3.Clear()
            Me.tb2ID4.Clear()
            Me.tb3ID1.Clear()
            Me.tb3ID2.Clear()
            Me.tb3ID3.Clear()
            Me.tb3ID4.Clear()
            Me.tb4ID1.Clear()
            Me.tb4ID2.Clear()
            Me.tb4ID3.Clear()
            Me.tb4ID4.Clear()
            Me.tb5ID1.Clear()
            Me.tb5ID2.Clear()
            Me.tb5ID3.Clear()
            Me.tb5ID4.Clear()
            Dim text As String = Me.tbInputString.Text
            Dim collection As Collection = New Collection()
            Dim expression As String = text.TrimEnd(New Char() {","c})
            Dim array As String() = Strings.Split(expression, ",", -1, CompareMethod.Binary)
            Dim array2 As String() = array
            For i As Integer = 0 To array2.Length - 1
                Dim item As String = array2(i)
                collection.Add(item, Nothing, Nothing, Nothing)
            Next
            Dim count As Integer = collection.Count
            Dim text2 As String = Conversions.ToString(collection(1))
            Dim value As String = Conversions.ToString(collection(2))
            Me.lblArrayCount.Text = "SID Length = " + count.ToString()
            If Conversions.ToDouble(value) = 1.0 And count <> 12 Then
                Interaction.MsgBox("Please Double Check your Input String Length" & vbCrLf & "Sub Id Count Should be 1 and Byte count should be 12", MsgBoxStyle.Information, "Input Verification Error 1")
            ElseIf Conversions.ToDouble(value) = 2.0 And count <> 16 Then
                Interaction.MsgBox("Please Double Check your Input String Length" & vbCrLf & "Sub Id Count Should be 2 and Byte count should be 16", MsgBoxStyle.Information, "Input Verification Error 2")
            ElseIf Conversions.ToDouble(value) = 3.0 And count <> 20 Then
                Interaction.MsgBox("Please Double Check your Input String Length" & vbCrLf & "Sub Id Count Should be 3 and Byte count should be 20", MsgBoxStyle.Information, "Input Verification Error 3")
            ElseIf Conversions.ToDouble(value) = 4.0 And count <> 24 Then
                Interaction.MsgBox("Please Double Check your Input String Length" & vbCrLf & "Sub Id Count Should be 4 and Byte count should be 24", MsgBoxStyle.Information, "Input Verification Error 4")
            ElseIf Conversions.ToDouble(value) = 5.0 And count <> 28 Then
                Interaction.MsgBox("Please Double Check your Input String Length" & vbCrLf & "Sub Id Count Should be 5 and Byte count should be 28", MsgBoxStyle.Information, "Input Verification Error 5")
            ElseIf count > 28 Then
                Interaction.MsgBox("Please Double Check your Input String Length" & vbCrLf & "Sub Id Count Should be 5 or less and Byte count should be 28 or less", MsgBoxStyle.Information, "Input Verification Error To Many Bytes")
            End If
        Catch expr_2F6 As Exception
            ProjectData.SetProjectError(expr_2F6)
            Dim ex As Exception = expr_2F6
            Interaction.MsgBox(ex.Message, MsgBoxStyle.Information, "Some Error happened while Checking SID Length")
            ProjectData.ClearProjectError()
        End Try
    End Sub

End Class
