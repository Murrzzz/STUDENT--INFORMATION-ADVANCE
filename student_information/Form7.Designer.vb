<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtExit = New System.Windows.Forms.Label()
        Me.dgvStudentInfo = New System.Windows.Forms.DataGridView()
        Me.StudIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.StudentInformationBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet29 = New student_information.DatabaseDataSet29()
        Me.RetrieveBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet21 = New student_information.DatabaseDataSet21()
        Me.RetrieveBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet20 = New student_information.DatabaseDataSet20()
        Me.RetrieveTableAdapter = New student_information.DatabaseDataSet20TableAdapters.RetrieveTableAdapter()
        Me.RetrieveTableAdapter1 = New student_information.DatabaseDataSet21TableAdapters.RetrieveTableAdapter()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnRetrieve = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DatabaseDataSet27 = New student_information.DatabaseDataSet27()
        Me.StudentInformationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Student_InformationTableAdapter = New student_information.DatabaseDataSet27TableAdapters.Student_InformationTableAdapter()
        Me.DatabaseDataSet29BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Student_InformationTableAdapter1 = New student_information.DatabaseDataSet29TableAdapters.Student_InformationTableAdapter()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvStudentInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentInformationBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RetrieveBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RetrieveBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet20, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DatabaseDataSet27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentInformationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet29BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtExit)
        Me.Panel1.Location = New System.Drawing.Point(-6, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1021, 68)
        Me.Panel1.TabIndex = 20
        '
        'txtExit
        '
        Me.txtExit.AutoSize = True
        Me.txtExit.BackColor = System.Drawing.Color.Transparent
        Me.txtExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExit.ForeColor = System.Drawing.Color.White
        Me.txtExit.Location = New System.Drawing.Point(965, 11)
        Me.txtExit.Name = "txtExit"
        Me.txtExit.Size = New System.Drawing.Size(48, 46)
        Me.txtExit.TabIndex = 39
        Me.txtExit.Text = "X"
        '
        'dgvStudentInfo
        '
        Me.dgvStudentInfo.AutoGenerateColumns = False
        Me.dgvStudentInfo.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.dgvStudentInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudentInfo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudIDDataGridViewTextBoxColumn, Me.FnameDataGridViewTextBoxColumn, Me.MnameDataGridViewTextBoxColumn, Me.LnameDataGridViewTextBoxColumn, Me.YearDataGridViewTextBoxColumn, Me.ContactNoDataGridViewTextBoxColumn, Me.BirthdateDataGridViewTextBoxColumn, Me.AgeDataGridViewTextBoxColumn, Me.SexDataGridViewTextBoxColumn, Me.NicknameDataGridViewTextBoxColumn, Me.CivilStatusDataGridViewTextBoxColumn, Me.ReligionDataGridViewTextBoxColumn, Me.PlaceOfBirthDataGridViewTextBoxColumn, Me.HomeAddressDataGridViewTextBoxColumn, Me.StudentsStatusDataGridViewTextBoxColumn, Me.ImgDataGridViewImageColumn})
        Me.dgvStudentInfo.DataSource = Me.StudentInformationBindingSource1
        Me.dgvStudentInfo.Location = New System.Drawing.Point(66, 248)
        Me.dgvStudentInfo.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvStudentInfo.Name = "dgvStudentInfo"
        Me.dgvStudentInfo.RowTemplate.Height = 24
        Me.dgvStudentInfo.Size = New System.Drawing.Size(878, 425)
        Me.dgvStudentInfo.TabIndex = 95
        '
        'StudIDDataGridViewTextBoxColumn
        '
        Me.StudIDDataGridViewTextBoxColumn.DataPropertyName = "Stud_ID"
        Me.StudIDDataGridViewTextBoxColumn.HeaderText = "Stud_ID"
        Me.StudIDDataGridViewTextBoxColumn.Name = "StudIDDataGridViewTextBoxColumn"
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
        'StudentInformationBindingSource1
        '
        Me.StudentInformationBindingSource1.DataMember = "Student_Information"
        Me.StudentInformationBindingSource1.DataSource = Me.DatabaseDataSet29
        '
        'DatabaseDataSet29
        '
        Me.DatabaseDataSet29.DataSetName = "DatabaseDataSet29"
        Me.DatabaseDataSet29.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RetrieveBindingSource1
        '
        Me.RetrieveBindingSource1.DataMember = "Retrieve"
        Me.RetrieveBindingSource1.DataSource = Me.DatabaseDataSet21
        '
        'DatabaseDataSet21
        '
        Me.DatabaseDataSet21.DataSetName = "DatabaseDataSet21"
        Me.DatabaseDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RetrieveBindingSource
        '
        Me.RetrieveBindingSource.DataMember = "Retrieve"
        Me.RetrieveBindingSource.DataSource = Me.DatabaseDataSet20
        '
        'DatabaseDataSet20
        '
        Me.DatabaseDataSet20.DataSetName = "DatabaseDataSet20"
        Me.DatabaseDataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RetrieveTableAdapter
        '
        Me.RetrieveTableAdapter.ClearBeforeFill = True
        '
        'RetrieveTableAdapter1
        '
        Me.RetrieveTableAdapter1.ClearBeforeFill = True
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.btnDelete.Location = New System.Drawing.Point(43, 33)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(204, 48)
        Me.btnDelete.TabIndex = 96
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnRetrieve
        '
        Me.btnRetrieve.BackColor = System.Drawing.Color.Transparent
        Me.btnRetrieve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRetrieve.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRetrieve.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.btnRetrieve.Location = New System.Drawing.Point(263, 33)
        Me.btnRetrieve.Name = "btnRetrieve"
        Me.btnRetrieve.Size = New System.Drawing.Size(204, 48)
        Me.btnRetrieve.TabIndex = 97
        Me.btnRetrieve.Text = "RETRIEVE"
        Me.btnRetrieve.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnRetrieve)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(66, 111)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(508, 107)
        Me.GroupBox1.TabIndex = 98
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "OPTIONS"
        '
        'DatabaseDataSet27
        '
        Me.DatabaseDataSet27.DataSetName = "DatabaseDataSet27"
        Me.DatabaseDataSet27.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentInformationBindingSource
        '
        Me.StudentInformationBindingSource.DataMember = "Student_Information"
        Me.StudentInformationBindingSource.DataSource = Me.DatabaseDataSet27
        '
        'Student_InformationTableAdapter
        '
        Me.Student_InformationTableAdapter.ClearBeforeFill = True
        '
        'DatabaseDataSet29BindingSource
        '
        Me.DatabaseDataSet29BindingSource.DataSource = Me.DatabaseDataSet29
        Me.DatabaseDataSet29BindingSource.Position = 0
        '
        'Student_InformationTableAdapter1
        '
        Me.Student_InformationTableAdapter1.ClearBeforeFill = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.DarkGray
        Me.Label24.Location = New System.Drawing.Point(603, 136)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(355, 60)
        Me.Label24.TabIndex = 99
        Me.Label24.Text = "Note:  When your Click DELETE The Data will" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Permanently deleted and when your cl" & _
            "ick" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "RETRIEVE your data will be recovered." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1011, 716)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvStudentInfo)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form7"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form7"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvStudentInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentInformationBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RetrieveBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RetrieveBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet20, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DatabaseDataSet27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentInformationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet29BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtExit As System.Windows.Forms.Label
    Friend WithEvents dgvStudentInfo As System.Windows.Forms.DataGridView
    Friend WithEvents DatabaseDataSet20 As student_information.DatabaseDataSet20
    Friend WithEvents RetrieveBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RetrieveTableAdapter As student_information.DatabaseDataSet20TableAdapters.RetrieveTableAdapter
    Friend WithEvents DatabaseDataSet21 As student_information.DatabaseDataSet21
    Friend WithEvents RetrieveBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents RetrieveTableAdapter1 As student_information.DatabaseDataSet21TableAdapters.RetrieveTableAdapter
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnRetrieve As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DatabaseDataSet27 As student_information.DatabaseDataSet27
    Friend WithEvents StudentInformationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Student_InformationTableAdapter As student_information.DatabaseDataSet27TableAdapters.Student_InformationTableAdapter
    Friend WithEvents DatabaseDataSet29BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DatabaseDataSet29 As student_information.DatabaseDataSet29
    Friend WithEvents StudentInformationBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Student_InformationTableAdapter1 As student_information.DatabaseDataSet29TableAdapters.Student_InformationTableAdapter
    Friend WithEvents StudIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents Label24 As System.Windows.Forms.Label
End Class
