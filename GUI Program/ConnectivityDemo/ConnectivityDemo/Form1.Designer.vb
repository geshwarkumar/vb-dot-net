Partial Public Class frm_Registration
    Inherits DevExpress.XtraEditors.XtraForm

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim MsSqlConnectionParameters6 As DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters = New DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters()
        Dim CustomSqlQuery6 As DevExpress.DataAccess.Sql.CustomSqlQuery = New DevExpress.DataAccess.Sql.CustomSqlQuery()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Registration))
        Me.lbl_Registration = New DevExpress.XtraEditors.LabelControl()
        Me.pnl_UserInfo = New DevExpress.XtraEditors.PanelControl()
        Me.lblUserInfoID = New DevExpress.XtraEditors.LabelControl()
        Me.txt_ConPassword = New DevExpress.XtraEditors.TextEdit()
        Me.txtPassword = New DevExpress.XtraEditors.TextEdit()
        Me.txt_Contact = New DevExpress.XtraEditors.TextEdit()
        Me.txt_EmailID = New DevExpress.XtraEditors.TextEdit()
        Me.txt_Fullname = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_ConPassword = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Password = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Contact = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_EmailID = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Fullname = New DevExpress.XtraEditors.LabelControl()
        Me.pnl_Action = New DevExpress.XtraEditors.PanelControl()
        Me.btn_Edit = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Export = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Clear = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_View = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Update = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Save = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.grd_View = New DevExpress.XtraGrid.GridControl()
        Me.TblUserInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_ConnectivityDemoDataSet = New ConnectivityDemo.db_ConnectivityDemoDataSet()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUserInfoID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFullname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmailID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContact = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPassword = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.Tbl_UserInfoTableAdapter = New ConnectivityDemo.db_ConnectivityDemoDataSetTableAdapters.tbl_UserInfoTableAdapter()
        CType(Me.pnl_UserInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_UserInfo.SuspendLayout()
        CType(Me.txt_ConPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Contact.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_EmailID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Fullname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnl_Action, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_Action.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.grd_View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblUserInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_ConnectivityDemoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Registration
        '
        Me.lbl_Registration.Appearance.Font = New System.Drawing.Font("Bell MT", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_Registration.Appearance.ForeColor = System.Drawing.Color.Teal
        Me.lbl_Registration.Appearance.Options.UseFont = True
        Me.lbl_Registration.Appearance.Options.UseForeColor = True
        Me.lbl_Registration.Location = New System.Drawing.Point(15, 14)
        Me.lbl_Registration.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.lbl_Registration.Name = "lbl_Registration"
        Me.lbl_Registration.Size = New System.Drawing.Size(172, 31)
        Me.lbl_Registration.TabIndex = 0
        Me.lbl_Registration.Text = "Add New User"
        '
        'pnl_UserInfo
        '
        Me.pnl_UserInfo.Appearance.BackColor = System.Drawing.Color.White
        Me.pnl_UserInfo.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnl_UserInfo.Appearance.BorderColor = System.Drawing.Color.Navy
        Me.pnl_UserInfo.Appearance.Options.UseBackColor = True
        Me.pnl_UserInfo.Appearance.Options.UseBorderColor = True
        Me.pnl_UserInfo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnl_UserInfo.Controls.Add(Me.lblUserInfoID)
        Me.pnl_UserInfo.Controls.Add(Me.txt_ConPassword)
        Me.pnl_UserInfo.Controls.Add(Me.txtPassword)
        Me.pnl_UserInfo.Controls.Add(Me.txt_Contact)
        Me.pnl_UserInfo.Controls.Add(Me.txt_EmailID)
        Me.pnl_UserInfo.Controls.Add(Me.txt_Fullname)
        Me.pnl_UserInfo.Controls.Add(Me.lbl_ConPassword)
        Me.pnl_UserInfo.Controls.Add(Me.lbl_Password)
        Me.pnl_UserInfo.Controls.Add(Me.lbl_Contact)
        Me.pnl_UserInfo.Controls.Add(Me.lbl_EmailID)
        Me.pnl_UserInfo.Controls.Add(Me.lbl_Fullname)
        Me.pnl_UserInfo.Location = New System.Drawing.Point(12, 53)
        Me.pnl_UserInfo.Name = "pnl_UserInfo"
        Me.pnl_UserInfo.Size = New System.Drawing.Size(471, 189)
        Me.pnl_UserInfo.TabIndex = 1
        Me.pnl_UserInfo.Tag = "tbl_UserInfo"
        '
        'lblUserInfoID
        '
        Me.lblUserInfoID.Appearance.Font = New System.Drawing.Font("Bell MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserInfoID.Appearance.ForeColor = System.Drawing.Color.Purple
        Me.lblUserInfoID.Appearance.Options.UseFont = True
        Me.lblUserInfoID.Appearance.Options.UseForeColor = True
        Me.lblUserInfoID.Location = New System.Drawing.Point(3, 3)
        Me.lblUserInfoID.Name = "lblUserInfoID"
        Me.lblUserInfoID.Size = New System.Drawing.Size(90, 22)
        Me.lblUserInfoID.TabIndex = 10
        Me.lblUserInfoID.Tag = "UserInfoID"
        Me.lblUserInfoID.Text = "UserInfoID"
        Me.lblUserInfoID.Visible = False
        '
        'txt_ConPassword
        '
        Me.txt_ConPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_ConPassword.Location = New System.Drawing.Point(199, 142)
        Me.txt_ConPassword.Name = "txt_ConPassword"
        Me.txt_ConPassword.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_ConPassword.Properties.Appearance.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ConPassword.Properties.Appearance.ForeColor = System.Drawing.Color.Purple
        Me.txt_ConPassword.Properties.Appearance.Options.UseBackColor = True
        Me.txt_ConPassword.Properties.Appearance.Options.UseFont = True
        Me.txt_ConPassword.Properties.Appearance.Options.UseForeColor = True
        Me.txt_ConPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txt_ConPassword.Properties.MaxLength = 10
        Me.txt_ConPassword.Properties.NullValuePrompt = "Confirm Password"
        Me.txt_ConPassword.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_ConPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_ConPassword.Size = New System.Drawing.Size(160, 26)
        Me.txt_ConPassword.TabIndex = 9
        Me.txt_ConPassword.ToolTip = "Re-Enter your password."
        '
        'txtPassword
        '
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.Location = New System.Drawing.Point(199, 112)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPassword.Properties.Appearance.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Properties.Appearance.ForeColor = System.Drawing.Color.Purple
        Me.txtPassword.Properties.Appearance.Options.UseBackColor = True
        Me.txtPassword.Properties.Appearance.Options.UseFont = True
        Me.txtPassword.Properties.Appearance.Options.UseForeColor = True
        Me.txtPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtPassword.Properties.MaxLength = 10
        Me.txtPassword.Properties.NullValuePrompt = "Password"
        Me.txtPassword.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(160, 26)
        Me.txtPassword.TabIndex = 8
        Me.txtPassword.Tag = "Password"
        Me.txtPassword.ToolTip = "Enter password here."
        '
        'txt_Contact
        '
        Me.txt_Contact.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_Contact.Location = New System.Drawing.Point(199, 82)
        Me.txt_Contact.Name = "txt_Contact"
        Me.txt_Contact.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_Contact.Properties.Appearance.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Contact.Properties.Appearance.ForeColor = System.Drawing.Color.Purple
        Me.txt_Contact.Properties.Appearance.Options.UseBackColor = True
        Me.txt_Contact.Properties.Appearance.Options.UseFont = True
        Me.txt_Contact.Properties.Appearance.Options.UseForeColor = True
        Me.txt_Contact.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txt_Contact.Properties.Mask.BeepOnError = True
        Me.txt_Contact.Properties.Mask.EditMask = "\d\d\d\d\d \d\d\d\d\d"
        Me.txt_Contact.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular
        Me.txt_Contact.Properties.NullValuePrompt = "eg: 12345 67890"
        Me.txt_Contact.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_Contact.Size = New System.Drawing.Size(160, 26)
        Me.txt_Contact.TabIndex = 7
        Me.txt_Contact.Tag = "Contact"
        Me.txt_Contact.ToolTip = "Enter your contact no eg: 1234567890"
        '
        'txt_EmailID
        '
        Me.txt_EmailID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_EmailID.Location = New System.Drawing.Point(199, 52)
        Me.txt_EmailID.Name = "txt_EmailID"
        Me.txt_EmailID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_EmailID.Properties.Appearance.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_EmailID.Properties.Appearance.ForeColor = System.Drawing.Color.Purple
        Me.txt_EmailID.Properties.Appearance.Options.UseBackColor = True
        Me.txt_EmailID.Properties.Appearance.Options.UseFont = True
        Me.txt_EmailID.Properties.Appearance.Options.UseForeColor = True
        Me.txt_EmailID.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txt_EmailID.Properties.NullValuePrompt = "eg: sample@sample.sample"
        Me.txt_EmailID.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_EmailID.Size = New System.Drawing.Size(196, 26)
        Me.txt_EmailID.TabIndex = 6
        Me.txt_EmailID.Tag = "EmailID"
        Me.txt_EmailID.ToolTip = "Enter your email id eg: sample@sample.sample"
        '
        'txt_Fullname
        '
        Me.txt_Fullname.AllowDrop = True
        Me.txt_Fullname.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[True]
        Me.txt_Fullname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_Fullname.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_Fullname.Location = New System.Drawing.Point(199, 22)
        Me.txt_Fullname.Name = "txt_Fullname"
        Me.txt_Fullname.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_Fullname.Properties.Appearance.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Fullname.Properties.Appearance.ForeColor = System.Drawing.Color.Purple
        Me.txt_Fullname.Properties.Appearance.Options.UseBackColor = True
        Me.txt_Fullname.Properties.Appearance.Options.UseFont = True
        Me.txt_Fullname.Properties.Appearance.Options.UseForeColor = True
        Me.txt_Fullname.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txt_Fullname.Properties.NullValuePrompt = "eg: Sample Name"
        Me.txt_Fullname.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_Fullname.Size = New System.Drawing.Size(178, 26)
        Me.txt_Fullname.TabIndex = 5
        Me.txt_Fullname.Tag = "Fullname"
        Me.txt_Fullname.ToolTip = "Enter your full name eg: Smaple Name"
        '
        'lbl_ConPassword
        '
        Me.lbl_ConPassword.Appearance.Font = New System.Drawing.Font("Bell MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ConPassword.Appearance.ForeColor = System.Drawing.Color.Purple
        Me.lbl_ConPassword.Appearance.Options.UseFont = True
        Me.lbl_ConPassword.Appearance.Options.UseForeColor = True
        Me.lbl_ConPassword.Location = New System.Drawing.Point(45, 141)
        Me.lbl_ConPassword.Name = "lbl_ConPassword"
        Me.lbl_ConPassword.Size = New System.Drawing.Size(146, 22)
        Me.lbl_ConPassword.TabIndex = 4
        Me.lbl_ConPassword.Text = "Confirm Password"
        '
        'lbl_Password
        '
        Me.lbl_Password.Appearance.Font = New System.Drawing.Font("Bell MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Password.Appearance.ForeColor = System.Drawing.Color.Purple
        Me.lbl_Password.Appearance.Options.UseFont = True
        Me.lbl_Password.Appearance.Options.UseForeColor = True
        Me.lbl_Password.Location = New System.Drawing.Point(114, 111)
        Me.lbl_Password.Name = "lbl_Password"
        Me.lbl_Password.Size = New System.Drawing.Size(77, 22)
        Me.lbl_Password.TabIndex = 3
        Me.lbl_Password.Text = "Password"
        '
        'lbl_Contact
        '
        Me.lbl_Contact.Appearance.Font = New System.Drawing.Font("Bell MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Contact.Appearance.ForeColor = System.Drawing.Color.Purple
        Me.lbl_Contact.Appearance.Options.UseFont = True
        Me.lbl_Contact.Appearance.Options.UseForeColor = True
        Me.lbl_Contact.Location = New System.Drawing.Point(130, 81)
        Me.lbl_Contact.Name = "lbl_Contact"
        Me.lbl_Contact.Size = New System.Drawing.Size(61, 22)
        Me.lbl_Contact.TabIndex = 2
        Me.lbl_Contact.Text = "Contact"
        '
        'lbl_EmailID
        '
        Me.lbl_EmailID.Appearance.Font = New System.Drawing.Font("Bell MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_EmailID.Appearance.ForeColor = System.Drawing.Color.Purple
        Me.lbl_EmailID.Appearance.Options.UseFont = True
        Me.lbl_EmailID.Appearance.Options.UseForeColor = True
        Me.lbl_EmailID.Location = New System.Drawing.Point(120, 51)
        Me.lbl_EmailID.Name = "lbl_EmailID"
        Me.lbl_EmailID.Size = New System.Drawing.Size(71, 22)
        Me.lbl_EmailID.TabIndex = 1
        Me.lbl_EmailID.Text = "Email ID"
        '
        'lbl_Fullname
        '
        Me.lbl_Fullname.Appearance.Font = New System.Drawing.Font("Bell MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Fullname.Appearance.ForeColor = System.Drawing.Color.Purple
        Me.lbl_Fullname.Appearance.Options.UseFont = True
        Me.lbl_Fullname.Appearance.Options.UseForeColor = True
        Me.lbl_Fullname.Location = New System.Drawing.Point(109, 21)
        Me.lbl_Fullname.Name = "lbl_Fullname"
        Me.lbl_Fullname.Size = New System.Drawing.Size(82, 22)
        Me.lbl_Fullname.TabIndex = 0
        Me.lbl_Fullname.Text = "Full Name"
        '
        'pnl_Action
        '
        Me.pnl_Action.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnl_Action.Controls.Add(Me.btn_Edit)
        Me.pnl_Action.Controls.Add(Me.btn_Export)
        Me.pnl_Action.Controls.Add(Me.btn_Clear)
        Me.pnl_Action.Controls.Add(Me.btn_View)
        Me.pnl_Action.Controls.Add(Me.btn_Update)
        Me.pnl_Action.Controls.Add(Me.btn_Save)
        Me.pnl_Action.Location = New System.Drawing.Point(12, 248)
        Me.pnl_Action.Name = "pnl_Action"
        Me.pnl_Action.Size = New System.Drawing.Size(471, 33)
        Me.pnl_Action.TabIndex = 2
        '
        'btn_Edit
        '
        Me.btn_Edit.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Edit.Appearance.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Edit.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Edit.Appearance.Options.UseBorderColor = True
        Me.btn_Edit.Appearance.Options.UseFont = True
        Me.btn_Edit.Appearance.Options.UseForeColor = True
        Me.btn_Edit.Location = New System.Drawing.Point(410, 5)
        Me.btn_Edit.Name = "btn_Edit"
        Me.btn_Edit.Size = New System.Drawing.Size(56, 23)
        Me.btn_Edit.TabIndex = 5
        Me.btn_Edit.Text = "Edit"
        '
        'btn_Export
        '
        Me.btn_Export.Appearance.BorderColor = System.Drawing.Color.Lime
        Me.btn_Export.Appearance.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Export.Appearance.ForeColor = System.Drawing.Color.Teal
        Me.btn_Export.Appearance.Options.UseBorderColor = True
        Me.btn_Export.Appearance.Options.UseFont = True
        Me.btn_Export.Appearance.Options.UseForeColor = True
        Me.btn_Export.Location = New System.Drawing.Point(248, 5)
        Me.btn_Export.Name = "btn_Export"
        Me.btn_Export.Size = New System.Drawing.Size(75, 23)
        Me.btn_Export.TabIndex = 4
        Me.btn_Export.Text = "Export"
        '
        'btn_Clear
        '
        Me.btn_Clear.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Clear.Appearance.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Clear.Appearance.ForeColor = System.Drawing.Color.Red
        Me.btn_Clear.Appearance.Options.UseBorderColor = True
        Me.btn_Clear.Appearance.Options.UseFont = True
        Me.btn_Clear.Appearance.Options.UseForeColor = True
        Me.btn_Clear.Location = New System.Drawing.Point(329, 5)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(75, 23)
        Me.btn_Clear.TabIndex = 3
        Me.btn_Clear.Text = "Clear"
        '
        'btn_View
        '
        Me.btn_View.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_View.Appearance.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_View.Appearance.ForeColor = System.Drawing.Color.Teal
        Me.btn_View.Appearance.Options.UseBorderColor = True
        Me.btn_View.Appearance.Options.UseFont = True
        Me.btn_View.Appearance.Options.UseForeColor = True
        Me.btn_View.Location = New System.Drawing.Point(167, 5)
        Me.btn_View.Name = "btn_View"
        Me.btn_View.Size = New System.Drawing.Size(75, 23)
        Me.btn_View.TabIndex = 2
        Me.btn_View.Text = "View"
        '
        'btn_Update
        '
        Me.btn_Update.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Update.Appearance.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Update.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Update.Appearance.Options.UseBorderColor = True
        Me.btn_Update.Appearance.Options.UseFont = True
        Me.btn_Update.Appearance.Options.UseForeColor = True
        Me.btn_Update.Location = New System.Drawing.Point(86, 5)
        Me.btn_Update.Name = "btn_Update"
        Me.btn_Update.Size = New System.Drawing.Size(75, 23)
        Me.btn_Update.TabIndex = 1
        Me.btn_Update.Text = "Update"
        '
        'btn_Save
        '
        Me.btn_Save.Appearance.BorderColor = System.Drawing.Color.Lime
        Me.btn_Save.Appearance.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Save.Appearance.ForeColor = System.Drawing.Color.Green
        Me.btn_Save.Appearance.Options.UseBorderColor = True
        Me.btn_Save.Appearance.Options.UseFont = True
        Me.btn_Save.Appearance.Options.UseForeColor = True
        Me.btn_Save.Location = New System.Drawing.Point(5, 5)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(75, 23)
        Me.btn_Save.TabIndex = 0
        Me.btn_Save.Text = "Save"
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PanelControl1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.grd_View)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 287)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(471, 207)
        Me.PanelControl1.TabIndex = 4
        '
        'grd_View
        '
        Me.grd_View.DataSource = Me.TblUserInfoBindingSource
        Me.grd_View.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grd_View.Location = New System.Drawing.Point(0, 0)
        Me.grd_View.MainView = Me.GridView1
        Me.grd_View.Name = "grd_View"
        Me.grd_View.Size = New System.Drawing.Size(471, 207)
        Me.grd_View.TabIndex = 0
        Me.grd_View.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'TblUserInfoBindingSource
        '
        Me.TblUserInfoBindingSource.DataMember = "tbl_UserInfo"
        Me.TblUserInfoBindingSource.DataSource = Me.Db_ConnectivityDemoDataSet
        '
        'Db_ConnectivityDemoDataSet
        '
        Me.Db_ConnectivityDemoDataSet.DataSetName = "db_ConnectivityDemoDataSet"
        Me.Db_ConnectivityDemoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUserInfoID, Me.colFullname, Me.colEmailID, Me.colContact, Me.colPassword, Me.GridColumn1})
        Me.GridView1.GridControl = Me.grd_View
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colUserInfoID
        '
        Me.colUserInfoID.FieldName = "UserInfoID"
        Me.colUserInfoID.Name = "colUserInfoID"
        '
        'colFullname
        '
        Me.colFullname.FieldName = "Fullname"
        Me.colFullname.Name = "colFullname"
        '
        'colEmailID
        '
        Me.colEmailID.FieldName = "EmailID"
        Me.colEmailID.Name = "colEmailID"
        Me.colEmailID.Visible = True
        Me.colEmailID.VisibleIndex = 1
        '
        'colContact
        '
        Me.colContact.FieldName = "Contact"
        Me.colContact.Name = "colContact"
        Me.colContact.Visible = True
        Me.colContact.VisibleIndex = 2
        '
        'colPassword
        '
        Me.colPassword.FieldName = "Password"
        Me.colPassword.Name = "colPassword"
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "Fullname"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "localhost_db_ConnectivityDemo_Connection"
        MsSqlConnectionParameters6.AuthorizationType = DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.Windows
        MsSqlConnectionParameters6.DatabaseName = "db_ConnectivityDemo"
        MsSqlConnectionParameters6.ServerName = "(LocalDb)\MSSQLLocalDB"
        Me.SqlDataSource1.ConnectionParameters = MsSqlConnectionParameters6
        Me.SqlDataSource1.Name = "SqlDataSource1"
        CustomSqlQuery6.Name = "Query"
        CustomSqlQuery6.Sql = "SELECT [Fullname],[EmailID],[Contact] FROM [db_ConnectivityDemo].[dbo].[tbl_UserI" &
    "nfo]"
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {CustomSqlQuery6})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'Tbl_UserInfoTableAdapter
        '
        Me.Tbl_UserInfoTableAdapter.ClearBeforeFill = True
        '
        'frm_Registration
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Appearance.BorderColor = System.Drawing.Color.Lime
        Me.Appearance.ForeColor = System.Drawing.Color.Teal
        Me.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseBorderColor = True
        Me.Appearance.Options.UseFont = True
        Me.Appearance.Options.UseForeColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 504)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.pnl_Action)
        Me.Controls.Add(Me.pnl_UserInfo)
        Me.Controls.Add(Me.lbl_Registration)
        Me.Font = New System.Drawing.Font("Bell MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Registration"
        Me.Opacity = 0.9R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registration Form"
        CType(Me.pnl_UserInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_UserInfo.ResumeLayout(False)
        Me.pnl_UserInfo.PerformLayout()
        CType(Me.txt_ConPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Contact.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_EmailID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Fullname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnl_Action, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_Action.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.grd_View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblUserInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_ConnectivityDemoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Registration As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pnl_UserInfo As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txt_Fullname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_ConPassword As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Password As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Contact As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_EmailID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Fullname As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_ConPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_Contact As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_EmailID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents pnl_Action As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btn_Clear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_View As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Update As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Save As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents btn_Export As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Edit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Db_ConnectivityDemoDataSet As db_ConnectivityDemoDataSet
    Friend WithEvents TblUserInfoBindingSource As BindingSource
    Friend WithEvents Tbl_UserInfoTableAdapter As db_ConnectivityDemoDataSetTableAdapters.tbl_UserInfoTableAdapter
    Friend WithEvents grd_View As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colUserInfoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFullname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmailID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContact As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPassword As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblUserInfoID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn

#End Region

End Class
