Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ListBox1.Items.Add(N.Text)
        N.Clear()

    End Sub

    Private Sub E_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N.TextChanged

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        N.Clear()
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim T As Double
        Dim I, J As Integer
        For I = 1 To ListBox1.Items.Count - 1
            For J = 0 To ListBox1.Items.Count - I - 1
                If (ASC.Checked = True) Then
                    If (ListBox1.Items.Item(J) > ListBox1.Items.Item(J + 1)) Then
                        T = ListBox1.Items.Item(J + 1)
                        ListBox1.Items.Item(J + 1) = ListBox1.Items.Item(J)
                        ListBox1.Items.Item(J) = T
                    End If
                ElseIf (ListBox1.Items.Item(J) < ListBox1.Items.Item(J + 1)) Then
                    T = ListBox1.Items.Item(J + 1)
                    ListBox1.Items.Item(J + 1) = ListBox1.Items.Item(J)
                    ListBox1.Items.Item(J) = T
                End If

            Next
        Next

    End Sub
End Class
