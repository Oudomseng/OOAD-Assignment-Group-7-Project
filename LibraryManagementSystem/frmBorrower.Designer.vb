<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBorrower
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
        Me.btnCard = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btn_last = New System.Windows.Forms.Button()
        Me.btn_next = New System.Windows.Forms.Button()
        Me.btn_New = New System.Windows.Forms.Button()
        Me.btn_first = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_prev = New System.Windows.Forms.Button()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtg_ABorrowLists = New System.Windows.Forms.DataGridView()
        Me.txt_bid = New System.Windows.Forms.TextBox()
        Me.txt_fname = New System.Windows.Forms.TextBox()
        Me.rdio_female = New System.Windows.Forms.RadioButton()
        Me.txt_mname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_lname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rch_address = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rdio_male = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtPhoto = New System.Windows.Forms.TextBox()
        Me.btnDisable = New System.Windows.Forms.Button()
        CType(Me.dtg_ABorrowLists, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCard
        '
        Me.btnCard.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCard.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCard.Location = New System.Drawing.Point(527, 175)
        Me.btnCard.Name = "btnCard"
        Me.btnCard.Size = New System.Drawing.Size(78, 44)
        Me.btnCard.TabIndex = 66
        Me.btnCard.Text = "Print Card"
        Me.btnCard.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btn_last
        '
        Me.btn_last.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_last.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_last.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_last.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_last.Location = New System.Drawing.Point(736, 221)
        Me.btn_last.Name = "btn_last"
        Me.btn_last.Size = New System.Drawing.Size(51, 24)
        Me.btn_last.TabIndex = 60
        Me.btn_last.Text = ">>|"
        Me.btn_last.UseVisualStyleBackColor = True
        '
        'btn_next
        '
        Me.btn_next.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_next.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_next.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_next.Location = New System.Drawing.Point(679, 221)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(51, 24)
        Me.btn_next.TabIndex = 59
        Me.btn_next.Text = ">>"
        Me.btn_next.UseVisualStyleBackColor = True
        '
        'btn_New
        '
        Me.btn_New.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_New.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_New.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_New.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_New.Location = New System.Drawing.Point(753, 174)
        Me.btn_New.Name = "btn_New"
        Me.btn_New.Size = New System.Drawing.Size(68, 44)
        Me.btn_New.TabIndex = 57
        Me.btn_New.Text = "Clear"
        Me.btn_New.UseVisualStyleBackColor = True
        '
        'btn_first
        '
        Me.btn_first.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_first.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_first.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_first.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_first.Location = New System.Drawing.Point(565, 221)
        Me.btn_first.Name = "btn_first"
        Me.btn_first.Size = New System.Drawing.Size(51, 24)
        Me.btn_first.TabIndex = 61
        Me.btn_first.Text = "|<<"
        Me.btn_first.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(679, 175)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(68, 44)
        Me.btn_delete.TabIndex = 56
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Location = New System.Drawing.Point(609, 175)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(66, 44)
        Me.btn_save.TabIndex = 54
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_prev
        '
        Me.btn_prev.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_prev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_prev.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_prev.Location = New System.Drawing.Point(622, 221)
        Me.btn_prev.Name = "btn_prev"
        Me.btn_prev.Size = New System.Drawing.Size(51, 24)
        Me.btn_prev.TabIndex = 58
        Me.btn_prev.Text = "<<"
        Me.btn_prev.UseVisualStyleBackColor = True
        '
        'txtContact
        '
        Me.txtContact.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtContact.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Location = New System.Drawing.Point(125, 196)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(357, 25)
        Me.txtContact.TabIndex = 51
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(29, 202)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 17)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Contact No. : "
        '
        'txtCourse
        '
        Me.txtCourse.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtCourse.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourse.Location = New System.Drawing.Point(607, 146)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(216, 25)
        Me.txtCourse.TabIndex = 50
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(514, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 17)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Course/Year :"
        '
        'dtg_ABorrowLists
        '
        Me.dtg_ABorrowLists.AllowUserToAddRows = False
        Me.dtg_ABorrowLists.AllowUserToDeleteRows = False
        Me.dtg_ABorrowLists.AllowUserToResizeColumns = False
        Me.dtg_ABorrowLists.AllowUserToResizeRows = False
        Me.dtg_ABorrowLists.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dtg_ABorrowLists.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtg_ABorrowLists.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtg_ABorrowLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_ABorrowLists.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtg_ABorrowLists.Location = New System.Drawing.Point(6, 249)
        Me.dtg_ABorrowLists.Name = "dtg_ABorrowLists"
        Me.dtg_ABorrowLists.RowHeadersVisible = False
        Me.dtg_ABorrowLists.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg_ABorrowLists.Size = New System.Drawing.Size(846, 210)
        Me.dtg_ABorrowLists.TabIndex = 49
        '
        'txt_bid
        '
        Me.txt_bid.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_bid.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bid.Location = New System.Drawing.Point(125, 11)
        Me.txt_bid.Name = "txt_bid"
        Me.txt_bid.Size = New System.Drawing.Size(357, 25)
        Me.txt_bid.TabIndex = 35
        '
        'txt_fname
        '
        Me.txt_fname.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_fname.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fname.Location = New System.Drawing.Point(125, 40)
        Me.txt_fname.Name = "txt_fname"
        Me.txt_fname.Size = New System.Drawing.Size(357, 25)
        Me.txt_fname.TabIndex = 36
        '
        'rdio_female
        '
        Me.rdio_female.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.rdio_female.AutoSize = True
        Me.rdio_female.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdio_female.Location = New System.Drawing.Point(187, 175)
        Me.rdio_female.Name = "rdio_female"
        Me.rdio_female.Size = New System.Drawing.Size(67, 21)
        Me.rdio_female.TabIndex = 47
        Me.rdio_female.TabStop = True
        Me.rdio_female.Text = "Female"
        Me.rdio_female.UseVisualStyleBackColor = True
        '
        'txt_mname
        '
        Me.txt_mname.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_mname.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mname.Location = New System.Drawing.Point(125, 98)
        Me.txt_mname.Name = "txt_mname"
        Me.txt_mname.Size = New System.Drawing.Size(357, 25)
        Me.txt_mname.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 17)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Borrower Id :"
        '
        'txt_lname
        '
        Me.txt_lname.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_lname.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_lname.Location = New System.Drawing.Point(125, 69)
        Me.txt_lname.Name = "txt_lname"
        Me.txt_lname.Size = New System.Drawing.Size(357, 25)
        Me.txt_lname.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 17)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "First Name :"
        '
        'rch_address
        '
        Me.rch_address.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.rch_address.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rch_address.Location = New System.Drawing.Point(125, 127)
        Me.rch_address.Name = "rch_address"
        Me.rch_address.Size = New System.Drawing.Size(357, 44)
        Me.rch_address.TabIndex = 43
        Me.rch_address.Text = ""
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 17)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Last Name :"
        '
        'rdio_male
        '
        Me.rdio_male.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.rdio_male.AutoSize = True
        Me.rdio_male.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdio_male.Location = New System.Drawing.Point(125, 175)
        Me.rdio_male.Name = "rdio_male"
        Me.rdio_male.Size = New System.Drawing.Size(55, 21)
        Me.rdio_male.TabIndex = 46
        Me.rdio_male.TabStop = True
        Me.rdio_male.Text = "Male"
        Me.rdio_male.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 17)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Middle Name :"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(52, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 17)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Address :"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(73, 177)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 17)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Sex :"
        '
        'btn_edit
        '
        Me.btn_edit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_edit.Enabled = False
        Me.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_edit.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.Location = New System.Drawing.Point(611, 175)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(64, 44)
        Me.btn_edit.TabIndex = 55
        Me.btn_edit.Text = "Update"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Location = New System.Drawing.Point(607, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(216, 136)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
        '
        'txtPhoto
        '
        Me.txtPhoto.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtPhoto.Location = New System.Drawing.Point(609, 41)
        Me.txtPhoto.Name = "txtPhoto"
        Me.txtPhoto.Size = New System.Drawing.Size(209, 20)
        Me.txtPhoto.TabIndex = 63
        '
        'btnDisable
        '
        Me.btnDisable.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnDisable.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDisable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDisable.Location = New System.Drawing.Point(679, 175)
        Me.btnDisable.Name = "btnDisable"
        Me.btnDisable.Size = New System.Drawing.Size(68, 44)
        Me.btnDisable.TabIndex = 65
        Me.btnDisable.Text = "Disable"
        Me.btnDisable.UseVisualStyleBackColor = True
        '
        'frmBorrower
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(859, 464)
        Me.Controls.Add(Me.btnCard)
        Me.Controls.Add(Me.btn_last)
        Me.Controls.Add(Me.btn_next)
        Me.Controls.Add(Me.btn_New)
        Me.Controls.Add(Me.btn_first)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_prev)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCourse)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtg_ABorrowLists)
        Me.Controls.Add(Me.txt_bid)
        Me.Controls.Add(Me.txt_fname)
        Me.Controls.Add(Me.rdio_female)
        Me.Controls.Add(Me.txt_mname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_lname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.rch_address)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rdio_male)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtPhoto)
        Me.Controls.Add(Me.btnDisable)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBorrower"
        Me.Text = "frmBorrower"
        CType(Me.dtg_ABorrowLists, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCard As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btn_last As Button
    Friend WithEvents btn_next As Button
    Friend WithEvents btn_New As Button
    Friend WithEvents btn_first As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_prev As Button
    Friend WithEvents txtContact As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCourse As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dtg_ABorrowLists As DataGridView
    Friend WithEvents txt_bid As TextBox
    Friend WithEvents txt_fname As TextBox
    Friend WithEvents rdio_female As RadioButton
    Friend WithEvents txt_mname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_lname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents rch_address As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents rdio_male As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_edit As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtPhoto As TextBox
    Friend WithEvents btnDisable As Button
End Class
