Imports System.Data.SQLite
Imports System.IO
Imports System.Xml


Public Class BackupFrm


    Dim store As New Store
    Private DataBase_Path As String = "Data Source=" & Application.StartupPath & "\IntegratedDataBase.db;"

    Private Sub BackupFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OverwriteRadBtn.Checked = True
        TxtTypeRadBtn.Checked = True

    End Sub

    '/////// IMPORT ////////////////////////////////////////////////////////////////////////////////////////////////////

    Private Sub ImportBtn_Click(sender As Object, e As EventArgs) Handles ImportBtn.Click



        If OverwriteRadBtn.Checked = True Then
            ImportFromXmlFile("Add")
        Else
            ImportFromXmlFile("Merge")
        End If

    End Sub

    Private Sub ImportFromXmlFile(ByVal importMode As String)
        Dim DataBaseConnection As New SQLiteConnection(DataBase_Path)

        Try
            DataBaseConnection.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
            DataBaseConnection.Dispose()
            DataBaseConnection.Close()
            Return
        End Try

        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "XML Files (*.xml)|*.xml"
        openFileDialog.Title = "Open XML File"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim xmlDocument As New XmlDocument()
            xmlDocument.Load(openFileDialog.FileName)

            Dim insertNodes As XmlNodeList = xmlDocument.SelectNodes("/Products/Product")

            Dim deleteAllCMD As String = "DELETE FROM ProductData;"

            If importMode = "Merge" Then
                ' Adds data to the database from the XML file.
                Using cmd As New SQLiteCommand("", DataBaseConnection)
                    For Each node As XmlNode In insertNodes
                        Try
                            Dim insertCommand As String = $"INSERT INTO ProductData (InventoryID, ProductName, Category, Amount, Description) VALUES ({node.SelectSingleNode("InventoryID").InnerText}, '{node.SelectSingleNode("ProductName").InnerText}', '{node.SelectSingleNode("Category").InnerText}', {node.SelectSingleNode("Amount").InnerText}, '{node.SelectSingleNode("Description").InnerText}');"
                            cmd.CommandText = insertCommand
                            cmd.ExecuteNonQuery()
                        Catch ex As Exception
                            MsgBox(ex.Message, vbCritical, "Results")
                        End Try
                    Next
                    MsgBox("Data Merged Successfully!", vbInformation, "Results")
                    store.WriteToLog(Store.loggedInAccount & " : Adds an item/s in the Database")
                End Using
            Else
                ' Deletes all the data in the Database and inserts the new.
                Using cmd0 As New SQLiteCommand(deleteAllCMD, DataBaseConnection)
                    cmd0.ExecuteNonQuery()
                End Using

                Using cmd As New SQLiteCommand("", DataBaseConnection)
                    For Each node As XmlNode In insertNodes
                        Try
                            Dim insertCommand As String = $"INSERT INTO ProductData (InventoryID, ProductName, Category, Amount, Description) VALUES ({node.SelectSingleNode("InventoryID").InnerText}, '{node.SelectSingleNode("ProductName").InnerText}', '{node.SelectSingleNode("Category").InnerText}', {node.SelectSingleNode("Amount").InnerText}, '{node.SelectSingleNode("Description").InnerText}');"
                            cmd.CommandText = insertCommand
                            cmd.ExecuteNonQuery()
                        Catch ex As Exception
                            MsgBox(ex.Message, vbCritical, "Results")
                        End Try
                    Next
                    MsgBox("Data Replaced Successfully!", vbInformation, "Results")
                    store.WriteToLog(Store.loggedInAccount & " : Replaces the data in Database")
                End Using
            End If
        End If

        DataBaseConnection.Close()
        DataBaseConnection.Dispose()
    End Sub







    '//////////////////////////////////////////////////////////////////////////////////////////////// IMPORT ///////

    Private Sub ExportBtn_Click(sender As Object, e As EventArgs) Handles ExportBtn.Click
        If TxtTypeRadBtn.Checked = True Then
            ExportTextFile()

        ElseIf TxtimpRadBtn.Checked = True Then
            ExportXmlFile()
        Else
            MsgBox("Sorry, PDF Export is not supported yet. Please wait for another release", vbInformation, "Apologies")
        End If
    End Sub



    Private Sub ExportToPDF()
        'Dim saveFileDialog As New SaveFileDialog()
        'saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf"
        'saveFileDialog.Title = "Save PDF File"
        'saveFileDialog.FileName = "ExportedData.pdf"

        'If saveFileDialog.ShowDialog() = DialogResult.OK Then
        '    Dim DataBaseConnection = New SQLiteConnection(DataBase_Path)
        '    DataBaseConnection.Open()

        '    Dim selectCommand As New SQLiteCommand("SELECT * FROM ProductData", DataBaseConnection)
        '    Dim dataReader As SQLiteDataReader = selectCommand.ExecuteReader()

        '    If dataReader.HasRows Then
        '        Dim pdfDocument As New PdfDocument()
        '        Dim page As PdfPageBase = pdfDocument.Pages.Add()

        '        Dim pdfTable As New PdfTable()
        '        pdfTable.Style.CellPadding = 2
        '        pdfTable.Style.HeaderSource = PdfHeaderSource.ColumnCaptions
        '        pdfTable.Style.HeaderStyle.BackgroundBrush = PdfBrushes.LightGray
        '        pdfTable.Style.HeaderStyle.TextBrush = PdfBrushes.Black
        '        pdfTable.Style.DefaultStyle.BackgroundBrush = PdfBrushes.White
        '        pdfTable.Style.DefaultStyle.TextBrush = PdfBrushes.Black

        '        pdfTable.DataSource = dataReader

        '        For i As Integer = 0 To dataReader.FieldCount - 1
        '            Dim column As New PdfColumn(dataReader.GetName(i))
        '            pdfTable.Columns.Add(column)
        '        Next

        '        pdfTable.Draw(page, New PointF(10, 10))

        '        pdfDocument.SaveToFile(saveFileDialog.FileName)
        '        pdfDocument.Close()

        '        dataReader.Close()
        '        DataBaseConnection.Close()

        '        MessageBox.Show("Data exported successfully to PDF!", "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Else
        '        MessageBox.Show("No data found to export!", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    End If
        'End If
    End Sub




    Private Sub ExportXmlFile()
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "XML Files (*.xml)|*.xml"
        saveFileDialog.Title = "Save XML File"
        saveFileDialog.FileName = "ExportedData.xml"

        Dim DataBaseConnection As New SQLiteConnection(DataBase_Path)

        Try
            DataBaseConnection.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
            DataBaseConnection.Close()
            DataBaseConnection.Dispose()
        End Try

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            DataBaseConnection = New SQLiteConnection(DataBase_Path)
            DataBaseConnection.Open()

            Dim selectCommand As New SQLiteCommand("SELECT * FROM ProductData", DataBaseConnection)
            Dim dataReader As SQLiteDataReader = selectCommand.ExecuteReader()

            Using xmlWriter As XmlWriter = XmlWriter.Create(saveFileDialog.FileName)
                ' Start writing the XML document
                xmlWriter.WriteStartDocument()

                ' Start the root element
                xmlWriter.WriteStartElement("Products")

                ' Loop through the data reader and write XML elements for each row
                While dataReader.Read()
                    xmlWriter.WriteStartElement("Product")
                    xmlWriter.WriteElementString("InventoryID", dataReader("InventoryID").ToString())
                    xmlWriter.WriteElementString("ProductName", dataReader("ProductName").ToString())
                    xmlWriter.WriteElementString("Category", dataReader("Category").ToString())
                    xmlWriter.WriteElementString("Amount", dataReader("Amount").ToString())
                    xmlWriter.WriteElementString("Description", dataReader("Description").ToString())
                    xmlWriter.WriteEndElement()
                End While

                ' End the root element
                xmlWriter.WriteEndElement()

                ' End the XML document
                xmlWriter.WriteEndDocument()
            End Using

            ' Close the data reader and the database connection
            dataReader.Close()
            DataBaseConnection.Close()

            MessageBox.Show("Data exported successfully!", "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            store.WriteToLog(Store.loggedInAccount & " : Exports importable XML file from the data in the database.")
        End If
    End Sub


    Private Sub ExportTextFile()
        ' Show the SaveFileDialog to allow the user to choose a location and provide a filename
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Text Files (*.txt)|*.txt"
        saveFileDialog.Title = "Save Text File"
        saveFileDialog.FileName = "ExportedData.txt"
        Dim DataBaseConnection As New SQLiteConnection(DataBase_Path)

        Try
            DataBaseConnection.Open()
        Catch ex As Exception

        End Try

        If saveFileDialog.ShowDialog() = DialogResult.OK Then

            DataBaseConnection = New SQLiteConnection(DataBase_Path)
            DataBaseConnection.Open()

            ' Create a command to select all data from the ProductData table
            Dim selectCommand As New SQLiteCommand("SELECT * FROM ProductData", DataBaseConnection)

            ' Execute the command and retrieve the data using a DataReader
            Dim dataReader As SQLiteDataReader = selectCommand.ExecuteReader()

            ' Open the StreamWriter to write data to the selected text file
            Using sw As New StreamWriter(saveFileDialog.FileName)
                ' Write the header line to the text file
                sw.WriteLine("InventoryID, ProductName, Category, Amount, Description")

                ' Loop through the data reader and write each row to the text file
                While dataReader.Read()
                    Dim line As String = $"{dataReader("InventoryID")}, {dataReader("ProductName")}, {dataReader("Category")}, {dataReader("Amount")}, {dataReader("Description")}"
                    sw.WriteLine(line)
                End While
            End Using

            ' Close the data reader and the database connection
            dataReader.Close()
            DataBaseConnection.Close()

            MessageBox.Show("Data exported successfully!", "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            store.WriteToLog(Store.loggedInAccount & " : Exports data in text file from the Database")
        End If

        DataBaseConnection.Close()
        DataBaseConnection.Dispose()

    End Sub


End Class