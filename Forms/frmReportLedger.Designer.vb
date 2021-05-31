<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportLedger
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportLedger))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRunningBalance = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtgClientLedger = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTotalPlanAmount = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtInstallmentNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPlanholdername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnView = New System.Windows.Forms.Button()
        Me.txtStudentCode = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnrefresh = New System.Windows.Forms.Button()
        Me.cmbSY = New System.Windows.Forms.ComboBox()
        Me.Panel4.SuspendLayout()
        CType(Me.dtgClientLedger, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel4.Size = New System.Drawing.Size(712, 23)
        Me.Panel4.TabIndex = 144
        '
        'btnClose
        '
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClose.ImageIndex = 1
        Me.btnClose.Location = New System.Drawing.Point(685, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(27, 23)
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
        Me.Label5.Location = New System.Drawing.Point(0, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 16)
        Me.Label5.TabIndex = 137
        Me.Label5.Text = "STUDENT LEDGER"
        '
        'txtRunningBalance
        '
        Me.txtRunningBalance.BackColor = System.Drawing.Color.White
        Me.txtRunningBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRunningBalance.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRunningBalance.Location = New System.Drawing.Point(499, 161)
        Me.txtRunningBalance.Name = "txtRunningBalance"
        Me.txtRunningBalance.ReadOnly = True
        Me.txtRunningBalance.Size = New System.Drawing.Size(207, 22)
        Me.txtRunningBalance.TabIndex = 724
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(496, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 17)
        Me.Label3.TabIndex = 723
        Me.Label3.Text = "Running Balance"
        '
        'dtgClientLedger
        '
        Me.dtgClientLedger.AllowUserToAddRows = False
        Me.dtgClientLedger.AllowUserToDeleteRows = False
        Me.dtgClientLedger.AllowUserToResizeColumns = False
        Me.dtgClientLedger.AllowUserToResizeRows = False
        Me.dtgClientLedger.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dtgClientLedger.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgClientLedger.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dtgClientLedger.ColumnHeadersHeight = 26
        Me.dtgClientLedger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtgClientLedger.EnableHeadersVisualStyles = False
        Me.dtgClientLedger.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dtgClientLedger.Location = New System.Drawing.Point(4, 187)
        Me.dtgClientLedger.MultiSelect = False
        Me.dtgClientLedger.Name = "dtgClientLedger"
        Me.dtgClientLedger.ReadOnly = True
        Me.dtgClientLedger.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtgClientLedger.RowHeadersVisible = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.dtgClientLedger.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dtgClientLedger.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgClientLedger.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dtgClientLedger.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DodgerBlue
        Me.dtgClientLedger.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dtgClientLedger.RowTemplate.Height = 25
        Me.dtgClientLedger.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgClientLedger.Size = New System.Drawing.Size(704, 374)
        Me.dtgClientLedger.TabIndex = 722
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Green
        Me.Label6.Location = New System.Drawing.Point(3, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(173, 16)
        Me.Label6.TabIndex = 721
        Me.Label6.Text = "SUMMARY OF TRANSACTION"
        '
        'txtTotalPlanAmount
        '
        Me.txtTotalPlanAmount.BackColor = System.Drawing.Color.White
        Me.txtTotalPlanAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalPlanAmount.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPlanAmount.Location = New System.Drawing.Point(286, 160)
        Me.txtTotalPlanAmount.Name = "txtTotalPlanAmount"
        Me.txtTotalPlanAmount.ReadOnly = True
        Me.txtTotalPlanAmount.Size = New System.Drawing.Size(207, 22)
        Me.txtTotalPlanAmount.TabIndex = 720
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(284, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 17)
        Me.Label4.TabIndex = 719
        Me.Label4.Text = "Total Amount Payable"
        '
        'txtInstallmentNo
        '
        Me.txtInstallmentNo.BackColor = System.Drawing.Color.White
        Me.txtInstallmentNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInstallmentNo.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInstallmentNo.Location = New System.Drawing.Point(143, 81)
        Me.txtInstallmentNo.Name = "txtInstallmentNo"
        Me.txtInstallmentNo.ReadOnly = True
        Me.txtInstallmentNo.Size = New System.Drawing.Size(200, 22)
        Me.txtInstallmentNo.TabIndex = 718
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 17)
        Me.Label2.TabIndex = 717
        Me.Label2.Text = "Account Number"
        '
        'txtPlanholdername
        '
        Me.txtPlanholdername.BackColor = System.Drawing.Color.White
        Me.txtPlanholdername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPlanholdername.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlanholdername.Location = New System.Drawing.Point(174, 55)
        Me.txtPlanholdername.Name = "txtPlanholdername"
        Me.txtPlanholdername.ReadOnly = True
        Me.txtPlanholdername.Size = New System.Drawing.Size(323, 22)
        Me.txtPlanholdername.TabIndex = 716
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(174, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 17)
        Me.Label1.TabIndex = 715
        Me.Label1.Text = "Student Name"
        '
        'btnView
        '
        Me.btnView.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.ForeColor = System.Drawing.Color.Black
        Me.btnView.ImageIndex = 1
        Me.btnView.Location = New System.Drawing.Point(143, 55)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(30, 23)
        Me.btnView.TabIndex = 712
        Me.btnView.Text = "..."
        Me.btnView.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnView.UseVisualStyleBackColor = True
        '
        'txtStudentCode
        '
        Me.txtStudentCode.BackColor = System.Drawing.Color.White
        Me.txtStudentCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStudentCode.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentCode.Location = New System.Drawing.Point(9, 55)
        Me.txtStudentCode.Name = "txtStudentCode"
        Me.txtStudentCode.ReadOnly = True
        Me.txtStudentCode.Size = New System.Drawing.Size(133, 22)
        Me.txtStudentCode.TabIndex = 714
        Me.txtStudentCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(10, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 17)
        Me.Label7.TabIndex = 713
        Me.Label7.Text = "Student Code"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(501, 55)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(205, 22)
        Me.TextBox1.TabIndex = 731
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(498, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 17)
        Me.Label8.TabIndex = 730
        Me.Label8.Text = "Grade-Section"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(360, 84)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 17)
        Me.Label9.TabIndex = 733
        Me.Label9.Text = "School Year"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(2, 564)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 26)
        Me.Button1.TabIndex = 895
        Me.Button1.Text = "PRINT"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnrefresh
        '
        Me.btnrefresh.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrefresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnrefresh.Image = CType(resources.GetObject("btnrefresh.Image"), System.Drawing.Image)
        Me.btnrefresh.Location = New System.Drawing.Point(571, 78)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(135, 26)
        Me.btnrefresh.TabIndex = 897
        Me.btnrefresh.Text = " Load Data"
        Me.btnrefresh.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnrefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnrefresh.UseVisualStyleBackColor = True
        '
        'cmbSY
        '
        Me.cmbSY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSY.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSY.FormattingEnabled = True
        Me.cmbSY.Location = New System.Drawing.Point(443, 79)
        Me.cmbSY.Name = "cmbSY"
        Me.cmbSY.Size = New System.Drawing.Size(129, 24)
        Me.cmbSY.TabIndex = 896
        '
        'frmReportLedger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(712, 592)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.cmbSY)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtRunningBalance)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtgClientLedger)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTotalPlanAmount)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtInstallmentNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPlanholdername)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.txtStudentCode)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmReportLedger"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLedger"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.dtgClientLedger, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtRunningBalance As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtgClientLedger As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTotalPlanAmount As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtInstallmentNo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPlanholdername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnView As Button
    Friend WithEvents txtStudentCode As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnrefresh As Button
    Friend WithEvents cmbSY As ComboBox
End Class
