Imports System.Data
Imports System.Data.OleDb


Public Class Form8
    Public Property hover As Integer = 0
    Dim Sem_ID As Integer
    Dim Count As String


    'I will get all the data in  all primary keys
    'To connect in the main table StudentInformation
    Public Property Year As String
    Public Property Sem As Integer
    Public Property Department As String
    Public Property Course As String
    Public Property YearL As String

    Dim upd1 As String 'to update the student data


    Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Administrator\Documents\Visual Studio 2010\Projects\STUDENT INFORMATION ADVANCE\student_information\bin\Database.accdb")
  

    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Save._Save' table. You can move, or remove it, as needed.
        Me.SaveTableAdapter2.Fill(Me.Save._Save)
        'TODO: This line of code loads data into the 'Saves.Save' table. You can move, or remove it, as needed.
        Me.SaveTableAdapter1.Fill(Me.Saves.Save)
        'TODO: This line of code loads data into the 'DatabaseDataSet22.Save' table. You can move, or remove it, as needed.
        Me.SaveTableAdapter.Fill(Me.DatabaseDataSet22.Save)
        'TODO: This line of code loads data into the 'DatabaseDataSet14.SchoolYear' table. You can move, or remove it, as needed.
        Me.SchoolYearTableAdapter2.Fill(Me.DatabaseDataSet14.SchoolYear)
        'TODO: This line of code loads data into the 'DatabaseDataSet3.SchoolYear' table. You can move, or remove it, as needed.
        Me.SchoolYearTableAdapter1.Fill(Me.DatabaseDataSet3.SchoolYear)
        pnlCourse.Hide()
        pnlDepartment.Hide()
        pnlSchoolYear.Hide()
        pnlSetSemester.Hide()



        Dim adp As New OleDbDataAdapter("SELECT * From [Department]", connection)
        Dim table_department As New DataTable
        adp.Fill(table_department)
        dgvDepartment.DataSource = table_department

        dgvDepartment.Columns.Item("Department_N").Width = 140
        dgvDepartment.Columns.Item("Dean").Width = 140
        dgvDepartment.Columns.Item("Description").Width = 300

        dgvDepartment.AllowUserToAddRows = False
        dgvDepartment.EditMode = DataGridViewEditMode.EditProgrammatically
        dgvDepartment.SelectionMode = DataGridViewSelectionMode.FullRowSelect


        Dim Crs As New OleDbDataAdapter("SELECT * From [Course]", connection) 'THE COURSE TABLE HERE<<<<<<<<<<<<<<<<<<<<<<<
        Dim table_Course As New DataTable
        Crs.Fill(table_Course)
        dgvCourse.DataSource = table_Course

        dgvCourse.Columns.Item("Course_Code").Width = 140
        dgvCourse.Columns.Item("Department").Width = 140
        dgvCourse.Columns.Item("Year_Level").Width = 140
        dgvCourse.Columns.Item("Description").Width = 200

        dgvCourse.AllowUserToAddRows = False
        dgvCourse.EditMode = DataGridViewEditMode.EditProgrammatically
        dgvCourse.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        select_save()


       

    End Sub
    Private Sub btnSchoolYear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSchoolYear.Click
        hidepanels()

        pnlSchoolYear.Show()
        hover = 0
        hover = 1
        Panel_Hover()


    End Sub
    Private Sub btnSemester_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSemester.Click
        hidepanels()

        pnlSetSemester.Show()
        hover = 2
        Panel_Hover()
    End Sub
    Private Sub btnCourse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCourse.Click
        hidepanels()

        pnlCourse.Show()
        hover = 3
        Panel_Hover()

    End Sub
    Private Sub btnDepartment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDepartment.Click
        hidepanels()

        pnlDepartment.Show()
        hover = 4
        Panel_Hover()

    End Sub

    Private Sub BtnUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUser.Click
        hidepanels()
        pnlUser.Show()
        hover = 5
        Panel_Hover()


    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        hidepanels()
        pnlSave.Show()
        hover = 6
        Panel_Hover()

    End Sub

    Public Sub hidepanels() 'to hide panels
        pnlCourse.Hide()
        pnlDepartment.Hide()
        pnlSchoolYear.Hide()
        pnlSetSemester.Hide()
        pnlUser.Hide()
        pnlSave.Hide()


    End Sub
    Public Sub Panel_Hover() 'to change the value or the color of the button when it click
        Dim color1 As Object = Color.FromArgb(24, 25, 40)
        Dim text1 As Object = Color.White


        If hover = 1 Then
            default_hover() 'i put the function here  so when i click other button it goes back to the default color

            btnSchoolYear.BackColor = Color.FromArgb(24, 25, 40)
            btnSchoolYear.ForeColor = Color.White
        ElseIf hover = 2 Then
            default_hover()

            btnSemester.BackColor = color1
            btnSemester.ForeColor = text1
        ElseIf hover = 3 Then
            default_hover()

            btnCourse.BackColor = color1
            btnCourse.ForeColor = text1
        ElseIf hover = 4 Then
            default_hover()

            btnDepartment.BackColor = color1
            btnDepartment.ForeColor = text1
        ElseIf hover = 5 Then
            default_hover()

            BtnUser.BackColor = color1
            BtnUser.ForeColor = text1
        ElseIf hover = 6 Then
            default_hover()

            btnSave.BackColor = color1
            btnSave.ForeColor = text1

        End If

    End Sub
    Public Sub default_hover() 'to make the button as a default color
        Dim color2 As Object = Color.FromArgb(3, 225, 228)
        Dim text2 As Object = Color.Black

        btnSchoolYear.BackColor = color2
        btnSchoolYear.ForeColor = text2

        btnSemester.BackColor = color2
        btnSemester.ForeColor = text2

        btnCourse.BackColor = color2
        btnCourse.ForeColor = text2


        btnDepartment.BackColor = color2
        btnDepartment.ForeColor = text2

        BtnUser.BackColor = color2
        BtnUser.ForeColor = text2

        btnSave.BackColor = color2
        btnSave.ForeColor = text2


    End Sub


    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        connection.Open()


        Dim School_Year As String = ("" & txtFrom.Text & "-" & txtTo.Text & "")
        lblCurrent.Text = School_Year
        Dim year As String


        year = "insert into SchoolYear([Stud_Year]) Values(?) "
        Dim cmd As New OleDbCommand(year, connection)

        cmd.Parameters.Add(New OleDbParameter("Stud_Year", CType(lblCurrent.Text, String))) 'I use the current text to insert into the Database

        Try
            cmd.ExecuteNonQuery()
            MsgBox("Create Successfully")
        Catch ex As Exception
            MsgBox("Check the Combo box The School Year You Entered is already Exist!")
        End Try

        connection.Close()
    End Sub

    Private Sub btnSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSet.Click
        connection.Open()




        Dim School_Year As String = ("" & txtFrom.Text & "-" & txtTo.Text & "")

        Dim year_set As String

        lblCurrent.Text = cmbSchoolYear.Text







        MsgBox("Set Successfully")
        connection.Close()




    End Sub

    Private Sub btnSetSemester_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetSemester.Click
        connection.Close()

        connection.Open()

        lblCurrent2.Text = cmbSemester.Text

        If cmbSemester.Text = "FIRST SEMESTER" Then
            Sem_ID = 1 'THE VARIABLE SEM_ID IS GLOBAL VARIABLE
        ElseIf cmbSemester.Text = "SECOND SEMESTER" Then
            Sem_ID = 2
        ElseIf cmbSemester.Text = "SUMMER" Then
            Sem_ID = 3

        End If

      



            MsgBox("Set Successfully")
      
        connection.Close()
    End Sub

   
    Private Sub btnAddDepartment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddDepartment.Click
        connection.Open()
        Dim add_department As String 'Department ADD<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<


        add_department = "insert into Department([Department_N],[Dean],[Description]) Values(?,?,?) "
        Dim cmd As New OleDbCommand(add_department, connection)

                cmd.Parameters.Add(New OleDbParameter("Department", CType(txtDepartment.Text, String))) 'Department ADD
        cmd.Parameters.Add(New OleDbParameter("Dean", CType(txtDean.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Description", CType(txtDepartmentDecript.Text, String)))

        Try
            cmd.ExecuteNonQuery()
            SelectAll_Department() 'to select all from the table

            MsgBox("Add Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try




        connection.Close()
    End Sub

    Private Sub btnUpdateDepartment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateDepartment.Click
        connection.Close()
        connection.Open()

        'connection.Open()


        Dim update_department As String


        update_department = "update[Department] Set[Department_N]='" & txtDepartment.Text & "',[Dean]='" & txtDean.Text & "',[Description]='" & txtDepartmentDecript.Text & "' Where[Department_N]='" & txtDepartment.Text & "' or [Dean]='" & txtDean.Text & "' or [Description]='" & txtDepartmentDecript.Text & "' "
        Dim cmd As New OleDbCommand(update_department, connection)

        cmd.Parameters.Add(New OleDbParameter("Department", CType(txtDepartment.Text, String))) 'Department ADD
        cmd.Parameters.Add(New OleDbParameter("Dean", CType(txtDean.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Description", CType(txtDepartmentDecript.Text, String)))

        Try
            cmd.ExecuteNonQuery()
            SelectAll_Department() 'to select all from the table

            MsgBox("Update Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
            connection.Close()
    End Sub

    Private Sub dgvDepartment_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDepartment.CellContentClick
        'To select all data in department table
        txtDepartment.Text = dgvDepartment.SelectedRows(0).Cells(0).Value.ToString
        txtDean.Text = dgvDepartment.SelectedRows(0).Cells(1).Value.ToString
        txtDepartmentDecript.Text = dgvDepartment.SelectedRows(0).Cells(2).Value.ToString




    End Sub

    Private Sub btnDeleteDepartment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteDepartment.Click
        connection.Open()

        Dim delete_department As New OleDbDataAdapter("Delete from [Department] where[Department_N]='" & txtDepartment.Text & "'", connection)
        Dim dept_table As New DataTable
        delete_department.Fill(dept_table)
        dgvDepartment.DataSource = dept_table

        


        MsgBox("Delete Successfully")
        SelectAll_Department() ' to select all from Department

        connection.Close()
    End Sub

    Private Sub SelectAll_Department()

        Dim all As New OleDbDataAdapter("Select * from[Department]", connection)
        Dim table_dept As New DataTable
        all.Fill(table_dept)
        dgvDepartment.DataSource = table_dept

        dgvDepartment.Columns.Item("Department_N").Width = 140
        dgvDepartment.Columns.Item("Dean").Width = 140
        dgvDepartment.Columns.Item("Description").Width = 300


    End Sub

    Private Sub btnAddCourse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddCourse.Click
        connection.Open()
        Dim add_course As String 'course ADD<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<


        add_course = "insert into Course([Course_Code],[Department],[Year_Level],[Description]) Values(?,?,?,?) "
        Dim cmd As New OleDbCommand(add_course, connection)

        cmd.Parameters.Add(New OleDbParameter("Department", CType(txtCourseCode.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Department", CType(cmbDepartment.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Dean", CType(cmbYearLevel.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Description", CType(txtDescriptionCourse.Text, String)))

        Try
            cmd.ExecuteNonQuery()
            SelectAll_Course() 'to select all from the table

            MsgBox("Add Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try




        connection.Close()
    End Sub
    Private Sub SelectAll_Course()

        Dim Crs As New OleDbDataAdapter("SELECT * From [Course]", connection) 'THE COURSE TABLE HERE<<<<<<<<<<<<<<<<<<<<<<<
        Dim table_Course As New DataTable
        Crs.Fill(table_Course)
        dgvCourse.DataSource = table_Course

        dgvCourse.Columns.Item("Course_Code").Width = 140
        dgvCourse.Columns.Item("Department").Width = 140
        dgvCourse.Columns.Item("Year_Level").Width = 140
        dgvCourse.Columns.Item("Description").Width = 200
    End Sub

    Private Sub dgvCourse_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCourse.CellContentClick
        Try
            txtCourseCode.Text = dgvCourse.SelectedRows(0).Cells(0).Value
            cmbDepartment.Text = dgvCourse.SelectedRows(0).Cells(1).Value
            cmbYearLevel.Text = dgvCourse.SelectedRows(0).Cells(2).Value
            txtDescriptionCourse.Text = dgvCourse.SelectedRows(0).Cells(3).Value
            cmbYearLevel.Text = dgvCourse.SelectedRows(0).Cells(4).Value

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnDeleteCourse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteCourse.Click
        connection.Open()

        Dim delete_department As New OleDbDataAdapter("Delete from [Course] where[Course_Code]='" & txtCourseCode.Text & "'", connection)
        Dim dept_table As New DataTable
        delete_department.Fill(dept_table)
        dgvCourse.DataSource = dept_table




        MsgBox("Delete Successfully")
        SelectAll_Course()

        connection.Close()
    End Sub

    Private Sub btnUpdateCourse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateCourse.Click
        connection.Open()
        Try

            Dim update_course As String


            update_course = "update[Course] Set[Course_Code]='" & txtCourseCode.Text & "',[Department]='" & cmbDepartment.Text & "',[Year_Level]='" & cmbYearLevel.Text & "',[Description]='" & txtDescriptionCourse.Text & "' Where[Course_Code]='" & txtCourseCode.Text & "' or [Department]='" & cmbDepartment.Text & "' or [Year_Level]='" & cmbYearLevel.Text & "' or [Description]='" & txtDescriptionCourse.Text & "'"
            Dim cmd As New OleDbCommand(update_course, connection)

            cmd.Parameters.Add(New OleDbParameter("Course_Code", CType(txtCourseCode.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Department", CType(cmbDepartment.Text, String))) 'Department ADD
            cmd.Parameters.Add(New OleDbParameter("YearLevel", CType(cmbYearLevel.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Description", CType(txtDescriptionCourse.Text, String)))



            cmd.ExecuteNonQuery()
            SelectAll_Course() 'to select all from the table

            MsgBox("Update Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connection.Close()
    End Sub

    Private Sub txtExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtExit.Click
        connection.Close()

        connection.Open()

        Dim Save_Settings As String 'When you exit the data will be inserted to Student Information Table

      


        Dim Stop_Repetition As New OleDbCommand("Select count(*) from[Student_Information] where[Course_Code]='" & Course & "' AND [Stud_Year]='" & Year & "' AND [Sem_ID]=" & Sem & " AND [Department]='" & Department & "'", connection)
        Dim count = Convert.ToInt32(Stop_Repetition.ExecuteScalar)
       
        'The data of all primary key
        Year = lblCurrent.Text 'School Year
        Sem = Sem_ID 'Semester
        Department = txtDepartment.Text 'The Department
        Course = txtCourseCode.Text 'The Course
        YearL = cmbYearLevel.Text 'Year Level

        Form4.Show()
        Me.Hide()
        If lblCurrent.Text = Nothing And Sem_ID = Nothing And txtDepartment.Text = Nothing And txtCourseCode.Text = Nothing Then

            MsgBox("Please Set the Settings First!")
            'Form4.Show()
            'Me.Hide()

            connection.Close()
        Else 'count > 0 Then if the data has duplicate means the count will be 1 or greater than 0

            'The data of all primary key
            Year = lblCurrent.Text 'School Year
            Sem = Sem_ID 'Semester
            Department = txtDepartment.Text 'The Department
            Course = txtCourseCode.Text 'The Course
            Form4.Show()
            Me.Hide()

            connection.Close()

       
        End If

    End Sub
    Private Sub oldpass() 'old password to update the new password

        connection.Close()
        connection.Open()
        Dim cmd_old As New OleDbCommand("SELECT [Password] From[Login]", connection)

        Count = Convert.ToString(cmd_old.ExecuteScalar)


        connection.Close()
    End Sub
    Private Sub clear_Acc()
        txtFullname.Text = ""
        txtUsername.Text = ""
        txtOldPassword.Text = ""
        txtPassword.Text = ""
        txtCpassword.Text = ""
        lblInvalid.Text = ""
        lblInvalid1.Text = ""
    End Sub
    Private Sub btnUserClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUserClear.Click
        clear_Acc()
    End Sub
    Private Sub txtAccUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccUpdate.Click
        oldpass() 'to give the value to this function
        connection.Open()

        Dim update_Acc As String

        If txtUsername.Text = Nothing Or txtFullname.Text = Nothing Or txtPassword.Text = Nothing Or txtUsername.Text = Nothing Or txtCpassword.Text = Nothing Then
            MsgBox("Fill the blanks")
            connection.Close()
        ElseIf lblInvalid.Text = "*INVALID!!" Then
            If txtPassword.Text = txtCpassword.Text Then
                lblInvalid.Text = ""
                connection.Close()
            End If
        ElseIf lblInvalid1.Text = "*INVALID" Then
            If txtOldPassword.Text = Count Then
                lblInvalid1.Text = ""
                connection.Close()
            End If
        ElseIf txtPassword.Text <> txtCpassword.Text Then
            lblInvalid.Text = "*INVALID!!"
            connection.Close()

        ElseIf txtOldPassword.Text <> Count Then
            lblInvalid1.Text = "*INVALID"
            connection.Close()


        ElseIf txtPassword.Text = txtCpassword.Text And Count = txtOldPassword.Text Then

            update_Acc = "Update [Login] set[User]='" & txtUsername.Text & "',[Password]='" & txtPassword.Text & "',[Full_Name]='" & txtFullname.Text & "'"
            Dim cmd As New OleDbCommand(update_Acc, connection)

            cmd.ExecuteNonQuery()


            MsgBox("Updated!")
            clear_Acc()
            connection.Close()

        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        connection.Open()

        txtDepartment.Text = ""
        txtDean.Text = ""
        txtDepartmentDecript.Text = ""

        connection.Close()
    End Sub

    Private Sub btnClearCourse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearCourse.Click
        connection.Open()

        cmbDepartment.Text = ""
        txtCourseCode.Text = ""
        cmbYearLevel.Text = ""
        txtDescriptionCourse.Text = ""

        connection.Close()
    End Sub

    Private Sub btnCreate_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate_save.Click
        connection.Close()
        connection.Close()
        connection.Open()
        Try
            Dim save As String

            'The data of all primary key
            Year = lblCurrent.Text 'School Year
            Sem = Sem_ID    'Semester
            Department = txtDepartment.Text 'The Department
            Course = txtCourseCode.Text 'The Course
            YearL = cmbYearLevel.Text

            save = "insert into Save([Data_Name],[Course],[Year],[Sem],[Department],[Year_Level]) values(?,?,?,?,?,?)"
            Dim cmd As New OleDbCommand(save, connection)

            cmd.Parameters.AddWithValue("Data_name", txtSave.Text)
            cmd.Parameters.AddWithValue("Course", Course)
            cmd.Parameters.AddWithValue("Year", Year)
            cmd.Parameters.AddWithValue("Sem", Sem)
            cmd.Parameters.AddWithValue("Department", Department)
            cmd.Parameters.AddWithValue("Department", cmbYearLevel.Text)

            cmd.ExecuteNonQuery()
            select_Save()
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            connection.Close()
        End Try

        connection.Close()
    End Sub
    Private Sub select_save()
        connection.Close()
        connection.Open()
        Dim cl As New OleDbDataAdapter("SELECT * From[Save]", connection) 'THE SAVE TABLE HERE<<<<<<<<<<<<<<<<<<<<<<<
        Dim table_Save As New DataTable
        cl.Fill(table_Save)
        dgvSave.DataSource = table_Save



        dgvSave.Columns.Item("Data_Name").Width = 500
        dgvSave.Columns.Item("Course").Width = 50
        dgvSave.Columns.Item("Year").Width = 50
        dgvSave.Columns.Item("Sem").Width = 50
        dgvSave.Columns.Item("Department").Width = 50


        dgvSave.AllowUserToAddRows = False
        dgvSave.EditMode = DataGridViewEditMode.EditProgrammatically
        dgvSave.SelectionMode = DataGridViewSelectionMode.FullRowSelect



        connection.Close()
    End Sub

    Private Sub dgvSave_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSave.CellContentClick
        Try

            'The data of all primary key
            Year = lblCurrent.Text 'School Year
            Sem = Sem_ID 'Semester
            Department = txtDepartment.Text 'The Department
            Course = txtCourseCode.Text 'The Course
            YearL = cmbYearLevel.Text



            txtSave.Text = dgvSave.SelectedRows(0).Cells(0).Value
            txtCourseCode.Text = dgvSave.SelectedRows(0).Cells(1).Value
            lblCurrent.Text = dgvSave.SelectedRows(0).Cells(2).Value
            Sem_ID = dgvSave.SelectedRows(0).Cells(3).Value
            txtDepartment.Text = dgvSave.SelectedRows(0).Cells(4).Value
            cmbYearLevel.Text = dgvSave.SelectedRows(0).Cells(5).Value


        Catch ex As Exception

        End Try
    End Sub
    Private Sub delete_tab() 'Delete in the Table save
        connection.Open()

        Dim delete_Save As New OleDbDataAdapter("Delete from [Save] where[Data_Name]='" & txtSave.Text & "'", connection)
        Dim save_table As New DataTable
        delete_Save.Fill(save_table)
        dgvSave.DataSource = save_table


        MsgBox("Delete Successfully")
        select_save()


        connection.Close()
    End Sub
    Private Sub delete_StudInfo() 'Delete in the Student Information table
        connection.Open()

        Dim delete_Save As String = "Delete from [Student_Information] where[Data_Name]='" & txtSave.Text & "'"
        Dim cmd As New OleDbCommand(delete_Save, connection)

        cmd.ExecuteNonQuery()

        connection.Close()
    End Sub
    Private Sub btnDelete_Load_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete_Load.Click
        delete_tab()
        delete_StudInfo()
        select_save()

    End Sub
    Private Sub btnSave_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave_save.Click
        Try
            connection.Open()

            connection.Close()
            connection.Open()

           
           



            '------------------------------------------------

            Dim upd As String 'for the copy of loading

            '   loadUpdate()  'to update the Student Information


            upd = "update[Save] set[Data_Name]='" & txtSave.Text & "',[Course]='" & txtCourseCode.Text & "',[Year]='" & lblCurrent.Text & "',[Sem]=" & Sem_ID & ",[Department]='" & txtDepartment.Text & "',[Year_Level]='" & cmbYearLevel.Text & "' where[Data_Name]='" & txtSave.Text & "'"

          

            Dim cmd As New OleDbCommand(upd, connection)
          
            cmd.ExecuteNonQuery()





            upd1 = "UPDATE Student_Information SET Data_Name= ?, Course_Code =?, Stud_Year = ?, Sem_ID = ?,Department = ?,Year_Level = ? WHERE Data_Name = ?"
            Dim cmd1 As New OleDbCommand(upd1, connection)


            cmd1.Parameters.Add(New OleDbParameter("Data_Name", CType(txtSave.Text, String)))
            cmd1.Parameters.Add(New OleDbParameter("Course_Code", CType(txtCourseCode.Text, String)))
            cmd1.Parameters.Add(New OleDbParameter("Stud_Year", CType(lblCurrent.Text, String)))
            cmd1.Parameters.AddWithValue("Sem_ID", Sem_ID)
            cmd1.Parameters.Add(New OleDbParameter("Data_Name", CType(txtDepartment.Text, String)))
            cmd1.Parameters.Add(New OleDbParameter("Data_Name", CType(cmbYearLevel.Text, String)))
            cmd1.Parameters.Add(New OleDbParameter("Data_Name", CType(txtSave.Text, String)))

            MsgBox(txtSave.Text)
            cmd1.ExecuteNonQuery()


            
            select_save()


            connection.Close()
            'loadUpdate()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub pnlDepartment_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlDepartment.Paint

    End Sub

    
End Class