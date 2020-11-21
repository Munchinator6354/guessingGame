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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGuessingGame))
        Me.lblID = New System.Windows.Forms.Label()
        Me.lnkGitHub = New System.Windows.Forms.LinkLabel()
        Me.grpColorGame = New System.Windows.Forms.GroupBox()
        Me.btnGreen = New System.Windows.Forms.Button()
        Me.btnYellow = New System.Windows.Forms.Button()
        Me.btnBlue = New System.Windows.Forms.Button()
        Me.btnRed = New System.Windows.Forms.Button()
        Me.lblColorInstructions = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblColorNumber = New System.Windows.Forms.Label()
        Me.lblNumberNumber = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpNumGuess = New System.Windows.Forms.GroupBox()
        Me.lblYourLastGuess = New System.Windows.Forms.Label()
        Me.btnGuess = New System.Windows.Forms.Button()
        Me.lblNumHintOutput = New System.Windows.Forms.Label()
        Me.txtNumGuess = New System.Windows.Forms.TextBox()
        Me.lblNumGameInstructions = New System.Windows.Forms.Label()
        Me.grpScores = New System.Windows.Forms.GroupBox()
        Me.btnProceed = New System.Windows.Forms.Button()
        Me.radNo = New System.Windows.Forms.RadioButton()
        Me.radYes = New System.Windows.Forms.RadioButton()
        Me.lblScores = New System.Windows.Forms.Label()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.lblColorCountLabel = New System.Windows.Forms.Label()
        Me.lblColorCount = New System.Windows.Forms.Label()
        Me.lblNumCountLabel = New System.Windows.Forms.Label()
        Me.lblNumCount = New System.Windows.Forms.Label()
        Me.lblTotalCountLabel = New System.Windows.Forms.Label()
        Me.lblTotalCount = New System.Windows.Forms.Label()
        Me.lblCheatCodes = New System.Windows.Forms.Label()
        Me.grpColorGame.SuspendLayout()
        Me.grpNumGuess.SuspendLayout()
        Me.grpScores.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(1, 3)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(187, 51)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "Programmer: Ryan Isaacson" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CS115 - Fall 2020" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Lab#2 Guessing Game"
        '
        'lnkGitHub
        '
        Me.lnkGitHub.AutoSize = True
        Me.lnkGitHub.Location = New System.Drawing.Point(185, 3)
        Me.lnkGitHub.Name = "lnkGitHub"
        Me.lnkGitHub.Size = New System.Drawing.Size(129, 17)
        Me.lnkGitHub.TabIndex = 1
        Me.lnkGitHub.TabStop = True
        Me.lnkGitHub.Text = "(Here's my GitHub)"
        '
        'grpColorGame
        '
        Me.grpColorGame.Controls.Add(Me.btnGreen)
        Me.grpColorGame.Controls.Add(Me.btnYellow)
        Me.grpColorGame.Controls.Add(Me.btnBlue)
        Me.grpColorGame.Controls.Add(Me.btnRed)
        Me.grpColorGame.Controls.Add(Me.lblColorInstructions)
        Me.grpColorGame.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpColorGame.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grpColorGame.Location = New System.Drawing.Point(106, 75)
        Me.grpColorGame.Name = "grpColorGame"
        Me.grpColorGame.Size = New System.Drawing.Size(554, 127)
        Me.grpColorGame.TabIndex = 6
        Me.grpColorGame.TabStop = False
        Me.grpColorGame.Text = "Color Guess Game"
        Me.grpColorGame.UseCompatibleTextRendering = True
        '
        'btnGreen
        '
        Me.btnGreen.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnGreen.Image = Global.guessingGame.My.Resources.Resources.Green
        Me.btnGreen.Location = New System.Drawing.Point(167, 46)
        Me.btnGreen.Name = "btnGreen"
        Me.btnGreen.Size = New System.Drawing.Size(104, 70)
        Me.btnGreen.TabIndex = 2
        Me.btnGreen.Text = "Green"
        Me.btnGreen.UseVisualStyleBackColor = True
        '
        'btnYellow
        '
        Me.btnYellow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnYellow.Image = Global.guessingGame.My.Resources.Resources.Yellow
        Me.btnYellow.Location = New System.Drawing.Point(387, 46)
        Me.btnYellow.Name = "btnYellow"
        Me.btnYellow.Size = New System.Drawing.Size(104, 70)
        Me.btnYellow.TabIndex = 4
        Me.btnYellow.Text = "Yellow"
        Me.btnYellow.UseVisualStyleBackColor = True
        '
        'btnBlue
        '
        Me.btnBlue.ForeColor = System.Drawing.SystemColors.Control
        Me.btnBlue.Image = Global.guessingGame.My.Resources.Resources.Blue
        Me.btnBlue.Location = New System.Drawing.Point(277, 46)
        Me.btnBlue.Name = "btnBlue"
        Me.btnBlue.Size = New System.Drawing.Size(104, 70)
        Me.btnBlue.TabIndex = 3
        Me.btnBlue.Text = "Blue"
        Me.btnBlue.UseVisualStyleBackColor = True
        '
        'btnRed
        '
        Me.btnRed.ForeColor = System.Drawing.SystemColors.Control
        Me.btnRed.Image = CType(resources.GetObject("btnRed.Image"), System.Drawing.Image)
        Me.btnRed.Location = New System.Drawing.Point(57, 46)
        Me.btnRed.Name = "btnRed"
        Me.btnRed.Size = New System.Drawing.Size(104, 70)
        Me.btnRed.TabIndex = 1
        Me.btnRed.Text = "Red"
        Me.btnRed.UseVisualStyleBackColor = True
        '
        'lblColorInstructions
        '
        Me.lblColorInstructions.AutoSize = True
        Me.lblColorInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColorInstructions.Location = New System.Drawing.Point(88, 23)
        Me.lblColorInstructions.Name = "lblColorInstructions"
        Me.lblColorInstructions.Size = New System.Drawing.Size(341, 17)
        Me.lblColorInstructions.TabIndex = 0
        Me.lblColorInstructions.Text = "Only 1 color will lead to the number guessing game..."
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(249, 33)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(254, 38)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Guessing Game"
        '
        'lblColorNumber
        '
        Me.lblColorNumber.AutoSize = True
        Me.lblColorNumber.Location = New System.Drawing.Point(657, 26)
        Me.lblColorNumber.Name = "lblColorNumber"
        Me.lblColorNumber.Size = New System.Drawing.Size(95, 17)
        Me.lblColorNumber.TabIndex = 4
        Me.lblColorNumber.Text = "Color Number"
        '
        'lblNumberNumber
        '
        Me.lblNumberNumber.AutoSize = True
        Me.lblNumberNumber.Location = New System.Drawing.Point(691, 26)
        Me.lblNumberNumber.Name = "lblNumberNumber"
        Me.lblNumberNumber.Size = New System.Drawing.Size(112, 17)
        Me.lblNumberNumber.TabIndex = 5
        Me.lblNumberNumber.Text = "Number Number"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(594, 381)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(149, 57)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "Exit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Program"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'grpNumGuess
        '
        Me.grpNumGuess.Controls.Add(Me.lblYourLastGuess)
        Me.grpNumGuess.Controls.Add(Me.btnGuess)
        Me.grpNumGuess.Controls.Add(Me.lblNumHintOutput)
        Me.grpNumGuess.Controls.Add(Me.txtNumGuess)
        Me.grpNumGuess.Controls.Add(Me.lblNumGameInstructions)
        Me.grpNumGuess.Location = New System.Drawing.Point(31, 208)
        Me.grpNumGuess.Name = "grpNumGuess"
        Me.grpNumGuess.Size = New System.Drawing.Size(360, 178)
        Me.grpNumGuess.TabIndex = 7
        Me.grpNumGuess.TabStop = False
        Me.grpNumGuess.Text = "Number Guess Game"
        '
        'lblYourLastGuess
        '
        Me.lblYourLastGuess.AutoSize = True
        Me.lblYourLastGuess.Location = New System.Drawing.Point(39, 117)
        Me.lblYourLastGuess.Name = "lblYourLastGuess"
        Me.lblYourLastGuess.Size = New System.Drawing.Size(118, 17)
        Me.lblYourLastGuess.TabIndex = 2
        Me.lblYourLastGuess.Text = "Your Last Guess:"
        '
        'btnGuess
        '
        Me.btnGuess.Location = New System.Drawing.Point(213, 130)
        Me.btnGuess.Name = "btnGuess"
        Me.btnGuess.Size = New System.Drawing.Size(96, 28)
        Me.btnGuess.TabIndex = 4
        Me.btnGuess.Text = "Guess!"
        Me.btnGuess.UseVisualStyleBackColor = True
        '
        'lblNumHintOutput
        '
        Me.lblNumHintOutput.AutoSize = True
        Me.lblNumHintOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumHintOutput.Location = New System.Drawing.Point(30, 144)
        Me.lblNumHintOutput.Name = "lblNumHintOutput"
        Me.lblNumHintOutput.Size = New System.Drawing.Size(0, 17)
        Me.lblNumHintOutput.TabIndex = 3
        '
        'txtNumGuess
        '
        Me.txtNumGuess.Location = New System.Drawing.Point(109, 88)
        Me.txtNumGuess.Name = "txtNumGuess"
        Me.txtNumGuess.Size = New System.Drawing.Size(114, 22)
        Me.txtNumGuess.TabIndex = 1
        '
        'lblNumGameInstructions
        '
        Me.lblNumGameInstructions.AutoSize = True
        Me.lblNumGameInstructions.Location = New System.Drawing.Point(54, 41)
        Me.lblNumGameInstructions.Name = "lblNumGameInstructions"
        Me.lblNumGameInstructions.Size = New System.Drawing.Size(229, 34)
        Me.lblNumGameInstructions.TabIndex = 0
        Me.lblNumGameInstructions.Text = "Can you guess the secret number?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Enter a number from 1-100"
        '
        'grpScores
        '
        Me.grpScores.Controls.Add(Me.btnProceed)
        Me.grpScores.Controls.Add(Me.radNo)
        Me.grpScores.Controls.Add(Me.radYes)
        Me.grpScores.Controls.Add(Me.lblScores)
        Me.grpScores.Location = New System.Drawing.Point(405, 208)
        Me.grpScores.Name = "grpScores"
        Me.grpScores.Size = New System.Drawing.Size(356, 167)
        Me.grpScores.TabIndex = 8
        Me.grpScores.TabStop = False
        Me.grpScores.Text = "Scores"
        '
        'btnProceed
        '
        Me.btnProceed.Location = New System.Drawing.Point(114, 138)
        Me.btnProceed.Name = "btnProceed"
        Me.btnProceed.Size = New System.Drawing.Size(78, 23)
        Me.btnProceed.TabIndex = 3
        Me.btnProceed.Text = "Proceed"
        Me.btnProceed.UseVisualStyleBackColor = True
        '
        'radNo
        '
        Me.radNo.AutoSize = True
        Me.radNo.Location = New System.Drawing.Point(170, 112)
        Me.radNo.Name = "radNo"
        Me.radNo.Size = New System.Drawing.Size(110, 21)
        Me.radNo.TabIndex = 2
        Me.radNo.TabStop = True
        Me.radNo.Text = "I guess not..."
        Me.radNo.UseVisualStyleBackColor = True
        '
        'radYes
        '
        Me.radYes.AutoSize = True
        Me.radYes.Location = New System.Drawing.Point(68, 113)
        Me.radYes.Name = "radYes"
        Me.radYes.Size = New System.Drawing.Size(96, 21)
        Me.radYes.TabIndex = 1
        Me.radYes.TabStop = True
        Me.radYes.Text = "I guess so!"
        Me.radYes.UseVisualStyleBackColor = True
        '
        'lblScores
        '
        Me.lblScores.AutoSize = True
        Me.lblScores.Location = New System.Drawing.Point(25, 25)
        Me.lblScores.Name = "lblScores"
        Me.lblScores.Size = New System.Drawing.Size(296, 85)
        Me.lblScores.TabIndex = 0
        Me.lblScores.Text = "Your number of INSERT is correct!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You guessed the color in INSERT guesses!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You " &
    "guessed the number in INSERT guesses!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Would you like to play again?"
        '
        'btnRestart
        '
        Me.btnRestart.Location = New System.Drawing.Point(425, 381)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(144, 57)
        Me.btnRestart.TabIndex = 15
        Me.btnRestart.Text = "Restart" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Program"
        Me.btnRestart.UseVisualStyleBackColor = True
        '
        'lblColorCountLabel
        '
        Me.lblColorCountLabel.AutoSize = True
        Me.lblColorCountLabel.Location = New System.Drawing.Point(1, 389)
        Me.lblColorCountLabel.Name = "lblColorCountLabel"
        Me.lblColorCountLabel.Size = New System.Drawing.Size(131, 17)
        Me.lblColorCountLabel.TabIndex = 9
        Me.lblColorCountLabel.Text = "Color Guess Count:"
        '
        'lblColorCount
        '
        Me.lblColorCount.AutoSize = True
        Me.lblColorCount.Location = New System.Drawing.Point(61, 413)
        Me.lblColorCount.Name = "lblColorCount"
        Me.lblColorCount.Size = New System.Drawing.Size(16, 17)
        Me.lblColorCount.TabIndex = 12
        Me.lblColorCount.Text = "0"
        '
        'lblNumCountLabel
        '
        Me.lblNumCountLabel.AutoSize = True
        Me.lblNumCountLabel.Location = New System.Drawing.Point(137, 389)
        Me.lblNumCountLabel.Name = "lblNumCountLabel"
        Me.lblNumCountLabel.Size = New System.Drawing.Size(148, 17)
        Me.lblNumCountLabel.TabIndex = 10
        Me.lblNumCountLabel.Text = "Number Guess Count:"
        '
        'lblNumCount
        '
        Me.lblNumCount.AutoSize = True
        Me.lblNumCount.Location = New System.Drawing.Point(194, 413)
        Me.lblNumCount.Name = "lblNumCount"
        Me.lblNumCount.Size = New System.Drawing.Size(16, 17)
        Me.lblNumCount.TabIndex = 13
        Me.lblNumCount.Text = "0"
        '
        'lblTotalCountLabel
        '
        Me.lblTotalCountLabel.AutoSize = True
        Me.lblTotalCountLabel.Location = New System.Drawing.Point(289, 389)
        Me.lblTotalCountLabel.Name = "lblTotalCountLabel"
        Me.lblTotalCountLabel.Size = New System.Drawing.Size(130, 17)
        Me.lblTotalCountLabel.TabIndex = 11
        Me.lblTotalCountLabel.Text = "Total Guess Count:"
        '
        'lblTotalCount
        '
        Me.lblTotalCount.AutoSize = True
        Me.lblTotalCount.BackColor = System.Drawing.SystemColors.Control
        Me.lblTotalCount.Location = New System.Drawing.Point(342, 413)
        Me.lblTotalCount.Name = "lblTotalCount"
        Me.lblTotalCount.Size = New System.Drawing.Size(16, 17)
        Me.lblTotalCount.TabIndex = 14
        Me.lblTotalCount.Text = "0"
        '
        'lblCheatCodes
        '
        Me.lblCheatCodes.AutoSize = True
        Me.lblCheatCodes.Location = New System.Drawing.Point(454, 26)
        Me.lblCheatCodes.Name = "lblCheatCodes"
        Me.lblCheatCodes.Size = New System.Drawing.Size(197, 17)
        Me.lblCheatCodes.TabIndex = 3
        Me.lblCheatCodes.Text = "Cheat Codes For Penny Here:"
        '
        'frmGuessingGame
        '
        Me.AcceptButton = Me.btnGuess
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblCheatCodes)
        Me.Controls.Add(Me.lblTotalCount)
        Me.Controls.Add(Me.lblTotalCountLabel)
        Me.Controls.Add(Me.lblNumCount)
        Me.Controls.Add(Me.lblNumCountLabel)
        Me.Controls.Add(Me.lblColorCount)
        Me.Controls.Add(Me.lblColorCountLabel)
        Me.Controls.Add(Me.btnRestart)
        Me.Controls.Add(Me.grpScores)
        Me.Controls.Add(Me.grpNumGuess)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblNumberNumber)
        Me.Controls.Add(Me.lblColorNumber)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.grpColorGame)
        Me.Controls.Add(Me.lnkGitHub)
        Me.Controls.Add(Me.lblID)
        Me.Name = "frmGuessingGame"
        Me.Text = "Guessing Game"
        Me.grpColorGame.ResumeLayout(False)
        Me.grpColorGame.PerformLayout()
        Me.grpNumGuess.ResumeLayout(False)
        Me.grpNumGuess.PerformLayout()
        Me.grpScores.ResumeLayout(False)
        Me.grpScores.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblID As Label
    Friend WithEvents lnkGitHub As LinkLabel
    Friend WithEvents grpColorGame As GroupBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblColorInstructions As Label
    Friend WithEvents btnGreen As Button
    Friend WithEvents btnYellow As Button
    Friend WithEvents btnBlue As Button
    Friend WithEvents btnRed As Button
    Friend WithEvents lblColorNumber As Label
    Friend WithEvents lblNumberNumber As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents grpNumGuess As GroupBox
    Friend WithEvents lblNumHintOutput As Label
    Friend WithEvents txtNumGuess As TextBox
    Friend WithEvents lblNumGameInstructions As Label
    Friend WithEvents btnGuess As Button
    Friend WithEvents grpScores As GroupBox
    Friend WithEvents lblScores As Label
    Friend WithEvents btnRestart As Button
    Friend WithEvents radNo As RadioButton
    Friend WithEvents radYes As RadioButton
    Friend WithEvents btnProceed As Button
    Friend WithEvents lblColorCountLabel As Label
    Friend WithEvents lblColorCount As Label
    Friend WithEvents lblNumCountLabel As Label
    Friend WithEvents lblNumCount As Label
    Friend WithEvents lblTotalCountLabel As Label
    Friend WithEvents lblTotalCount As Label
    Friend WithEvents lblYourLastGuess As Label
    Friend WithEvents lblCheatCodes As Label
End Class
