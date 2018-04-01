Public Class Preferences
    Private Sub Preferences_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        songLengthLabel.Text = songLengthSlider.Value.ToString + " seconds"
        tempoLabel.Text = tempoSlider.Value.ToString + " BPM"
    End Sub

    Private Sub songLengthSlider_change(sender As Object, e As EventArgs) Handles songLengthSlider.ValueChanged
        songLengthLabel.Text = songLengthSlider.Value.ToString + " seconds"
    End Sub

    Private Sub tempoSlider_change(sender As Object, e As EventArgs) Handles tempoSlider.ValueChanged
        tempoLabel.Text = tempoSlider.Value.ToString + " BPM"
    End Sub

End Class