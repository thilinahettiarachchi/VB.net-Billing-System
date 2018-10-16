Public Class Form_Tele


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_date.Text = Date.Now

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        lbl_user.Text = user
    End Sub

    Private Sub btn_clearall_Click(sender As Object, e As EventArgs) Handles btn_clearall.Click
        txt_billnumber.Text = ""
        txt_cashreceived.Text = ""
        txt_customername.Text = ""
        txt_nic.Text = ""
        txt_paymentamount.Text = ""
        txt_telephonenumber.Text = ""
        lbl_balance.Text = "Rs. 0.00"
    End Sub

    Private Sub btn_pay_Click(sender As Object, e As EventArgs) Handles btn_pay.Click
        
        If txt_billnumber.Text = "" And txt_cashreceived.Text = "" And txt_customername.Text = "" And txt_nic.Text = "" And txt_paymentamount.Text = "" And txt_telephonenumber.Text = "" Then
            MessageBox.Show("Please fill all fields", "Error")
        ElseIf RadioButton_airtel.Checked = False And RadioButton_dialog.Checked = False And RadioButton_etisalate.Checked = False And RadioButton_hutch.Checked = False And RadioButton_mobitel.Checked = False And RadioButton_slt.Checked = False Then
            MessageBox.Show("Please select the network", "Error")
        Else
            Try
                pay = txt_paymentamount.Text
                cash = txt_cashreceived.Text
                balance = cash - pay
                lbl_balance.Text = balance
            Catch ex As InvalidCastException
                MessageBox.Show("Plese insert correct data types", "Invalid Data")
            Catch ex As OverflowException
                MessageBox.Show("Payment amounts exceed", "Invalid Data")
            End Try
        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_mobitel.CheckedChanged

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
        MessageBox.Show("This is for telephone payment")
    End Sub
End Class