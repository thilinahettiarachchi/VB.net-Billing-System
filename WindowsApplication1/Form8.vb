Public Class Form_bill


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_date.Text = Date.Now
        lbl_time.Text = TimeOfDay
    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        lbl_user.Text = user
    End Sub

End Class