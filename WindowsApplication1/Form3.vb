Module moduleA
    Public balance As Integer
    Public cash As Double
    Public pay As Double
End Module

Public Class Form_electricity


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_date.Text = Date.Now

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_user.Text = user
        Timer1.Enabled = True
    End Sub

    Private Sub btn_printreceipt_Click(sender As Object, e As EventArgs) Handles btn_printreceipt.Click
        If RadioButton_card.Checked = True Then
            form_card_reciept.Show()
            form_center_reciept.Show()
        Else
            form_center_reciept.Show()
        End If

    End Sub

    Private Sub btn_clearall_Click(sender As Object, e As EventArgs) Handles btn_clearall.Click
        txt_billnumber.Text = ""
        txt_cashreceived2.Text = ""
        txt_customername.Text = ""
        txt_nic.Text = ""
        txt_paymentamount.Text = ""
        txt_telephonenumber.Text = ""
        lbl_balance.Text = "Rs. 0.00"
    End Sub

    Private Sub btn_pay_Click(sender As Object, e As EventArgs) Handles btn_pay.Click
        
        If txt_billnumber.Text = "" And txt_cashreceived2.Text = "" And txt_customername.Text = "" And txt_nic.Text = "" And txt_paymentamount.Text = "" And txt_telephonenumber.Text = "" Then
            MessageBox.Show("Please fill all fields", "Error")
        Else
            Try
                pay = txt_paymentamount.Text
                cash = txt_cashreceived2.Text
                balance = cash - pay
                lbl_balance.Text = balance

            Catch ex As InvalidCastException
                MessageBox.Show("Plese insert correct data types", "Invalid Data")
            Catch ex As OverflowException
                MessageBox.Show("Payment amounts exceed", "Invalid Data")
            End Try
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        txt_billnumber.Text = ""
        txt_cashreceived2.Text = ""
        txt_customername.Text = ""
        txt_nic.Text = ""
        txt_paymentamount.Text = ""
        txt_telephonenumber.Text = ""
        lbl_balance.Text = "Rs. 0.00"
    End Sub

    Private Sub txt_telephonenumber_TextChanged(sender As Object, e As EventArgs) Handles txt_telephonenumber.TextChanged

    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        MessageBox.Show(" Branch Manager - 071 555784 , Colombo Branch - 011 5698744", "Contacts")
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        MessageBox.Show("This is for electricity bill payment")
    End Sub
End Class