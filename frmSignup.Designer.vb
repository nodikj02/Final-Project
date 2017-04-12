<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSignup
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
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.txtvpass = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtfname
        '
        Me.txtfname.Location = New System.Drawing.Point(157, 26)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(100, 22)
        Me.txtfname.TabIndex = 0
        '
        'txtlname
        '
        Me.txtlname.Location = New System.Drawing.Point(157, 74)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(100, 22)
        Me.txtlname.TabIndex = 1
        '
        'txtuser
        '
        Me.txtuser.Location = New System.Drawing.Point(157, 128)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(100, 22)
        Me.txtuser.TabIndex = 2
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(157, 177)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(100, 22)
        Me.txtpass.TabIndex = 3
        '
        'txtvpass
        '
        Me.txtvpass.Location = New System.Drawing.Point(157, 224)
        Me.txtvpass.Name = "txtvpass"
        Me.txtvpass.Size = New System.Drawing.Size(100, 22)
        Me.txtvpass.TabIndex = 4
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(157, 272)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(100, 22)
        Me.txtemail.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "first name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "last name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(59, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "username:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(59, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "password:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "verify password:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(86, 272)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "email:"
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(114, 314)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(143, 23)
        Me.btnCreate.TabIndex = 12
        Me.btnCreate.Text = "Create Account"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'frmSignup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 359)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txtvpass)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtuser)
        Me.Controls.Add(Me.txtlname)
        Me.Controls.Add(Me.txtfname)
        Me.Name = "frmSignup"
        Me.Text = "frmSignup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtfname As TextBox
    Friend WithEvents txtlname As TextBox
    Friend WithEvents txtuser As TextBox
    Friend WithEvents txtpass As TextBox
    Friend WithEvents txtvpass As TextBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCreate As Button
End Class
