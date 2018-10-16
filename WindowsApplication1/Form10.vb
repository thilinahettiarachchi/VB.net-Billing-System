Public Class form_center_reciept

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_date.Text = Date.Now
        lbl_time.Text = TimeOfDay
    End Sub

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        lbl_user.Text = user
        lbl_balance.Text = balance
        lbl_billamount.Text = pay
        lbl_cash.Text = cash
    End Sub
End Class