Public Class Form1
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Button1.PerformClick()
        End If
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub DoWhileLoop(n As Integer)
        With ListBox1.Items
            .Clear()
            Dim Bil1, Bil2 As Integer
            Bil1 = 1
            Do While Bil1 <= n
                .Add(Bil1 & ".")
                Bil2 = 1
                Do While Bil2 <= n
                    .Add(Bil1 & "." & Bil2)
                    Bil2 += 1
                Loop
                Bil1 += 1
            Loop
        End With
    End Sub

    Private Sub DoLoopUntil(n As Integer)
        With ListBox1.Items
            .Clear()
            Dim Bil1, Bil2 As Integer
            Bil1 = 1
            Do
                .Add(Bil1 & ".")
                Bil2 = 1
                Do
                    .Add(Bil1 & "." & Bil2)
                    Bil2 += 1
                Loop Until Bil2 = n
                Bil1 += 1
            Loop Until Bil1 = n
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If RadioButton1.Checked Then
                DoWhileLoop(TextBox1.Text)
            ElseIf RadioButton2.Checked Then
                DoLoopUntil(TextBox1.Text)
            End If
        Catch er As InvalidCastException
            Debug.Print(er.Message)
        End Try
    End Sub
End Class
