Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        ' exiting the program when the exit button is clicked
        Me.Close()

    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click

        ' showing the picEquation image when the show button is pressed
        picEquation.Visible = True

    End Sub

    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click

        ' hiding the picEquation image when the hide button is pressed
        picEquation.Visible = False

    End Sub
End Class
