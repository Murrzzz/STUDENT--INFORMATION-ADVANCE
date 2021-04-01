
Imports System.Data
Imports System.Data.OleDb

Public Class Form4
    Dim categ As String 'this var is for the category of the filter
    Dim semester As Integer 'thi var is for Sem_id because of the data type I separate this variable

    Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Administrator\Documents\Visual Studio 2010\Projects\STUDENT INFORMATION ADVANCE\student_information\bin\Database.accdb")

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        ' Label6.Text = Nothing
        Form1.guest = "bawal"

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form5.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form6.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form7.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form8.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub txtExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtExit.Click
        Me.Hide()
        Form3.Show()

    End Sub

    Private Sub Button2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
        'Button2.Image = My.Resources.hover222

    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        'Button2.Image = My.Resources.hover111
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pnlDash.Hide()
        pnlMain.Show()

        Value()
        refresh_dash()
        
    End Sub
    Private Sub Value() 'give value to the combobox galing sa Settings
        Dim semester1 As String

        If Form8.Sem = 1 Then
            semester1 = "FIRST SEMESTER"
        ElseIf Form8.Sem = 2 Then
            semester1 = "SECOND SEMESTER"
        ElseIf Form8.Sem = 3 Then
            semester1 = "SUMMER"
        End If

        cmbCourse.Text = Form8.Course
        cmbDepartment.Text = Form8.Department
        cmbSchoolYear.Text = Form8.Year
        cmbSemester.Text = semester1

    End Sub
    Private Sub refresh_dash() 'to refresh the data in the dashoard
        Admin_Name()
        total_Irregular()
        total_Regular()
        total_Drop()
        total_Transferee()

    End Sub
    Private Sub total_Regular() 'to display the number of regular Students

        connection.Open()

        Dim StudInfo As New OleDbCommand("SELECT Count(StudentsStatus) From[Student_Information] where[StudentsStatus]='New Student' or [StudentsStatus]='Old Student' or [StudentsStatus]='Returnee'", connection)

        Dim Count = Convert.ToInt32(StudInfo.ExecuteScalar)

        lblRegular.Text = Count
        connection.Close()

    End Sub
    Private Sub total_Irregular() 'to display the number of irregular Students

        connection.Open()

        Dim StudInfo As New OleDbCommand("SELECT Count(StudentsStatus) From[Student_Information] where[StudentsStatus]='Irregular Student'", connection)

        Dim Count = Convert.ToInt32(StudInfo.ExecuteScalar)

        lblIrregular.Text = Count
        connection.Close()

    End Sub

    Private Sub total_Drop() 'to display the number of irregular Students

        connection.Open()

        Dim StudInfo As New OleDbCommand("SELECT Count(StudentsStatus) From[Student_Information] where[StudentsStatus]='Drop'", connection)

        Dim Count = Convert.ToInt32(StudInfo.ExecuteScalar)

        lblDrop.Text = Count
        connection.Close()

    End Sub
    Private Sub total_Transferee() 'to display the number of irregular Students

        connection.Open()

        Dim StudInfo As New OleDbCommand("SELECT Count(StudentsStatus) From[Student_Information] where[StudentsStatus]='Transferee'", connection)

        Dim Count = Convert.ToInt32(StudInfo.ExecuteScalar)

        lblTransferee.Text = Count
        connection.Close()

    End Sub


    Private Sub Admin_Name() 'to display the full name of the Admin


        connection.Close()
        connection.Open()


        Dim cmd As New OleDbCommand("SELECT [Full_Name] From[Login]", connection)
        Dim name = Convert.ToString(cmd.ExecuteScalar)
        txtName.Text = name
        connection.Close()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnNext1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()

        Form8.Show()

    End Sub

    Private Sub Button2_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Form8.Year = Nothing And Form8.Sem = Nothing And Form8.Department = Nothing And Form8.Course = Nothing Then

            MsgBox("Please Create or Select to the Settings the School Year and Department")
        Else
            Form9.Show()


        End If
    End Sub

 
    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        connection.Open()

        refresh_process()




        connection.Close()
    End Sub
    Private Sub refresh_process()
        connection.Close()
        connection.Open()

        If cmbCourse.Text = Nothing Or cmbDepartment.Text = Nothing Or cmbSchoolYear.Text = Nothing Or cmbSemester.Text = Nothing Then
            MsgBox("Fill the blanks")

        ElseIf cmbCourse.Text = "ALL" And cmbDepartment.Text = "ALL" And cmbSchoolYear.Text = "ALL" And cmbSemester.Text = "ALL" Then
            refresh_dash()

        Else

            process()

        End If




        connection.Close()
    End Sub
    Private Sub Select_all()
    End Sub
    Private Sub process()
        Dim semester As Integer

        If cmbSemester.Text = "FIRST SEMESTER" Then
            semester = 1
        ElseIf cmbSemester.Text = "SECOND SEMESTER" Then
            semester = 2
        ElseIf cmbSemester.Text = "SUMMER" Then
            semester = 3
        End If

        Dim cmd_regular As New OleDbCommand("SELECT Count(StudentsStatus) From[Student_Information] where[Course_Code]='" & cmbCourse.Text & "' AND [Stud_Year]='" & cmbSchoolYear.Text & "' AND [Sem_ID]=" & semester & " AND [Department]='" & cmbDepartment.Text & "' AND [StudentsStatus]='New Student' or [StudentsStatus]='Old Student' or [StudentsStatus]='Returnee' ", connection)

        Dim Countt = Convert.ToInt32(cmd_regular.ExecuteScalar)
        MsgBox(Countt)
        lblRegular.Text = Countt

        Dim cmd_Irregular As New OleDbCommand("SELECT Count(StudentsStatus) From[Student_Information] where[Course_Code]='" & cmbCourse.Text & "' AND [Stud_Year]='" & cmbSchoolYear.Text & "' AND [Sem_ID]=" & semester & " AND [Department]='" & cmbDepartment.Text & "' AND [StudentsStatus]='Irregular Student'", connection)

        Dim Count1 = Convert.ToInt32(cmd_Irregular.ExecuteScalar)

        lblIrregular.Text = Count1


        Dim cmd_Drop As New OleDbCommand("SELECT Count(StudentsStatus) From[Student_Information] where[Course_Code]='" & cmbCourse.Text & "' AND [Stud_Year]='" & cmbSchoolYear.Text & "' AND [Sem_ID]=" & semester & " AND [Department]='" & cmbDepartment.Text & "' AND [StudentsStatus]='Drop'", connection)

        Dim Count2 = Convert.ToInt32(cmd_Drop.ExecuteScalar)

        lblDrop.Text = Count2


        Dim cmd_Transferee As New OleDbCommand("SELECT Count(StudentsStatus) From[Student_Information] where[Course_Code]='" & cmbCourse.Text & "' AND [Stud_Year]='" & cmbSchoolYear.Text & "' AND [Sem_ID]=" & semester & " AND [Department]='" & cmbDepartment.Text & "' AND [StudentsStatus]='Transferee'", connection)

        Dim Count3 = Convert.ToInt32(cmd_Transferee.ExecuteScalar)

        lblTransferee.Text = Count3


    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        pnlMain.Show()
        pnlDash.Hide()

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        pnlDash.Show()
        pnlMain.Hide()

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Hide()
        Form8.Show()
        Form8.hidepanels()
        Form8.pnlUser.Show()
        Form8.hover = 5
        Form8.Panel_Hover()
    End Sub

    Private Sub pnlDash_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlDash.Paint
        Value()
    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click

    End Sub
End Class