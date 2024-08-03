<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActivityLogFrm
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Panel5 = New Panel()
        Panel7 = New Panel()
        DataGridViewTable = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Panel6 = New Panel()
        ClearBtn = New Button()
        ExportBtn = New Button()
        Panel5.SuspendLayout()
        Panel7.SuspendLayout()
        CType(DataGridViewTable, ComponentModel.ISupportInitialize).BeginInit()
        Panel6.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(999, 21)
        Panel1.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.Dock = DockStyle.Left
        Panel3.Location = New Point(0, 21)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(19, 621)
        Panel3.TabIndex = 2
        ' 
        ' Panel4
        ' 
        Panel4.Dock = DockStyle.Right
        Panel4.Location = New Point(976, 21)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(23, 621)
        Panel4.TabIndex = 3
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(Panel7)
        Panel5.Controls.Add(Panel6)
        Panel5.Dock = DockStyle.Fill
        Panel5.Location = New Point(19, 21)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(957, 621)
        Panel5.TabIndex = 4
        ' 
        ' Panel7
        ' 
        Panel7.Controls.Add(DataGridViewTable)
        Panel7.Dock = DockStyle.Fill
        Panel7.Location = New Point(0, 0)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(957, 558)
        Panel7.TabIndex = 0
        ' 
        ' DataGridViewTable
        ' 
        DataGridViewTable.AllowUserToAddRows = False
        DataGridViewTable.AllowUserToDeleteRows = False
        DataGridViewTable.AllowUserToOrderColumns = True
        DataGridViewTable.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(179), CByte(168), CByte(146))
        DataGridViewCellStyle1.Font = New Font("Consolas", 11F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(218), CByte(221), CByte(177))
        DataGridViewCellStyle1.SelectionForeColor = Color.Black
        DataGridViewTable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewTable.BackgroundColor = Color.FromArgb(CByte(214), CByte(199), CByte(179))
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DataGridViewTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewTable.ColumnHeadersHeight = 25
        DataGridViewTable.Columns.AddRange(New DataGridViewColumn() {Column1, Column4})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(214), CByte(199), CByte(174))
        DataGridViewCellStyle3.Font = New Font("Consolas", 11F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(218), CByte(221), CByte(177))
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        DataGridViewTable.DefaultCellStyle = DataGridViewCellStyle3
        DataGridViewTable.Dock = DockStyle.Fill
        DataGridViewTable.EnableHeadersVisualStyles = False
        DataGridViewTable.Location = New Point(0, 0)
        DataGridViewTable.Name = "DataGridViewTable"
        DataGridViewTable.RightToLeft = RightToLeft.No
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(214), CByte(199), CByte(174))
        DataGridViewCellStyle4.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(CByte(218), CByte(221), CByte(177))
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.WindowText
        DataGridViewTable.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewTable.RowHeadersVisible = False
        DataGridViewTable.RowHeadersWidth = 20
        DataGridViewTable.RowTemplate.Height = 25
        DataGridViewTable.Size = New Size(957, 558)
        DataGridViewTable.TabIndex = 1
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Column1.FillWeight = 99.61929F
        Column1.HeaderText = "Date and Time"
        Column1.MinimumWidth = 200
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 200
        ' 
        ' Column4
        ' 
        Column4.FillWeight = 99.61929F
        Column4.HeaderText = "Details"
        Column4.MinimumWidth = 60
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' Panel6
        ' 
        Panel6.Controls.Add(ClearBtn)
        Panel6.Controls.Add(ExportBtn)
        Panel6.Dock = DockStyle.Bottom
        Panel6.Location = New Point(0, 558)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(957, 63)
        Panel6.TabIndex = 0
        ' 
        ' ClearBtn
        ' 
        ClearBtn.Anchor = AnchorStyles.Left
        ClearBtn.BackColor = Color.FromArgb(CByte(191), CByte(178), CByte(158))
        ClearBtn.FlatStyle = FlatStyle.Flat
        ClearBtn.Font = New Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        ClearBtn.Location = New Point(0, 9)
        ClearBtn.Name = "ClearBtn"
        ClearBtn.Size = New Size(111, 38)
        ClearBtn.TabIndex = 2
        ClearBtn.Text = "Clear Logs"
        ClearBtn.UseVisualStyleBackColor = False
        ' 
        ' ExportBtn
        ' 
        ExportBtn.Anchor = AnchorStyles.Right
        ExportBtn.BackColor = Color.FromArgb(CByte(191), CByte(178), CByte(158))
        ExportBtn.FlatStyle = FlatStyle.Flat
        ExportBtn.Font = New Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        ExportBtn.Location = New Point(839, 9)
        ExportBtn.Name = "ExportBtn"
        ExportBtn.Size = New Size(118, 38)
        ExportBtn.TabIndex = 3
        ExportBtn.Text = "Export Logs"
        ExportBtn.UseVisualStyleBackColor = False
        ' 
        ' ActivityLogFrm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(218), CByte(221), CByte(177))
        ClientSize = New Size(999, 642)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Name = "ActivityLogFrm"
        Text = "ActivityLog"
        Panel5.ResumeLayout(False)
        Panel7.ResumeLayout(False)
        CType(DataGridViewTable, ComponentModel.ISupportInitialize).EndInit()
        Panel6.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents ClearBtn As Button
    Friend WithEvents ExportBtn As Button
    Friend WithEvents DataGridViewTable As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
