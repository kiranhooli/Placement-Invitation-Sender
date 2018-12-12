Imports MySql.Data.MySqlClient

Public Class Form1

    Dim conn As New MySqlConnection
    Dim db As String = "students"
    Dim server As String = "localhost"
    Dim username As String = "root"
    Dim password As String = ""
    Dim id As String = ""
    Dim query As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not conn Is Nothing Then conn.Close()
        conn.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, username, password, db)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            conn.Open()

        Catch ex As Exception
        End Try
        Dim uname As String = TextBox1.Text
        query = "SELECT * FROM `admins` WHERE `username` = '" & uname & "'"
        Dim mycmd As New MySql.Data.MySqlClient.MySqlCommand(query, conn)
        Dim myReader As MySql.Data.MySqlClient.MySqlDataReader
        myReader = mycmd.ExecuteReader()

        If myReader.Read() Then
            If TextBox2.Text = myReader.GetString(1) Then
                Me.Hide()
                Form4.Show()
            Else
                MsgBox("Invalid Password..!")
            End If
        Else
            MsgBox("Invalid Username..!")
        End If

        conn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Form2.show()
    End Sub
End Class
