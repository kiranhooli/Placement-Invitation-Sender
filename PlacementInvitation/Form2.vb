Imports MySql.Data.MySqlClient

Public Class Form2
    Dim conn As New MySqlConnection
    Dim db As String = "students"
    Dim server As String = "localhost"
    Dim username As String = "root"
    Dim password As String = ""
    Dim id As String = ""
    Dim query As String

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not conn Is Nothing Then conn.Close()
        conn.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, username, password, db)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name As String = TextBox1.Text
        Dim email As String = TextBox2.Text
        Dim sslc As Double = TextBox3.Text
        Dim puc As Double = TextBox4.Text
        Dim ug As Double = TextBox5.Text
        Dim stream As String

        If RadioButton1.Checked = True Then
            stream = RadioButton1.Text
        Else
            stream = RadioButton2.Text
        End If

        Try
            conn.Open()
        Catch ex As Exception
        End Try

        Dim query As String = "INSERT INTO `data`(`Name`, `Email`, `SSLC`, `PUC`, `UG`, `Stream`) VALUES ('" & name & "','" & email & "','" & sslc & "','" & puc & "','" & ug & "','" & stream & "')"
        Dim mycmd As New MySql.Data.MySqlClient.MySqlCommand(query, conn)

        mycmd.ExecuteNonQuery()


        Me.Hide()
        Form3.Show()


        conn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Form1.Show()
    End Sub


End Class