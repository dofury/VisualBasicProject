<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.Image = New System.Windows.Forms.PictureBox()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.startButton = New System.Windows.Forms.Button()
        Me.stopButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Image
        '
        Me.Image.Image = Global.문제3.My.Resources.Resources.cat
        Me.Image.Location = New System.Drawing.Point(20, 25)
        Me.Image.Name = "Image"
        Me.Image.Size = New System.Drawing.Size(200, 200)
        Me.Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Image.TabIndex = 0
        Me.Image.TabStop = False
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Location = New System.Drawing.Point(406, 312)
        Me.HScrollBar1.Maximum = 50
        Me.HScrollBar1.Minimum = 1
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(350, 49)
        Me.HScrollBar1.TabIndex = 1
        Me.HScrollBar1.Value = 1
        '
        'startButton
        '
        Me.startButton.Font = New System.Drawing.Font("맑은 고딕", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.startButton.Location = New System.Drawing.Point(643, 379)
        Me.startButton.Name = "startButton"
        Me.startButton.Size = New System.Drawing.Size(113, 59)
        Me.startButton.TabIndex = 2
        Me.startButton.Text = "Start"
        Me.startButton.UseVisualStyleBackColor = True
        '
        'stopButton
        '
        Me.stopButton.Font = New System.Drawing.Font("맑은 고딕", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.stopButton.Location = New System.Drawing.Point(643, 379)
        Me.stopButton.Name = "stopButton"
        Me.stopButton.Size = New System.Drawing.Size(119, 59)
        Me.stopButton.TabIndex = 3
        Me.stopButton.Text = "Stop"
        Me.stopButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("맑은 고딕", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(333, 321)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 30)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "속도"
        '
        'Timer1
        '
        Me.Timer1.Interval = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.stopButton)
        Me.Controls.Add(Me.startButton)
        Me.Controls.Add(Me.HScrollBar1)
        Me.Controls.Add(Me.Image)
        Me.Name = "Form1"
        Me.Text = "이미지 애니메이션"
        CType(Me.Image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Image As PictureBox
    Friend WithEvents HScrollBar1 As HScrollBar
    Friend WithEvents startButton As Button
    Friend WithEvents stopButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
End Class
