<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmChart
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
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series7 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series8 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea5 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend5 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series9 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series10 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChart))
        Dim ChartArea6 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend6 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series11 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series12 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btnrefresh = New System.Windows.Forms.Button()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Chart3 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart1
        '
        ChartArea4.AxisX.Title = "Year"
        ChartArea4.AxisY.Title = "Expense"
        ChartArea4.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea4)
        Legend4.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend4)
        Me.Chart1.Location = New System.Drawing.Point(9, 336)
        Me.Chart1.Name = "Chart1"
        Series7.ChartArea = "ChartArea1"
        Series7.Legend = "Legend1"
        Series7.Name = "Series1"
        Series8.ChartArea = "ChartArea1"
        Series8.Legend = "Legend1"
        Series8.Name = "Series2"
        Me.Chart1.Series.Add(Series7)
        Me.Chart1.Series.Add(Series8)
        Me.Chart1.Size = New System.Drawing.Size(467, 332)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Goldenrod
        Me.Panel4.Controls.Add(Me.btnClose)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(956, 26)
        Me.Panel4.TabIndex = 581
        '
        'btnClose
        '
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClose.ImageIndex = 1
        Me.btnClose.Location = New System.Drawing.Point(925, 0)
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
        Me.Label5.Size = New System.Drawing.Size(183, 16)
        Me.Label5.TabIndex = 137
        Me.Label5.Text = "DECISION SUPPORT CHARTING"
        '
        'Chart2
        '
        ChartArea5.AxisX.Title = "Month"
        ChartArea5.AxisY.Title = "Expense"
        ChartArea5.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea5)
        Legend5.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend5)
        Me.Chart2.Location = New System.Drawing.Point(9, 60)
        Me.Chart2.Name = "Chart2"
        Series9.ChartArea = "ChartArea1"
        Series9.Legend = "Legend1"
        Series9.Name = "Series1"
        Series10.ChartArea = "ChartArea1"
        Series10.Legend = "Legend1"
        Series10.Name = "Series2"
        Me.Chart2.Series.Add(Series9)
        Me.Chart2.Series.Add(Series10)
        Me.Chart2.Size = New System.Drawing.Size(932, 270)
        Me.Chart2.TabIndex = 582
        Me.Chart2.Text = "Chart2"
        '
        'btnrefresh
        '
        Me.btnrefresh.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrefresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnrefresh.Image = CType(resources.GetObject("btnrefresh.Image"), System.Drawing.Image)
        Me.btnrefresh.Location = New System.Drawing.Point(339, 32)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(58, 25)
        Me.btnrefresh.TabIndex = 664
        Me.btnrefresh.Text = " "
        Me.btnrefresh.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnrefresh.UseVisualStyleBackColor = True
        '
        'cmbYear
        '
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Location = New System.Drawing.Point(105, 32)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(234, 24)
        Me.cmbYear.TabIndex = 663
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(8, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 16)
        Me.Label1.TabIndex = 137
        Me.Label1.Text = "FILTER BY YEAR"
        '
        'Chart3
        '
        ChartArea6.AxisX.Title = "Year"
        ChartArea6.AxisY.Title = "Expense"
        ChartArea6.Name = "ChartArea1"
        Me.Chart3.ChartAreas.Add(ChartArea6)
        Legend6.Name = "Legend1"
        Me.Chart3.Legends.Add(Legend6)
        Me.Chart3.Location = New System.Drawing.Point(482, 394)
        Me.Chart3.Name = "Chart3"
        Series11.ChartArea = "ChartArea1"
        Series11.Legend = "Legend1"
        Series11.Name = "Series1"
        Series12.ChartArea = "ChartArea1"
        Series12.Legend = "Legend1"
        Series12.Name = "Series2"
        Me.Chart3.Series.Add(Series11)
        Me.Chart3.Series.Add(Series12)
        Me.Chart3.Size = New System.Drawing.Size(459, 274)
        Me.Chart3.TabIndex = 665
        Me.Chart3.Text = "Chart3"
        '
        'frmChart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(956, 717)
        Me.Controls.Add(Me.Chart3)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Chart2)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmChart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmChart"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Chart2 As DataVisualization.Charting.Chart
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents btnrefresh As Button
    Friend WithEvents Chart3 As DataVisualization.Charting.Chart
End Class
