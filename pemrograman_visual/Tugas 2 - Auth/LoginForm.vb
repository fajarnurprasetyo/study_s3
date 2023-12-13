Imports MaterialSkin

Public Class LoginForm
    Private ShowPassword As Boolean = False

    Private Sub Submit()
        If InputEmail.TextLength = 0 Then
            MsgBox("Email tidak boleh kosong!")
            Return
        End If

        If Not InputEmail.Text = "fajarnurprasetyo.2@gmail.com" Then
            MsgBox("Email salah!")
            Return
        End If

        If InputPassword.TextLength = 0 Then
            MsgBox("Password tidak boleh kosong!")
            Return
        End If

        If Not InputPassword.Text = "admin" Then
            MsgBox("Password salah!")
            Return
        End If

        MsgBox("Selamat Datang!")
        Close()
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE)
    End Sub

    Private Sub LoginForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown, InputEmail.KeyDown, InputPassword.KeyDown
        If e.KeyCode = 27 Then
            e.Handled = True
            Close()
        End If
        If e.KeyCode = 13 Then
            e.Handled = True
            Submit()
        End If
    End Sub

    Private Sub InputPassword_Click(sender As Object, e As EventArgs) Handles InputPassword.TrailingIconClick
        ShowPassword = Not ShowPassword
        If ShowPassword Then
            InputPassword.UseSystemPasswordChar = False
            InputPassword.PasswordChar = ""
            InputPassword.TrailingIcon = My.Resources.visibility_off
        Else
            InputPassword.UseSystemPasswordChar = True
            InputPassword.TrailingIcon = My.Resources.visibility
        End If
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Submit()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As MouseEventArgs) Handles BtnClose.Click
        Close()
    End Sub
End Class
