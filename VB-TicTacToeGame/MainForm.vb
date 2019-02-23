Public Class TicTacToe
    Dim WhosTurn As Boolean ' True will be X's turn. False is O's turn.

    Private Sub startGame_Click(sender As Object, e As EventArgs) Handles startGameBtn.Click
        HandleEnablingXOButtons()
    End Sub

    Private Sub TTToe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WhosTurn = True
        LabelManipulator()
    End Sub

    Private Sub Sector_Click(sender As Object, e As EventArgs) Handles topMdlBtn.Click, topRightBtn.Click, topLeftBtn.Click, mdlRightBtn.Click, mdlMdlBtn.Click, mdlLeftBtn.Click, botRightBtn.Click, botMdlBtn.Click, botLeftBtn.Click
        Dim btn = CType(sender, Button)
        If String.IsNullOrEmpty(btn.Text) Then
            btn.Text = currentTurnLabel.Text(0)
            If WhosTurn = False Then
                WhosTurn = True
                WinConditionCheck("O")
                LabelManipulator()
            Else
                WhosTurn = False
                WinConditionCheck("X")
                LabelManipulator()
            End If
        End If
    End Sub

    Private Sub LabelManipulator()
        If WhosTurn = True Then
            currentTurnLabel.Text = "X's Turn."
        Else
            currentTurnLabel.Text = "O's Turn."
        End If
    End Sub

    Private Sub WinConditionCheck(ltr As Char)
        If topLeftBtn.Text = ltr And topMdlBtn.Text = ltr And topRightBtn.Text = ltr Then
            MsgBox(ltr + " won.1") : ResetGame() ' Top left, top middle, top right win scenario
        ElseIf topLeftBtn.Text = ltr And mdlMdlBtn.Text = ltr And botRightBtn.Text = ltr Then
            MsgBox(ltr + " won.2") : ResetGame() ' Top left, Middle middle, bottom right win scenario
        ElseIf topLeftBtn.Text = ltr And mdlLeftBtn.Text = ltr And botLeftBtn.Text = ltr Then
            MsgBox(ltr + " won.3") : ResetGame() ' Top left, middle left, bot left win scenario
        ElseIf topMdlBtn.Text = ltr And mdlMdlBtn.Text = ltr And botMdlBtn.Text = ltr Then
            MsgBox(ltr + " won.4") : ResetGame() ' Top middle, middle middle, bottom middle win scenario
        ElseIf topRightBtn.Text = ltr And mdlMdlBtn.Text = ltr And botLeftBtn.Text = ltr Then
            MsgBox(ltr + " won.5") : ResetGame() ' Top right, middle middle, bottom left win scenario
        ElseIf topRightBtn.Text = ltr And mdlRightBtn.Text = ltr And botMdlBtn.Text = ltr Then
            MsgBox(ltr + " won.6") : ResetGame() ' Top middle, middle middle, bottom middle win scenario
        ElseIf mdlLeftBtn.Text = ltr And mdlMdlBtn.Text = ltr And mdlRightBtn.Text = ltr Then
            MsgBox(ltr + " won.7") : ResetGame() ' Middle left, middle middle, middle right win scenario
        ElseIf botLeftBtn.Text = ltr And botMdlBtn.Text = ltr And botRightBtn.Text = ltr Then
            MsgBox(ltr + " won.8") : ResetGame() ' Bot left, bot middle, bot right win scenario
        ElseIf topRightBtn.Text = ltr And mdlRightBtn.Text = ltr And botRightBtn.Text = ltr Then
            MsgBox(ltr + " won.9") : ResetGame() ' Bot left, bot middle, bot right win scenario
        End If
    End Sub

    Private Sub ResetGame()
        If WhosTurn Then
            Label4.Text = Integer.Parse(Label4.Text) + 1
        ElseIf WhosTurn = False Then
            Label2.Text = Integer.Parse(Label2.Text) + 1
        End If

        WhosTurn = True
        topLeftBtn.Enabled = False : topLeftBtn.Text = ""
        topMdlBtn.Enabled = False : topMdlBtn.Text = ""
        topRightBtn.Enabled = False : topRightBtn.Text = ""
        mdlLeftBtn.Enabled = False : mdlLeftBtn.Text = ""
        mdlMdlBtn.Enabled = False : mdlMdlBtn.Text = ""
        mdlRightBtn.Enabled = False : mdlRightBtn.Text = ""
        botLeftBtn.Enabled = False : botLeftBtn.Text = ""
        botMdlBtn.Enabled = False : botMdlBtn.Text = ""
        botRightBtn.Enabled = False : botRightBtn.Text = ""
    End Sub

    Private Sub HandleEnablingXOButtons()
        topLeftBtn.Enabled = True
        topMdlBtn.Enabled = True
        topRightBtn.Enabled = True
        mdlLeftBtn.Enabled = True
        mdlMdlBtn.Enabled = True
        mdlRightBtn.Enabled = True
        botLeftBtn.Enabled = True
        botMdlBtn.Enabled = True
        botRightBtn.Enabled = True
    End Sub

    Private Sub settingsBtn_Click(sender As Object, e As EventArgs) Handles settingsBtn.Click
        Dim settingsbox = New SettingsForm()
        settingsbox.Show()
    End Sub
End Class
