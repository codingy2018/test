<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreateUsers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCreateUsers))
        Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_Add = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_Edit = New System.Windows.Forms.ToolStripButton()
        Me.side2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_Delete = New System.Windows.Forms.ToolStripButton()
        Me.side3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_close = New System.Windows.Forms.ToolStripButton()
        Me.txtAttempt = New System.Windows.Forms.TextBox()
        Me.DTLastSignDate = New System.Windows.Forms.DateTimePicker()
        Me.txtLocked = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DTBookingDate = New System.Windows.Forms.DateTimePicker()
        Me.txtInputer = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtStaffID = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtLastSignDate = New System.Windows.Forms.MaskedTextBox()
        Me.lblBookingDate = New System.Windows.Forms.Label()
        Me.lblLastSingDate = New System.Windows.Forms.Label()
        Me.txtBookingDate = New System.Windows.Forms.MaskedTextBox()
        Me.ChkActive = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CboProfile = New System.Windows.Forms.ComboBox()
        Me.lblPWD = New System.Windows.Forms.Label()
        Me.TxtPWD = New System.Windows.Forms.TextBox()
        Me.txtLoginName = New System.Windows.Forms.TextBox()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtmatdate = New System.Windows.Forms.Label()
        Me.lblMisExpireDate = New System.Windows.Forms.Label()
        Me.lblMisStartDate = New System.Windows.Forms.Label()
        Me.DTStartDate = New System.Windows.Forms.DateTimePicker()
        Me.DTExpireDate = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtExpireDate = New System.Windows.Forms.MaskedTextBox()
        Me.txtStartDate = New System.Windows.Forms.MaskedTextBox()
        Me.gdUsers = New System.Windows.Forms.DataGridView()
        Me.txtNextChangeDate = New System.Windows.Forms.MaskedTextBox()
        Me.lblNextChangedDate = New System.Windows.Forms.Label()
        Me.DTNextChangeDate = New System.Windows.Forms.DateTimePicker()
        Me.lblStaffID = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.toolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.gdUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'toolStrip1
        '
        Me.toolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_Add, Me.ToolStripSeparator1, Me.btn_Edit, Me.side2, Me.btn_Delete, Me.side3, Me.btn_close})
        Me.toolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.toolStrip1.Name = "toolStrip1"
        Me.toolStrip1.Size = New System.Drawing.Size(978, 31)
        Me.toolStrip1.TabIndex = 189
        Me.toolStrip1.Text = "toolStrip1"
        '
        'btn_Add
        '
        Me.btn_Add.Image = CType(resources.GetObject("btn_Add.Image"), System.Drawing.Image)
        Me.btn_Add.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(60, 28)
        Me.btn_Add.Text = "&Add "
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'btn_Edit
        '
        Me.btn_Edit.Image = CType(resources.GetObject("btn_Edit.Image"), System.Drawing.Image)
        Me.btn_Edit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Edit.Name = "btn_Edit"
        Me.btn_Edit.Size = New System.Drawing.Size(55, 28)
        Me.btn_Edit.Text = "&Edit"
        '
        'side2
        '
        Me.side2.Name = "side2"
        Me.side2.Size = New System.Drawing.Size(6, 31)
        '
        'btn_Delete
        '
        Me.btn_Delete.Image = CType(resources.GetObject("btn_Delete.Image"), System.Drawing.Image)
        Me.btn_Delete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Delete.Name = "btn_Delete"
        Me.btn_Delete.Size = New System.Drawing.Size(68, 28)
        Me.btn_Delete.Text = "&Delete"
        Me.btn_Delete.ToolTipText = "Delete"
        '
        'side3
        '
        Me.side3.Name = "side3"
        Me.side3.Size = New System.Drawing.Size(6, 31)
        '
        'btn_close
        '
        Me.btn_close.Image = CType(resources.GetObject("btn_close.Image"), System.Drawing.Image)
        Me.btn_close.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(64, 28)
        Me.btn_close.Text = "&Close"
        '
        'txtAttempt
        '
        Me.txtAttempt.BackColor = System.Drawing.Color.Khaki
        Me.txtAttempt.Location = New System.Drawing.Point(123, 168)
        Me.txtAttempt.Name = "txtAttempt"
        Me.txtAttempt.Size = New System.Drawing.Size(74, 20)
        Me.txtAttempt.TabIndex = 169
        '
        'DTLastSignDate
        '
        Me.DTLastSignDate.Enabled = False
        Me.DTLastSignDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTLastSignDate.Location = New System.Drawing.Point(113, 55)
        Me.DTLastSignDate.Name = "DTLastSignDate"
        Me.DTLastSignDate.Size = New System.Drawing.Size(135, 20)
        Me.DTLastSignDate.TabIndex = 83
        Me.DTLastSignDate.Visible = False
        '
        'txtLocked
        '
        Me.txtLocked.Enabled = False
        Me.txtLocked.Location = New System.Drawing.Point(112, 5)
        Me.txtLocked.Name = "txtLocked"
        Me.txtLocked.Size = New System.Drawing.Size(74, 20)
        Me.txtLocked.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(59, 6)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 14)
        Me.Label10.TabIndex = 87
        Me.Label10.Text = "Locked"
        '
        'DTBookingDate
        '
        Me.DTBookingDate.Enabled = False
        Me.DTBookingDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTBookingDate.Location = New System.Drawing.Point(113, 83)
        Me.DTBookingDate.Name = "DTBookingDate"
        Me.DTBookingDate.Size = New System.Drawing.Size(135, 20)
        Me.DTBookingDate.TabIndex = 91
        Me.DTBookingDate.Visible = False
        '
        'txtInputer
        '
        Me.txtInputer.Enabled = False
        Me.txtInputer.Location = New System.Drawing.Point(112, 27)
        Me.txtInputer.Name = "txtInputer"
        Me.txtInputer.Size = New System.Drawing.Size(135, 20)
        Me.txtInputer.TabIndex = 12
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Blue
        Me.Label15.Location = New System.Drawing.Point(25, 87)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 14)
        Me.Label15.TabIndex = 90
        Me.Label15.Text = "Booking Date"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Blue
        Me.Label13.Location = New System.Drawing.Point(57, 29)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 14)
        Me.Label13.TabIndex = 89
        Me.Label13.Text = "Inputer"
        '
        'txtStaffID
        '
        Me.txtStaffID.BackColor = System.Drawing.Color.Khaki
        Me.txtStaffID.Location = New System.Drawing.Point(123, 191)
        Me.txtStaffID.Name = "txtStaffID"
        Me.txtStaffID.Size = New System.Drawing.Size(74, 20)
        Me.txtStaffID.TabIndex = 170
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtLastSignDate)
        Me.Panel1.Controls.Add(Me.lblBookingDate)
        Me.Panel1.Controls.Add(Me.lblLastSingDate)
        Me.Panel1.Controls.Add(Me.txtBookingDate)
        Me.Panel1.Controls.Add(Me.ChkActive)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.DTLastSignDate)
        Me.Panel1.Controls.Add(Me.txtLocked)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.DTBookingDate)
        Me.Panel1.Controls.Add(Me.txtInputer)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Location = New System.Drawing.Point(11, 217)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(268, 128)
        Me.Panel1.TabIndex = 188
        '
        'txtLastSignDate
        '
        Me.txtLastSignDate.BackColor = System.Drawing.Color.White
        Me.txtLastSignDate.Enabled = False
        Me.txtLastSignDate.Location = New System.Drawing.Point(113, 57)
        Me.txtLastSignDate.Mask = "00/00/0000"
        Me.txtLastSignDate.Name = "txtLastSignDate"
        Me.txtLastSignDate.Size = New System.Drawing.Size(118, 20)
        Me.txtLastSignDate.TabIndex = 13
        Me.txtLastSignDate.ValidatingType = GetType(Date)
        Me.txtLastSignDate.Visible = False
        '
        'lblBookingDate
        '
        Me.lblBookingDate.AutoSize = True
        Me.lblBookingDate.Location = New System.Drawing.Point(114, 88)
        Me.lblBookingDate.Name = "lblBookingDate"
        Me.lblBookingDate.Size = New System.Drawing.Size(0, 13)
        Me.lblBookingDate.TabIndex = 92
        '
        'lblLastSingDate
        '
        Me.lblLastSingDate.AutoSize = True
        Me.lblLastSingDate.Location = New System.Drawing.Point(114, 62)
        Me.lblLastSingDate.Name = "lblLastSingDate"
        Me.lblLastSingDate.Size = New System.Drawing.Size(0, 13)
        Me.lblLastSingDate.TabIndex = 92
        '
        'txtBookingDate
        '
        Me.txtBookingDate.Enabled = False
        Me.txtBookingDate.Location = New System.Drawing.Point(113, 83)
        Me.txtBookingDate.Mask = "00/00/0000"
        Me.txtBookingDate.Name = "txtBookingDate"
        Me.txtBookingDate.Size = New System.Drawing.Size(118, 20)
        Me.txtBookingDate.TabIndex = 14
        Me.txtBookingDate.ValidatingType = GetType(Date)
        Me.txtBookingDate.Visible = False
        '
        'ChkActive
        '
        Me.ChkActive.AutoSize = True
        Me.ChkActive.Checked = True
        Me.ChkActive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkActive.ForeColor = System.Drawing.Color.Red
        Me.ChkActive.Location = New System.Drawing.Point(112, 107)
        Me.ChkActive.Name = "ChkActive"
        Me.ChkActive.Size = New System.Drawing.Size(56, 17)
        Me.ChkActive.TabIndex = 15
        Me.ChkActive.Text = "Active"
        Me.ChkActive.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(3, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 14)
        Me.Label9.TabIndex = 82
        Me.Label9.Text = "Last SignOn Date"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(57, 169)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 14)
        Me.Label8.TabIndex = 175
        Me.Label8.Text = "Attempts"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(14, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 16)
        Me.Label6.TabIndex = 174
        Me.Label6.Text = "Profile"
        '
        'CboProfile
        '
        Me.CboProfile.BackColor = System.Drawing.Color.Khaki
        Me.CboProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboProfile.FormattingEnabled = True
        Me.CboProfile.Items.AddRange(New Object() {"Admin", "User"})
        Me.CboProfile.Location = New System.Drawing.Point(123, 57)
        Me.CboProfile.Name = "CboProfile"
        Me.CboProfile.Size = New System.Drawing.Size(185, 21)
        Me.CboProfile.TabIndex = 164
        '
        'lblPWD
        '
        Me.lblPWD.AutoSize = True
        Me.lblPWD.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPWD.ForeColor = System.Drawing.Color.Blue
        Me.lblPWD.Location = New System.Drawing.Point(53, 83)
        Me.lblPWD.Name = "lblPWD"
        Me.lblPWD.Size = New System.Drawing.Size(63, 16)
        Me.lblPWD.TabIndex = 173
        Me.lblPWD.Text = "Password"
        '
        'TxtPWD
        '
        Me.TxtPWD.BackColor = System.Drawing.Color.Khaki
        Me.TxtPWD.Location = New System.Drawing.Point(123, 80)
        Me.TxtPWD.MaxLength = 50
        Me.TxtPWD.Name = "TxtPWD"
        Me.TxtPWD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPWD.Size = New System.Drawing.Size(185, 20)
        Me.TxtPWD.TabIndex = 165
        '
        'txtLoginName
        '
        Me.txtLoginName.BackColor = System.Drawing.Color.Khaki
        Me.txtLoginName.Location = New System.Drawing.Point(65, -9)
        Me.txtLoginName.MaxLength = 50
        Me.txtLoginName.Name = "txtLoginName"
        Me.txtLoginName.Size = New System.Drawing.Size(185, 20)
        Me.txtLoginName.TabIndex = 163
        '
        'TxtUsername
        '
        Me.TxtUsername.BackColor = System.Drawing.Color.Khaki
        Me.TxtUsername.Location = New System.Drawing.Point(65, -32)
        Me.TxtUsername.MaxLength = 50
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(185, 20)
        Me.TxtUsername.TabIndex = 162
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(-17, -7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 16)
        Me.Label2.TabIndex = 172
        Me.Label2.Text = "Login Name"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(52, 106)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 14)
        Me.Label11.TabIndex = 176
        Me.Label11.Text = "Start Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(-13, -29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 16)
        Me.Label1.TabIndex = 171
        Me.Label1.Text = "User Name"
        '
        'txtUserID
        '
        Me.txtUserID.BackColor = System.Drawing.Color.Khaki
        Me.txtUserID.Location = New System.Drawing.Point(65, -58)
        Me.txtUserID.MaxLength = 50
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(185, 20)
        Me.txtUserID.TabIndex = 161
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(8, -55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 16)
        Me.Label5.TabIndex = 183
        Me.Label5.Text = "User ID"
        '
        'dtmatdate
        '
        Me.dtmatdate.AutoSize = True
        Me.dtmatdate.BackColor = System.Drawing.Color.Transparent
        Me.dtmatdate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtmatdate.ForeColor = System.Drawing.Color.Blue
        Me.dtmatdate.Location = New System.Drawing.Point(8, 151)
        Me.dtmatdate.Name = "dtmatdate"
        Me.dtmatdate.Size = New System.Drawing.Size(108, 14)
        Me.dtmatdate.TabIndex = 182
        Me.dtmatdate.Text = "Next Change Date"
        '
        'lblMisExpireDate
        '
        Me.lblMisExpireDate.AutoSize = True
        Me.lblMisExpireDate.Location = New System.Drawing.Point(467, 134)
        Me.lblMisExpireDate.Name = "lblMisExpireDate"
        Me.lblMisExpireDate.Size = New System.Drawing.Size(0, 13)
        Me.lblMisExpireDate.TabIndex = 181
        '
        'lblMisStartDate
        '
        Me.lblMisStartDate.AutoSize = True
        Me.lblMisStartDate.Location = New System.Drawing.Point(467, 107)
        Me.lblMisStartDate.Name = "lblMisStartDate"
        Me.lblMisStartDate.Size = New System.Drawing.Size(0, 13)
        Me.lblMisStartDate.TabIndex = 180
        '
        'DTStartDate
        '
        Me.DTStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTStartDate.Location = New System.Drawing.Point(123, 101)
        Me.DTStartDate.Name = "DTStartDate"
        Me.DTStartDate.Size = New System.Drawing.Size(135, 20)
        Me.DTStartDate.TabIndex = 178
        Me.DTStartDate.Value = New Date(2008, 9, 21, 0, 0, 0, 0)
        '
        'DTExpireDate
        '
        Me.DTExpireDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTExpireDate.Location = New System.Drawing.Point(123, 126)
        Me.DTExpireDate.Name = "DTExpireDate"
        Me.DTExpireDate.Size = New System.Drawing.Size(135, 20)
        Me.DTExpireDate.TabIndex = 179
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(46, 129)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 14)
        Me.Label12.TabIndex = 177
        Me.Label12.Text = "Expire Date"
        '
        'txtExpireDate
        '
        Me.txtExpireDate.BackColor = System.Drawing.Color.Khaki
        Me.txtExpireDate.Location = New System.Drawing.Point(123, 126)
        Me.txtExpireDate.Mask = "00/00/0000"
        Me.txtExpireDate.Name = "txtExpireDate"
        Me.txtExpireDate.Size = New System.Drawing.Size(121, 20)
        Me.txtExpireDate.TabIndex = 167
        Me.txtExpireDate.ValidatingType = GetType(Date)
        '
        'txtStartDate
        '
        Me.txtStartDate.BackColor = System.Drawing.Color.Khaki
        Me.txtStartDate.Location = New System.Drawing.Point(123, 101)
        Me.txtStartDate.Mask = "00/00/0000"
        Me.txtStartDate.Name = "txtStartDate"
        Me.txtStartDate.Size = New System.Drawing.Size(121, 20)
        Me.txtStartDate.TabIndex = 166
        Me.txtStartDate.ValidatingType = GetType(Date)
        '
        'gdUsers
        '
        Me.gdUsers.AllowUserToAddRows = False
        Me.gdUsers.AllowUserToDeleteRows = False
        Me.gdUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gdUsers.Location = New System.Drawing.Point(342, 62)
        Me.gdUsers.Name = "gdUsers"
        Me.gdUsers.ReadOnly = True
        Me.gdUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gdUsers.Size = New System.Drawing.Size(569, 283)
        Me.gdUsers.TabIndex = 186
        '
        'txtNextChangeDate
        '
        Me.txtNextChangeDate.BackColor = System.Drawing.Color.Khaki
        Me.txtNextChangeDate.Location = New System.Drawing.Point(123, 147)
        Me.txtNextChangeDate.Mask = "00/00/0000"
        Me.txtNextChangeDate.Name = "txtNextChangeDate"
        Me.txtNextChangeDate.Size = New System.Drawing.Size(121, 20)
        Me.txtNextChangeDate.TabIndex = 168
        Me.txtNextChangeDate.ValidatingType = GetType(Date)
        '
        'lblNextChangedDate
        '
        Me.lblNextChangedDate.AutoSize = True
        Me.lblNextChangedDate.Location = New System.Drawing.Point(467, 155)
        Me.lblNextChangedDate.Name = "lblNextChangedDate"
        Me.lblNextChangedDate.Size = New System.Drawing.Size(0, 13)
        Me.lblNextChangedDate.TabIndex = 185
        '
        'DTNextChangeDate
        '
        Me.DTNextChangeDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTNextChangeDate.Location = New System.Drawing.Point(123, 147)
        Me.DTNextChangeDate.Name = "DTNextChangeDate"
        Me.DTNextChangeDate.Size = New System.Drawing.Size(135, 20)
        Me.DTNextChangeDate.TabIndex = 184
        '
        'lblStaffID
        '
        Me.lblStaffID.AutoSize = True
        Me.lblStaffID.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaffID.ForeColor = System.Drawing.Color.Blue
        Me.lblStaffID.Location = New System.Drawing.Point(67, 193)
        Me.lblStaffID.Name = "lblStaffID"
        Me.lblStaffID.Size = New System.Drawing.Size(49, 14)
        Me.lblStaffID.TabIndex = 187
        Me.lblStaffID.Text = "Staff ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(66, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 16)
        Me.Label3.TabIndex = 190
        Me.Label3.Text = "User ID"
        '
        'frmCreateUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 483)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.toolStrip1)
        Me.Controls.Add(Me.txtAttempt)
        Me.Controls.Add(Me.txtStaffID)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CboProfile)
        Me.Controls.Add(Me.lblPWD)
        Me.Controls.Add(Me.TxtPWD)
        Me.Controls.Add(Me.txtLoginName)
        Me.Controls.Add(Me.TxtUsername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtUserID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtmatdate)
        Me.Controls.Add(Me.lblMisExpireDate)
        Me.Controls.Add(Me.lblMisStartDate)
        Me.Controls.Add(Me.DTStartDate)
        Me.Controls.Add(Me.DTExpireDate)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtExpireDate)
        Me.Controls.Add(Me.txtStartDate)
        Me.Controls.Add(Me.gdUsers)
        Me.Controls.Add(Me.txtNextChangeDate)
        Me.Controls.Add(Me.lblNextChangedDate)
        Me.Controls.Add(Me.DTNextChangeDate)
        Me.Controls.Add(Me.lblStaffID)
        Me.Name = "frmCreateUsers"
        Me.Text = "frmCreateUsers"
        Me.toolStrip1.ResumeLayout(False)
        Me.toolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.gdUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents toolStrip1 As System.Windows.Forms.ToolStrip
    Private WithEvents btn_Add As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents btn_Edit As System.Windows.Forms.ToolStripButton
    Private WithEvents side2 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents btn_Delete As System.Windows.Forms.ToolStripButton
    Private WithEvents side3 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents btn_close As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtAttempt As System.Windows.Forms.TextBox
    Friend WithEvents DTLastSignDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtLocked As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DTBookingDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtInputer As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtStaffID As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtLastSignDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblBookingDate As System.Windows.Forms.Label
    Friend WithEvents lblLastSingDate As System.Windows.Forms.Label
    Friend WithEvents txtBookingDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ChkActive As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CboProfile As System.Windows.Forms.ComboBox
    Friend WithEvents lblPWD As System.Windows.Forms.Label
    Friend WithEvents TxtPWD As System.Windows.Forms.TextBox
    Friend WithEvents txtLoginName As System.Windows.Forms.TextBox
    Friend WithEvents TxtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtmatdate As System.Windows.Forms.Label
    Friend WithEvents lblMisExpireDate As System.Windows.Forms.Label
    Friend WithEvents lblMisStartDate As System.Windows.Forms.Label
    Friend WithEvents DTStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTExpireDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtExpireDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtStartDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents gdUsers As System.Windows.Forms.DataGridView
    Friend WithEvents txtNextChangeDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblNextChangedDate As System.Windows.Forms.Label
    Friend WithEvents DTNextChangeDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblStaffID As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
