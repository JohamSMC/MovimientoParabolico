<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox_x0 = New System.Windows.Forms.TextBox()
        Me.TextBox_y0 = New System.Windows.Forms.TextBox()
        Me.TextBox_vi = New System.Windows.Forms.TextBox()
        Me.TextBox_gravedad = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox_vTimer = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label_amp = New System.Windows.Forms.Label()
        Me.Label_amf = New System.Windows.Forms.Label()
        Me.Label_tvp = New System.Windows.Forms.Label()
        Me.Label_tvf = New System.Windows.Forms.Label()
        Me.Label_vt = New System.Windows.Forms.Label()
        Me.Label_yt = New System.Windows.Forms.Label()
        Me.Label_xt = New System.Windows.Forms.Label()
        Me.suelo = New System.Windows.Forms.PictureBox()
        Me.masa = New System.Windows.Forms.PictureBox()
        Me.Button_start = New System.Windows.Forms.Button()
        Me.Button_restart = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Numeric_Timer = New System.Windows.Forms.NumericUpDown()
        Me.TextBox_angulo = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        CType(Me.suelo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.masa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Numeric_Timer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox_angulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "x0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(46, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "y0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(200, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Angulo °"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(46, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(22, 16)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Vi"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(193, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Gravedad"
        '
        'TextBox_x0
        '
        Me.TextBox_x0.Location = New System.Drawing.Point(75, 69)
        Me.TextBox_x0.Name = "TextBox_x0"
        Me.TextBox_x0.Size = New System.Drawing.Size(62, 20)
        Me.TextBox_x0.TabIndex = 7
        '
        'TextBox_y0
        '
        Me.TextBox_y0.Location = New System.Drawing.Point(75, 95)
        Me.TextBox_y0.Name = "TextBox_y0"
        Me.TextBox_y0.Size = New System.Drawing.Size(61, 20)
        Me.TextBox_y0.TabIndex = 8
        '
        'TextBox_vi
        '
        Me.TextBox_vi.Location = New System.Drawing.Point(75, 121)
        Me.TextBox_vi.Name = "TextBox_vi"
        Me.TextBox_vi.Size = New System.Drawing.Size(62, 20)
        Me.TextBox_vi.TabIndex = 9
        '
        'TextBox_gravedad
        '
        Me.TextBox_gravedad.Location = New System.Drawing.Point(271, 70)
        Me.TextBox_gravedad.Name = "TextBox_gravedad"
        Me.TextBox_gravedad.Size = New System.Drawing.Size(62, 20)
        Me.TextBox_gravedad.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(148, 122)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 16)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Velocidad Timer"
        '
        'TextBox_vTimer
        '
        Me.TextBox_vTimer.Location = New System.Drawing.Point(271, 122)
        Me.TextBox_vTimer.Name = "TextBox_vTimer"
        Me.TextBox_vTimer.Size = New System.Drawing.Size(62, 20)
        Me.TextBox_vTimer.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(137, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 24)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "ENTRADAS"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(619, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 24)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "SALIDAS"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(654, 60)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 16)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "X(t)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(652, 89)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 16)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Y(t)"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(651, 116)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(35, 16)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "V(t)"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(605, 143)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 16)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Tv Formula"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label15.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(608, 170)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(81, 16)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Tv Proceso"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label16.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(586, 198)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(103, 16)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "Ymax Formula"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label17.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(589, 228)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(100, 16)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "Ymax Proceso"
        '
        'Label_amp
        '
        Me.Label_amp.AutoSize = True
        Me.Label_amp.BackColor = System.Drawing.Color.White
        Me.Label_amp.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_amp.Location = New System.Drawing.Point(729, 228)
        Me.Label_amp.Name = "Label_amp"
        Me.Label_amp.Size = New System.Drawing.Size(17, 16)
        Me.Label_amp.TabIndex = 24
        Me.Label_amp.Text = "0"
        '
        'Label_amf
        '
        Me.Label_amf.AutoSize = True
        Me.Label_amf.BackColor = System.Drawing.Color.White
        Me.Label_amf.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_amf.Location = New System.Drawing.Point(729, 198)
        Me.Label_amf.Name = "Label_amf"
        Me.Label_amf.Size = New System.Drawing.Size(17, 16)
        Me.Label_amf.TabIndex = 25
        Me.Label_amf.Text = "0"
        '
        'Label_tvp
        '
        Me.Label_tvp.AutoSize = True
        Me.Label_tvp.BackColor = System.Drawing.Color.White
        Me.Label_tvp.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_tvp.Location = New System.Drawing.Point(729, 170)
        Me.Label_tvp.Name = "Label_tvp"
        Me.Label_tvp.Size = New System.Drawing.Size(17, 16)
        Me.Label_tvp.TabIndex = 26
        Me.Label_tvp.Text = "0"
        '
        'Label_tvf
        '
        Me.Label_tvf.AutoSize = True
        Me.Label_tvf.BackColor = System.Drawing.Color.White
        Me.Label_tvf.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_tvf.Location = New System.Drawing.Point(729, 143)
        Me.Label_tvf.Name = "Label_tvf"
        Me.Label_tvf.Size = New System.Drawing.Size(17, 16)
        Me.Label_tvf.TabIndex = 27
        Me.Label_tvf.Text = "0"
        '
        'Label_vt
        '
        Me.Label_vt.AutoSize = True
        Me.Label_vt.BackColor = System.Drawing.Color.White
        Me.Label_vt.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_vt.Location = New System.Drawing.Point(729, 116)
        Me.Label_vt.Name = "Label_vt"
        Me.Label_vt.Size = New System.Drawing.Size(17, 16)
        Me.Label_vt.TabIndex = 28
        Me.Label_vt.Text = "0"
        '
        'Label_yt
        '
        Me.Label_yt.AutoSize = True
        Me.Label_yt.BackColor = System.Drawing.Color.White
        Me.Label_yt.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_yt.Location = New System.Drawing.Point(729, 89)
        Me.Label_yt.Name = "Label_yt"
        Me.Label_yt.Size = New System.Drawing.Size(17, 16)
        Me.Label_yt.TabIndex = 29
        Me.Label_yt.Text = "0"
        '
        'Label_xt
        '
        Me.Label_xt.AutoSize = True
        Me.Label_xt.BackColor = System.Drawing.Color.White
        Me.Label_xt.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_xt.Location = New System.Drawing.Point(729, 60)
        Me.Label_xt.Name = "Label_xt"
        Me.Label_xt.Size = New System.Drawing.Size(17, 16)
        Me.Label_xt.TabIndex = 30
        Me.Label_xt.Text = "0"
        '
        'suelo
        '
        Me.suelo.BackColor = System.Drawing.Color.SaddleBrown
        Me.suelo.Location = New System.Drawing.Point(12, 536)
        Me.suelo.Name = "suelo"
        Me.suelo.Size = New System.Drawing.Size(960, 22)
        Me.suelo.TabIndex = 31
        Me.suelo.TabStop = False
        '
        'masa
        '
        Me.masa.BackColor = System.Drawing.Color.DarkSlateGray
        Me.masa.Location = New System.Drawing.Point(12, 464)
        Me.masa.Name = "masa"
        Me.masa.Size = New System.Drawing.Size(40, 40)
        Me.masa.TabIndex = 32
        Me.masa.TabStop = False
        '
        'Button_start
        '
        Me.Button_start.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button_start.Font = New System.Drawing.Font("Maiandra GD", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_start.Location = New System.Drawing.Point(394, 52)
        Me.Button_start.Name = "Button_start"
        Me.Button_start.Size = New System.Drawing.Size(138, 37)
        Me.Button_start.TabIndex = 33
        Me.Button_start.Text = "INICIAR"
        Me.Button_start.UseVisualStyleBackColor = False
        '
        'Button_restart
        '
        Me.Button_restart.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button_restart.Font = New System.Drawing.Font("Maiandra GD", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_restart.Location = New System.Drawing.Point(394, 122)
        Me.Button_restart.Name = "Button_restart"
        Me.Button_restart.Size = New System.Drawing.Size(138, 37)
        Me.Button_restart.TabIndex = 34
        Me.Button_restart.Text = "REINICIAR"
        Me.Button_restart.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 281)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(960, 277)
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(33, 52)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(322, 134)
        Me.PictureBox2.TabIndex = 36
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PictureBox3.Location = New System.Drawing.Point(570, 52)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(218, 209)
        Me.PictureBox3.TabIndex = 37
        Me.PictureBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(164, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 16)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Tiempo Timer"
        '
        'Numeric_Timer
        '
        Me.Numeric_Timer.DecimalPlaces = 2
        Me.Numeric_Timer.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.Numeric_Timer.Location = New System.Drawing.Point(271, 148)
        Me.Numeric_Timer.Maximum = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.Numeric_Timer.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.Numeric_Timer.Name = "Numeric_Timer"
        Me.Numeric_Timer.Size = New System.Drawing.Size(62, 20)
        Me.Numeric_Timer.TabIndex = 39
        Me.Numeric_Timer.Value = New Decimal(New Integer() {5, 0, 0, 131072})
        '
        'TextBox_angulo
        '
        Me.TextBox_angulo.Location = New System.Drawing.Point(271, 96)
        Me.TextBox_angulo.Maximum = New Decimal(New Integer() {90, 0, 0, 0})
        Me.TextBox_angulo.Name = "TextBox_angulo"
        Me.TextBox_angulo.Size = New System.Drawing.Size(62, 20)
        Me.TextBox_angulo.TabIndex = 40
        Me.TextBox_angulo.Value = New Decimal(New Integer() {45, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Maiandra GD", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(814, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 66)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "By:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Joham Medina" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hernan Cadena"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(818, 136)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(148, 125)
        Me.PictureBox4.TabIndex = 42
        Me.PictureBox4.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox_angulo)
        Me.Controls.Add(Me.Numeric_Timer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_restart)
        Me.Controls.Add(Me.Button_start)
        Me.Controls.Add(Me.masa)
        Me.Controls.Add(Me.suelo)
        Me.Controls.Add(Me.Label_xt)
        Me.Controls.Add(Me.Label_yt)
        Me.Controls.Add(Me.Label_vt)
        Me.Controls.Add(Me.Label_tvf)
        Me.Controls.Add(Me.Label_tvp)
        Me.Controls.Add(Me.Label_amf)
        Me.Controls.Add(Me.Label_amp)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox_vTimer)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox_gravedad)
        Me.Controls.Add(Me.TextBox_vi)
        Me.Controls.Add(Me.TextBox_y0)
        Me.Controls.Add(Me.TextBox_x0)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.MaximumSize = New System.Drawing.Size(1000, 600)
        Me.MinimumSize = New System.Drawing.Size(1000, 600)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form1"
        CType(Me.suelo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.masa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Numeric_Timer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox_angulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox_x0 As TextBox
    Friend WithEvents TextBox_y0 As TextBox
    Friend WithEvents TextBox_vi As TextBox
    Friend WithEvents TextBox_gravedad As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox_vTimer As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label_amp As Label
    Friend WithEvents Label_amf As Label
    Friend WithEvents Label_tvp As Label
    Friend WithEvents Label_tvf As Label
    Friend WithEvents Label_vt As Label
    Friend WithEvents Label_yt As Label
    Friend WithEvents Label_xt As Label
    Friend WithEvents suelo As PictureBox
    Friend WithEvents masa As PictureBox
    Friend WithEvents Button_start As Button
    Friend WithEvents Button_restart As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Numeric_Timer As NumericUpDown
    Friend WithEvents TextBox_angulo As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox4 As PictureBox
End Class
