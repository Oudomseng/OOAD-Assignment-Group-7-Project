<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBooks
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
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDeweyDecimal = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.dtgList = New System.Windows.Forms.DataGridView()
        Me.cboCategory = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpDatePublish = New System.Windows.Forms.DateTimePicker()
        Me.txtPublisher = New System.Windows.Forms.TextBox()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAccessionNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dtgList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Location = New System.Drawing.Point(298, 144)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(63, 55)
        Me.btnDelete.TabIndex = 47
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Location = New System.Drawing.Point(233, 144)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(63, 55)
        Me.btnUpdate.TabIndex = 46
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'cboType
        '
        Me.cboType.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cboType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cboType.FormattingEnabled = True
        Me.cboType.Items.AddRange(New Object() {"Unknown", "Fiction", "Non-Fiction"})
        Me.cboType.Location = New System.Drawing.Point(565, 94)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(239, 24)
        Me.cboType.TabIndex = 45
        Me.cboType.Text = "Unknown"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label9.Location = New System.Drawing.Point(458, 97)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 17)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Type of Books :"
        '
        'txtDeweyDecimal
        '
        Me.txtDeweyDecimal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtDeweyDecimal.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtDeweyDecimal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeweyDecimal.Location = New System.Drawing.Point(565, 64)
        Me.txtDeweyDecimal.Name = "txtDeweyDecimal"
        Me.txtDeweyDecimal.ReadOnly = True
        Me.txtDeweyDecimal.Size = New System.Drawing.Size(239, 23)
        Me.txtDeweyDecimal.TabIndex = 37
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(453, 67)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 17)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "Dewey Decimal :"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(488, 191)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 20)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "Search:"
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtSearch.BackColor = System.Drawing.Color.White
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(557, 188)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(296, 26)
        Me.txtSearch.TabIndex = 41
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(168, 144)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(63, 55)
        Me.btnSave.TabIndex = 38
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(363, 144)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(63, 55)
        Me.btnNew.TabIndex = 39
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'dtgList
        '
        Me.dtgList.AllowUserToAddRows = False
        Me.dtgList.AllowUserToDeleteRows = False
        Me.dtgList.AllowUserToResizeColumns = False
        Me.dtgList.AllowUserToResizeRows = False
        Me.dtgList.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dtgList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgList.Location = New System.Drawing.Point(5, 220)
        Me.dtgList.Name = "dtgList"
        Me.dtgList.RowHeadersVisible = False
        Me.dtgList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgList.Size = New System.Drawing.Size(848, 237)
        Me.dtgList.TabIndex = 33
        '
        'cboCategory
        '
        Me.cboCategory.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cboCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.Location = New System.Drawing.Point(565, 37)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(239, 24)
        Me.cboCategory.TabIndex = 36
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(66, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 17)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Date Publish :"
        '
        'dtpDatePublish
        '
        Me.dtpDatePublish.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dtpDatePublish.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDatePublish.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDatePublish.Location = New System.Drawing.Point(168, 115)
        Me.dtpDatePublish.Name = "dtpDatePublish"
        Me.dtpDatePublish.Size = New System.Drawing.Size(170, 23)
        Me.dtpDatePublish.TabIndex = 34
        '
        'txtPublisher
        '
        Me.txtPublisher.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtPublisher.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPublisher.Location = New System.Drawing.Point(565, 11)
        Me.txtPublisher.Name = "txtPublisher"
        Me.txtPublisher.Size = New System.Drawing.Size(239, 23)
        Me.txtPublisher.TabIndex = 35
        '
        'txtAuthor
        '
        Me.txtAuthor.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtAuthor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAuthor.Location = New System.Drawing.Point(168, 89)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(239, 23)
        Me.txtAuthor.TabIndex = 32
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(492, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 17)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Category :"
        '
        'txtDesc
        '
        Me.txtDesc.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc.Location = New System.Drawing.Point(168, 63)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(239, 23)
        Me.txtDesc.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(490, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 17)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Publisher :"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(102, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 17)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Author :"
        '
        'txtTitle
        '
        Me.txtTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(168, 37)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(239, 23)
        Me.txtTitle.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(73, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 17)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Description :"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(117, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 17)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Title :"
        '
        'txtAccessionNo
        '
        Me.txtAccessionNo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtAccessionNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccessionNo.Location = New System.Drawing.Point(168, 11)
        Me.txtAccessionNo.Name = "txtAccessionNo"
        Me.txtAccessionNo.Size = New System.Drawing.Size(239, 23)
        Me.txtAccessionNo.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 17)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Accession No. :"
        '
        'frmBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(859, 464)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.cboType)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtDeweyDecimal)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.dtgList)
        Me.Controls.Add(Me.cboCategory)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtpDatePublish)
        Me.Controls.Add(Me.txtPublisher)
        Me.Controls.Add(Me.txtAuthor)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAccessionNo)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBooks"
        Me.Text = "frmBooks"
        CType(Me.dtgList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents cboType As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDeweyDecimal As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents dtgList As DataGridView
    Friend WithEvents cboCategory As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpDatePublish As DateTimePicker
    Friend WithEvents txtPublisher As TextBox
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAccessionNo As TextBox
    Friend WithEvents Label1 As Label
End Class
