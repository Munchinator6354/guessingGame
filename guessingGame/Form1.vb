Option Explicit On
Option Strict On

'Program:       guessingGame
'               Lab 2 - Guessing Game
'Programmer:    Ryan Isaacson / Munchinator6354
'GitHub         https://github.com/munchinator6354
'Date           November 20, 2020
'Description    Program will have the user guess a prechosen secret color as well as a prechosen secret number. 
'               Each guess will count And the lower the score, the better. Try it out!

Public Class frmGuessingGame
    'Here we initialize our lovely variables
    Dim rand As New Random
    Dim intRandColor As Integer
    Dim intRandNum As Integer
    Dim intColorCount As Integer = 0
    Dim intNumCount As Integer = 0
    Dim intTotalCount As Integer
    Const intRed As Integer = 1
    Const intGreen As Integer = 2
    Const intBlue As Integer = 3
    Const intYellow As Integer = 4
    '-----------------------------------------------------------------------------------------------
    'Initialize Game
    '-----------------------------------------------------------------------------------------------
    'Subroutine:    frmGuessingGame_Load
    'Programmer:    Ryan Isaacson / Munchinator6354
    'Date:          November 20, 2020
    'Description    Initialized game when the form loads
    Private Sub frmGuessingGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Begin the Color Game
        Call InitializeGame()
    End Sub
    '-----------------------------------------------------------------------------------------------
    'Color Buttons
    '-----------------------------------------------------------------------------------------------
    'Subroutine:    btnRed_Click
    'Programmer:    Ryan Isaacson / Munchinator6354
    'Date:          November 20, 2020
    'Description    Handles the red button being clicked, increases count and determines if correct color.
    Private Sub btnRed_Click(sender As Object, e As EventArgs) Handles btnRed.Click
        'Increase Color Guessed Count
        intColorCount += 1
        'Update the Guessing Counts
        UpdateCountScores()
        'If Red's assigned number is the random color number, start the Number Guess Game
        If intRed = intRandColor Then
            StartNumberGuess()
        Else
            'Otherwise output a message box saying the user was wrong with their guess
            MsgBox("Looks like that was NOT the right color...")
        End If
    End Sub

    'Subroutine:    btnBlue_Click
    'Programmer:    Ryan Isaacson / Munchinator6354
    'Date:          November 20, 2020
    'Description    Handles the blue button being clicked, increases count and determines if correct color.
    Private Sub btnBlue_Click(sender As Object, e As EventArgs) Handles btnBlue.Click
        'Increase Color Guessed Count
        intColorCount += 1
        'Update the Guessing Counts
        UpdateCountScores()
        'If Blue's assigned number is the random color number, start the Number Guess Game
        If intBlue = intRandColor Then
            StartNumberGuess()
        Else
            'Otherwise output a message box saying the user was wrong with their guess
            MsgBox("Looks like that was NOT the right color...")
        End If
    End Sub

    'Subroutine:    btnGreen_Click
    'Programmer:    Ryan Isaacson / Munchinator6354
    'Date:          November 20, 2020
    'Description    Handles the green button being clicked, increases count and determines if correct color.
    Private Sub btnGreen_Click(sender As Object, e As EventArgs) Handles btnGreen.Click
        'Increase Color Guessed Count
        intColorCount += 1
        'Update the Guessing Counts
        UpdateCountScores()
        'If Green's assigned number is the random color number, start the Number Guess Game
        If intGreen = intRandColor Then
            StartNumberGuess()
        Else
            'Otherwise output a message box saying the user was wrong with their guess
            MsgBox("Looks like that was NOT the right color...")
        End If
    End Sub

    'Subroutine:    btnYellow_Click
    'Programmer:    Ryan Isaacson / Munchinator6354
    'Date:          November 20, 2020
    'Description    Handles the yellow button being clicked, increases count and determines if correct color.
    Private Sub btnYellow_Click(sender As Object, e As EventArgs) Handles btnYellow.Click
        'Increase Color Guessed Count
        intColorCount += 1
        'Update the Guessing Counts
        UpdateCountScores()
        'If Yellow's assigned number is the random color number, start the Number Guess Game
        If intYellow = intRandColor Then
            StartNumberGuess()
        Else
            'Otherwise output a message box saying the user was wrong with their guess
            MsgBox("Looks like that was NOT the right color...")
        End If
    End Sub

    '-----------------------------------------------------------------------------------------------
    'Other Functions & Subroutines
    '-----------------------------------------------------------------------------------------------
    'Subroutine:    lnkGitHub_LinkClicked
    'Programmer:    Ryan Isaacson / Munchinator6354
    'Date:          November 20, 2020
    'Description    Takes the user to my spiffy GitHub
    Private Sub lnkGitHub_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkGitHub.LinkClicked
        Process.Start("https://github.com/Munchinator6354")
    End Sub

    'Subroutine:    InitializeGame()
    'Programmer:    Ryan Isaacson / Munchinator6354
    'Date:          November 20, 2020
    'Description    Sets the game up to be played and/or played again
    Private Sub InitializeGame()
        'Get Random Color and Number
        intRandColor = rand.Next(1, 5)
        intRandNum = rand.Next(1, 101)
        'Populate help to the professor grading fields
        lblColorNumber.Text = CStr(intRandColor)
        lblNumberNumber.Text = CStr(intRandNum)
        'Set Initial Count of 0
        UpdateCountScores()
        'Set visible properties back to just color game
        grpColorGame.Visible = True
        grpNumGuess.Visible = False
        grpScores.Visible = False
        'Reset the counts and how they display and clears necessary fields
        intColorCount = 0
        intNumCount = 0
        intTotalCount = 0
        UpdateCountScores()
        txtNumGuess.Text = ""
        lblNumHintOutput.Text = ""
        lblYourLastGuess.Text = "Your Last Guess: "
        AcceptButton = btnGuess
    End Sub

    'Subroutine:    StartNumberGuess()
    'Programmer:    Ryan Isaacson / Munchinator6354
    'Date:          November 20, 2020
    'Description    Makes the number guess game visible and hides the color guess game
    Private Sub StartNumberGuess()
        'Display Number Guess Game
        If grpNumGuess.Visible = False Then
            grpNumGuess.Visible() = True
            grpColorGame.Visible = False
            txtNumGuess.Focus()
            txtNumGuess.SelectAll()
        End If
    End Sub

    'Subroutine:    UpdateCountScores
    'Programmer:    Ryan Isaacson / Munchinator6354
    'Date:          November 20, 2020
    'Description    Updates the guess counts
    Private Sub UpdateCountScores()
        'Update Count Scores
        lblColorCount.Text = CStr(intColorCount)
        lblNumCount.Text = CStr(intNumCount)
        intTotalCount = intColorCount + intNumCount
        lblTotalCount.Text = CStr(intTotalCount)
    End Sub

    'Subroutine:    UpdateScoresGroup
    'Programmer:    Ryan Isaacson / Munchinator6354
    'Date:          November 20, 2020
    'Description    Updates the scores/outcome within the Scores GroupBox
    Private Sub UpdateScoresGroup()
        'Displays end group box to user with information and replay options
        lblScores.Text = "Your number of " & txtNumGuess.Text & " is correct!" & vbCrLf _
            & "You guessed the color in " & lblColorCount.Text & " guesses!" & vbCrLf _
            & "You guessed the number in " & lblNumCount.Text & " guesses!" & vbCrLf _
            & "Would you like to play again?"

    End Sub

    'Subroutine:    btnGuess_Click
    'Programmer:    Ryan Isaacson / Munchinator6354
    'Date:          November 20, 2020
    'Description    Checks user input validation, then compates input number to actual secret number and displays hints as well as what the user last guessed.
    Private Sub btnGuess_Click(sender As Object, e As EventArgs) Handles btnGuess.Click
        'Initializes a new varible to store the last number guessed
        Dim intLastNumberGuessed As Integer
        'Focus' on the guess TextBox
        txtNumGuess.Focus()
        'Checks if the user leaves the number guess text box blank, if blank, outputs message asking for a guess
        If txtNumGuess.Text = "" Then
            MsgBox("Surely you'd like to make a guess?")
            'Checks if the number guess is a valid integer from 0-100
        ElseIf IsNumeric(txtNumGuess.Text) And CInt(txtNumGuess.Text) >= 0 And CInt(txtNumGuess.Text) <= 100 Then
            'This stores the string the user input into a variable
            intLastNumberGuessed = CInt(txtNumGuess.Text)
            'This will clear the TextBox again
            txtNumGuess.Text = ""
            'Displays what the user's last guess was
            lblYourLastGuess.Text = "Your Last Guess: " & CStr(intLastNumberGuessed)
            'Increase Number Guess Count
            intNumCount = intNumCount + 1
            'Update all counts
            UpdateCountScores()
            'Determines output for exact match to hidden number
            If intLastNumberGuessed = intRandNum Then
                AcceptButton = btnProceed
                grpScores.Visible = True
                grpNumGuess.Visible = False
                UpdateScoresGroup()
                MsgBox("Congratulations, You Won" & vbCrLf & "Your Total Guess Count was  " & lblTotalCount.Text & "!")
                'Determines output for number guess more than 7 higher than the hidden number
            ElseIf intLastNumberGuessed > intRandNum And Math.Abs(intRandNum - intLastNumberGuessed) > 7 Then
                lblNumHintOutput.Text = "You guessed too high"

                'Determines output for number guess 7 or less higher than the hidden number
            ElseIf intLastNumberGuessed > intRandNum And intRandNum - intLastNumberGuessed <= 7 Then
                lblNumHintOutput.Text = "You guessed slightly high"

                'Determines output for number guess 7 or less lower than the hidden number
            ElseIf intLastNumberGuessed < intRandNum And intRandNum - intLastNumberGuessed <= 7 Then
                lblNumHintOutput.Text = "You guessed slightly low"

                'Determines output for number guess more than 7 lower than the hidden number
            ElseIf intLastNumberGuessed < intRandNum Then
                lblNumHintOutput.Text = "You guessed too low"
            End If
            'If user did not input valid integer from 0-100, displays Message Box asking for valid input
        Else
            'Tells the user they didn't put in a valid integer
            MsgBox("Input must be a valid integer from 0-100")
        End If
    End Sub

    'Subroutine:    btnProceed_Click
    'Programmer:    Ryan Isaacson / Munchinator6354
    'Date:          November 20, 2020
    'Description    Allows the user to choose between 2 radio buttons and select if they'd like to replay the game or close the program upon button click.
    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        'Checks which radio button is checked and determines to either restart the game or exit the program
        If radYes.Checked Then
            InitializeGame()
        ElseIf radNo.Checked Then
            Close()
        Else
            MsgBox("I would advise selecting one of the 2 radio button options ; )")
        End If
    End Sub

    'Subroutine:    btnRestart_Click
    'Programmer:    Ryan Isaacson / Munchinator6354
    'Date:          November 20, 2020
    'Description    Resets the program back to the beginning
    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        'Calls the InitializeGame subroutine to restart the game
        InitializeGame()
    End Sub

    'Subroutine:    btnExit_Click
    'Programmer:    Ryan Isaacson / Munchinator6354
    'Date:          November 20, 2020
    'Description    Exits the Program
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
