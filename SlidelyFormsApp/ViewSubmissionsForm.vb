Public Class ViewSubmissionsForm
    Inherits Form

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGitHub As TextBox
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents lblStopwatch As TextBox

    Private submissions As List(Of Dictionary(Of String, String))
    Private currentIndex As Integer = 0

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub InitializeComponent()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtGitHub = New System.Windows.Forms.TextBox()
        Me.lblStopwatch = New System.Windows.Forms.TextBox()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(147, 68)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(100, 22)
        Me.txtName.TabIndex = 0
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(147, 164)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(100, 22)
        Me.txtEmail.TabIndex = 1
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(147, 260)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.ReadOnly = True
        Me.txtPhone.Size = New System.Drawing.Size(100, 22)
        Me.txtPhone.TabIndex = 2
        '
        'txtGitHub
        '
        Me.txtGitHub.Location = New System.Drawing.Point(147, 370)
        Me.txtGitHub.Name = "txtGitHub"
        Me.txtGitHub.ReadOnly = True
        Me.txtGitHub.Size = New System.Drawing.Size(100, 22)
        Me.txtGitHub.TabIndex = 3
        '
        'lblStopwatch
        '
        Me.lblStopwatch.Location = New System.Drawing.Point(147, 484)
        Me.lblStopwatch.Name = "lblStopwatch"
        Me.lblStopwatch.ReadOnly = True
        Me.lblStopwatch.Size = New System.Drawing.Size(100, 22)
        Me.lblStopwatch.TabIndex = 4
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(33, 585)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(143, 23)
        Me.btnPrevious.TabIndex = 5
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(217, 585)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(143, 23)
        Me.btnNext.TabIndex = 6
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'ViewSubmissionsForm
        '
        Me.ClientSize = New System.Drawing.Size(935, 747)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.lblStopwatch)
        Me.Controls.Add(Me.txtGitHub)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtName)
        Me.Name = "ViewSubmissionsForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Private Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load submissions from backend
        submissions = LoadSubmissions()
        ShowSubmission(0)
        Me.KeyPreview = True
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            ShowSubmission(currentIndex)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            ShowSubmission(currentIndex)
        End If
    End Sub

    Private Sub ShowSubmission(index As Integer)
        Dim submission = submissions(index)
        txtName.Text = submission("name")
        txtEmail.Text = submission("email")
        txtPhone.Text = submission("phone")
        txtGitHub.Text = submission("github_link")
        lblStopwatch.Text = submission("stopwatch_time")
    End Sub

    Private Function LoadSubmissions() As List(Of Dictionary(Of String, String))
        ' Code to load submissions from backend
    End Function

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevious.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnNext.PerformClick()
        End If
    End Sub
End Class
