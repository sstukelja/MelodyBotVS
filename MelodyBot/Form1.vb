﻿
Public Class Form1

    Dim songTuples As New List(Of Tuple(Of String, String))
    'Initialization for page
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "MelodyBot"
        Me.BackColor = Color.White
        AxWindowsMediaPlayer1.Hide()
        btnPause.Hide()
    End Sub

    'Button for file play
    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        If (AxWindowsMediaPlayer1.URL.Equals(songTuples(listSamples.SelectedIndex).Item1)) Then
            AxWindowsMediaPlayer1.Ctlcontrols.play()
        Else
            AxWindowsMediaPlayer1.URL = songTuples(listSamples.SelectedIndex).Item1
        End If
        btnPause.Show()
        btnPlay.Hide()
    End Sub

    'Button for file pause
    Private Sub btnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click
        AxWindowsMediaPlayer1.Ctlcontrols.pause()
        btnPlay.Show()
        btnPause.Hide()
    End Sub

    'Button to invoke RNN
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim OpenCMD
        Dim Genre As String = String.Empty
        Dim cmd As String = "python RNN_Sampler.py "

        If (RadioButton1.Checked) Then
            Genre = "bluesGuitar"
        End If

        If (RadioButton2.Checked) Then
            Genre = "jazzPiano"
        End If

        If (RadioButton3.Checked) Then
            Genre = "classicalViolin"
        End If

        If (Genre.Equals(String.Empty)) Then
            Throw New ArgumentException("Exception Occured")
        End If

        Dim command As String = String.Concat(cmd, Genre)

        OpenCMD = CreateObject("wscript.shell")
        OpenCMD.CurrentDirectory = "C:\Users\Lepi\Desktop\CS425\RNN_MelodyBot_NoData\"
        OpenCMD.run(command)

        Dim filePath As String = "C:\Users\Lepi\Desktop\CS425\RNN_MelodyBot_NoData\active_samples\"
        Dim fileName As String = String.Concat(Genre, "Sample.mid")
        Dim newTuple As Tuple(Of String, String) = New Tuple(Of String, String)(String.Concat(filePath, fileName), fileName)

        If (songTuples.IndexOf(newTuple).Equals(-1)) Then
            songTuples.Add(newTuple)
            listSamples.Items.Add(newTuple.Item2)
        Else
            AxWindowsMediaPlayer1.Ctlcontrols.pause()
            btnPlay.Show()
            btnPause.Hide()

            listSamples.SelectedIndex = -1
        End If

    End Sub

    'File Import
    Private Sub ImportFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportFileToolStripMenuItem.Click
        If (OpenFileDialog1.ShowDialog = DialogResult.OK) Then
            Dim start As Integer = OpenFileDialog1.FileName.LastIndexOf("\")
            Dim newTuple As Tuple(Of String, String) = New Tuple(Of String, String)(OpenFileDialog1.FileName, OpenFileDialog1.FileName.Substring(start + 1))

            songTuples.Add(newTuple)
            listSamples.Items.Add(newTuple.Item2)
            Console.WriteLine(newTuple)
        End If
    End Sub

    'File Remove
    Private Sub RemoveFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveFileToolStripMenuItem.Click
        If (AxWindowsMediaPlayer1.URL.Equals(songTuples(listSamples.SelectedIndex).Item1)) Then
            AxWindowsMediaPlayer1.Ctlcontrols.stop()
        End If
        songTuples.RemoveAt(listSamples.SelectedIndex)
        listSamples.Items.Remove(listSamples.SelectedItem)
    End Sub

    'Exit Application
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    'Go To Preferences
    Private Sub PreferencesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PHToolStripMenuItem.Click
        Preferences.ShowDialog()
    End Sub

    'Go To Project Website
    Private Sub WebsiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WebsiteToolStripMenuItem.Click
        Process.Start("https://jsannicolas.github.io/CS-426-MelodyBot/")
    End Sub
End Class
