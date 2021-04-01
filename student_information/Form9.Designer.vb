<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form9))
        Me.StudentInformationBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet24 = New student_information.DatabaseDataSet24()
        Me.StudentInformationBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet23 = New student_information.DatabaseDataSet23()
        Me.StudentInformationBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet8 = New student_information.DatabaseDataSet8()
        Me.StudentInformationBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet6 = New student_information.DatabaseDataSet6()
        Me.StudentInformationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Student_InformationTableAdapter = New student_information.DatabaseDataSet6TableAdapters.Student_InformationTableAdapter()
        Me.DepartmentTableAdapter1 = New student_information.DatabaseDataSet2TableAdapters.DepartmentTableAdapter()
        Me.CourseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet17BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet17 = New student_information.DatabaseDataSet17()
        Me.SchoolYearBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet18 = New student_information.DatabaseDataSet18()
        Me.DepartmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet16 = New student_information.DatabaseDataSet16()
        Me.SemesterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SchoolYearBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet15 = New student_information.DatabaseDataSet15()
        Me.StudInfoTableAdapter1 = New student_information.Database2DataSetTableAdapters.studInfoTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtExit = New System.Windows.Forms.Label()
        Me.DatabaseDataSet7 = New student_information.DatabaseDataSet7()
        Me.DatabaseDataSet7BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Student_InformationTableAdapter1 = New student_information.DatabaseDataSet8TableAdapters.Student_InformationTableAdapter()
        Me.SchoolYearTableAdapter = New student_information.DatabaseDataSet15TableAdapters.SchoolYearTableAdapter()
        Me.DepartmentTableAdapter = New student_information.DatabaseDataSet16TableAdapters.DepartmentTableAdapter()
        Me.CourseTableAdapter = New student_information.DatabaseDataSet17TableAdapters.CourseTableAdapter()
        Me.SchoolYearTableAdapter1 = New student_information.DatabaseDataSet18TableAdapters.SchoolYearTableAdapter()
        Me.SemesterTableAdapter = New student_information.DatabaseDataSet17TableAdapters.SemesterTableAdapter()
        Me.Student_InformationTableAdapter2 = New student_information.DatabaseDataSet23TableAdapters.Student_InformationTableAdapter()
        Me.Student_InformationTableAdapter3 = New student_information.DatabaseDataSet24TableAdapters.Student_InformationTableAdapter()
        Me.pnlView = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtPlaceOfBirth = New System.Windows.Forms.Label()
        Me.cmbSex = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.Label()
        Me.txtNickName = New System.Windows.Forms.Label()
        Me.txtStudent_ID = New System.Windows.Forms.Label()
        Me.txtStudent = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.Label()
        Me.txtCivilStatus = New System.Windows.Forms.Label()
        Me.cmbCourse_ID = New System.Windows.Forms.Label()
        Me.txtReligion = New System.Windows.Forms.Label()
        Me.txtBirthdate = New System.Windows.Forms.Label()
        Me.cmbYear = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.Label()
        Me.txtMname = New System.Windows.Forms.Label()
        Me.txtFname = New System.Windows.Forms.Label()
        Me.txtLname = New System.Windows.Forms.Label()
        Me.btnback = New System.Windows.Forms.Button()
        Me.dgvStudentInformation = New System.Windows.Forms.DataGridView()
        Me.StudIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Course_Code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FnameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MnameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LnameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YearDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BirthdateDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NicknameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CivilStatusDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReligionDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlaceOfBirthDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HomeAddressDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentsStatusDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImgDataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.StudentInformationBindingSource7 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet25 = New student_information.DatabaseDataSet25()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.pnlSelectAll = New System.Windows.Forms.Panel()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.cmbSearch = New System.Windows.Forms.ComboBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbCourse = New System.Windows.Forms.ComboBox()
        Me.cmbSchoolYear = New System.Windows.Forms.ComboBox()
        Me.cmbDepartment = New System.Windows.Forms.ComboBox()
        Me.cmbSemester = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.dgvStudentInfo = New System.Windows.Forms.DataGridView()
        Me.StudIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BirthdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NicknameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CivilStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReligionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlaceOfBirthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HomeAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentsStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImgDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.StudentInformationBindingSource10 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet29 = New student_information.DatabaseDataSet29()
        Me.View = New student_information.View()
        Me.StudentInformationBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Student_InformationTableAdapter4 = New student_information.ViewTableAdapters.Student_InformationTableAdapter()
        Me.Views = New student_information.views()
        Me.StudentInformationBindingSource6 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Student_InformationTableAdapter5 = New student_information.viewsTableAdapters.Student_InformationTableAdapter()
        Me.Student_InformationTableAdapter6 = New student_information.DatabaseDataSet25TableAdapters.Student_InformationTableAdapter()
        Me.DatabaseDataSet28 = New student_information.DatabaseDataSet28()
        Me.StudentInformationBindingSource8 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Student_InformationTableAdapter7 = New student_information.DatabaseDataSet28TableAdapters.Student_InformationTableAdapter()
        Me.Mainn = New student_information.mainn()
        Me.StudentInformationBindingSource9 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Student_InformationTableAdapter8 = New student_information.mainnTableAdapters.Student_InformationTableAdapter()
        Me.Student_InformationTableAdapter9 = New student_information.DatabaseDataSet29TableAdapters.Student_InformationTableAdapter()
        CType(Me.StudentInformationBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentInformationBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentInformationBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentInformationBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentInformationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CourseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet17BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchoolYearBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SemesterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchoolYearBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet15, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DatabaseDataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet7BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlView.SuspendLayout()
        CType(Me.dgvStudentInformation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentInformationBindingSource7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSelectAll.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvStudentInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentInformationBindingSource10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentInformationBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Views, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentInformationBindingSource6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentInformationBindingSource8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mainn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentInformationBindingSource9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StudentInformationBindingSource4
        '
        Me.StudentInformationBindingSource4.DataMember = "Student_Information"
        Me.StudentInformationBindingSource4.DataSource = Me.DatabaseDataSet24
        '
        'DatabaseDataSet24
        '
        Me.DatabaseDataSet24.DataSetName = "DatabaseDataSet24"
        Me.DatabaseDataSet24.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentInformationBindingSource3
        '
        Me.StudentInformationBindingSource3.DataMember = "Student_Information"
        Me.StudentInformationBindingSource3.DataSource = Me.DatabaseDataSet23
        '
        'DatabaseDataSet23
        '
        Me.DatabaseDataSet23.DataSetName = "DatabaseDataSet23"
        Me.DatabaseDataSet23.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentInformationBindingSource2
        '
        Me.StudentInformationBindingSource2.DataMember = "Student_Information"
        Me.StudentInformationBindingSource2.DataSource = Me.DatabaseDataSet8
        '
        'DatabaseDataSet8
        '
        Me.DatabaseDataSet8.DataSetName = "DatabaseDataSet8"
        Me.DatabaseDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentInformationBindingSource1
        '
        Me.StudentInformationBindingSource1.DataMember = "Student_Information"
        Me.StudentInformationBindingSource1.DataSource = Me.DatabaseDataSet6
        '
        'DatabaseDataSet6
        '
        Me.DatabaseDataSet6.DataSetName = "DatabaseDataSet6"
        Me.DatabaseDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Student_InformationTableAdapter
        '
        Me.Student_InformationTableAdapter.ClearBeforeFill = True
        '
        'DepartmentTableAdapter1
        '
        Me.DepartmentTableAdapter1.ClearBeforeFill = True
        '
        'CourseBindingSource
        '
        Me.CourseBindingSource.DataMember = "Course"
        Me.CourseBindingSource.DataSource = Me.DatabaseDataSet17BindingSource
        '
        'DatabaseDataSet17BindingSource
        '
        Me.DatabaseDataSet17BindingSource.DataSource = Me.DatabaseDataSet17
        Me.DatabaseDataSet17BindingSource.Position = 0
        '
        'DatabaseDataSet17
        '
        Me.DatabaseDataSet17.DataSetName = "DatabaseDataSet17"
        Me.DatabaseDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SchoolYearBindingSource1
        '
        Me.SchoolYearBindingSource1.DataMember = "SchoolYear"
        Me.SchoolYearBindingSource1.DataSource = Me.DatabaseDataSet18
        '
        'DatabaseDataSet18
        '
        Me.DatabaseDataSet18.DataSetName = "DatabaseDataSet18"
        Me.DatabaseDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DepartmentBindingSource
        '
        Me.DepartmentBindingSource.DataMember = "Department"
        Me.DepartmentBindingSource.DataSource = Me.DatabaseDataSet16
        '
        'DatabaseDataSet16
        '
        Me.DatabaseDataSet16.DataSetName = "DatabaseDataSet16"
        Me.DatabaseDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SemesterBindingSource
        '
        Me.SemesterBindingSource.DataMember = "Semester"
        Me.SemesterBindingSource.DataSource = Me.DatabaseDataSet17BindingSource
        '
        'SchoolYearBindingSource
        '
        Me.SchoolYearBindingSource.DataMember = "SchoolYear"
        Me.SchoolYearBindingSource.DataSource = Me.DatabaseDataSet15
        '
        'DatabaseDataSet15
        '
        Me.DatabaseDataSet15.DataSetName = "DatabaseDataSet15"
        Me.DatabaseDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudInfoTableAdapter1
        '
        Me.StudInfoTableAdapter1.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtExit)
        Me.Panel1.Location = New System.Drawing.Point(-6, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1244, 68)
        Me.Panel1.TabIndex = 90
        '
        'txtExit
        '
        Me.txtExit.AutoSize = True
        Me.txtExit.BackColor = System.Drawing.Color.Transparent
        Me.txtExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExit.ForeColor = System.Drawing.Color.White
        Me.txtExit.Location = New System.Drawing.Point(1197, 13)
        Me.txtExit.Name = "txtExit"
        Me.txtExit.Size = New System.Drawing.Size(48, 46)
        Me.txtExit.TabIndex = 33
        Me.txtExit.Text = "X"
        '
        'DatabaseDataSet7
        '
        Me.DatabaseDataSet7.DataSetName = "DatabaseDataSet7"
        Me.DatabaseDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DatabaseDataSet7BindingSource
        '
        Me.DatabaseDataSet7BindingSource.DataSource = Me.DatabaseDataSet7
        Me.DatabaseDataSet7BindingSource.Position = 0
        '
        'Student_InformationTableAdapter1
        '
        Me.Student_InformationTableAdapter1.ClearBeforeFill = True
        '
        'SchoolYearTableAdapter
        '
        Me.SchoolYearTableAdapter.ClearBeforeFill = True
        '
        'DepartmentTableAdapter
        '
        Me.DepartmentTableAdapter.ClearBeforeFill = True
        '
        'CourseTableAdapter
        '
        Me.CourseTableAdapter.ClearBeforeFill = True
        '
        'SchoolYearTableAdapter1
        '
        Me.SchoolYearTableAdapter1.ClearBeforeFill = True
        '
        'SemesterTableAdapter
        '
        Me.SemesterTableAdapter.ClearBeforeFill = True
        '
        'Student_InformationTableAdapter2
        '
        Me.Student_InformationTableAdapter2.ClearBeforeFill = True
        '
        'Student_InformationTableAdapter3
        '
        Me.Student_InformationTableAdapter3.ClearBeforeFill = True
        '
        'pnlView
        '
        Me.pnlView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlView.Controls.Add(Me.Label11)
        Me.pnlView.Controls.Add(Me.Panel2)
        Me.pnlView.Controls.Add(Me.txtPlaceOfBirth)
        Me.pnlView.Controls.Add(Me.cmbSex)
        Me.pnlView.Controls.Add(Me.txtAddress)
        Me.pnlView.Controls.Add(Me.txtNickName)
        Me.pnlView.Controls.Add(Me.txtStudent_ID)
        Me.pnlView.Controls.Add(Me.txtStudent)
        Me.pnlView.Controls.Add(Me.txtContact)
        Me.pnlView.Controls.Add(Me.txtCivilStatus)
        Me.pnlView.Controls.Add(Me.cmbCourse_ID)
        Me.pnlView.Controls.Add(Me.txtReligion)
        Me.pnlView.Controls.Add(Me.txtBirthdate)
        Me.pnlView.Controls.Add(Me.cmbYear)
        Me.pnlView.Controls.Add(Me.txtAge)
        Me.pnlView.Controls.Add(Me.txtMname)
        Me.pnlView.Controls.Add(Me.txtFname)
        Me.pnlView.Controls.Add(Me.txtLname)
        Me.pnlView.Controls.Add(Me.btnback)
        Me.pnlView.Controls.Add(Me.dgvStudentInformation)
        Me.pnlView.Controls.Add(Me.PictureBox1)
        Me.pnlView.Controls.Add(Me.Label24)
        Me.pnlView.Controls.Add(Me.Label23)
        Me.pnlView.Controls.Add(Me.Label6)
        Me.pnlView.Controls.Add(Me.Label22)
        Me.pnlView.Controls.Add(Me.Label19)
        Me.pnlView.Controls.Add(Me.Label21)
        Me.pnlView.Controls.Add(Me.Label20)
        Me.pnlView.Controls.Add(Me.Label18)
        Me.pnlView.Controls.Add(Me.Label12)
        Me.pnlView.Controls.Add(Me.Label17)
        Me.pnlView.Controls.Add(Me.Label9)
        Me.pnlView.Controls.Add(Me.Label16)
        Me.pnlView.Controls.Add(Me.Label7)
        Me.pnlView.Controls.Add(Me.Label15)
        Me.pnlView.Controls.Add(Me.Label8)
        Me.pnlView.Controls.Add(Me.Label10)
        Me.pnlView.Controls.Add(Me.Label14)
        Me.pnlView.Controls.Add(Me.Label13)
        Me.pnlView.ForeColor = System.Drawing.Color.DarkGray
        Me.pnlView.Location = New System.Drawing.Point(1, 62)
        Me.pnlView.Name = "pnlView"
        Me.pnlView.Size = New System.Drawing.Size(1242, 839)
        Me.pnlView.TabIndex = 96
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkGray
        Me.Label11.Location = New System.Drawing.Point(678, 325)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 20)
        Me.Label11.TabIndex = 139
        Me.Label11.Text = "STUDENT:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(307, 17)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 341)
        Me.Panel2.TabIndex = 182
        '
        'txtPlaceOfBirth
        '
        Me.txtPlaceOfBirth.AutoSize = True
        Me.txtPlaceOfBirth.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlaceOfBirth.ForeColor = System.Drawing.Color.White
        Me.txtPlaceOfBirth.Location = New System.Drawing.Point(768, 227)
        Me.txtPlaceOfBirth.Name = "txtPlaceOfBirth"
        Me.txtPlaceOfBirth.Size = New System.Drawing.Size(38, 20)
        Me.txtPlaceOfBirth.TabIndex = 181
        Me.txtPlaceOfBirth.Text = "Null"
        '
        'cmbSex
        '
        Me.cmbSex.AutoSize = True
        Me.cmbSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSex.ForeColor = System.Drawing.Color.White
        Me.cmbSex.Location = New System.Drawing.Point(978, 133)
        Me.cmbSex.Name = "cmbSex"
        Me.cmbSex.Size = New System.Drawing.Size(38, 20)
        Me.cmbSex.TabIndex = 180
        Me.cmbSex.Text = "Null"
        '
        'txtAddress
        '
        Me.txtAddress.AutoSize = True
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.ForeColor = System.Drawing.Color.White
        Me.txtAddress.Location = New System.Drawing.Point(501, 272)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(38, 20)
        Me.txtAddress.TabIndex = 180
        Me.txtAddress.Text = "Null"
        '
        'txtNickName
        '
        Me.txtNickName.AutoSize = True
        Me.txtNickName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNickName.ForeColor = System.Drawing.Color.White
        Me.txtNickName.Location = New System.Drawing.Point(503, 181)
        Me.txtNickName.Name = "txtNickName"
        Me.txtNickName.Size = New System.Drawing.Size(38, 20)
        Me.txtNickName.TabIndex = 179
        Me.txtNickName.Text = "Null"
        '
        'txtStudent_ID
        '
        Me.txtStudent_ID.AutoSize = True
        Me.txtStudent_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudent_ID.ForeColor = System.Drawing.Color.White
        Me.txtStudent_ID.Location = New System.Drawing.Point(503, 325)
        Me.txtStudent_ID.Name = "txtStudent_ID"
        Me.txtStudent_ID.Size = New System.Drawing.Size(38, 20)
        Me.txtStudent_ID.TabIndex = 179
        Me.txtStudent_ID.Text = "Null"
        '
        'txtStudent
        '
        Me.txtStudent.AutoSize = True
        Me.txtStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudent.ForeColor = System.Drawing.Color.White
        Me.txtStudent.Location = New System.Drawing.Point(769, 325)
        Me.txtStudent.Name = "txtStudent"
        Me.txtStudent.Size = New System.Drawing.Size(38, 20)
        Me.txtStudent.TabIndex = 178
        Me.txtStudent.Text = "Null"
        '
        'txtContact
        '
        Me.txtContact.AutoSize = True
        Me.txtContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.ForeColor = System.Drawing.Color.White
        Me.txtContact.Location = New System.Drawing.Point(980, 89)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(38, 20)
        Me.txtContact.TabIndex = 178
        Me.txtContact.Text = "Null"
        '
        'txtCivilStatus
        '
        Me.txtCivilStatus.AutoSize = True
        Me.txtCivilStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCivilStatus.ForeColor = System.Drawing.Color.White
        Me.txtCivilStatus.Location = New System.Drawing.Point(765, 182)
        Me.txtCivilStatus.Name = "txtCivilStatus"
        Me.txtCivilStatus.Size = New System.Drawing.Size(38, 20)
        Me.txtCivilStatus.TabIndex = 178
        Me.txtCivilStatus.Text = "Null"
        '
        'cmbCourse_ID
        '
        Me.cmbCourse_ID.AutoSize = True
        Me.cmbCourse_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCourse_ID.ForeColor = System.Drawing.Color.White
        Me.cmbCourse_ID.Location = New System.Drawing.Point(503, 89)
        Me.cmbCourse_ID.Name = "cmbCourse_ID"
        Me.cmbCourse_ID.Size = New System.Drawing.Size(38, 20)
        Me.cmbCourse_ID.TabIndex = 176
        Me.cmbCourse_ID.Text = "Null"
        '
        'txtReligion
        '
        Me.txtReligion.AutoSize = True
        Me.txtReligion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReligion.ForeColor = System.Drawing.Color.White
        Me.txtReligion.Location = New System.Drawing.Point(503, 227)
        Me.txtReligion.Name = "txtReligion"
        Me.txtReligion.Size = New System.Drawing.Size(38, 20)
        Me.txtReligion.TabIndex = 177
        Me.txtReligion.Text = "Null"
        '
        'txtBirthdate
        '
        Me.txtBirthdate.AutoSize = True
        Me.txtBirthdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBirthdate.ForeColor = System.Drawing.Color.White
        Me.txtBirthdate.Location = New System.Drawing.Point(503, 136)
        Me.txtBirthdate.Name = "txtBirthdate"
        Me.txtBirthdate.Size = New System.Drawing.Size(38, 20)
        Me.txtBirthdate.TabIndex = 177
        Me.txtBirthdate.Text = "Null"
        '
        'cmbYear
        '
        Me.cmbYear.AutoSize = True
        Me.cmbYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbYear.ForeColor = System.Drawing.Color.White
        Me.cmbYear.Location = New System.Drawing.Point(762, 88)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(60, 20)
        Me.cmbYear.TabIndex = 175
        Me.cmbYear.Text = "Fname"
        '
        'txtAge
        '
        Me.txtAge.AutoSize = True
        Me.txtAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.ForeColor = System.Drawing.Color.White
        Me.txtAge.Location = New System.Drawing.Point(762, 134)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(38, 20)
        Me.txtAge.TabIndex = 176
        Me.txtAge.Text = "Null"
        '
        'txtMname
        '
        Me.txtMname.AutoSize = True
        Me.txtMname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMname.ForeColor = System.Drawing.Color.White
        Me.txtMname.Location = New System.Drawing.Point(981, 33)
        Me.txtMname.Name = "txtMname"
        Me.txtMname.Size = New System.Drawing.Size(38, 20)
        Me.txtMname.TabIndex = 174
        Me.txtMname.Text = "Null"
        '
        'txtFname
        '
        Me.txtFname.AutoSize = True
        Me.txtFname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFname.ForeColor = System.Drawing.Color.White
        Me.txtFname.Location = New System.Drawing.Point(755, 31)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(38, 20)
        Me.txtFname.TabIndex = 173
        Me.txtFname.Text = "Null"
        '
        'txtLname
        '
        Me.txtLname.AutoSize = True
        Me.txtLname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLname.ForeColor = System.Drawing.Color.White
        Me.txtLname.Location = New System.Drawing.Point(509, 29)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(38, 20)
        Me.txtLname.TabIndex = 172
        Me.txtLname.Text = "Null"
        '
        'btnback
        '
        Me.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnback.ForeColor = System.Drawing.Color.White
        Me.btnback.Location = New System.Drawing.Point(40, 770)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(156, 48)
        Me.btnback.TabIndex = 171
        Me.btnback.Text = "BACK"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'dgvStudentInformation
        '
        Me.dgvStudentInformation.AutoGenerateColumns = False
        Me.dgvStudentInformation.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.dgvStudentInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudentInformation.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudIDDataGridViewTextBoxColumn, Me.Course_Code, Me.FnameDataGridViewTextBoxColumn1, Me.MnameDataGridViewTextBoxColumn1, Me.LnameDataGridViewTextBoxColumn1, Me.YearDataGridViewTextBoxColumn1, Me.ContactNoDataGridViewTextBoxColumn1, Me.BirthdateDataGridViewTextBoxColumn1, Me.AgeDataGridViewTextBoxColumn1, Me.SexDataGridViewTextBoxColumn1, Me.NicknameDataGridViewTextBoxColumn1, Me.CivilStatusDataGridViewTextBoxColumn1, Me.ReligionDataGridViewTextBoxColumn1, Me.PlaceOfBirthDataGridViewTextBoxColumn1, Me.HomeAddressDataGridViewTextBoxColumn1, Me.StudentsStatusDataGridViewTextBoxColumn1, Me.ImgDataGridViewImageColumn1})
        Me.dgvStudentInformation.DataSource = Me.StudentInformationBindingSource7
        Me.dgvStudentInformation.Location = New System.Drawing.Point(47, 404)
        Me.dgvStudentInformation.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvStudentInformation.Name = "dgvStudentInformation"
        Me.dgvStudentInformation.RowTemplate.Height = 24
        Me.dgvStudentInformation.Size = New System.Drawing.Size(1149, 352)
        Me.dgvStudentInformation.TabIndex = 170
        '
        'StudIDDataGridViewTextBoxColumn
        '
        Me.StudIDDataGridViewTextBoxColumn.DataPropertyName = "Stud_ID"
        Me.StudIDDataGridViewTextBoxColumn.HeaderText = "Stud_ID"
        Me.StudIDDataGridViewTextBoxColumn.Name = "StudIDDataGridViewTextBoxColumn"
        '
        'Course_Code
        '
        Me.Course_Code.DataPropertyName = "Course_Code"
        Me.Course_Code.HeaderText = "Course_Code"
        Me.Course_Code.Name = "Course_Code"
        '
        'FnameDataGridViewTextBoxColumn1
        '
        Me.FnameDataGridViewTextBoxColumn1.DataPropertyName = "Fname"
        Me.FnameDataGridViewTextBoxColumn1.HeaderText = "Fname"
        Me.FnameDataGridViewTextBoxColumn1.Name = "FnameDataGridViewTextBoxColumn1"
        '
        'MnameDataGridViewTextBoxColumn1
        '
        Me.MnameDataGridViewTextBoxColumn1.DataPropertyName = "Mname"
        Me.MnameDataGridViewTextBoxColumn1.HeaderText = "Mname"
        Me.MnameDataGridViewTextBoxColumn1.Name = "MnameDataGridViewTextBoxColumn1"
        '
        'LnameDataGridViewTextBoxColumn1
        '
        Me.LnameDataGridViewTextBoxColumn1.DataPropertyName = "Lname"
        Me.LnameDataGridViewTextBoxColumn1.HeaderText = "Lname"
        Me.LnameDataGridViewTextBoxColumn1.Name = "LnameDataGridViewTextBoxColumn1"
        '
        'YearDataGridViewTextBoxColumn1
        '
        Me.YearDataGridViewTextBoxColumn1.DataPropertyName = "Year"
        Me.YearDataGridViewTextBoxColumn1.HeaderText = "Year"
        Me.YearDataGridViewTextBoxColumn1.Name = "YearDataGridViewTextBoxColumn1"
        '
        'ContactNoDataGridViewTextBoxColumn1
        '
        Me.ContactNoDataGridViewTextBoxColumn1.DataPropertyName = "ContactNo"
        Me.ContactNoDataGridViewTextBoxColumn1.HeaderText = "ContactNo"
        Me.ContactNoDataGridViewTextBoxColumn1.Name = "ContactNoDataGridViewTextBoxColumn1"
        '
        'BirthdateDataGridViewTextBoxColumn1
        '
        Me.BirthdateDataGridViewTextBoxColumn1.DataPropertyName = "Birthdate"
        Me.BirthdateDataGridViewTextBoxColumn1.HeaderText = "Birthdate"
        Me.BirthdateDataGridViewTextBoxColumn1.Name = "BirthdateDataGridViewTextBoxColumn1"
        '
        'AgeDataGridViewTextBoxColumn1
        '
        Me.AgeDataGridViewTextBoxColumn1.DataPropertyName = "Age"
        Me.AgeDataGridViewTextBoxColumn1.HeaderText = "Age"
        Me.AgeDataGridViewTextBoxColumn1.Name = "AgeDataGridViewTextBoxColumn1"
        '
        'SexDataGridViewTextBoxColumn1
        '
        Me.SexDataGridViewTextBoxColumn1.DataPropertyName = "Sex"
        Me.SexDataGridViewTextBoxColumn1.HeaderText = "Sex"
        Me.SexDataGridViewTextBoxColumn1.Name = "SexDataGridViewTextBoxColumn1"
        '
        'NicknameDataGridViewTextBoxColumn1
        '
        Me.NicknameDataGridViewTextBoxColumn1.DataPropertyName = "Nickname"
        Me.NicknameDataGridViewTextBoxColumn1.HeaderText = "Nickname"
        Me.NicknameDataGridViewTextBoxColumn1.Name = "NicknameDataGridViewTextBoxColumn1"
        '
        'CivilStatusDataGridViewTextBoxColumn1
        '
        Me.CivilStatusDataGridViewTextBoxColumn1.DataPropertyName = "CivilStatus"
        Me.CivilStatusDataGridViewTextBoxColumn1.HeaderText = "CivilStatus"
        Me.CivilStatusDataGridViewTextBoxColumn1.Name = "CivilStatusDataGridViewTextBoxColumn1"
        '
        'ReligionDataGridViewTextBoxColumn1
        '
        Me.ReligionDataGridViewTextBoxColumn1.DataPropertyName = "Religion"
        Me.ReligionDataGridViewTextBoxColumn1.HeaderText = "Religion"
        Me.ReligionDataGridViewTextBoxColumn1.Name = "ReligionDataGridViewTextBoxColumn1"
        '
        'PlaceOfBirthDataGridViewTextBoxColumn1
        '
        Me.PlaceOfBirthDataGridViewTextBoxColumn1.DataPropertyName = "PlaceOfBirth"
        Me.PlaceOfBirthDataGridViewTextBoxColumn1.HeaderText = "PlaceOfBirth"
        Me.PlaceOfBirthDataGridViewTextBoxColumn1.Name = "PlaceOfBirthDataGridViewTextBoxColumn1"
        '
        'HomeAddressDataGridViewTextBoxColumn1
        '
        Me.HomeAddressDataGridViewTextBoxColumn1.DataPropertyName = "HomeAddress"
        Me.HomeAddressDataGridViewTextBoxColumn1.HeaderText = "HomeAddress"
        Me.HomeAddressDataGridViewTextBoxColumn1.Name = "HomeAddressDataGridViewTextBoxColumn1"
        '
        'StudentsStatusDataGridViewTextBoxColumn1
        '
        Me.StudentsStatusDataGridViewTextBoxColumn1.DataPropertyName = "StudentsStatus"
        Me.StudentsStatusDataGridViewTextBoxColumn1.HeaderText = "StudentsStatus"
        Me.StudentsStatusDataGridViewTextBoxColumn1.Name = "StudentsStatusDataGridViewTextBoxColumn1"
        '
        'ImgDataGridViewImageColumn1
        '
        Me.ImgDataGridViewImageColumn1.DataPropertyName = "img"
        Me.ImgDataGridViewImageColumn1.HeaderText = "img"
        Me.ImgDataGridViewImageColumn1.Name = "ImgDataGridViewImageColumn1"
        '
        'StudentInformationBindingSource7
        '
        Me.StudentInformationBindingSource7.DataMember = "Student_Information"
        Me.StudentInformationBindingSource7.DataSource = Me.DatabaseDataSet25
        '
        'DatabaseDataSet25
        '
        Me.DatabaseDataSet25.DataSetName = "DatabaseDataSet25"
        Me.DatabaseDataSet25.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(30, 61)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(253, 248)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 169
        Me.PictureBox1.TabStop = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(101, 318)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(130, 18)
        Me.Label24.TabIndex = 168
        Me.Label24.Text = "1X1 Profile Picture"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.DarkGray
        Me.Label23.Location = New System.Drawing.Point(426, 29)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(62, 20)
        Me.Label23.TabIndex = 127
        Me.Label23.Text = "NAME:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkGray
        Me.Label6.Location = New System.Drawing.Point(326, 325)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(171, 20)
        Me.Label6.TabIndex = 164
        Me.Label6.Text = "STUDENT NUMBER:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.DarkGray
        Me.Label22.Location = New System.Drawing.Point(503, 53)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(76, 17)
        Me.Label22.TabIndex = 131
        Me.Label22.Text = "Last Name"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.DarkGray
        Me.Label19.Location = New System.Drawing.Point(482, 297)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(380, 17)
        Me.Label19.TabIndex = 155
        Me.Label19.Text = "Street/Purok,       Barangay,       Municipality,         Province"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.DarkGray
        Me.Label21.Location = New System.Drawing.Point(756, 53)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(76, 17)
        Me.Label21.TabIndex = 132
        Me.Label21.Text = "First Name"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.DarkGray
        Me.Label20.Location = New System.Drawing.Point(981, 53)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(90, 17)
        Me.Label20.TabIndex = 133
        Me.Label20.Text = "Middle Name"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.DarkGray
        Me.Label18.Location = New System.Drawing.Point(343, 272)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(152, 20)
        Me.Label18.TabIndex = 153
        Me.Label18.Text = "HOME ADDRESS:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkGray
        Me.Label12.Location = New System.Drawing.Point(406, 89)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 20)
        Me.Label12.TabIndex = 134
        Me.Label12.Text = "COURSE:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.DarkGray
        Me.Label17.Location = New System.Drawing.Point(617, 228)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(153, 20)
        Me.Label17.TabIndex = 151
        Me.Label17.Text = "PLACE OF BIRTH:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkGray
        Me.Label9.Location = New System.Drawing.Point(704, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 20)
        Me.Label9.TabIndex = 136
        Me.Label9.Text = "YEAR:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.DarkGray
        Me.Label16.Location = New System.Drawing.Point(400, 227)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(93, 20)
        Me.Label16.TabIndex = 149
        Me.Label16.Text = "RELIGION:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkGray
        Me.Label7.Location = New System.Drawing.Point(842, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 20)
        Me.Label7.TabIndex = 138
        Me.Label7.Text = "CONTACT NO/S:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.DarkGray
        Me.Label15.Location = New System.Drawing.Point(641, 182)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(125, 20)
        Me.Label15.TabIndex = 147
        Me.Label15.Text = "CIVIL STATUS:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkGray
        Me.Label8.Location = New System.Drawing.Point(381, 136)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 20)
        Me.Label8.TabIndex = 140
        Me.Label8.Text = "BIRTHDATE:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkGray
        Me.Label10.Location = New System.Drawing.Point(714, 135)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 20)
        Me.Label10.TabIndex = 141
        Me.Label10.Text = "AGE:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.DarkGray
        Me.Label14.Location = New System.Drawing.Point(390, 182)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(101, 20)
        Me.Label14.TabIndex = 145
        Me.Label14.Text = "NICKNAME:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DarkGray
        Me.Label13.Location = New System.Drawing.Point(933, 135)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 20)
        Me.Label13.TabIndex = 143
        Me.Label13.Text = "SEX:"
        '
        'pnlSelectAll
        '
        Me.pnlSelectAll.Controls.Add(Me.btnSearch)
        Me.pnlSelectAll.Controls.Add(Me.cmbSearch)
        Me.pnlSelectAll.Controls.Add(Me.btnDelete)
        Me.pnlSelectAll.Controls.Add(Me.lblTotal)
        Me.pnlSelectAll.Controls.Add(Me.Label5)
        Me.pnlSelectAll.Controls.Add(Me.GroupBox2)
        Me.pnlSelectAll.Controls.Add(Me.GroupBox1)
        Me.pnlSelectAll.Controls.Add(Me.txtSearch)
        Me.pnlSelectAll.Controls.Add(Me.Label25)
        Me.pnlSelectAll.Controls.Add(Me.dgvStudentInfo)
        Me.pnlSelectAll.Location = New System.Drawing.Point(1, 62)
        Me.pnlSelectAll.Name = "pnlSelectAll"
        Me.pnlSelectAll.Size = New System.Drawing.Size(1239, 834)
        Me.pnlSelectAll.TabIndex = 97
        '
        'btnSearch
        '
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.btnSearch.Location = New System.Drawing.Point(570, 33)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(109, 30)
        Me.btnSearch.TabIndex = 105
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'cmbSearch
        '
        Me.cmbSearch.FormattingEnabled = True
        Me.cmbSearch.Items.AddRange(New Object() {"Fname", "Mname", "Lname", "ContactNo", "Nick Name", "Age ", "Sex", "Religion", "CivilStatus", "StudentsStatus"})
        Me.cmbSearch.Location = New System.Drawing.Point(459, 33)
        Me.cmbSearch.Name = "cmbSearch"
        Me.cmbSearch.Size = New System.Drawing.Size(103, 28)
        Me.cmbSearch.TabIndex = 104
        '
        'btnDelete
        '
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.ForeColor = System.Drawing.Color.Red
        Me.btnDelete.Location = New System.Drawing.Point(41, 763)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(156, 48)
        Me.btnDelete.TabIndex = 103
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(1167, 776)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(18, 20)
        Me.lblTotal.TabIndex = 102
        Me.lblTotal.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(993, 776)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(166, 20)
        Me.Label5.TabIndex = 101
        Me.Label5.Text = "NO. OF STUDENTS:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cmbCourse)
        Me.GroupBox2.Controls.Add(Me.cmbSchoolYear)
        Me.GroupBox2.Controls.Add(Me.cmbDepartment)
        Me.GroupBox2.Controls.Add(Me.cmbSemester)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(732, 24)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(465, 220)
        Me.GroupBox2.TabIndex = 100
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filter Students"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(309, 124)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 20)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "COURSE:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(70, 124)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 20)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "SCHOOL YEAR:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(285, 44)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 20)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "DEPARTMENT:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(82, 44)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 20)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "SEMESTER:"
        '
        'cmbCourse
        '
        Me.cmbCourse.DataSource = Me.CourseBindingSource
        Me.cmbCourse.DisplayMember = "Course_Code"
        Me.cmbCourse.FormattingEnabled = True
        Me.cmbCourse.Location = New System.Drawing.Point(272, 144)
        Me.cmbCourse.Name = "cmbCourse"
        Me.cmbCourse.Size = New System.Drawing.Size(150, 28)
        Me.cmbCourse.TabIndex = 3
        Me.cmbCourse.ValueMember = "Course_Code"
        '
        'cmbSchoolYear
        '
        Me.cmbSchoolYear.DataSource = Me.SchoolYearBindingSource1
        Me.cmbSchoolYear.DisplayMember = "Stud_Year"
        Me.cmbSchoolYear.FormattingEnabled = True
        Me.cmbSchoolYear.Location = New System.Drawing.Point(63, 144)
        Me.cmbSchoolYear.Name = "cmbSchoolYear"
        Me.cmbSchoolYear.Size = New System.Drawing.Size(150, 28)
        Me.cmbSchoolYear.TabIndex = 2
        '
        'cmbDepartment
        '
        Me.cmbDepartment.DataSource = Me.DepartmentBindingSource
        Me.cmbDepartment.DisplayMember = "Department"
        Me.cmbDepartment.FormattingEnabled = True
        Me.cmbDepartment.Location = New System.Drawing.Point(272, 67)
        Me.cmbDepartment.Name = "cmbDepartment"
        Me.cmbDepartment.Size = New System.Drawing.Size(150, 28)
        Me.cmbDepartment.TabIndex = 1
        Me.cmbDepartment.ValueMember = "Department"
        '
        'cmbSemester
        '
        Me.cmbSemester.DataSource = Me.SemesterBindingSource
        Me.cmbSemester.DisplayMember = "Sem"
        Me.cmbSemester.FormattingEnabled = True
        Me.cmbSemester.Location = New System.Drawing.Point(60, 67)
        Me.cmbSemester.Name = "cmbSemester"
        Me.cmbSemester.Size = New System.Drawing.Size(150, 28)
        Me.cmbSemester.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnView)
        Me.GroupBox1.Controls.Add(Me.btnRefresh)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(41, 91)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(672, 153)
        Me.GroupBox1.TabIndex = 99
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Option"
        '
        'btnView
        '
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnView.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.btnView.Location = New System.Drawing.Point(446, 57)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(156, 48)
        Me.btnView.TabIndex = 89
        Me.btnView.Text = "VIEW"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnRefresh.Location = New System.Drawing.Point(88, 57)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(156, 48)
        Me.btnRefresh.TabIndex = 88
        Me.btnRefresh.Text = "REFRESH"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(156, 33)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(296, 28)
        Me.txtSearch.TabIndex = 98
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(56, 40)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(84, 20)
        Me.Label25.TabIndex = 97
        Me.Label25.Text = "SEARCH:"
        '
        'dgvStudentInfo
        '
        Me.dgvStudentInfo.AllowUserToDeleteRows = False
        Me.dgvStudentInfo.AutoGenerateColumns = False
        Me.dgvStudentInfo.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.dgvStudentInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudentInfo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudIDDataGridViewTextBoxColumn1, Me.FnameDataGridViewTextBoxColumn, Me.MnameDataGridViewTextBoxColumn, Me.LnameDataGridViewTextBoxColumn, Me.YearDataGridViewTextBoxColumn, Me.ContactNoDataGridViewTextBoxColumn, Me.BirthdateDataGridViewTextBoxColumn, Me.AgeDataGridViewTextBoxColumn, Me.SexDataGridViewTextBoxColumn, Me.NicknameDataGridViewTextBoxColumn, Me.CivilStatusDataGridViewTextBoxColumn, Me.ReligionDataGridViewTextBoxColumn, Me.PlaceOfBirthDataGridViewTextBoxColumn, Me.HomeAddressDataGridViewTextBoxColumn, Me.StudentsStatusDataGridViewTextBoxColumn, Me.ImgDataGridViewImageColumn})
        Me.dgvStudentInfo.DataSource = Me.StudentInformationBindingSource10
        Me.dgvStudentInfo.Location = New System.Drawing.Point(41, 291)
        Me.dgvStudentInfo.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvStudentInfo.Name = "dgvStudentInfo"
        Me.dgvStudentInfo.RowTemplate.Height = 24
        Me.dgvStudentInfo.Size = New System.Drawing.Size(1149, 465)
        Me.dgvStudentInfo.TabIndex = 96
        '
        'StudIDDataGridViewTextBoxColumn1
        '
        Me.StudIDDataGridViewTextBoxColumn1.DataPropertyName = "Stud_ID"
        Me.StudIDDataGridViewTextBoxColumn1.HeaderText = "Stud_ID"
        Me.StudIDDataGridViewTextBoxColumn1.Name = "StudIDDataGridViewTextBoxColumn1"
        '
        'FnameDataGridViewTextBoxColumn
        '
        Me.FnameDataGridViewTextBoxColumn.DataPropertyName = "Fname"
        Me.FnameDataGridViewTextBoxColumn.HeaderText = "Fname"
        Me.FnameDataGridViewTextBoxColumn.Name = "FnameDataGridViewTextBoxColumn"
        '
        'MnameDataGridViewTextBoxColumn
        '
        Me.MnameDataGridViewTextBoxColumn.DataPropertyName = "Mname"
        Me.MnameDataGridViewTextBoxColumn.HeaderText = "Mname"
        Me.MnameDataGridViewTextBoxColumn.Name = "MnameDataGridViewTextBoxColumn"
        '
        'LnameDataGridViewTextBoxColumn
        '
        Me.LnameDataGridViewTextBoxColumn.DataPropertyName = "Lname"
        Me.LnameDataGridViewTextBoxColumn.HeaderText = "Lname"
        Me.LnameDataGridViewTextBoxColumn.Name = "LnameDataGridViewTextBoxColumn"
        '
        'YearDataGridViewTextBoxColumn
        '
        Me.YearDataGridViewTextBoxColumn.DataPropertyName = "Year"
        Me.YearDataGridViewTextBoxColumn.HeaderText = "Year"
        Me.YearDataGridViewTextBoxColumn.Name = "YearDataGridViewTextBoxColumn"
        '
        'ContactNoDataGridViewTextBoxColumn
        '
        Me.ContactNoDataGridViewTextBoxColumn.DataPropertyName = "ContactNo"
        Me.ContactNoDataGridViewTextBoxColumn.HeaderText = "ContactNo"
        Me.ContactNoDataGridViewTextBoxColumn.Name = "ContactNoDataGridViewTextBoxColumn"
        '
        'BirthdateDataGridViewTextBoxColumn
        '
        Me.BirthdateDataGridViewTextBoxColumn.DataPropertyName = "Birthdate"
        Me.BirthdateDataGridViewTextBoxColumn.HeaderText = "Birthdate"
        Me.BirthdateDataGridViewTextBoxColumn.Name = "BirthdateDataGridViewTextBoxColumn"
        '
        'AgeDataGridViewTextBoxColumn
        '
        Me.AgeDataGridViewTextBoxColumn.DataPropertyName = "Age"
        Me.AgeDataGridViewTextBoxColumn.HeaderText = "Age"
        Me.AgeDataGridViewTextBoxColumn.Name = "AgeDataGridViewTextBoxColumn"
        '
        'SexDataGridViewTextBoxColumn
        '
        Me.SexDataGridViewTextBoxColumn.DataPropertyName = "Sex"
        Me.SexDataGridViewTextBoxColumn.HeaderText = "Sex"
        Me.SexDataGridViewTextBoxColumn.Name = "SexDataGridViewTextBoxColumn"
        '
        'NicknameDataGridViewTextBoxColumn
        '
        Me.NicknameDataGridViewTextBoxColumn.DataPropertyName = "Nickname"
        Me.NicknameDataGridViewTextBoxColumn.HeaderText = "Nickname"
        Me.NicknameDataGridViewTextBoxColumn.Name = "NicknameDataGridViewTextBoxColumn"
        '
        'CivilStatusDataGridViewTextBoxColumn
        '
        Me.CivilStatusDataGridViewTextBoxColumn.DataPropertyName = "CivilStatus"
        Me.CivilStatusDataGridViewTextBoxColumn.HeaderText = "CivilStatus"
        Me.CivilStatusDataGridViewTextBoxColumn.Name = "CivilStatusDataGridViewTextBoxColumn"
        '
        'ReligionDataGridViewTextBoxColumn
        '
        Me.ReligionDataGridViewTextBoxColumn.DataPropertyName = "Religion"
        Me.ReligionDataGridViewTextBoxColumn.HeaderText = "Religion"
        Me.ReligionDataGridViewTextBoxColumn.Name = "ReligionDataGridViewTextBoxColumn"
        '
        'PlaceOfBirthDataGridViewTextBoxColumn
        '
        Me.PlaceOfBirthDataGridViewTextBoxColumn.DataPropertyName = "PlaceOfBirth"
        Me.PlaceOfBirthDataGridViewTextBoxColumn.HeaderText = "PlaceOfBirth"
        Me.PlaceOfBirthDataGridViewTextBoxColumn.Name = "PlaceOfBirthDataGridViewTextBoxColumn"
        '
        'HomeAddressDataGridViewTextBoxColumn
        '
        Me.HomeAddressDataGridViewTextBoxColumn.DataPropertyName = "HomeAddress"
        Me.HomeAddressDataGridViewTextBoxColumn.HeaderText = "HomeAddress"
        Me.HomeAddressDataGridViewTextBoxColumn.Name = "HomeAddressDataGridViewTextBoxColumn"
        '
        'StudentsStatusDataGridViewTextBoxColumn
        '
        Me.StudentsStatusDataGridViewTextBoxColumn.DataPropertyName = "StudentsStatus"
        Me.StudentsStatusDataGridViewTextBoxColumn.HeaderText = "StudentsStatus"
        Me.StudentsStatusDataGridViewTextBoxColumn.Name = "StudentsStatusDataGridViewTextBoxColumn"
        '
        'ImgDataGridViewImageColumn
        '
        Me.ImgDataGridViewImageColumn.DataPropertyName = "img"
        Me.ImgDataGridViewImageColumn.HeaderText = "img"
        Me.ImgDataGridViewImageColumn.Name = "ImgDataGridViewImageColumn"
        '
        'StudentInformationBindingSource10
        '
        Me.StudentInformationBindingSource10.DataMember = "Student_Information"
        Me.StudentInformationBindingSource10.DataSource = Me.DatabaseDataSet29
        '
        'DatabaseDataSet29
        '
        Me.DatabaseDataSet29.DataSetName = "DatabaseDataSet29"
        Me.DatabaseDataSet29.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'View
        '
        Me.View.DataSetName = "View"
        Me.View.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentInformationBindingSource5
        '
        Me.StudentInformationBindingSource5.DataMember = "Student_Information"
        Me.StudentInformationBindingSource5.DataSource = Me.View
        '
        'Student_InformationTableAdapter4
        '
        Me.Student_InformationTableAdapter4.ClearBeforeFill = True
        '
        'Views
        '
        Me.Views.DataSetName = "views"
        Me.Views.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentInformationBindingSource6
        '
        Me.StudentInformationBindingSource6.DataMember = "Student_Information"
        Me.StudentInformationBindingSource6.DataSource = Me.Views
        '
        'Student_InformationTableAdapter5
        '
        Me.Student_InformationTableAdapter5.ClearBeforeFill = True
        '
        'Student_InformationTableAdapter6
        '
        Me.Student_InformationTableAdapter6.ClearBeforeFill = True
        '
        'DatabaseDataSet28
        '
        Me.DatabaseDataSet28.DataSetName = "DatabaseDataSet28"
        Me.DatabaseDataSet28.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentInformationBindingSource8
        '
        Me.StudentInformationBindingSource8.DataMember = "Student_Information"
        Me.StudentInformationBindingSource8.DataSource = Me.DatabaseDataSet28
        '
        'Student_InformationTableAdapter7
        '
        Me.Student_InformationTableAdapter7.ClearBeforeFill = True
        '
        'Mainn
        '
        Me.Mainn.DataSetName = "mainn"
        Me.Mainn.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentInformationBindingSource9
        '
        Me.StudentInformationBindingSource9.DataMember = "Student_Information"
        Me.StudentInformationBindingSource9.DataSource = Me.Mainn
        '
        'Student_InformationTableAdapter8
        '
        Me.Student_InformationTableAdapter8.ClearBeforeFill = True
        '
        'Student_InformationTableAdapter9
        '
        Me.Student_InformationTableAdapter9.ClearBeforeFill = True
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1238, 892)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlSelectAll)
        Me.Controls.Add(Me.pnlView)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form9"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "."
        CType(Me.StudentInformationBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentInformationBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentInformationBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentInformationBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentInformationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CourseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet17BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchoolYearBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SemesterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchoolYearBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet15, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DatabaseDataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet7BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlView.ResumeLayout(False)
        Me.pnlView.PerformLayout()
        CType(Me.dgvStudentInformation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentInformationBindingSource7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSelectAll.ResumeLayout(False)
        Me.pnlSelectAll.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvStudentInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentInformationBindingSource10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentInformationBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Views, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentInformationBindingSource6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentInformationBindingSource8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mainn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentInformationBindingSource9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StudentInformationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DatabaseDataSet6 As student_information.DatabaseDataSet6
    Friend WithEvents StudentInformationBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Student_InformationTableAdapter As student_information.DatabaseDataSet6TableAdapters.Student_InformationTableAdapter
    Friend WithEvents DepartmentTableAdapter1 As student_information.DatabaseDataSet2TableAdapters.DepartmentTableAdapter
    Friend WithEvents StudInfoTableAdapter1 As student_information.Database2DataSetTableAdapters.studInfoTableAdapter
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DatabaseDataSet7BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DatabaseDataSet7 As student_information.DatabaseDataSet7
    Friend WithEvents DatabaseDataSet8 As student_information.DatabaseDataSet8
    Friend WithEvents StudentInformationBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents Student_InformationTableAdapter1 As student_information.DatabaseDataSet8TableAdapters.Student_InformationTableAdapter
    Friend WithEvents DatabaseDataSet15 As student_information.DatabaseDataSet15
    Friend WithEvents SchoolYearBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SchoolYearTableAdapter As student_information.DatabaseDataSet15TableAdapters.SchoolYearTableAdapter
    Friend WithEvents DatabaseDataSet16 As student_information.DatabaseDataSet16
    Friend WithEvents DepartmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DepartmentTableAdapter As student_information.DatabaseDataSet16TableAdapters.DepartmentTableAdapter
    Friend WithEvents DatabaseDataSet17BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DatabaseDataSet17 As student_information.DatabaseDataSet17
    Friend WithEvents CourseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CourseTableAdapter As student_information.DatabaseDataSet17TableAdapters.CourseTableAdapter
    Friend WithEvents DatabaseDataSet18 As student_information.DatabaseDataSet18
    Friend WithEvents SchoolYearBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents SchoolYearTableAdapter1 As student_information.DatabaseDataSet18TableAdapters.SchoolYearTableAdapter
    Friend WithEvents SemesterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SemesterTableAdapter As student_information.DatabaseDataSet17TableAdapters.SemesterTableAdapter
    Friend WithEvents txtExit As System.Windows.Forms.Label
    Friend WithEvents DatabaseDataSet23 As student_information.DatabaseDataSet23
    Friend WithEvents StudentInformationBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents Student_InformationTableAdapter2 As student_information.DatabaseDataSet23TableAdapters.Student_InformationTableAdapter
    Friend WithEvents DatabaseDataSet24 As student_information.DatabaseDataSet24
    Friend WithEvents StudentInformationBindingSource4 As System.Windows.Forms.BindingSource
    Friend WithEvents Student_InformationTableAdapter3 As student_information.DatabaseDataSet24TableAdapters.Student_InformationTableAdapter
    Friend WithEvents pnlView As System.Windows.Forms.Panel
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents dgvStudentInformation As System.Windows.Forms.DataGridView
    Friend WithEvents pnlSelectAll As System.Windows.Forms.Panel
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents cmbSearch As System.Windows.Forms.ComboBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbCourse As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSchoolYear As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSemester As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents dgvStudentInfo As System.Windows.Forms.DataGridView
    Friend WithEvents View As student_information.View
    Friend WithEvents StudentInformationBindingSource5 As System.Windows.Forms.BindingSource
    Friend WithEvents Student_InformationTableAdapter4 As student_information.ViewTableAdapters.Student_InformationTableAdapter
    Friend WithEvents Views As student_information.views
    Friend WithEvents StudentInformationBindingSource6 As System.Windows.Forms.BindingSource
    Friend WithEvents Student_InformationTableAdapter5 As student_information.viewsTableAdapters.Student_InformationTableAdapter
    Friend WithEvents DatabaseDataSet25 As student_information.DatabaseDataSet25
    Friend WithEvents StudentInformationBindingSource7 As System.Windows.Forms.BindingSource
    Friend WithEvents Student_InformationTableAdapter6 As student_information.DatabaseDataSet25TableAdapters.Student_InformationTableAdapter
    Friend WithEvents StudIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Course_Code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FnameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MnameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LnameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YearDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContactNoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BirthdateDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SexDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NicknameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CivilStatusDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReligionDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PlaceOfBirthDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HomeAddressDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StudentsStatusDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImgDataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents btnback As System.Windows.Forms.Button
    Friend WithEvents DatabaseDataSet28 As student_information.DatabaseDataSet28
    Friend WithEvents StudentInformationBindingSource8 As System.Windows.Forms.BindingSource
    Friend WithEvents Student_InformationTableAdapter7 As student_information.DatabaseDataSet28TableAdapters.Student_InformationTableAdapter
    Friend WithEvents Mainn As student_information.mainn
    Friend WithEvents StudentInformationBindingSource9 As System.Windows.Forms.BindingSource
    Friend WithEvents Student_InformationTableAdapter8 As student_information.mainnTableAdapters.Student_InformationTableAdapter
    Friend WithEvents DatabaseDataSet29 As student_information.DatabaseDataSet29
    Friend WithEvents StudentInformationBindingSource10 As System.Windows.Forms.BindingSource
    Friend WithEvents Student_InformationTableAdapter9 As student_information.DatabaseDataSet29TableAdapters.Student_InformationTableAdapter
    Friend WithEvents StudIDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YearDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContactNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BirthdateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SexDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NicknameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CivilStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReligionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PlaceOfBirthDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HomeAddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StudentsStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImgDataGridViewImageColumn As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents txtFname As System.Windows.Forms.Label
    Friend WithEvents txtLname As System.Windows.Forms.Label
    Friend WithEvents txtContact As System.Windows.Forms.Label
    Friend WithEvents cmbCourse_ID As System.Windows.Forms.Label
    Friend WithEvents txtBirthdate As System.Windows.Forms.Label
    Friend WithEvents cmbYear As System.Windows.Forms.Label
    Friend WithEvents txtAge As System.Windows.Forms.Label
    Friend WithEvents txtMname As System.Windows.Forms.Label
    Friend WithEvents txtPlaceOfBirth As System.Windows.Forms.Label
    Friend WithEvents cmbSex As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.Label
    Friend WithEvents txtNickName As System.Windows.Forms.Label
    Friend WithEvents txtStudent_ID As System.Windows.Forms.Label
    Friend WithEvents txtStudent As System.Windows.Forms.Label
    Friend WithEvents txtCivilStatus As System.Windows.Forms.Label
    Friend WithEvents txtReligion As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
