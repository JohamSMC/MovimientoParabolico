Public Class Form1
    Dim y0 As Double      'Posicion Inicial en el eje y'
    Dim x0 As Double      'Posicion Inicial en el eje x'
    Dim v0 As Double      'Velocidad inicial
    Dim angulo As Double  'Angulo de tiro
    Dim g As Double       'Gravedad del sistema
    Dim t As Double       'Tiempo dado por timer'
    Dim y As Double       'Posicion vertical de la masa en funcion del tiempo
    Dim x As Double       'Posicion horizontal de la masa en funcion del tiempo
    Dim ymaxF As Double   'Altura maxima alcanzada por el objeto
    Dim ymaxP As Double   'Altura maxima alcanzada por el objeto en el proceso
    Dim v As Double       'Velocidad de la masa en funcion del tiempo
    Dim v0x As Double     'Velocidad vectorial inicial en el eje x
    Dim v0y As Double     'Velocidad vectorial inicial en el eje y
    Dim tvf As Double     'Tiempo de vuelo caculado con formula
    Dim tvp As Double     'Tiempo de vuelo calculado con la ejecución del proceso
    Dim cero As Integer   'Refencia del PictureBox Suelo'
    Dim alto As Integer   'Refencia del PictureBox Tamaño del Objeto(alto)'
    Dim coorX As Integer  'Refencia de la coordenada X del Suelo'
    Dim tvp1 As Double    'Tiempo de vuelo calculado con la ejecución del proceso en primer arco
    Dim tvp2 As Double    'Tiempo de vuelo calculado con la ejecución del proceso en segundo arco
    Dim tvp3 As Double    'Tiempo de vuelo calculado con la ejecución del proceso en tercer arco
    Dim tvf1 As Double    'Tiempo de vuelo calculado con la formula del proceso en primer arco
    Dim tvf2 As Double    'Tiempo de vuelo calculado con la formula del proceso en segundo arco
    Dim tvf3 As Double    'Tiempo de vuelo calculado con la formula del proceso en tercer arco
    Dim iteracion As Integer
    Dim numericTimer As Double
    Dim vX As Double
    Dim vY As Double
    Dim check As Boolean

    'Posicionar la masa segun el dato de posicion vertical de entrada
    Private Sub TextBox_y0_TextChanged(sender As Object, e As EventArgs) Handles TextBox_y0.TextChanged
        If Val(TextBox_y0.Text) < 0 Then
            TextBox_y0.Text = "0"
        End If
        masa.Top = cero - alto - Val(TextBox_y0.Text)
    End Sub

    'Posicionar la masa segun el dato de posicion horizontal de entrada
    Private Sub TextBox_x0_TextChanged(sender As Object, e As EventArgs) Handles TextBox_x0.TextChanged
        If Val(TextBox_x0.Text) < 0 Then
            TextBox_x0.Text = "0"
        End If
        masa.Left = coorX + Val(TextBox_x0.Text)
    End Sub

    Private Sub TextBox_vi_TextChanged(sender As Object, e As EventArgs) Handles TextBox_vi.TextChanged
        If Val(TextBox_vi.Text) < 0 Then
            TextBox_vi.Text = "0"
        End If
    End Sub

    'Resetear todos los datos de entrada y salida del sistema
    Private Sub Button_restart_Click(sender As Object, e As EventArgs) Handles Button_restart.Click

        Button_start.Enabled = True

        resetearLabelsSalida()
        resetearLabelsEntrada()
        resetearVariablesGlobales()
        resetearEntradas()
        pararReloj()
        posicionarMasa(0, 0)


        'Resetar graficas'
        Form2.ChartX.Series(0).Points.Clear()
        Form2.ChartY.Series(0).Points.Clear()
        Form2.ChartVx.Series(0).Points.Clear()
        Form2.ChartVy.Series(0).Points.Clear()

        Form2.Close()

    End Sub

    'Constructor del formulario donde se inicializan valores de posicion y constantes
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cero = suelo.Location.Y
        alto = masa.Height
        coorX = suelo.Location.X
        TextBox_gravedad.Text = "9.8"
        TextBox_vTimer.Text = "1"
        t = 0
        Numeric_Timer.Value = 0.05
        TextBox_angulo.Value = 45
        check = True
        posicionarMasa(0, 0)
    End Sub

    Private Sub Button_start_Click(sender As Object, e As EventArgs) Handles Button_start.Click
        Button_start.Enabled = False


        ' Validar valores no negativos para la velocidad, posición X y posición Y '
        If Val(TextBox_y0.Text) < 0 Then
            TextBox_y0.Text = "0"
        End If

        If Val(TextBox_x0.Text) < 0 Then
            TextBox_x0.Text = "0"
        End If

        If Val(TextBox_vi.Text) < 0 Then
            TextBox_vi.Text = "0"
        End If

        iniciarEntradas(Val(TextBox_x0.Text),
                        Val(TextBox_y0.Text),
                        Val(TextBox_vi.Text),
                        Val(TextBox_angulo.Value),
                        Val(TextBox_gravedad.Text))
        Timer1.Interval = Val(TextBox_vTimer.Text)
        numericTimer = Val(Numeric_Timer.Value)
        iteracion = 1
        iniciarReloj()

        ' Mostra Formulario de graficas '
        Form2.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        x = x0 + (v0 * Math.Cos(angulo) * t)
        y = y0 + (v0 * Math.Sin(angulo) * t) - (0.5 * g * Math.Pow(t, 2))
        vX = v0x
        vY = v0y - (g * t)
        v = velocidadR(vX, vY)
        tvf = tiempoVueloFormula()

        tvp = t

        ' Añadir y dibujar puntos en graficas '
        anadirPuntosGraficas(x, y, vX, vY, t, iteracion)

        If vY <= 0 And check Then
            check = False
            ymaxF = alturaMaximaFormula()
            ymaxP = y
            Dim pointMax As Int32 = Form2.ChartY.Series(0).Points.AddXY(t, y)
            Form2.ChartY.Series(0).Points.Item(pointMax).Label = Str(Math.Round(y, 1)) + " ;" + Str(Math.Round(t, 1))
        End If
        posicionarMasa(x, y)
        pintarResultados()
        If y < 0 Then
            If iteracion = 1 Then
                v0x = vX
                v0y = vY / 2
                resetearLabelsSalida()
                v0 = velocidadR(v0x, v0y)
                tvf1 = Math.Round(tvf, 2)
                tvp1 = Math.Round(t, 2)
                t = 0
                tvf = 0
                tvp = tvp1
                iniciarEntradas(x, 0, v0, Val(TextBox_angulo.Text), g)
                iteracion += 1

            ElseIf iteracion = 2 Then
                v0x = vX
                v0y = vY / 2
                resetearLabelsSalida()
                v0 = velocidadR(v0x, v0y)
                v0 = Math.Round(v / 2, 2)
                tvf2 = Math.Round(tvf1 + tvf, 2)
                tvp2 = Math.Round(tvp1 + t, 2)
                t = 0
                tvf = 0
                tvp = tvp2
                iniciarEntradas(x, 0, v0, Val(TextBox_angulo.Text), g)
                iteracion += 1
            ElseIf iteracion = 3 Then
                tvp3 = Math.Round(tvp2 + t, 2)
                tvf3 = Math.Round(tvf2 + tvf, 2)
                tvf = Math.Round(tvf3, 2)
                tvp = Math.Round(tvp3, 2)
                pintarResultados()
                pararReloj()
            End If

        End If
        t = t + numericTimer
    End Sub
    Private Function velocidadR(vx As Double, vy As Double)
        Dim vR As Double = Math.Sqrt(Math.Pow(vx, 2) + Math.Pow(vy, 2))
        Return vR
    End Function
    Private Sub pintarResultados()
        Label_xt.Text = Math.Round(x, 2)
        Label_yt.Text = Math.Round(y, 2)
        Label_vt.Text = Math.Round(v, 2)
        Label_tvf.Text = Math.Round(tvf, 2)
        Label_tvp.Text = Math.Round(tvp, 2)
        Label_amf.Text = Math.Round(ymaxF, 2)
        Label_amp.Text = Math.Round(ymaxP, 2)
    End Sub
    Private Function alturaMaximaFormula()
        Return ((Math.Pow(v0y, 2) / (2 * g)) + y0)

    End Function
    Private Sub iniciarEntradas(x0i As Double, y0i As Double, v0i As Double, anguloi As Double, gi As Double)
        x0 = x0i
        y0 = y0i
        v0 = v0i
        angulo = anguloi * (Math.PI / 180)
        v0x = v0 * Math.Cos(angulo)
        v0y = v0 * Math.Sin(angulo)
        g = gi
    End Sub
    Private Sub posicionarMasa(x As Double, y As Double)
        masa.Location = New Point(x + coorX, cero - alto - y)
    End Sub
    Function tiempoVueloFormula() As Double
        Dim a As Double = 0.5 * g
        Dim b As Double = -1 * v0y
        Dim c As Double = -1 * y0
        Dim tvf1 As Double = ((-1 * b) + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a)
        Dim tvf2 As Double = ((-1 * b) - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a)
        'Asignar el valor positiva de la ecuacion a la variable de tiempo de vuelo
        If (tvf1 > 0) Then
            Return tvf1
        End If
        Return tvf2
    End Function

    Private Sub anadirPuntosGraficas(x As Double, y As Double, vx As Double, vy As Double, t As Double, iteracion As Double)
        If iteracion = 2 Then
            t += tvp1
        ElseIf iteracion = 3 Then
            t += tvp2
        End If
        Form2.ChartX.Series(0).Points.AddXY(t, x)
        Form2.ChartY.Series(0).Points.AddXY(t, y)
        Form2.ChartVx.Series(0).Points.AddXY(t, vx)
        Form2.ChartVy.Series(0).Points.AddXY(t, vy)

    End Sub

    Private Sub resetearLabelsSalida()
        Label_amf.Text = 0
        Label_amp.Text = 0
        Label_tvf.Text = 0
        Label_tvp.Text = 0
        Label_vt.Text = 0
        Label_yt.Text = 0
        Label_xt.Text = 0
    End Sub
    Private Sub resetearLabelsEntrada()
        TextBox_gravedad.Text = "9.8"
        TextBox_x0.Text = ""
        TextBox_y0.Text = ""
        TextBox_angulo.Value = 45
        Numeric_Timer.Value = 0.05
        TextBox_vi.Text = ""
        TextBox_vTimer.Text = "1"

    End Sub
    Private Sub resetearVariablesGlobales()
        x = 0
        y = 0
        v = 0
        t = 0
        tvf = 0
        tvp = 0
        vX = 0
        vY = 0
        ymaxF = 0
        ymaxP = 0
        angulo = 0
        g = 0
        check = True
    End Sub
    Private Sub resetearEntradas()
        x0 = 0
        y0 = 0
        v0 = 0
        v0x = 0
        v0y = 0
    End Sub
    Private Sub iniciarReloj()
        Timer1.Enabled = True
    End Sub
    Private Sub pararReloj()
        Timer1.Enabled = False
    End Sub

End Class