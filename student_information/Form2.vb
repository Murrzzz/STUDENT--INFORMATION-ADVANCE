Imports System.Data.OleDb
Imports System.Data



Public Class Form2
    Dim user As String = Nothing

    Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Administrator\Documents\Visual Studio 2010\Projects\STUDENT INFORMATION ADVANCE\student_information\bin\Database.accdb")
    Dim provider As String
    Dim file As String
    Dim connString As String
    Dim tries As Integer = 3

    Public Property user_name As String = "none" 'username <<<<'

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If tries = 1 Then
            MsgBox("Invalid Input Autmatic Close")

            Me.Close()
            Form1.Close()

        Else



            If txtUser.Text = Nothing Or txtPass.Text = Nothing Then
                MsgBox("Fill the Blanks")
            Else





                connection.Open()



                Dim cmd As New OleDbCommand("select count(*) from[Login] where User=? and Password=?", connection)
                cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = txtUser.Text
                cmd.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = txtPass.Text

                user_name = txtUser.Text

                Dim count = Convert.ToInt32(cmd.ExecuteScalar)
                If (count > 0) Then
                    MsgBox("Welcome " & txtUser.Text)
                    MsgBox("Login Succed")

                   


                    txtUser.Text = Nothing
                    txtPass.Text = Nothing
                    Form4.Show()
                    Me.Hide()
                    Me.Close()
                    Me.Close()

                    connection.Close()

                Else
                    tries -= 1
                    MsgBox("Invalid")
                    MsgBox("Number of Attempts " & tries)
                    txtUser.Text = Nothing
                    txtPass.Text = Nothing
                    connection.Close()
                End If
            End If
        End If
    End Sub
    


    Private Sub chkSpass_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSpass.CheckedChanged

        If chkSpass.CheckState = CheckState.Checked Then
            txtPass.UseSystemPasswordChar = True
        ElseIf chkSpass.CheckState = CheckState.Unchecked Then
            txtPass.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        MsgBox("Please contact the Admin or the Owner of the System")
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class