Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (Men.Checked = True) Then
            If (N1.Value < N2.Value And N1.Value < N3.Value) Then
                MessageBox.Show("El numero menor es el Valor 1, el cual es " & N1.Value)
            ElseIf (N2.Value < N1.Value And N2.Value < N3.Value) Then
                MessageBox.Show("El numero menor es el valor 2, el cual es " & N2.Value)
            ElseIf (N3.Value < N1.Value And N3.Value < N2.Value) Then
                MessageBox.Show("El numero menor es el valor 3, el cual es " & N3.Value)
            Else
                MessageBox.Show("Todos los numeros son iguales o ya lo dañaste")
            End If
        ElseIf (Ma.Checked = True) Then
            If (N1.Value > N2.Value And N1.Value > N3.Value) Then
                MessageBox.Show("El numero mayor es el Valor 1, el cual es " & N1.Value)
            ElseIf (N2.Value > N1.Value And N2.Value > N3.Value) Then
                MessageBox.Show("El numero mayor es el valor 2, el cual es " & N2.Value)
            ElseIf (N3.Value > N1.Value And N3.Value > N2.Value) Then
                MessageBox.Show("El numero mayor es el valor 3, el cual es " & N3.Value)
            Else
                MessageBox.Show("Todos los numeros son iguales o ya lo dañaste")
            End If
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        N1.Value = 0
        N2.Value = 0
        N3.Value = 0
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub Men_CheckedChanged(sender As Object, e As EventArgs) Handles Men.CheckedChanged

    End Sub
End Class
