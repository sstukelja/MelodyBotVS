Imports System.Runtime.InteropServices
Imports System.IO


Public Class Form1
    Dim songTuples As New List(Of Tuple(Of String, String))
    Dim x As Integer = 0
    Dim sampleFolder As String = String.Empty
    'Initialization for page
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "MelodyBot"
        btnGenerate.Show()
        AxWindowsMediaPlayer1.Hide()
        btnPause.Hide()

        volumeSlider.Value = AxWindowsMediaPlayer1.settings.volume
        volumeVal.Text = volumeSlider.Value.ToString

        sampleFolder = My.Computer.FileSystem.SpecialDirectories.Desktop + "\publish\RNN_MelodyBot_NoData"
    End Sub

    'click and drag the window
    Private isMouseDown As Boolean = False
    Private mouseOffset As Point

    ' Left mouse button pressed
    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ' Get the new position
            mouseOffset = New Point(-e.X, -e.Y)
            ' Set that left button is pressed
            isMouseDown = True
        End If
    End Sub

    ' MouseMove used to check if mouse cursor is moving
    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If isMouseDown Then
            Dim mousePos As Point = Control.MousePosition
            ' Get the new form position
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Me.Location = mousePos
        End If
    End Sub

    ' Left mouse button released, form should stop moving
    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            isMouseDown = False
        End If
    End Sub

    'Button for file play
    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        PictureBox5.Hide()
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
        PictureBox5.Show()
    End Sub

    '8 second timer
    Public Sub runTimer()
        Dim timer As New System.Timers.Timer()
        timer.Interval = 8000
        AddHandler timer.Elapsed, AddressOf OnTimedEvent
        timer.AutoReset = False
        timer.Enabled = True
    End Sub

    Private Delegate Sub ShowButtonCallBack()

    'shows generate button and opens dialog box
    Private Sub ShowButton()
        If InvokeRequired Then
            Dim x As New ShowButtonCallBack(AddressOf ShowButton)
            Invoke(x, Nothing)
        Else
            btnGenerate.Show()
            OpenFileDialog1.InitialDirectory = sampleFolder + "\active_samples\"

            If (OpenFileDialog1.ShowDialog = DialogResult.OK) Then
                Dim start As Integer = OpenFileDialog1.FileName.LastIndexOf("\")
                Dim newTuple As Tuple(Of String, String) = New Tuple(Of String, String)(OpenFileDialog1.FileName, OpenFileDialog1.FileName.Substring(start + 1))

                songTuples.Add(newTuple)
                listSamples.Items.Add(newTuple.Item2)
                Console.WriteLine(newTuple)
            End If
        End If
    End Sub

    Private Sub OnTimedEvent(source As Object, e As System.Timers.ElapsedEventArgs)
        ShowButton()
    End Sub


    'Button to invoke RNN
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim OpenCMD
        Dim Genre As String = String.Empty
        Dim output As Integer = 0
        Dim tempo As Integer = 0
        Dim seed As Integer = 0
        Dim length As Integer = 0
        Dim cmd As String = "python RNN_Sampler.py "

        btnGenerate.Hide()
        runTimer()

        If (Preferences.radioBluesGuitar.Checked) Then
            Genre = "bluesGuitar "
        End If

        If (Preferences.radioJazzPiano.Checked) Then
            Genre = "jazzPiano "
        End If

        If (Preferences.radioClassicalViolin.Checked) Then
            Genre = "classicalViolin "
        End If

        If (Preferences.radioMozart.Checked) Then
            Genre = "mozartPiano "
        End If

        If (Preferences.radioJimi.Checked) Then
            Genre = "jimiHendrixGuitar "
        End If

        If (Genre.Equals(String.Empty)) Then
            Throw New ArgumentException("Exception Occured")
        End If

        output = Preferences.listInstruments.SelectedIndex
        tempo = Preferences.tempoSlider.Value
        seed = Preferences.seedNum.Text
        length = Preferences.songLengthSlider.Value

        Dim command As String = String.Concat(cmd, Genre, output, " ", tempo, " ", seed, " ", length)

        OpenCMD = CreateObject("wscript.shell")
        Directory.SetCurrentDirectory(sampleFolder)
        OpenCMD.run(command, 0)

    End Sub

    'Hovering over buttons change color
    'play button
    Private Sub btnPlay_Enter(sender As Object, e As EventArgs) Handles btnPlay.MouseEnter
        btnPlay.BackColor = Color.Gray
    End Sub
    Private Sub btnPlay_Leave(sender As Object, e As EventArgs) Handles btnPlay.MouseLeave
        btnPlay.BackColor = Color.FromArgb(64, 64, 64)
    End Sub

    'pausebutton
    Private Sub btnPause_Enter(sender As Object, e As EventArgs) Handles btnPause.MouseEnter
        btnPause.BackColor = Color.Gray
    End Sub
    Private Sub btnPause_Leave(sender As Object, e As EventArgs) Handles btnPause.MouseLeave
        btnPause.BackColor = Color.FromArgb(64, 64, 64)
    End Sub

    'generate button
    Private Sub btnGenerate_Enter(sender As Object, e As EventArgs) Handles btnGenerate.MouseEnter
        btnGenerate.BackColor = Color.Gray
    End Sub
    Private Sub btnGenerate_Leave(sender As Object, e As EventArgs) Handles btnGenerate.MouseLeave
        btnGenerate.BackColor = Color.FromArgb(64, 64, 64)
    End Sub

    'volume change
    Private Sub volumeSlider_scroll(sender As Object, e As EventArgs) Handles volumeSlider.Scroll
        Dim volume As UInteger = CUInt((UShort.MaxValue / 100) * volumeSlider.Value)
        waveOutSetVolume(IntPtr.Zero, CUInt((volume And &HFFFF) Or (volume << 16)))
        volumeVal.Text = volumeSlider.Value.ToString
    End Sub
    Private Function getVolume() As Integer
        Dim volume As UInteger = 0
        waveOutGetVolume(IntPtr.Zero, volume)
        Return CInt((volume And &HFFFF) / (UShort.MaxValue / 100))
    End Function
    Private Sub timer_tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim v As Integer = getVolume()
        If volumeSlider.Value <> v Then
            volumeSlider.Value = v
            volumeVal.Text = volumeSlider.Value.ToString
        End If
    End Sub
    <DllImport("winmm.dll")> Private Shared Function waveOutSetVolume(ByVal hwo As IntPtr, ByVal dwVolume As UInteger) As UInteger
    End Function
    <DllImport("winmm.dll")> Private Shared Function waveOutGetVolume(ByVal hwo As IntPtr, ByRef pdwVolume As UInteger) As UInteger
    End Function

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
    Private Sub Settings_Click(sender As Object, e As EventArgs) Handles Settings.Click

        User_Prompt.Hide()
        Preferences.ShowDialog()
    End Sub
    'settings button color change
    Private Sub settings_Enter(sender As Object, e As EventArgs) Handles Settings.MouseEnter
        Settings.BackColor = Color.Gray
    End Sub
    Private Sub settings_Leave(sender As Object, e As EventArgs) Handles Settings.MouseLeave
        Settings.BackColor = Color.FromArgb(64, 64, 64)
    End Sub

    'Go To Project Website
    Private Sub WebsiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WebsiteToolStripMenuItem.Click
        Process.Start("https://jsannicolas.github.io/CS-426-MelodyBot/")
    End Sub

    Private Sub exitMain_Click(sender As Object, e As EventArgs) Handles exitMain.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub GeneratingEQ_Click(sender As Object, e As EventArgs) Handles GeneratingEQ.Click

    End Sub

    Private Sub SaveFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveFileToolStripMenuItem.Click
        'Dim fileStream As Stream
        SaveFileDialog1.Filter = "MIDI File|*.mid"
        SaveFileDialog1.Title = "Save a MIDI File"
        SaveFileDialog1.RestoreDirectory = True

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            If (songTuples(listSamples.SelectedIndex).Item2 IsNot Nothing) Then
                My.Computer.FileSystem.CopyFile(My.Computer.FileSystem.SpecialDirectories.Desktop + "\publish\RNN_MelodyBot_NoData\active_samples\" + songTuples(listSamples.SelectedIndex).Item2, SaveFileDialog1.FileName)
            End If
        End If

    End Sub
End Class
