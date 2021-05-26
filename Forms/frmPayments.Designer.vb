<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayments
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPayments))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtgSales = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.lblrecordcount = New System.Windows.Forms.Label()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.panelPayment = New System.Windows.Forms.Panel()
        Me.btnBrowseStudent = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtYrSection = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panelpay = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.dtpaymentDate = New System.Windows.Forms.DateTimePicker()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtAmountPaid = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.bntClear = New System.Windows.Forms.Button()
        Me.lblItemCode = New System.Windows.Forms.Label()
        Me.lblAccountID = New System.Windows.Forms.Label()
        Me.lblSchedID = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dtgSchoolFee = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtbalance = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.txttotalPayment = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotalpayable = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbldesc = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtAccountID = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtStudentCode = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtgender = New System.Windows.Forms.TextBox()
        Me.txtStudentFullname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel4.SuspendLayout()
        CType(Me.dtgSales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.panelPayment.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelpay.SuspendLayout()
        Me.Panel10.SuspendLayout()
        CType(Me.dtgSchoolFee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Goldenrod
        Me.Panel4.Controls.Add(Me.btnClose)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1020, 26)
        Me.Panel4.TabIndex = 581
        '
        'btnClose
        '
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClose.ImageIndex = 1
        Me.btnClose.Location = New System.Drawing.Point(989, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(31, 26)
        Me.btnClose.TabIndex = 218
        Me.btnClose.Text = "X"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(6, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 16)
        Me.Label5.TabIndex = 137
        Me.Label5.Text = "PAYMENT ENTRY"
        '
        'dtgSales
        '
        Me.dtgSales.AllowUserToAddRows = False
        Me.dtgSales.AllowUserToDeleteRows = False
        Me.dtgSales.AllowUserToResizeColumns = False
        Me.dtgSales.AllowUserToResizeRows = False
        Me.dtgSales.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dtgSales.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgSales.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dtgSales.ColumnHeadersHeight = 26
        Me.dtgSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtgSales.EnableHeadersVisualStyles = False
        Me.dtgSales.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dtgSales.Location = New System.Drawing.Point(4, 62)
        Me.dtgSales.MultiSelect = False
        Me.dtgSales.Name = "dtgSales"
        Me.dtgSales.ReadOnly = True
        Me.dtgSales.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtgSales.RowHeadersVisible = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.dtgSales.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dtgSales.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgSales.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dtgSales.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DodgerBlue
        Me.dtgSales.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dtgSales.RowTemplate.Height = 25
        Me.dtgSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgSales.Size = New System.Drawing.Size(1008, 608)
        Me.dtgSales.TabIndex = 716
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.btnPrint)
        Me.Panel2.Controls.Add(Me.lblrecordcount)
        Me.Panel2.Controls.Add(Me.btnNew)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 675)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1020, 29)
        Me.Panel2.TabIndex = 715
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.Location = New System.Drawing.Point(110, 1)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(100, 26)
        Me.btnPrint.TabIndex = 749
        Me.btnPrint.Text = "Print "
        Me.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'lblrecordcount
        '
        Me.lblrecordcount.AutoSize = True
        Me.lblrecordcount.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrecordcount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblrecordcount.Location = New System.Drawing.Point(823, 6)
        Me.lblrecordcount.Name = "lblrecordcount"
        Me.lblrecordcount.Size = New System.Drawing.Size(90, 17)
        Me.lblrecordcount.TabIndex = 551
        Me.lblrecordcount.Text = "Record Count"
        '
        'btnNew
        '
        Me.btnNew.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.Location = New System.Drawing.Point(0, 1)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(100, 26)
        Me.btnNew.TabIndex = 13
        Me.btnNew.Text = "New"
        Me.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Green
        Me.Label8.Location = New System.Drawing.Point(4, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 16)
        Me.Label8.TabIndex = 714
        Me.Label8.Text = "PAYMENT  LIST"
        '
        'panelPayment
        '
        Me.panelPayment.Controls.Add(Me.btnBrowseStudent)
        Me.panelPayment.Controls.Add(Me.Label13)
        Me.panelPayment.Controls.Add(Me.txtYrSection)
        Me.panelPayment.Controls.Add(Me.PictureBox1)
        Me.panelPayment.Controls.Add(Me.panelpay)
        Me.panelPayment.Controls.Add(Me.btnSave)
        Me.panelPayment.Controls.Add(Me.bntClear)
        Me.panelPayment.Controls.Add(Me.lblItemCode)
        Me.panelPayment.Controls.Add(Me.lblAccountID)
        Me.panelPayment.Controls.Add(Me.lblSchedID)
        Me.panelPayment.Controls.Add(Me.Panel8)
        Me.panelPayment.Controls.Add(Me.Label12)
        Me.panelPayment.Controls.Add(Me.Label17)
        Me.panelPayment.Controls.Add(Me.dtgSchoolFee)
        Me.panelPayment.Controls.Add(Me.Panel1)
        Me.panelPayment.Controls.Add(Me.txtbalance)
        Me.panelPayment.Controls.Add(Me.Label10)
        Me.panelPayment.Controls.Add(Me.Panel7)
        Me.panelPayment.Controls.Add(Me.txttotalPayment)
        Me.panelPayment.Controls.Add(Me.Label3)
        Me.panelPayment.Controls.Add(Me.txtTotalpayable)
        Me.panelPayment.Controls.Add(Me.Label18)
        Me.panelPayment.Controls.Add(Me.Panel3)
        Me.panelPayment.Controls.Add(Me.Panel5)
        Me.panelPayment.Controls.Add(Me.Label6)
        Me.panelPayment.Controls.Add(Me.Label9)
        Me.panelPayment.Controls.Add(Me.txtAccountID)
        Me.panelPayment.Controls.Add(Me.Label21)
        Me.panelPayment.Controls.Add(Me.Label1)
        Me.panelPayment.Controls.Add(Me.txtStudentCode)
        Me.panelPayment.Controls.Add(Me.Label7)
        Me.panelPayment.Controls.Add(Me.txtgender)
        Me.panelPayment.Controls.Add(Me.txtStudentFullname)
        Me.panelPayment.Controls.Add(Me.Label4)
        Me.panelPayment.Location = New System.Drawing.Point(77, 69)
        Me.panelPayment.Name = "panelPayment"
        Me.panelPayment.Size = New System.Drawing.Size(866, 588)
        Me.panelPayment.TabIndex = 717
        Me.panelPayment.Visible = False
        '
        'btnBrowseStudent
        '
        Me.btnBrowseStudent.Image = CType(resources.GetObject("btnBrowseStudent.Image"), System.Drawing.Image)
        Me.btnBrowseStudent.Location = New System.Drawing.Point(336, 81)
        Me.btnBrowseStudent.Name = "btnBrowseStudent"
        Me.btnBrowseStudent.Size = New System.Drawing.Size(57, 24)
        Me.btnBrowseStudent.TabIndex = 750
        Me.btnBrowseStudent.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(103, 156)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(99, 17)
        Me.Label13.TabIndex = 749
        Me.Label13.Text = "Year - Section:"
        '
        'txtYrSection
        '
        Me.txtYrSection.BackColor = System.Drawing.Color.White
        Me.txtYrSection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtYrSection.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYrSection.Location = New System.Drawing.Point(203, 154)
        Me.txtYrSection.Name = "txtYrSection"
        Me.txtYrSection.ReadOnly = True
        Me.txtYrSection.Size = New System.Drawing.Size(133, 22)
        Me.txtYrSection.TabIndex = 748
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 378)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(162, 184)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 747
        Me.PictureBox1.TabStop = False
        '
        'panelpay
        '
        Me.panelpay.BackColor = System.Drawing.Color.White
        Me.panelpay.Controls.Add(Me.Panel10)
        Me.panelpay.Controls.Add(Me.dtpaymentDate)
        Me.panelpay.Controls.Add(Me.Label24)
        Me.panelpay.Controls.Add(Me.txtAmountPaid)
        Me.panelpay.Controls.Add(Me.Label11)
        Me.panelpay.Location = New System.Drawing.Point(202, 380)
        Me.panelpay.Name = "panelpay"
        Me.panelpay.Size = New System.Drawing.Size(261, 159)
        Me.panelpay.TabIndex = 746
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Goldenrod
        Me.Panel10.Controls.Add(Me.Label20)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(261, 25)
        Me.Panel10.TabIndex = 684
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(5, 4)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(117, 17)
        Me.Label20.TabIndex = 137
        Me.Label20.Text = "Enter Amount Paid"
        '
        'dtpaymentDate
        '
        Me.dtpaymentDate.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpaymentDate.Location = New System.Drawing.Point(9, 51)
        Me.dtpaymentDate.Name = "dtpaymentDate"
        Me.dtpaymentDate.Size = New System.Drawing.Size(243, 23)
        Me.dtpaymentDate.TabIndex = 722
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(4, 82)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(109, 17)
        Me.Label24.TabIndex = 708
        Me.Label24.Text = "Amount To Pay:"
        '
        'txtAmountPaid
        '
        Me.txtAmountPaid.BackColor = System.Drawing.Color.White
        Me.txtAmountPaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAmountPaid.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmountPaid.ForeColor = System.Drawing.Color.Green
        Me.txtAmountPaid.Location = New System.Drawing.Point(8, 102)
        Me.txtAmountPaid.Name = "txtAmountPaid"
        Me.txtAmountPaid.Size = New System.Drawing.Size(244, 37)
        Me.txtAmountPaid.TabIndex = 4
        Me.txtAmountPaid.Text = "0.00"
        Me.txtAmountPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(9, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 17)
        Me.Label11.TabIndex = 723
        Me.Label11.Text = "Payment Date:"
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(305, 545)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(158, 26)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "Confirm Payment"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'bntClear
        '
        Me.bntClear.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntClear.Image = CType(resources.GetObject("bntClear.Image"), System.Drawing.Image)
        Me.bntClear.Location = New System.Drawing.Point(202, 545)
        Me.bntClear.Name = "bntClear"
        Me.bntClear.Size = New System.Drawing.Size(100, 26)
        Me.bntClear.TabIndex = 17
        Me.bntClear.Text = "Clear"
        Me.bntClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bntClear.UseVisualStyleBackColor = True
        '
        'lblItemCode
        '
        Me.lblItemCode.AutoSize = True
        Me.lblItemCode.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemCode.ForeColor = System.Drawing.Color.Red
        Me.lblItemCode.Location = New System.Drawing.Point(368, 159)
        Me.lblItemCode.Name = "lblItemCode"
        Me.lblItemCode.Size = New System.Drawing.Size(77, 17)
        Me.lblItemCode.TabIndex = 743
        Me.lblItemCode.Text = "ITEM CODE"
        Me.lblItemCode.Visible = False
        '
        'lblAccountID
        '
        Me.lblAccountID.AutoSize = True
        Me.lblAccountID.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountID.ForeColor = System.Drawing.Color.Red
        Me.lblAccountID.Location = New System.Drawing.Point(342, 50)
        Me.lblAccountID.Name = "lblAccountID"
        Me.lblAccountID.Size = New System.Drawing.Size(82, 17)
        Me.lblAccountID.TabIndex = 742
        Me.lblAccountID.Text = "PAYMENT ID"
        Me.lblAccountID.Visible = False
        '
        'lblSchedID
        '
        Me.lblSchedID.AutoSize = True
        Me.lblSchedID.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSchedID.ForeColor = System.Drawing.Color.Red
        Me.lblSchedID.Location = New System.Drawing.Point(781, 40)
        Me.lblSchedID.Name = "lblSchedID"
        Me.lblSchedID.Size = New System.Drawing.Size(68, 17)
        Me.lblSchedID.TabIndex = 736
        Me.lblSchedID.Text = "SCHED ID"
        Me.lblSchedID.Visible = False
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Black
        Me.Panel8.Location = New System.Drawing.Point(11, 350)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(460, 2)
        Me.Panel8.TabIndex = 691
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Green
        Me.Label12.Location = New System.Drawing.Point(199, 355)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(198, 16)
        Me.Label12.TabIndex = 720
        Me.Label12.Text = "PAYMENT INFORMATION DETAILS"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Green
        Me.Label17.Location = New System.Drawing.Point(478, 48)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(83, 16)
        Me.Label17.TabIndex = 719
        Me.Label17.Text = "SCHOOL FEES"
        '
        'dtgSchoolFee
        '
        Me.dtgSchoolFee.AllowUserToAddRows = False
        Me.dtgSchoolFee.AllowUserToDeleteRows = False
        Me.dtgSchoolFee.AllowUserToResizeColumns = False
        Me.dtgSchoolFee.AllowUserToResizeRows = False
        Me.dtgSchoolFee.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgSchoolFee.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dtgSchoolFee.ColumnHeadersHeight = 26
        Me.dtgSchoolFee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtgSchoolFee.EnableHeadersVisualStyles = False
        Me.dtgSchoolFee.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dtgSchoolFee.Location = New System.Drawing.Point(478, 67)
        Me.dtgSchoolFee.MultiSelect = False
        Me.dtgSchoolFee.Name = "dtgSchoolFee"
        Me.dtgSchoolFee.ReadOnly = True
        Me.dtgSchoolFee.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtgSchoolFee.RowHeadersVisible = False
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        Me.dtgSchoolFee.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dtgSchoolFee.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgSchoolFee.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dtgSchoolFee.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DodgerBlue
        Me.dtgSchoolFee.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dtgSchoolFee.RowTemplate.Height = 25
        Me.dtgSchoolFee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgSchoolFee.Size = New System.Drawing.Size(385, 504)
        Me.dtgSchoolFee.TabIndex = 718
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(471, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(2, 551)
        Me.Panel1.TabIndex = 717
        '
        'txtbalance
        '
        Me.txtbalance.BackColor = System.Drawing.Color.White
        Me.txtbalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbalance.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbalance.Location = New System.Drawing.Point(204, 289)
        Me.txtbalance.Name = "txtbalance"
        Me.txtbalance.ReadOnly = True
        Me.txtbalance.Size = New System.Drawing.Size(113, 23)
        Me.txtbalance.TabIndex = 692
        Me.txtbalance.Text = "0.00"
        Me.txtbalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(139, 291)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 17)
        Me.Label10.TabIndex = 691
        Me.Label10.Text = "Balance:"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Black
        Me.Panel7.Location = New System.Drawing.Point(203, 286)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(236, 2)
        Me.Panel7.TabIndex = 690
        '
        'txttotalPayment
        '
        Me.txttotalPayment.BackColor = System.Drawing.Color.White
        Me.txttotalPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttotalPayment.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotalPayment.Location = New System.Drawing.Point(204, 260)
        Me.txttotalPayment.Name = "txttotalPayment"
        Me.txttotalPayment.ReadOnly = True
        Me.txttotalPayment.Size = New System.Drawing.Size(113, 23)
        Me.txttotalPayment.TabIndex = 689
        Me.txttotalPayment.Text = "0.00"
        Me.txttotalPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(99, 264)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 17)
        Me.Label3.TabIndex = 688
        Me.Label3.Text = "Total Payment:"
        '
        'txtTotalpayable
        '
        Me.txtTotalpayable.BackColor = System.Drawing.Color.White
        Me.txtTotalpayable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalpayable.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalpayable.Location = New System.Drawing.Point(202, 226)
        Me.txtTotalpayable.Name = "txtTotalpayable"
        Me.txtTotalpayable.ReadOnly = True
        Me.txtTotalpayable.Size = New System.Drawing.Size(113, 23)
        Me.txtTotalpayable.TabIndex = 687
        Me.txtTotalpayable.Text = "0.00"
        Me.txtTotalpayable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(102, 228)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(99, 17)
        Me.Label18.TabIndex = 686
        Me.Label18.Text = "Total Payable:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Location = New System.Drawing.Point(203, 252)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(236, 2)
        Me.Panel3.TabIndex = 685
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Black
        Me.Panel6.Location = New System.Drawing.Point(0, 56)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(236, 42)
        Me.Panel6.TabIndex = 686
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Goldenrod
        Me.Panel5.Controls.Add(Me.lbldesc)
        Me.Panel5.Controls.Add(Me.Button1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(866, 25)
        Me.Panel5.TabIndex = 683
        '
        'lbldesc
        '
        Me.lbldesc.AutoSize = True
        Me.lbldesc.BackColor = System.Drawing.Color.Transparent
        Me.lbldesc.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldesc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbldesc.Location = New System.Drawing.Point(5, 4)
        Me.lbldesc.Name = "lbldesc"
        Me.lbldesc.Size = New System.Drawing.Size(118, 17)
        Me.lbldesc.TabIndex = 137
        Me.lbldesc.Text = "Add New Payment"
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.ImageIndex = 1
        Me.Button1.Location = New System.Drawing.Point(841, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 25)
        Me.Button1.TabIndex = 218
        Me.Button1.Text = "X"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Green
        Me.Label6.Location = New System.Drawing.Point(96, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 16)
        Me.Label6.TabIndex = 682
        Me.Label6.Text = "STUDENT DETAILS"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Green
        Me.Label9.Location = New System.Drawing.Point(86, 201)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 16)
        Me.Label9.TabIndex = 681
        Me.Label9.Text = "ACCOUNT DETAILS"
        '
        'txtAccountID
        '
        Me.txtAccountID.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtAccountID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAccountID.Enabled = False
        Me.txtAccountID.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccountID.Location = New System.Drawing.Point(202, 60)
        Me.txtAccountID.Name = "txtAccountID"
        Me.txtAccountID.Size = New System.Drawing.Size(134, 22)
        Me.txtAccountID.TabIndex = 673
        Me.txtAccountID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(115, 60)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(84, 17)
        Me.Label21.TabIndex = 672
        Me.Label21.Text = "Account ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(141, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 17)
        Me.Label1.TabIndex = 671
        Me.Label1.Text = "Gender:"
        '
        'txtStudentCode
        '
        Me.txtStudentCode.BackColor = System.Drawing.Color.White
        Me.txtStudentCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStudentCode.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentCode.Location = New System.Drawing.Point(203, 83)
        Me.txtStudentCode.Name = "txtStudentCode"
        Me.txtStudentCode.ReadOnly = True
        Me.txtStudentCode.Size = New System.Drawing.Size(133, 22)
        Me.txtStudentCode.TabIndex = 670
        Me.txtStudentCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(97, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 17)
        Me.Label7.TabIndex = 669
        Me.Label7.Text = "Student Code:"
        '
        'txtgender
        '
        Me.txtgender.BackColor = System.Drawing.Color.White
        Me.txtgender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtgender.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgender.Location = New System.Drawing.Point(203, 130)
        Me.txtgender.Name = "txtgender"
        Me.txtgender.ReadOnly = True
        Me.txtgender.Size = New System.Drawing.Size(133, 22)
        Me.txtgender.TabIndex = 667
        '
        'txtStudentFullname
        '
        Me.txtStudentFullname.BackColor = System.Drawing.Color.White
        Me.txtStudentFullname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStudentFullname.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentFullname.Location = New System.Drawing.Point(203, 106)
        Me.txtStudentFullname.Name = "txtStudentFullname"
        Me.txtStudentFullname.ReadOnly = True
        Me.txtStudentFullname.Size = New System.Drawing.Size(237, 22)
        Me.txtStudentFullname.TabIndex = 666
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(96, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 17)
        Me.Label4.TabIndex = 668
        Me.Label4.Text = "Student Name:"
        '
        'frmPayments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1020, 704)
        Me.Controls.Add(Me.panelPayment)
        Me.Controls.Add(Me.dtgSales)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPayments"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPayments"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.dtgSales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.panelPayment.ResumeLayout(False)
        Me.panelPayment.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelpay.ResumeLayout(False)
        Me.panelpay.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        CType(Me.dtgSchoolFee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents dtgSales As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnPrint As Button
    Friend WithEvents lblrecordcount As Label
    Friend WithEvents btnNew As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents panelPayment As Panel
    Friend WithEvents panelpay As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label20 As Label
    Friend WithEvents dtpaymentDate As DateTimePicker
    Friend WithEvents Label24 As Label
    Friend WithEvents txtAmountPaid As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents bntClear As Button
    Friend WithEvents lblItemCode As Label
    Friend WithEvents lblAccountID As Label
    Friend WithEvents lblSchedID As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents dtgSchoolFee As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtbalance As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents txttotalPayment As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTotalpayable As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lbldesc As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtAccountID As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtStudentCode As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtgender As TextBox
    Friend WithEvents txtStudentFullname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtYrSection As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBrowseStudent As Button
End Class
