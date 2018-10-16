Public Class Form_reload


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_date.Text = Date.Now

    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        lbl_user.Text = user
    End Sub

    Private Sub btn_clearall_Click(sender As Object, e As EventArgs) Handles btn_clearall.Click
        txt_cashreceived.Text = ""
        txt_reloadamount.Text = ""
        txt_telephonenumber.Text = ""
        lbl_balance.Text = "Rs 0.00"
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        txt_cashreceived.Text = ""
        txt_reloadamount.Text = ""
        txt_telephonenumber.Text = ""
        lbl_balance.Text = "Rs 0.00"
    End Sub

    Private Sub btn_reload_Click(sender As Object, e As EventArgs) Handles btn_reload.Click

        Dim reload As Double
        If txt_cashreceived.Text = "" And txt_reloadamount.Text = "" And txt_telephonenumber.Text = "" Then
            MessageBox.Show("Please fill all fields", "Error")
        Else


            Try
                reload = txt_reloadamount.Text
                cash = txt_cashreceived.Text
                balance = cash - reload

                lbl_balance.Text = "Rs " + balance
            Catch ex As InvalidCastException
                MessageBox.Show("Plese insert correct data types", "Invalid Data")
            Catch ex As OverflowException
                MessageBox.Show("Reload amounts exceed", "Error")

            End Try
        End If
    End Sub

    Private Sub btn_printreceipt_Click(sender As Object, e As EventArgs) Handles btn_printreceipt.Click
        If RadioButton_card.Checked = True Then
            form_card_reciept.Show()
            form_center_reciept.Show()
        Else
            form_center_reciept.Show()
        End If
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        MessageBox.Show(" Branch Manager - 071 555784 , Colombo Branch - 011 5698744", "Contacts")
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        MessageBox.Show("This is for reloading facility")
    End Sub
End Class