Public Class HomeForm

    'Variable Declaration
    'Public Property v_get_usertype_id As Byte

    Private Sub HomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Label3.Text = v_get_usertype_id
        Label3.Text = v_usertype_id
    End Sub

    Private Sub HomeForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        End
    End Sub

    Private Sub AddStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddStudentToolStripMenuItem.Click
        Dim a As New AddNewStudentForm
        a.Show()
    End Sub

    Private Sub UpdateStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateStudentToolStripMenuItem.Click
        Dim a As New UpdateStudentForm
        a.Show()
    End Sub

    Private Sub StudentDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentDetailsToolStripMenuItem.Click
        Dim a As New StudentDetailForm
        a.Show()
    End Sub

    Private Sub AddClassToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddClassToolStripMenuItem.Click
        Dim a As New AddNewClassForm
        a.Show()
    End Sub

    Private Sub ClassDetailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClassDetailToolStripMenuItem.Click
        Dim a As New ClassDetailForm
        a.Show()
    End Sub

    Private Sub AddStaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddStaffToolStripMenuItem.Click
        Dim a As New AddNewEmployeeForm
        a.Show()
    End Sub

    Private Sub StaffDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StaffDetailsToolStripMenuItem.Click
        Dim a As New EmployeeDetailForm
        a.Show()
    End Sub

    Private Sub AddSubjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddSubjectToolStripMenuItem.Click
        Dim a As New AddNewSubjectForm
        a.Show()
    End Sub

    Private Sub AddFeesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddFeesToolStripMenuItem.Click
        Dim a As New AddNewFeesForm
        a.Show()
    End Sub

End Class