<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Preferences
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.songLengthSlider = New System.Windows.Forms.TrackBar()
        Me.ModelInstrument = New System.Windows.Forms.GroupBox()
        Me.radioJimi = New System.Windows.Forms.RadioButton()
        Me.radioMozart = New System.Windows.Forms.RadioButton()
        Me.radioClassicalViolin = New System.Windows.Forms.RadioButton()
        Me.radioJazzPiano = New System.Windows.Forms.RadioButton()
        Me.radioBluesGuitar = New System.Windows.Forms.RadioButton()
        Me.outputInstrument = New System.Windows.Forms.GroupBox()
        Me.listInstruments = New System.Windows.Forms.ListBox()
        Me.groupSongLength = New System.Windows.Forms.GroupBox()
        Me.songLengthLabel = New System.Windows.Forms.Label()
        Me.lblTwo = New System.Windows.Forms.Label()
        Me.lblOne = New System.Windows.Forms.Label()
        Me.lblTen = New System.Windows.Forms.Label()
        Me.groupTempo = New System.Windows.Forms.GroupBox()
        Me.tempoLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tempoSlider = New System.Windows.Forms.TrackBar()
        Me.exitPref = New System.Windows.Forms.Button()
        Me.groupSeed = New System.Windows.Forms.GroupBox()
        Me.buttonRandom = New System.Windows.Forms.Button()
        Me.seedNum = New System.Windows.Forms.TextBox()
        Me.ModelTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SeedTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.songLengthSlider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ModelInstrument.SuspendLayout()
        Me.outputInstrument.SuspendLayout()
        Me.groupSongLength.SuspendLayout()
        Me.groupTempo.SuspendLayout()
        CType(Me.tempoSlider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupSeed.SuspendLayout()
        Me.SuspendLayout()
        '
        'songLengthSlider
        '
        Me.songLengthSlider.LargeChange = 1000
        Me.songLengthSlider.Location = New System.Drawing.Point(6, 50)
        Me.songLengthSlider.Maximum = 200000
        Me.songLengthSlider.Minimum = 5000
        Me.songLengthSlider.Name = "songLengthSlider"
        Me.songLengthSlider.Size = New System.Drawing.Size(307, 45)
        Me.songLengthSlider.SmallChange = 500
        Me.songLengthSlider.TabIndex = 0
        Me.songLengthSlider.TickFrequency = 10000
        Me.songLengthSlider.Value = 20000
        '
        'ModelInstrument
        '
        Me.ModelInstrument.Controls.Add(Me.radioJimi)
        Me.ModelInstrument.Controls.Add(Me.radioMozart)
        Me.ModelInstrument.Controls.Add(Me.radioClassicalViolin)
        Me.ModelInstrument.Controls.Add(Me.radioJazzPiano)
        Me.ModelInstrument.Controls.Add(Me.radioBluesGuitar)
        Me.ModelInstrument.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModelInstrument.ForeColor = System.Drawing.Color.White
        Me.ModelInstrument.Location = New System.Drawing.Point(20, 23)
        Me.ModelInstrument.Name = "ModelInstrument"
        Me.ModelInstrument.Size = New System.Drawing.Size(200, 147)
        Me.ModelInstrument.TabIndex = 19
        Me.ModelInstrument.TabStop = False
        Me.ModelInstrument.Text = "Model"
        Me.ModelTip.SetToolTip(Me.ModelInstrument, "Type of music the neural network has learned from.")
        '
        'radioJimi
        '
        Me.radioJimi.AutoSize = True
        Me.radioJimi.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioJimi.Location = New System.Drawing.Point(11, 122)
        Me.radioJimi.Name = "radioJimi"
        Me.radioJimi.Size = New System.Drawing.Size(151, 22)
        Me.radioJimi.TabIndex = 21
        Me.radioJimi.TabStop = True
        Me.radioJimi.Text = "Jimi Hendrix Guitar"
        Me.radioJimi.UseVisualStyleBackColor = True
        '
        'radioMozart
        '
        Me.radioMozart.AutoSize = True
        Me.radioMozart.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioMozart.Location = New System.Drawing.Point(12, 97)
        Me.radioMozart.Name = "radioMozart"
        Me.radioMozart.Size = New System.Drawing.Size(115, 22)
        Me.radioMozart.TabIndex = 20
        Me.radioMozart.TabStop = True
        Me.radioMozart.Text = "Mozart Piano"
        Me.radioMozart.UseVisualStyleBackColor = True
        '
        'radioClassicalViolin
        '
        Me.radioClassicalViolin.AutoSize = True
        Me.radioClassicalViolin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioClassicalViolin.Location = New System.Drawing.Point(11, 72)
        Me.radioClassicalViolin.Name = "radioClassicalViolin"
        Me.radioClassicalViolin.Size = New System.Drawing.Size(125, 22)
        Me.radioClassicalViolin.TabIndex = 19
        Me.radioClassicalViolin.TabStop = True
        Me.radioClassicalViolin.Text = "Classical Violin"
        Me.radioClassicalViolin.UseVisualStyleBackColor = True
        '
        'radioJazzPiano
        '
        Me.radioJazzPiano.AutoSize = True
        Me.radioJazzPiano.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioJazzPiano.Location = New System.Drawing.Point(11, 47)
        Me.radioJazzPiano.Name = "radioJazzPiano"
        Me.radioJazzPiano.Size = New System.Drawing.Size(100, 22)
        Me.radioJazzPiano.TabIndex = 18
        Me.radioJazzPiano.TabStop = True
        Me.radioJazzPiano.Text = "Jazz Piano"
        Me.radioJazzPiano.UseVisualStyleBackColor = True
        '
        'radioBluesGuitar
        '
        Me.radioBluesGuitar.AutoSize = True
        Me.radioBluesGuitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioBluesGuitar.Location = New System.Drawing.Point(11, 22)
        Me.radioBluesGuitar.Name = "radioBluesGuitar"
        Me.radioBluesGuitar.Size = New System.Drawing.Size(107, 22)
        Me.radioBluesGuitar.TabIndex = 17
        Me.radioBluesGuitar.TabStop = True
        Me.radioBluesGuitar.Text = "Blues Guitar"
        Me.radioBluesGuitar.UseVisualStyleBackColor = True
        '
        'outputInstrument
        '
        Me.outputInstrument.Controls.Add(Me.listInstruments)
        Me.outputInstrument.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outputInstrument.ForeColor = System.Drawing.Color.White
        Me.outputInstrument.Location = New System.Drawing.Point(20, 176)
        Me.outputInstrument.Name = "outputInstrument"
        Me.outputInstrument.Size = New System.Drawing.Size(200, 303)
        Me.outputInstrument.TabIndex = 20
        Me.outputInstrument.TabStop = False
        Me.outputInstrument.Text = "Output Instrument"
        '
        'listInstruments
        '
        Me.listInstruments.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.listInstruments.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listInstruments.ForeColor = System.Drawing.Color.White
        Me.listInstruments.FormattingEnabled = True
        Me.listInstruments.ItemHeight = 16
        Me.listInstruments.Items.AddRange(New Object() {"Acoustic Grand Piano", "Bright Acoustic Piano", "Electric Grand Piano", "Honky-Tonk Piano", "Electric Piano 1", "Electric Piano 2", "Harpsichord", "Clavi", "Celesta", "Glockenspiel", "Music Box", "Vibraphone", "Marimba", "Xylophone", "Tubular Bells", "Dulcimer", "Drawbar Organ", "Percussive Organ", "Rock Organ", "Church Organ", "Reed Organ", "Accordian", "Harmonica", "Tango Accordian", "Acoustic Guitar (nylon)", "Acoustic Guitar (steel)", "Electric Guitar (jazz)", "Electric Guitar (clean)", "Electric Guitar (muted)", "Overdriven Guitar", "Distortion Guitar", "Guitar harmonics", "Acoustic Bass", "Electric Bass (finger)", "Electric Bass (pick)", "Fretless Bass", "Slap Bass 1", "Slap Bass 2", "Synth Bass 1", "Synth Bass 2", "Violin", "Viola", "Cello", "Contrabass", "Tremolo Strings", "Pizzicato Strings", "Orchestral Harp", "Timpani", "String Ensemble 1", "String Ensemble 2", "SynthStrings 1", "SynthStrings 2", "Choir Aahs", "Voice Oohs", "Synth Voice", "Orchestra Hit", "Trumpet", "Trombone", "Tuba", "Muted Trumpet", "French Horn", "Brass Section", "SynthBrass 1", "SynthBrass 2", "Soprano Sax", "Alto Sax", "Tenor Sax", "Baritone Sax", "Oboe", "English Horn", "Bassoon", "Clarinet", "Piccolo", "Flute", "Recorder", "Pan Flute", "Blown Bottle", "Shakuhachi", "Whistle", "Ocarina"})
        Me.listInstruments.Location = New System.Drawing.Point(7, 29)
        Me.listInstruments.Name = "listInstruments"
        Me.listInstruments.Size = New System.Drawing.Size(187, 260)
        Me.listInstruments.TabIndex = 0
        '
        'groupSongLength
        '
        Me.groupSongLength.Controls.Add(Me.songLengthLabel)
        Me.groupSongLength.Controls.Add(Me.lblTwo)
        Me.groupSongLength.Controls.Add(Me.lblOne)
        Me.groupSongLength.Controls.Add(Me.lblTen)
        Me.groupSongLength.Controls.Add(Me.songLengthSlider)
        Me.groupSongLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupSongLength.ForeColor = System.Drawing.Color.White
        Me.groupSongLength.Location = New System.Drawing.Point(229, 23)
        Me.groupSongLength.Name = "groupSongLength"
        Me.groupSongLength.Size = New System.Drawing.Size(319, 147)
        Me.groupSongLength.TabIndex = 21
        Me.groupSongLength.TabStop = False
        Me.groupSongLength.Text = "Song Length"
        '
        'songLengthLabel
        '
        Me.songLengthLabel.Location = New System.Drawing.Point(61, 27)
        Me.songLengthLabel.Name = "songLengthLabel"
        Me.songLengthLabel.Size = New System.Drawing.Size(189, 24)
        Me.songLengthLabel.TabIndex = 8
        Me.songLengthLabel.Text = "000"
        Me.songLengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTwo
        '
        Me.lblTwo.AutoSize = True
        Me.lblTwo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTwo.Location = New System.Drawing.Point(272, 83)
        Me.lblTwo.Name = "lblTwo"
        Me.lblTwo.Size = New System.Drawing.Size(44, 18)
        Me.lblTwo.TabIndex = 7
        Me.lblTwo.Text = "200 k"
        '
        'lblOne
        '
        Me.lblOne.AutoSize = True
        Me.lblOne.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOne.Location = New System.Drawing.Point(81, 83)
        Me.lblOne.Name = "lblOne"
        Me.lblOne.Size = New System.Drawing.Size(0, 18)
        Me.lblOne.TabIndex = 6
        '
        'lblTen
        '
        Me.lblTen.AutoSize = True
        Me.lblTen.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTen.Location = New System.Drawing.Point(3, 83)
        Me.lblTen.Name = "lblTen"
        Me.lblTen.Size = New System.Drawing.Size(28, 18)
        Me.lblTen.TabIndex = 5
        Me.lblTen.Text = "5 k"
        '
        'groupTempo
        '
        Me.groupTempo.Controls.Add(Me.tempoLabel)
        Me.groupTempo.Controls.Add(Me.Label4)
        Me.groupTempo.Controls.Add(Me.Label1)
        Me.groupTempo.Controls.Add(Me.Label2)
        Me.groupTempo.Controls.Add(Me.Label3)
        Me.groupTempo.Controls.Add(Me.tempoSlider)
        Me.groupTempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupTempo.ForeColor = System.Drawing.Color.White
        Me.groupTempo.Location = New System.Drawing.Point(226, 176)
        Me.groupTempo.Name = "groupTempo"
        Me.groupTempo.Size = New System.Drawing.Size(319, 147)
        Me.groupTempo.TabIndex = 22
        Me.groupTempo.TabStop = False
        Me.groupTempo.Text = "Tempo"
        '
        'tempoLabel
        '
        Me.tempoLabel.Location = New System.Drawing.Point(69, 32)
        Me.tempoLabel.Name = "tempoLabel"
        Me.tempoLabel.Size = New System.Drawing.Size(184, 31)
        Me.tempoLabel.TabIndex = 0
        Me.tempoLabel.Text = "000"
        Me.tempoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(184, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "1000"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(273, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 18)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "1500"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(94, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "500"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "20"
        '
        'tempoSlider
        '
        Me.tempoSlider.LargeChange = 10
        Me.tempoSlider.Location = New System.Drawing.Point(6, 56)
        Me.tempoSlider.Maximum = 1500
        Me.tempoSlider.Minimum = 20
        Me.tempoSlider.Name = "tempoSlider"
        Me.tempoSlider.Size = New System.Drawing.Size(307, 45)
        Me.tempoSlider.SmallChange = 5
        Me.tempoSlider.TabIndex = 0
        Me.tempoSlider.TickFrequency = 100
        Me.tempoSlider.Value = 120
        '
        'exitPref
        '
        Me.exitPref.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.exitPref.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitPref.ForeColor = System.Drawing.Color.White
        Me.exitPref.Location = New System.Drawing.Point(277, 443)
        Me.exitPref.Name = "exitPref"
        Me.exitPref.Size = New System.Drawing.Size(212, 36)
        Me.exitPref.TabIndex = 23
        Me.exitPref.Text = "Confirm"
        Me.exitPref.UseVisualStyleBackColor = False
        '
        'groupSeed
        '
        Me.groupSeed.Controls.Add(Me.buttonRandom)
        Me.groupSeed.Controls.Add(Me.seedNum)
        Me.groupSeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupSeed.ForeColor = System.Drawing.Color.White
        Me.groupSeed.Location = New System.Drawing.Point(226, 329)
        Me.groupSeed.Name = "groupSeed"
        Me.groupSeed.Size = New System.Drawing.Size(319, 108)
        Me.groupSeed.TabIndex = 22
        Me.groupSeed.TabStop = False
        Me.groupSeed.Text = "Seed"
        Me.SeedTip.SetToolTip(Me.groupSeed, "Value for the procedurally generated music to start from.")
        '
        'buttonRandom
        '
        Me.buttonRandom.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.buttonRandom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonRandom.ForeColor = System.Drawing.Color.White
        Me.buttonRandom.Location = New System.Drawing.Point(123, 49)
        Me.buttonRandom.Name = "buttonRandom"
        Me.buttonRandom.Size = New System.Drawing.Size(179, 31)
        Me.buttonRandom.TabIndex = 24
        Me.buttonRandom.Text = "Generate Random Seed"
        Me.buttonRandom.UseVisualStyleBackColor = False
        '
        'seedNum
        '
        Me.seedNum.Location = New System.Drawing.Point(24, 50)
        Me.seedNum.Name = "seedNum"
        Me.seedNum.Size = New System.Drawing.Size(78, 31)
        Me.seedNum.TabIndex = 24
        Me.seedNum.Text = "000000"
        '
        'ModelTip
        '
        Me.ModelTip.ShowAlways = True
        Me.ModelTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ModelTip.ToolTipTitle = "Model description"
        '
        'Preferences
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(560, 491)
        Me.Controls.Add(Me.groupSeed)
        Me.Controls.Add(Me.exitPref)
        Me.Controls.Add(Me.groupTempo)
        Me.Controls.Add(Me.groupSongLength)
        Me.Controls.Add(Me.outputInstrument)
        Me.Controls.Add(Me.ModelInstrument)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Preferences"
        Me.Text = "Preferences"
        CType(Me.songLengthSlider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ModelInstrument.ResumeLayout(False)
        Me.ModelInstrument.PerformLayout()
        Me.outputInstrument.ResumeLayout(False)
        Me.groupSongLength.ResumeLayout(False)
        Me.groupSongLength.PerformLayout()
        Me.groupTempo.ResumeLayout(False)
        Me.groupTempo.PerformLayout()
        CType(Me.tempoSlider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupSeed.ResumeLayout(False)
        Me.groupSeed.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents songLengthSlider As TrackBar
    Friend WithEvents ModelInstrument As GroupBox
    Friend WithEvents radioClassicalViolin As RadioButton
    Friend WithEvents radioJazzPiano As RadioButton
    Friend WithEvents radioBluesGuitar As RadioButton
    Friend WithEvents outputInstrument As GroupBox
    Friend WithEvents listInstruments As ListBox
    Friend WithEvents radioMozart As RadioButton
    Friend WithEvents groupSongLength As GroupBox
    Friend WithEvents lblTwo As Label
    Friend WithEvents lblOne As Label
    Friend WithEvents lblTen As Label
    Friend WithEvents groupTempo As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tempoSlider As TrackBar
    Friend WithEvents songLengthLabel As Label
    Friend WithEvents tempoLabel As Label
    Friend WithEvents exitPref As Button
    Friend WithEvents radioJimi As RadioButton
    Friend WithEvents groupSeed As GroupBox
    Friend WithEvents seedNum As TextBox
    Friend WithEvents buttonRandom As Button
    Friend WithEvents ModelTip As ToolTip
    Friend WithEvents SeedTip As ToolTip
End Class
