Public Class Form1
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Select Case CInt(txtInput.Text)
            Case 1
                lblMessage.Text = "I"
            Case 2
                lblMessage.Text = "II"
            Case 3
                lblMessage.Text = "III"
            Case 4
                lblMessage.Text = "IV"
            Case 5
                lblMessage.Text = "V"
            Case 6
                lblMessage.Text = "VI"
            Case 7
                lblMessage.Text = "VII"
            Case 8
                lblMessage.Text = "VIII"
            Case 9
                lblMessage.Text = "IX"
            Case 10
                lblMessage.Text = "X"
            Case Else
                lblMessage.Text = "Its not a valid value"
        End Select
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
