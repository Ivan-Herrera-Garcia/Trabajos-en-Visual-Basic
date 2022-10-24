Public Class Form1

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        R.Clear()
        A.Clear()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub RUN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RUN.Click
        Dim X As Double
        X = (3.1416) * ((R.Text * R.Text) / 2)
        A.Text = X

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
