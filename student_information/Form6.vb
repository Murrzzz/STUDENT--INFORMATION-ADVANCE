Imports System.Data.OleDb
Imports System.Data
Public Class Form6
    Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Administrator\Documents\Visual Studio 2010\Projects\STUDENT INFORMATION ADVANCE\student_information\bin\Database.accdb")
    Dim tabl As New DataTable



    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet26.Student_Information' table. You can move, or remove it, as needed.
        Me.Student_InformationTableAdapter6.Fill(Me.DatabaseDataSet26.Student_Information)
        'TODO: This line of code loads data into the 'ViewPanel.Student_Information' table. You can move, or remove it, as needed.
       
        connection.Open()
        SelectAll_StudInfo()
        connection.Close()

    End Sub


    Private Sub SelectAll_StudInfo()
        Dim StudInfo As New OleDbDataAdapter("SELECT * From[Student_Information] where[Course_Code]='" & Form8.Course & "' AND [Stud_Year]='" & Form8.Year & "' AND [Sem_ID]=" & Form8.Sem & " AND [Department]='" & Form8.Department & "'", connection)
        Dim tabl As New DataTable
        StudInfo.Fill(tabl)
        dgvStudentInfo.DataSource = tabl

        dgvStudentInfo.AllowUserToAddRows = False
        dgvStudentInfo.EditMode = DataGridViewEditMode.EditProgrammatically
        dgvStudentInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        ' Label9.Text = Nothing
        connection.Close()

    End Sub




    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim imgpath As String
        'to insert the Picture
        Try

            Dim OFD As FileDialog = New OpenFileDialog()

            OFD.Filter = "Image File (*.jpg;*.bmp;*.gif;*.png)|*.jpg;*.bmp;*.gif;*.png"

            If OFD.ShowDialog() = DialogResult.OK Then
                imgpath = OFD.FileName
                PictureBox1.ImageLocation = imgpath

            End If

            OFD = Nothing


        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try

    End Sub



    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form5.Show()

        Me.Close()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form7.Show()
        Me.Close()

    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form5.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form7.Show()
        Me.Close()

    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form4.Show()
        Me.Hide()

    End Sub

    Private Sub txtExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtExit.Click
        Me.Close()
        Form4.Show()

    End Sub

    
    Private Sub dgvStudentInfo_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvStudentInfo.CellContentClick
        Dim arrImage() As Byte

        txtStudent_ID.Text = dgvStudentInfo.SelectedRows(0).Cells(0).Value.ToString()
        cmbCourse.Text = dgvStudentInfo.SelectedRows(0).Cells(1).Value.ToString()
        txtFname.Text = dgvStudentInfo.SelectedRows(0).Cells(2).Value.ToString()
        txtMname.Text = dgvStudentInfo.SelectedRows(0).Cells(3).Value.ToString()
        txtLname.Text = dgvStudentInfo.SelectedRows(0).Cells(4).Value.ToString()

        cmbYear.Text = dgvStudentInfo.SelectedRows(0).Cells(5).Value.ToString()
        txtContact.Text = dgvStudentInfo.SelectedRows(0).Cells(6).Value.ToString()
        txtBirthdate.Text = dgvStudentInfo.SelectedRows(0).Cells(7).Value.ToString()
        txtAge.Text = dgvStudentInfo.SelectedRows(0).Cells(8).Value.ToString()
        cmbSex.Text = dgvStudentInfo.SelectedRows(0).Cells(9).Value.ToString()
        txtNickName.Text = dgvStudentInfo.SelectedRows(0).Cells(10).Value.ToString()
        txtCivilStatus.Text = dgvStudentInfo.SelectedRows(0).Cells(11).Value.ToString()
        txtReligion.Text = dgvStudentInfo.SelectedRows(0).Cells(12).Value.ToString()
        txtPlaceOfBirth.Text = dgvStudentInfo.SelectedRows(0).Cells(13).Value.ToString()
        txtAddress.Text = dgvStudentInfo.SelectedRows(0).Cells(14).Value.ToString()
        cmbStudent.Text = dgvStudentInfo.SelectedRows(0).Cells(15).Value.ToString()
        'para makita yung picture sa picture box1
        arrImage = dgvStudentInfo.SelectedRows(0).Cells(16).Value

        Dim mstream As New System.IO.MemoryStream(arrImage)
        PictureBox1.Image = Image.FromStream(mstream)

    End Sub

    Private Sub txtUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUpdate.Click

        If txtStudent_ID.Text = Nothing Or txtFname.Text = Nothing Or txtMname.Text = Nothing Or txtLname.Text = Nothing Or cmbCourse.Text = Nothing Or cmbYear.Text = Nothing Or txtContact.Text = Nothing Or txtBirthdate.Text = Nothing Or txtAge.Text = Nothing Or cmbSex.Text = Nothing Or txtNickName.Text = Nothing Or txtCivilStatus.Text = Nothing Or txtReligion.Text = Nothing Or txtPlaceOfBirth.Text = Nothing Or txtAddress.Text = Nothing Then
            connection.Open()
            MsgBox("Click data to Update")
            connection.Close()
        Else


            connection.Open()

            Dim arrimage() As Byte

            Dim upt As String
            upt = "update[Student_Information] set[Stud_ID]='" & txtStudent_ID.Text & "',[Course_Code]='" & cmbCourse.Text & "',[Fname]='" & txtFname.Text & "',[Mname]='" & txtMname.Text & "',[Lname]='" & txtLname.Text & "',[Year]='" & cmbYear.Text & "',[ContactNo]='" & txtContact.Text & "',[Birthdate]='" & txtBirthdate.Text & "',[Age]='" & txtAge.Text & "',[Sex]='" & cmbSex.Text & "',[Nickname]='" & txtNickName.Text & "',[CivilStatus]='" & txtCivilStatus.Text & "',[Religion]='" & txtReligion.Text & "',[PlaceOfBirth]='" & txtPlaceOfBirth.Text & "',[HomeAddress]='" & txtAddress.Text & "',[StudentsStatus]='" & cmbStudent.Text & "',[img]=? where[Stud_ID]='" & txtStudent_ID.Text & "'"

            'para ma save or ma update yung nasa MS Access na solve din sa wakas hahahaha
            Dim cmd As OleDbCommand = New OleDbCommand(upt, connection)

            Dim mstream As New System.IO.MemoryStream

            PictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            arrimage = mstream.GetBuffer()
            Dim fileSize As UInt32
            fileSize = mstream.Length
            mstream.Close()


            cmd.Parameters.AddWithValue("img", arrimage)

            Try
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                SelectAll_StudInfo()

                connection.Close()
                ' txtStud_ID.Clear()
                'txtLname.Clear()
                'txtFname.Clear()
                'txtMname.Clear()
                'txtStud_Course.Clear()
                'txtStud_Year.Clear()
                'txtStud_Section.Clear()
                MsgBox("Data Updated")
                'para bumalik sa initial image everytime na click yung button
                PictureBox1.Image = PictureBox1.InitialImage()


                'table to update
                ' Dim command As New OleDbDataAdapter("SELECT * from[studInfo]", connection)
                'Dim dt As New DataTable
                'command.Fill(dt)
                'DataGridView1.DataSource = dt
                'select all
            Catch ex As Exception
                MsgBox(ex.Message)
                connection.Close()
            End Try


        End If
    End Sub

End Class