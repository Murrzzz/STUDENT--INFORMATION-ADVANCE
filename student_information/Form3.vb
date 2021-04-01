Imports System.Data.OleDb
Imports System.Data
Public Class Form3
    Dim date_now As Date

    Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Administrator\Documents\Visual Studio 2010\Projects\student_information\student_information\bin\USER_ADMIN.accdb")
    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        Dim Sttr As String





            connection.Open()




            Sttr = "insert into admin([username],[password],[date_created]) Values(?,?,?)"
            Dim cmd As New OleDbCommand(Sttr, connection)

            date_now = Now 'containing date

        'cmd.Parameters.Add(New OleDbParameter("username", CType(TextBox1.Text, String)))
        'cmd.Parameters.Add(New OleDbParameter("password", CType(TextBox2.Text, String)))
        'cmd.Parameters.Add(New OleDbParameter("date_created", CType(date_now, String)))

            Try
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                connection.Close()
            '        TextBox1.Clear()
            '       TextBox2.Clear()
                MsgBox("registered")
                Me.Close()
            Catch ex As Exception
                MsgBox("registered")
                Me.Close()

            End Try


        'End If
    End Sub


    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load








    End Sub

    Private Sub btnMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMain.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click


        If Form8.Year = Nothing Or Form8.Sem = Nothing Or Form8.Department = Nothing Or Form8.Course = Nothing Then

            MsgBox("Please Create or Select to the Settings the School Year and Department")
        Else
            Me.Hide()
            Form5.Show()



        End If

       
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If Form8.Year = Nothing Or Form8.Sem = Nothing Or Form8.Department = Nothing Or Form8.Course = Nothing Then

            MsgBox("Please Create or Select to the Settings the School Year and Department")
        Else

            Me.Hide()
            Form6.Show()
        End If
    End Sub

    Private Sub btnRetrieve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetrieve.Click
        If Form8.Year = Nothing Or Form8.Sem = Nothing Or Form8.Department = Nothing Or Form8.Course = Nothing Then

            MsgBox("Please Create or Select to the Settings the School Year and Department")
        Else
            Me.Hide()
            Form7.Show()
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form1.Close()

    End Sub
End Class