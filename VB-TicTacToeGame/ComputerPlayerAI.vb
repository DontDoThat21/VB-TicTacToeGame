Public Class ComputerPlayerAI
    Public Shared difficulty As Integer
    Public Shared selectedRows As New ArrayList

    Public Sub New(ByVal diff As Integer, ByVal alreadySelected() As Integer)
        difficulty = diff
        For Each selectedGrid As Integer In alreadySelected
            selectedRows.Add(selectedGrid)
        Next
    End Sub

    Private Sub GenerateSelectionRouter()
        If difficulty = 1 Then
            GenerateSelectionEasy()
        ElseIf difficulty = 2 Then
            GenerateSelectionMiddle()
        ElseIf difficulty = 3 Then
            GenerateSelectionHard()
        End If

    End Sub

    Private Sub GenerateSelectionEasy()

    End Sub

    Private Sub GenerateSelectionMiddle()
        Throw New NotImplementedException()
    End Sub

    Private Sub GenerateSelectionHard()
        Throw New NotImplementedException()
    End Sub

End Class