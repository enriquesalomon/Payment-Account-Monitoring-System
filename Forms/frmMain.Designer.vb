<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDescLogin = New System.Windows.Forms.Label()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsMenuProfile = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsMenuAdmission = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsMenuFees = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem17 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsMenuExpenses = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem13 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsMenuTransaction = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsMenuUsers = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserLogsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmenuReports = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SchoolExpensesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsMenuSetting = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageGradeLevelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsMenuLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.panelLogin = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblLogsID = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblbranchName = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PaymentListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.panelLogin.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Goldenrod
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblDescLogin)
        Me.Panel1.Controls.Add(Me.lbltime)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1149, 31)
        Me.Panel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(319, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PAYMENTS AND ACCOUNT MONITORING SYSTEM"
        '
        'lblDescLogin
        '
        Me.lblDescLogin.AutoSize = True
        Me.lblDescLogin.BackColor = System.Drawing.Color.Transparent
        Me.lblDescLogin.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblDescLogin.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescLogin.ForeColor = System.Drawing.Color.White
        Me.lblDescLogin.Location = New System.Drawing.Point(1035, 0)
        Me.lblDescLogin.Name = "lblDescLogin"
        Me.lblDescLogin.Size = New System.Drawing.Size(62, 17)
        Me.lblDescLogin.TabIndex = 229
        Me.lblDescLogin.Text = "Welcome"
        Me.lblDescLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDescLogin.Visible = False
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.BackColor = System.Drawing.Color.Transparent
        Me.lbltime.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbltime.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.ForeColor = System.Drawing.Color.White
        Me.lbltime.Location = New System.Drawing.Point(1097, 0)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(50, 17)
        Me.lbltime.TabIndex = 230
        Me.lbltime.Text = "lbltime"
        Me.lbltime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem5, Me.tsMenuProfile, Me.tsMenuAdmission, Me.tsMenuFees, Me.tsMenuExpenses, Me.tsMenuTransaction, Me.tsMenuUsers, Me.tsmenuReports, Me.tsMenuSetting, Me.tsMenuLogout})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 31)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1149, 40)
        Me.MenuStrip1.TabIndex = 244
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripMenuItem5.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem6})
        Me.ToolStripMenuItem5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ToolStripMenuItem5.Image = CType(resources.GetObject("ToolStripMenuItem5.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(28, 36)
        Me.ToolStripMenuItem5.Text = "PROFILE"
        Me.ToolStripMenuItem5.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(115, 22)
        Me.ToolStripMenuItem6.Text = "Log in"
        '
        'tsMenuProfile
        '
        Me.tsMenuProfile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3})
        Me.tsMenuProfile.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsMenuProfile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tsMenuProfile.Image = CType(resources.GetObject("tsMenuProfile.Image"), System.Drawing.Image)
        Me.tsMenuProfile.Name = "tsMenuProfile"
        Me.tsMenuProfile.Size = New System.Drawing.Size(65, 36)
        Me.tsMenuProfile.Text = "PROFILE"
        Me.tsMenuProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(204, 22)
        Me.ToolStripMenuItem3.Text = "Student Information"
        '
        'tsMenuAdmission
        '
        Me.tsMenuAdmission.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem4})
        Me.tsMenuAdmission.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsMenuAdmission.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tsMenuAdmission.Image = CType(resources.GetObject("tsMenuAdmission.Image"), System.Drawing.Image)
        Me.tsMenuAdmission.Name = "tsMenuAdmission"
        Me.tsMenuAdmission.Size = New System.Drawing.Size(87, 36)
        Me.tsMenuAdmission.Text = "ADMISSION"
        Me.tsMenuAdmission.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripMenuItem4.Text = "Record Entry"
        '
        'tsMenuFees
        '
        Me.tsMenuFees.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem17})
        Me.tsMenuFees.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsMenuFees.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tsMenuFees.Image = CType(resources.GetObject("tsMenuFees.Image"), System.Drawing.Image)
        Me.tsMenuFees.Name = "tsMenuFees"
        Me.tsMenuFees.Size = New System.Drawing.Size(44, 36)
        Me.tsMenuFees.Text = "FEES"
        Me.tsMenuFees.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripMenuItem17
        '
        Me.ToolStripMenuItem17.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem17.Name = "ToolStripMenuItem17"
        Me.ToolStripMenuItem17.Size = New System.Drawing.Size(190, 22)
        Me.ToolStripMenuItem17.Text = "Manage Expenses"
        '
        'tsMenuExpenses
        '
        Me.tsMenuExpenses.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem13})
        Me.tsMenuExpenses.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsMenuExpenses.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tsMenuExpenses.Image = CType(resources.GetObject("tsMenuExpenses.Image"), System.Drawing.Image)
        Me.tsMenuExpenses.Name = "tsMenuExpenses"
        Me.tsMenuExpenses.Padding = New System.Windows.Forms.Padding(30, 0, 4, 0)
        Me.tsMenuExpenses.Size = New System.Drawing.Size(100, 36)
        Me.tsMenuExpenses.Text = "EXPENSES"
        Me.tsMenuExpenses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripMenuItem13
        '
        Me.ToolStripMenuItem13.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem13.Name = "ToolStripMenuItem13"
        Me.ToolStripMenuItem13.Size = New System.Drawing.Size(179, 22)
        Me.ToolStripMenuItem13.Text = "School Expenses"
        '
        'tsMenuTransaction
        '
        Me.tsMenuTransaction.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2})
        Me.tsMenuTransaction.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsMenuTransaction.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tsMenuTransaction.Image = CType(resources.GetObject("tsMenuTransaction.Image"), System.Drawing.Image)
        Me.tsMenuTransaction.Name = "tsMenuTransaction"
        Me.tsMenuTransaction.Size = New System.Drawing.Size(104, 36)
        Me.tsMenuTransaction.Text = "TRANSACTION"
        Me.tsMenuTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripMenuItem2.Text = "Payments"
        '
        'tsMenuUsers
        '
        Me.tsMenuUsers.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem9, Me.UserLogsToolStripMenuItem})
        Me.tsMenuUsers.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsMenuUsers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tsMenuUsers.Image = CType(resources.GetObject("tsMenuUsers.Image"), System.Drawing.Image)
        Me.tsMenuUsers.Name = "tsMenuUsers"
        Me.tsMenuUsers.Padding = New System.Windows.Forms.Padding(25, 0, 4, 0)
        Me.tsMenuUsers.Size = New System.Drawing.Size(74, 36)
        Me.tsMenuUsers.Text = "USERS"
        Me.tsMenuUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(159, 22)
        Me.ToolStripMenuItem9.Text = "Manage User"
        '
        'UserLogsToolStripMenuItem
        '
        Me.UserLogsToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserLogsToolStripMenuItem.Name = "UserLogsToolStripMenuItem"
        Me.UserLogsToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.UserLogsToolStripMenuItem.Text = "User Logs"
        '
        'tsmenuReports
        '
        Me.tsmenuReports.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem8, Me.ToolStripMenuItem10, Me.ToolStripMenuItem11, Me.SchoolExpensesToolStripMenuItem, Me.PaymentListToolStripMenuItem})
        Me.tsmenuReports.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmenuReports.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tsmenuReports.Image = CType(resources.GetObject("tsmenuReports.Image"), System.Drawing.Image)
        Me.tsmenuReports.Name = "tsmenuReports"
        Me.tsmenuReports.Size = New System.Drawing.Size(69, 36)
        Me.tsmenuReports.Text = "REPORTS"
        Me.tsmenuReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(202, 22)
        Me.ToolStripMenuItem8.Text = "Student Ledger"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(202, 22)
        Me.ToolStripMenuItem10.Text = "Admission List"
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(202, 22)
        Me.ToolStripMenuItem11.Text = "School Fees List"
        '
        'SchoolExpensesToolStripMenuItem
        '
        Me.SchoolExpensesToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SchoolExpensesToolStripMenuItem.Name = "SchoolExpensesToolStripMenuItem"
        Me.SchoolExpensesToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.SchoolExpensesToolStripMenuItem.Text = "School Expenses List"
        '
        'tsMenuSetting
        '
        Me.tsMenuSetting.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserManagementToolStripMenuItem, Me.ManageGradeLevelToolStripMenuItem})
        Me.tsMenuSetting.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsMenuSetting.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tsMenuSetting.Image = CType(resources.GetObject("tsMenuSetting.Image"), System.Drawing.Image)
        Me.tsMenuSetting.Name = "tsMenuSetting"
        Me.tsMenuSetting.Size = New System.Drawing.Size(73, 36)
        Me.tsMenuSetting.Text = "SETTINGS"
        Me.tsMenuSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'UserManagementToolStripMenuItem
        '
        Me.UserManagementToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserManagementToolStripMenuItem.Name = "UserManagementToolStripMenuItem"
        Me.UserManagementToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.UserManagementToolStripMenuItem.Text = "Manage School Year"
        '
        'ManageGradeLevelToolStripMenuItem
        '
        Me.ManageGradeLevelToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManageGradeLevelToolStripMenuItem.Name = "ManageGradeLevelToolStripMenuItem"
        Me.ManageGradeLevelToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.ManageGradeLevelToolStripMenuItem.Text = "Manage Grade Level"
        '
        'tsMenuLogout
        '
        Me.tsMenuLogout.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsMenuLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tsMenuLogout.Image = CType(resources.GetObject("tsMenuLogout.Image"), System.Drawing.Image)
        Me.tsMenuLogout.Name = "tsMenuLogout"
        Me.tsMenuLogout.Size = New System.Drawing.Size(74, 36)
        Me.tsMenuLogout.Text = "LOG-OUT"
        Me.tsMenuLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'panelLogin
        '
        Me.panelLogin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.panelLogin.BackColor = System.Drawing.Color.White
        Me.panelLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelLogin.Controls.Add(Me.btnClose)
        Me.panelLogin.Controls.Add(Me.btnLogin)
        Me.panelLogin.Controls.Add(Me.txtpassword)
        Me.panelLogin.Controls.Add(Me.Panel4)
        Me.panelLogin.Controls.Add(Me.PictureBox1)
        Me.panelLogin.Controls.Add(Me.Label6)
        Me.panelLogin.Controls.Add(Me.txtusername)
        Me.panelLogin.Controls.Add(Me.Label10)
        Me.panelLogin.Location = New System.Drawing.Point(369, 156)
        Me.panelLogin.Name = "panelLogin"
        Me.panelLogin.Size = New System.Drawing.Size(411, 139)
        Me.panelLogin.TabIndex = 245
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ImageIndex = 1
        Me.btnClose.Location = New System.Drawing.Point(305, 104)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(88, 29)
        Me.btnClose.TabIndex = 217
        Me.btnClose.Text = "Close"
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ImageKey = "Check_16x16.png"
        Me.btnLogin.Location = New System.Drawing.Point(211, 104)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(88, 29)
        Me.btnLogin.TabIndex = 216
        Me.btnLogin.Text = "Login"
        Me.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtpassword
        '
        Me.txtpassword.BackColor = System.Drawing.Color.White
        Me.txtpassword.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(196, 73)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(195, 23)
        Me.txtpassword.TabIndex = 2
        Me.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Goldenrod
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Location = New System.Drawing.Point(-2, -2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(412, 24)
        Me.Panel4.TabIndex = 137
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(6, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 16)
        Me.Label5.TabIndex = 137
        Me.Label5.Text = "LOGIN ACCOUNT   "
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(83, 107)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Goldenrod
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(92, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 20)
        Me.Label6.TabIndex = 136
        Me.Label6.Text = "Password     :"
        '
        'txtusername
        '
        Me.txtusername.BackColor = System.Drawing.Color.White
        Me.txtusername.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.Location = New System.Drawing.Point(196, 43)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(195, 23)
        Me.txtusername.TabIndex = 1
        Me.txtusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Goldenrod
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(92, 44)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 20)
        Me.Label10.TabIndex = 135
        Me.Label10.Text = "Username    :"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel5.Controls.Add(Me.lblLogsID)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.lblbranchName)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 421)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1149, 29)
        Me.Panel5.TabIndex = 246
        '
        'lblLogsID
        '
        Me.lblLogsID.AutoSize = True
        Me.lblLogsID.BackColor = System.Drawing.Color.Goldenrod
        Me.lblLogsID.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblLogsID.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogsID.ForeColor = System.Drawing.Color.White
        Me.lblLogsID.Location = New System.Drawing.Point(0, 0)
        Me.lblLogsID.Name = "lblLogsID"
        Me.lblLogsID.Size = New System.Drawing.Size(58, 20)
        Me.lblLogsID.TabIndex = 222
        Me.lblLogsID.Text = "LogsID"
        Me.lblLogsID.Visible = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(422, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(572, 15)
        Me.Label3.TabIndex = 209
        Me.Label3.Text = "Copyrights 2020 @ PAGADIAN CITY SALVATION AND PRAISE LEARNING CENTER. All Rights " &
    "Reserved "
        '
        'lblbranchName
        '
        Me.lblbranchName.AutoSize = True
        Me.lblbranchName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbranchName.Location = New System.Drawing.Point(1198, 6)
        Me.lblbranchName.Name = "lblbranchName"
        Me.lblbranchName.Size = New System.Drawing.Size(97, 16)
        Me.lblbranchName.TabIndex = 221
        Me.lblbranchName.Text = "lblbranchname"
        Me.lblbranchName.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'PaymentListToolStripMenuItem
        '
        Me.PaymentListToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaymentListToolStripMenuItem.Name = "PaymentListToolStripMenuItem"
        Me.PaymentListToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.PaymentListToolStripMenuItem.Text = "Transactions List"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1149, 450)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.panelLogin)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.panelLogin.ResumeLayout(False)
        Me.panelLogin.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblDescLogin As Label
    Friend WithEvents lbltime As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents tsMenuAdmission As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents tsMenuFees As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem17 As ToolStripMenuItem
    Friend WithEvents tsMenuExpenses As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem13 As ToolStripMenuItem
    Friend WithEvents tsMenuTransaction As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents tsMenuUsers As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As ToolStripMenuItem
    Friend WithEvents tsMenuSetting As ToolStripMenuItem
    Friend WithEvents UserManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsMenuLogout As ToolStripMenuItem
    Friend WithEvents panelLogin As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents lblbranchName As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents tsMenuProfile As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents UserLogsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsmenuReports As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem11 As ToolStripMenuItem
    Friend WithEvents ManageGradeLevelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents lblLogsID As Label
    Friend WithEvents SchoolExpensesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaymentListToolStripMenuItem As ToolStripMenuItem
End Class
