Public Module SidHelper
    Public Function GetSidByteCol(byteValues As String) As IList(Of Byte)
        byteValues = byteValues.Trim(" "c, ","c).Replace(" ", "")
        byteValues = byteValues.TrimEnd(","c)
        Dim strArray = Split(byteValues, ",", -1)

        Return (From strByte In strArray Select CByte(strByte)).ToList()
    End Function
End Module
