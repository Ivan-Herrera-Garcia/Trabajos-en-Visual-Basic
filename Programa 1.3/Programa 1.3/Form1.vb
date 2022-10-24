Public Class Form1

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        A.Clear()
        B.Clear()
        C.Clear()
        X1.Clear()
        X2.Clear()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Va, Vb, Vc As Double
        Va = Double.Parse(A.Text)
        Vb = Double.Parse(B.Text)
        Vc = Double.Parse(C.Text)

        X1.Text = (-Vb + Math.Sqrt(Vb ^ 2 - 4 * Va * Vc)) / (2 * Va)
        X2.Text = (-Vb - Math.Sqrt(Vb ^ 2 - 4 * Va * Vc)) / (2 * Va)

    End Sub
End Class
