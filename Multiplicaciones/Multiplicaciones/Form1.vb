Public Class Form1

    Private Sub limpiar()

        ListBox1.Items.Clear()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        limpiar()


        Dim X, Z, V As Double
        X = T.Value
        For Z = 1 To 10 Step +1
            V = X * Z
            ListBox1.Items.Add(X & "*" & Z & "=" & V)
        Next
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        limpiar()
        T.Value = 0


    End Sub
End Class
