<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.grpStudent = New System.Windows.Forms.GroupBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.btnSaveStudent = New System.Windows.Forms.Button()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.grpCourse = New System.Windows.Forms.GroupBox()
        Me.btnStudentCourseSave = New System.Windows.Forms.Button()
        Me.cboCourseID = New System.Windows.Forms.ComboBox()
        Me.cboStudentID = New System.Windows.Forms.ComboBox()
        Me.btnCourseSave = New System.Windows.Forms.Button()
        Me.txtCourseDesc = New System.Windows.Forms.TextBox()
        Me.txtCourseID = New System.Windows.Forms.TextBox()
        Me.lvwSummary = New System.Windows.Forms.ListView()
        Me.StudentID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CourseDesc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblStudentName = New System.Windows.Forms.Label()
        Me.lblCourseDesc = New System.Windows.Forms.Label()
        Me.grpStudent.SuspendLayout()
        Me.grpCourse.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpStudent
        '
        Me.grpStudent.Controls.Add(Me.txtAddress)
        Me.grpStudent.Controls.Add(Me.btnSaveStudent)
        Me.grpStudent.Controls.Add(Me.cboGender)
        Me.grpStudent.Controls.Add(Me.txtName)
        Me.grpStudent.Controls.Add(Me.txtStudentID)
        Me.grpStudent.Location = New System.Drawing.Point(12, 12)
        Me.grpStudent.Name = "grpStudent"
        Me.grpStudent.Size = New System.Drawing.Size(220, 158)
        Me.grpStudent.TabIndex = 0
        Me.grpStudent.TabStop = False
        Me.grpStudent.Text = "Student"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(6, 98)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(202, 20)
        Me.txtAddress.TabIndex = 4
        Me.txtAddress.Text = "Student Addess"
        '
        'btnSaveStudent
        '
        Me.btnSaveStudent.Location = New System.Drawing.Point(133, 124)
        Me.btnSaveStudent.Name = "btnSaveStudent"
        Me.btnSaveStudent.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveStudent.TabIndex = 3
        Me.btnSaveStudent.Text = "Save"
        Me.btnSaveStudent.UseVisualStyleBackColor = True
        '
        'cboGender
        '
        Me.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cboGender.Location = New System.Drawing.Point(6, 71)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(121, 21)
        Me.cboGender.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(6, 45)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(202, 20)
        Me.txtName.TabIndex = 1
        Me.txtName.Text = "Student Name"
        '
        'txtStudentID
        '
        Me.txtStudentID.Location = New System.Drawing.Point(6, 19)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(121, 20)
        Me.txtStudentID.TabIndex = 0
        Me.txtStudentID.Text = "Student ID"
        '
        'grpCourse
        '
        Me.grpCourse.Controls.Add(Me.lblCourseDesc)
        Me.grpCourse.Controls.Add(Me.lblStudentName)
        Me.grpCourse.Controls.Add(Me.btnStudentCourseSave)
        Me.grpCourse.Controls.Add(Me.cboCourseID)
        Me.grpCourse.Controls.Add(Me.cboStudentID)
        Me.grpCourse.Controls.Add(Me.btnCourseSave)
        Me.grpCourse.Controls.Add(Me.txtCourseDesc)
        Me.grpCourse.Controls.Add(Me.txtCourseID)
        Me.grpCourse.Location = New System.Drawing.Point(238, 12)
        Me.grpCourse.Name = "grpCourse"
        Me.grpCourse.Size = New System.Drawing.Size(220, 158)
        Me.grpCourse.TabIndex = 1
        Me.grpCourse.TabStop = False
        Me.grpCourse.Text = "Course"
        '
        'btnStudentCourseSave
        '
        Me.btnStudentCourseSave.Location = New System.Drawing.Point(133, 124)
        Me.btnStudentCourseSave.Name = "btnStudentCourseSave"
        Me.btnStudentCourseSave.Size = New System.Drawing.Size(75, 23)
        Me.btnStudentCourseSave.TabIndex = 6
        Me.btnStudentCourseSave.Text = "Save"
        Me.btnStudentCourseSave.UseVisualStyleBackColor = True
        '
        'cboCourseID
        '
        Me.cboCourseID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCourseID.FormattingEnabled = True
        Me.cboCourseID.Location = New System.Drawing.Point(6, 100)
        Me.cboCourseID.Name = "cboCourseID"
        Me.cboCourseID.Size = New System.Drawing.Size(90, 21)
        Me.cboCourseID.TabIndex = 5
        '
        'cboStudentID
        '
        Me.cboStudentID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStudentID.FormattingEnabled = True
        Me.cboStudentID.Location = New System.Drawing.Point(6, 71)
        Me.cboStudentID.Name = "cboStudentID"
        Me.cboStudentID.Size = New System.Drawing.Size(90, 21)
        Me.cboStudentID.TabIndex = 4
        '
        'btnCourseSave
        '
        Me.btnCourseSave.Location = New System.Drawing.Point(133, 19)
        Me.btnCourseSave.Name = "btnCourseSave"
        Me.btnCourseSave.Size = New System.Drawing.Size(75, 23)
        Me.btnCourseSave.TabIndex = 3
        Me.btnCourseSave.Text = "Save"
        Me.btnCourseSave.UseVisualStyleBackColor = True
        '
        'txtCourseDesc
        '
        Me.txtCourseDesc.Location = New System.Drawing.Point(6, 45)
        Me.txtCourseDesc.Name = "txtCourseDesc"
        Me.txtCourseDesc.Size = New System.Drawing.Size(202, 20)
        Me.txtCourseDesc.TabIndex = 1
        Me.txtCourseDesc.Text = "Course Description"
        '
        'txtCourseID
        '
        Me.txtCourseID.Location = New System.Drawing.Point(6, 19)
        Me.txtCourseID.Name = "txtCourseID"
        Me.txtCourseID.Size = New System.Drawing.Size(121, 20)
        Me.txtCourseID.TabIndex = 0
        Me.txtCourseID.Text = "Course ID"
        '
        'lvwSummary
        '
        Me.lvwSummary.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.StudentID, Me.SName, Me.CourseDesc})
        Me.lvwSummary.GridLines = True
        Me.lvwSummary.Location = New System.Drawing.Point(12, 176)
        Me.lvwSummary.Name = "lvwSummary"
        Me.lvwSummary.Size = New System.Drawing.Size(448, 198)
        Me.lvwSummary.TabIndex = 2
        Me.lvwSummary.UseCompatibleStateImageBehavior = False
        Me.lvwSummary.View = System.Windows.Forms.View.Details
        '
        'StudentID
        '
        Me.StudentID.Text = "Student ID"
        Me.StudentID.Width = 64
        '
        'SName
        '
        Me.SName.Text = "Name"
        Me.SName.Width = 163
        '
        'CourseDesc
        '
        Me.CourseDesc.Text = "Course Description"
        Me.CourseDesc.Width = 157
        '
        'lblStudentName
        '
        Me.lblStudentName.AutoSize = True
        Me.lblStudentName.Location = New System.Drawing.Point(102, 74)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(35, 13)
        Me.lblStudentName.TabIndex = 7
        Me.lblStudentName.Text = "Name"
        '
        'lblCourseDesc
        '
        Me.lblCourseDesc.AutoSize = True
        Me.lblCourseDesc.Location = New System.Drawing.Point(102, 108)
        Me.lblCourseDesc.Name = "lblCourseDesc"
        Me.lblCourseDesc.Size = New System.Drawing.Size(96, 13)
        Me.lblCourseDesc.TabIndex = 8
        Me.lblCourseDesc.Text = "Course Description"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 393)
        Me.Controls.Add(Me.lvwSummary)
        Me.Controls.Add(Me.grpCourse)
        Me.Controls.Add(Me.grpStudent)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.grpStudent.ResumeLayout(False)
        Me.grpStudent.PerformLayout()
        Me.grpCourse.ResumeLayout(False)
        Me.grpCourse.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpStudent As System.Windows.Forms.GroupBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtStudentID As System.Windows.Forms.TextBox
    Friend WithEvents btnSaveStudent As System.Windows.Forms.Button
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents cboGender As System.Windows.Forms.ComboBox
    Friend WithEvents grpCourse As System.Windows.Forms.GroupBox
    Friend WithEvents btnCourseSave As System.Windows.Forms.Button
    Friend WithEvents txtCourseDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtCourseID As System.Windows.Forms.TextBox
    Friend WithEvents lvwSummary As System.Windows.Forms.ListView
    Friend WithEvents btnStudentCourseSave As System.Windows.Forms.Button
    Friend WithEvents cboCourseID As System.Windows.Forms.ComboBox
    Friend WithEvents cboStudentID As System.Windows.Forms.ComboBox
    Friend WithEvents StudentID As System.Windows.Forms.ColumnHeader
    Friend WithEvents SName As System.Windows.Forms.ColumnHeader
    Friend WithEvents CourseDesc As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblCourseDesc As System.Windows.Forms.Label
    Friend WithEvents lblStudentName As System.Windows.Forms.Label

End Class
