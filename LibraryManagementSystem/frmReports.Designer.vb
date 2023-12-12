<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReports
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtp_endDate = New System.Windows.Forms.DateTimePicker()
        Me.btnTotalbooks = New System.Windows.Forms.Button()
        Me.btnListBooks = New System.Windows.Forms.Button()
        Me.rdoMonthly = New System.Windows.Forms.RadioButton()
        Me.rdoWeekly = New System.Windows.Forms.RadioButton()
        Me.rdoDaily = New System.Windows.Forms.RadioButton()
        Me.dtp_strtDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.btn_preview = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GroupBox1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "End Date :"
        '
        'dtp_endDate
        '
        Me.dtp_endDate.CustomFormat = "yyyy-MM-dd"
        Me.dtp_endDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_endDate.Location = New System.Drawing.Point(10, 89)
        Me.dtp_endDate.Name = "dtp_endDate"
        Me.dtp_endDate.Size = New System.Drawing.Size(132, 20)
        Me.dtp_endDate.TabIndex = 17
        '
        'btnTotalbooks
        '
        Me.btnTotalbooks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTotalbooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTotalbooks.Location = New System.Drawing.Point(6, 66)
        Me.btnTotalbooks.Name = "btnTotalbooks"
        Me.btnTotalbooks.Size = New System.Drawing.Size(133, 44)
        Me.btnTotalbooks.TabIndex = 3
        Me.btnTotalbooks.Text = "Total No. of Books"
        Me.btnTotalbooks.UseVisualStyleBackColor = True
        '
        'btnListBooks
        '
        Me.btnListBooks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnListBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListBooks.Location = New System.Drawing.Point(6, 19)
        Me.btnListBooks.Name = "btnListBooks"
        Me.btnListBooks.Size = New System.Drawing.Size(133, 44)
        Me.btnListBooks.TabIndex = 2
        Me.btnListBooks.Text = "List of Books"
        Me.btnListBooks.UseVisualStyleBackColor = True
        '
        'rdoMonthly
        '
        Me.rdoMonthly.AutoSize = True
        Me.rdoMonthly.Location = New System.Drawing.Point(26, 224)
        Me.rdoMonthly.Name = "rdoMonthly"
        Me.rdoMonthly.Size = New System.Drawing.Size(97, 17)
        Me.rdoMonthly.TabIndex = 2
        Me.rdoMonthly.TabStop = True
        Me.rdoMonthly.Text = "Monthly Report"
        Me.rdoMonthly.UseVisualStyleBackColor = True
        '
        'rdoWeekly
        '
        Me.rdoWeekly.AutoSize = True
        Me.rdoWeekly.Location = New System.Drawing.Point(26, 201)
        Me.rdoWeekly.Name = "rdoWeekly"
        Me.rdoWeekly.Size = New System.Drawing.Size(96, 17)
        Me.rdoWeekly.TabIndex = 2
        Me.rdoWeekly.TabStop = True
        Me.rdoWeekly.Text = "Weekly Report"
        Me.rdoWeekly.UseVisualStyleBackColor = True
        '
        'rdoDaily
        '
        Me.rdoDaily.AutoSize = True
        Me.rdoDaily.Location = New System.Drawing.Point(26, 178)
        Me.rdoDaily.Name = "rdoDaily"
        Me.rdoDaily.Size = New System.Drawing.Size(83, 17)
        Me.rdoDaily.TabIndex = 2
        Me.rdoDaily.TabStop = True
        Me.rdoDaily.Text = "Daily Report"
        Me.rdoDaily.UseVisualStyleBackColor = True
        '
        'dtp_strtDate
        '
        Me.dtp_strtDate.CustomFormat = "yyyy-MM-dd"
        Me.dtp_strtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_strtDate.Location = New System.Drawing.Point(10, 41)
        Me.dtp_strtDate.Name = "dtp_strtDate"
        Me.dtp_strtDate.Size = New System.Drawing.Size(132, 20)
        Me.dtp_strtDate.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Start Date :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Status :"
        '
        'cboStatus
        '
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"Borrowed", "Returned", "Overdue"})
        Me.cboStatus.Location = New System.Drawing.Point(4, 135)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(137, 21)
        Me.cboStatus.TabIndex = 0
        Me.cboStatus.Text = "Borrowed"
        '
        'btn_preview
        '
        Me.btn_preview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_preview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_preview.Location = New System.Drawing.Point(9, 115)
        Me.btn_preview.Name = "btn_preview"
        Me.btn_preview.Size = New System.Drawing.Size(130, 50)
        Me.btn_preview.TabIndex = 15
        Me.btn_preview.Text = "Preview"
        Me.btn_preview.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnTotalbooks)
        Me.GroupBox1.Controls.Add(Me.btnListBooks)
        Me.GroupBox1.Controls.Add(Me.rdoMonthly)
        Me.GroupBox1.Controls.Add(Me.rdoWeekly)
        Me.GroupBox1.Controls.Add(Me.rdoDaily)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboStatus)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(146, 262)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Books"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.GroupBox1)
        Me.FlowLayoutPanel1.Controls.Add(Me.GroupBox2)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(155, 464)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtp_strtDate)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.dtp_endDate)
        Me.GroupBox2.Controls.Add(Me.btn_preview)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 271)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(146, 171)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Date Filter"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(155, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(704, 464)
        Me.CrystalReportViewer1.TabIndex = 2
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(859, 464)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmReports"
        Me.Text = "frmReports"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents dtp_endDate As DateTimePicker
    Friend WithEvents btnTotalbooks As Button
    Friend WithEvents btnListBooks As Button
    Friend WithEvents rdoMonthly As RadioButton
    Friend WithEvents rdoWeekly As RadioButton
    Friend WithEvents rdoDaily As RadioButton
    Friend WithEvents dtp_strtDate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents btn_preview As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
