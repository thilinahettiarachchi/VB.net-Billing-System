<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Tele
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Tele))
        Me.Label33 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_nic = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_telephonenumber = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_paymentamount = New System.Windows.Forms.TextBox()
        Me.txt_customername = New System.Windows.Forms.TextBox()
        Me.txt_billnumber = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbl_balance = New System.Windows.Forms.Label()
        Me.btn_pay = New System.Windows.Forms.Button()
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton_hutch = New System.Windows.Forms.RadioButton()
        Me.RadioButton_airtel = New System.Windows.Forms.RadioButton()
        Me.RadioButton_etisalate = New System.Windows.Forms.RadioButton()
        Me.RadioButton_dialog = New System.Windows.Forms.RadioButton()
        Me.RadioButton_mobitel = New System.Windows.Forms.RadioButton()
        Me.RadioButton_slt = New System.Windows.Forms.RadioButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.Location = New System.Drawing.Point(5, 31)
        Me.Label33.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(975, 24)
        Me.Label33.TabIndex = 65
        Me.Label33.Text = "------------------------------------------- JANKO Super Center Galle  -----------" & _
    "--------------------------------"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_nic)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_telephonenumber)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_paymentamount)
        Me.GroupBox1.Controls.Add(Me.txt_customername)
        Me.GroupBox1.Controls.Add(Me.txt_billnumber)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(248, 89)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(535, 298)
        Me.GroupBox1.TabIndex = 64
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Telephone Bill Details"
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
        'txt_nic
        '
        Me.txt_nic.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nic.Location = New System.Drawing.Point(165, 176)
        Me.txt_nic.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nic.MaxLength = 7
        Me.txt_nic.Name = "txt_nic"
        Me.txt_nic.Size = New System.Drawing.Size(335, 26)
        Me.txt_nic.TabIndex = 34
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
        'txt_telephonenumber
        '
        Me.txt_telephonenumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_telephonenumber.Location = New System.Drawing.Point(166, 91)
        Me.txt_telephonenumber.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_telephonenumber.MaxLength = 10
        Me.txt_telephonenumber.Name = "txt_telephonenumber"
        Me.txt_telephonenumber.Size = New System.Drawing.Size(334, 26)
        Me.txt_telephonenumber.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 135)
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
        Me.Label2.Location = New System.Drawing.Point(23, 180)
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
        Me.Label1.Location = New System.Drawing.Point(23, 95)
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
        'txt_customername
        '
        Me.txt_customername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_customername.Location = New System.Drawing.Point(166, 131)
        Me.txt_customername.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_customername.MaxLength = 10
        Me.txt_customername.Name = "txt_customername"
        Me.txt_customername.Size = New System.Drawing.Size(335, 26)
        Me.txt_customername.TabIndex = 26
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
        Me.GroupBox3.Controls.Add(Me.btn_pay)
        Me.GroupBox3.Controls.Add(Me.txt_cashreceived)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.RadioButton_cash)
        Me.GroupBox3.Controls.Add(Me.RadioButton_card)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(11, 417)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(798, 110)
        Me.GroupBox3.TabIndex = 63
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
        'btn_pay
        '
        Me.btn_pay.BackColor = System.Drawing.Color.DarkBlue
        Me.btn_pay.Font = New System.Drawing.Font("Modern No. 20", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pay.ForeColor = System.Drawing.Color.White
        Me.btn_pay.Location = New System.Drawing.Point(356, 35)
        Me.btn_pay.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_pay.Name = "btn_pay"
        Me.btn_pay.Size = New System.Drawing.Size(116, 58)
        Me.btn_pay.TabIndex = 17
        Me.btn_pay.Text = "PAY"
        Me.btn_pay.UseVisualStyleBackColor = False
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
        Me.btn_printreceipt.Location = New System.Drawing.Point(800, 184)
        Me.btn_printreceipt.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_printreceipt.Name = "btn_printreceipt"
        Me.btn_printreceipt.Size = New System.Drawing.Size(149, 110)
        Me.btn_printreceipt.TabIndex = 62
        Me.btn_printreceipt.Text = "PRINT RECEIPT"
        Me.btn_printreceipt.UseVisualStyleBackColor = False
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.Location = New System.Drawing.Point(851, 16)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(65, 13)
        Me.lbl_date.TabIndex = 60
        Me.lbl_date.Text = "02/07/2016"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(758, 13)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 16)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "Date/Time :"
        '
        'lbl_user
        '
        Me.lbl_user.AutoSize = True
        Me.lbl_user.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_user.Location = New System.Drawing.Point(630, 15)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(106, 13)
        Me.lbl_user.TabIndex = 58
        Me.lbl_user.Text = "A.B.De Kudu Nuwan"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(572, 13)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 16)
        Me.Label12.TabIndex = 57
        Me.Label12.Text = "USER :"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton3, Me.ToolStripButton4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(985, 25)
        Me.ToolStrip1.TabIndex = 56
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
        Me.btn_clearall.Location = New System.Drawing.Point(835, 458)
        Me.btn_clearall.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_clearall.Name = "btn_clearall"
        Me.btn_clearall.Size = New System.Drawing.Size(103, 37)
        Me.btn_clearall.TabIndex = 55
        Me.btn_clearall.Text = "Clear All"
        Me.btn_clearall.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.RadioButton_hutch)
        Me.GroupBox2.Controls.Add(Me.RadioButton_airtel)
        Me.GroupBox2.Controls.Add(Me.RadioButton_etisalate)
        Me.GroupBox2.Controls.Add(Me.RadioButton_dialog)
        Me.GroupBox2.Controls.Add(Me.RadioButton_mobitel)
        Me.GroupBox2.Controls.Add(Me.RadioButton_slt)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(28, 89)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(167, 298)
        Me.GroupBox2.TabIndex = 66
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Network"
        '
        'RadioButton_hutch
        '
        Me.RadioButton_hutch.AutoSize = True
        Me.RadioButton_hutch.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_hutch.Location = New System.Drawing.Point(29, 197)
        Me.RadioButton_hutch.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButton_hutch.Name = "RadioButton_hutch"
        Me.RadioButton_hutch.Size = New System.Drawing.Size(77, 26)
        Me.RadioButton_hutch.TabIndex = 5
        Me.RadioButton_hutch.TabStop = True
        Me.RadioButton_hutch.Text = "Hutch"
        Me.RadioButton_hutch.UseVisualStyleBackColor = True
        '
        'RadioButton_airtel
        '
        Me.RadioButton_airtel.AutoSize = True
        Me.RadioButton_airtel.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_airtel.Location = New System.Drawing.Point(29, 232)
        Me.RadioButton_airtel.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButton_airtel.Name = "RadioButton_airtel"
        Me.RadioButton_airtel.Size = New System.Drawing.Size(74, 26)
        Me.RadioButton_airtel.TabIndex = 4
        Me.RadioButton_airtel.TabStop = True
        Me.RadioButton_airtel.Text = "Airtel"
        Me.RadioButton_airtel.UseVisualStyleBackColor = True
        '
        'RadioButton_etisalate
        '
        Me.RadioButton_etisalate.AutoSize = True
        Me.RadioButton_etisalate.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_etisalate.Location = New System.Drawing.Point(28, 161)
        Me.RadioButton_etisalate.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButton_etisalate.Name = "RadioButton_etisalate"
        Me.RadioButton_etisalate.Size = New System.Drawing.Size(100, 26)
        Me.RadioButton_etisalate.TabIndex = 3
        Me.RadioButton_etisalate.TabStop = True
        Me.RadioButton_etisalate.Text = "Etisalate"
        Me.RadioButton_etisalate.UseVisualStyleBackColor = True
        '
        'RadioButton_dialog
        '
        Me.RadioButton_dialog.AutoSize = True
        Me.RadioButton_dialog.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_dialog.Location = New System.Drawing.Point(29, 126)
        Me.RadioButton_dialog.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButton_dialog.Name = "RadioButton_dialog"
        Me.RadioButton_dialog.Size = New System.Drawing.Size(82, 26)
        Me.RadioButton_dialog.TabIndex = 2
        Me.RadioButton_dialog.TabStop = True
        Me.RadioButton_dialog.Text = "Dialog"
        Me.RadioButton_dialog.UseVisualStyleBackColor = True
        '
        'RadioButton_mobitel
        '
        Me.RadioButton_mobitel.AutoSize = True
        Me.RadioButton_mobitel.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_mobitel.Location = New System.Drawing.Point(29, 91)
        Me.RadioButton_mobitel.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButton_mobitel.Name = "RadioButton_mobitel"
        Me.RadioButton_mobitel.Size = New System.Drawing.Size(91, 26)
        Me.RadioButton_mobitel.TabIndex = 1
        Me.RadioButton_mobitel.TabStop = True
        Me.RadioButton_mobitel.Text = "Mobitel"
        Me.RadioButton_mobitel.UseVisualStyleBackColor = True
        '
        'RadioButton_slt
        '
        Me.RadioButton_slt.AutoSize = True
        Me.RadioButton_slt.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_slt.Location = New System.Drawing.Point(29, 55)
        Me.RadioButton_slt.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButton_slt.Name = "RadioButton_slt"
        Me.RadioButton_slt.Size = New System.Drawing.Size(62, 26)
        Me.RadioButton_slt.TabIndex = 0
        Me.RadioButton_slt.TabStop = True
        Me.RadioButton_slt.Text = "SLT"
        Me.RadioButton_slt.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Form_Tele
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
        Me.Name = "Form_Tele"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Telephone Bill Payment"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_nic As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_telephonenumber As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_paymentamount As System.Windows.Forms.TextBox
    Friend WithEvents txt_customername As System.Windows.Forms.TextBox
    Friend WithEvents txt_billnumber As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_balance As System.Windows.Forms.Label
    Friend WithEvents btn_pay As System.Windows.Forms.Button
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton_hutch As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_airtel As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_etisalate As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_dialog As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_mobitel As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_slt As System.Windows.Forms.RadioButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
