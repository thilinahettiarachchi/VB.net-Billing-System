Imports System.Data.OleDb

Module module1
    Public j As Integer
    Public k As Integer
    Public total As Integer
    Dim i As Integer

    Public billnettotal As Integer
    Public billbalance As Integer
    Public billcash As Integer

End Module

Public Class Form2

    Dim connection As OleDbConnection
    Dim reader As OleDbDataReader
    Dim command As OleDbCommand
    
    Dim cashreceived As Integer
    Dim nettotal As Integer
    Dim balance As Integer

    Dim cashreceived1 As Integer
    Dim nettotal1 As Integer
    Dim balance1 As Integer





    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridView1.Columns.Add(0, "Item ID")
        DataGridView1.Columns.Add(1, "Item Name")
        DataGridView1.Columns.Add(2, "Description")
        DataGridView1.Columns.Add(3, "Price")
        DataGridView1.Columns.Add(4, "Quantity")

        DataGridView2.Columns.Add(0, "Item ID")
        DataGridView2.Columns.Add(1, "Item Name")
        DataGridView2.Columns.Add(2, "Description")
        DataGridView2.Columns.Add(3, "Price")
        DataGridView2.Columns.Add(4, "Quantity")

        Timer1.Enabled = True
       
        lbl_username.Text = user
    End Sub


    Private Sub btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click
        txt_itemcode.Text = ""
        txt_quantity.Text = ""
    End Sub

    Private Sub btn_additem_Click(sender As Object, e As EventArgs) Handles btn_additem.Click

        connection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Desktop\thilina\VB final\New folder\WindowsApplication1\WindowsApplication1\Database2.accdb")
        Try
            connection.Open()
            command = New OleDbCommand("SELECT * FROM Items WHERE Item_ID =" & txt_itemcode.Text, connection)
            reader = command.ExecuteReader

            DataGridView1.DataSource = Nothing

            Dim row As String()
            Do While reader.Read()
                row = New String() {reader("Item_ID"), reader("Item_Name"), reader("Description"), reader("Price"), txt_quantity.Text}
                DataGridView1.Rows.Add(row)
            Loop
        Catch ex As OleDbException
            MessageBox.Show("Database connection failed")
        End Try


        total = 0
        
        For i = 0 To DataGridView1.Rows.Count - 1
            j = DataGridView1.Rows(i).Cells(3).Value
            k = DataGridView1.Rows(i).Cells(4).Value
            total = total + j * k

        Next
        lbl_nettotal.Text = total

    End Sub

    Private Sub btn_check_Click(sender As Object, e As EventArgs) Handles btn_check.Click
        If rb_cash.Checked = True Then
            txt_cashreceived.Text = 0
        Else
            form_card_reciept.Show()
            billnettotal = lbl_nettotal.Text

            form_card_reciept.lbl_billamount.Text = billnettotal
        End If
    End Sub

    Private Sub btn_nettotal_Click(sender As Object, e As EventArgs) Handles btn_nettotal.Click
        cashreceived = txt_cashreceived.Text
        nettotal = lbl_nettotal.Text
        balance = cashreceived - nettotal
        lbl_balance.Text = balance
    End Sub

    Private Sub btn_clearall_Click(sender As Object, e As EventArgs) Handles btn_clearall.Click
        txt_itemcode.Text = ""
        txt_quantity.Text = ""
        txt_cashreceived.Text = ""
        lbl_nettotal.Text = ""
        lbl_balance.Text = ""
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub btn_itemlist_Click(sender As Object, e As EventArgs) Handles btn_itemlist.Click
        Form12.Show()
        connection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Desktop\thilina\VB final\New folder\WindowsApplication1\WindowsApplication1\Database2.accdb")
        Try
            connection.Open()
            command = New OleDbCommand("SELECT * FROM Items", connection)
            reader = command.ExecuteReader

            Form12.DataGridView4.DataSource = Nothing

            Dim row As String()
            Do While reader.Read()
                row = New String() {reader("Item_ID"), reader("Item_Name"), reader("Description"), reader("Price")}
                Form12.DataGridView4.Rows.Add(row)
            Loop
        Catch ex As OleDbException
            MessageBox.Show("Database connection failed")
        End Try

    End Sub

    Private Sub btn_clearitem_Click(sender As Object, e As EventArgs) Handles btn_clearitem.Click
        j = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(3).Value
        k = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(4).Value
        total = total - j * k
        lbl_nettotal.Text = total
        DataGridView1.Rows.RemoveAt(DataGridView1.CurrentRow.Index)

    End Sub

    Private Sub btn_printbill_Click(sender As Object, e As EventArgs) Handles btn_printbill.Click
        Form_bill.Show()
        billnettotal = lbl_nettotal.Text
        billbalance = lbl_balance.Text
        billcash = txt_cashreceived.Text

        Form_bill.lbl_nettotal.Text = billnettotal
        Form_bill.lbl_cash.Text = billcash
        Form_bill.lbl_balance.Text = billbalance

    End Sub









    Private Sub btn_electricitybill_Click(sender As Object, e As EventArgs) Handles btn_electricitybill.Click
        Form_electricity.Show()
    End Sub

    Private Sub btn_waterbill_Click(sender As Object, e As EventArgs) Handles btn_waterbill.Click
        Form_water.Show()
    End Sub

    Private Sub btn_telephonebill_Click(sender As Object, e As EventArgs) Handles btn_telephonebill.Click
        Form_Tele.Show()
    End Sub

    Private Sub btn_creditcard_Click(sender As Object, e As EventArgs) Handles btn_creditcard.Click
        Form_creditcard_pay.Show()
    End Sub

    Private Sub btn_reload_Click(sender As Object, e As EventArgs) Handles btn_reload.Click
        Form_reload.Show()
    End Sub









    Private Sub btn_next1_Click(sender As Object, e As EventArgs) Handles btn_next1.Click


        connection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Desktop\thilina\VB final\New folder\WindowsApplication1\WindowsApplication1\custommode.accdb")
        command = New OleDbCommand("Insert into custommode values (@Item_ID, @Item_Name, @Description, @Unit_Price, @Quantity)", connection)
        Try
            connection.Open()
            command.Parameters.AddWithValue("@Item_ID", txt_itemcode1.Text)
            command.Parameters.AddWithValue("@Item_Name", txt_itemname.Text)
            command.Parameters.AddWithValue("@Description", txt_description.Text)
            command.Parameters.AddWithValue("@Unit_Price", txt_unitprice.Text)
            command.Parameters.AddWithValue("@Quantity", txt_quantity1.Text)
            command.ExecuteNonQuery()
            connection.Close()

        Catch ex As Exception

        End Try

        connection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Desktop\thilina\VB final\New folder\WindowsApplication1\WindowsApplication1\custommode.accdb")
        Try
            connection.Open()
            command = New OleDbCommand("SELECT * FROM custommode", connection)
            reader = command.ExecuteReader

            DataGridView2.DataSource = Nothing

            Dim row As String()
            Do While reader.Read()
                row = New String() {reader("Item_ID"), reader("Item_Name"), reader("Description"), reader("Unit_Price"), reader("Quantity")}
                DataGridView2.Rows.Add(row)
            Loop
        Catch ex As OleDbException
            MessageBox.Show("Database connection failed")
        End Try


        Dim p As Integer

        total = 0
        For p = 0 To DataGridView2.Rows.Count - 1
            j = DataGridView2.Rows(p).Cells(3).Value
            k = DataGridView2.Rows(p).Cells(4).Value
            total = total + j * k

        Next
        lbl_nettotal1.Text = total

    End Sub

    Private Sub btn_clear1_Click(sender As Object, e As EventArgs) Handles btn_clear1.Click
        txt_itemcode1.Text = ""
        txt_itemname.Text = ""
        txt_description.Text = ""
        txt_unitprice.Text = ""
        txt_quantity1.Text = ""
    End Sub

    Private Sub btn_check1_Click(sender As Object, e As EventArgs) Handles btn_check1.Click
        If rb_cash1.Checked = True Then
            txt_cashreceived1.Text = 0
        Else
            form_card_reciept.Show()
            
            billnettotal = lbl_nettotal1.Text
            
            form_card_reciept.lbl_billamount.Text = billnettotal
            
        End If
    End Sub

    Private Sub btn_itemlist1_Click(sender As Object, e As EventArgs) Handles btn_itemlist1.Click
        Form12.Show()
        connection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Desktop\thilina\VB final\New folder\WindowsApplication1\WindowsApplication1\Database2.accdb")
        Try
            connection.Open()
            command = New OleDbCommand("SELECT * FROM Items", connection)
            reader = command.ExecuteReader

            Form12.DataGridView4.DataSource = Nothing

            Dim row As String()
            Do While reader.Read()
                row = New String() {reader("Item_ID"), reader("Item_Name"), reader("Description"), reader("Price")}
                Form12.DataGridView4.Rows.Add(row)
            Loop
        Catch ex As OleDbException
            MessageBox.Show("Database connection failed")
        End Try

    End Sub

    Private Sub btn_clearitem1_Click(sender As Object, e As EventArgs) Handles btn_clearitem1.Click
        j = DataGridView2.Rows(DataGridView2.CurrentRow.Index).Cells(3).Value
        k = DataGridView2.Rows(DataGridView2.CurrentRow.Index).Cells(4).Value
        total = total - j * k
        lbl_nettotal.Text = total
        DataGridView2.Rows.RemoveAt(DataGridView2.CurrentRow.Index)
    End Sub

    Private Sub btn_clearall1_Click(sender As Object, e As EventArgs) Handles btn_clearall1.Click
        DataGridView2.Rows.Clear()
        txt_itemcode1.Text = ""
        txt_itemname.Text = ""
        txt_description.Text = ""
        txt_unitprice.Text = ""
        txt_quantity1.Text = ""
        lbl_nettotal1.Text = ""
        lbl_balance1.Text = ""
    End Sub

    Private Sub btn_nettotal1_Click(sender As Object, e As EventArgs) Handles btn_nettotal1.Click
        cashreceived1 = txt_cashreceived1.Text
        nettotal1 = lbl_nettotal1.Text
        balance1 = cashreceived1 - nettotal1
        lbl_balance1.Text = balance1
    End Sub












    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        connection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Desktop\thilina\VB final\New folder\WindowsApplication1\WindowsApplication1\Customers.accdb")
        command = New OleDbCommand("Insert into Customers values (@NIC, @Customer_Name,@Telephone_Number,@Email_Address)", connection)
        Try
            connection.Open()
            command.Parameters.AddWithValue("@NIC", txt_nic.Text)
            command.Parameters.AddWithValue("@Customer_Name", txt_customername.Text)
            command.Parameters.AddWithValue("@Telephone_Number", txt_telephonenumber.Text)
            command.Parameters.AddWithValue("@Email_Address", txt_emailaddress.Text)
            command.ExecuteNonQuery()
            connection.Close()
            MessageBox.Show("Add Customer Successfully")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_clear2_Click(sender As Object, e As EventArgs) Handles btn_clear2.Click
        txt_nic.Text = ""
        txt_customername.Text = ""
        txt_telephonenumber.Text = ""
        txt_emailaddress.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_date.Text = Date.Now

    End Sub

    Private Sub btn_printbill1_Click(sender As Object, e As EventArgs) Handles btn_printbill1.Click
        Form_bill.Show()

        billnettotal = lbl_nettotal1.Text
        billbalance = lbl_balance1.Text
        billcash = txt_cashreceived1.Text

        Form_bill.lbl_nettotal.Text = billnettotal
        Form_bill.lbl_cash.Text = billcash
        Form_bill.lbl_balance.Text = billbalance

    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        MessageBox.Show(" Branch Manager - 071 555784 , Colombo Branch - 011 5698744", "Contacts")
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        MessageBox.Show("JANKO BILL for calculate bill using item code/ PAYMENT & RELOAD for pay other bills and reload facility/ CUSTOM MODE for manual bill calculation/ ADD CUSTOMER for add customer details into database")
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        txt_itemcode.Text = ""
        txt_quantity.Text = ""
        txt_cashreceived.Text = ""
        lbl_nettotal.Text = ""
        lbl_balance.Text = ""
        DataGridView1.Rows.Clear()
    End Sub
End Class





