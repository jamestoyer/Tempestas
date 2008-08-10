' ----- The Library Project
'       Start-to-Finish Visual Basic 2005
'       Copyright (c) 2006 by Tim Patrick

Public Class ListItemData
    Public ItemText As String
    Public ItemData As Integer

    Public Sub New(ByVal displayText As String, _
    ByVal itemID As Integer)
        ' ----- Initialize the record.
        ItemText = displayText
        ItemData = itemID
    End Sub

    Public Overrides Function ToString() As String
        ' ----- Display the basic item text.
        Return ItemText
    End Function

    Public Overrides Function Equals(ByVal obj As Object) As Boolean
        ' ----- Allow IndexOf() and Contains() searches by ItemData.
        If (TypeOf obj Is Integer) Then
            Return CBool(CInt(obj) = ItemData)
        Else
            Return MyBase.Equals(obj)
        End If
    End Function
End Class
