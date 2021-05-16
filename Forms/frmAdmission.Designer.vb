<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmission
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdmission))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtStudID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtLastname = New System.Windows.Forms.TextBox()
        Me.asf = New System.Windows.Forms.Label()
        Me.txtMiddlename = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dtgList = New System.Windows.Forms.DataGridView()
        Me.cmbGradeSection = New System.Windows.Forms.ComboBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.bntClose = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblrecordcount = New System.Windows.Forms.Label()
        Me.txtControlNumber = New System.Windows.Forms.TextBox()
        Me.lblSchoolYear = New System.Windows.Forms.Label()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnBrowseStudent = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnrefresh = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Panel4.SuspendLayout()
        CType(Me.dtgList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
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
        Me.Panel4.Size = New System.Drawing.Size(1255, 26)
        Me.Panel4.TabIndex = 581
        '
        'btnClose
        '
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClose.ImageIndex = 1
        Me.btnClose.Location = New System.Drawing.Point(1224, 0)
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
        Me.Label5.Size = New System.Drawing.Size(127, 16)
        Me.Label5.TabIndex = 137
        Me.Label5.Text = "STUDENT ADMISSION"
        '
        'txtStudID
        '
        Me.txtStudID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStudID.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudID.Location = New System.Drawing.Point(102, 110)
        Me.txtStudID.Name = "txtStudID"
        Me.txtStudID.ReadOnly = True
        Me.txtStudID.Size = New System.Drawing.Size(115, 22)
        Me.txtStudID.TabIndex = 620
        Me.txtStudID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 17)
        Me.Label2.TabIndex = 621
        Me.Label2.Text = "StudentID:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Green
        Me.Label7.Location = New System.Drawing.Point(6, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 16)
        Me.Label7.TabIndex = 619
        Me.Label7.Text = "STUDENT DETAILS"
        '
        'txtLastname
        '
        Me.txtLastname.BackColor = System.Drawing.Color.White
        Me.txtLastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLastname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLastname.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastname.Location = New System.Drawing.Point(103, 185)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.ReadOnly = True
        Me.txtLastname.Size = New System.Drawing.Size(234, 22)
        Me.txtLastname.TabIndex = 611
        '
        'asf
        '
        Me.asf.AutoSize = True
        Me.asf.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.asf.Location = New System.Drawing.Point(28, 190)
        Me.asf.Name = "asf"
        Me.asf.Size = New System.Drawing.Size(75, 17)
        Me.asf.TabIndex = 612
        Me.asf.Text = "Lastname:"
        '
        'txtMiddlename
        '
        Me.txtMiddlename.BackColor = System.Drawing.Color.White
        Me.txtMiddlename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMiddlename.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMiddlename.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddlename.Location = New System.Drawing.Point(103, 160)
        Me.txtMiddlename.Name = "txtMiddlename"
        Me.txtMiddlename.ReadOnly = True
        Me.txtMiddlename.Size = New System.Drawing.Size(234, 22)
        Me.txtMiddlename.TabIndex = 609
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 17)
        Me.Label1.TabIndex = 610
        Me.Label1.Text = "Middlename:"
        '
        'txtFirstname
        '
        Me.txtFirstname.BackColor = System.Drawing.Color.White
        Me.txtFirstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFirstname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFirstname.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstname.Location = New System.Drawing.Point(103, 135)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.ReadOnly = True
        Me.txtFirstname.Size = New System.Drawing.Size(234, 22)
        Me.txtFirstname.TabIndex = 603
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(30, 140)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 17)
        Me.Label9.TabIndex = 608
        Me.Label9.Text = "Firstname:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(-1, 235)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 17)
        Me.Label6.TabIndex = 606
        Me.Label6.Text = "Grade-Section:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Green
        Me.Label12.Location = New System.Drawing.Point(1221, 60)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 16)
        Me.Label12.TabIndex = 624
        Me.Label12.Text = "LIST"
        '
        'dtgList
        '
        Me.dtgList.AllowUserToAddRows = False
        Me.dtgList.AllowUserToDeleteRows = False
        Me.dtgList.AllowUserToResizeColumns = False
        Me.dtgList.AllowUserToResizeRows = False
        Me.dtgList.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dtgList.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgList.ColumnHeadersHeight = 32
        Me.dtgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtgList.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dtgList.EnableHeadersVisualStyles = False
        Me.dtgList.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dtgList.Location = New System.Drawing.Point(341, 81)
        Me.dtgList.MultiSelect = False
        Me.dtgList.Name = "dtgList"
        Me.dtgList.ReadOnly = True
        Me.dtgList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtgList.RowHeadersVisible = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.dtgList.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgList.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dtgList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DodgerBlue
        Me.dtgList.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dtgList.RowTemplate.Height = 25
        Me.dtgList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgList.Size = New System.Drawing.Size(911, 532)
        Me.dtgList.TabIndex = 623
        '
        'cmbGradeSection
        '
        Me.cmbGradeSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGradeSection.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGradeSection.FormattingEnabled = True
        Me.cmbGradeSection.Location = New System.Drawing.Point(103, 233)
        Me.cmbGradeSection.Name = "cmbGradeSection"
        Me.cmbGradeSection.Size = New System.Drawing.Size(234, 25)
        Me.cmbGradeSection.TabIndex = 627
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.Location = New System.Drawing.Point(85, 277)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(81, 26)
        Me.btnEdit.TabIndex = 632
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(165, 277)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(81, 26)
        Me.btnSave.TabIndex = 630
        Me.btnSave.Text = "Save"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.Location = New System.Drawing.Point(5, 277)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(81, 26)
        Me.btnNew.TabIndex = 629
        Me.btnNew.Text = "New"
        Me.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'bntClose
        '
        Me.bntClose.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntClose.Image = CType(resources.GetObject("bntClose.Image"), System.Drawing.Image)
        Me.bntClose.Location = New System.Drawing.Point(247, 277)
        Me.bntClose.Name = "bntClose"
        Me.bntClose.Size = New System.Drawing.Size(81, 26)
        Me.bntClose.TabIndex = 631
        Me.bntClose.Text = "Cancel"
        Me.bntClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bntClose.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lblrecordcount)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 619)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1255, 31)
        Me.Panel1.TabIndex = 634
        '
        'lblrecordcount
        '
        Me.lblrecordcount.AutoSize = True
        Me.lblrecordcount.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrecordcount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblrecordcount.Location = New System.Drawing.Point(338, 5)
        Me.lblrecordcount.Name = "lblrecordcount"
        Me.lblrecordcount.Size = New System.Drawing.Size(90, 17)
        Me.lblrecordcount.TabIndex = 551
        Me.lblrecordcount.Text = "Record Count"
        '
        'txtControlNumber
        '
        Me.txtControlNumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtControlNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtControlNumber.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtControlNumber.Location = New System.Drawing.Point(156, 82)
        Me.txtControlNumber.Name = "txtControlNumber"
        Me.txtControlNumber.ReadOnly = True
        Me.txtControlNumber.Size = New System.Drawing.Size(115, 22)
        Me.txtControlNumber.TabIndex = 635
        Me.txtControlNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtControlNumber.Visible = False
        '
        'lblSchoolYear
        '
        Me.lblSchoolYear.AutoSize = True
        Me.lblSchoolYear.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSchoolYear.ForeColor = System.Drawing.Color.Green
        Me.lblSchoolYear.Location = New System.Drawing.Point(7, 31)
        Me.lblSchoolYear.Name = "lblSchoolYear"
        Me.lblSchoolYear.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSchoolYear.Size = New System.Drawing.Size(159, 28)
        Me.lblSchoolYear.TabIndex = 636
        Me.lblSchoolYear.Text = "USER DETAILS"
        '
        'txtGender
        '
        Me.txtGender.BackColor = System.Drawing.Color.White
        Me.txtGender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGender.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGender.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGender.Location = New System.Drawing.Point(103, 209)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.ReadOnly = True
        Me.txtGender.Size = New System.Drawing.Size(234, 22)
        Me.txtGender.TabIndex = 637
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(43, 214)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 17)
        Me.Label3.TabIndex = 638
        Me.Label3.Text = "Gender:"
        '
        'btnBrowseStudent
        '
        Me.btnBrowseStudent.Image = CType(resources.GetObject("btnBrowseStudent.Image"), System.Drawing.Image)
        Me.btnBrowseStudent.Location = New System.Drawing.Point(218, 109)
        Me.btnBrowseStudent.Name = "btnBrowseStudent"
        Me.btnBrowseStudent.Size = New System.Drawing.Size(57, 24)
        Me.btnBrowseStudent.TabIndex = 704
        Me.btnBrowseStudent.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteMenuStrip})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(152, 30)
        '
        'DeleteMenuStrip
        '
        Me.DeleteMenuStrip.Image = CType(resources.GetObject("DeleteMenuStrip.Image"), System.Drawing.Image)
        Me.DeleteMenuStrip.Name = "DeleteMenuStrip"
        Me.DeleteMenuStrip.Size = New System.Drawing.Size(151, 26)
        Me.DeleteMenuStrip.Text = "Delete Record"
        '
        'btnrefresh
        '
        Me.btnrefresh.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrefresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnrefresh.Image = CType(resources.GetObject("btnrefresh.Image"), System.Drawing.Image)
        Me.btnrefresh.Location = New System.Drawing.Point(1182, 53)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(38, 23)
        Me.btnrefresh.TabIndex = 709
        Me.btnrefresh.Text = " "
        Me.btnrefresh.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnrefresh.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(1145, 53)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(38, 23)
        Me.btnSearch.TabIndex = 708
        Me.btnSearch.Text = " "
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtsearch
        '
        Me.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsearch.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(741, 53)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(404, 23)
        Me.txtsearch.TabIndex = 706
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Image = CType(resources.GetObject("Label39.Image"), System.Drawing.Image)
        Me.Label39.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label39.Location = New System.Drawing.Point(601, 56)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(139, 17)
        Me.Label39.TabIndex = 707
        Me.Label39.Text = "      Search Keyword:"
        '
        'frmAdmission
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1255, 650)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.btnBrowseStudent)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblSchoolYear)
        Me.Controls.Add(Me.txtControlNumber)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.bntClose)
        Me.Controls.Add(Me.cmbGradeSection)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.dtgList)
        Me.Controls.Add(Me.txtStudID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtLastname)
        Me.Controls.Add(Me.asf)
        Me.Controls.Add(Me.txtMiddlename)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFirstname)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAdmission"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAdmission"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.dtgList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtStudID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtLastname As TextBox
    Friend WithEvents asf As Label
    Friend WithEvents txtMiddlename As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFirstname As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents dtgList As DataGridView
    Friend WithEvents cmbGradeSection As ComboBox
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents bntClose As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblrecordcount As Label
    Friend WithEvents txtControlNumber As TextBox
    Friend WithEvents lblSchoolYear As Label
    Friend WithEvents txtGender As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnBrowseStudent As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DeleteMenuStrip As ToolStripMenuItem
    Friend WithEvents btnrefresh As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents Label39 As Label
End Class
