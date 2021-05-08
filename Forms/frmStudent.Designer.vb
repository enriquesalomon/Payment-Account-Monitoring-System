<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStudent))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.lblrecordcount = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.dtgStudent = New System.Windows.Forms.DataGridView()
        Me.btnrefresh = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.panelClient = New System.Windows.Forms.Panel()
        Me.txtProvince = New System.Windows.Forms.TextBox()
        Me.txtMunCity = New System.Windows.Forms.TextBox()
        Me.txtContactNoC = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnClosePanel = New System.Windows.Forms.Button()
        Me.lbldesc = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.txtLnameC = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtBaranggay = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtcontactno = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtage = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtBirthdate = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtClientCode = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dtgStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelClient.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClose.ImageIndex = 1
        Me.btnClose.Location = New System.Drawing.Point(1058, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(31, 26)
        Me.btnClose.TabIndex = 218
        Me.btnClose.Text = "X"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Goldenrod
        Me.Panel4.Controls.Add(Me.btnClose)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1089, 26)
        Me.Panel4.TabIndex = 579
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(6, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(162, 16)
        Me.Label5.TabIndex = 137
        Me.Label5.Text = "MANAGE STUDENT PROFILE"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnPrint)
        Me.Panel1.Controls.Add(Me.btnEdit)
        Me.Panel1.Controls.Add(Me.lblrecordcount)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnNew)
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 521)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1089, 31)
        Me.Panel1.TabIndex = 586
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ImageIndex = 4
        Me.btnPrint.Location = New System.Drawing.Point(398, 2)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(100, 26)
        Me.btnPrint.TabIndex = 552
        Me.btnPrint.Text = "Print "
        Me.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.Location = New System.Drawing.Point(99, 1)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(100, 26)
        Me.btnEdit.TabIndex = 530
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'lblrecordcount
        '
        Me.lblrecordcount.AutoSize = True
        Me.lblrecordcount.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrecordcount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblrecordcount.Location = New System.Drawing.Point(860, 6)
        Me.lblrecordcount.Name = "lblrecordcount"
        Me.lblrecordcount.Size = New System.Drawing.Size(90, 17)
        Me.lblrecordcount.TabIndex = 551
        Me.lblrecordcount.Text = "Record Count"
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(199, 1)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 26)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "Save"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = True
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
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.Location = New System.Drawing.Point(299, 1)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 26)
        Me.btnDelete.TabIndex = 16
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'dtgStudent
        '
        Me.dtgStudent.AllowUserToAddRows = False
        Me.dtgStudent.AllowUserToDeleteRows = False
        Me.dtgStudent.AllowUserToResizeColumns = False
        Me.dtgStudent.AllowUserToResizeRows = False
        Me.dtgStudent.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dtgStudent.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgStudent.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgStudent.ColumnHeadersHeight = 26
        Me.dtgStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtgStudent.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dtgStudent.EnableHeadersVisualStyles = False
        Me.dtgStudent.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dtgStudent.Location = New System.Drawing.Point(0, 80)
        Me.dtgStudent.MultiSelect = False
        Me.dtgStudent.Name = "dtgStudent"
        Me.dtgStudent.ReadOnly = True
        Me.dtgStudent.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtgStudent.RowHeadersVisible = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.dtgStudent.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgStudent.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgStudent.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dtgStudent.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DodgerBlue
        Me.dtgStudent.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dtgStudent.RowTemplate.Height = 25
        Me.dtgStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgStudent.Size = New System.Drawing.Size(1089, 441)
        Me.dtgStudent.TabIndex = 587
        '
        'btnrefresh
        '
        Me.btnrefresh.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrefresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnrefresh.Image = CType(resources.GetObject("btnrefresh.Image"), System.Drawing.Image)
        Me.btnrefresh.Location = New System.Drawing.Point(1027, 38)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(38, 23)
        Me.btnrefresh.TabIndex = 592
        Me.btnrefresh.Text = " "
        Me.btnrefresh.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnrefresh.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(990, 38)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(38, 23)
        Me.btnSearch.TabIndex = 591
        Me.btnSearch.Text = " "
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtsearch
        '
        Me.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsearch.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(586, 38)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(404, 23)
        Me.txtsearch.TabIndex = 589
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Image = CType(resources.GetObject("Label39.Image"), System.Drawing.Image)
        Me.Label39.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label39.Location = New System.Drawing.Point(446, 41)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(139, 17)
        Me.Label39.TabIndex = 590
        Me.Label39.Text = "      Search Keyword:"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.Green
        Me.Label40.Location = New System.Drawing.Point(5, 44)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(116, 16)
        Me.Label40.TabIndex = 588
        Me.Label40.Text = "LIST OF STUDENTS"
        '
        'panelClient
        '
        Me.panelClient.Controls.Add(Me.txtProvince)
        Me.panelClient.Controls.Add(Me.txtMunCity)
        Me.panelClient.Controls.Add(Me.txtContactNoC)
        Me.panelClient.Controls.Add(Me.Label10)
        Me.panelClient.Controls.Add(Me.Panel3)
        Me.panelClient.Controls.Add(Me.Label42)
        Me.panelClient.Controls.Add(Me.Label37)
        Me.panelClient.Controls.Add(Me.txtLnameC)
        Me.panelClient.Controls.Add(Me.Label36)
        Me.panelClient.Controls.Add(Me.Label35)
        Me.panelClient.Controls.Add(Me.txtBaranggay)
        Me.panelClient.Controls.Add(Me.Label28)
        Me.panelClient.Controls.Add(Me.Label21)
        Me.panelClient.Controls.Add(Me.txtcontactno)
        Me.panelClient.Controls.Add(Me.Label9)
        Me.panelClient.Controls.Add(Me.cboGender)
        Me.panelClient.Controls.Add(Me.Label12)
        Me.panelClient.Controls.Add(Me.txtage)
        Me.panelClient.Controls.Add(Me.Label11)
        Me.panelClient.Controls.Add(Me.dtBirthdate)
        Me.panelClient.Controls.Add(Me.Label8)
        Me.panelClient.Controls.Add(Me.Label6)
        Me.panelClient.Controls.Add(Me.txtClientCode)
        Me.panelClient.Controls.Add(Me.Label7)
        Me.panelClient.Controls.Add(Me.txtMname)
        Me.panelClient.Controls.Add(Me.Label2)
        Me.panelClient.Controls.Add(Me.txtFname)
        Me.panelClient.Controls.Add(Me.Label3)
        Me.panelClient.Controls.Add(Me.txtLname)
        Me.panelClient.Controls.Add(Me.Label4)
        Me.panelClient.Location = New System.Drawing.Point(197, 101)
        Me.panelClient.Name = "panelClient"
        Me.panelClient.Size = New System.Drawing.Size(660, 366)
        Me.panelClient.TabIndex = 593
        '
        'txtProvince
        '
        Me.txtProvince.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProvince.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProvince.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProvince.Location = New System.Drawing.Point(150, 255)
        Me.txtProvince.Name = "txtProvince"
        Me.txtProvince.Size = New System.Drawing.Size(236, 22)
        Me.txtProvince.TabIndex = 660
        '
        'txtMunCity
        '
        Me.txtMunCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMunCity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMunCity.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMunCity.Location = New System.Drawing.Point(150, 231)
        Me.txtMunCity.Name = "txtMunCity"
        Me.txtMunCity.Size = New System.Drawing.Size(236, 22)
        Me.txtMunCity.TabIndex = 659
        '
        'txtContactNoC
        '
        Me.txtContactNoC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContactNoC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContactNoC.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNoC.Location = New System.Drawing.Point(523, 328)
        Me.txtContactNoC.Name = "txtContactNoC"
        Me.txtContactNoC.Size = New System.Drawing.Size(115, 22)
        Me.txtContactNoC.TabIndex = 657
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(433, 330)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 17)
        Me.Label10.TabIndex = 658
        Me.Label10.Text = "Contact No:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Goldenrod
        Me.Panel3.Controls.Add(Me.btnClosePanel)
        Me.Panel3.Controls.Add(Me.lbldesc)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(660, 24)
        Me.Panel3.TabIndex = 656
        '
        'btnClosePanel
        '
        Me.btnClosePanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClosePanel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClosePanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClosePanel.ImageIndex = 1
        Me.btnClosePanel.Location = New System.Drawing.Point(635, 0)
        Me.btnClosePanel.Name = "btnClosePanel"
        Me.btnClosePanel.Size = New System.Drawing.Size(25, 24)
        Me.btnClosePanel.TabIndex = 218
        Me.btnClosePanel.Text = "X"
        Me.btnClosePanel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClosePanel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClosePanel.UseVisualStyleBackColor = True
        '
        'lbldesc
        '
        Me.lbldesc.AutoSize = True
        Me.lbldesc.BackColor = System.Drawing.Color.Transparent
        Me.lbldesc.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldesc.ForeColor = System.Drawing.Color.White
        Me.lbldesc.Location = New System.Drawing.Point(5, 3)
        Me.lbldesc.Name = "lbldesc"
        Me.lbldesc.Size = New System.Drawing.Size(51, 17)
        Me.lbldesc.TabIndex = 137
        Me.lbldesc.Text = "lbldesc"
        Me.lbldesc.Visible = False
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(68, 333)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(76, 17)
        Me.Label42.TabIndex = 253
        Me.Label42.Text = "Full Name:"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(82, 259)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(68, 17)
        Me.Label37.TabIndex = 640
        Me.Label37.Text = "Province:"
        '
        'txtLnameC
        '
        Me.txtLnameC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLnameC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLnameC.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLnameC.Location = New System.Drawing.Point(150, 328)
        Me.txtLnameC.Name = "txtLnameC"
        Me.txtLnameC.Size = New System.Drawing.Size(282, 22)
        Me.txtLnameC.TabIndex = 23
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(34, 232)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(119, 17)
        Me.Label36.TabIndex = 639
        Me.Label36.Text = "City/Municipality:"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Green
        Me.Label35.Location = New System.Drawing.Point(45, 188)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(96, 16)
        Me.Label35.TabIndex = 638
        Me.Label35.Text = "HOME ADDRESS"
        '
        'txtBaranggay
        '
        Me.txtBaranggay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBaranggay.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBaranggay.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBaranggay.Location = New System.Drawing.Point(150, 207)
        Me.txtBaranggay.Name = "txtBaranggay"
        Me.txtBaranggay.Size = New System.Drawing.Size(236, 22)
        Me.txtBaranggay.TabIndex = 14
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(6, 210)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(147, 17)
        Me.Label28.TabIndex = 637
        Me.Label28.Text = "Blkno./St./Baranggay:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Green
        Me.Label21.Location = New System.Drawing.Point(7, 302)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(147, 16)
        Me.Label21.TabIndex = 628
        Me.Label21.Text = "IN CASE OF EMERGENCY"
        '
        'txtcontactno
        '
        Me.txtcontactno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcontactno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcontactno.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontactno.Location = New System.Drawing.Point(509, 128)
        Me.txtcontactno.Name = "txtcontactno"
        Me.txtcontactno.Size = New System.Drawing.Size(115, 22)
        Me.txtcontactno.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(419, 130)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 17)
        Me.Label9.TabIndex = 625
        Me.Label9.Text = "Contact No:"
        '
        'cboGender
        '
        Me.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGender.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.cboGender.Location = New System.Drawing.Point(510, 52)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(115, 24)
        Me.cboGender.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(451, 54)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 17)
        Me.Label12.TabIndex = 621
        Me.Label12.Text = "Gender:"
        '
        'txtage
        '
        Me.txtage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtage.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtage.Location = New System.Drawing.Point(509, 103)
        Me.txtage.Name = "txtage"
        Me.txtage.ReadOnly = True
        Me.txtage.Size = New System.Drawing.Size(115, 22)
        Me.txtage.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(472, 103)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 17)
        Me.Label11.TabIndex = 620
        Me.Label11.Text = "Age:"
        '
        'dtBirthdate
        '
        Me.dtBirthdate.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtBirthdate.Location = New System.Drawing.Point(509, 77)
        Me.dtBirthdate.Name = "dtBirthdate"
        Me.dtBirthdate.Size = New System.Drawing.Size(115, 23)
        Me.dtBirthdate.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(441, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 17)
        Me.Label8.TabIndex = 618
        Me.Label8.Text = "Birthdate:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Green
        Me.Label6.Location = New System.Drawing.Point(7, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(155, 16)
        Me.Label6.TabIndex = 613
        Me.Label6.Text = "PERSONAL INFORMATION"
        '
        'txtClientCode
        '
        Me.txtClientCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtClientCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtClientCode.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClientCode.Location = New System.Drawing.Point(150, 61)
        Me.txtClientCode.Name = "txtClientCode"
        Me.txtClientCode.ReadOnly = True
        Me.txtClientCode.Size = New System.Drawing.Size(115, 22)
        Me.txtClientCode.TabIndex = 611
        Me.txtClientCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(50, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 17)
        Me.Label7.TabIndex = 610
        Me.Label7.Text = "Student Code:"
        '
        'txtMname
        '
        Me.txtMname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMname.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMname.Location = New System.Drawing.Point(150, 130)
        Me.txtMname.Name = "txtMname"
        Me.txtMname.Size = New System.Drawing.Size(231, 22)
        Me.txtMname.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(53, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 17)
        Me.Label2.TabIndex = 609
        Me.Label2.Text = "Middle Name:"
        '
        'txtFname
        '
        Me.txtFname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFname.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFname.Location = New System.Drawing.Point(150, 107)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(231, 22)
        Me.txtFname.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(74, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 17)
        Me.Label3.TabIndex = 608
        Me.Label3.Text = "First Name:"
        '
        'txtLname
        '
        Me.txtLname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLname.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLname.Location = New System.Drawing.Point(150, 84)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(231, 22)
        Me.txtLname.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(72, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 17)
        Me.Label4.TabIndex = 607
        Me.Label4.Text = "Last Name:"
        '
        'frmStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1089, 552)
        Me.Controls.Add(Me.panelClient)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.dtgStudent)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmStudent"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dtgStudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelClient.ResumeLayout(False)
        Me.panelClient.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents lblrecordcount As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents dtgStudent As DataGridView
    Friend WithEvents btnrefresh As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents panelClient As Panel
    Friend WithEvents txtProvince As TextBox
    Friend WithEvents txtMunCity As TextBox
    Friend WithEvents txtContactNoC As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnClosePanel As Button
    Friend WithEvents lbldesc As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents txtLnameC As TextBox
    Friend WithEvents Label36 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents txtBaranggay As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txtcontactno As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cboGender As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtage As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents dtBirthdate As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtClientCode As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtMname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLname As TextBox
    Friend WithEvents Label4 As Label
End Class
