<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardFrm
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
        Dim ChartArea1 As DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend1 As DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series1 As DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim Title1 As DataVisualization.Charting.Title = New DataVisualization.Charting.Title()
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel6 = New Panel()
        Label1 = New Label()
        Panel7 = New Panel()
        SplitContainer1 = New SplitContainer()
        Label2 = New Label()
        MonthCalendar1 = New MonthCalendar()
        Panel8 = New Panel()
        SplitContainer2 = New SplitContainer()
        TextBox1 = New TextBox()
        Panel9 = New Panel()
        Label3 = New Label()
        Panel11 = New Panel()
        TableLayoutPanel2 = New TableLayoutPanel()
        Chart3 = New DataVisualization.Charting.Chart()
        Panel10 = New Panel()
        Label4 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Panel5 = New Panel()
        TableLayoutPanel1.SuspendLayout()
        Panel6.SuspendLayout()
        Panel7.SuspendLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        Panel8.SuspendLayout()
        CType(SplitContainer2, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer2.Panel1.SuspendLayout()
        SplitContainer2.Panel2.SuspendLayout()
        SplitContainer2.SuspendLayout()
        Panel9.SuspendLayout()
        Panel11.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        CType(Chart3, ComponentModel.ISupportInitialize).BeginInit()
        Panel10.SuspendLayout()
        Panel5.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = Color.FromArgb(CByte(218), CByte(221), CByte(177))
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(Panel6, 0, 0)
        TableLayoutPanel1.Controls.Add(Panel7, 0, 1)
        TableLayoutPanel1.Controls.Add(Panel8, 0, 2)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 171F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(973, 602)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(179), CByte(168), CByte(146))
        Panel6.Controls.Add(Label1)
        Panel6.Dock = DockStyle.Fill
        Panel6.Location = New Point(3, 3)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(967, 44)
        Panel6.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(13, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 23)
        Label1.TabIndex = 0
        Label1.Text = "Greet!"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.FromArgb(CByte(179), CByte(168), CByte(138))
        Panel7.Controls.Add(SplitContainer1)
        Panel7.Dock = DockStyle.Fill
        Panel7.Location = New Point(3, 53)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(967, 165)
        Panel7.TabIndex = 2
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(0, 0)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.BackColor = Color.FromArgb(CByte(179), CByte(168), CByte(146))
        SplitContainer1.Panel1.Controls.Add(Label2)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.BackColor = Color.FromArgb(CByte(179), CByte(168), CByte(146))
        SplitContainer1.Panel2.Controls.Add(MonthCalendar1)
        SplitContainer1.Size = New Size(967, 165)
        SplitContainer1.SplitterDistance = 732
        SplitContainer1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.FlatStyle = FlatStyle.Flat
        Label2.Font = New Font("Consolas", 72F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(218), CByte(221), CByte(177))
        Label2.Location = New Point(147, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(471, 112)
        Label2.TabIndex = 0
        Label2.Text = "TT:MM:SS"
        ' 
        ' MonthCalendar1
        ' 
        MonthCalendar1.BackColor = Color.FromArgb(CByte(218), CByte(221), CByte(177))
        MonthCalendar1.Dock = DockStyle.Fill
        MonthCalendar1.Location = New Point(0, 0)
        MonthCalendar1.Name = "MonthCalendar1"
        MonthCalendar1.TabIndex = 0
        ' 
        ' Panel8
        ' 
        Panel8.Controls.Add(SplitContainer2)
        Panel8.Dock = DockStyle.Fill
        Panel8.Location = New Point(3, 224)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(967, 375)
        Panel8.TabIndex = 3
        ' 
        ' SplitContainer2
        ' 
        SplitContainer2.Dock = DockStyle.Fill
        SplitContainer2.Location = New Point(0, 0)
        SplitContainer2.Name = "SplitContainer2"
        ' 
        ' SplitContainer2.Panel1
        ' 
        SplitContainer2.Panel1.Controls.Add(TextBox1)
        SplitContainer2.Panel1.Controls.Add(Panel9)
        ' 
        ' SplitContainer2.Panel2
        ' 
        SplitContainer2.Panel2.BackColor = Color.FromArgb(CByte(179), CByte(168), CByte(146))
        SplitContainer2.Panel2.Controls.Add(Panel11)
        SplitContainer2.Panel2.Controls.Add(Panel10)
        SplitContainer2.Size = New Size(967, 375)
        SplitContainer2.SplitterDistance = 214
        SplitContainer2.TabIndex = 0
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(218), CByte(221), CByte(200))
        TextBox1.Dock = DockStyle.Fill
        TextBox1.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(0, 35)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.ScrollBars = ScrollBars.Vertical
        TextBox1.Size = New Size(214, 340)
        TextBox1.TabIndex = 1
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.FromArgb(CByte(179), CByte(168), CByte(146))
        Panel9.Controls.Add(Label3)
        Panel9.Dock = DockStyle.Top
        Panel9.Location = New Point(0, 0)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(214, 35)
        Panel9.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.Font = New Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(69, 7)
        Label3.Name = "Label3"
        Label3.Size = New Size(68, 23)
        Label3.TabIndex = 0
        Label3.Text = "NOTES"
        ' 
        ' Panel11
        ' 
        Panel11.BackColor = Color.FromArgb(CByte(218), CByte(221), CByte(177))
        Panel11.Controls.Add(TableLayoutPanel2)
        Panel11.Dock = DockStyle.Fill
        Panel11.Location = New Point(0, 35)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(749, 340)
        Panel11.TabIndex = 1
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.AutoScroll = True
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Controls.Add(Chart3, 0, 0)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(0, 0)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 320F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 320F))
        TableLayoutPanel2.Size = New Size(749, 340)
        TableLayoutPanel2.TabIndex = 0
        ' 
        ' Chart3
        ' 
        Chart3.BackColor = Color.FromArgb(CByte(214), CByte(199), CByte(174))
        ChartArea1.Name = "ChartArea1"
        Chart3.ChartAreas.Add(ChartArea1)
        Chart3.Dock = DockStyle.Fill
        Legend1.Name = "Legend1"
        Chart3.Legends.Add(Legend1)
        Chart3.Location = New Point(3, 3)
        Chart3.Name = "Chart3"
        Chart3.Palette = DataVisualization.Charting.ChartColorPalette.SeaGreen
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = DataVisualization.Charting.SeriesChartType.Doughnut
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Chart3.Series.Add(Series1)
        Chart3.Size = New Size(743, 314)
        Chart3.TabIndex = 0
        Chart3.Text = "Chart3"
        Title1.Font = New Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Title1.Name = "Title1"
        Title1.Text = "Inventory Composition"
        Chart3.Titles.Add(Title1)
        ' 
        ' Panel10
        ' 
        Panel10.Controls.Add(Label4)
        Panel10.Dock = DockStyle.Top
        Panel10.Location = New Point(0, 0)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(749, 35)
        Panel10.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top
        Label4.AutoSize = True
        Label4.Font = New Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(347, 7)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 23)
        Label4.TabIndex = 1
        Label4.Text = "REPORTS"
        ' 
        ' Panel1
        ' 
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1013, 20)
        Panel1.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 622)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1013, 20)
        Panel2.TabIndex = 2
        ' 
        ' Panel3
        ' 
        Panel3.Dock = DockStyle.Left
        Panel3.Location = New Point(0, 20)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(20, 602)
        Panel3.TabIndex = 2
        ' 
        ' Panel4
        ' 
        Panel4.Dock = DockStyle.Right
        Panel4.Location = New Point(993, 20)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(20, 602)
        Panel4.TabIndex = 2
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(TableLayoutPanel1)
        Panel5.Dock = DockStyle.Fill
        Panel5.Location = New Point(20, 20)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(973, 602)
        Panel5.TabIndex = 2
        ' 
        ' DashboardFrm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(218), CByte(221), CByte(177))
        ClientSize = New Size(1013, 642)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "DashboardFrm"
        Text = "Dashboard"
        TableLayoutPanel1.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel7.ResumeLayout(False)
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel1.PerformLayout()
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        Panel8.ResumeLayout(False)
        SplitContainer2.Panel1.ResumeLayout(False)
        SplitContainer2.Panel1.PerformLayout()
        SplitContainer2.Panel2.ResumeLayout(False)
        CType(SplitContainer2, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer2.ResumeLayout(False)
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        Panel11.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        CType(Chart3, ComponentModel.ISupportInitialize).EndInit()
        Panel10.ResumeLayout(False)
        Panel10.PerformLayout()
        Panel5.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Label2 As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Panel8 As Panel
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel11 As Panel
    'Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Label4 As Label
    'Friend WithEvents Chart2 As DataVisualization.Charting.Chart
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Chart3 As DataVisualization.Charting.Chart
End Class
