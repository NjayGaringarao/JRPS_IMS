Imports System.Data.SQLite
Imports System.Windows.Forms.DataVisualization.Charting

Public Class DashboardFrm
    Private WithEvents timer0 As New Timer()
    Dim store As New Store
    Dim DataBase_Path As String = "Data Source=" & Application.StartupPath & "\IntegratedDataBase.db;"
    Dim DataBaseConnection As New SQLiteConnection(DataBase_Path)


    Private Sub LoadChart()
        Dim DataBaseConnection As New SQLiteConnection(DataBase_Path)
        Dim query As String = "SELECT * FROM DiversityDataView"
        Dim dataTable As New DataTable()
        Try
            DataBaseConnection.Open()
            store.LoadDataBase(query, dataTable, DataBaseConnection)
            PopulateChart(dataTable)
        Catch ex As Exception
            MsgBox(ex.Message)
            DataBaseConnection.Close()
            DataBaseConnection.Dispose()
        End Try

        DataBaseConnection.Close()
        DataBaseConnection.Dispose()
    End Sub

    Private Sub PopulateChart(dataTable As DataTable)

        Dim series As Series = Chart3.Series("Series1")

        series.Points.Clear()

        For Each row As DataRow In dataTable.Rows
            Dim category As String = row("Category").ToString()
            Dim amount As Double = Convert.ToDouble(row("Amount"))

            series.Points.AddXY(category, amount)
        Next

        ' Refresh the chart
        Chart3.Invalidate()

    End Sub

    Private Sub UpdateDisplayTime(sender As Object, e As EventArgs) Handles timer0.Tick
        Label2.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub Greet()
        Dim currentTime As DateTime = DateTime.Now
        Dim greetMode As String = ""

        If currentTime.Hour >= 6 AndAlso currentTime.Hour < 12 Then
            greetMode = "Magandang Umaga"
        ElseIf currentTime.Hour >= 12 AndAlso currentTime.Hour < 18 Then
            greetMode = "Magandang Hapon"
        Else
            greetMode = "Magandang Gabi"
        End If

        Label1.Text = greetMode & " " & Store.loggedInName

    End Sub

    Private Sub DashboardFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timer0.Interval = 1000
        timer0.Start()
        Greet()
        LoadChart()
        LoadTextBox1()
    End Sub

    Private Sub LoadTextBox1()
        Dim DataBaseConnection As New SQLiteConnection(DataBase_Path)
        Dim CMD As String = "SELECT notes FROM AccountData WHERE username = '" & Store.loggedInAccount & "'"
        Dim dataTable As New DataTable()

        Try
            DataBaseConnection.Open()
            Dim adapter As New SQLiteDataAdapter(CMD, DataBaseConnection)
            adapter.Fill(dataTable)


            If dataTable.Rows.Count > 0 Then

                TextBox1.Text = dataTable.Rows(0)("notes").ToString()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            DataBaseConnection.Close()
            DataBaseConnection.Dispose()
        End Try
    End Sub

    Private Sub TextBox1SaveAndLeave(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        Dim DataBaseConnection As New SQLiteConnection(DataBase_Path)
        Dim CMD As String = "UPDATE AccountData SET notes='" & TextBox1.Text & "' WHERE username = '" & Store.loggedInAccount & "'"
        Dim dataTable As New DataTable()

        Try
            DataBaseConnection.Open()
            store.ExecuteNonQuery(CMD, DataBaseConnection)
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            DataBaseConnection.Close()
            DataBaseConnection.Dispose()
        End Try

    End Sub
End Class