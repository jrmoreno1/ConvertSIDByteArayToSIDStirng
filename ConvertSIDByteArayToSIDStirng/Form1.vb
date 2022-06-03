Option Strict Off

Imports System.Collections.ObjectModel
Imports System.Text

Public Class Form1

    Private Sub btnConvert_Click(ByVal sender As System.Object,
            ByVal e As System.EventArgs) Handles btnConvert.Click

        Try
            Dim b1, b2 As String
            Dim RawSid As String
            RawSid = tbInputString.Text
            Dim SidStrCol As New Collection
            Dim TrmdRawSID As String = RawSid.TrimEnd(",")
            Dim stary() As String = Split(TrmdRawSID, ",", -1)

            For Each strByte In stary
                SidStrCol.Add(strByte)

            Next

            b1 = SidStrCol(1)         ' Revision Number           1 byte
            b2 = SidStrCol(2)         ' Sub ID Count              1 byte
            If b2 = 1 Then
                sCount1()
            ElseIf b2 = 2 Then
                sCount2()
            ElseIf b2 = 3 Then
                sCount3()
            ElseIf b2 = 4 Then
                sCount4()
            ElseIf b2 = 5 Then
                sCount5()
            ElseIf b2 > 5 Then
                MsgBox("This program only works for " &
               "SID's with 1-5 Sub Authority's" & vbNewLine &
               "Your Sub ID = " & b2.ToString,
               MsgBoxStyle.Information, "Sub ID Count To High")
            End If
        Catch ex As Exception
            If tbInputString.Text = Nothing Then
                MsgBox("Please insert the SID to Convert",
                   MsgBoxStyle.Information, "Error, Missing SID")
            Else
                MsgBox(ex.Message, MsgBoxStyle.Information,
                        "Some Kind Of Error Happened")
            End If
        End Try
    End Sub
    Private Sub sCount1()
        Try
            Dim b1, b2, b3, b4, b5, b6, b7, b8, b9, b10, b11, b12 As String
            Dim RawSid As String
            RawSid = tbInputString.Text
            Dim SidStrCol As New Collection
            Dim TrmdRawSID As String = RawSid.TrimEnd(",")
            Dim stary() As String = Split(TrmdRawSID, ",", -1)

            For Each strByte In stary
                SidStrCol.Add(strByte)

            Next

            b1 = SidStrCol(1)         ' Revision Number           1 byte
            b2 = SidStrCol(2)         ' Sub ID Count              1 byte ' Satrt Auth.
            b3 = SidStrCol(3)         ' SID_IDENTIFIER_AUTHORITY  6 bytes
            b4 = SidStrCol(4)         ' 2
            b5 = SidStrCol(5)         ' 3
            b6 = SidStrCol(6)         ' 4
            b7 = SidStrCol(7)         ' 5
            b8 = SidStrCol(8)         ' 6 'Start Sub 1
            b9 = SidStrCol(9)         ' Sub Authority 1           4 bytes
            b10 = SidStrCol(10)       ' 2
            b11 = SidStrCol(11)       ' 3
            b12 = SidStrCol(12)       ' 4
            ' Everything before here is the minimum that
            ' will go in Will need to check the sub id count after this.      

            tbRevision.Text = b1
            tbSubIDCount.Text = b2
            'Text boxes SID_IDENTIFIER_AUTHORITY
            tbIA1.Text = b3
            tbIA2.Text = b4
            tbIA3.Text = b5
            tbIA4.Text = b6
            tbIA5.Text = b7
            tbIA6.Text = b8
            'Text boxes sub 1
            tb1ID1.Text = b9
            tb1ID2.Text = b10
            tb1ID3.Text = b11
            tb1ID4.Text = b12

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
            Dim strIAMath As String
            strIAMath = b3
            strIAMath = strIAMath * 256 + b4
            strIAMath = strIAMath * 256 + b5
            strIAMath = strIAMath * 256 + b6
            strIAMath = strIAMath * 256 + b7
            strIAMath = strIAMath * 256 + b8

            Dim Sub1Math As String
            Sub1Math = b12                      ' Starts From The Right
            Sub1Math = (Sub1Math * 256) + b11
            Sub1Math = (Sub1Math * 256) + b10
            Sub1Math = (Sub1Math * 256) + b9

            Dim OutputString As String

            OutputString = ("S-" & b1 & "-" & strIAMath & "-" & Sub1Math)

            tbOutputString.Text = OutputString
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Some Kind Of Error Happened")
        End Try
    End Sub
    Private Sub sCount2()
        Try
            Dim b1, b2, b3, b4, b5, b6, b7, b8, b9, b10,
                b11, b12, b13, b14, b15, b16 As String
            Dim RawSid As String
            RawSid = tbInputString.Text
            Dim SidStrCol As New Collection
            Dim TrmdRawSID As String = RawSid.TrimEnd(",")
            Dim stary() As String = Split(TrmdRawSID, ",", -1)

            For Each strByte In stary
                SidStrCol.Add(strByte)

            Next

            b1 = SidStrCol(1)         ' Revision Number           1 byte
            b2 = SidStrCol(2)         ' Sub ID Count              1 byte ' Satrt Auth.
            b3 = SidStrCol(3)         ' SID_IDENTIFIER_AUTHORITY  6 bytes
            b4 = SidStrCol(4)         ' 2
            b5 = SidStrCol(5)         ' 3
            b6 = SidStrCol(6)         ' 4
            b7 = SidStrCol(7)         ' 5
            b8 = SidStrCol(8)         ' 6 'Start Sub 1
            b9 = SidStrCol(9)         ' Sub Authority 1           4 bytes
            b10 = SidStrCol(10)       ' 2
            b11 = SidStrCol(11)       ' 3
            b12 = SidStrCol(12)       ' 4
            ' Everything before here is the minimum that will go in
            ' Will need to check the sub id count after this.
            b13 = SidStrCol(13)       ' Sub Authority 2           4 bytes
            b14 = SidStrCol(14)       ' 2
            b15 = SidStrCol(15)       ' 3
            b16 = SidStrCol(16)       ' 4 'Sub ID count = 2 All above

            tbRevision.Text = b1
            tbSubIDCount.Text = b2
            'Text boxes SID_IDENTIFIER_AUTHORITY
            tbIA1.Text = b3
            tbIA2.Text = b4
            tbIA3.Text = b5
            tbIA4.Text = b6
            tbIA5.Text = b7
            tbIA6.Text = b8
            'Text boxes sub 1
            tb1ID1.Text = b9
            tb1ID2.Text = b10
            tb1ID3.Text = b11
            tb1ID4.Text = b12

            ' Text boxes Sub 2
            tb2ID1.Text = b13
            tb2ID2.Text = b14
            tb2ID3.Text = b15
            tb2ID4.Text = b16
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
            Dim strIAMath As String
            strIAMath = b3
            strIAMath = strIAMath * 256 + b4
            strIAMath = strIAMath * 256 + b5
            strIAMath = strIAMath * 256 + b6
            strIAMath = strIAMath * 256 + b7
            strIAMath = strIAMath * 256 + b8

            Dim Sub1Math As String
            Sub1Math = b12                      ' Starts From The Right
            Sub1Math = (Sub1Math * 256) + b11
            Sub1Math = (Sub1Math * 256) + b10
            Sub1Math = (Sub1Math * 256) + b9

            Dim Sub2Math As String
            Sub2Math = b16                     ' Starts From The Right
            Sub2Math = (Sub2Math * 256) + b15
            Sub2Math = (Sub2Math * 256) + b14
            Sub2Math = (Sub2Math * 256) + b13

            Dim OutputString As String

            OutputString = ("S-" & b1 & "-" & strIAMath & "-" & Sub1Math & "-" & Sub2Math)

            tbOutputString.Text = OutputString
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Some Kind Of Error Happened")
        End Try
    End Sub
    Private Sub sCount3()
        Try
            Dim b1, b2, b3, b4, b5, b6, b7, b8, b9, b10, b11, b12,
            b13, b14, b15, b16, b17, b18, b19, b20 As Double
            Dim RawSid As String
            RawSid = tbInputString.Text
            Dim SidStrCol As New Collection(Of String)
            Dim TrmdRawSID As String = RawSid.TrimEnd(",")
            Dim stary() As String = Split(TrmdRawSID, ",", -1)

            For Each strByte In stary
                SidStrCol.Add(strByte)

            Next

            b1 = SidStrCol(1)         ' Revision Number           1 byte
            b2 = SidStrCol(2)         ' Sub ID Count              1 byte ' Satrt Auth.
            b3 = SidStrCol(3)         ' SID_IDENTIFIER_AUTHORITY  6 bytes
            b4 = SidStrCol(4)         ' 2
            b5 = SidStrCol(5)         ' 3
            b6 = SidStrCol(6)         ' 4
            b7 = SidStrCol(7)         ' 5
            b8 = SidStrCol(8)         ' 6 'Start Sub 1
            b9 = SidStrCol(9)         ' Sub Authority 1           4 bytes
            b10 = SidStrCol(10)       ' 2
            b11 = SidStrCol(11)       ' 3
            b12 = SidStrCol(12)       ' 4
            ' Everything before here is the minimum
            ' that will go in Will need to check the sub id count after this.
            b13 = SidStrCol(13)       ' Sub Authority 2           4 bytes
            b14 = SidStrCol(14)       ' 2
            b15 = SidStrCol(15)       ' 3
            b16 = SidStrCol(16)       ' 4 'Sub ID count = 2 All above
            b17 = SidStrCol(17)       ' Sub Authority 3           4 bytes
            b18 = SidStrCol(18)       ' 2
            b19 = SidStrCol(19)       ' 3
            b20 = SidStrCol(20)       ' 4 ' Sub ID Count = 3 All Above

            tbRevision.Text = b1
            tbSubIDCount.Text = b2
            'Text boxes SID_IDENTIFIER_AUTHORITY
            tbIA1.Text = b3
            tbIA2.Text = b4
            tbIA3.Text = b5
            tbIA4.Text = b6
            tbIA5.Text = b7
            tbIA6.Text = b8
            'Text boxes sub 1
            tb1ID1.Text = b9
            tb1ID2.Text = b10
            tb1ID3.Text = b11
            tb1ID4.Text = b12

            ' Text boxes Sub 2
            tb2ID1.Text = b13
            tb2ID2.Text = b14
            tb2ID3.Text = b15
            tb2ID4.Text = b16
            ' Text boxes Sub 3
            tb3ID1.Text = b17
            tb3ID2.Text = b18
            tb3ID3.Text = b19
            tb3ID4.Text = b20
            ' Text boxes Sub 4
            tb4ID1.Text = "x"
            tb4ID2.Text = "x"
            tb4ID3.Text = "x"
            tb4ID4.Text = "x" ' Tex boxes Sub 5
            tb5ID1.Text = "x"
            tb5ID2.Text = "x"
            tb5ID3.Text = "x"
            tb5ID4.Text = "x" 'IA Math
            Dim strIAMath As String
            strIAMath = b3
            strIAMath = strIAMath * 256 + b4
            strIAMath = strIAMath * 256 + b5
            strIAMath = strIAMath * 256 + b6
            strIAMath = strIAMath * 256 + b7
            strIAMath = strIAMath * 256 + b8

            Dim Sub1Math As String
            Sub1Math = b12                      ' Starts From The Right
            Sub1Math = (Sub1Math * 256) + b11
            Sub1Math = (Sub1Math * 256) + b10
            Sub1Math = (Sub1Math * 256) + b9

            Dim Sub2Math As String
            Sub2Math = b16                     ' Starts From The Right
            Sub2Math = (Sub2Math * 256) + b15
            Sub2Math = (Sub2Math * 256) + b14
            Sub2Math = (Sub2Math * 256) + b13

            Dim Sub3Math As String
            Sub3Math = b20                     ' Starts From The Right
            Sub3Math = Sub3Math * 256 + b19
            Sub3Math = Sub3Math * 256 + b18
            Sub3Math = Sub3Math * 256 + b17

            Dim OutputString As String

            OutputString = ("S-" & b1 & "-" & strIAMath &
              "-" & Sub1Math & "-" & Sub2Math & "-" & Sub3Math)

            tbOutputString.Text = OutputString
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Some Kind Of Error Happened")
        End Try
    End Sub
    Private Sub sCount4()
        Try
            Dim b1, b2, b3, b4, b5, b6, b7, b8, b9, b10, b11, b12,
              b13, b14, b15, b16, b17, b18, b19, b20, b21, b22, b23, b24 As String
            Dim RawSid As String
            RawSid = tbInputString.Text
            Dim SidStrCol As New Collection
            Dim TrmdRawSID As String = RawSid.TrimEnd(",")
            Dim stary() As String = Split(TrmdRawSID, ",", -1)

            For Each strByte In stary
                SidStrCol.Add(strByte)

            Next

            b1 = SidStrCol(1)         ' Revision Number           1 byte
            b2 = SidStrCol(2)         ' Sub ID Count              1 byte ' Satrt Auth.
            b3 = SidStrCol(3)         ' SID_IDENTIFIER_AUTHORITY  6 bytes
            b4 = SidStrCol(4)         ' 2
            b5 = SidStrCol(5)         ' 3
            b6 = SidStrCol(6)         ' 4
            b7 = SidStrCol(7)         ' 5
            b8 = SidStrCol(8)         ' 6 'Start Sub 1
            b9 = SidStrCol(9)         ' Sub Authority 1           4 bytes
            b10 = SidStrCol(10)       ' 2
            b11 = SidStrCol(11)       ' 3
            b12 = SidStrCol(12)       ' 4
            ' Everything before here is the minimum that will
            ' go in Will need to check the sub id count after this.
            b13 = SidStrCol(13)       ' Sub Authority 2           4 bytes
            b14 = SidStrCol(14)       ' 2
            b15 = SidStrCol(15)       ' 3
            b16 = SidStrCol(16)       ' 4 'Sub ID count = 2 All above
            b17 = SidStrCol(17)       ' Sub Authority 3           4 bytes
            b18 = SidStrCol(18)       ' 2
            b19 = SidStrCol(19)       ' 3
            b20 = SidStrCol(20)       ' 4 ' Sub ID Count = 3 All Above
            b21 = SidStrCol(21)       ' Sub Authority 4           4 bytes
            b22 = SidStrCol(22)       ' 2
            b23 = SidStrCol(23)       ' 3
            b24 = SidStrCol(24)       ' 4 ' Sub ID Count = 4 All Above          

            tbRevision.Text = b1
            tbSubIDCount.Text = b2
            'Text boxes SID_IDENTIFIER_AUTHORITY
            tbIA1.Text = b3
            tbIA2.Text = b4
            tbIA3.Text = b5
            tbIA4.Text = b6
            tbIA5.Text = b7
            tbIA6.Text = b8
            'Text boxes sub 1
            tb1ID1.Text = b9
            tb1ID2.Text = b10
            tb1ID3.Text = b11
            tb1ID4.Text = b12

            ' Text boxes Sub 2
            tb2ID1.Text = b13
            tb2ID2.Text = b14
            tb2ID3.Text = b15
            tb2ID4.Text = b16
            ' Text boxes Sub 3
            tb3ID1.Text = b17
            tb3ID2.Text = b18
            tb3ID3.Text = b19
            tb3ID4.Text = b20
            ' Text boxes Sub 4
            tb4ID1.Text = b21
            tb4ID2.Text = b22
            tb4ID3.Text = b23
            tb4ID4.Text = b24
            ' Tex boxes Sub 5
            tb5ID1.Text = "x"
            tb5ID2.Text = "x"
            tb5ID3.Text = "x"
            tb5ID4.Text = "x" 'IA Math
            Dim strIAMath As String
            strIAMath = b3
            strIAMath = strIAMath * 256 + b4
            strIAMath = strIAMath * 256 + b5
            strIAMath = strIAMath * 256 + b6
            strIAMath = strIAMath * 256 + b7
            strIAMath = strIAMath * 256 + b8

            Dim Sub1Math As String
            Sub1Math = b12                      ' Starts From The Right
            Sub1Math = (Sub1Math * 256) + b11
            Sub1Math = (Sub1Math * 256) + b10
            Sub1Math = (Sub1Math * 256) + b9

            Dim Sub2Math As String
            Sub2Math = b16                     ' Starts From The Right
            Sub2Math = (Sub2Math * 256) + b15
            Sub2Math = (Sub2Math * 256) + b14
            Sub2Math = (Sub2Math * 256) + b13

            Dim Sub3Math As String
            Sub3Math = b20                     ' Starts From The Right
            Sub3Math = Sub3Math * 256 + b19
            Sub3Math = Sub3Math * 256 + b18
            Sub3Math = Sub3Math * 256 + b17

            Dim Sub4Math As String
            Sub4Math = b24                     ' Starts From The Right
            Sub4Math = Sub4Math * 256 + b23
            Sub4Math = Sub4Math * 256 + b22
            Sub4Math = Sub4Math * 256 + b21

            Dim OutputString As String

            OutputString = ("S-" & b1 & "-" & strIAMath & "-" &
               Sub1Math & "-" & Sub2Math & "-" & Sub3Math & "-" & Sub4Math)

            tbOutputString.Text = OutputString
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Some Kind Of Error Happened")
        End Try
    End Sub
    Private Sub sCount5()
        Try
            Dim b1, b2, b3, b4, b5, b6, b7, b8, b9, b10, b11, b12, b13,
              b14, b15, b16, b17, b18, b19, b20, b21, b22, b23,
              b24, b25, b26, b27, b28 As String
            Dim RawSid As String
            RawSid = tbInputString.Text
            Dim SidStrCol As New Collection
            Dim TrmdRawSID As String = RawSid.TrimEnd(",")
            Dim stary() As String = Split(TrmdRawSID, ",", -1)

            For Each strByte In stary
                SidStrCol.Add(strByte)
            Next

            b1 = SidStrCol(1)         ' Revision Number           1 byte
            b2 = SidStrCol(2)         ' Sub ID Count              1 byte ' Satrt Auth.
            b3 = SidStrCol(3)         ' SID_IDENTIFIER_AUTHORITY  6 bytes
            b4 = SidStrCol(4)         ' 2
            b5 = SidStrCol(5)         ' 3
            b6 = SidStrCol(6)         ' 4
            b7 = SidStrCol(7)         ' 5
            b8 = SidStrCol(8)         ' 6 'Start Sub 1
            b9 = SidStrCol(9)         ' Sub Authority 1           4 bytes
            b10 = SidStrCol(10)       ' 2
            b11 = SidStrCol(11)       ' 3
            b12 = SidStrCol(12)       ' 4
            ' Everything before here is the minimum that will go
            ' in Will need to check the sub id count after this.
            b13 = SidStrCol(13)       ' Sub Authority 2           4 bytes
            b14 = SidStrCol(14)       ' 2
            b15 = SidStrCol(15)       ' 3
            b16 = SidStrCol(16)       ' 4 'Sub ID count = 2 All above
            b17 = SidStrCol(17)       ' Sub Authority 3           4 bytes
            b18 = SidStrCol(18)       ' 2
            b19 = SidStrCol(19)       ' 3
            b20 = SidStrCol(20)       ' 4 ' Sub ID Count = 3 All Above
            b21 = SidStrCol(21)       ' Sub Authority 4           4 bytes
            b22 = SidStrCol(22)       ' 2
            b23 = SidStrCol(23)       ' 3
            b24 = SidStrCol(24)       ' 4 ' Sub ID Count = 4 All Above
            b25 = SidStrCol(25)       ' Sub Authority 5 (RID)     4 bytes
            b26 = SidStrCol(26)       ' 2
            b27 = SidStrCol(27)       ' 3
            b28 = SidStrCol(28)       ' 4   (Last byte in the array / Collection)
            'Sub ID Count = 5 then All 28 Bytes will be used.
            tbRevision.Text = b1
            tbSubIDCount.Text = b2
            'Text boxes SID_IDENTIFIER_AUTHORITY
            tbIA1.Text = b3
            tbIA2.Text = b4
            tbIA3.Text = b5
            tbIA4.Text = b6
            tbIA5.Text = b7
            tbIA6.Text = b8
            'Text boxes sub 1
            tb1ID1.Text = b9
            tb1ID2.Text = b10
            tb1ID3.Text = b11
            tb1ID4.Text = b12

            ' Text boxes Sub 2
            tb2ID1.Text = b13
            tb2ID2.Text = b14
            tb2ID3.Text = b15
            tb2ID4.Text = b16
            ' Text boxes Sub 3
            tb3ID1.Text = b17
            tb3ID2.Text = b18
            tb3ID3.Text = b19
            tb3ID4.Text = b20
            ' Text boxes Sub 4
            tb4ID1.Text = b21
            tb4ID2.Text = b22
            tb4ID3.Text = b23
            tb4ID4.Text = b24
            ' Tex boxes Sub 5
            tb5ID1.Text = b25
            tb5ID2.Text = b26
            tb5ID3.Text = b27
            tb5ID4.Text = b28
            'IA Math
            Dim strIAMath As String
            strIAMath = b3
            strIAMath = strIAMath * 256 + b4
            strIAMath = strIAMath * 256 + b5
            strIAMath = strIAMath * 256 + b6
            strIAMath = strIAMath * 256 + b7
            strIAMath = strIAMath * 256 + b8

            Dim Sub1Math As String
            Sub1Math = b12                      ' Starts From The Right
            Sub1Math = (Sub1Math * 256) + b11
            Sub1Math = (Sub1Math * 256) + b10
            Sub1Math = (Sub1Math * 256) + b9

            Dim Sub2Math As String
            Sub2Math = b16                     ' Starts From The Right
            Sub2Math = (Sub2Math * 256) + b15
            Sub2Math = (Sub2Math * 256) + b14
            Sub2Math = (Sub2Math * 256) + b13

            Dim Sub3Math As String
            Sub3Math = b20                     ' Starts From The Right
            Sub3Math = Sub3Math * 256 + b19
            Sub3Math = Sub3Math * 256 + b18
            Sub3Math = Sub3Math * 256 + b17

            Dim Sub4Math As String
            Sub4Math = b24                     ' Starts From The Right
            Sub4Math = Sub4Math * 256 + b23
            Sub4Math = Sub4Math * 256 + b22
            Sub4Math = Sub4Math * 256 + b21

            Dim sub5Math As String
            sub5Math = b28                      ' Starts From The Right
            sub5Math = sub5Math * 256 + b27
            sub5Math = sub5Math * 256 + b26
            sub5Math = sub5Math * 256 + b25

            Dim OutputString As String

            OutputString = ("S-" & b1 & "-" & strIAMath & "-" &
               Sub1Math & "-" & Sub2Math & "-" & Sub3Math & "-" &
               Sub4Math & "-" & sub5Math)

            tbOutputString.Text = OutputString
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Some Kind Of Error Happened")
        End Try
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

            Dim b1, b2 As String
            Dim RawSid As String
            RawSid = tbInputString.Text
            Dim SidStrCol As New Collection
            Dim TrmdRawSID As String = RawSid.TrimEnd(",")
            Dim stary() As String = Split(TrmdRawSID, ",", -1)

            For Each strByte In stary
                SidStrCol.Add(strByte)
            Next
            Dim colcnt As Integer
            colcnt = SidStrCol.Count
            b1 = SidStrCol(1)         ' Revision Number           1 byte
            b2 = SidStrCol(2)         ' Sub ID Count              1 byte
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