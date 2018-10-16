Module username
    Public user As String
End Module

Public Class Form1

    Private Sub btn_log_Click(sender As Object, e As EventArgs) Handles btn_log.Click
        If txt_username.Text = "JA01" And txt_password.Text = "j123" Then
            user = txt_username.Text
            Me.Hide()
            Form2.Show()
        ElseIf txt_username.Text = "JA02" And txt_password.Text = "j456" Then
            user = txt_username.Text
            Me.Hide()
            Form2.Show()
        ElseIf txt_username.Text = "JA03" And txt_password.Text = "j789" Then
            user = txt_username.Text
            Me.Hide()
            Form2.Show()
        Else
            MessageBox.Show(" Plese enter a correct user name and password", "INCORRECT PASSWORD...!!", MessageBoxButtons.OK)
            txt_username.Text = ""
            txt_password.Text = ""
        End If
        txt_username.Text = ""
        txt_password.Text = ""
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Dim x As DialogResult
        x = MessageBox.Show("Are you sure you want to Exit?", "EXIT??", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If x = vbYes Then
            Me.Close()
        ElseIf x = vbNo Then
            Me.Show()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Welcome to JANKO Super Centre Bill Management System. Please Loggin...", "-- JANKO --", MessageBoxButtons.OK)
    End Sub

    Private Sub NIBM_Click(sender As Object, e As EventArgs) Handles NIBM.Click

    End Sub
End Class
