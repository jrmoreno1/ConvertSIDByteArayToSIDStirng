Imports System.Collections.ObjectModel
Imports System.Text

Public Class TransformBytesToSID_pcsxcetrasupport3
    Public ReadOnly Property SectionCount As Integer
    Public ReadOnly Property Bytes As IList(Of Byte)
    Public ReadOnly Property SID As String

    Public Sub New(byteValues As String)
        Me.New(GetSidByteCol(byteValues))
    End Sub

    Public Sub New(byteCollection As IEnumerable(Of Byte))
        Bytes = byteCollection.ToList()

        Dim b1 = Bytes(0)         ' Revision Number           1 byte (should always be 1)
        SectionCount = Bytes(1)   ' Sub ID Count              1 byte
        SID = GetSidFromByteValues(Bytes, SectionCount)
    End Sub

    Private Shared Function GetSidFromByteValues(bytes As IList(Of Byte), sections As Integer) As String
        If sections >= 1 Then
            Return GetSid(bytes)
        Else
            Throw New Exception($"Section Count={sections}")
        End If
    End Function

    Private Shared Function GetSid(SidByteCol As IList(Of Byte)) As String
        Try
            Dim b1 As Long = SidByteCol(0)         ' Revision Number           1 byte
            Dim IdentifierAuthority = GetIdentifierAuthority(SidByteCol)

            Dim strSid = $"S-{b1}-{IdentifierAuthority}"
            Dim sectionCount = SidByteCol(1)  ' Sub ID Count              1 byte

            For i = 1 To sectionCount
                strSid = $"{strSid}-{SubAuthority(i, SidByteCol)}"
            Next

            Return strSid
        Catch ex As Exception
            Throw New Exception("Some Kind Of Error Happened")
        End Try
    End Function

    Private Shared Function GetIdentifierAuthority(SidByteCol As IList(Of Byte)) As Long
        'IA Math
        Dim strIAMath As Long
        strIAMath = SidByteCol(2)
        strIAMath = strIAMath * 256 + SidByteCol(3) '65792
        strIAMath = strIAMath * 256 + SidByteCol(4) '16843008
        strIAMath = strIAMath * 256 + SidByteCol(5) '4311810304
        strIAMath = strIAMath * 256 + SidByteCol(6)
        strIAMath = strIAMath * 256 + SidByteCol(7) ' 6 'Start Sub 1
        Return strIAMath
    End Function

    Private Shared Function SubAuthority(section As Integer, SidByteCol As IList(Of Byte)) As Long
        ' 32-bits (4 bytes) for each SubAuthority
        '1st index = 8  '2nd index = 12 '3rd index = 16 '4th index = 20 '5th index = 24

        If section > 5 Then
            Throw New CountTooHigh($"This program only works for SID's with 1-5 Sub Authority's {vbNewLine}Your Sub ID = {section}")
        End If

        Dim index As Integer = 4 + (section * 4)

        Dim SubAuthorityMath As Long
        SubAuthorityMath = SidByteCol(index + 3)   ' Starts From The Right
        SubAuthorityMath = SubAuthorityMath * 256 + SidByteCol(index + 2)
        SubAuthorityMath = SubAuthorityMath * 256 + SidByteCol(index + 1)
        SubAuthorityMath = SubAuthorityMath * 256 + SidByteCol(index)
        Return SubAuthorityMath
    End Function

    Public Class CountTooHigh
        Inherits Exception
        Public Sub New(s As String)
            MyBase.New(s)
        End Sub
    End Class


End Class
