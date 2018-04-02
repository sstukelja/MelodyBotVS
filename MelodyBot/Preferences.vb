Public Class Preferences
    Dim num As Integer = 0

    Private Sub Preferences_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        songLengthLabel.Text = songLengthSlider.Value.ToString + " Events"
        tempoLabel.Text = tempoSlider.Value.ToString + " BPM"
    End Sub

    'changing value in sliders
    Private Sub songLengthSlider_change(sender As Object, e As EventArgs) Handles songLengthSlider.ValueChanged
        songLengthLabel.Text = songLengthSlider.Value.ToString + " Events"
    End Sub

    Private Sub tempoSlider_change(sender As Object, e As EventArgs) Handles tempoSlider.ValueChanged
        tempoLabel.Text = tempoSlider.Value.ToString + " BPM"
    End Sub

    'confirm button click
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles exitPref.Click
        Me.Close()
    End Sub
    'confim button color change
    Private Sub exitPref_Enter(sender As Object, e As EventArgs) Handles exitPref.MouseEnter
        exitPref.BackColor = Color.Gray
    End Sub
    Private Sub exitPref_Leave(sender As Object, e As EventArgs) Handles exitPref.MouseLeave
        exitPref.BackColor = Color.FromArgb(64, 64, 64)
    End Sub

    'setting defaults values
    'blues guitar
    Private Sub bluesGuitar_Default(sender As Object, e As EventArgs) Handles radioBluesGuitar.CheckedChanged
        If (radioBluesGuitar.Checked) Then
            tempoSlider.Value = 960
            listInstruments.SelectedIndex = 25
        End If
    End Sub
    'jazz piano
    Private Sub jazzPiano_Default(sender As Object, e As EventArgs) Handles radioJazzPiano.CheckedChanged
        If (radioJazzPiano.Checked) Then
            tempoSlider.Value = 120
            listInstruments.SelectedIndex = 0
        End If
    End Sub
    'classical violin
    Private Sub classicalViolin_Default(sender As Object, e As EventArgs) Handles radioClassicalViolin.CheckedChanged
        If (radioClassicalViolin.Checked) Then
            tempoSlider.Value = 480
            listInstruments.SelectedIndex = 40
        End If
    End Sub
    'mozart piano
    Private Sub mozart_Default(sender As Object, e As EventArgs) Handles radioMozart.CheckedChanged
        If (radioMozart.Checked) Then
            tempoSlider.Value = 120
            listInstruments.SelectedIndex = 0
        End If
    End Sub
    'jimi hendrix guitar
    Private Sub jimi_Default(sender As Object, e As EventArgs) Handles radioJimi.CheckedChanged
        If (radioJimi.Checked) Then
            tempoSlider.Value = 960
            listInstruments.SelectedIndex = 30
        End If
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

    'random seed number button click
    Private Sub buttonRandom_Click(sender As Object, e As EventArgs) Handles buttonRandom.Click
        Randomize()
        num = Int(Rnd() * 1000000) + 1
        seedNum.Text = num
    End Sub
    'random seed number color change
    Private Sub random_Enter(sender As Object, e As EventArgs) Handles buttonRandom.MouseEnter
        buttonRandom.BackColor = Color.Gray
    End Sub
    Private Sub random_Leave(sender As Object, e As EventArgs) Handles buttonRandom.MouseLeave
        buttonRandom.BackColor = Color.FromArgb(64, 64, 64)
    End Sub

End Class