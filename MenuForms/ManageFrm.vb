Imports System.ComponentModel
Imports System.Data.Common
Imports System.Data.SQLite
Imports System.Windows.Forms.Design
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports JRPS_IMS.Store

Public Class ManageFrm
    Dim store As New Store
    Private DataBase_Path As String = "Data Source=" & Application.StartupPath & "\IntegratedDataBase.db;"
    Private TableName As String = "ProductData"



    Public Sub RefreshDataGridViewTable()
        Dim DataBaseConnection As New SQLiteConnection(DataBase_Path)
        DataGridViewTable.Rows.Clear()

        'Connects to the DataBase
        Try
            DataBaseConnection.Open()

        Catch ex As Exception
            DataBaseConnection.Close()
            MsgBox(ex.Message)
            Exit Sub
        End Try

        'Makes an SQL Query
        Dim insertCMD = New SQLiteCommand("SELECT * FROM " & TableName & " ORDER BY ProductName", DataBaseConnection)
        Dim dataReader = insertCMD.ExecuteReader
        Dim i As Integer = 0

        'Putting the data into the table while following the format
        While dataReader.Read
            i += 1
            DataGridViewTable.Rows.Add(i, dataReader.Item("InventoryID").ToString, dataReader.Item("ProductName").ToString, dataReader.Item("Category").ToString, dataReader.Item("Amount").ToString, dataReader.Item("Description").ToString)
        End While

        dataReader.Close()
        DataBaseConnection.Close() 'To avoid Conflicts
    End Sub

    '<SEARCH BOX AND SEARCH MECHANISM//////////////////////////////////////////////////////////////////////////////////////////////////////>

    'SEARCH BOOLEAN VARIABLE
    Dim isSearchBoxActive As Boolean

    Private Sub SearchTxtBox_Enter(sender As Object, e As EventArgs) Handles SearchTxtBox.Enter
        isSearchBoxActive = True
        SearchBarLbl.Visible = False
    End Sub

    Private Sub SearchTxtBox_Leave(sender As Object, e As EventArgs) Handles SearchTxtBox.Leave
        isSearchBoxActive = False
        SearchBarLbl.Visible = True
    End Sub


    Private Sub SearchTxtBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTxtBox.TextChanged


        Dim isSearchBoxNull As Boolean
        Dim isSortByNameChecked As Boolean

        'Checks if search bar has a null search value
        If SearchTxtBox.Text = "" Then
            isSearchBoxNull = True
        Else
            isSearchBoxNull = False
        End If

        'Checks if sort by name is checked
        If SortByNameCheckBox.Checked = True Then
            isSortByNameChecked = True
        Else
            isSortByNameChecked = False
        End If

        SearchInstruction(isSearchBoxActive, isSearchBoxNull, isSortByNameChecked)

    End Sub

    Private Sub SearchInstruction(ByVal active As Boolean, ByVal emptySearch As Boolean, ByVal sortbyName As Boolean)
        If active = False Then
            Exit Sub
        End If

        Dim searchCMD As String

        If emptySearch = True And sortbyName = True Then
            'MsgBox("show all the data", vbInformation, "walang laman ang search bar AND naka sort by name")
            searchCMD = "SELECT * FROM " & TableName & " ORDER BY ProductName"

        ElseIf emptySearch = True And sortbyName = False Then
            'MsgBox("show all the data that has the same selected category", vbInformation, "walang laman ang search AND and naka filter by category")
            Dim categoryCondition As String = ""

            'Since SortByCategoryComboBox.SelectedIndex is Integer, I converted them into text and make it fit to
            'be part of searchCMD as a valid sql command
            Select Case SortByCategoryComboBox.SelectedIndex
                Case 1
                    categoryCondition = "Category = 'Paper/Medium'"
                Case 2
                    categoryCondition = "Category = 'Printed Materials'"
                Case 3
                    categoryCondition = "Category = 'Essential Office Supply'"
                Case 4
                    categoryCondition = "Category = 'Inks And Cartridges'"
                Case 5
                    categoryCondition = "Category = 'Printer Maintenance'"

            End Select

            searchCMD = "SELECT * FROM " & TableName & " WHERE " & categoryCondition & " ORDER BY ProductName"
        ElseIf emptySearch = False And sortbyName = True Then
            'MsgBox("Show the search result sorted by name", vbInformation, "may laman ang search bar AND naka sort by name")
            searchCMD = "SELECT * FROM " & TableName & " WHERE ProductName LIKE '" & SearchTxtBox.Text & "%' ORDER BY ProductName"

        ElseIf emptySearch = False And sortbyName = False Then
            'MsgBox("Show the filtered by category search result sorted by name.", vbInformation, "may laman ang search bar and naka filter by category")

            Dim categoryCondition As String = ""

            'Since SortByCategoryComboBox.SelectedIndex is Integer, I converted them into text and make it fit to
            'be part of searchCMD as a valid sql command
            Select Case SortByCategoryComboBox.SelectedIndex
                Case 1
                    categoryCondition = "Category = 'Paper/Medium'"
                Case 2
                    categoryCondition = "Category = 'Printed Materials'"
                Case 3
                    categoryCondition = "Category = 'Essential Office Supply'"
                Case 4
                    categoryCondition = "Category = 'Inks And Cartridges'"
                Case 5
                    categoryCondition = "Category = 'Printer Maintenance'"

            End Select

            searchCMD = "SELECT * FROM " & TableName & " WHERE " & categoryCondition & " AND ProductName LIKE '" & SearchTxtBox.Text & "%' ORDER BY ProductName"

        Else
            Exit Sub
        End If

        SearchWork(searchCMD)
    End Sub

    Private Sub SearchWork(ByVal cmdSearch As String)
        Dim DataBaseConnection As New SQLiteConnection(DataBase_Path)

        Try
            DataBaseConnection.Open()
        Catch ex As Exception
            MsgBox("DataBase Cannot open")
        End Try

        DataGridViewTable.Rows.Clear()
        Dim insertCMD = New SQLiteCommand(cmdSearch, DataBaseConnection)
        Dim dataReader = insertCMD.ExecuteReader

        Try
            Dim i As Integer = 0
            While dataReader.Read()
                i += 1
                DataGridViewTable.Rows.Add(i, dataReader.Item("InventoryID").ToString, dataReader.Item("ProductName").ToString, dataReader.Item("Category").ToString, dataReader.Item("Amount").ToString, dataReader.Item("Description").ToString)
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        DataBaseConnection.Close()
    End Sub

    '<//////////////////////////////////////////////////////////////////////////////////////////////////////////SEARCH BOX AND SEARCH MECHANISM>
    Private Sub ManageFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SortByCategoryComboBox.SelectedIndex = 0
        SortByNameCheckBox.Checked = True
        RefreshDataGridViewTable()

    End Sub

    Private Sub NewBtn_Click(sender As Object, e As EventArgs) Handles NewBtn.Click
        AddEditDialogueFrm.CustomShowDialog("Add")

    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        Dim selectedRow As DataGridViewRow
        'Check if a row is selected
        If Not (DataGridViewTable.SelectedRows.Count = 1) Then
            MsgBox("Please select a row to edit.", MsgBoxStyle.Exclamation, "No Row Selected")
            Return
        End If
        'Access the data from the selected row and use the data to fill the Edit form
        selectedRow = DataGridViewTable.SelectedRows(0)

        AddEditDialogueFrm.CustomShowDialog("Edit", selectedRow)
    End Sub

    Private Sub SortByNameCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles SortByNameCheckBox.CheckedChanged
        If SortByNameCheckBox.Checked = True Then
            SortByCategoryComboBox.SelectedIndex = 0
        Else
            SortByCategoryComboBox.SelectedIndex = 1
        End If
    End Sub

    Private Sub SortByCategoryComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SortByCategoryComboBox.SelectedIndexChanged
        If SortByCategoryComboBox.SelectedIndex = 0 Then
            SortByNameCheckBox.Checked = True
        Else
            SortByNameCheckBox.Checked = False
        End If

        isSearchBoxActive = True
        SearchTxtBox_TextChanged(sender, e)
        isSearchBoxActive = False
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        'Checks if any row is selected in the DataGridView
        If DataGridViewTable.SelectedRows.Count = 0 Then
            MsgBox("Please select a row to delete.", MsgBoxStyle.Exclamation, "No Selection")
            Return
        End If

        'Asks the user for confirmation
        If MessageBox.Show("Do you want to delete the selected row? This cannot be undone!", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim DataBaseConnection As New SQLiteConnection(DataBase_Path)

            Try
                DataBaseConnection.Open()
            Catch ex As Exception
                DataBaseConnection.Dispose()
                DataBaseConnection = Nothing
                MsgBox(ex.Message)
                Return
            End Try

            'This loop Iterates through selected rows to be delete from the database
            For Each row As DataGridViewRow In DataGridViewTable.SelectedRows
                Dim inventoryID As String = row.Cells("Column1").Value.ToString()

                store.ExecuteNonQuery("DELETE FROM ProductData WHERE InventoryID = '" & inventoryID & "';", DataBaseConnection)
                store.WriteToLog(Store.loggedInAccount & " : Deletes an Item/s")

                '' Construct and execute the DELETE query
                'Dim deleteQuery As String = "DELETE FROM ProductData WHERE InventoryID = @InventoryID;"
                'Using deleteCommand As New SQLiteCommand(deleteQuery, DBConnection)
                '    deleteCommand.Parameters.AddWithValue("@InventoryID", inventoryID)
                '    deleteCommand.ExecuteNonQuery()
                'End Using
            Next

            DataBaseConnection.Close()
            DataBaseConnection.Dispose()
        End If
        'After the operation:
        RefreshDataGridViewTable()

    End Sub

    Private Sub SearchBarLbl_Click(sender As Object, e As EventArgs) Handles SearchBarLbl.Click
        SearchBarLbl.Visible = False
        SearchTxtBox.Focus()
    End Sub

End Class