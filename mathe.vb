Public Class Form1

    Private randomNumber As Integer
    Private attempts As Integer

    Public Sub New()
        InitializeComponent()
        StartNewGame()
    End Sub

    Private Sub StartNewGame()
        Dim rand As New Random()
        randomNumber = rand.Next(1, 101)
        attempts = 0

        labelHint.Text = "Versuche eine Zahl zwischen 1 und 100 zu erraten!"
        labelAttempts.Text = "Versuche: 0"
        textBoxGuess.Text = ""
        buttonGuess.Enabled = True
    End Sub

    Private Sub buttonGuess_Click(sender As Object, e As EventArgs) Handles buttonGuess.Click
        Dim guess As Integer
        If Integer.TryParse(textBoxGuess.Text, guess) Then
            attempts += 1
            labelAttempts.Text = "Versuche: " & attempts.ToString()

            If guess < randomNumber Then
                labelHint.Text = "Zu niedrig! Versuch es nochmal."
            ElseIf guess > randomNumber Then
                labelHint.Text = "Zu hoch! Versuch es nochmal."
            Else
                labelHint.Text = "Gewonnen! Die richtige Zahl war " & randomNumber.ToString() & "."
                buttonGuess.Enabled = False '
            End If
        Else
            labelHint.Text = "Bitte gib eine gültige Zahl ein!"
        End If
    End Sub
    Private Sub buttonNewGame_Click(sender As Object, e As EventArgs) Handles buttonNewGame.Click
        StartNewGame()
    End Sub
End Class
