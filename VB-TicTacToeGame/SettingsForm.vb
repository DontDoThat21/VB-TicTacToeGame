Public Class SettingsForm
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Dim tb As TrackBar
        tb = CType(sender, TrackBar)
        If tb.Value < 5 And tb.Value <> 0 Then
            tb.Value = 0
        ElseIf tb.Value > 5 And tb.Value < 8 Then
            tb.Value = 5
        ElseIf tb.Value > 7 And tb.Value < 11 Then
            tb.Value = 10
        End If
        Select Case tb.Value
            Case 0
                Label1.Text = "Easy"
            Case 5
                Label1.Text = "Medium"
            Case 10
                Label1.Text = "Impossible"
        End Select
    End Sub
End Class