Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim X As Double
        If (N.Value < 50) Then
            X = (N.Value * N.Value)
            MessageBox.Show("Su cuadrado es " & X, "Cuadrado")
        ElseIf (N.Value = 55 Or N.Value = 80 Or N.Value = 75) Then
            X = Math.Pow(N.Value, (1 / 3))
            MessageBox.Show("Su raiz cubica es " & X, "Raiz Cubica")
        ElseIf (N.Value = 10 Or N.Value > 100 Or (N.Value = 3 Or N.Value = 8) Or (N.Value = 77 Or N.Value = 90)) Then
            X = (N.Value / 10)
            MessageBox.Show("Tu valor dividido entre 10 es " & X, "Divicion")
        Else
            MessageBox.Show("Tu numero es " & N.Value, "Original")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        N.Value = 0

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Close()
    End Sub
End Class
