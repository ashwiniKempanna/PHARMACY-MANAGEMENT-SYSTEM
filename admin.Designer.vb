<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbluser = New System.Windows.Forms.Label
        Me.lblpwd = New System.Windows.Forms.Label
        Me.btlogin = New System.Windows.Forms.Button
        Me.btcancel = New System.Windows.Forms.Button
        Me.txtuser = New System.Windows.Forms.TextBox
        Me.txtpwd = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(177, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LOGIN "
        '
        'lbluser
        '
        Me.lbluser.AutoSize = True
        Me.lbluser.BackColor = System.Drawing.Color.Transparent
        Me.lbluser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbluser.Location = New System.Drawing.Point(130, 186)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(97, 16)
        Me.lbluser.TabIndex = 2
        Me.lbluser.Text = "USER NAME"
        '
        'lblpwd
        '
        Me.lblpwd.AutoSize = True
        Me.lblpwd.BackColor = System.Drawing.Color.Transparent
        Me.lblpwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpwd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblpwd.Location = New System.Drawing.Point(132, 242)
        Me.lblpwd.Name = "lblpwd"
        Me.lblpwd.Size = New System.Drawing.Size(95, 16)
        Me.lblpwd.TabIndex = 3
        Me.lblpwd.Text = "PASSWORD"
        '
        'btlogin
        '
        Me.btlogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btlogin.Location = New System.Drawing.Point(161, 312)
        Me.btlogin.Name = "btlogin"
        Me.btlogin.Size = New System.Drawing.Size(75, 23)
        Me.btlogin.TabIndex = 4
        Me.btlogin.Text = "LOGIN"
        Me.btlogin.UseVisualStyleBackColor = True
        '
        'btcancel
        '
        Me.btcancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btcancel.Location = New System.Drawing.Point(286, 312)
        Me.btcancel.Name = "btcancel"
        Me.btcancel.Size = New System.Drawing.Size(75, 23)
        Me.btcancel.TabIndex = 5
        Me.btcancel.Text = "CANCEL"
        Me.btcancel.UseVisualStyleBackColor = True
        '
        'txtuser
        '
        Me.txtuser.Location = New System.Drawing.Point(271, 185)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(158, 20)
        Me.txtuser.TabIndex = 6
        '
        'txtpwd
        '
        Me.txtpwd.Location = New System.Drawing.Point(271, 242)
        Me.txtpwd.Name = "txtpwd"
        Me.txtpwd.Size = New System.Drawing.Size(158, 20)
        Me.txtpwd.TabIndex = 7
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(464, 378)
        Me.Controls.Add(Me.txtpwd)
        Me.Controls.Add(Me.txtuser)
        Me.Controls.Add(Me.btcancel)
        Me.Controls.Add(Me.btlogin)
        Me.Controls.Add(Me.lblpwd)
        Me.Controls.Add(Me.lbluser)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbluser As System.Windows.Forms.Label
    Friend WithEvents lblpwd As System.Windows.Forms.Label
    Friend WithEvents btlogin As System.Windows.Forms.Button
    Friend WithEvents btcancel As System.Windows.Forms.Button
    Friend WithEvents txtuser As System.Windows.Forms.TextBox
    Friend WithEvents txtpwd As System.Windows.Forms.TextBox
End Class
