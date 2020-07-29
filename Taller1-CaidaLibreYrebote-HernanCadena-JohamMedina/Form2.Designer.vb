<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim ChartArea5 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend5 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea6 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend6 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea7 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend7 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series7 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea8 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend8 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series8 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.ChartX = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ChartY = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ChartVx = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ChartVy = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.ChartX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartVx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartVy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChartX
        '
        Me.ChartX.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        ChartArea5.AxisX.MajorGrid.Enabled = False
        ChartArea5.AxisY.MajorGrid.Enabled = False
        ChartArea5.AxisY.Minimum = 0R
        ChartArea5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        ChartArea5.Name = "ChartArea1"
        Me.ChartX.ChartAreas.Add(ChartArea5)
        Legend5.Name = "Legend1"
        Me.ChartX.Legends.Add(Legend5)
        Me.ChartX.Location = New System.Drawing.Point(10, 80)
        Me.ChartX.Name = "ChartX"
        Series5.BorderWidth = 3
        Series5.ChartArea = "ChartArea1"
        Series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series5.Color = System.Drawing.Color.Black
        Series5.Legend = "Legend1"
        Series5.Name = "X(t)"
        Me.ChartX.Series.Add(Series5)
        Me.ChartX.Size = New System.Drawing.Size(450, 200)
        Me.ChartX.TabIndex = 0
        Me.ChartX.Text = "Chart1"
        '
        'ChartY
        '
        Me.ChartY.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        ChartArea6.AxisX.MajorGrid.Enabled = False
        ChartArea6.AxisY.MajorGrid.Enabled = False
        ChartArea6.AxisY.Minimum = 0R
        ChartArea6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        ChartArea6.Name = "ChartArea1"
        Me.ChartY.ChartAreas.Add(ChartArea6)
        Legend6.Name = "Legend1"
        Me.ChartY.Legends.Add(Legend6)
        Me.ChartY.Location = New System.Drawing.Point(500, 80)
        Me.ChartY.Name = "ChartY"
        Series6.BorderWidth = 3
        Series6.ChartArea = "ChartArea1"
        Series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series6.Color = System.Drawing.Color.DarkRed
        Series6.Legend = "Legend1"
        Series6.Name = "Y(t)"
        Me.ChartY.Series.Add(Series6)
        Me.ChartY.Size = New System.Drawing.Size(450, 200)
        Me.ChartY.TabIndex = 1
        Me.ChartY.Text = "Chart1"
        '
        'ChartVx
        '
        Me.ChartVx.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        ChartArea7.AxisX.MajorGrid.Enabled = False
        ChartArea7.AxisY.MajorGrid.Enabled = False
        ChartArea7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        ChartArea7.Name = "ChartArea1"
        Me.ChartVx.ChartAreas.Add(ChartArea7)
        Legend7.Name = "Legend1"
        Me.ChartVx.Legends.Add(Legend7)
        Me.ChartVx.Location = New System.Drawing.Point(10, 330)
        Me.ChartVx.Name = "ChartVx"
        Series7.BorderWidth = 3
        Series7.ChartArea = "ChartArea1"
        Series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series7.Legend = "Legend1"
        Series7.Name = "Vx(t)"
        Me.ChartVx.Series.Add(Series7)
        Me.ChartVx.Size = New System.Drawing.Size(450, 200)
        Me.ChartVx.TabIndex = 2
        Me.ChartVx.Text = "Chart1"
        '
        'ChartVy
        '
        Me.ChartVy.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        ChartArea8.AxisX.MajorGrid.Enabled = False
        ChartArea8.AxisY.MajorGrid.Enabled = False
        ChartArea8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        ChartArea8.Name = "ChartArea1"
        Me.ChartVy.ChartAreas.Add(ChartArea8)
        Legend8.Name = "Legend1"
        Me.ChartVy.Legends.Add(Legend8)
        Me.ChartVy.Location = New System.Drawing.Point(500, 330)
        Me.ChartVy.Name = "ChartVy"
        Series8.BorderWidth = 3
        Series8.ChartArea = "ChartArea1"
        Series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series8.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Series8.Legend = "Legend1"
        Series8.Name = "Vy(t)"
        Me.ChartVy.Series.Add(Series8)
        Me.ChartVy.Size = New System.Drawing.Size(450, 200)
        Me.ChartVy.TabIndex = 3
        Me.ChartVy.Text = "Chart1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell Extra Bold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(287, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(429, 32)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Graficas de la Silmuación"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ChartVy)
        Me.Controls.Add(Me.ChartVx)
        Me.Controls.Add(Me.ChartY)
        Me.Controls.Add(Me.ChartX)
        Me.MaximumSize = New System.Drawing.Size(1000, 600)
        Me.MinimumSize = New System.Drawing.Size(1000, 600)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.ChartX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartVx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartVy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ChartX As DataVisualization.Charting.Chart
    Friend WithEvents ChartY As DataVisualization.Charting.Chart
    Friend WithEvents ChartVx As DataVisualization.Charting.Chart
    Friend WithEvents ChartVy As DataVisualization.Charting.Chart
    Friend WithEvents Label1 As Label
End Class
