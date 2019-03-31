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
        Me.cmbDD = New System.Windows.Forms.ComboBox
        Me.cmbMM = New System.Windows.Forms.ComboBox
        Me.cmbYY = New System.Windows.Forms.ComboBox
        Me.lblDay = New System.Windows.Forms.Label
        Me.lblYear = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnShow = New System.Windows.Forms.Button
        Me.btnReset = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cmbDD
        '
        Me.cmbDD.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDD.FormattingEnabled = True
        Me.cmbDD.Items.AddRange(New Object() {"Date"})
        Me.cmbDD.Location = New System.Drawing.Point(141, 88)
        Me.cmbDD.Name = "cmbDD"
        Me.cmbDD.Size = New System.Drawing.Size(63, 25)
        Me.cmbDD.TabIndex = 0
        Me.cmbDD.Text = "Date"
        '
        'cmbMM
        '
        Me.cmbMM.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMM.FormattingEnabled = True
        Me.cmbMM.Items.AddRange(New Object() {"Month"})
        Me.cmbMM.Location = New System.Drawing.Point(141, 119)
        Me.cmbMM.Name = "cmbMM"
        Me.cmbMM.Size = New System.Drawing.Size(63, 25)
        Me.cmbMM.TabIndex = 1
        Me.cmbMM.Text = "Month"
        '
        'cmbYY
        '
        Me.cmbYY.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbYY.FormattingEnabled = True
        Me.cmbYY.Items.AddRange(New Object() {"Year"})
        Me.cmbYY.Location = New System.Drawing.Point(141, 150)
        Me.cmbYY.Name = "cmbYY"
        Me.cmbYY.Size = New System.Drawing.Size(75, 25)
        Me.cmbYY.TabIndex = 2
        Me.cmbYY.Text = "Year"
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDay.Location = New System.Drawing.Point(52, 91)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(39, 17)
        Me.lblDay.TabIndex = 3
        Me.lblDay.Text = "Date"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.Location = New System.Drawing.Point(52, 119)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(52, 17)
        Me.lblYear.TabIndex = 4
        Me.lblYear.Text = "Month"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(53, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Year"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(236, 21)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Date Formate at run time entry"
        '
        'btnShow
        '
        Me.btnShow.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.Location = New System.Drawing.Point(148, 181)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(68, 23)
        Me.btnShow.TabIndex = 7
        Me.btnShow.Text = "Show Date"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(222, 181)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(68, 23)
        Me.btnReset.TabIndex = 8
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 210)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.cmbYY)
        Me.Controls.Add(Me.cmbMM)
        Me.Controls.Add(Me.cmbDD)
        Me.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "Form1"
        Me.Text = "Date formate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbDD As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMM As System.Windows.Forms.ComboBox
    Friend WithEvents cmbYY As System.Windows.Forms.ComboBox
    Friend WithEvents lblDay As System.Windows.Forms.Label
    Friend WithEvents lblYear As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button

End Class
