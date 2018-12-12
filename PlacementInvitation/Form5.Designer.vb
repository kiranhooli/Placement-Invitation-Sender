<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Silver
        Me.Button2.Font = New System.Drawing.Font("Book Antiqua", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(171, 339)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(123, 44)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Send"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Silver
        Me.Button1.Font = New System.Drawing.Font("Book Antiqua", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(384, 339)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 44)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(210, 153)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 64)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Send Invitation to" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Eligible Students"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Firebrick
        Me.Label5.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(375, 459)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 18)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Kiran Hooli"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Firebrick
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(375, 437)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(214, 16)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Designed and Developed by:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Firebrick
        Me.PictureBox1.Location = New System.Drawing.Point(0, 428)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(663, 58)
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(663, 486)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "Form5"
        Me.Text = "Eligibility"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
