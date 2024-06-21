Public Class btnViewSubmissions
    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissionss.Click
        Dim viewForm As New ViewSubmissionsForm()
        viewForm.Show()
    End Sub

    Private Sub btnCreateNewSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateNewSubmission.Click
        Dim createForm As New CreateSubmissionForm()
        createForm.Show()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set keyboard shortcuts
        Me.KeyPreview = True
    End Sub

    Private Sub MainForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            btnViewSubmissionss.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnCreateNewSubmission.PerformClick()
        End If
    End Sub
End Class
