Option Strict On

Imports System.Collections.ObjectModel
Imports System.Text

'https://www.codeproject.com/Articles/303160/Converting-a-SID-in-Array-of-bytes-to-String-versi#_comments
'License: https://www.codeproject.com/info/cpol10.aspx

'1,5,0,0,0,0,0,5,21,0,0,0,213,142,2,34,86,100,158,107,112,120,52,41,246,3,0,0 
'S-1-5-21-570592981-1805542486-691304560-1014

'1,2,0,0,0,0,0,5,32,0,0,0,32,2,0,0
'S-1-5-32-544

Public Class Form1

    Private Sub btnConvert_Click(ByVal sender As System.Object,
            ByVal e As System.EventArgs) Handles btnConvert.Click

        Try
            Dim RawSid As String
            RawSid = tbInputString.Text.Replace(" ", "")
            Dim SidStrCol As New Collection(Of Byte)
            Dim TrmdRawSID As String = RawSid.TrimEnd(","c)
            Dim stary() As String = Split(TrmdRawSID, ",", -1)

            For Each strByte In stary
                SidStrCol.Add(CByte(strByte))
            Next

            Dim b1 = SidStrCol(0)         ' Revision Number           1 byte
            Dim b2 = SidStrCol(1)         ' Sub ID Count              1 byte
            If b2 = 1 Then
                tbOutputString.Text = sCount1(SidStrCol, AddressOf UICount1)
            ElseIf b2 = 2 Then
                tbOutputString.Text = sCount2(SidStrCol, AddressOf UICount2)
            ElseIf b2 = 3 Then
                tbOutputString.Text = sCount3(SidStrCol, AddressOf UICount3)
            ElseIf b2 = 4 Then
                tbOutputString.Text = sCount4(SidStrCol, AddressOf UICount4)
            ElseIf b2 = 5 Then
                tbOutputString.Text = sCount5(SidStrCol, AddressOf UICount5)
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
    Private Function sCount1(SidStrCol As ICollection(Of Byte), updateUI As Action(Of ICollection(Of Byte))) As String
        Try
            Dim b1, b2, b3, b4, b5, b6, b7, b8, b9, b10, b11, b12 As Double


            b1 = SidStrCol(0)         ' Revision Number           1 byte
            b2 = SidStrCol(1)         ' Sub ID Count              1 byte ' Satrt Auth.
            b3 = SidStrCol(2)         ' SID_IDENTIFIER_AUTHORITY  6 bytes
            b4 = SidStrCol(3)         ' 2
            b5 = SidStrCol(4)         ' 3
            b6 = SidStrCol(5)         ' 4
            b7 = SidStrCol(6)         ' 5
            b8 = SidStrCol(7)         ' 6 'Start Sub 1
            b9 = SidStrCol(8)         ' Sub Authority 1           4 bytes
            b10 = SidStrCol(9)       ' 2
            b11 = SidStrCol(10)       ' 3
            b12 = SidStrCol(11)

            updateUI?.Invoke(SidStrCol)

            ' 4
            ' Everything before here is the minimum that will go in
            ' Will need to check the sub id count after this.      

            Dim strIAMath As Double
            strIAMath = b3
            strIAMath = strIAMath * 256 + b4
            strIAMath = strIAMath * 256 + b5
            strIAMath = strIAMath * 256 + b6
            strIAMath = strIAMath * 256 + b7
            strIAMath = strIAMath * 256 + b8

            Dim Sub1Math As Double
            Sub1Math = b12                      ' Starts From The Right
            Sub1Math = (Sub1Math * 256) + b11
            Sub1Math = (Sub1Math * 256) + b10
            Sub1Math = (Sub1Math * 256) + b9

            Dim OutputString As String

            OutputString = ("S-" & b1 & "-" & strIAMath & "-" & Sub1Math)

            Return OutputString
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Some Kind Of Error Happened")
        End Try
        Return ""
    End Function

    Private Sub UICount1(SidStrCol As ICollection(Of Byte))
        tbRevision.Text = SidStrCol(0).ToString()
        tbSubIDCount.Text = SidStrCol(1).ToString()
        'Text boxes SID_IDENTIFIER_AUTHORITY
        tbIA1.Text = SidStrCol(2).ToString()
        tbIA2.Text = SidStrCol(3).ToString()
        tbIA3.Text = SidStrCol(4).ToString()
        tbIA4.Text = SidStrCol(5).ToString()
        tbIA5.Text = SidStrCol(6).ToString()
        tbIA6.Text = SidStrCol(7).ToString()
        'Text boxes sub 1
        tb1ID1.Text = SidStrCol(8).ToString()
        tb1ID2.Text = SidStrCol(9).ToString()
        tb1ID3.Text = SidStrCol(10).ToString()
        tb1ID4.Text = SidStrCol(11).ToString()

        ' Text boxes Sub 2
        tb2ID1.Text = "x"
        tb2ID2.Text = "x"
        tb2ID3.Text = "x"
        tb2ID4.Text = "x" ' Text boxes Sub 3
        tb3ID1.Text = "x"
        tb3ID2.Text = "x"
        tb3ID3.Text = "x"
        tb3ID4.Text = "x" ' Text boxes Sub 4
        tb4ID1.Text = "x"
        tb4ID2.Text = "x"
        tb4ID3.Text = "x"
        tb4ID4.Text = "x" ' Tex boxes Sub 5
        tb5ID1.Text = "x"
        tb5ID2.Text = "x"
        tb5ID3.Text = "x"
        tb5ID4.Text = "x" 'IA Math
    End Sub

    Private Function sCount2(SidStrCol As ICollection(Of Byte), updateUI As Action(Of ICollection(Of Byte))) As String
        Try
            Dim b1, b2, b3, b4, b5, b6, b7, b8, b9, b10,
                b11, b12, b13, b14, b15, b16 As Double


            b1 = SidStrCol(0)         ' Revision Number           1 byte
            b2 = SidStrCol(1)         ' Sub ID Count              1 byte ' Satrt Auth.
            b3 = SidStrCol(2)         ' SID_IDENTIFIER_AUTHORITY  6 bytes
            b4 = SidStrCol(3)         ' 2
            b5 = SidStrCol(4)         ' 3
            b6 = SidStrCol(5)         ' 4
            b7 = SidStrCol(6)         ' 5
            b8 = SidStrCol(7)         ' 6 'Start Sub 1
            b9 = SidStrCol(8)         ' Sub Authority 1           4 bytes
            b10 = SidStrCol(9)       ' 2
            b11 = SidStrCol(10)       ' 3
            b12 = SidStrCol(11)       ' 4
            ' Everything before here is the minimum that will go in
            ' Will need to check the sub id count after this.
            b13 = SidStrCol(12)       ' Sub Authority 2           4 bytes
            b14 = SidStrCol(13)       ' 2
            b15 = SidStrCol(14)       ' 3
            b16 = SidStrCol(15)

            updateUI?.Invoke(SidStrCol)

            ' 4 'Sub ID count = 2 All above

            Dim strIAMath As Double
            strIAMath = b3
            strIAMath = strIAMath * 256 + b4
            strIAMath = strIAMath * 256 + b5
            strIAMath = strIAMath * 256 + b6
            strIAMath = strIAMath * 256 + b7
            strIAMath = strIAMath * 256 + b8

            Dim Sub1Math As Double
            Sub1Math = b12                      ' Starts From The Right
            Sub1Math = (Sub1Math * 256) + b11
            Sub1Math = (Sub1Math * 256) + b10
            Sub1Math = (Sub1Math * 256) + b9

            Dim Sub2Math As Double
            Sub2Math = b16                     ' Starts From The Right
            Sub2Math = (Sub2Math * 256) + b15
            Sub2Math = (Sub2Math * 256) + b14
            Sub2Math = (Sub2Math * 256) + b13

            Dim OutputString As String

            OutputString = $"S-{b1}-{strIAMath}-{Sub1Math}-{Sub2Math}"

            Return OutputString
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Some Kind Of Error Happened")

        End Try

        Return ""
    End Function

    Private Sub UICount2(SidStrCol As ICollection(Of Byte))

        tbRevision.Text = SidStrCol(0).ToString()
        tbSubIDCount.Text = SidStrCol(1).ToString()
        'Text boxes SID_IDENTIFIER_AUTHORITY
        tbIA1.Text = SidStrCol(2).ToString()
        tbIA2.Text = SidStrCol(3).ToString()
        tbIA3.Text = SidStrCol(4).ToString()
        tbIA4.Text = SidStrCol(5).ToString()
        tbIA5.Text = SidStrCol(6).ToString()
        tbIA6.Text = SidStrCol(7).ToString()
        'Text boxes sub 1
        tb1ID1.Text = SidStrCol(8).ToString()
        tb1ID2.Text = SidStrCol(9).ToString()
        tb1ID3.Text = SidStrCol(10).ToString()
        tb1ID4.Text = SidStrCol(11).ToString()

        ' Text boxes Sub 2
        tb2ID1.Text = SidStrCol(12).ToString()
        tb2ID2.Text = SidStrCol(13).ToString()
        tb2ID3.Text = SidStrCol(14).ToString()
        tb2ID4.Text = SidStrCol(15).ToString()
        ' Text boxes Sub 3
        tb3ID1.Text = "x"
        tb3ID2.Text = "x"
        tb3ID3.Text = "x"
        tb3ID4.Text = "x" ' Text boxes Sub 4
        tb4ID1.Text = "x"
        tb4ID2.Text = "x"
        tb4ID3.Text = "x"
        tb4ID4.Text = "x" ' Tex boxes Sub 5
        tb5ID1.Text = "x"
        tb5ID2.Text = "x"
        tb5ID3.Text = "x"
        tb5ID4.Text = "x" 'IA Math
    End Sub

    Private Function sCount3(SidStrCol As ICollection(Of Byte), updateUI As Action(Of ICollection(Of Byte))) As String
        Try
            Dim b1, b2, b3, b4, b5, b6, b7, b8, b9, b10, b11, b12,
            b13, b14, b15, b16, b17, b18, b19, b20 As Double

            b1 = SidStrCol(0)         ' Revision Number           1 byte
            b2 = SidStrCol(1)         ' Sub ID Count              1 byte ' Satrt Auth.
            b3 = SidStrCol(2)         ' SID_IDENTIFIER_AUTHORITY  6 bytes
            b4 = SidStrCol(3)         ' 2
            b5 = SidStrCol(4)         ' 3
            b6 = SidStrCol(5)         ' 4
            b7 = SidStrCol(6)         ' 5
            b8 = SidStrCol(7)         ' 6 'Start Sub 1
            b9 = SidStrCol(8)         ' Sub Authority 1           4 bytes
            b10 = SidStrCol(9)       ' 2
            b11 = SidStrCol(10)       ' 3
            b12 = SidStrCol(11)       ' 4
            ' Everything before here is the minimum
            ' that will go in Will need to check the sub id count after this.
            b13 = SidStrCol(12)       ' Sub Authority 2           4 bytes
            b14 = SidStrCol(13)       ' 2
            b15 = SidStrCol(14)       ' 3
            b16 = SidStrCol(15)       ' 4 'Sub ID count = 2 All above
            b17 = SidStrCol(16)       ' Sub Authority 3           4 bytes
            b18 = SidStrCol(17)       ' 2
            b19 = SidStrCol(18)       ' 3
            b20 = SidStrCol(19)

            updateUI?.Invoke(SidStrCol)

            ' 4 ' Sub ID Count = 3 All Above

            Dim strIAMath As Double
            strIAMath = b3
            strIAMath = strIAMath * 256 + b4
            strIAMath = strIAMath * 256 + b5
            strIAMath = strIAMath * 256 + b6
            strIAMath = strIAMath * 256 + b7
            strIAMath = strIAMath * 256 + b8

            Dim Sub1Math As Double
            Sub1Math = b12                      ' Starts From The Right
            Sub1Math = (Sub1Math * 256) + b11
            Sub1Math = (Sub1Math * 256) + b10
            Sub1Math = (Sub1Math * 256) + b9

            Dim Sub2Math As Double
            Sub2Math = b16                     ' Starts From The Right
            Sub2Math = (Sub2Math * 256) + b15
            Sub2Math = (Sub2Math * 256) + b14
            Sub2Math = (Sub2Math * 256) + b13

            Dim Sub3Math As Double
            Sub3Math = b20                     ' Starts From The Right
            Sub3Math = Sub3Math * 256 + b19
            Sub3Math = Sub3Math * 256 + b18
            Sub3Math = Sub3Math * 256 + b17

            Dim OutputString As String

            OutputString = $"S-{b1}-{strIAMath}-{Sub1Math}-{Sub2Math}-{Sub3Math}"

            Return OutputString
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Some Kind Of Error Happened")
        End Try
        Return ""
    End Function

    Private Sub UICount3(SidStrCol As ICollection(Of Byte))


        tbRevision.Text = SidStrCol(0).ToString()
        tbSubIDCount.Text = SidStrCol(1).ToString()
        'Text boxes SID_IDENTIFIER_AUTHORITY
        tbIA1.Text = SidStrCol(2).ToString()
        tbIA2.Text = SidStrCol(3).ToString()
        tbIA3.Text = SidStrCol(4).ToString()
        tbIA4.Text = SidStrCol(5).ToString()
        tbIA5.Text = SidStrCol(6).ToString()
        tbIA6.Text = SidStrCol(7).ToString()
        'Text boxes sub 1
        tb1ID1.Text = SidStrCol(8).ToString()
        tb1ID2.Text = SidStrCol(9).ToString()
        tb1ID3.Text = SidStrCol(10).ToString()
        tb1ID4.Text = SidStrCol(11).ToString()

        ' Text boxes Sub 2
        tb2ID1.Text = SidStrCol(12).ToString()
        tb2ID2.Text = SidStrCol(13).ToString()
        tb2ID3.Text = SidStrCol(14).ToString()
        tb2ID4.Text = SidStrCol(15).ToString()
        ' Text boxes Sub 3
        tb3ID1.Text = SidStrCol(16).ToString()
        tb3ID2.Text = SidStrCol(17).ToString()
        tb3ID3.Text = SidStrCol(18).ToString()
        tb3ID4.Text = SidStrCol(19).ToString()
        ' Text boxes Sub 4
        tb4ID1.Text = "x"
        tb4ID2.Text = "x"
        tb4ID3.Text = "x"
        tb4ID4.Text = "x" ' Tex boxes Sub 5
        tb5ID1.Text = "x"
        tb5ID2.Text = "x"
        tb5ID3.Text = "x"
        tb5ID4.Text = "x" 'IA Math
    End Sub

    Private Function sCount4(SidStrCol As Collection(Of Byte), updateUI As Action(Of ICollection(Of Byte))) As String
        Try
            Dim b1, b2, b3, b4, b5, b6, b7, b8, b9, b10, b11, b12,
              b13, b14, b15, b16, b17, b18, b19, b20, b21, b22, b23, b24 As Double


            b1 = SidStrCol(0)         ' Revision Number           1 byte
            b2 = SidStrCol(1)         ' Sub ID Count              1 byte ' Satrt Auth.
            b3 = SidStrCol(2)         ' SID_IDENTIFIER_AUTHORITY  6 bytes
            b4 = SidStrCol(3)         ' 2
            b5 = SidStrCol(4)         ' 3
            b6 = SidStrCol(5)         ' 4
            b7 = SidStrCol(6)         ' 5
            b8 = SidStrCol(7)         ' 6 'Start Sub 1
            b9 = SidStrCol(8)         ' Sub Authority 1           4 bytes
            b10 = SidStrCol(9)       ' 2
            b11 = SidStrCol(10)       ' 3
            b12 = SidStrCol(11)       ' 4
            ' Everything before here is the minimum that will
            ' go in Will need to check the sub id count after this.
            b13 = SidStrCol(13)       ' Sub Authority 2           4 bytes
            b14 = SidStrCol(13)       ' 2
            b15 = SidStrCol(14)       ' 3
            b16 = SidStrCol(15)       ' 4 'Sub ID count = 2 All above
            b17 = SidStrCol(16)       ' Sub Authority 3           4 bytes
            b18 = SidStrCol(17)       ' 2
            b19 = SidStrCol(18)       ' 3
            b20 = SidStrCol(19)       ' 4 ' Sub ID Count = 3 All Above
            b21 = SidStrCol(20)       ' Sub Authority 4           4 bytes
            b22 = SidStrCol(21)       ' 2
            b23 = SidStrCol(22)       ' 3
            b24 = SidStrCol(23)

            updateUI?.Invoke(SidStrCol)

            ' 4 ' Sub ID Count = 4 All Above          
            Dim strIAMath As Double
            strIAMath = b3
            strIAMath = strIAMath * 256 + b4
            strIAMath = strIAMath * 256 + b5
            strIAMath = strIAMath * 256 + b6
            strIAMath = strIAMath * 256 + b7
            strIAMath = strIAMath * 256 + b8

            Dim Sub1Math As Double
            Sub1Math = b12                      ' Starts From The Right
            Sub1Math = (Sub1Math * 256) + b11
            Sub1Math = (Sub1Math * 256) + b10
            Sub1Math = (Sub1Math * 256) + b9

            Dim Sub2Math As Double
            Sub2Math = b16                     ' Starts From The Right
            Sub2Math = (Sub2Math * 256) + b15
            Sub2Math = (Sub2Math * 256) + b14
            Sub2Math = (Sub2Math * 256) + b13

            Dim Sub3Math As Double
            Sub3Math = b20                     ' Starts From The Right
            Sub3Math = Sub3Math * 256 + b19
            Sub3Math = Sub3Math * 256 + b18
            Sub3Math = Sub3Math * 256 + b17

            Dim Sub4Math As Double
            Sub4Math = b24                     ' Starts From The Right
            Sub4Math = Sub4Math * 256 + b23
            Sub4Math = Sub4Math * 256 + b22
            Sub4Math = Sub4Math * 256 + b21

            Dim OutputString As String

            OutputString = $"S-{b1}-{strIAMath}-{Sub1Math}-{Sub2Math}-{Sub3Math}-{Sub4Math}"

            Return OutputString
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Some Kind Of Error Happened")
        End Try
        Return ""
    End Function

    Private Sub UICount4(SidStrCol As ICollection(Of Byte))
        tbRevision.Text = SidStrCol(0).ToString()
        tbSubIDCount.Text = SidStrCol(1).ToString()
        'Text boxes SID_IDENTIFIER_AUTHORITY
        tbIA1.Text = SidStrCol(2).ToString()
        tbIA2.Text = SidStrCol(3).ToString()
        tbIA3.Text = SidStrCol(4).ToString()
        tbIA4.Text = SidStrCol(5).ToString()
        tbIA5.Text = SidStrCol(6).ToString()
        tbIA6.Text = SidStrCol(7).ToString()
        'Text boxes sub 1
        tb1ID1.Text = SidStrCol(8).ToString()
        tb1ID2.Text = SidStrCol(9).ToString()
        tb1ID3.Text = SidStrCol(10).ToString()
        tb1ID4.Text = SidStrCol(11).ToString()

        ' Text boxes Sub 2
        tb2ID1.Text = SidStrCol(12).ToString()
        tb2ID2.Text = SidStrCol(13).ToString()
        tb2ID3.Text = SidStrCol(14).ToString()
        tb2ID4.Text = SidStrCol(15).ToString()
        ' Text boxes Sub 3
        tb3ID1.Text = SidStrCol(16).ToString()
        tb3ID2.Text = SidStrCol(17).ToString()
        tb3ID3.Text = SidStrCol(18).ToString()
        tb3ID4.Text = SidStrCol(19).ToString()
        ' Text boxes Sub 4
        tb4ID1.Text = SidStrCol(20).ToString()
        tb4ID2.Text = SidStrCol(21).ToString()
        tb4ID3.Text = SidStrCol(22).ToString()
        tb4ID4.Text = SidStrCol(23).ToString()
        ' Tex boxes Sub 5
        tb5ID1.Text = "x"
        tb5ID2.Text = "x"
        tb5ID3.Text = "x"
        tb5ID4.Text = "x" 'IA Math
    End Sub

    Private Function sCount5(SidStrCol As ICollection(Of Byte), updateUI As Action(Of ICollection(Of Byte))) As String
        Try
            Dim b1, b2, b3, b4, b5, b6, b7, b8, b9, b10, b11, b12, b13,
              b14, b15, b16, b17, b18, b19, b20, b21, b22, b23,
              b24, b25, b26, b27, b28 As Double


            b1 = SidStrCol(0)         ' Revision Number           1 byte
            b2 = SidStrCol(1)         ' Sub ID Count              1 byte ' Satrt Auth.
            b3 = SidStrCol(2)         ' SID_IDENTIFIER_AUTHORITY  6 bytes
            b4 = SidStrCol(3)         ' 2
            b5 = SidStrCol(4)         ' 3
            b6 = SidStrCol(5)         ' 4
            b7 = SidStrCol(6)         ' 5
            b8 = SidStrCol(7)         ' 6 'Start Sub 1
            b9 = SidStrCol(8)         ' Sub Authority 1           4 bytes
            b10 = SidStrCol(9)       ' 2
            b11 = SidStrCol(10)       ' 3
            b12 = SidStrCol(11)       ' 4
            ' Everything before here is the minimum that will go
            ' in Will need to check the sub id count after this.
            b13 = SidStrCol(12)       ' Sub Authority 2           4 bytes
            b14 = SidStrCol(13)       ' 2
            b15 = SidStrCol(14)       ' 3
            b16 = SidStrCol(15)       ' 4 'Sub ID count = 2 All above
            b17 = SidStrCol(16)       ' Sub Authority 3           4 bytes
            b18 = SidStrCol(17)       ' 2
            b19 = SidStrCol(18)       ' 3
            b20 = SidStrCol(19)       ' 4 ' Sub ID Count = 3 All Above
            b21 = SidStrCol(20)       ' Sub Authority 4           4 bytes
            b22 = SidStrCol(21)       ' 2
            b23 = SidStrCol(22)       ' 3
            b24 = SidStrCol(23)       ' 4 ' Sub ID Count = 4 All Above
            b25 = SidStrCol(24)       ' Sub Authority 5 (RID)     4 bytes
            b26 = SidStrCol(25)       ' 2
            b27 = SidStrCol(26)       ' 3
            b28 = SidStrCol(27)

            updateUI?.Invoke(SidStrCol)

            ' 4   (Last byte in the array / Collection)
            'IA Math
            Dim strIAMath As Double
            strIAMath = b3
            strIAMath = strIAMath * 256 + b4
            strIAMath = strIAMath * 256 + b5
            strIAMath = strIAMath * 256 + b6
            strIAMath = strIAMath * 256 + b7
            strIAMath = strIAMath * 256 + b8

            Dim Sub1Math As Double
            Sub1Math = b12                      ' Starts From The Right
            Sub1Math = (Sub1Math * 256) + b11
            Sub1Math = (Sub1Math * 256) + b10
            Sub1Math = (Sub1Math * 256) + b9

            Dim Sub2Math As Double
            Sub2Math = b16                     ' Starts From The Right
            Sub2Math = (Sub2Math * 256) + b15
            Sub2Math = (Sub2Math * 256) + b14
            Sub2Math = (Sub2Math * 256) + b13

            Dim Sub3Math As Double
            Sub3Math = b20                     ' Starts From The Right
            Sub3Math = Sub3Math * 256 + b19
            Sub3Math = Sub3Math * 256 + b18
            Sub3Math = Sub3Math * 256 + b17

            Dim Sub4Math As Double
            Sub4Math = b24                     ' Starts From The Right
            Sub4Math = Sub4Math * 256 + b23
            Sub4Math = Sub4Math * 256 + b22
            Sub4Math = Sub4Math * 256 + b21

            Dim sub5Math As Double
            sub5Math = b28                      ' Starts From The Right
            sub5Math = sub5Math * 256 + b27
            sub5Math = sub5Math * 256 + b26
            sub5Math = sub5Math * 256 + b25

            Dim OutputString As String

            OutputString = $"S-{b1}-{strIAMath}-{Sub1Math}-{Sub2Math}-{Sub3Math}-{Sub4Math}-{sub5Math}"

            Return OutputString
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Some Kind Of Error Happened")
        End Try
        Return ""
    End Function

    Private Sub UICount5(SidStrCol As ICollection(Of Byte))


        'Sub ID Count = 5 then All 28 Bytes will be used.
        tbRevision.Text = SidStrCol(0).ToString()
        tbSubIDCount.Text = SidStrCol(1).ToString()
        'Text boxes SID_IDENTIFIER_AUTHORITY
        tbIA1.Text = SidStrCol(2).ToString()
        tbIA2.Text = SidStrCol(3).ToString()
        tbIA3.Text = SidStrCol(4).ToString()
        tbIA4.Text = SidStrCol(5).ToString()
        tbIA5.Text = SidStrCol(6).ToString()
        tbIA6.Text = SidStrCol(7).ToString()
        'Text boxes sub 1
        tb1ID1.Text = SidStrCol(8).ToString()
        tb1ID2.Text = SidStrCol(9).ToString()
        tb1ID3.Text = SidStrCol(10).ToString()
        tb1ID4.Text = SidStrCol(11).ToString()

        ' Text boxes Sub 2
        tb2ID1.Text = SidStrCol(12).ToString()
        tb2ID2.Text = SidStrCol(13).ToString()
        tb2ID3.Text = SidStrCol(14).ToString()
        tb2ID4.Text = SidStrCol(15).ToString()
        ' Text boxes Sub 3
        tb3ID1.Text = SidStrCol(16).ToString()
        tb3ID2.Text = SidStrCol(17).ToString()
        tb3ID3.Text = SidStrCol(18).ToString()
        tb3ID4.Text = SidStrCol(19).ToString()
        ' Text boxes Sub 4
        tb4ID1.Text = SidStrCol(20).ToString()
        tb4ID2.Text = SidStrCol(21).ToString()
        tb4ID3.Text = SidStrCol(22).ToString()
        tb4ID4.Text = SidStrCol(23).ToString()
        ' Tex boxes Sub 5
        tb5ID1.Text = SidStrCol(24).ToString()
        tb5ID2.Text = SidStrCol(25).ToString()
        tb5ID3.Text = SidStrCol(26).ToString()
        tb5ID4.Text = SidStrCol(27).ToString()
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
            Dim RawSid As String
            RawSid = tbInputString.Text.Replace(" ", "")
            Dim SidStrCol As New Collection(Of Byte)
            Dim TrmdRawSID As String = RawSid.TrimEnd(","c)
            Dim stary() As String = Split(TrmdRawSID, ",", -1)

            For Each strByte In stary
                SidStrCol.Add(CByte(strByte))
            Next
            Dim colcnt As Integer
            colcnt = SidStrCol.Count
            b1 = SidStrCol(0)         ' Revision Number           1 byte
            b2 = SidStrCol(1)         ' Sub ID Count              1 byte
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
End Class