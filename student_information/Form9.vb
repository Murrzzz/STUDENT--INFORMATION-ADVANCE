Imports System.Data
Imports System.Data.OleDb

Public Class Form9

    Dim studentID As String

    Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Administrator\Documents\Visual Studio 2010\Projects\STUDENT INFORMATION ADVANCE\student_information\bin\Database.accdb")
    Private Sub Form9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet29.Student_Information' table. You can move, or remove it, as needed.
        Me.Student_InformationTableAdapter9.Fill(Me.DatabaseDataSet29.Student_Information)
        'TODO: This line of code loads data into the 'Mainn.Student_Information' table. You can move, or remove it, as needed.
        Me.Student_InformationTableAdapter8.Fill(Me.Mainn.Student_Information)


        SelectAll_StudInfo()
        SelectAll_StudInformation()
        total()

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

    Private Sub SelectAll_StudInfo() 'first panel
        Dim StudInfo As New OleDbDataAdapter("SELECT * From[Student_Information] where[Course_Code]='" & Form8.Course & "' AND [Stud_Year]='" & Form8.Year & "' AND [Sem_ID]=" & Form8.Sem & " AND [Department]='" & Form8.Department & "'AND [Year_Level]='" & Form8.YearL & "'", connection)
        Dim tabl As New DataTable
        StudInfo.Fill(tabl)
        dgvStudentInfo.DataSource = tabl

        dgvStudentInfo.AllowUserToAddRows = False
        dgvStudentInfo.EditMode = DataGridViewEditMode.EditProgrammatically
        dgvStudentInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub
    Private Sub SelectAll_StudInformation() 'second panel
        Dim StudInfo As New OleDbDataAdapter("SELECT * From[Student_Information] where[Course_Code]='" & Form8.Course & "' AND [Stud_Year]='" & Form8.Year & "' AND [Sem_ID]=" & Form8.Sem & " AND [Department]='" & Form8.Department & "' AND [Year_Level]='" & Form8.YearL & "'", connection)
        Dim tabl As New DataTable
        StudInfo.Fill(tabl)
        dgvStudentInformation.DataSource = tabl

        dgvStudentInformation.AllowUserToAddRows = False
        dgvStudentInformation.EditMode = DataGridViewEditMode.EditProgrammatically
        dgvStudentInformation.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub


    Private Sub total()

        connection.Open()



        Dim StudInfo As New OleDbCommand("SELECT Count(*) From[Student_Information] where[Course_Code]='" & Form8.Course & "' AND [Stud_Year]='" & Form8.Year & "' AND [Sem_ID]=" & Form8.Sem & " AND [Department]='" & Form8.Department & "'", connection)
        Dim tabl As New DataTable
        Dim Count = Convert.ToInt32(StudInfo.ExecuteScalar)

        lblTotal.Text = Count
        connection.Close()

    End Sub
    Private Sub filter()

        connection.Open()


        Dim semester As Integer

        If cmbSemester.Text = "FIRST SEMESTER" Then
            semester = 1
        ElseIf cmbSemester.Text = "SECOND SEMESTER" Then
            semester = 2
        ElseIf cmbSemester.Text = "SUMMER" Then
            semester = 3
        End If

        'to display the total================================================================
        Dim StudInfo_total As New OleDbCommand("SELECT count(*) From[Student_Information] where[Course_Code]='" & cmbCourse.Text & "' AND [Stud_Year]='" & cmbSchoolYear.Text & "' AND [Sem_ID]=" & semester & " AND [Department]='" & cmbDepartment.Text & "'", connection)

        Dim Count = Convert.ToInt32(StudInfo_total.ExecuteScalar)

        lblTotal.Text = Count
        '====================================================================================
        Dim StudInfo As New OleDbDataAdapter("SELECT * From[Student_Information] where[Course_Code]='" & cmbCourse.Text & "' AND [Stud_Year]='" & cmbSchoolYear.Text & "' AND [Sem_ID]=" & semester & " AND [Department]='" & cmbDepartment.Text & "'", connection)
        Dim tabl As New DataTable


        StudInfo.Fill(tabl)
        dgvStudentInfo.DataSource = tabl

        dgvStudentInfo.AllowUserToAddRows = False
        dgvStudentInfo.EditMode = DataGridViewEditMode.EditProgrammatically
        dgvStudentInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        connection.Close()
    End Sub



    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtSearch.Text = ""
        cmbSearch.Text = ""


        SelectAll_StudInfo()
        filter()



    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CopyDeletedfiles() 'this funtion is copy yung delete na file sa retrieve table
        actual_delete() 'this the function kung saan delete yung data sa Student Information table

        SelectAll_StudInfo()
    End Sub
    Private Sub actual_delete()
        connection.Open()

        Dim del1 As String

        del1 = "Delete from[Student_Information] where[Stud_ID]='" & studentID & "'"
        Dim cmd As New OleDbCommand(del1, connection)


        Try
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        connection.Close()

    End Sub


    Private Sub CopyDeletedfiles() 'copy the deleted file in retrieve table
        connection.Open()
        Dim del As String
        MsgBox(studentID)
        del = "insert into[Retrieve] Select * from[Student_Information] where[Stud_ID]='" & studentID & "'"

        Dim cmd As New OleDbCommand(del, connection)

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try




        connection.Close()
    End Sub



    Private Sub dgvStudentInfo_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)


        studentID = dgvStudentInfo.SelectedRows(0).Cells(0).Value.ToString()



    End Sub

    Private Sub txtExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtExit.Click
        Me.Close()
        Form4.Show()

    End Sub


    Private Sub Search()
        Try
           

            Dim Search As New OleDbDataAdapter("SELECT * From[Student_Information] where[" & cmbSearch.Text & "]='" & txtSearch.Text & "' ", connection)
            MsgBox(cmbSearch.Text)
            Dim tabl As New DataTable
            Search.Fill(tabl)
            dgvStudentInfo.DataSource = tabl

            dgvStudentInfo.AllowUserToAddRows = False
            dgvStudentInfo.EditMode = DataGridViewEditMode.EditProgrammatically
            dgvStudentInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvStudentInformation_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvStudentInformation.CellContentClick
        Dim arrImage() As Byte

        txtStudent_ID.Text = dgvStudentInformation.SelectedRows(0).Cells(0).Value.ToString()
        txtFname.Text = dgvStudentInformation.SelectedRows(0).Cells(1).Value.ToString()
        txtMname.Text = dgvStudentInformation.SelectedRows(0).Cells(2).Value.ToString()
        txtLname.Text = dgvStudentInformation.SelectedRows(0).Cells(3).Value.ToString()
        cmbCourse_ID.Text = dgvStudentInformation.SelectedRows(0).Cells(4).Value.ToString()
        cmbYear.Text = dgvStudentInformation.SelectedRows(0).Cells(5).Value.ToString()
        txtContact.Text = dgvStudentInformation.SelectedRows(0).Cells(6).Value.ToString()
        txtBirthdate.Text = dgvStudentInformation.SelectedRows(0).Cells(7).Value.ToString()
        txtAge.Text = dgvStudentInformation.SelectedRows(0).Cells(8).Value.ToString()
        cmbSex.Text = dgvStudentInformation.SelectedRows(0).Cells(9).Value.ToString()
        txtNickName.Text = dgvStudentInformation.SelectedRows(0).Cells(10).Value.ToString()
        txtCivilStatus.Text = dgvStudentInformation.SelectedRows(0).Cells(11).Value.ToString()
        txtReligion.Text = dgvStudentInformation.SelectedRows(0).Cells(12).Value.ToString()
        txtPlaceOfBirth.Text = dgvStudentInformation.SelectedRows(0).Cells(13).Value.ToString()
        txtAddress.Text = dgvStudentInformation.SelectedRows(0).Cells(14).Value.ToString()
        txtStudent.Text = dgvStudentInformation.SelectedRows(0).Cells(15).Value.ToString()
        'para makita yung picture sa picture box1
        arrImage = dgvStudentInformation.SelectedRows(0).Cells(16).Value

        Dim mstream As New System.IO.MemoryStream(arrImage)
        PictureBox1.Image = Image.FromStream(mstream)

    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        pnlView.Hide()
        pnlSelectAll.Show()

    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        pnlSelectAll.Hide()

        pnlView.Show()

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        connection.Open()


        If txtSearch.Text = Nothing Then
            MsgBox("Fill the blank")
        ElseIf cmbSearch.Text = Nothing Then
            MsgBox("Choose the Catergory")
        Else
            Search()
        End If




        connection.Close()
    End Sub

    Private Sub btnDelete_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim result As DialogResult = MessageBox.Show("Are You Sure Do you want to Delete?", "Warning", MessageBoxButtons.YesNo)
        If studentID = Nothing Then
            MsgBox("Select Item to Delete")
        Else
            If result = DialogResult.Cancel Then
                MessageBox.Show("Cancelled")
            ElseIf result = DialogResult.No Then

            ElseIf result = DialogResult.Yes Then
                CopyDeletedfiles() 'this funtion is copy yung delete na file sa retrieve table
                actual_delete() 'this the function kung saan delete yung data sa Student Information table
                MessageBox.Show("Deleted")
            End If
        End If
        SelectAll_StudInfo()
    End Sub

    Private Sub dgvStudentInfo_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvStudentInfo.CellContentClick
        studentID = dgvStudentInfo.SelectedRows(0).Cells(0).Value.ToString()
    End Sub

    Private Sub btnRefresh_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        txtSearch.Text = ""
        cmbSearch.Text = ""


        SelectAll_StudInfo()
        filter()
    End Sub

    Private Sub pnlSelectAll_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlSelectAll.Paint

    End Sub
End Class