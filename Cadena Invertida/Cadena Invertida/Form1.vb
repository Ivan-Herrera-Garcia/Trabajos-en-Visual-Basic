Public Class Form1

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Close()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Ca.Clear()
        Inv.Clear()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim N, I As Integer
        Dim Texto As String = ""
        N = Ca.Text.Length()
        For I = N - 1 To 0 Step -1
            Texto = Texto & Ca.Text(I)
        Next
        Inv.Text = Texto
    End Sub
End Class
