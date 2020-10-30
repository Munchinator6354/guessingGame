<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGuessingGame
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.grpColorGame = New System.Windows.Forms.GroupBox()
        Me.picColor1 = New System.Windows.Forms.PictureBox()
        Me.picColor2 = New System.Windows.Forms.PictureBox()
        Me.picColor3 = New System.Windows.Forms.PictureBox()
        Me.picColor4 = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblColorInstructions = New System.Windows.Forms.Label()
        Me.grpColorGame.SuspendLayout()
        CType(Me.picColor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picColor2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picColor3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picColor4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 51)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Programmer: Ryan Isaacson" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CS115 - Fall 2020" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Lab#2 Guessing Game"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(185, 3)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(129, 17)
        Me.LinkLabel1.TabIndex = 1
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "(Here's my GitHub)"
        '
        'grpColorGame
        '
        Me.grpColorGame.Controls.Add(Me.lblColorInstructions)
        Me.grpColorGame.Controls.Add(Me.picColor4)
        Me.grpColorGame.Controls.Add(Me.picColor3)
        Me.grpColorGame.Controls.Add(Me.picColor2)
        Me.grpColorGame.Controls.Add(Me.picColor1)
        Me.grpColorGame.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpColorGame.Location = New System.Drawing.Point(96, 100)
        Me.grpColorGame.Name = "grpColorGame"
        Me.grpColorGame.Size = New System.Drawing.Size(560, 145)
        Me.grpColorGame.TabIndex = 2
        Me.grpColorGame.TabStop = False
        Me.grpColorGame.UseCompatibleTextRendering = True
        '
        'picColor1
        '
        Me.picColor1.BackColor = System.Drawing.Color.Red
        Me.picColor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picColor1.Location = New System.Drawing.Point(36, 61)
        Me.picColor1.Name = "picColor1"
        Me.picColor1.Size = New System.Drawing.Size(106, 65)
        Me.picColor1.TabIndex = 0
        Me.picColor1.TabStop = False
        '
        'picColor2
        '
        Me.picColor2.BackColor = System.Drawing.Color.Blue
        Me.picColor2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picColor2.Location = New System.Drawing.Point(161, 61)
        Me.picColor2.Name = "picColor2"
        Me.picColor2.Size = New System.Drawing.Size(106, 65)
        Me.picColor2.TabIndex = 1
        Me.picColor2.TabStop = False
        '
        'picColor3
        '
        Me.picColor3.BackColor = System.Drawing.Color.Green
        Me.picColor3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picColor3.Location = New System.Drawing.Point(287, 61)
        Me.picColor3.Name = "picColor3"
        Me.picColor3.Size = New System.Drawing.Size(106, 65)
        Me.picColor3.TabIndex = 2
        Me.picColor3.TabStop = False
        '
        'picColor4
        '
        Me.picColor4.BackColor = System.Drawing.Color.Yellow
        Me.picColor4.Location = New System.Drawing.Point(412, 61)
        Me.picColor4.Name = "picColor4"
        Me.picColor4.Size = New System.Drawing.Size(106, 65)
        Me.picColor4.TabIndex = 3
        Me.picColor4.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(250, 49)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(262, 39)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "Guessing Game"
        '
        'lblColorInstructions
        '
        Me.lblColorInstructions.AutoSize = True
        Me.lblColorInstructions.Location = New System.Drawing.Point(69, 23)
        Me.lblColorInstructions.Name = "lblColorInstructions"
        Me.lblColorInstructions.Size = New System.Drawing.Size(402, 20)
        Me.lblColorInstructions.TabIndex = 4
        Me.lblColorInstructions.Text = "Only 1 color will lead to the number guessing game..."
        '
        'frmGuessingGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.grpColorGame)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmGuessingGame"
        Me.Text = "Guessing Game"
        Me.grpColorGame.ResumeLayout(False)
        Me.grpColorGame.PerformLayout()
        CType(Me.picColor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picColor2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picColor3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picColor4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents grpColorGame As GroupBox
    Friend WithEvents picColor4 As PictureBox
    Friend WithEvents picColor3 As PictureBox
    Friend WithEvents picColor2 As PictureBox
    Friend WithEvents picColor1 As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblColorInstructions As Label
End Class
