<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_creditcard_pay
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_creditcard_pay))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton_ntb = New System.Windows.Forms.RadioButton()
        Me.RadioButton_hnb = New System.Windows.Forms.RadioButton()
        Me.RadioButton_cb = New System.Windows.Forms.RadioButton()
        Me.RadioButton_sb = New System.Windows.Forms.RadioButton()
        Me.RadioButton_nsb = New System.Windows.Forms.RadioButton()
        Me.RadioButton_pb = New System.Windows.Forms.RadioButton()
        Me.RadioButton_boc = New System.Windows.Forms.RadioButton()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_telephonenumber = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_customername = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_paymentamount = New System.Windows.Forms.TextBox()
        Me.txt_nic = New System.Windows.Forms.TextBox()
        Me.txt_billnumber = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbl_balance = New System.Windows.Forms.Label()
        Me.btn_calculate = New System.Windows.Forms.Button()
        Me.txt_cashreceived = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.RadioButton_cash = New System.Windows.Forms.RadioButton()
        Me.RadioButton_card = New System.Windows.Forms.RadioButton()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btn_printreceipt = New System.Windows.Forms.Button()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_user = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.btn_clearall = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.RadioButton_ntb)
        Me.GroupBox2.Controls.Add(Me.RadioButton_hnb)
        Me.GroupBox2.Controls.Add(Me.RadioButton_cb)
        Me.GroupBox2.Controls.Add(Me.RadioButton_sb)
        Me.GroupBox2.Controls.Add(Me.RadioButton_nsb)
        Me.GroupBox2.Controls.Add(Me.RadioButton_pb)
        Me.GroupBox2.Controls.Add(Me.RadioButton_boc)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(9, 92)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(242, 298)
        Me.GroupBox2.TabIndex = 80
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Bank"
        '
        'RadioButton_ntb
        '
        Me.RadioButton_ntb.AutoSize = True
        Me.RadioButton_ntb.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_ntb.Location = New System.Drawing.Point(15, 246)
        Me.RadioButton_ntb.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButton_ntb.Name = "RadioButton_ntb"
        Me.RadioButton_ntb.Size = New System.Drawing.Size(189, 26)
        Me.RadioButton_ntb.TabIndex = 6
        Me.RadioButton_ntb.TabStop = True
        Me.RadioButton_ntb.Text = "Nations Trust Bank"
        Me.RadioButton_ntb.UseVisualStyleBackColor = True
        '
        'RadioButton_hnb
        '
        Me.RadioButton_hnb.AutoSize = True
        Me.RadioButton_hnb.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_hnb.Location = New System.Drawing.Point(16, 176)
        Me.RadioButton_hnb.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButton_hnb.Name = "RadioButton_hnb"
        Me.RadioButton_hnb.Size = New System.Drawing.Size(202, 26)
        Me.RadioButton_hnb.TabIndex = 5
        Me.RadioButton_hnb.TabStop = True
        Me.RadioButton_hnb.Text = "Haton National Bank"
        Me.RadioButton_hnb.UseVisualStyleBackColor = True
        '
        'RadioButton_cb
        '
        Me.RadioButton_cb.AutoSize = True
        Me.RadioButton_cb.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_cb.Location = New System.Drawing.Point(16, 211)
        Me.RadioButton_cb.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButton_cb.Name = "RadioButton_cb"
        Me.RadioButton_cb.Size = New System.Drawing.Size(177, 26)
        Me.RadioButton_cb.TabIndex = 4
        Me.RadioButton_cb.TabStop = True
        Me.RadioButton_cb.Text = "Commercial Bank"
        Me.RadioButton_cb.UseVisualStyleBackColor = True
        '
        'RadioButton_sb
        '
        Me.RadioButton_sb.AutoSize = True
        Me.RadioButton_sb.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_sb.Location = New System.Drawing.Point(15, 140)
        Me.RadioButton_sb.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButton_sb.Name = "RadioButton_sb"
        Me.RadioButton_sb.Size = New System.Drawing.Size(149, 26)
        Me.RadioButton_sb.TabIndex = 3
        Me.RadioButton_sb.TabStop = True
        Me.RadioButton_sb.Text = "Sampath Bank"
        Me.RadioButton_sb.UseVisualStyleBackColor = True
        '
        'RadioButton_nsb
        '
        Me.RadioButton_nsb.AutoSize = True
        Me.RadioButton_nsb.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_nsb.Location = New System.Drawing.Point(16, 105)
        Me.RadioButton_nsb.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButton_nsb.Name = "RadioButton_nsb"
        Me.RadioButton_nsb.Size = New System.Drawing.Size(215, 26)
        Me.RadioButton_nsb.TabIndex = 2
        Me.RadioButton_nsb.TabStop = True
        Me.RadioButton_nsb.Text = "National Savings Bank"
        Me.RadioButton_nsb.UseVisualStyleBackColor = True
        '
        'RadioButton_pb
        '
        Me.RadioButton_pb.AutoSize = True
        Me.RadioButton_pb.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_pb.Location = New System.Drawing.Point(16, 70)
        Me.RadioButton_pb.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButton_pb.Name = "RadioButton_pb"
        Me.RadioButton_pb.Size = New System.Drawing.Size(145, 26)
        Me.RadioButton_pb.TabIndex = 1
        Me.RadioButton_pb.TabStop = True
        Me.RadioButton_pb.Text = "People's Bank"
        Me.RadioButton_pb.UseVisualStyleBackColor = True
        '
        'RadioButton_boc
        '
        Me.RadioButton_boc.AutoSize = True
        Me.RadioButton_boc.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_boc.Location = New System.Drawing.Point(16, 34)
        Me.RadioButton_boc.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButton_boc.Name = "RadioButton_boc"
        Me.RadioButton_boc.Size = New System.Drawing.Size(155, 26)
        Me.RadioButton_boc.TabIndex = 0
        Me.RadioButton_boc.TabStop = True
        Me.RadioButton_boc.Text = "Bank of Ceylon"
        Me.RadioButton_boc.UseVisualStyleBackColor = True
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.SystemColors.Control
        Me.Label33.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.Location = New System.Drawing.Point(5, 34)
        Me.Label33.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(975, 24)
        Me.Label33.TabIndex = 79
        Me.Label33.Text = "------------------------------------------- JANKO Super Center Galle  -----------" & _
    "--------------------------------"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_telephonenumber)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_customername)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_paymentamount)
        Me.GroupBox1.Controls.Add(Me.txt_nic)
        Me.GroupBox1.Controls.Add(Me.txt_billnumber)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(248, 92)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(535, 298)
        Me.GroupBox1.TabIndex = 78
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Credit Card Bill Details"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 54)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 19)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Bill Number"
        '
        'txt_telephonenumber
        '
        Me.txt_telephonenumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_telephonenumber.Location = New System.Drawing.Point(165, 176)
        Me.txt_telephonenumber.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_telephonenumber.MaxLength = 7
        Me.txt_telephonenumber.Name = "txt_telephonenumber"
        Me.txt_telephonenumber.Size = New System.Drawing.Size(335, 26)
        Me.txt_telephonenumber.TabIndex = 34
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 223)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 19)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Payment Amount"
        '
        'txt_customername
        '
        Me.txt_customername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_customername.Location = New System.Drawing.Point(166, 91)
        Me.txt_customername.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_customername.MaxLength = 10
        Me.txt_customername.Name = "txt_customername"
        Me.txt_customername.Size = New System.Drawing.Size(334, 26)
        Me.txt_customername.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 95)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 19)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Customer Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 135)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 19)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "NIC"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 180)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 19)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Telephone Number"
        '
        'txt_paymentamount
        '
        Me.txt_paymentamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_paymentamount.Location = New System.Drawing.Point(166, 219)
        Me.txt_paymentamount.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_paymentamount.MaxLength = 6
        Me.txt_paymentamount.Name = "txt_paymentamount"
        Me.txt_paymentamount.Size = New System.Drawing.Size(335, 26)
        Me.txt_paymentamount.TabIndex = 27
        '
        'txt_nic
        '
        Me.txt_nic.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nic.Location = New System.Drawing.Point(166, 131)
        Me.txt_nic.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nic.MaxLength = 10
        Me.txt_nic.Name = "txt_nic"
        Me.txt_nic.Size = New System.Drawing.Size(335, 26)
        Me.txt_nic.TabIndex = 26
        '
        'txt_billnumber
        '
        Me.txt_billnumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_billnumber.Location = New System.Drawing.Point(166, 50)
        Me.txt_billnumber.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_billnumber.MaxLength = 10
        Me.txt_billnumber.Name = "txt_billnumber"
        Me.txt_billnumber.Size = New System.Drawing.Size(334, 26)
        Me.txt_billnumber.TabIndex = 25
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.lbl_balance)
        Me.GroupBox3.Controls.Add(Me.btn_calculate)
        Me.GroupBox3.Controls.Add(Me.txt_cashreceived)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.RadioButton_cash)
        Me.GroupBox3.Controls.Add(Me.RadioButton_card)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(11, 420)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(798, 110)
        Me.GroupBox3.TabIndex = 77
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Transaction"
        '
        'lbl_balance
        '
        Me.lbl_balance.AutoSize = True
        Me.lbl_balance.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_balance.ForeColor = System.Drawing.Color.Navy
        Me.lbl_balance.Location = New System.Drawing.Point(635, 42)
        Me.lbl_balance.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_balance.Name = "lbl_balance"
        Me.lbl_balance.Size = New System.Drawing.Size(122, 36)
        Me.lbl_balance.TabIndex = 20
        Me.lbl_balance.Text = "Rs. 0.00"
        '
        'btn_calculate
        '
        Me.btn_calculate.BackColor = System.Drawing.Color.DarkBlue
        Me.btn_calculate.Font = New System.Drawing.Font("Modern No. 20", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_calculate.ForeColor = System.Drawing.Color.White
        Me.btn_calculate.Location = New System.Drawing.Point(356, 35)
        Me.btn_calculate.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_calculate.Name = "btn_calculate"
        Me.btn_calculate.Size = New System.Drawing.Size(116, 58)
        Me.btn_calculate.TabIndex = 17
        Me.btn_calculate.Text = "PAY"
        Me.btn_calculate.UseVisualStyleBackColor = False
        '
        'txt_cashreceived
        '
        Me.txt_cashreceived.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cashreceived.Location = New System.Drawing.Point(127, 75)
        Me.txt_cashreceived.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cashreceived.Name = "txt_cashreceived"
        Me.txt_cashreceived.Size = New System.Drawing.Size(179, 26)
        Me.txt_cashreceived.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(505, 46)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(113, 32)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Balance"
        '
        'RadioButton_cash
        '
        Me.RadioButton_cash.AutoSize = True
        Me.RadioButton_cash.Checked = True
        Me.RadioButton_cash.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_cash.Location = New System.Drawing.Point(127, 28)
        Me.RadioButton_cash.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButton_cash.Name = "RadioButton_cash"
        Me.RadioButton_cash.Size = New System.Drawing.Size(61, 23)
        Me.RadioButton_cash.TabIndex = 10
        Me.RadioButton_cash.TabStop = True
        Me.RadioButton_cash.Text = "Cash"
        Me.RadioButton_cash.UseVisualStyleBackColor = True
        '
        'RadioButton_card
        '
        Me.RadioButton_card.AutoSize = True
        Me.RadioButton_card.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_card.Location = New System.Drawing.Point(17, 28)
        Me.RadioButton_card.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButton_card.Name = "RadioButton_card"
        Me.RadioButton_card.Size = New System.Drawing.Size(60, 23)
        Me.RadioButton_card.TabIndex = 9
        Me.RadioButton_card.Text = "Card"
        Me.RadioButton_card.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(13, 79)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(110, 19)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Cash Recieved"
        '
        'btn_printreceipt
        '
        Me.btn_printreceipt.BackColor = System.Drawing.Color.DimGray
        Me.btn_printreceipt.Font = New System.Drawing.Font("Modern No. 20", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_printreceipt.ForeColor = System.Drawing.Color.White
        Me.btn_printreceipt.Location = New System.Drawing.Point(803, 188)
        Me.btn_printreceipt.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_printreceipt.Name = "btn_printreceipt"
        Me.btn_printreceipt.Size = New System.Drawing.Size(149, 110)
        Me.btn_printreceipt.TabIndex = 76
        Me.btn_printreceipt.Text = "PRINT RECEIPT"
        Me.btn_printreceipt.UseVisualStyleBackColor = False
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.Location = New System.Drawing.Point(851, 19)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(65, 13)
        Me.lbl_date.TabIndex = 74
        Me.lbl_date.Text = "02/07/2016"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(758, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 16)
        Me.Label10.TabIndex = 73
        Me.Label10.Text = "Date/Time :"
        '
        'lbl_user
        '
        Me.lbl_user.AutoSize = True
        Me.lbl_user.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_user.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_user.Location = New System.Drawing.Point(630, 18)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(13, 13)
        Me.lbl_user.TabIndex = 72
        Me.lbl_user.Text = "a"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(572, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 16)
        Me.Label12.TabIndex = 71
        Me.Label12.Text = "USER :"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton3, Me.ToolStripButton4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(985, 25)
        Me.ToolStrip1.TabIndex = 70
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripButton1.Text = "New"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(58, 22)
        Me.ToolStripButton3.Text = "Contacts"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(36, 22)
        Me.ToolStripButton4.Text = "Help"
        '
        'btn_clearall
        '
        Me.btn_clearall.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clearall.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_clearall.Location = New System.Drawing.Point(841, 467)
        Me.btn_clearall.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_clearall.Name = "btn_clearall"
        Me.btn_clearall.Size = New System.Drawing.Size(103, 37)
        Me.btn_clearall.TabIndex = 69
        Me.btn_clearall.Text = "Clear All"
        Me.btn_clearall.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Form_creditcard_pay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(985, 532)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btn_printreceipt)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lbl_user)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btn_clearall)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "Form_creditcard_pay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Credit Card Bill Payment"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton_hnb As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_cb As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_sb As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_nsb As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_pb As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_boc As System.Windows.Forms.RadioButton
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_telephonenumber As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_customername As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_paymentamount As System.Windows.Forms.TextBox
    Friend WithEvents txt_nic As System.Windows.Forms.TextBox
    Friend WithEvents txt_billnumber As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_balance As System.Windows.Forms.Label
    Friend WithEvents btn_calculate As System.Windows.Forms.Button
    Friend WithEvents txt_cashreceived As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents RadioButton_cash As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_card As System.Windows.Forms.RadioButton
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btn_printreceipt As System.Windows.Forms.Button
    Friend WithEvents lbl_date As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lbl_user As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_clearall As System.Windows.Forms.Button
    Friend WithEvents RadioButton_ntb As System.Windows.Forms.RadioButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
