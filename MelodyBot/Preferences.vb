﻿Public Class Preferences
    Dim num As Integer = 0

    Private Sub Preferences_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        songLengthLabel.Text = songLengthSlider.Value.ToString + " Events"
        tempoLabel.Text = tempoSlider.Value.ToString + " BPM"
    End Sub

    Private Sub songLengthSlider_change(sender As Object, e As EventArgs) Handles songLengthSlider.ValueChanged
        songLengthLabel.Text = songLengthSlider.Value.ToString + " Events"
    End Sub

    Private Sub tempoSlider_change(sender As Object, e As EventArgs) Handles tempoSlider.ValueChanged
        tempoLabel.Text = tempoSlider.Value.ToString + " BPM"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles exitPref.Click
        Me.Close()
    End Sub

    Private Sub exitPref_Enter(sender As Object, e As EventArgs) Handles exitPref.MouseEnter
        exitPref.BackColor = Color.Gray
    End Sub
    Private Sub exitPref_Leave(sender As Object, e As EventArgs) Handles exitPref.MouseLeave
        exitPref.BackColor = Color.FromArgb(64, 64, 64)
    End Sub

    Private Sub radioReuse_check(sender As Object, e As EventArgs)
        num = seedNum.Text
    End Sub

    'click and drag the window
    Private isMouseDown As Boolean = False
    Private mouseOffset As Point

    ' Left mouse button pressed
    Private Sub Pref_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ' Get the new position
            mouseOffset = New Point(-e.X, -e.Y)
            ' Set that left button is pressed
            isMouseDown = True
        End If
    End Sub

    ' MouseMove used to check if mouse cursor is moving
    Private Sub Pref_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If isMouseDown Then
            Dim mousePos As Point = Control.MousePosition
            ' Get the new form position
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Me.Location = mousePos
        End If
    End Sub

    ' Left mouse button released, form should stop moving
    Private Sub Pref_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            isMouseDown = False
        End If
    End Sub

    Private Sub buttonRandom_Click(sender As Object, e As EventArgs) Handles buttonRandom.Click
        Randomize()
        num = Int(Rnd() * 1000000) + 1
        seedNum.Text = num
    End Sub
End Class