Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim X As Double
        Dim Valor As Double
        Valor = D.Text
        X = S.Value * Valor
        R.Text = (X)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub E_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S.ValueChanged

    End Sub

    Private Sub D_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D.TextChanged

    End Sub

    Private Sub R_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        D.Clear()
        R.Clear()
        S.Value = 0

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Close()
    End Sub
End Class
