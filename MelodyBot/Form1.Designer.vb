<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.listSamples = New System.Windows.Forms.ListBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebsiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LicenseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.volumeSlider = New System.Windows.Forms.TrackBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.exitMain = New System.Windows.Forms.Button()
        Me.PictureBox16 = New System.Windows.Forms.PictureBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.volumeVal = New System.Windows.Forms.Label()
        Me.volumeLabel = New System.Windows.Forms.Label()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnPause = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.GenLabel = New System.Windows.Forms.Label()
        Me.GeneratingEQ = New System.Windows.Forms.PictureBox()
        Me.Settings = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.User_Prompt = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.volumeSlider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneratingEQ, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'listSamples
        '
        Me.listSamples.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.listSamples.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listSamples.ForeColor = System.Drawing.Color.White
        Me.listSamples.FormattingEnabled = True
        Me.listSamples.ItemHeight = 25
        Me.listSamples.Location = New System.Drawing.Point(361, 164)
        Me.listSamples.Name = "listSamples"
        Me.listSamples.Size = New System.Drawing.Size(348, 129)
        Me.listSamples.TabIndex = 9
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(0, 452)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(38, 25)
        Me.AxWindowsMediaPlayer1.TabIndex = 13
        '
        'btnGenerate
        '
        Me.btnGenerate.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnGenerate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerate.ForeColor = System.Drawing.Color.White
        Me.btnGenerate.Location = New System.Drawing.Point(51, 237)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(266, 126)
        Me.btnGenerate.TabIndex = 15
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AboutUsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(731, 24)
        Me.MenuStrip1.TabIndex = 16
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportFileToolStripMenuItem, Me.RemoveFileToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ImportFileToolStripMenuItem
        '
        Me.ImportFileToolStripMenuItem.Name = "ImportFileToolStripMenuItem"
        Me.ImportFileToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.ImportFileToolStripMenuItem.Text = "Import File..."
        '
        'RemoveFileToolStripMenuItem
        '
        Me.RemoveFileToolStripMenuItem.Name = "RemoveFileToolStripMenuItem"
        Me.RemoveFileToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.RemoveFileToolStripMenuItem.Text = "Remove File..."
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.ExitToolStripMenuItem.Text = "Exit..."
        '
        'AboutUsToolStripMenuItem
        '
        Me.AboutUsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AboutUsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WebsiteToolStripMenuItem, Me.LicenseToolStripMenuItem})
        Me.AboutUsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AboutUsToolStripMenuItem.Name = "AboutUsToolStripMenuItem"
        Me.AboutUsToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutUsToolStripMenuItem.Text = "About"
        '
        'WebsiteToolStripMenuItem
        '
        Me.WebsiteToolStripMenuItem.Name = "WebsiteToolStripMenuItem"
        Me.WebsiteToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.WebsiteToolStripMenuItem.Text = "Website..."
        '
        'LicenseToolStripMenuItem
        '
        Me.LicenseToolStripMenuItem.Name = "LicenseToolStripMenuItem"
        Me.LicenseToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.LicenseToolStripMenuItem.Text = "License..."
        '
        'volumeSlider
        '
        Me.volumeSlider.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.volumeSlider.LargeChange = 2
        Me.volumeSlider.Location = New System.Drawing.Point(534, 326)
        Me.volumeSlider.Maximum = 100
        Me.volumeSlider.Name = "volumeSlider"
        Me.volumeSlider.Size = New System.Drawing.Size(156, 45)
        Me.volumeSlider.TabIndex = 22
        Me.volumeSlider.TickFrequency = 5
        '
        'Timer1
        '
        '
        'exitMain
        '
        Me.exitMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.exitMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exitMain.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitMain.ForeColor = System.Drawing.Color.White
        Me.exitMain.Location = New System.Drawing.Point(706, -1)
        Me.exitMain.Name = "exitMain"
        Me.exitMain.Size = New System.Drawing.Size(27, 24)
        Me.exitMain.TabIndex = 25
        Me.exitMain.Text = "X"
        Me.exitMain.UseVisualStyleBackColor = False
        '
        'PictureBox16
        '
        Me.PictureBox16.Image = CType(resources.GetObject("PictureBox16.Image"), System.Drawing.Image)
        Me.PictureBox16.Location = New System.Drawing.Point(409, 448)
        Me.PictureBox16.Name = "PictureBox16"
        Me.PictureBox16.Size = New System.Drawing.Size(231, 83)
        Me.PictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox16.TabIndex = 38
        Me.PictureBox16.TabStop = False
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ListBox1.ForeColor = System.Drawing.Color.White
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G"})
        Me.ListBox1.Location = New System.Drawing.Point(7, 20)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(100, 69)
        Me.ListBox1.TabIndex = 0
        '
        'ListBox2
        '
        Me.ListBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ListBox2.ForeColor = System.Drawing.Color.White
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Items.AddRange(New Object() {"#", "♭", "Major", "Minor"})
        Me.ListBox2.Location = New System.Drawing.Point(114, 20)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(80, 69)
        Me.ListBox2.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ListBox2)
        Me.GroupBox3.Controls.Add(Me.ListBox1)
        Me.GroupBox3.Location = New System.Drawing.Point(117, 407)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Key"
        Me.GroupBox3.Visible = False
        '
        'volumeVal
        '
        Me.volumeVal.AutoSize = True
        Me.volumeVal.BackColor = System.Drawing.Color.Transparent
        Me.volumeVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.volumeVal.ForeColor = System.Drawing.Color.White
        Me.volumeVal.Location = New System.Drawing.Point(636, 307)
        Me.volumeVal.Name = "volumeVal"
        Me.volumeVal.Size = New System.Drawing.Size(22, 16)
        Me.volumeVal.TabIndex = 24
        Me.volumeVal.Text = "00"
        '
        'volumeLabel
        '
        Me.volumeLabel.AutoSize = True
        Me.volumeLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.volumeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.volumeLabel.ForeColor = System.Drawing.Color.White
        Me.volumeLabel.Location = New System.Drawing.Point(570, 307)
        Me.volumeLabel.Name = "volumeLabel"
        Me.volumeLabel.Size = New System.Drawing.Size(60, 16)
        Me.volumeLabel.TabIndex = 23
        Me.volumeLabel.Text = "Volume :"
        '
        'btnPlay
        '
        Me.btnPlay.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.ForeColor = System.Drawing.Color.White
        Me.btnPlay.Location = New System.Drawing.Point(395, 316)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(97, 47)
        Me.btnPlay.TabIndex = 12
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = False
        '
        'btnPause
        '
        Me.btnPause.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnPause.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPause.ForeColor = System.Drawing.Color.White
        Me.btnPause.Location = New System.Drawing.Point(396, 315)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(97, 47)
        Me.btnPause.TabIndex = 14
        Me.btnPause.Text = "Pause"
        Me.btnPause.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(204, 473)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(231, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 39
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-1, 473)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(231, 34)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 40
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.PictureBox3.Location = New System.Drawing.Point(-1, 130)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(732, 254)
        Me.PictureBox3.TabIndex = 41
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(563, 456)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(231, 68)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 42
        Me.PictureBox4.TabStop = False
        '
        'GenLabel
        '
        Me.GenLabel.AutoSize = True
        Me.GenLabel.BackColor = System.Drawing.Color.Transparent
        Me.GenLabel.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenLabel.ForeColor = System.Drawing.Color.White
        Me.GenLabel.Location = New System.Drawing.Point(131, 236)
        Me.GenLabel.Name = "GenLabel"
        Me.GenLabel.Size = New System.Drawing.Size(113, 24)
        Me.GenLabel.TabIndex = 43
        Me.GenLabel.Text = "Generating"
        '
        'GeneratingEQ
        '
        Me.GeneratingEQ.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GeneratingEQ.Image = CType(resources.GetObject("GeneratingEQ.Image"), System.Drawing.Image)
        Me.GeneratingEQ.Location = New System.Drawing.Point(51, 236)
        Me.GeneratingEQ.Name = "GeneratingEQ"
        Me.GeneratingEQ.Size = New System.Drawing.Size(266, 126)
        Me.GeneratingEQ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GeneratingEQ.TabIndex = 44
        Me.GeneratingEQ.TabStop = False
        '
        'Settings
        '
        Me.Settings.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Settings.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Settings.ForeColor = System.Drawing.Color.White
        Me.Settings.Location = New System.Drawing.Point(51, 164)
        Me.Settings.Name = "Settings"
        Me.Settings.Size = New System.Drawing.Size(266, 55)
        Me.Settings.TabIndex = 45
        Me.Settings.Text = "Settings"
        Me.Settings.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(12, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 42)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Melo♪yBot"
        '
        'User_Prompt
        '
        Me.User_Prompt.AutoSize = True
        Me.User_Prompt.ForeColor = System.Drawing.Color.White
        Me.User_Prompt.Location = New System.Drawing.Point(12, 114)
        Me.User_Prompt.Name = "User_Prompt"
        Me.User_Prompt.Size = New System.Drawing.Size(122, 13)
        Me.User_Prompt.TabIndex = 47
        Me.User_Prompt.Text = "Press 'Settings' to begin." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(731, 497)
        Me.Controls.Add(Me.User_Prompt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Settings)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.GenLabel)
        Me.Controls.Add(Me.GeneratingEQ)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox16)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.exitMain)
        Me.Controls.Add(Me.volumeVal)
        Me.Controls.Add(Me.volumeLabel)
        Me.Controls.Add(Me.volumeSlider)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnPause)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.listSamples)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "MelodyBot"
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.volumeSlider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneratingEQ, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents listSamples As ListBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents btnGenerate As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImportFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutUsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WebsiteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LicenseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents volumeSlider As TrackBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents exitMain As Button
    Friend WithEvents PictureBox16 As PictureBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents volumeVal As Label
    Friend WithEvents volumeLabel As Label
    Friend WithEvents btnPlay As Button
    Friend WithEvents btnPause As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents GenLabel As Label
    Friend WithEvents GeneratingEQ As PictureBox
    Friend WithEvents Settings As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents User_Prompt As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
End Class
