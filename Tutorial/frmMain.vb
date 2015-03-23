Public Class frmMain

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboStudentIDCourseIDLoad()
        lvwSummaryLoad()
    End Sub

    Private Sub btnSaveStudent_Click(sender As Object, e As EventArgs) Handles btnSaveStudent.Click
        Connect()
        rs.Open("tblStudent", con, 3, 3)
        rs.AddNew()
        rs("StudentID").Value = txtStudentID.Text
        rs("Name").Value = txtName.Text
        rs("Gender").Value = cboGender.Text
        rs("Address").Value = txtAddress.Text
        rs.Update()
        MsgBox("Successfully saved!")
        rs.Close()
        con.Close()
        cboStudentIDCourseIDLoad()
        lvwSummaryLoad()
    End Sub

    Private Sub btnCourseSave_Click(sender As Object, e As EventArgs) Handles btnCourseSave.Click
        Connect()
        rs.Open("tblCourse", con, 3, 3)
        rs.AddNew()
        rs("CourseID").Value = txtCourseID.Text
        rs("CourseDesc").Value = txtCourseDesc.Text
        rs.Update()
        MsgBox("Successfully saved!")
        rs.Close()
        con.Close()
        cboStudentIDCourseIDLoad()
        lvwSummaryLoad()
    End Sub

    Private Sub btnStudentCourseSave_Click(sender As Object, e As EventArgs) Handles btnStudentCourseSave.Click
        Connect()
        rs.Open("tblCourseStudent", con, 3, 3)
        rs.AddNew()
        rs("StudentID").Value = cboStudentID.Text
        rs("CourseID").Value = cboCourseID.Text
        rs.Update()
        MsgBox("Successfully saved!")
        rs.Close()
        con.Close()
        lvwSummaryLoad()
        cboStudentIDCourseIDLoad()
    End Sub
    Sub lvwSummaryLoad()
        lvwSummary.Items.Clear()
        Connect()
        rs.Open("SELECT tblCourseStudent.*, tblStudent.*, tblCourse.* " & _
                "FROM tblCourseStudent, tblStudent, tblCourse " & _
                "WHERE tblCourseStudent.StudentID=tblStudent.StudentID AND " & _
                "tblCourseStudent.CourseID=tblCourse.CourseID", con, 3, 3)
        Dim i As Integer = 0
        If rs.RecordCount <> 0 Then
            lvwSummary.Items.Add(rs("tblCourseStudent.StudentID").Value)
            lvwSummary.Items(i).SubItems.Add(rs("Name").Value)
            lvwSummary.Items(i).SubItems.Add(rs("CourseDesc").Value)
            rs.MoveNext()
            i = i + 1
        End If
        rs.Close()
        con.Close()
    End Sub
    Sub cboStudentIDCourseIDLoad()
        cboCourseID.Items.Clear()
        cboStudentID.Items.Clear()
        Connect()
        rs.Open("SELECT StudentID FROM tblStudent", con, 3, 3)
        If rs.RecordCount <> 0 Then
            Do Until rs.EOF
                cboStudentID.Items.Add(rs("StudentID").Value)
                rs.MoveNext()
            Loop
        End If
        rs.Close()
        con.Close()
        Connect()
        rs.Open("tblCourse", con, 3, 3)
        If rs.RecordCount <> 0 Then
            Do Until rs.EOF
                cboCourseID.Items.Add(rs("CourseID").Value)
                rs.MoveNext()
            Loop
        End If
        rs.Close()
        con.Close()
    End Sub


    Private Sub cboStudentID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStudentID.SelectedIndexChanged
        Connect()
        rs.Open("SELECT StudentID, Name FROM tblStudent WHERE StudentID='" & cboStudentID.Text & "'", con, 3, 3)
        If rs.RecordCount <> 0 Then
            lblStudentName.Text = rs("Name").Value
        End If
        rs.Close()
        con.Close()
    End Sub

    Private Sub cboCourseID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCourseID.SelectedIndexChanged
        Connect()
        rs.Open("SELECT * FROM tblCourse WHERE CourseID='" & cboCourseID.Text & "'", con, 3, 3)
        If rs.RecordCount <> 0 Then
            lblCourseDesc.Text = rs("CourseDesc").Value
        End If
        rs.Close()
        con.Close()
    End Sub
End Class
