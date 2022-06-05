Imports System.Collections.ObjectModel
Imports System.Text

Public Class TransformBytesToSID_miromannino
    Public ReadOnly Property SectionCount As Integer
    Public ReadOnly Property Bytes As IList(Of Byte)
    Public ReadOnly Property SID As String

    Public Sub New(byteCollection As IEnumerable(Of Byte))
        Bytes = byteCollection.ToList()
        SectionCount = Bytes(1)   ' Sub ID Count              1 byte
        SID = GetSid(Bytes)
    End Sub

    ''' Cribbed from https://gist.github.com/miromannino/04be6a64ea0b5f4d4254bb321e09d628
    ''' where the license was (per a comment from miro):
    ''' The License is: Do Whatever You Want With It 2.0
    ''' aka I don't care, I hope it helps you!
    Private Shared Function GetSid(byteCollection As IEnumerable(Of Byte)) As String

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
