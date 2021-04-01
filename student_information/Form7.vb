Imports System.Data
Imports System.Data.OleDb

Public Class Form7
    Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Administrator\Documents\Visual Studio 2010\Projects\STUDENT INFORMATION ADVANCE\student_information\bin\Database.accdb")
    Dim studentID As String

   
    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet29.Student_Information' table. You can move, or remove it, as needed.
        Me.Student_InformationTableAdapter1.Fill(Me.DatabaseDataSet29.Student_Information)
        'TODO: This line of code loads data into the 'DatabaseDataSet27.Student_Information' table. You can move, or remove it, as needed.
        Me.Student_InformationTableAdapter.Fill(Me.DatabaseDataSet27.Student_Information)
        'TODO: This line of code loads data into the 'DatabaseDataSet21.Retrieve' table. You can move, or remove it, as needed.
        Me.RetrieveTableAdapter1.Fill(Me.DatabaseDataSet21.Retrieve)
        connection.Open()

        SelectAll_StudInfo()

        connection.Close()

    End Sub
    Private Sub SelectAll_StudInfo()
        connection.Close()
        connection.Open()

        Dim StudInfo As New OleDbDataAdapter("SELECT * From[Retrieve] where[Course_Code]='" & Form8.Course & "' AND [Stud_Year]='" & Form8.Year & "' AND [Sem_ID]=" & Form8.Sem & " AND [Department]='" & Form8.Department & "'", connection)
        Dim tabl As New DataTable
        StudInfo.Fill(tabl)
        dgvStudentInfo.DataSource = tabl

        dgvStudentInfo.AllowUserToAddRows = False
        dgvStudentInfo.EditMode = DataGridViewEditMode.EditProgrammatically
        dgvStudentInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        connection.Close()

    End Sub

    Private Sub dgvStudentInfo_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvStudentInfo.CellContentClick
        studentID = dgvStudentInfo.SelectedRows(0).Cells(0).Value.ToString()
    End Sub
    Private Sub actual_delete()
        connection.Close()
        connection.Open()
        Dim del1 As String

        del1 = "Delete from[Retrieve] where[Stud_ID]='" & studentID & "'"
        Dim cmd As New OleDbCommand(del1, connection)


        Try
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        connection.Close()

    End Sub
   

    Private Sub btnRetrieve_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetrieve.Click
        connection.Open()
        Dim result As DialogResult = MessageBox.Show("Are You Sure Do you want to Retrieve?", "Warning", MessageBoxButtons.YesNo)
        If studentID = Nothing Then
            MsgBox("Select items to retrieve")
        Else
            If result = DialogResult.Cancel Then
                MessageBox.Show("Cancelled")
            ElseIf result = DialogResult.No Then

            ElseIf result = DialogResult.Yes Then
                CopyDeletedfiles()
                actual_delete()
                MessageBox.Show("retrieved")
            End If
        End If
        SelectAll_StudInfo()
        connection.Close()

    End Sub
    Private Sub CopyDeletedfiles() 'copy the deleted file in retrieve table

        connection.Close()
        connection.Open()

        Dim del As String
        MsgBox(studentID)
        del = "insert into[Student_Information] Select * from[Retrieve] where[Stud_ID]='" & studentID & "'"

        Dim cmd As New OleDbCommand(del, connection)

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try




        connection.Close()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        connection.Open()
        Dim result As DialogResult = MessageBox.Show("Are You Sure Do you want to Delete?", "Warning", MessageBoxButtons.YesNo)
        If studentID = Nothing Then
            MsgBox("Select item to delete")
        Else
            If result = DialogResult.Cancel Then
                MessageBox.Show("Cancelled")
            ElseIf result = DialogResult.No Then

            ElseIf result = DialogResult.Yes Then
                actual_delete()
                MessageBox.Show("Deleted")
            End If
        End If
        SelectAll_StudInfo()
        connection.Close()
    End Sub

    Private Sub txtExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtExit.Click
        Me.Close()
        Form4.Show()

    End Sub
End Class