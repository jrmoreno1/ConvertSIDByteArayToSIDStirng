Imports System.Collections.ObjectModel
Imports System.Text

Public Class TransformBytesToSID
    Public ReadOnly Property SectionCount As Integer
    Public ReadOnly Property Bytes As IList(Of Byte)
    Public ReadOnly Property SID As String

    Public Sub New(byteValues As String)
        Bytes = GetSidByteCol(byteValues)

        Dim b1 = Bytes(0)         ' Revision Number           1 byte (should always be 1)
        SectionCount = Bytes(1)   ' Sub ID Count              1 byte
        SID = GetSidFromStrByteValues(Bytes, SectionCount)
    End Sub

    Public Sub New(byteCollection As IEnumerable(Of Byte))
        Bytes = byteCollection.ToList()

        Dim b1 = Bytes(0)         ' Revision Number           1 byte (should always be 1)
        SectionCount = Bytes(1)   ' Sub ID Count              1 byte
        SID = GetSidFromStrByteValues(Bytes, SectionCount)
    End Sub

    Private Shared Function GetSidFromStrByteValues(bytes As IList(Of Byte), sections As Integer) As String
        If sections >= 1 Then
            Return GetSid(bytes)
        Else
            Throw New Exception($"Section Count={sections}")
        End If
    End Function

    Public Shared Function GetSidByteCol(byteValues As String) As IList(Of Byte)
        byteValues = byteValues.Trim(" "c, ","c).Replace(" ", "")
        byteValues = byteValues.TrimEnd(","c)
        Dim strArray = Split(byteValues, ",", -1)

        Return (From strByte In strArray Select CByte(strByte)).ToList()
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

    Public Sub New(byteCollection As IEnumerable(Of Byte), useMannino As Boolean)
        Bytes = byteCollection.ToList()
        SectionCount = Bytes(1)   ' Sub ID Count              1 byte
        SID = GetSidUsingMannino(Bytes)
    End Sub

    ''' Cribbed from https://gist.github.com/miromannino/04be6a64ea0b5f4d4254bb321e09d628
    ''' where the license was (per a comment from miro):
    ''' The License is: Do Whatever You Want With It 2.0
    ''' aka I don't care, I hope it helps you!
    Private Shared Function GetSidUsingMannino(byteCollection As IEnumerable(Of Byte)) As String
        ' sid[0] is the Revision, we allow only version 1, because it's the
        ' only that exists right now.
        If byteCollection(0) <> 1 Then Throw New ArgumentOutOfRangeException("SID (bytes(0)) revision must be 1")

        Dim stringSidBuilder = New StringBuilder("S-1-")

        ' The next byte specifies the numbers of sub authorities
        ' (number of dashes minus two), should be 5 or less, but not enforcing that
        Dim subAuthorityCount = byteCollection(1)

        ' IdentifierAuthority (6 bytes starting from the second) (big endian)
        Dim identifierAuthority As Long = 0

        Dim offset = 2
        Dim size = 6
        Dim i As Integer

        For i = 0 To size - 1
            identifierAuthority = identifierAuthority Or CLng(byteCollection(offset + i)) << 8 * (size - 1 - i)
        Next

        stringSidBuilder.Append(identifierAuthority.ToString())

        ' Iterate all the SubAuthority (little-endian)
        offset = 8
        size = 4 ' 32-bits (4 bytes) for each SubAuthority
        i = 0
        While i < subAuthorityCount
            Dim subAuthority As Long = 0
            For j = 0 To size - 1
                ' the below "Or" is a logical Or not a boolean operator
                subAuthority = subAuthority Or CLng(byteCollection(offset + j)) << 8 * j
            Next
            stringSidBuilder.Append("-").Append(subAuthority)
            i += 1
            offset += size
        End While

        Return stringSidBuilder.ToString()
    End Function


End Class
