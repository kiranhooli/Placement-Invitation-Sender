Imports System.Net.Mail
Imports MySql.Data.MySqlClient

Public Class Form5
    Dim conn As New MySqlConnection
    Dim db As String = "students"
    Dim server As String = "localhost"
    Dim username As String = "root"
    Dim password As String = ""
    Dim Smtp_Server As New SmtpClient
    Dim e_mail As New MailMessage()

    Dim sql As String

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not conn Is Nothing Then conn.Close()
        conn.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, username, password, db)

        Try
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("rlsbca.edu@gmail.com", "kiranhooli")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"
        Catch error_t As Exception
            MsgBox(error_t.ToString)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.Enabled = False
        Try
            conn.Open()

        Catch ex As Exception
        End Try

        Dim s As Double = Form4.TextBox4.Text
        Dim p As Double = Form4.TextBox5.Text
        Dim u As Double = Form4.TextBox6.Text

        Dim companyName As String = Form4.TextBox1.Text
        Dim post As String = Form4.TextBox2.Text
        Dim dates As String = Form4.DateTimePicker1.Value.Date.ToString
        Dim venue As String = Form4.TextBox3.Text

        Dim mailsub As String = companyName & " - Campus Drive Invitation"
        Dim msg As String = "KLE's College of BCA is organising campus drive for " & companyName + vbNewLine & " for the post of " & post & " dated on " & dates & " at " & venue + vbNewLine & " So we hereby request you to atend the campus drive. " & vbNewLine + vbNewLine & " Thank you "
        Dim id As String = ""
        Dim sname As String
        Dim count As Integer = 0

        sql = "SELECT * FROM `data` WHERE `SSLC` >= " & s & " AND `PUC` >= " & p & " AND `UG` >= " & u
        Dim mycmd As New MySql.Data.MySqlClient.MySqlCommand(sql, conn)
        Dim myReader As MySql.Data.MySqlClient.MySqlDataReader
        myReader = mycmd.ExecuteReader()





        If Form4.CheckBox1.Checked = True And Form4.CheckBox2.Checked = True Then

            While myReader.Read()
                id = myReader.GetString(1)
                sname = myReader.GetString(0)
                e_mail = New MailMessage()
                e_mail.From = New MailAddress("rlsbca.edu@gmail.com", "RLS BCA")
                e_mail.Subject = mailsub
                e_mail.IsBodyHtml = False
                e_mail.To.Add(id)
                e_mail.Body = "Hello, " & sname + vbNewLine + vbNewLine + msg
                Smtp_Server.Send(e_mail)
                count = count + 1
            End While

        ElseIf Form4.CheckBox1.Checked = True Then
            While myReader.Read()
                If myReader.GetString(5) = "BCA" Then
                    id = myReader.GetString(1)
                    sname = myReader.GetString(0)
                    e_mail = New MailMessage()
                    e_mail.From = New MailAddress("rlsbca.edu@gmail.com", "RLS BCA")
                    e_mail.Subject = mailsub
                    e_mail.IsBodyHtml = False
                    e_mail.To.Add(id)
                    e_mail.Body = "Hello, " & sname + vbNewLine + msg
                    Smtp_Server.Send(e_mail)
                    count = count + 1
                End If
            End While
        ElseIf Form4.CheckBox2.Checked = True Then
            While myReader.Read()
                If myReader.GetString(5) = "BBA" Then
                    id = myReader.GetString(1)
                    sname = myReader.GetString(0)
                    e_mail = New MailMessage()
                    e_mail.From = New MailAddress("rlsbca.edu@gmail.com", "RLS BCA")
                    e_mail.Subject = mailsub
                    e_mail.IsBodyHtml = False
                    e_mail.To.Add(id)
                    e_mail.Body = "Hello, " & sname + vbNewLine + msg
                    Smtp_Server.Send(e_mail)
                    count = count + 1
                End If
            End While
        End If
        conn.Close()
        Label1.ForeColor = Color.LawnGreen
        Label1.Text = count & " Students Invited."

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub
End Class