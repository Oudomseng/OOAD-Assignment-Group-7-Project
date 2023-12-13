<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnUser = New System.Windows.Forms.Button()
        Me.btnCategory = New System.Windows.Forms.Button()
        Me.btnOverdues = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnBorrowBooks = New System.Windows.Forms.Button()
        Me.btnBorrower = New System.Windows.Forms.Button()
        Me.btnBooks = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.PictureBox()
        Me.pnlContainer = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.btnLogout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnReports)
        Me.Panel1.Controls.Add(Me.btnReturn)
        Me.Panel1.Controls.Add(Me.btnUser)
        Me.Panel1.Controls.Add(Me.btnCategory)
        Me.Panel1.Controls.Add(Me.btnOverdues)
        Me.Panel1.Controls.Add(Me.btnBorrowBooks)
        Me.Panel1.Controls.Add(Me.btnBorrower)
        Me.Panel1.Controls.Add(Me.btnBooks)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(179, 557)
        Me.Panel1.TabIndex = 0
        '
        'btnReports
        '
        Me.btnReports.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btnReports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReports.FlatAppearance.BorderSize = 0
        Me.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReports.ForeColor = System.Drawing.Color.White
        Me.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReports.Location = New System.Drawing.Point(-1, 477)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(175, 53)
        Me.btnReports.TabIndex = 9
        Me.btnReports.Text = "Reports"
        Me.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReports.UseVisualStyleBackColor = False
        '
        'btnUser
        '
        Me.btnUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btnUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUser.FlatAppearance.BorderSize = 0
        Me.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUser.ForeColor = System.Drawing.Color.White
        Me.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUser.Location = New System.Drawing.Point(1, 418)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(175, 53)
        Me.btnUser.TabIndex = 8
        Me.btnUser.Text = "Manage Users"
        Me.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUser.UseVisualStyleBackColor = False
        '
        'btnCategory
        '
        Me.btnCategory.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btnCategory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCategory.FlatAppearance.BorderSize = 0
        Me.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCategory.ForeColor = System.Drawing.Color.White
        Me.btnCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCategory.Location = New System.Drawing.Point(1, 359)
        Me.btnCategory.Name = "btnCategory"
        Me.btnCategory.Size = New System.Drawing.Size(175, 53)
        Me.btnCategory.TabIndex = 7
        Me.btnCategory.Text = "Manage Categories"
        Me.btnCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCategory.UseVisualStyleBackColor = False
        '
        'btnOverdues
        '
        Me.btnOverdues.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btnOverdues.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOverdues.FlatAppearance.BorderSize = 0
        Me.btnOverdues.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOverdues.ForeColor = System.Drawing.Color.White
        Me.btnOverdues.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOverdues.Location = New System.Drawing.Point(1, 306)
        Me.btnOverdues.Name = "btnOverdues"
        Me.btnOverdues.Size = New System.Drawing.Size(175, 53)
        Me.btnOverdues.TabIndex = 6
        Me.btnOverdues.Text = "Overdues"
        Me.btnOverdues.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOverdues.UseVisualStyleBackColor = False
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReturn.FlatAppearance.BorderSize = 0
        Me.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturn.ForeColor = System.Drawing.Color.White
        Me.btnReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReturn.Location = New System.Drawing.Point(3, 247)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(175, 53)
        Me.btnReturn.TabIndex = 5
        Me.btnReturn.Text = "Return"
        Me.btnReturn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'btnBorrowBooks
        '
        Me.btnBorrowBooks.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btnBorrowBooks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrowBooks.FlatAppearance.BorderSize = 0
        Me.btnBorrowBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrowBooks.ForeColor = System.Drawing.Color.White
        Me.btnBorrowBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBorrowBooks.Location = New System.Drawing.Point(2, 200)
        Me.btnBorrowBooks.Name = "btnBorrowBooks"
        Me.btnBorrowBooks.Size = New System.Drawing.Size(175, 53)
        Me.btnBorrowBooks.TabIndex = 4
        Me.btnBorrowBooks.Text = "Borrow Books"
        Me.btnBorrowBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBorrowBooks.UseVisualStyleBackColor = False
        '
        'btnBorrower
        '
        Me.btnBorrower.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btnBorrower.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrower.FlatAppearance.BorderSize = 0
        Me.btnBorrower.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrower.ForeColor = System.Drawing.Color.White
        Me.btnBorrower.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBorrower.Location = New System.Drawing.Point(1, 147)
        Me.btnBorrower.Name = "btnBorrower"
        Me.btnBorrower.Size = New System.Drawing.Size(175, 53)
        Me.btnBorrower.TabIndex = 3
        Me.btnBorrower.Text = "Manage Borrowers"
        Me.btnBorrower.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBorrower.UseVisualStyleBackColor = False
        '
        'btnBooks
        '
        Me.btnBooks.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btnBooks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBooks.FlatAppearance.BorderSize = 0
        Me.btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBooks.ForeColor = System.Drawing.Color.White
        Me.btnBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBooks.Location = New System.Drawing.Point(2, 94)
        Me.btnBooks.Name = "btnBooks"
        Me.btnBooks.Size = New System.Drawing.Size(175, 53)
        Me.btnBooks.TabIndex = 2
        Me.btnBooks.Text = "Manage Books"
        Me.btnBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBooks.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(-1, -1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(183, 89)
        Me.Panel3.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(26, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Library System"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btnLogout)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(179, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(870, 62)
        Me.Panel2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(5, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(434, 46)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Library Management System"
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Transparent
        Me.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.InitialImage = Nothing
        Me.btnLogout.Location = New System.Drawing.Point(788, 6)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(71, 51)
        Me.btnLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnLogout.TabIndex = 0
        Me.btnLogout.TabStop = False
        Me.btnLogout.Tag = "Logout"
        '
        'pnlContainer
        '
        Me.pnlContainer.Location = New System.Drawing.Point(193, 95)
        Me.pnlContainer.Name = "pnlContainer"
        Me.pnlContainer.Size = New System.Drawing.Size(844, 450)
        Me.pnlContainer.TabIndex = 5
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial Narrow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(185, 65)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(42, 24)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Title"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1049, 557)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.pnlContainer)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.btnLogout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCategory As Button
    Friend WithEvents btnOverdues As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnBorrowBooks As Button
    Friend WithEvents btnBorrower As Button
    Friend WithEvents btnBooks As Button
    Friend WithEvents pnlContainer As Panel
    Friend WithEvents btnImageButton3 As PictureBox
    Friend WithEvents btnImageButton2 As PictureBox
    Friend WithEvents btnLogout As PictureBox
    Friend WithEvents btnReports As Button
    Friend WithEvents btnUser As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTitle As Label
End Class
