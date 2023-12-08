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
        Me.btnReports = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnUser = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnCategory = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnOverdues = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnReturn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnBorrowBooks = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnBorrower = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnBooks = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BunifuImageButton3 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnLogout = New Bunifu.Framework.UI.BunifuImageButton()
        Me.pnlContainer = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnLogout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnReports)
        Me.Panel1.Controls.Add(Me.btnUser)
        Me.Panel1.Controls.Add(Me.btnCategory)
        Me.Panel1.Controls.Add(Me.btnOverdues)
        Me.Panel1.Controls.Add(Me.btnReturn)
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
        Me.btnReports.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnReports.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btnReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReports.BorderRadius = 0
        'Me.btnReports.ButtonText = "Reports"
        'Me.btnReports.Cursor = System.Windows.Forms.Cursors.Hand
        'Me.btnReports.DisabledColor = System.Drawing.Color.Gray
        Me.btnReports.Font = New System.Drawing.Font("Century", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReports.Iconcolor = System.Drawing.Color.Transparent
        'Me.btnReports.Iconimage = CType(resources.GetObject("btnReports.Iconimage"), System.Drawing.Image)
        'Me.btnReports.Iconimage_right = Nothing
        'Me.btnReports.Iconimage_right_Selected = Nothing
        'Me.btnReports.Iconimage_Selected = Nothing
        'Me.btnReports.IconMarginLeft = 0
        'Me.btnReports.IconMarginRight = 0
        'Me.btnReports.IconRightVisible = True
        'Me.btnReports.IconRightZoom = 0R
        'Me.btnReports.IconVisible = True
        'Me.btnReports.IconZoom = 90.0R
        'Me.btnReports.IsTab = False
        Me.btnReports.Location = New System.Drawing.Point(1, 966)
        'Me.btnReports.Name = "btnReports"
        'Me.btnReports.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(95, Byte), Integer))
        'Me.btnReports.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(169, Byte), Integer))
        'Me.btnReports.OnHoverTextColor = System.Drawing.Color.White
        'Me.btnReports.selected = False
        'Me.btnReports.Size = New System.Drawing.Size(175, 53)
        'Me.btnReports.TabIndex = 9
        'Me.btnReports.Text = "Reports"
        'Me.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        'Me.btnReports.Textcolor = System.Drawing.Color.White
        'Me.btnReports.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnUser
        '
        Me.btnUser.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btnUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUser.BorderRadius = 0
        Me.btnUser.ButtonText = "Manage Users"
        Me.btnUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUser.DisabledColor = System.Drawing.Color.Gray
        Me.btnUser.Font = New System.Drawing.Font("Century", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUser.Iconcolor = System.Drawing.Color.Transparent
        Me.btnUser.Iconimage = CType(resources.GetObject("btnUser.Iconimage"), System.Drawing.Image)
        Me.btnUser.Iconimage_right = Nothing
        Me.btnUser.Iconimage_right_Selected = Nothing
        Me.btnUser.Iconimage_Selected = Nothing
        Me.btnUser.IconMarginLeft = 0
        Me.btnUser.IconMarginRight = 0
        Me.btnUser.IconRightVisible = True
        Me.btnUser.IconRightZoom = 0R
        Me.btnUser.IconVisible = True
        Me.btnUser.IconZoom = 90.0R
        Me.btnUser.IsTab = False
        Me.btnUser.Location = New System.Drawing.Point(2, 412)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btnUser.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUser.OnHoverTextColor = System.Drawing.Color.White
        Me.btnUser.selected = False
        Me.btnUser.Size = New System.Drawing.Size(175, 53)
        Me.btnUser.TabIndex = 8
        Me.btnUser.Text = "Manage Users"
        Me.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUser.Textcolor = System.Drawing.Color.White
        Me.btnUser.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnCategory
        '
        Me.btnCategory.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCategory.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btnCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCategory.BorderRadius = 0
        Me.btnCategory.ButtonText = "Category"
        Me.btnCategory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCategory.DisabledColor = System.Drawing.Color.Gray
        Me.btnCategory.Font = New System.Drawing.Font("Century", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCategory.Iconcolor = System.Drawing.Color.Transparent
        Me.btnCategory.Iconimage = CType(resources.GetObject("btnCategory.Iconimage"), System.Drawing.Image)
        Me.btnCategory.Iconimage_right = Nothing
        Me.btnCategory.Iconimage_right_Selected = Nothing
        Me.btnCategory.Iconimage_Selected = Nothing
        Me.btnCategory.IconMarginLeft = 0
        Me.btnCategory.IconMarginRight = 0
        Me.btnCategory.IconRightVisible = True
        Me.btnCategory.IconRightZoom = 0R
        Me.btnCategory.IconVisible = True
        Me.btnCategory.IconZoom = 90.0R
        Me.btnCategory.IsTab = False
        Me.btnCategory.Location = New System.Drawing.Point(1, 358)
        Me.btnCategory.Name = "btnCategory"
        Me.btnCategory.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btnCategory.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCategory.OnHoverTextColor = System.Drawing.Color.White
        Me.btnCategory.selected = False
        Me.btnCategory.Size = New System.Drawing.Size(175, 53)
        Me.btnCategory.TabIndex = 7
        Me.btnCategory.Text = "Category"
        Me.btnCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCategory.Textcolor = System.Drawing.Color.White
        Me.btnCategory.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnOverdues
        '
        Me.btnOverdues.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnOverdues.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btnOverdues.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOverdues.BorderRadius = 0
        Me.btnOverdues.ButtonText = "Overdues Books"
        Me.btnOverdues.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOverdues.DisabledColor = System.Drawing.Color.Gray
        Me.btnOverdues.Font = New System.Drawing.Font("Century", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOverdues.Iconcolor = System.Drawing.Color.Transparent
        Me.btnOverdues.Iconimage = CType(resources.GetObject("btnOverdues.Iconimage"), System.Drawing.Image)
        Me.btnOverdues.Iconimage_right = Nothing
        Me.btnOverdues.Iconimage_right_Selected = Nothing
        Me.btnOverdues.Iconimage_Selected = Nothing
        Me.btnOverdues.IconMarginLeft = 0
        Me.btnOverdues.IconMarginRight = 0
        Me.btnOverdues.IconRightVisible = True
        Me.btnOverdues.IconRightZoom = 0R
        Me.btnOverdues.IconVisible = True
        Me.btnOverdues.IconZoom = 90.0R
        Me.btnOverdues.IsTab = False
        Me.btnOverdues.Location = New System.Drawing.Point(1, 304)
        Me.btnOverdues.Name = "btnOverdues"
        Me.btnOverdues.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btnOverdues.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnOverdues.OnHoverTextColor = System.Drawing.Color.White
        Me.btnOverdues.selected = False
        Me.btnOverdues.Size = New System.Drawing.Size(175, 53)
        Me.btnOverdues.TabIndex = 6
        Me.btnOverdues.Text = "Overdues Books"
        Me.btnOverdues.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOverdues.Textcolor = System.Drawing.Color.White
        Me.btnOverdues.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnReturn
        '
        Me.btnReturn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReturn.BorderRadius = 0
        Me.btnReturn.ButtonText = "Return Books"
        Me.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReturn.DisabledColor = System.Drawing.Color.Gray
        Me.btnReturn.Font = New System.Drawing.Font("Century", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Iconcolor = System.Drawing.Color.Transparent
        Me.btnReturn.Iconimage = CType(resources.GetObject("btnReturn.Iconimage"), System.Drawing.Image)
        Me.btnReturn.Iconimage_right = Nothing
        Me.btnReturn.Iconimage_right_Selected = Nothing
        Me.btnReturn.Iconimage_Selected = Nothing
        Me.btnReturn.IconMarginLeft = 0
        Me.btnReturn.IconMarginRight = 0
        Me.btnReturn.IconRightVisible = True
        Me.btnReturn.IconRightZoom = 0R
        Me.btnReturn.IconVisible = True
        Me.btnReturn.IconZoom = 90.0R
        Me.btnReturn.IsTab = False
        Me.btnReturn.Location = New System.Drawing.Point(1, 250)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btnReturn.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnReturn.OnHoverTextColor = System.Drawing.Color.White
        Me.btnReturn.selected = False
        Me.btnReturn.Size = New System.Drawing.Size(175, 53)
        Me.btnReturn.TabIndex = 5
        Me.btnReturn.Text = "Return Books"
        Me.btnReturn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReturn.Textcolor = System.Drawing.Color.White
        Me.btnReturn.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnBorrowBooks
        '
        Me.btnBorrowBooks.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBorrowBooks.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btnBorrowBooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBorrowBooks.BorderRadius = 0
        Me.btnBorrowBooks.ButtonText = "Borrow Books"
        Me.btnBorrowBooks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrowBooks.DisabledColor = System.Drawing.Color.Gray
        Me.btnBorrowBooks.Font = New System.Drawing.Font("Century", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrowBooks.Iconcolor = System.Drawing.Color.Transparent
        Me.btnBorrowBooks.Iconimage = CType(resources.GetObject("btnBorrowBooks.Iconimage"), System.Drawing.Image)
        Me.btnBorrowBooks.Iconimage_right = Nothing
        Me.btnBorrowBooks.Iconimage_right_Selected = Nothing
        Me.btnBorrowBooks.Iconimage_Selected = Nothing
        Me.btnBorrowBooks.IconMarginLeft = 0
        Me.btnBorrowBooks.IconMarginRight = 0
        Me.btnBorrowBooks.IconRightVisible = True
        Me.btnBorrowBooks.IconRightZoom = 0R
        Me.btnBorrowBooks.IconVisible = True
        Me.btnBorrowBooks.IconZoom = 90.0R
        Me.btnBorrowBooks.IsTab = False
        Me.btnBorrowBooks.Location = New System.Drawing.Point(1, 196)
        Me.btnBorrowBooks.Name = "btnBorrowBooks"
        Me.btnBorrowBooks.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btnBorrowBooks.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBorrowBooks.OnHoverTextColor = System.Drawing.Color.White
        Me.btnBorrowBooks.selected = False
        Me.btnBorrowBooks.Size = New System.Drawing.Size(175, 53)
        Me.btnBorrowBooks.TabIndex = 4
        Me.btnBorrowBooks.Text = "Borrow Books"
        Me.btnBorrowBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBorrowBooks.Textcolor = System.Drawing.Color.White
        Me.btnBorrowBooks.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnBorrower
        '
        Me.btnBorrower.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBorrower.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btnBorrower.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBorrower.BorderRadius = 0
        Me.btnBorrower.ButtonText = "Borrower"
        Me.btnBorrower.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrower.DisabledColor = System.Drawing.Color.Gray
        Me.btnBorrower.Font = New System.Drawing.Font("Century", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrower.Iconcolor = System.Drawing.Color.Transparent
        Me.btnBorrower.Iconimage = CType(resources.GetObject("btnBorrower.Iconimage"), System.Drawing.Image)
        Me.btnBorrower.Iconimage_right = Nothing
        Me.btnBorrower.Iconimage_right_Selected = Nothing
        Me.btnBorrower.Iconimage_Selected = Nothing
        Me.btnBorrower.IconMarginLeft = 0
        Me.btnBorrower.IconMarginRight = 0
        Me.btnBorrower.IconRightVisible = True
        Me.btnBorrower.IconRightZoom = 0R
        Me.btnBorrower.IconVisible = True
        Me.btnBorrower.IconZoom = 90.0R
        Me.btnBorrower.IsTab = False
        Me.btnBorrower.Location = New System.Drawing.Point(1, 142)
        Me.btnBorrower.Name = "btnBorrower"
        Me.btnBorrower.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btnBorrower.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBorrower.OnHoverTextColor = System.Drawing.Color.White
        Me.btnBorrower.selected = False
        Me.btnBorrower.Size = New System.Drawing.Size(175, 53)
        Me.btnBorrower.TabIndex = 3
        Me.btnBorrower.Text = "Borrower"
        Me.btnBorrower.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBorrower.Textcolor = System.Drawing.Color.White
        Me.btnBorrower.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnBooks
        '
        Me.btnBooks.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBooks.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btnBooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBooks.BorderRadius = 0
        Me.btnBooks.ButtonText = "Books"
        Me.btnBooks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBooks.DisabledColor = System.Drawing.Color.Gray
        Me.btnBooks.Font = New System.Drawing.Font("Century", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBooks.Iconcolor = System.Drawing.Color.Transparent
        'Me.btnBooks.Iconimage = CType(resources.GetObject("btnBooks.Iconimage"), System.Drawing.Image)
        'Me.btnBooks.Iconimage = Image.FromFile("../../images/register2.png")
        Me.btnBooks.Iconimage = CType(resources.GetObject("btnBooks.Iconimage"), System.Drawing.Image)
        Me.btnBooks.Iconimage_right = Nothing
        Me.btnBooks.Iconimage_right_Selected = Nothing
        Me.btnBooks.Iconimage_Selected = Nothing
        Me.btnBooks.IconMarginLeft = 0
        Me.btnBooks.IconMarginRight = 0
        Me.btnBooks.IconRightVisible = True
        Me.btnBooks.IconRightZoom = 0R
        Me.btnBooks.IconVisible = True
        Me.btnBooks.IconZoom = 90.0R
        Me.btnBooks.IsTab = False
        Me.btnBooks.Location = New System.Drawing.Point(1, 88)
        Me.btnBooks.Name = "btnBooks"
        Me.btnBooks.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btnBooks.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBooks.OnHoverTextColor = System.Drawing.Color.White
        Me.btnBooks.selected = False
        Me.btnBooks.Size = New System.Drawing.Size(175, 53)
        Me.btnBooks.TabIndex = 2
        Me.btnBooks.Text = "Books"
        Me.btnBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBooks.Textcolor = System.Drawing.Color.White
        Me.btnBooks.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Location = New System.Drawing.Point(4, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(170, 82)
        Me.Panel3.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(79, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 40)
        Me.Label1.TabIndex = 2
        Me.Label1.ForeColor = System.Drawing.Color.Green

        Me.Label1.Text = "Group 7"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Image.FromFile("../../images/RUPP_logo.ico")
        'if i can put this picture in this and edit text in this system.
        '   Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.BunifuImageButton3)
        Me.Panel2.Controls.Add(Me.BunifuImageButton2)
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
        Me.Label2.Size = New System.Drawing.Size(236, 46)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Library Management System"
        '
        'BunifuImageButton3
        '
        Me.BunifuImageButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(95, Byte), Integer))
        'Me.BunifuImageButton3.Cursor = System.Windows.Forms.Cursors.Hand
        'Me.BunifuImageButton3.Image = CType(resources.GetObject("BunifuImageButton3.Image"), System.Drawing.Image)
        'Me.BunifuImageButton3.ImageActive = Nothing
        'Me.BunifuImageButton3.Location = New System.Drawing.Point(634, 6)
        'Me.BunifuImageButton3.Name = "BunifuImageButton3"
        'Me.BunifuImageButton3.Size = New System.Drawing.Size(71, 51)
        'Me.BunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        'Me.BunifuImageButton3.TabIndex = 2
        'Me.BunifuImageButton3.TabStop = False
        'Me.BunifuImageButton3.Tag = "Youtube Channel"
        'Me.BunifuImageButton3.Zoom = 10
        '

        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Transparent
        Me.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.ImageActive = Nothing
        Me.btnLogout.InitialImage = Nothing
        Me.btnLogout.Location = New System.Drawing.Point(788, 6)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(71, 51)
        Me.btnLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnLogout.TabIndex = 0
        Me.btnLogout.TabStop = False
        Me.btnLogout.Tag = "Logout"
        Me.btnLogout.Zoom = 10
        '
        'pnlContainer
        '
        Me.pnlContainer.BackgroundImage = CType(resources.GetObject("pnlContainer.BackgroundImage"), System.Drawing.Image)
        Me.pnlContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlContainer.GradientBottomLeft = System.Drawing.Color.White
        Me.pnlContainer.GradientBottomRight = System.Drawing.Color.White
        Me.pnlContainer.GradientTopLeft = System.Drawing.Color.White
        Me.pnlContainer.GradientTopRight = System.Drawing.Color.White
        Me.pnlContainer.Location = New System.Drawing.Point(184, 89)
        Me.pnlContainer.Name = "pnlContainer"
        Me.pnlContainer.Quality = 10
        Me.pnlContainer.Size = New System.Drawing.Size(859, 464)
        Me.pnlContainer.TabIndex = 2
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnLogout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCategory As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnOverdues As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnReturn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnBorrowBooks As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnBorrower As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnBooks As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents pnlContainer As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuImageButton3 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnLogout As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnReports As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnUser As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTitle As Label
End Class
