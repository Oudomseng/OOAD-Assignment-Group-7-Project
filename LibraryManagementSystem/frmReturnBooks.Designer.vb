<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReturnBooks
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
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtSearchPborrower = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.dtg_RlistReturn = New System.Windows.Forms.DataGridView()
        Me.grp_Rgroup = New System.Windows.Forms.GroupBox()
        Me.txtRname = New System.Windows.Forms.TextBox()
        Me.cboRborrowerId = New System.Windows.Forms.TextBox()
        Me.txtRbookTitle = New System.Windows.Forms.TextBox()
        Me.txtRauthor = New System.Windows.Forms.TextBox()
        Me.txtRdescription = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_accessionNo = New System.Windows.Forms.Label()
        Me.lbl_transid = New System.Windows.Forms.Label()
        Me.lbl_borrowerId = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lbl_Rduedate = New System.Windows.Forms.Label()
        Me.lbl_rpayments = New System.Windows.Forms.Label()
        Me.lbl_Rchange = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txt_RtenAmount = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtRCopyBorrowed = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtRRqty = New System.Windows.Forms.TextBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btn_Rsave = New System.Windows.Forms.Button()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtrbooksSearch = New System.Windows.Forms.TextBox()
        Me.dtgListreturned = New System.Windows.Forms.DataGridView()
        Me.check_due = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl3.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dtg_RlistReturn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Rgroup.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        CType(Me.dtgListreturned, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl3
        '
        Me.TabControl3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TabControl3.Controls.Add(Me.TabPage5)
        Me.TabControl3.Controls.Add(Me.TabPage6)
        Me.TabControl3.Location = New System.Drawing.Point(3, 6)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(852, 452)
        Me.TabControl3.TabIndex = 6
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.GroupBox3)
        Me.TabPage5.Controls.Add(Me.grp_Rgroup)
        Me.TabPage5.Controls.Add(Me.btnNew)
        Me.TabPage5.Controls.Add(Me.btn_Rsave)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(844, 426)
        Me.TabPage5.TabIndex = 0
        Me.TabPage5.Text = "Unreturn Books"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtSearchPborrower)
        Me.GroupBox3.Controls.Add(Me.Label27)
        Me.GroupBox3.Controls.Add(Me.dtg_RlistReturn)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(406, 414)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "View Details of Unreturn Books"
        '
        'txtSearchPborrower
        '
        Me.txtSearchPborrower.Location = New System.Drawing.Point(117, 24)
        Me.txtSearchPborrower.Name = "txtSearchPborrower"
        Me.txtSearchPborrower.Size = New System.Drawing.Size(283, 25)
        Me.txtSearchPborrower.TabIndex = 25
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(27, 27)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(84, 17)
        Me.Label27.TabIndex = 24
        Me.Label27.Text = "Borrower Id :"
        '
        'dtg_RlistReturn
        '
        Me.dtg_RlistReturn.AllowUserToAddRows = False
        Me.dtg_RlistReturn.AllowUserToDeleteRows = False
        Me.dtg_RlistReturn.AllowUserToResizeColumns = False
        Me.dtg_RlistReturn.AllowUserToResizeRows = False
        Me.dtg_RlistReturn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dtg_RlistReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_RlistReturn.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtg_RlistReturn.Location = New System.Drawing.Point(6, 55)
        Me.dtg_RlistReturn.MultiSelect = False
        Me.dtg_RlistReturn.Name = "dtg_RlistReturn"
        Me.dtg_RlistReturn.RowHeadersVisible = False
        Me.dtg_RlistReturn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg_RlistReturn.Size = New System.Drawing.Size(394, 353)
        Me.dtg_RlistReturn.TabIndex = 0
        '
        'grp_Rgroup
        '
        Me.grp_Rgroup.Controls.Add(Me.txtRname)
        Me.grp_Rgroup.Controls.Add(Me.cboRborrowerId)
        Me.grp_Rgroup.Controls.Add(Me.txtRbookTitle)
        Me.grp_Rgroup.Controls.Add(Me.txtRauthor)
        Me.grp_Rgroup.Controls.Add(Me.txtRdescription)
        Me.grp_Rgroup.Controls.Add(Me.GroupBox2)
        Me.grp_Rgroup.Controls.Add(Me.Label18)
        Me.grp_Rgroup.Controls.Add(Me.Label9)
        Me.grp_Rgroup.Controls.Add(Me.Label3)
        Me.grp_Rgroup.Controls.Add(Me.Label8)
        Me.grp_Rgroup.Controls.Add(Me.GroupBox5)
        Me.grp_Rgroup.Controls.Add(Me.Label25)
        Me.grp_Rgroup.Controls.Add(Me.txtRCopyBorrowed)
        Me.grp_Rgroup.Controls.Add(Me.Label14)
        Me.grp_Rgroup.Controls.Add(Me.Label11)
        Me.grp_Rgroup.Controls.Add(Me.txtRRqty)
        Me.grp_Rgroup.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_Rgroup.Location = New System.Drawing.Point(425, 17)
        Me.grp_Rgroup.Name = "grp_Rgroup"
        Me.grp_Rgroup.Size = New System.Drawing.Size(388, 297)
        Me.grp_Rgroup.TabIndex = 2
        Me.grp_Rgroup.TabStop = False
        Me.grp_Rgroup.Text = "Return"
        '
        'txtRname
        '
        Me.txtRname.Enabled = False
        Me.txtRname.Location = New System.Drawing.Point(27, 41)
        Me.txtRname.Name = "txtRname"
        Me.txtRname.Size = New System.Drawing.Size(345, 25)
        Me.txtRname.TabIndex = 27
        '
        'cboRborrowerId
        '
        Me.cboRborrowerId.Enabled = False
        Me.cboRborrowerId.Location = New System.Drawing.Point(36, 41)
        Me.cboRborrowerId.Name = "cboRborrowerId"
        Me.cboRborrowerId.Size = New System.Drawing.Size(65, 25)
        Me.cboRborrowerId.TabIndex = 30
        '
        'txtRbookTitle
        '
        Me.txtRbookTitle.Enabled = False
        Me.txtRbookTitle.Location = New System.Drawing.Point(27, 89)
        Me.txtRbookTitle.Name = "txtRbookTitle"
        Me.txtRbookTitle.Size = New System.Drawing.Size(345, 25)
        Me.txtRbookTitle.TabIndex = 29
        '
        'txtRauthor
        '
        Me.txtRauthor.Enabled = False
        Me.txtRauthor.Location = New System.Drawing.Point(27, 137)
        Me.txtRauthor.Name = "txtRauthor"
        Me.txtRauthor.Size = New System.Drawing.Size(345, 25)
        Me.txtRauthor.TabIndex = 27
        '
        'txtRdescription
        '
        Me.txtRdescription.Enabled = False
        Me.txtRdescription.Location = New System.Drawing.Point(27, 182)
        Me.txtRdescription.Multiline = True
        Me.txtRdescription.Name = "txtRdescription"
        Me.txtRdescription.Size = New System.Drawing.Size(345, 101)
        Me.txtRdescription.TabIndex = 27
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl_accessionNo)
        Me.GroupBox2.Controls.Add(Me.lbl_transid)
        Me.GroupBox2.Controls.Add(Me.lbl_borrowerId)
        Me.GroupBox2.Location = New System.Drawing.Point(515, 116)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(25, 10)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ID's Secret"
        '
        'lbl_accessionNo
        '
        Me.lbl_accessionNo.AutoSize = True
        Me.lbl_accessionNo.Location = New System.Drawing.Point(56, 42)
        Me.lbl_accessionNo.Name = "lbl_accessionNo"
        Me.lbl_accessionNo.Size = New System.Drawing.Size(88, 17)
        Me.lbl_accessionNo.TabIndex = 5
        Me.lbl_accessionNo.Text = "Accession #  :"
        '
        'lbl_transid
        '
        Me.lbl_transid.AutoSize = True
        Me.lbl_transid.Location = New System.Drawing.Point(59, 59)
        Me.lbl_transid.Name = "lbl_transid"
        Me.lbl_transid.Size = New System.Drawing.Size(48, 17)
        Me.lbl_transid.TabIndex = 24
        Me.lbl_transid.Text = "transid"
        '
        'lbl_borrowerId
        '
        Me.lbl_borrowerId.AutoSize = True
        Me.lbl_borrowerId.Location = New System.Drawing.Point(56, 25)
        Me.lbl_borrowerId.Name = "lbl_borrowerId"
        Me.lbl_borrowerId.Size = New System.Drawing.Size(78, 17)
        Me.lbl_borrowerId.TabIndex = 21
        Me.lbl_borrowerId.Text = "borrower id"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(28, 21)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(108, 17)
        Me.Label18.TabIndex = 19
        Me.Label18.Text = "Borrower Name :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(24, 165)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 17)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Description :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Author :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Book Title :"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lbl_Rduedate)
        Me.GroupBox5.Controls.Add(Me.lbl_rpayments)
        Me.GroupBox5.Controls.Add(Me.lbl_Rchange)
        Me.GroupBox5.Controls.Add(Me.Label24)
        Me.GroupBox5.Controls.Add(Me.Label23)
        Me.GroupBox5.Controls.Add(Me.txt_RtenAmount)
        Me.GroupBox5.Controls.Add(Me.Label22)
        Me.GroupBox5.Controls.Add(Me.Label21)
        Me.GroupBox5.Location = New System.Drawing.Point(506, 144)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(45, 25)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "do not touch.Time and Days for the future used. "
        '
        'lbl_Rduedate
        '
        Me.lbl_Rduedate.AutoSize = True
        Me.lbl_Rduedate.Location = New System.Drawing.Point(71, 26)
        Me.lbl_Rduedate.Name = "lbl_Rduedate"
        Me.lbl_Rduedate.Size = New System.Drawing.Size(53, 17)
        Me.lbl_Rduedate.TabIndex = 7
        Me.lbl_Rduedate.Text = "Label25"
        '
        'lbl_rpayments
        '
        Me.lbl_rpayments.AutoSize = True
        Me.lbl_rpayments.Location = New System.Drawing.Point(71, 52)
        Me.lbl_rpayments.Name = "lbl_rpayments"
        Me.lbl_rpayments.Size = New System.Drawing.Size(53, 17)
        Me.lbl_rpayments.TabIndex = 4
        Me.lbl_rpayments.Text = "Label25"
        '
        'lbl_Rchange
        '
        Me.lbl_Rchange.AutoSize = True
        Me.lbl_Rchange.Location = New System.Drawing.Point(75, 122)
        Me.lbl_Rchange.Name = "lbl_Rchange"
        Me.lbl_Rchange.Size = New System.Drawing.Size(53, 17)
        Me.lbl_Rchange.TabIndex = 6
        Me.lbl_Rchange.Text = "Label26"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(15, 122)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(59, 17)
        Me.Label24.TabIndex = 5
        Me.Label24.Text = "Change :"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(6, 87)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(119, 17)
        Me.Label23.TabIndex = 3
        Me.Label23.Text = "Tendered Amount :"
        '
        'txt_RtenAmount
        '
        Me.txt_RtenAmount.Location = New System.Drawing.Point(132, 84)
        Me.txt_RtenAmount.Name = "txt_RtenAmount"
        Me.txt_RtenAmount.Size = New System.Drawing.Size(177, 25)
        Me.txt_RtenAmount.TabIndex = 2
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(6, 52)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(70, 17)
        Me.Label22.TabIndex = 1
        Me.Label22.Text = "Payments :"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 26)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(70, 17)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Over Due :"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(28, 44)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(84, 17)
        Me.Label25.TabIndex = 22
        Me.Label25.Text = "Borrower Id :"
        Me.Label25.Visible = False
        '
        'txtRCopyBorrowed
        '
        Me.txtRCopyBorrowed.Enabled = False
        Me.txtRCopyBorrowed.Location = New System.Drawing.Point(27, 231)
        Me.txtRCopyBorrowed.Name = "txtRCopyBorrowed"
        Me.txtRCopyBorrowed.Size = New System.Drawing.Size(147, 25)
        Me.txtRCopyBorrowed.TabIndex = 27
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(189, 211)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(77, 17)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Return Qty :"
        Me.Label14.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(23, 214)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(157, 17)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "No. of Copies Borrowed :"
        '
        'txtRRqty
        '
        Me.txtRRqty.Location = New System.Drawing.Point(192, 231)
        Me.txtRRqty.Name = "txtRRqty"
        Me.txtRRqty.Size = New System.Drawing.Size(113, 25)
        Me.txtRRqty.TabIndex = 8
        Me.txtRRqty.Visible = False
        '
        'btnNew
        '
        Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(545, 320)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(123, 63)
        Me.btnNew.TabIndex = 0
        Me.btnNew.Text = "Clear"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btn_Rsave
        '
        Me.btn_Rsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Rsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Rsave.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Rsave.Location = New System.Drawing.Point(425, 320)
        Me.btn_Rsave.Name = "btn_Rsave"
        Me.btn_Rsave.Size = New System.Drawing.Size(118, 63)
        Me.btn_Rsave.TabIndex = 0
        Me.btn_Rsave.Text = "Return"
        Me.btn_Rsave.UseVisualStyleBackColor = True
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.Label4)
        Me.TabPage6.Controls.Add(Me.txtrbooksSearch)
        Me.TabPage6.Controls.Add(Me.dtgListreturned)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(844, 426)
        Me.TabPage6.TabIndex = 1
        Me.TabPage6.Text = "History"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(426, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 25)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Search :"
        '
        'txtrbooksSearch
        '
        Me.txtrbooksSearch.BackColor = System.Drawing.Color.White
        Me.txtrbooksSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrbooksSearch.Location = New System.Drawing.Point(517, 3)
        Me.txtrbooksSearch.Name = "txtrbooksSearch"
        Me.txtrbooksSearch.Size = New System.Drawing.Size(320, 30)
        Me.txtrbooksSearch.TabIndex = 1
        '
        'dtgListreturned
        '
        Me.dtgListreturned.AllowUserToAddRows = False
        Me.dtgListreturned.AllowUserToDeleteRows = False
        Me.dtgListreturned.AllowUserToResizeColumns = False
        Me.dtgListreturned.AllowUserToResizeRows = False
        Me.dtgListreturned.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgListreturned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgListreturned.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgListreturned.Location = New System.Drawing.Point(5, 42)
        Me.dtgListreturned.Name = "dtgListreturned"
        Me.dtgListreturned.RowHeadersVisible = False
        Me.dtgListreturned.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgListreturned.Size = New System.Drawing.Size(835, 378)
        Me.dtgListreturned.TabIndex = 0
        '
        'frmReturnBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(859, 464)
        Me.Controls.Add(Me.TabControl3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmReturnBooks"
        Me.Text = "frmReturnBooks"
        Me.TabControl3.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dtg_RlistReturn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Rgroup.ResumeLayout(False)
        Me.grp_Rgroup.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        CType(Me.dtgListreturned, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl3 As TabControl
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtSearchPborrower As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents dtg_RlistReturn As DataGridView
    Friend WithEvents grp_Rgroup As GroupBox
    Friend WithEvents txtRname As TextBox
    Friend WithEvents cboRborrowerId As TextBox
    Friend WithEvents txtRbookTitle As TextBox
    Friend WithEvents txtRauthor As TextBox
    Friend WithEvents txtRdescription As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbl_accessionNo As Label
    Friend WithEvents lbl_transid As Label
    Friend WithEvents lbl_borrowerId As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents lbl_Rduedate As Label
    Friend WithEvents lbl_rpayments As Label
    Friend WithEvents lbl_Rchange As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents txt_RtenAmount As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents txtRCopyBorrowed As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtRRqty As TextBox
    Friend WithEvents btnNew As Button
    Friend WithEvents btn_Rsave As Button
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents txtrbooksSearch As TextBox
    Friend WithEvents dtgListreturned As DataGridView
    Friend WithEvents check_due As Timer
End Class
