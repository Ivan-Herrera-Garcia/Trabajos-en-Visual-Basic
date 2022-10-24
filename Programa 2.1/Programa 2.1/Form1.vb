Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim A As Double
        Dim B As Integer
        A = N.Value / 2
        B = N.Value / 2
        If A = B Then
            MessageBox.Show("Tu numero es Par Bv")
        Else
            MessageBox.Show("Tu numero no es Par :(")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        N.Value = 0
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Close()
    End Sub
End Class
