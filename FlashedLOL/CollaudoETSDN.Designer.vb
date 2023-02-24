<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CollaudoETSDN
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PanelAlimentazione = New System.Windows.Forms.Panel()
        Me.InfoPWR = New System.Windows.Forms.PictureBox()
        Me.ErrorTestPWR = New System.Windows.Forms.PictureBox()
        Me.StatoTestAlimentazione = New System.Windows.Forms.PictureBox()
        Me.PWR_NOT = New System.Windows.Forms.PictureBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Amps = New System.Windows.Forms.Label()
        Me.LabelTensioneIn = New System.Windows.Forms.Label()
        Me.PWR_OK = New System.Windows.Forms.PictureBox()
        Me.CheckPWR = New System.Windows.Forms.CheckBox()
        Me.LoadingPWR = New System.Windows.Forms.PictureBox()
        Me.LabelPWR = New System.Windows.Forms.Label()
        Me.PanelRele = New System.Windows.Forms.Panel()
        Me.LabelRL3 = New System.Windows.Forms.Label()
        Me.LabelRL2 = New System.Windows.Forms.Label()
        Me.LabelRL1 = New System.Windows.Forms.Label()
        Me.InfoRL = New System.Windows.Forms.PictureBox()
        Me.StatotestRele = New System.Windows.Forms.PictureBox()
        Me.RL3_NOT = New System.Windows.Forms.PictureBox()
        Me.RL2_NOT = New System.Windows.Forms.PictureBox()
        Me.RL1_NOT = New System.Windows.Forms.PictureBox()
        Me.RL1_OK = New System.Windows.Forms.PictureBox()
        Me.RL3_OK = New System.Windows.Forms.PictureBox()
        Me.RL2_OK = New System.Windows.Forms.PictureBox()
        Me.Label_RL3 = New System.Windows.Forms.Label()
        Me.Label_RL2 = New System.Windows.Forms.Label()
        Me.Label_RL1 = New System.Windows.Forms.Label()
        Me.ErrorTestRL = New System.Windows.Forms.PictureBox()
        Me.LoadingRL = New System.Windows.Forms.PictureBox()
        Me.CheckRL = New System.Windows.Forms.CheckBox()
        Me.PanelIngressi = New System.Windows.Forms.Panel()
        Me.InfoIP = New System.Windows.Forms.PictureBox()
        Me.IN2_NOT = New System.Windows.Forms.PictureBox()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.ANA10V_NOT = New System.Windows.Forms.PictureBox()
        Me.IN1_NOT = New System.Windows.Forms.PictureBox()
        Me.ANA5V_NOT = New System.Windows.Forms.PictureBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.ANA10V_OK = New System.Windows.Forms.PictureBox()
        Me.IP2_NOT = New System.Windows.Forms.PictureBox()
        Me.ANA5V_OK = New System.Windows.Forms.PictureBox()
        Me.IP1_NOT = New System.Windows.Forms.PictureBox()
        Me.ANAVolt10 = New System.Windows.Forms.Label()
        Me.IP1_OK = New System.Windows.Forms.PictureBox()
        Me.ANAVolt5 = New System.Windows.Forms.Label()
        Me.Label_ANA10V = New System.Windows.Forms.Label()
        Me.IN2_OK = New System.Windows.Forms.PictureBox()
        Me.Label_ANA5V = New System.Windows.Forms.Label()
        Me.IN1_OK = New System.Windows.Forms.PictureBox()
        Me.IP2_OK = New System.Windows.Forms.PictureBox()
        Me.Label_IN2 = New System.Windows.Forms.Label()
        Me.Label_IN1 = New System.Windows.Forms.Label()
        Me.Label_IP2 = New System.Windows.Forms.Label()
        Me.Label_IP1 = New System.Windows.Forms.Label()
        Me.ErrorTestIP = New System.Windows.Forms.PictureBox()
        Me.StatoTestIngressi = New System.Windows.Forms.PictureBox()
        Me.CheckIP = New System.Windows.Forms.CheckBox()
        Me.LoadingIP = New System.Windows.Forms.PictureBox()
        Me.Panel5V = New System.Windows.Forms.Panel()
        Me.Info5V = New System.Windows.Forms.PictureBox()
        Me.OUT5V_NOT = New System.Windows.Forms.PictureBox()
        Me.OUT5V_OK = New System.Windows.Forms.PictureBox()
        Me.OUT5V = New System.Windows.Forms.Label()
        Me.Label_5V = New System.Windows.Forms.Label()
        Me.ErrorTest5V = New System.Windows.Forms.PictureBox()
        Me.StatoTest5V = New System.Windows.Forms.PictureBox()
        Me.Loading5V = New System.Windows.Forms.PictureBox()
        Me.Check5V = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelAcc = New System.Windows.Forms.Panel()
        Me.MsgTestAcc = New System.Windows.Forms.Label()
        Me.accX = New System.Windows.Forms.Label()
        Me.InfoACC = New System.Windows.Forms.PictureBox()
        Me.accY = New System.Windows.Forms.Label()
        Me.accZ = New System.Windows.Forms.Label()
        Me.ErrorTestACC = New System.Windows.Forms.PictureBox()
        Me.StatoTestAccellerometro = New System.Windows.Forms.PictureBox()
        Me.LoadingAcc = New System.Windows.Forms.PictureBox()
        Me.CheckAcc = New System.Windows.Forms.CheckBox()
        Me.MovimentoETSDN = New System.Windows.Forms.PictureBox()
        Me.ETSDN_Statico = New System.Windows.Forms.PictureBox()
        Me.CheckTutti = New System.Windows.Forms.CheckBox()
        Me.OpenLog = New System.Windows.Forms.Button()
        Me.TestingSerial = New System.Windows.Forms.Label()
        Me.BarTestEtsdn = New System.Windows.Forms.ProgressBar()
        Me.ButtonErrorView = New System.Windows.Forms.Button()
        Me.LabelClock = New System.Windows.Forms.Label()
        Me.ErrorTestCAN = New System.Windows.Forms.PictureBox()
        Me.StatoTestCAN = New System.Windows.Forms.PictureBox()
        Me.GifCan = New System.Windows.Forms.PictureBox()
        Me.ErrorInfo = New System.Windows.Forms.Button()
        Me.StartEtsdn = New System.Windows.Forms.Button()
        Me.StopEtsdn = New System.Windows.Forms.Button()
        Me.PanelAlimentazione.SuspendLayout()
        CType(Me.InfoPWR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorTestPWR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatoTestAlimentazione, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PWR_NOT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PWR_OK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoadingPWR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelRele.SuspendLayout()
        CType(Me.InfoRL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatotestRele, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RL3_NOT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RL2_NOT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RL1_NOT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RL1_OK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RL3_OK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RL2_OK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorTestRL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoadingRL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelIngressi.SuspendLayout()
        CType(Me.InfoIP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IN2_NOT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANA10V_NOT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IN1_NOT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANA5V_NOT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANA10V_OK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IP2_NOT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANA5V_OK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IP1_NOT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IP1_OK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IN2_OK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IN1_OK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IP2_OK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorTestIP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatoTestIngressi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoadingIP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5V.SuspendLayout()
        CType(Me.Info5V, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OUT5V_NOT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OUT5V_OK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorTest5V, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatoTest5V, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Loading5V, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelAcc.SuspendLayout()
        CType(Me.InfoACC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorTestACC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatoTestAccellerometro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoadingAcc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MovimentoETSDN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ETSDN_Statico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorTestCAN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatoTestCAN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GifCan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelAlimentazione
        '
        Me.PanelAlimentazione.BackColor = System.Drawing.Color.White
        Me.PanelAlimentazione.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelAlimentazione.Controls.Add(Me.InfoPWR)
        Me.PanelAlimentazione.Controls.Add(Me.ErrorTestPWR)
        Me.PanelAlimentazione.Controls.Add(Me.StatoTestAlimentazione)
        Me.PanelAlimentazione.Controls.Add(Me.PWR_NOT)
        Me.PanelAlimentazione.Controls.Add(Me.Label50)
        Me.PanelAlimentazione.Controls.Add(Me.Amps)
        Me.PanelAlimentazione.Controls.Add(Me.LabelTensioneIn)
        Me.PanelAlimentazione.Controls.Add(Me.PWR_OK)
        Me.PanelAlimentazione.Controls.Add(Me.CheckPWR)
        Me.PanelAlimentazione.Controls.Add(Me.LoadingPWR)
        Me.PanelAlimentazione.Location = New System.Drawing.Point(8, 143)
        Me.PanelAlimentazione.Name = "PanelAlimentazione"
        Me.PanelAlimentazione.Size = New System.Drawing.Size(242, 148)
        Me.PanelAlimentazione.TabIndex = 0
        '
        'InfoPWR
        '
        Me.InfoPWR.BackColor = System.Drawing.Color.Transparent
        Me.InfoPWR.BackgroundImage = Global.FlashedLOL.My.Resources.Res.Info
        Me.InfoPWR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.InfoPWR.Location = New System.Drawing.Point(152, 5)
        Me.InfoPWR.Name = "InfoPWR"
        Me.InfoPWR.Size = New System.Drawing.Size(23, 30)
        Me.InfoPWR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.InfoPWR.TabIndex = 115
        Me.InfoPWR.TabStop = False
        '
        'ErrorTestPWR
        '
        Me.ErrorTestPWR.BackColor = System.Drawing.Color.Transparent
        Me.ErrorTestPWR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ErrorTestPWR.Image = Global.FlashedLOL.My.Resources.Res.R
        Me.ErrorTestPWR.Location = New System.Drawing.Point(179, 94)
        Me.ErrorTestPWR.Name = "ErrorTestPWR"
        Me.ErrorTestPWR.Size = New System.Drawing.Size(66, 53)
        Me.ErrorTestPWR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ErrorTestPWR.TabIndex = 19
        Me.ErrorTestPWR.TabStop = False
        Me.ErrorTestPWR.Visible = False
        '
        'StatoTestAlimentazione
        '
        Me.StatoTestAlimentazione.BackColor = System.Drawing.Color.Transparent
        Me.StatoTestAlimentazione.BackgroundImage = Global.FlashedLOL.My.Resources.Res.Correct
        Me.StatoTestAlimentazione.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.StatoTestAlimentazione.Location = New System.Drawing.Point(199, 3)
        Me.StatoTestAlimentazione.Name = "StatoTestAlimentazione"
        Me.StatoTestAlimentazione.Size = New System.Drawing.Size(42, 39)
        Me.StatoTestAlimentazione.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.StatoTestAlimentazione.TabIndex = 16
        Me.StatoTestAlimentazione.TabStop = False
        Me.StatoTestAlimentazione.Visible = False
        '
        'PWR_NOT
        '
        Me.PWR_NOT.BackColor = System.Drawing.Color.Transparent
        Me.PWR_NOT.BackgroundImage = Global.FlashedLOL.My.Resources.Res._Error
        Me.PWR_NOT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PWR_NOT.Location = New System.Drawing.Point(166, 68)
        Me.PWR_NOT.Name = "PWR_NOT"
        Me.PWR_NOT.Size = New System.Drawing.Size(17, 17)
        Me.PWR_NOT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PWR_NOT.TabIndex = 108
        Me.PWR_NOT.TabStop = False
        Me.PWR_NOT.Visible = False
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(141, 71)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(25, 13)
        Me.Label50.TabIndex = 96
        Me.Label50.Text = "Volt"
        '
        'Amps
        '
        Me.Amps.AutoSize = True
        Me.Amps.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Amps.Location = New System.Drawing.Point(95, 71)
        Me.Amps.MinimumSize = New System.Drawing.Size(45, 15)
        Me.Amps.Name = "Amps"
        Me.Amps.Size = New System.Drawing.Size(45, 15)
        Me.Amps.TabIndex = 22
        '
        'LabelTensioneIn
        '
        Me.LabelTensioneIn.AutoSize = True
        Me.LabelTensioneIn.Location = New System.Drawing.Point(12, 70)
        Me.LabelTensioneIn.Name = "LabelTensioneIn"
        Me.LabelTensioneIn.Size = New System.Drawing.Size(86, 13)
        Me.LabelTensioneIn.TabIndex = 21
        Me.LabelTensioneIn.Text = "Tensione interna"
        '
        'PWR_OK
        '
        Me.PWR_OK.BackColor = System.Drawing.Color.Transparent
        Me.PWR_OK.BackgroundImage = Global.FlashedLOL.My.Resources.Res.Correct
        Me.PWR_OK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PWR_OK.Location = New System.Drawing.Point(183, 68)
        Me.PWR_OK.Name = "PWR_OK"
        Me.PWR_OK.Size = New System.Drawing.Size(17, 17)
        Me.PWR_OK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PWR_OK.TabIndex = 20
        Me.PWR_OK.TabStop = False
        Me.PWR_OK.Visible = False
        '
        'CheckPWR
        '
        Me.CheckPWR.AutoSize = True
        Me.CheckPWR.Checked = True
        Me.CheckPWR.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckPWR.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckPWR.Location = New System.Drawing.Point(9, 8)
        Me.CheckPWR.Name = "CheckPWR"
        Me.CheckPWR.Size = New System.Drawing.Size(148, 22)
        Me.CheckPWR.TabIndex = 0
        Me.CheckPWR.Text = "Test Alimentazione" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.CheckPWR.UseVisualStyleBackColor = True
        '
        'LoadingPWR
        '
        Me.LoadingPWR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.LoadingPWR.Image = Global.FlashedLOL.My.Resources.Res.Loading
        Me.LoadingPWR.Location = New System.Drawing.Point(199, -1)
        Me.LoadingPWR.Name = "LoadingPWR"
        Me.LoadingPWR.Size = New System.Drawing.Size(46, 43)
        Me.LoadingPWR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LoadingPWR.TabIndex = 12
        Me.LoadingPWR.TabStop = False
        Me.LoadingPWR.Visible = False
        '
        'LabelPWR
        '
        Me.LabelPWR.AutoSize = True
        Me.LabelPWR.Location = New System.Drawing.Point(80, 11)
        Me.LabelPWR.Name = "LabelPWR"
        Me.LabelPWR.Size = New System.Drawing.Size(69, 13)
        Me.LabelPWR.TabIndex = 12
        Me.LabelPWR.Text = "Stato Device"
        '
        'PanelRele
        '
        Me.PanelRele.BackColor = System.Drawing.Color.White
        Me.PanelRele.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelRele.Controls.Add(Me.LabelRL3)
        Me.PanelRele.Controls.Add(Me.LabelRL2)
        Me.PanelRele.Controls.Add(Me.LabelRL1)
        Me.PanelRele.Controls.Add(Me.InfoRL)
        Me.PanelRele.Controls.Add(Me.StatotestRele)
        Me.PanelRele.Controls.Add(Me.RL3_NOT)
        Me.PanelRele.Controls.Add(Me.RL2_NOT)
        Me.PanelRele.Controls.Add(Me.RL1_NOT)
        Me.PanelRele.Controls.Add(Me.RL1_OK)
        Me.PanelRele.Controls.Add(Me.RL3_OK)
        Me.PanelRele.Controls.Add(Me.RL2_OK)
        Me.PanelRele.Controls.Add(Me.Label_RL3)
        Me.PanelRele.Controls.Add(Me.Label_RL2)
        Me.PanelRele.Controls.Add(Me.Label_RL1)
        Me.PanelRele.Controls.Add(Me.ErrorTestRL)
        Me.PanelRele.Controls.Add(Me.LoadingRL)
        Me.PanelRele.Controls.Add(Me.CheckRL)
        Me.PanelRele.Location = New System.Drawing.Point(296, 143)
        Me.PanelRele.Name = "PanelRele"
        Me.PanelRele.Size = New System.Drawing.Size(242, 148)
        Me.PanelRele.TabIndex = 1
        '
        'LabelRL3
        '
        Me.LabelRL3.AutoSize = True
        Me.LabelRL3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelRL3.Location = New System.Drawing.Point(52, 92)
        Me.LabelRL3.MinimumSize = New System.Drawing.Size(45, 15)
        Me.LabelRL3.Name = "LabelRL3"
        Me.LabelRL3.Size = New System.Drawing.Size(45, 15)
        Me.LabelRL3.TabIndex = 120
        '
        'LabelRL2
        '
        Me.LabelRL2.AutoSize = True
        Me.LabelRL2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelRL2.Location = New System.Drawing.Point(52, 68)
        Me.LabelRL2.MinimumSize = New System.Drawing.Size(45, 15)
        Me.LabelRL2.Name = "LabelRL2"
        Me.LabelRL2.Size = New System.Drawing.Size(45, 15)
        Me.LabelRL2.TabIndex = 119
        '
        'LabelRL1
        '
        Me.LabelRL1.AutoSize = True
        Me.LabelRL1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelRL1.Location = New System.Drawing.Point(52, 44)
        Me.LabelRL1.MinimumSize = New System.Drawing.Size(45, 15)
        Me.LabelRL1.Name = "LabelRL1"
        Me.LabelRL1.Size = New System.Drawing.Size(45, 15)
        Me.LabelRL1.TabIndex = 116
        '
        'InfoRL
        '
        Me.InfoRL.BackColor = System.Drawing.Color.Transparent
        Me.InfoRL.BackgroundImage = Global.FlashedLOL.My.Resources.Res.Info
        Me.InfoRL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.InfoRL.Location = New System.Drawing.Point(93, 5)
        Me.InfoRL.Name = "InfoRL"
        Me.InfoRL.Size = New System.Drawing.Size(23, 30)
        Me.InfoRL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.InfoRL.TabIndex = 116
        Me.InfoRL.TabStop = False
        '
        'StatotestRele
        '
        Me.StatotestRele.BackColor = System.Drawing.Color.Transparent
        Me.StatotestRele.BackgroundImage = Global.FlashedLOL.My.Resources.Res.Correct
        Me.StatotestRele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.StatotestRele.Location = New System.Drawing.Point(195, 3)
        Me.StatotestRele.Name = "StatotestRele"
        Me.StatotestRele.Size = New System.Drawing.Size(42, 39)
        Me.StatotestRele.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.StatotestRele.TabIndex = 18
        Me.StatotestRele.TabStop = False
        Me.StatotestRele.Visible = False
        '
        'RL3_NOT
        '
        Me.RL3_NOT.BackColor = System.Drawing.Color.Transparent
        Me.RL3_NOT.BackgroundImage = Global.FlashedLOL.My.Resources.Res._Error
        Me.RL3_NOT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.RL3_NOT.Location = New System.Drawing.Point(120, 95)
        Me.RL3_NOT.Name = "RL3_NOT"
        Me.RL3_NOT.Size = New System.Drawing.Size(17, 17)
        Me.RL3_NOT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.RL3_NOT.TabIndex = 118
        Me.RL3_NOT.TabStop = False
        Me.RL3_NOT.Visible = False
        '
        'RL2_NOT
        '
        Me.RL2_NOT.BackColor = System.Drawing.Color.Transparent
        Me.RL2_NOT.BackgroundImage = Global.FlashedLOL.My.Resources.Res._Error
        Me.RL2_NOT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.RL2_NOT.Location = New System.Drawing.Point(120, 68)
        Me.RL2_NOT.Name = "RL2_NOT"
        Me.RL2_NOT.Size = New System.Drawing.Size(17, 17)
        Me.RL2_NOT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.RL2_NOT.TabIndex = 117
        Me.RL2_NOT.TabStop = False
        Me.RL2_NOT.Visible = False
        '
        'RL1_NOT
        '
        Me.RL1_NOT.BackColor = System.Drawing.Color.Transparent
        Me.RL1_NOT.BackgroundImage = Global.FlashedLOL.My.Resources.Res._Error
        Me.RL1_NOT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.RL1_NOT.Location = New System.Drawing.Point(120, 44)
        Me.RL1_NOT.Name = "RL1_NOT"
        Me.RL1_NOT.Size = New System.Drawing.Size(17, 17)
        Me.RL1_NOT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.RL1_NOT.TabIndex = 110
        Me.RL1_NOT.TabStop = False
        Me.RL1_NOT.Visible = False
        '
        'RL1_OK
        '
        Me.RL1_OK.BackColor = System.Drawing.Color.Transparent
        Me.RL1_OK.BackgroundImage = Global.FlashedLOL.My.Resources.Res.Correct
        Me.RL1_OK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.RL1_OK.Location = New System.Drawing.Point(138, 44)
        Me.RL1_OK.Name = "RL1_OK"
        Me.RL1_OK.Size = New System.Drawing.Size(17, 17)
        Me.RL1_OK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.RL1_OK.TabIndex = 116
        Me.RL1_OK.TabStop = False
        Me.RL1_OK.Visible = False
        '
        'RL3_OK
        '
        Me.RL3_OK.BackColor = System.Drawing.Color.Transparent
        Me.RL3_OK.BackgroundImage = Global.FlashedLOL.My.Resources.Res.Correct
        Me.RL3_OK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.RL3_OK.Location = New System.Drawing.Point(138, 95)
        Me.RL3_OK.Name = "RL3_OK"
        Me.RL3_OK.Size = New System.Drawing.Size(17, 17)
        Me.RL3_OK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.RL3_OK.TabIndex = 115
        Me.RL3_OK.TabStop = False
        Me.RL3_OK.Visible = False
        '
        'RL2_OK
        '
        Me.RL2_OK.BackColor = System.Drawing.Color.Transparent
        Me.RL2_OK.BackgroundImage = Global.FlashedLOL.My.Resources.Res.Correct
        Me.RL2_OK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.RL2_OK.Location = New System.Drawing.Point(138, 68)
        Me.RL2_OK.Name = "RL2_OK"
        Me.RL2_OK.Size = New System.Drawing.Size(17, 17)
        Me.RL2_OK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.RL2_OK.TabIndex = 114
        Me.RL2_OK.TabStop = False
        Me.RL2_OK.Visible = False
        '
        'Label_RL3
        '
        Me.Label_RL3.AutoSize = True
        Me.Label_RL3.Location = New System.Drawing.Point(11, 94)
        Me.Label_RL3.Name = "Label_RL3"
        Me.Label_RL3.Size = New System.Drawing.Size(35, 13)
        Me.Label_RL3.TabIndex = 113
        Me.Label_RL3.Text = "Rele3"
        '
        'Label_RL2
        '
        Me.Label_RL2.AutoSize = True
        Me.Label_RL2.Location = New System.Drawing.Point(11, 68)
        Me.Label_RL2.Name = "Label_RL2"
        Me.Label_RL2.Size = New System.Drawing.Size(35, 13)
        Me.Label_RL2.TabIndex = 112
        Me.Label_RL2.Text = "Rele2"
        '
        'Label_RL1
        '
        Me.Label_RL1.AutoSize = True
        Me.Label_RL1.Location = New System.Drawing.Point(11, 44)
        Me.Label_RL1.Name = "Label_RL1"
        Me.Label_RL1.Size = New System.Drawing.Size(35, 13)
        Me.Label_RL1.TabIndex = 111
        Me.Label_RL1.Text = "Rele1"
        '
        'ErrorTestRL
        '
        Me.ErrorTestRL.BackColor = System.Drawing.Color.Transparent
        Me.ErrorTestRL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ErrorTestRL.Image = Global.FlashedLOL.My.Resources.Res.R
        Me.ErrorTestRL.Location = New System.Drawing.Point(177, 94)
        Me.ErrorTestRL.Name = "ErrorTestRL"
        Me.ErrorTestRL.Size = New System.Drawing.Size(64, 53)
        Me.ErrorTestRL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ErrorTestRL.TabIndex = 20
        Me.ErrorTestRL.TabStop = False
        Me.ErrorTestRL.Visible = False
        '
        'LoadingRL
        '
        Me.LoadingRL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.LoadingRL.Image = Global.FlashedLOL.My.Resources.Res.Loading
        Me.LoadingRL.Location = New System.Drawing.Point(195, -1)
        Me.LoadingRL.Name = "LoadingRL"
        Me.LoadingRL.Size = New System.Drawing.Size(42, 43)
        Me.LoadingRL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LoadingRL.TabIndex = 13
        Me.LoadingRL.TabStop = False
        Me.LoadingRL.Visible = False
        '
        'CheckRL
        '
        Me.CheckRL.AutoSize = True
        Me.CheckRL.Checked = True
        Me.CheckRL.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckRL.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckRL.Location = New System.Drawing.Point(14, 8)
        Me.CheckRL.Name = "CheckRL"
        Me.CheckRL.Size = New System.Drawing.Size(85, 22)
        Me.CheckRL.TabIndex = 1
        Me.CheckRL.Text = "Test Rele"
        Me.CheckRL.UseVisualStyleBackColor = True
        '
        'PanelIngressi
        '
        Me.PanelIngressi.BackColor = System.Drawing.Color.White
        Me.PanelIngressi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelIngressi.Controls.Add(Me.InfoIP)
        Me.PanelIngressi.Controls.Add(Me.IN2_NOT)
        Me.PanelIngressi.Controls.Add(Me.Panel10)
        Me.PanelIngressi.Controls.Add(Me.ANA10V_NOT)
        Me.PanelIngressi.Controls.Add(Me.IN1_NOT)
        Me.PanelIngressi.Controls.Add(Me.ANA5V_NOT)
        Me.PanelIngressi.Controls.Add(Me.Panel9)
        Me.PanelIngressi.Controls.Add(Me.ANA10V_OK)
        Me.PanelIngressi.Controls.Add(Me.IP2_NOT)
        Me.PanelIngressi.Controls.Add(Me.ANA5V_OK)
        Me.PanelIngressi.Controls.Add(Me.IP1_NOT)
        Me.PanelIngressi.Controls.Add(Me.ANAVolt10)
        Me.PanelIngressi.Controls.Add(Me.IP1_OK)
        Me.PanelIngressi.Controls.Add(Me.ANAVolt5)
        Me.PanelIngressi.Controls.Add(Me.Label_ANA10V)
        Me.PanelIngressi.Controls.Add(Me.IN2_OK)
        Me.PanelIngressi.Controls.Add(Me.Label_ANA5V)
        Me.PanelIngressi.Controls.Add(Me.IN1_OK)
        Me.PanelIngressi.Controls.Add(Me.IP2_OK)
        Me.PanelIngressi.Controls.Add(Me.Label_IN2)
        Me.PanelIngressi.Controls.Add(Me.Label_IN1)
        Me.PanelIngressi.Controls.Add(Me.Label_IP2)
        Me.PanelIngressi.Controls.Add(Me.Label_IP1)
        Me.PanelIngressi.Controls.Add(Me.ErrorTestIP)
        Me.PanelIngressi.Controls.Add(Me.StatoTestIngressi)
        Me.PanelIngressi.Controls.Add(Me.CheckIP)
        Me.PanelIngressi.Controls.Add(Me.LoadingIP)
        Me.PanelIngressi.Location = New System.Drawing.Point(584, 143)
        Me.PanelIngressi.Name = "PanelIngressi"
        Me.PanelIngressi.Size = New System.Drawing.Size(242, 148)
        Me.PanelIngressi.TabIndex = 1
        '
        'InfoIP
        '
        Me.InfoIP.BackColor = System.Drawing.Color.Transparent
        Me.InfoIP.BackgroundImage = Global.FlashedLOL.My.Resources.Res.Info
        Me.InfoIP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.InfoIP.Location = New System.Drawing.Point(112, 5)
        Me.InfoIP.Name = "InfoIP"
        Me.InfoIP.Size = New System.Drawing.Size(23, 30)
        Me.InfoIP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.InfoIP.TabIndex = 119
        Me.InfoIP.TabStop = False
        '
        'IN2_NOT
        '
        Me.IN2_NOT.BackColor = System.Drawing.Color.Transparent
        Me.IN2_NOT.BackgroundImage = Global.FlashedLOL.My.Resources.Res._Error
        Me.IN2_NOT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.IN2_NOT.Location = New System.Drawing.Point(123, 59)
        Me.IN2_NOT.Name = "IN2_NOT"
        Me.IN2_NOT.Size = New System.Drawing.Size(17, 17)
        Me.IN2_NOT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.IN2_NOT.TabIndex = 107
        Me.IN2_NOT.TabStop = False
        Me.IN2_NOT.Visible = False
        '
        'Panel10
        '
        Me.Panel10.Location = New System.Drawing.Point(313, 312)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(324, 125)
        Me.Panel10.TabIndex = 26
        '
        'ANA10V_NOT
        '
        Me.ANA10V_NOT.BackColor = System.Drawing.Color.Transparent
        Me.ANA10V_NOT.BackgroundImage = Global.FlashedLOL.My.Resources.Res._Error
        Me.ANA10V_NOT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ANA10V_NOT.Location = New System.Drawing.Point(112, 118)
        Me.ANA10V_NOT.Name = "ANA10V_NOT"
        Me.ANA10V_NOT.Size = New System.Drawing.Size(17, 17)
        Me.ANA10V_NOT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ANA10V_NOT.TabIndex = 114
        Me.ANA10V_NOT.TabStop = False
        Me.ANA10V_NOT.Visible = False
        '
        'IN1_NOT
        '
        Me.IN1_NOT.BackColor = System.Drawing.Color.Transparent
        Me.IN1_NOT.BackgroundImage = Global.FlashedLOL.My.Resources.Res._Error
        Me.IN1_NOT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.IN1_NOT.Location = New System.Drawing.Point(123, 36)
        Me.IN1_NOT.Name = "IN1_NOT"
        Me.IN1_NOT.Size = New System.Drawing.Size(17, 17)
        Me.IN1_NOT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.IN1_NOT.TabIndex = 106
        Me.IN1_NOT.TabStop = False
        Me.IN1_NOT.Visible = False
        '
        'ANA5V_NOT
        '
        Me.ANA5V_NOT.BackColor = System.Drawing.Color.Transparent
        Me.ANA5V_NOT.BackgroundImage = Global.FlashedLOL.My.Resources.Res._Error
        Me.ANA5V_NOT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ANA5V_NOT.Location = New System.Drawing.Point(112, 94)
        Me.ANA5V_NOT.Name = "ANA5V_NOT"
        Me.ANA5V_NOT.Size = New System.Drawing.Size(17, 17)
        Me.ANA5V_NOT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ANA5V_NOT.TabIndex = 108
        Me.ANA5V_NOT.TabStop = False
        Me.ANA5V_NOT.Visible = False
        '
        'Panel9
        '
        Me.Panel9.Location = New System.Drawing.Point(313, 93)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(324, 95)
        Me.Panel9.TabIndex = 25
        '
        'ANA10V_OK
        '
        Me.ANA10V_OK.BackColor = System.Drawing.Color.Transparent
        Me.ANA10V_OK.BackgroundImage = Global.FlashedLOL.My.Resources.Res.Correct
        Me.ANA10V_OK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ANA10V_OK.Location = New System.Drawing.Point(130, 119)
        Me.ANA10V_OK.Name = "ANA10V_OK"
        Me.ANA10V_OK.Size = New System.Drawing.Size(17, 17)
        Me.ANA10V_OK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ANA10V_OK.TabIndex = 113
        Me.ANA10V_OK.TabStop = False
        Me.ANA10V_OK.Visible = False
        '
        'IP2_NOT
        '
        Me.IP2_NOT.BackColor = System.Drawing.Color.Transparent
        Me.IP2_NOT.BackgroundImage = Global.FlashedLOL.My.Resources.Res._Error
        Me.IP2_NOT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.IP2_NOT.Location = New System.Drawing.Point(42, 59)
        Me.IP2_NOT.Name = "IP2_NOT"
        Me.IP2_NOT.Size = New System.Drawing.Size(17, 17)
        Me.IP2_NOT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.IP2_NOT.TabIndex = 105
        Me.IP2_NOT.TabStop = False
        Me.IP2_NOT.Visible = False
        '
        'ANA5V_OK
        '
        Me.ANA5V_OK.BackColor = System.Drawing.Color.Transparent
        Me.ANA5V_OK.BackgroundImage = Global.FlashedLOL.My.Resources.Res.Correct
        Me.ANA5V_OK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ANA5V_OK.Location = New System.Drawing.Point(130, 94)
        Me.ANA5V_OK.Name = "ANA5V_OK"
        Me.ANA5V_OK.Size = New System.Drawing.Size(17, 17)
        Me.ANA5V_OK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ANA5V_OK.TabIndex = 112
        Me.ANA5V_OK.TabStop = False
        Me.ANA5V_OK.Visible = False
        '
        'IP1_NOT
        '
        Me.IP1_NOT.BackColor = System.Drawing.Color.Transparent
        Me.IP1_NOT.BackgroundImage = Global.FlashedLOL.My.Resources.Res._Error
        Me.IP1_NOT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.IP1_NOT.Location = New System.Drawing.Point(42, 35)
        Me.IP1_NOT.Name = "IP1_NOT"
        Me.IP1_NOT.Size = New System.Drawing.Size(17, 17)
        Me.IP1_NOT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.IP1_NOT.TabIndex = 97
        Me.IP1_NOT.TabStop = False
        Me.IP1_NOT.Visible = False
        '
        'ANAVolt10
        '
        Me.ANAVolt10.AutoSize = True
        Me.ANAVolt10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ANAVolt10.Location = New System.Drawing.Point(54, 120)
        Me.ANAVolt10.MinimumSize = New System.Drawing.Size(45, 15)
        Me.ANAVolt10.Name = "ANAVolt10"
        Me.ANAVolt10.Size = New System.Drawing.Size(45, 15)
        Me.ANAVolt10.TabIndex = 111
        '
        'IP1_OK
        '
        Me.IP1_OK.BackColor = System.Drawing.Color.Transparent
        Me.IP1_OK.BackgroundImage = Global.FlashedLOL.My.Resources.Res.Correct
        Me.IP1_OK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.IP1_OK.Location = New System.Drawing.Point(60, 35)
        Me.IP1_OK.Name = "IP1_OK"
        Me.IP1_OK.Size = New System.Drawing.Size(17, 17)
        Me.IP1_OK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.IP1_OK.TabIndex = 104
        Me.IP1_OK.TabStop = False
        Me.IP1_OK.Visible = False
        '
        'ANAVolt5
        '
        Me.ANAVolt5.AutoSize = True
        Me.ANAVolt5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ANAVolt5.Location = New System.Drawing.Point(54, 95)
        Me.ANAVolt5.MinimumSize = New System.Drawing.Size(45, 15)
        Me.ANAVolt5.Name = "ANAVolt5"
        Me.ANAVolt5.Size = New System.Drawing.Size(45, 15)
        Me.ANAVolt5.TabIndex = 109
        '
        'Label_ANA10V
        '
        Me.Label_ANA10V.AutoSize = True
        Me.Label_ANA10V.Location = New System.Drawing.Point(22, 120)
        Me.Label_ANA10V.Name = "Label_ANA10V"
        Me.Label_ANA10V.Size = New System.Drawing.Size(35, 13)
        Me.Label_ANA10V.TabIndex = 110
        Me.Label_ANA10V.Text = "ANA2"
        '
        'IN2_OK
        '
        Me.IN2_OK.BackColor = System.Drawing.Color.Transparent
        Me.IN2_OK.BackgroundImage = Global.FlashedLOL.My.Resources.Res.Correct
        Me.IN2_OK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.IN2_OK.Location = New System.Drawing.Point(141, 59)
        Me.IN2_OK.Name = "IN2_OK"
        Me.IN2_OK.Size = New System.Drawing.Size(17, 17)
        Me.IN2_OK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.IN2_OK.TabIndex = 103
        Me.IN2_OK.TabStop = False
        Me.IN2_OK.Visible = False
        '
        'Label_ANA5V
        '
        Me.Label_ANA5V.AutoSize = True
        Me.Label_ANA5V.Location = New System.Drawing.Point(22, 95)
        Me.Label_ANA5V.Name = "Label_ANA5V"
        Me.Label_ANA5V.Size = New System.Drawing.Size(35, 13)
        Me.Label_ANA5V.TabIndex = 109
        Me.Label_ANA5V.Text = "ANA1"
        '
        'IN1_OK
        '
        Me.IN1_OK.BackColor = System.Drawing.Color.Transparent
        Me.IN1_OK.BackgroundImage = Global.FlashedLOL.My.Resources.Res.Correct
        Me.IN1_OK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.IN1_OK.Location = New System.Drawing.Point(141, 36)
        Me.IN1_OK.Name = "IN1_OK"
        Me.IN1_OK.Size = New System.Drawing.Size(17, 17)
        Me.IN1_OK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.IN1_OK.TabIndex = 102
        Me.IN1_OK.TabStop = False
        Me.IN1_OK.Visible = False
        '
        'IP2_OK
        '
        Me.IP2_OK.BackColor = System.Drawing.Color.Transparent
        Me.IP2_OK.BackgroundImage = Global.FlashedLOL.My.Resources.Res.Correct
        Me.IP2_OK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.IP2_OK.Location = New System.Drawing.Point(60, 59)
        Me.IP2_OK.Name = "IP2_OK"
        Me.IP2_OK.Size = New System.Drawing.Size(17, 17)
        Me.IP2_OK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.IP2_OK.TabIndex = 101
        Me.IP2_OK.TabStop = False
        Me.IP2_OK.Visible = False
        '
        'Label_IN2
        '
        Me.Label_IN2.AutoSize = True
        Me.Label_IN2.Location = New System.Drawing.Point(101, 59)
        Me.Label_IN2.Name = "Label_IN2"
        Me.Label_IN2.Size = New System.Drawing.Size(24, 13)
        Me.Label_IN2.TabIndex = 100
        Me.Label_IN2.Text = "IN2"
        '
        'Label_IN1
        '
        Me.Label_IN1.AutoSize = True
        Me.Label_IN1.Location = New System.Drawing.Point(101, 35)
        Me.Label_IN1.Name = "Label_IN1"
        Me.Label_IN1.Size = New System.Drawing.Size(24, 13)
        Me.Label_IN1.TabIndex = 99
        Me.Label_IN1.Text = "IN1"
        '
        'Label_IP2
        '
        Me.Label_IP2.AutoSize = True
        Me.Label_IP2.Location = New System.Drawing.Point(20, 59)
        Me.Label_IP2.Name = "Label_IP2"
        Me.Label_IP2.Size = New System.Drawing.Size(23, 13)
        Me.Label_IP2.TabIndex = 98
        Me.Label_IP2.Text = "IP2"
        '
        'Label_IP1
        '
        Me.Label_IP1.AutoSize = True
        Me.Label_IP1.Location = New System.Drawing.Point(20, 35)
        Me.Label_IP1.Name = "Label_IP1"
        Me.Label_IP1.Size = New System.Drawing.Size(23, 13)
        Me.Label_IP1.TabIndex = 97
        Me.Label_IP1.Text = "IP1"
        '
        'ErrorTestIP
        '
        Me.ErrorTestIP.BackColor = System.Drawing.Color.Transparent
        Me.ErrorTestIP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ErrorTestIP.Image = Global.FlashedLOL.My.Resources.Res.R
        Me.ErrorTestIP.Location = New System.Drawing.Point(179, 93)
        Me.ErrorTestIP.Name = "ErrorTestIP"
        Me.ErrorTestIP.Size = New System.Drawing.Size(66, 53)
        Me.ErrorTestIP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ErrorTestIP.TabIndex = 24
        Me.ErrorTestIP.TabStop = False
        Me.ErrorTestIP.Visible = False
        '
        'StatoTestIngressi
        '
        Me.StatoTestIngressi.BackColor = System.Drawing.Color.Transparent
        Me.StatoTestIngressi.BackgroundImage = Global.FlashedLOL.My.Resources.Res.Correct
        Me.StatoTestIngressi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.StatoTestIngressi.Location = New System.Drawing.Point(199, 3)
        Me.StatoTestIngressi.Name = "StatoTestIngressi"
        Me.StatoTestIngressi.Size = New System.Drawing.Size(42, 39)
        Me.StatoTestIngressi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.StatoTestIngressi.TabIndex = 19
        Me.StatoTestIngressi.TabStop = False
        Me.StatoTestIngressi.Visible = False
        '
        'CheckIP
        '
        Me.CheckIP.AutoSize = True
        Me.CheckIP.Checked = True
        Me.CheckIP.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckIP.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckIP.Location = New System.Drawing.Point(12, 8)
        Me.CheckIP.Name = "CheckIP"
        Me.CheckIP.Size = New System.Drawing.Size(106, 22)
        Me.CheckIP.TabIndex = 5
        Me.CheckIP.Text = "Test Ingressi"
        Me.CheckIP.UseVisualStyleBackColor = True
        '
        'LoadingIP
        '
        Me.LoadingIP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.LoadingIP.Image = Global.FlashedLOL.My.Resources.Res.Loading
        Me.LoadingIP.Location = New System.Drawing.Point(199, -1)
        Me.LoadingIP.Name = "LoadingIP"
        Me.LoadingIP.Size = New System.Drawing.Size(42, 43)
        Me.LoadingIP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LoadingIP.TabIndex = 15
        Me.LoadingIP.TabStop = False
        Me.LoadingIP.Visible = False
        '
        'Panel5V
        '
        Me.Panel5V.BackColor = System.Drawing.Color.White
        Me.Panel5V.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5V.Controls.Add(Me.Info5V)
        Me.Panel5V.Controls.Add(Me.OUT5V_NOT)
        Me.Panel5V.Controls.Add(Me.OUT5V_OK)
        Me.Panel5V.Controls.Add(Me.OUT5V)
        Me.Panel5V.Controls.Add(Me.Label_5V)
        Me.Panel5V.Controls.Add(Me.ErrorTest5V)
        Me.Panel5V.Controls.Add(Me.StatoTest5V)
        Me.Panel5V.Controls.Add(Me.Loading5V)
        Me.Panel5V.Controls.Add(Me.Check5V)
        Me.Panel5V.Location = New System.Drawing.Point(127, 313)
        Me.Panel5V.Name = "Panel5V"
        Me.Panel5V.Size = New System.Drawing.Size(242, 148)
        Me.Panel5V.TabIndex = 1
        '
        'Info5V
        '
        Me.Info5V.BackColor = System.Drawing.Color.Transparent
        Me.Info5V.BackgroundImage = Global.FlashedLOL.My.Resources.Res.Info
        Me.Info5V.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Info5V.Location = New System.Drawing.Point(75, 5)
        Me.Info5V.Name = "Info5V"
        Me.Info5V.Size = New System.Drawing.Size(23, 30)
        Me.Info5V.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Info5V.TabIndex = 120
        Me.Info5V.TabStop = False
        '
        'OUT5V_NOT
        '
        Me.OUT5V_NOT.BackColor = System.Drawing.Color.Transparent
        Me.OUT5V_NOT.BackgroundImage = Global.FlashedLOL.My.Resources.Res._Error
        Me.OUT5V_NOT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.OUT5V_NOT.Location = New System.Drawing.Point(75, 76)
        Me.OUT5V_NOT.Name = "OUT5V_NOT"
        Me.OUT5V_NOT.Size = New System.Drawing.Size(17, 17)
        Me.OUT5V_NOT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.OUT5V_NOT.TabIndex = 110
        Me.OUT5V_NOT.TabStop = False
        Me.OUT5V_NOT.Visible = False
        '
        'OUT5V_OK
        '
        Me.OUT5V_OK.BackColor = System.Drawing.Color.Transparent
        Me.OUT5V_OK.BackgroundImage = Global.FlashedLOL.My.Resources.Res.Correct
        Me.OUT5V_OK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.OUT5V_OK.Location = New System.Drawing.Point(92, 76)
        Me.OUT5V_OK.Name = "OUT5V_OK"
        Me.OUT5V_OK.Size = New System.Drawing.Size(17, 17)
        Me.OUT5V_OK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.OUT5V_OK.TabIndex = 109
        Me.OUT5V_OK.TabStop = False
        Me.OUT5V_OK.Visible = False
        '
        'OUT5V
        '
        Me.OUT5V.AutoSize = True
        Me.OUT5V.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.OUT5V.Location = New System.Drawing.Point(30, 76)
        Me.OUT5V.MinimumSize = New System.Drawing.Size(45, 15)
        Me.OUT5V.Name = "OUT5V"
        Me.OUT5V.Size = New System.Drawing.Size(45, 15)
        Me.OUT5V.TabIndex = 109
        '
        'Label_5V
        '
        Me.Label_5V.AutoSize = True
        Me.Label_5V.Location = New System.Drawing.Point(6, 78)
        Me.Label_5V.Name = "Label_5V"
        Me.Label_5V.Size = New System.Drawing.Size(20, 13)
        Me.Label_5V.TabIndex = 109
        Me.Label_5V.Text = "5V"
        '
        'ErrorTest5V
        '
        Me.ErrorTest5V.BackColor = System.Drawing.Color.Transparent
        Me.ErrorTest5V.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ErrorTest5V.Image = Global.FlashedLOL.My.Resources.Res.R
        Me.ErrorTest5V.Location = New System.Drawing.Point(179, 94)
        Me.ErrorTest5V.Name = "ErrorTest5V"
        Me.ErrorTest5V.Size = New System.Drawing.Size(66, 53)
        Me.ErrorTest5V.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ErrorTest5V.TabIndex = 21
        Me.ErrorTest5V.TabStop = False
        Me.ErrorTest5V.Visible = False
        '
        'StatoTest5V
        '
        Me.StatoTest5V.BackColor = System.Drawing.Color.Transparent
        Me.StatoTest5V.BackgroundImage = Global.FlashedLOL.My.Resources.Res.Correct
        Me.StatoTest5V.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.StatoTest5V.Location = New System.Drawing.Point(199, 3)
        Me.StatoTest5V.Name = "StatoTest5V"
        Me.StatoTest5V.Size = New System.Drawing.Size(42, 39)
        Me.StatoTest5V.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.StatoTest5V.TabIndex = 15
        Me.StatoTest5V.TabStop = False
        Me.StatoTest5V.Visible = False
        '
        'Loading5V
        '
        Me.Loading5V.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Loading5V.Image = Global.FlashedLOL.My.Resources.Res.Loading
        Me.Loading5V.Location = New System.Drawing.Point(199, -1)
        Me.Loading5V.Name = "Loading5V"
        Me.Loading5V.Size = New System.Drawing.Size(46, 43)
        Me.Loading5V.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Loading5V.TabIndex = 13
        Me.Loading5V.TabStop = False
        Me.Loading5V.Visible = False
        '
        'Check5V
        '
        Me.Check5V.AutoSize = True
        Me.Check5V.Checked = True
        Me.Check5V.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Check5V.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Check5V.Location = New System.Drawing.Point(9, 9)
        Me.Check5V.Name = "Check5V"
        Me.Check5V.Size = New System.Drawing.Size(72, 22)
        Me.Check5V.TabIndex = 3
        Me.Check5V.Text = "Test 5V"
        Me.Check5V.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(206, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 18)
        Me.Label1.TabIndex = 122
        Me.Label1.Text = "CAN Communication"
        '
        'PanelAcc
        '
        Me.PanelAcc.BackColor = System.Drawing.Color.White
        Me.PanelAcc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelAcc.Controls.Add(Me.MsgTestAcc)
        Me.PanelAcc.Controls.Add(Me.accX)
        Me.PanelAcc.Controls.Add(Me.InfoACC)
        Me.PanelAcc.Controls.Add(Me.accY)
        Me.PanelAcc.Controls.Add(Me.accZ)
        Me.PanelAcc.Controls.Add(Me.ErrorTestACC)
        Me.PanelAcc.Controls.Add(Me.StatoTestAccellerometro)
        Me.PanelAcc.Controls.Add(Me.LoadingAcc)
        Me.PanelAcc.Controls.Add(Me.CheckAcc)
        Me.PanelAcc.Controls.Add(Me.LabelPWR)
        Me.PanelAcc.Controls.Add(Me.MovimentoETSDN)
        Me.PanelAcc.Controls.Add(Me.ETSDN_Statico)
        Me.PanelAcc.Location = New System.Drawing.Point(436, 313)
        Me.PanelAcc.Name = "PanelAcc"
        Me.PanelAcc.Size = New System.Drawing.Size(242, 148)
        Me.PanelAcc.TabIndex = 2
        '
        'MsgTestAcc
        '
        Me.MsgTestAcc.AutoSize = True
        Me.MsgTestAcc.ForeColor = System.Drawing.Color.Red
        Me.MsgTestAcc.Location = New System.Drawing.Point(27, 133)
        Me.MsgTestAcc.Name = "MsgTestAcc"
        Me.MsgTestAcc.Size = New System.Drawing.Size(16, 13)
        Me.MsgTestAcc.TabIndex = 130
        Me.MsgTestAcc.Text = "..."
        '
        'accX
        '
        Me.accX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.accX.Location = New System.Drawing.Point(5, 103)
        Me.accX.MinimumSize = New System.Drawing.Size(45, 15)
        Me.accX.Name = "accX"
        Me.accX.Size = New System.Drawing.Size(55, 21)
        Me.accX.TabIndex = 117
        '
        'InfoACC
        '
        Me.InfoACC.BackColor = System.Drawing.Color.Transparent
        Me.InfoACC.BackgroundImage = Global.FlashedLOL.My.Resources.Res.Info
        Me.InfoACC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.InfoACC.Location = New System.Drawing.Point(159, 5)
        Me.InfoACC.Name = "InfoACC"
        Me.InfoACC.Size = New System.Drawing.Size(23, 30)
        Me.InfoACC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.InfoACC.TabIndex = 122
        Me.InfoACC.TabStop = False
        '
        'accY
        '
        Me.accY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.accY.Location = New System.Drawing.Point(6, 69)
        Me.accY.MinimumSize = New System.Drawing.Size(45, 15)
        Me.accY.Name = "accY"
        Me.accY.Size = New System.Drawing.Size(55, 21)
        Me.accY.TabIndex = 116
        '
        'accZ
        '
        Me.accZ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.accZ.Location = New System.Drawing.Point(6, 34)
        Me.accZ.MinimumSize = New System.Drawing.Size(45, 15)
        Me.accZ.Name = "accZ"
        Me.accZ.Size = New System.Drawing.Size(55, 21)
        Me.accZ.TabIndex = 115
        '
        'ErrorTestACC
        '
        Me.ErrorTestACC.BackColor = System.Drawing.Color.Transparent
        Me.ErrorTestACC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ErrorTestACC.Image = Global.FlashedLOL.My.Resources.Res.R
        Me.ErrorTestACC.Location = New System.Drawing.Point(183, 94)
        Me.ErrorTestACC.Name = "ErrorTestACC"
        Me.ErrorTestACC.Size = New System.Drawing.Size(58, 53)
        Me.ErrorTestACC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ErrorTestACC.TabIndex = 23
        Me.ErrorTestACC.TabStop = False
        Me.ErrorTestACC.Visible = False
        '
        'StatoTestAccellerometro
        '
        Me.StatoTestAccellerometro.BackColor = System.Drawing.Color.Transparent
        Me.StatoTestAccellerometro.BackgroundImage = Global.FlashedLOL.My.Resources.Res.Correct
        Me.StatoTestAccellerometro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.StatoTestAccellerometro.Location = New System.Drawing.Point(199, 3)
        Me.StatoTestAccellerometro.Name = "StatoTestAccellerometro"
        Me.StatoTestAccellerometro.Size = New System.Drawing.Size(42, 39)
        Me.StatoTestAccellerometro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.StatoTestAccellerometro.TabIndex = 19
        Me.StatoTestAccellerometro.TabStop = False
        Me.StatoTestAccellerometro.Visible = False
        '
        'LoadingAcc
        '
        Me.LoadingAcc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.LoadingAcc.Image = Global.FlashedLOL.My.Resources.Res.Loading
        Me.LoadingAcc.Location = New System.Drawing.Point(199, -1)
        Me.LoadingAcc.Name = "LoadingAcc"
        Me.LoadingAcc.Size = New System.Drawing.Size(42, 43)
        Me.LoadingAcc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LoadingAcc.TabIndex = 15
        Me.LoadingAcc.TabStop = False
        Me.LoadingAcc.Visible = False
        '
        'CheckAcc
        '
        Me.CheckAcc.AutoSize = True
        Me.CheckAcc.Checked = True
        Me.CheckAcc.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckAcc.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckAcc.Location = New System.Drawing.Point(12, 9)
        Me.CheckAcc.Name = "CheckAcc"
        Me.CheckAcc.Size = New System.Drawing.Size(154, 22)
        Me.CheckAcc.TabIndex = 4
        Me.CheckAcc.Text = "Test accellerometro"
        Me.CheckAcc.UseVisualStyleBackColor = True
        '
        'MovimentoETSDN
        '
        Me.MovimentoETSDN.BackColor = System.Drawing.Color.Transparent
        Me.MovimentoETSDN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MovimentoETSDN.Image = Global.FlashedLOL.My.Resources.Res.ETSDN_collaudo1
        Me.MovimentoETSDN.Location = New System.Drawing.Point(69, 1)
        Me.MovimentoETSDN.Name = "MovimentoETSDN"
        Me.MovimentoETSDN.Size = New System.Drawing.Size(182, 170)
        Me.MovimentoETSDN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.MovimentoETSDN.TabIndex = 23
        Me.MovimentoETSDN.TabStop = False
        Me.MovimentoETSDN.Visible = False
        '
        'ETSDN_Statico
        '
        Me.ETSDN_Statico.BackColor = System.Drawing.Color.Transparent
        Me.ETSDN_Statico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ETSDN_Statico.Image = Global.FlashedLOL.My.Resources.Res.ETSDN_statico
        Me.ETSDN_Statico.Location = New System.Drawing.Point(60, 29)
        Me.ETSDN_Statico.Name = "ETSDN_Statico"
        Me.ETSDN_Statico.Size = New System.Drawing.Size(182, 140)
        Me.ETSDN_Statico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ETSDN_Statico.TabIndex = 118
        Me.ETSDN_Statico.TabStop = False
        Me.ETSDN_Statico.Visible = False
        '
        'CheckTutti
        '
        Me.CheckTutti.AutoSize = True
        Me.CheckTutti.Checked = True
        Me.CheckTutti.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckTutti.Location = New System.Drawing.Point(8, 77)
        Me.CheckTutti.Name = "CheckTutti"
        Me.CheckTutti.Size = New System.Drawing.Size(47, 17)
        Me.CheckTutti.TabIndex = 10
        Me.CheckTutti.Text = "Tutti"
        Me.CheckTutti.UseVisualStyleBackColor = True
        '
        'OpenLog
        '
        Me.OpenLog.BackColor = System.Drawing.Color.Orange
        Me.OpenLog.ForeColor = System.Drawing.Color.Black
        Me.OpenLog.Location = New System.Drawing.Point(735, 59)
        Me.OpenLog.Name = "OpenLog"
        Me.OpenLog.Size = New System.Drawing.Size(92, 29)
        Me.OpenLog.TabIndex = 136
        Me.OpenLog.Text = "OpenLog"
        Me.OpenLog.UseVisualStyleBackColor = False
        '
        'TestingSerial
        '
        Me.TestingSerial.BackColor = System.Drawing.Color.Transparent
        Me.TestingSerial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TestingSerial.Location = New System.Drawing.Point(627, 91)
        Me.TestingSerial.Name = "TestingSerial"
        Me.TestingSerial.Size = New System.Drawing.Size(199, 19)
        Me.TestingSerial.TabIndex = 137
        '
        'BarTestEtsdn
        '
        Me.BarTestEtsdn.BackColor = System.Drawing.SystemColors.ControlText
        Me.BarTestEtsdn.Enabled = False
        Me.BarTestEtsdn.ForeColor = System.Drawing.Color.Salmon
        Me.BarTestEtsdn.Location = New System.Drawing.Point(8, 112)
        Me.BarTestEtsdn.Margin = New System.Windows.Forms.Padding(2)
        Me.BarTestEtsdn.Maximum = 70
        Me.BarTestEtsdn.Name = "BarTestEtsdn"
        Me.BarTestEtsdn.Size = New System.Drawing.Size(818, 26)
        Me.BarTestEtsdn.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.BarTestEtsdn.TabIndex = 139
        '
        'ButtonErrorView
        '
        Me.ButtonErrorView.BackColor = System.Drawing.Color.Red
        Me.ButtonErrorView.Location = New System.Drawing.Point(636, 59)
        Me.ButtonErrorView.Name = "ButtonErrorView"
        Me.ButtonErrorView.Size = New System.Drawing.Size(96, 29)
        Me.ButtonErrorView.TabIndex = 144
        Me.ButtonErrorView.Text = "Visualizza Errori"
        Me.ButtonErrorView.UseVisualStyleBackColor = False
        Me.ButtonErrorView.Visible = False
        '
        'LabelClock
        '
        Me.LabelClock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelClock.Location = New System.Drawing.Point(8, 94)
        Me.LabelClock.Name = "LabelClock"
        Me.LabelClock.Size = New System.Drawing.Size(158, 16)
        Me.LabelClock.TabIndex = 145
        '
        'ErrorTestCAN
        '
        Me.ErrorTestCAN.BackColor = System.Drawing.Color.Transparent
        Me.ErrorTestCAN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ErrorTestCAN.Image = Global.FlashedLOL.My.Resources.Res.R
        Me.ErrorTestCAN.Location = New System.Drawing.Point(261, 42)
        Me.ErrorTestCAN.Name = "ErrorTestCAN"
        Me.ErrorTestCAN.Size = New System.Drawing.Size(36, 33)
        Me.ErrorTestCAN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ErrorTestCAN.TabIndex = 22
        Me.ErrorTestCAN.TabStop = False
        Me.ErrorTestCAN.Visible = False
        '
        'StatoTestCAN
        '
        Me.StatoTestCAN.BackColor = System.Drawing.Color.Transparent
        Me.StatoTestCAN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.StatoTestCAN.Image = Global.FlashedLOL.My.Resources.Res.CorrectSenzaSfondo
        Me.StatoTestCAN.Location = New System.Drawing.Point(340, 22)
        Me.StatoTestCAN.Name = "StatoTestCAN"
        Me.StatoTestCAN.Size = New System.Drawing.Size(29, 20)
        Me.StatoTestCAN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.StatoTestCAN.TabIndex = 17
        Me.StatoTestCAN.TabStop = False
        Me.StatoTestCAN.Visible = False
        '
        'GifCan
        '
        Me.GifCan.BackColor = System.Drawing.Color.Transparent
        Me.GifCan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.GifCan.Image = Global.FlashedLOL.My.Resources.Res.SendMessage
        Me.GifCan.Location = New System.Drawing.Point(245, 42)
        Me.GifCan.Name = "GifCan"
        Me.GifCan.Size = New System.Drawing.Size(67, 29)
        Me.GifCan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GifCan.TabIndex = 123
        Me.GifCan.TabStop = False
        Me.GifCan.Visible = False
        '
        'ErrorInfo
        '
        Me.ErrorInfo.BackColor = System.Drawing.Color.Transparent
        Me.ErrorInfo.BackgroundImage = Global.FlashedLOL.My.Resources.Res.Info
        Me.ErrorInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ErrorInfo.Location = New System.Drawing.Point(779, 8)
        Me.ErrorInfo.Name = "ErrorInfo"
        Me.ErrorInfo.Size = New System.Drawing.Size(48, 47)
        Me.ErrorInfo.TabIndex = 140
        Me.ErrorInfo.UseVisualStyleBackColor = False
        '
        'StartEtsdn
        '
        Me.StartEtsdn.BackColor = System.Drawing.Color.Transparent
        Me.StartEtsdn.BackgroundImage = Global.FlashedLOL.My.Resources.Res.ButtonStart
        Me.StartEtsdn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.StartEtsdn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.StartEtsdn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.StartEtsdn.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartEtsdn.Location = New System.Drawing.Point(6, 6)
        Me.StartEtsdn.Name = "StartEtsdn"
        Me.StartEtsdn.Size = New System.Drawing.Size(160, 69)
        Me.StartEtsdn.TabIndex = 128
        Me.StartEtsdn.Text = "Start Test"
        Me.StartEtsdn.UseVisualStyleBackColor = False
        '
        'StopEtsdn
        '
        Me.StopEtsdn.BackColor = System.Drawing.Color.Transparent
        Me.StopEtsdn.BackgroundImage = Global.FlashedLOL.My.Resources.Res.ButtonStop
        Me.StopEtsdn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.StopEtsdn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.StopEtsdn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.StopEtsdn.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StopEtsdn.Location = New System.Drawing.Point(6, 8)
        Me.StopEtsdn.Name = "StopEtsdn"
        Me.StopEtsdn.Size = New System.Drawing.Size(160, 69)
        Me.StopEtsdn.TabIndex = 129
        Me.StopEtsdn.Text = "Stop Test"
        Me.StopEtsdn.UseVisualStyleBackColor = False
        '
        'CollaudoETSDN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(813, 473)
        Me.Controls.Add(Me.ErrorTestCAN)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StatoTestCAN)
        Me.Controls.Add(Me.GifCan)
        Me.Controls.Add(Me.LabelClock)
        Me.Controls.Add(Me.ButtonErrorView)
        Me.Controls.Add(Me.ErrorInfo)
        Me.Controls.Add(Me.BarTestEtsdn)
        Me.Controls.Add(Me.TestingSerial)
        Me.Controls.Add(Me.OpenLog)
        Me.Controls.Add(Me.StartEtsdn)
        Me.Controls.Add(Me.StopEtsdn)
        Me.Controls.Add(Me.CheckTutti)
        Me.Controls.Add(Me.PanelAlimentazione)
        Me.Controls.Add(Me.PanelIngressi)
        Me.Controls.Add(Me.PanelRele)
        Me.Controls.Add(Me.Panel5V)
        Me.Controls.Add(Me.PanelAcc)
        Me.DoubleBuffered = True
        Me.Name = "CollaudoETSDN"
        Me.RightToLeftLayout = True
        Me.Text = "ETSDN"
        Me.PanelAlimentazione.ResumeLayout(False)
        Me.PanelAlimentazione.PerformLayout()
        CType(Me.InfoPWR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorTestPWR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatoTestAlimentazione, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PWR_NOT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PWR_OK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoadingPWR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelRele.ResumeLayout(False)
        Me.PanelRele.PerformLayout()
        CType(Me.InfoRL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatotestRele, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RL3_NOT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RL2_NOT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RL1_NOT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RL1_OK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RL3_OK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RL2_OK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorTestRL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoadingRL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelIngressi.ResumeLayout(False)
        Me.PanelIngressi.PerformLayout()
        CType(Me.InfoIP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IN2_NOT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANA10V_NOT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IN1_NOT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANA5V_NOT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANA10V_OK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IP2_NOT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANA5V_OK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IP1_NOT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IP1_OK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IN2_OK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IN1_OK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IP2_OK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorTestIP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatoTestIngressi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoadingIP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5V.ResumeLayout(False)
        Me.Panel5V.PerformLayout()
        CType(Me.Info5V, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OUT5V_NOT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OUT5V_OK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorTest5V, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatoTest5V, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Loading5V, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelAcc.ResumeLayout(False)
        Me.PanelAcc.PerformLayout()
        CType(Me.InfoACC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorTestACC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatoTestAccellerometro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoadingAcc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MovimentoETSDN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ETSDN_Statico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorTestCAN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatoTestCAN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GifCan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelAlimentazione As Panel
    Friend WithEvents PanelRele As Panel
    Friend WithEvents PanelIngressi As Panel
    Friend WithEvents Panel5V As Panel
    Friend WithEvents PanelAcc As Panel
    Friend WithEvents CheckPWR As CheckBox
    Friend WithEvents CheckRL As CheckBox
    Friend WithEvents CheckIP As CheckBox
    Friend WithEvents Check5V As CheckBox
    Friend WithEvents CheckAcc As CheckBox
    Friend WithEvents CheckTutti As CheckBox
    Friend WithEvents LoadingPWR As PictureBox
    Friend WithEvents LoadingRL As PictureBox
    Friend WithEvents LoadingIP As PictureBox
    Friend WithEvents StatoTest5V As PictureBox
    Friend WithEvents StatoTestAlimentazione As PictureBox
    Friend WithEvents StatotestRele As PictureBox
    Friend WithEvents StatoTestIngressi As PictureBox
    Friend WithEvents StatoTestCAN As PictureBox
    Friend WithEvents ErrorTestPWR As PictureBox
    Friend WithEvents ErrorTestRL As PictureBox
    Friend WithEvents ErrorTestIP As PictureBox
    Friend WithEvents ErrorTest5V As PictureBox
    Friend WithEvents ErrorTestCAN As PictureBox
    Friend WithEvents LabelTensioneIn As Label
    Friend WithEvents PWR_OK As PictureBox
    Friend WithEvents LabelPWR As Label
    Friend WithEvents Amps As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents IN2_OK As PictureBox
    Friend WithEvents IN1_OK As PictureBox
    Friend WithEvents IP2_OK As PictureBox
    Friend WithEvents IP1_NOT As PictureBox
    Friend WithEvents Label_IN2 As Label
    Friend WithEvents Label_IN1 As Label
    Friend WithEvents Label_IP2 As Label
    Friend WithEvents Label_IP1 As Label
    Friend WithEvents PWR_NOT As PictureBox
    Friend WithEvents IN2_NOT As PictureBox
    Friend WithEvents IN1_NOT As PictureBox
    Friend WithEvents IP2_NOT As PictureBox
    Friend WithEvents RL3_NOT As PictureBox
    Friend WithEvents RL2_NOT As PictureBox
    Friend WithEvents RL1_NOT As PictureBox
    Friend WithEvents RL1_OK As PictureBox
    Friend WithEvents RL3_OK As PictureBox
    Friend WithEvents RL2_OK As PictureBox
    Friend WithEvents Label_RL3 As Label
    Friend WithEvents Label_RL2 As Label
    Friend WithEvents Label_RL1 As Label
    Friend WithEvents OUT5V_NOT As PictureBox
    Friend WithEvents OUT5V_OK As PictureBox
    Friend WithEvents OUT5V As Label
    Friend WithEvents Label_5V As Label
    Friend WithEvents ANA10V_NOT As PictureBox
    Friend WithEvents ANA5V_NOT As PictureBox
    Friend WithEvents ANA10V_OK As PictureBox
    Friend WithEvents ANA5V_OK As PictureBox
    Friend WithEvents ANAVolt10 As Label
    Friend WithEvents ANAVolt5 As Label
    Friend WithEvents Label_ANA10V As Label
    Friend WithEvents Label_ANA5V As Label
    Friend WithEvents MovimentoETSDN As PictureBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents LoadingAcc As PictureBox
    Friend WithEvents ErrorTestACC As PictureBox
    Friend WithEvents Loading5V As PictureBox
    Friend WithEvents StatoTestAccellerometro As PictureBox
    Friend WithEvents IP1_OK As PictureBox
    Friend WithEvents StartEtsdn As Button
    Friend WithEvents StopEtsdn As Button
    Friend WithEvents accZ As Label
    Friend WithEvents accX As Label
    Friend WithEvents accY As Label
    Friend WithEvents ETSDN_Statico As PictureBox
    Friend WithEvents MsgTestAcc As Label
    Friend WithEvents OpenLog As Button
    Friend WithEvents InfoPWR As PictureBox
    Friend WithEvents InfoRL As PictureBox
    Friend WithEvents InfoIP As PictureBox
    Friend WithEvents Info5V As PictureBox
    Friend WithEvents InfoACC As PictureBox
    Friend WithEvents TestingSerial As Label
    Friend WithEvents BarTestEtsdn As ProgressBar
    Friend WithEvents ErrorInfo As Button
    Friend WithEvents ButtonErrorView As Button
    Friend WithEvents LabelClock As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelRL3 As Label
    Friend WithEvents LabelRL2 As Label
    Friend WithEvents LabelRL1 As Label
    Friend WithEvents GifCan As PictureBox
End Class
