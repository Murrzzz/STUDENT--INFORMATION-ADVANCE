Imports System.Data.OleDb
Imports System.Data

Public Class Form5
    Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Administrator\Documents\Visual Studio 2010\Projects\STUDENT INFORMATION ADVANCE\student_information\bin\Database.accdb")
    Dim imgpath As String
    Dim Pic1 As Integer
    Public arrimage() As Byte
    Dim StudentStatus As String 'TO know if the Student is New or Old
    Dim A As Integer = 0 'Para hindi ma double yung check


    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet13.Course' table. You can move, or remove it, as needed.
        Me.CourseTableAdapter2.Fill(Me.DatabaseDataSet13.Course)
        'TODO: This line of code loads data into the 'DatabaseDataSet12.Course' table. You can move, or remove it, as needed.
        Me.CourseTableAdapter1.Fill(Me.DatabaseDataSet12.Course)
        'TODO: This line of code loads data into the 'DatabaseDataSet11.Course' table. You can move, or remove it, as needed.
        Me.CourseTableAdapter.Fill(Me.DatabaseDataSet11.Course)
        Label11.Text = TimeOfDay 'time



     
        'pnlStudentInfo.Hide()



       
        'Label14.Text = Form2.user_name.ToUpper  'user name galing sa form2'
    End Sub

    Private Sub insert()
        'to insert the Picture
        Try

            Dim OFD As FileDialog = New OpenFileDialog() 'to insert the picture

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
   

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        insert()


    End Sub
    
    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click

        Dim cond As Integer = 0
        A = 0
        If rdbNewStud.Checked = True Then
            StudentStatus = "New Student"
            A += 1
        ElseIf rdbOldStud.Checked = True Then
            StudentStatus = "Old Student"
            A += 1
        ElseIf rdbReturnee.Checked = True Then
            StudentStatus = "Returnee"
            A += 1
        ElseIf rdbTransferee.Checked = True Then
            StudentStatus = "Transferee"
            A += 1
        ElseIf rdb2ndCourser.Checked = True Then
            StudentStatus = "2nd Courser"
            A += 1
        End If




                If A = 0 Then
            MsgBox("Please check the radiobox")
            txtA.Text = "*"

        ElseIf txtA.Text = "*" Then
            If A <> 0 Then
                txtA.Text = ""
            End If
                ElseIf txtStud_ID.Text = Nothing Then
            MsgBox("fill the blank!")
            txtB.Text = "*"
        ElseIf txtB.Text = "*" Then
            If txtStud_ID.Text <> Nothing Then
                txtB.Text = ""
            End If
        Else

            pnlAddPic.Hide()
            pnlStudentInfo.Show()
                End If





    End Sub
    Private Sub studInfo_clear()
        txtFname.Text = ""
        txtMname.Text = ""
        txtLname.Text = ""
        cmbCourse.Text = ""
        cmbYear.Text = ""
        txtContact.Text = ""
        txtMonth.Text = "0"
        txtDay.Text = "00"
        txtYear.Text = "0000"
        txtAge.Text = ""
        cmbSex.Text = ""
        txtNickName.Text = ""
        cmbCivilStatus.Text = ""
        txtReligion.Text = ""
        txtPlaceOfBirth.Text = ""
        txtAddress.Text = ""
        txtStud_ID.Text = ""



    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Administrator\Documents\Visual Studio 2010\Projects\STUDENT INFORMATION ADVANCE\student_information\bin\Database.accdb")
        Dim Sttr As String

        Dim DateBirth = "" & txtMonth.Text & "/" & txtDay.Text & "/" & txtYear.Text & ""
        cmbYear.Text = Form8.YearL
        cmbCourse.Text = Form8.txtCourseCode.Text


        If txtFname.Text = Nothing Or txtLname.Text = Nothing Or cmbCourse.Text = Nothing Or cmbYear.Text = Nothing Or txtContact.Text = Nothing Or DateBirth = Nothing Or txtAge.Text = Nothing Or cmbSex.Text = Nothing Or txtNickName.Text = Nothing Or cmbCivilStatus.Text = Nothing Or txtReligion.Text = Nothing Or txtPlaceOfBirth.Text = Nothing Then
            MsgBox("Fill the Blank")
            If txtMonth.Text = Nothing And txtDay.Text = Nothing And txtYear.Text = Nothing Then
                MsgBox("Fill the Blank")
            End If

        Else



            connection.Open()

            Sttr = "insert into Student_Information([Data_Name],[Stud_Year],[Sem_ID],[Department],[Stud_ID],[Fname],[Mname],[Lname],[Course_Code],[Year],[ContactNo],[Birthdate],[Age],[Sex],[NickName],[CivilStatus],[Religion],[PlaceOfBirth],[HomeAddress],[StudentsStatus],[img],[Year_Level]) Values(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"

            Dim cmd As New OleDbCommand(Sttr, connection)
            'to saved the picture in the database
            Dim mstream As New System.IO.MemoryStream
            PictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            arrimage = mstream.GetBuffer()

            Dim fileSize As UInt32
            fileSize = mstream.Length
            mstream.Close()
            '------------------------------------------------------------------------
            cmd.Parameters.AddWithValue("Data_Name", Form8.txtSave.Text)

            cmd.Parameters.AddWithValue("Stud_Phone", Form8.Year)
            cmd.Parameters.AddWithValue("Stud_Phone", Form8.Sem)
            cmd.Parameters.AddWithValue("Stud_Phone", Form8.Department)
            cmd.Parameters.Add(New OleDbParameter("stud_ID", CType(txtStud_ID.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Fname ", CType(txtFname.Text.ToUpper, String)))
            cmd.Parameters.Add(New OleDbParameter("Mname", CType(txtMname.Text.ToUpper, String)))
            cmd.Parameters.Add(New OleDbParameter("Lname", CType(txtLname.Text.ToUpper, String)))

            cmd.Parameters.Add(New OleDbParameter("stud_Course", CType(cmbCourse.Text.ToUpper, String)))
            cmd.Parameters.Add(New OleDbParameter("sud_Yr", CType(txtYear.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("stud_sec", CType(txtContact.Text.ToUpper, String)))
            cmd.Parameters.Add(New OleDbParameter("Stud_Address", CType(DateBirth.ToUpper, String)))
            cmd.Parameters.Add(New OleDbParameter("Stud_Address", CType(txtAge.Text.ToUpper, String)))
            cmd.Parameters.Add(New OleDbParameter("Stud_Address", CType(cmbSex.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Stud_Address", CType(txtNickName.Text, String)))
            cmd.Parameters.AddWithValue("Stud_Sex", cmbCivilStatus.Text)
            cmd.Parameters.AddWithValue("Stud_Status", txtReligion.Text)
            cmd.Parameters.AddWithValue("Stud_Note", txtPlaceOfBirth.Text)
            cmd.Parameters.AddWithValue("Stud_Phone", txtAddress.Text)
            cmd.Parameters.AddWithValue("StatusStudent", StudentStatus)

            cmd.Parameters.AddWithValue("img", arrimage)
            cmd.Parameters.AddWithValue("Year_Level", cmbYear.Text)


            Try
                cmd.ExecuteNonQuery()
                'table to update

                MsgBox("Data Added")
                studInfo_clear()

                'para bumalik sa initial image
                PictureBox1.Image = PictureBox1.InitialImage
            Catch ex As Exception
                MsgBox(ex.Message)


            End Try
        End If
    End Sub


    Private Sub txtExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtExit.Click
        Me.Hide()
        Form4.Show()

    End Sub

    Private Sub rdbPic1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        pnlAddPic.Show()
        pnlStudentInfo.Hide()

    End Sub

    Private Sub rdbStudInfo1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        pnlStudentInfo.Show()
        pnlAddPic.Hide()

    End Sub


    Private Sub RadioButton2_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        pnlAddPic.Hide()
        pnlStudentInfo.Show()
    End Sub

    Private Sub RadioButton1_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        pnlStudentInfo.Hide()
        pnlAddPic.Show()
    End Sub
End Class