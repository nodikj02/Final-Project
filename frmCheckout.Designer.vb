<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheckout
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCardNumber = New System.Windows.Forms.TextBox()
        Me.lstOrderSummary = New System.Windows.Forms.ListBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboMonth = New System.Windows.Forms.ComboBox()
        Me.cboDay = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnPurchase = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblTotal)
        Me.GroupBox1.Controls.Add(Me.lstOrderSummary)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(346, 129)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Order Summary"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cboDay)
        Me.GroupBox2.Controls.Add(Me.cboMonth)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtCardNumber)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 148)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(346, 151)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Payment Method"
        '
        'txtCardNumber
        '
        Me.txtCardNumber.Location = New System.Drawing.Point(6, 56)
        Me.txtCardNumber.Name = "txtCardNumber"
        Me.txtCardNumber.Size = New System.Drawing.Size(181, 22)
        Me.txtCardNumber.TabIndex = 0
        '
        'lstOrderSummary
        '
        Me.lstOrderSummary.FormattingEnabled = True
        Me.lstOrderSummary.ItemHeight = 16
        Me.lstOrderSummary.Location = New System.Drawing.Point(6, 21)
        Me.lstOrderSummary.Name = "lstOrderSummary"
        Me.lstOrderSummary.Size = New System.Drawing.Size(181, 100)
        Me.lstOrderSummary.TabIndex = 0
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(193, 21)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(132, 17)
        Me.lblTotal.TabIndex = 1
        Me.lblTotal.Text = "Your Total Is: $0.00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Card Number"
        '
        'cboMonth
        '
        Me.cboMonth.FormattingEnabled = True
        Me.cboMonth.Location = New System.Drawing.Point(6, 108)
        Me.cboMonth.Name = "cboMonth"
        Me.cboMonth.Size = New System.Drawing.Size(92, 24)
        Me.cboMonth.TabIndex = 3
        Me.cboMonth.Text = "Month"
        '
        'cboDay
        '
        Me.cboDay.FormattingEnabled = True
        Me.cboDay.Location = New System.Drawing.Point(104, 108)
        Me.cboDay.Name = "cboDay"
        Me.cboDay.Size = New System.Drawing.Size(92, 24)
        Me.cboDay.TabIndex = 4
        Me.cboDay.Text = "Day"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Expiration"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(230, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "CVV"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(233, 108)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(63, 22)
        Me.TextBox1.TabIndex = 6
        '
        'btnPurchase
        '
        Me.btnPurchase.Location = New System.Drawing.Point(76, 305)
        Me.btnPurchase.Name = "btnPurchase"
        Me.btnPurchase.Size = New System.Drawing.Size(202, 23)
        Me.btnPurchase.TabIndex = 2
        Me.btnPurchase.Text = "Confirm Purchase"
        Me.btnPurchase.UseVisualStyleBackColor = True
        '
        'frmCheckout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 332)
        Me.Controls.Add(Me.btnPurchase)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmCheckout"
        Me.Text = "Checkout"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents lstOrderSummary As ListBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtCardNumber As TextBox
    Friend WithEvents cboDay As ComboBox
    Friend WithEvents cboMonth As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnPurchase As Button
End Class
