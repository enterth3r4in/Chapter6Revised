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
        Me.btnAsk = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.userPrompt = New System.Windows.Forms.Label()
        Me.questionInput = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAsk
        '
        Me.btnAsk.Location = New System.Drawing.Point(89, 347)
        Me.btnAsk.Name = "btnAsk"
        Me.btnAsk.Size = New System.Drawing.Size(100, 23)
        Me.btnAsk.TabIndex = 1
        Me.btnAsk.Text = "Ask Question"
        Me.btnAsk.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(245, 347)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.TabStop = False
        Me.btnExit.Text = "Exit Program"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'userPrompt
        '
        Me.userPrompt.AutoSize = True
        Me.userPrompt.Location = New System.Drawing.Point(88, 285)
        Me.userPrompt.Name = "userPrompt"
        Me.userPrompt.Size = New System.Drawing.Size(255, 13)
        Me.userPrompt.TabIndex = 3
        Me.userPrompt.Text = "Enter your question for the magic, mystical Eight Ball!"
        Me.userPrompt.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'questionInput
        '
        Me.questionInput.Location = New System.Drawing.Point(89, 301)
        Me.questionInput.Name = "questionInput"
        Me.questionInput.Size = New System.Drawing.Size(256, 20)
        Me.questionInput.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(91, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(256, 256)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 382)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.questionInput)
        Me.Controls.Add(Me.userPrompt)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAsk)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Magic Eight Ball"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAsk As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents userPrompt As System.Windows.Forms.Label
    Friend WithEvents questionInput As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
