
Public Class Form1

    Dim songTuples As New List(Of Tuple(Of String, String))

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "MelodyBot"
        Me.BackColor = Color.White
        AxWindowsMediaPlayer1.Hide()
        btnPause.Hide()
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        If (AxWindowsMediaPlayer1.URL.Equals(songTuples(listSamples.SelectedIndex).Item1)) Then
            AxWindowsMediaPlayer1.Ctlcontrols.play()
        Else
            AxWindowsMediaPlayer1.URL = songTuples(listSamples.SelectedIndex).Item1
        End If
        btnPause.Show()
        btnPlay.Hide()
    End Sub

    Private Sub btnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click
        AxWindowsMediaPlayer1.Ctlcontrols.pause()
        btnPlay.Show()
        btnPause.Hide()
    End Sub




    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        Dim OpenCMD
        OpenCMD = CreateObject("wscript.shell")
        OpenCMD.CurrentDirectory = "C:\Users\Lepi\Desktop\CS425\RNN_MelodyBot\"
        OpenCMD.run("python example.py")
    End Sub

    Private Sub ImportSampleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportSampleToolStripMenuItem.Click
        If (OpenFileDialog1.ShowDialog = DialogResult.OK) Then
            Dim start As Integer = OpenFileDialog1.FileName.LastIndexOf("\")
            Dim newTuple As Tuple(Of String, String) = New Tuple(Of String, String)(OpenFileDialog1.FileName, OpenFileDialog1.FileName.Substring(start + 1))

            songTuples.Add(newTuple)
            listSamples.Items.Add(newTuple.Item2)
        End If
    End Sub

    Private Sub RemoveSampleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveSampleToolStripMenuItem.Click
        If (AxWindowsMediaPlayer1.URL.Equals(songTuples(listSamples.SelectedIndex).Item1)) Then
            AxWindowsMediaPlayer1.Ctlcontrols.stop()
        End If
        songTuples.RemoveAt(listSamples.SelectedIndex)
        listSamples.Items.Remove(listSamples.SelectedItem)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub PreferencesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PHToolStripMenuItem.Click
        Preferences.ShowDialog()
    End Sub

    Private Sub WebsiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WebsiteToolStripMenuItem.Click
        Process.Start("https://jsannicolas.github.io/CS-426-MelodyBot/")
    End Sub
End Class
