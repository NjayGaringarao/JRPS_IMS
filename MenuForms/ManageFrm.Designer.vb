﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageFrm
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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(ManageFrm))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        Panel4 = New Panel()
        SearchBarLbl = New Label()
        SortByCategoryComboBox = New ComboBox()
        SortByNameCheckBox = New CheckBox()
        SearchTxtBox = New TextBox()
        Panel3 = New Panel()
        NewBtn = New Button()
        Panel2 = New Panel()
        EditBtn = New Button()
        DeleteBtn = New Button()
        Panel5 = New Panel()
        Panel12 = New Panel()
        Panel11 = New Panel()
        Label1 = New Label()
        Panel10 = New Panel()
        Panel6 = New Panel()
        Panel7 = New Panel()
        Panel8 = New Panel()
        Panel9 = New Panel()
        DataGridViewTable = New DataGridView()
        ToolTip1 = New ToolTip(components)
        Column0 = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Panel1.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        Panel5.SuspendLayout()
        Panel11.SuspendLayout()
        Panel9.SuspendLayout()
        CType(DataGridViewTable, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1013, 116)
        Panel1.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(SearchBarLbl)
        Panel4.Controls.Add(SortByCategoryComboBox)
        Panel4.Controls.Add(SortByNameCheckBox)
        Panel4.Controls.Add(SearchTxtBox)
        Panel4.Dock = DockStyle.Fill
        Panel4.Location = New Point(206, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(698, 116)
        Panel4.TabIndex = 3
        ' 
        ' SearchBarLbl
        ' 
        SearchBarLbl.AccessibleRole = AccessibleRole.None
        SearchBarLbl.Anchor = AnchorStyles.Top
        SearchBarLbl.AutoSize = True
        SearchBarLbl.BackColor = Color.FromArgb(CByte(214), CByte(199), CByte(174))
        SearchBarLbl.Font = New Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point)
        SearchBarLbl.ForeColor = SystemColors.WindowFrame
        SearchBarLbl.Location = New Point(287, 33)
        SearchBarLbl.Name = "SearchBarLbl"
        SearchBarLbl.Size = New Size(120, 22)
        SearchBarLbl.TabIndex = 4
        SearchBarLbl.Text = "Search Here"
        ' 
        ' SortByCategoryComboBox
        ' 
        SortByCategoryComboBox.Anchor = AnchorStyles.Top
        SortByCategoryComboBox.BackColor = Color.FromArgb(CByte(191), CByte(178), CByte(158))
        SortByCategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        SortByCategoryComboBox.FormattingEnabled = True
        SortByCategoryComboBox.Items.AddRange(New Object() {"-- Sort by Category --", "Paper/Medium", "Printed Materials", "Essential Office Supply", "Inks and Cartridges", "Printer Maintenance"})
        SortByCategoryComboBox.Location = New Point(345, 65)
        SortByCategoryComboBox.Name = "SortByCategoryComboBox"
        SortByCategoryComboBox.Size = New Size(154, 23)
        SortByCategoryComboBox.TabIndex = 3
        ' 
        ' SortByNameCheckBox
        ' 
        SortByNameCheckBox.Anchor = AnchorStyles.Top
        SortByNameCheckBox.AutoSize = True
        SortByNameCheckBox.Font = New Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point)
        SortByNameCheckBox.Location = New Point(237, 67)
        SortByNameCheckBox.Name = "SortByNameCheckBox"
        SortByNameCheckBox.Size = New Size(103, 21)
        SortByNameCheckBox.TabIndex = 1
        SortByNameCheckBox.Text = "Sort by Name"
        ToolTip1.SetToolTip(SortByNameCheckBox, "Sort the search result by name")
        SortByNameCheckBox.UseVisualStyleBackColor = True
        ' 
        ' SearchTxtBox
        ' 
        SearchTxtBox.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        SearchTxtBox.BackColor = Color.FromArgb(CByte(214), CByte(199), CByte(174))
        SearchTxtBox.BorderStyle = BorderStyle.FixedSingle
        SearchTxtBox.Font = New Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        SearchTxtBox.ForeColor = SystemColors.WindowText
        SearchTxtBox.Location = New Point(15, 29)
        SearchTxtBox.Name = "SearchTxtBox"
        SearchTxtBox.Size = New Size(671, 30)
        SearchTxtBox.TabIndex = 0
        SearchTxtBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(NewBtn)
        Panel3.Dock = DockStyle.Right
        Panel3.Location = New Point(904, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(109, 116)
        Panel3.TabIndex = 2
        ' 
        ' NewBtn
        ' 
        NewBtn.BackColor = Color.FromArgb(CByte(191), CByte(178), CByte(158))
        NewBtn.FlatStyle = FlatStyle.Flat
        NewBtn.Font = New Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        NewBtn.Image = CType(resources.GetObject("NewBtn.Image"), Image)
        NewBtn.Location = New Point(11, 16)
        NewBtn.Name = "NewBtn"
        NewBtn.Size = New Size(78, 78)
        NewBtn.TabIndex = 6
        NewBtn.TextAlign = ContentAlignment.MiddleRight
        ToolTip1.SetToolTip(NewBtn, "Add" & vbCrLf & "     - Adding new Inventory Item" & vbCrLf)
        NewBtn.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(EditBtn)
        Panel2.Controls.Add(DeleteBtn)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(206, 116)
        Panel2.TabIndex = 1
        ' 
        ' EditBtn
        ' 
        EditBtn.BackColor = Color.FromArgb(CByte(191), CByte(178), CByte(158))
        EditBtn.FlatStyle = FlatStyle.Flat
        EditBtn.Font = New Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        EditBtn.Image = CType(resources.GetObject("EditBtn.Image"), Image)
        EditBtn.Location = New Point(120, 16)
        EditBtn.Name = "EditBtn"
        EditBtn.Size = New Size(78, 78)
        EditBtn.TabIndex = 1
        EditBtn.TextAlign = ContentAlignment.BottomCenter
        ToolTip1.SetToolTip(EditBtn, "Edit" & vbCrLf & "     -Modifying details of a selected Item " & vbCrLf & "       from the Inventory Table View")
        EditBtn.UseVisualStyleBackColor = False
        ' 
        ' DeleteBtn
        ' 
        DeleteBtn.BackColor = Color.FromArgb(CByte(191), CByte(178), CByte(158))
        DeleteBtn.FlatStyle = FlatStyle.Flat
        DeleteBtn.Font = New Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        DeleteBtn.Image = CType(resources.GetObject("DeleteBtn.Image"), Image)
        DeleteBtn.Location = New Point(21, 16)
        DeleteBtn.Name = "DeleteBtn"
        DeleteBtn.Size = New Size(78, 78)
        DeleteBtn.TabIndex = 2
        DeleteBtn.TextAlign = ContentAlignment.BottomCenter
        ToolTip1.SetToolTip(DeleteBtn, "Delete" & vbCrLf & "     - Removing a selected item in the Inventory" & vbCrLf & "        Table View.")
        DeleteBtn.UseVisualStyleBackColor = False
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(Panel12)
        Panel5.Controls.Add(Panel11)
        Panel5.Controls.Add(Panel10)
        Panel5.Dock = DockStyle.Top
        Panel5.Location = New Point(0, 116)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(1013, 42)
        Panel5.TabIndex = 1
        ' 
        ' Panel12
        ' 
        Panel12.Dock = DockStyle.Right
        Panel12.Location = New Point(993, 0)
        Panel12.Name = "Panel12"
        Panel12.Size = New Size(20, 42)
        Panel12.TabIndex = 2
        ' 
        ' Panel11
        ' 
        Panel11.BackColor = Color.FromArgb(CByte(179), CByte(168), CByte(146))
        Panel11.BorderStyle = BorderStyle.FixedSingle
        Panel11.Controls.Add(Label1)
        Panel11.Dock = DockStyle.Fill
        Panel11.Location = New Point(20, 0)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(993, 42)
        Panel11.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(29, 5)
        Label1.Name = "Label1"
        Label1.Size = New Size(220, 29)
        Label1.TabIndex = 5
        Label1.Text = "Inventory Table View"
        ' 
        ' Panel10
        ' 
        Panel10.Dock = DockStyle.Left
        Panel10.Location = New Point(0, 0)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(20, 42)
        Panel10.TabIndex = 0
        ' 
        ' Panel6
        ' 
        Panel6.Dock = DockStyle.Bottom
        Panel6.Location = New Point(0, 622)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(1013, 20)
        Panel6.TabIndex = 2
        ' 
        ' Panel7
        ' 
        Panel7.Dock = DockStyle.Left
        Panel7.Location = New Point(0, 158)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(20, 464)
        Panel7.TabIndex = 3
        ' 
        ' Panel8
        ' 
        Panel8.Dock = DockStyle.Right
        Panel8.Location = New Point(993, 158)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(20, 464)
        Panel8.TabIndex = 4
        ' 
        ' Panel9
        ' 
        Panel9.Controls.Add(DataGridViewTable)
        Panel9.Dock = DockStyle.Fill
        Panel9.Location = New Point(20, 158)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(973, 464)
        Panel9.TabIndex = 0
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
        DataGridViewTable.Columns.AddRange(New DataGridViewColumn() {Column0, Column1, Column2, Column3, Column5, Column4})
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
        DataGridViewTable.RowHeadersWidth = 20
        DataGridViewTable.RowTemplate.Height = 25
        DataGridViewTable.Size = New Size(973, 464)
        DataGridViewTable.TabIndex = 0
        ' 
        ' Column0
        ' 
        Column0.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column0.HeaderText = "#"
        Column0.MinimumWidth = 20
        Column0.Name = "Column0"
        Column0.ReadOnly = True
        Column0.Width = 43
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Column1.FillWeight = 99.61929F
        Column1.HeaderText = "InventoryID"
        Column1.MinimumWidth = 130
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 170
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Column2.FillWeight = 99.61929F
        Column2.HeaderText = "ProductName"
        Column2.MinimumWidth = 216
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 216
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Column3.FillWeight = 99.61929F
        Column3.HeaderText = "Category"
        Column3.MinimumWidth = 200
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 200
        ' 
        ' Column5
        ' 
        Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Column5.FillWeight = 101.522842F
        Column5.HeaderText = "Amount"
        Column5.MinimumWidth = 60
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 60
        ' 
        ' Column4
        ' 
        Column4.FillWeight = 99.61929F
        Column4.HeaderText = "Details"
        Column4.MinimumWidth = 60
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' ManageFrm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(218), CByte(221), CByte(177))
        ClientSize = New Size(1013, 642)
        Controls.Add(Panel9)
        Controls.Add(Panel8)
        Controls.Add(Panel7)
        Controls.Add(Panel6)
        Controls.Add(Panel5)
        Controls.Add(Panel1)
        Name = "ManageFrm"
        Text = "ManageFrm"
        Panel1.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel11.ResumeLayout(False)
        Panel11.PerformLayout()
        Panel9.ResumeLayout(False)
        CType(DataGridViewTable, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents EditBtn As Button
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents SearchTxtBox As TextBox
    Friend WithEvents NewBtn As Button
    Friend WithEvents SortByNameCheckBox As CheckBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents DataGridViewTable As DataGridView
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents SortByCategoryComboBox As ComboBox
    Friend WithEvents SearchBarLbl As Label
    Friend WithEvents Column0 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
