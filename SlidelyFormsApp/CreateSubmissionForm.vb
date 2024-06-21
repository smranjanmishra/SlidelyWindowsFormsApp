Public Class CreateSubmissionForm
    Inherits Form

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblStopwatch As Label
    Friend WithEvents btnToggleStopwatch As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtGitHub As TextBox

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub InitializeComponent()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtGitHub = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblStopwatch = New System.Windows.Forms.Label()
        Me.btnToggleStopwatch = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(186, 33)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(148, 22)
        Me.txtName.TabIndex = 0
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(186, 100)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(148, 22)
        Me.txtEmail.TabIndex = 1
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(186, 167)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(148, 22)
        Me.txtPhone.TabIndex = 2
        '
        'txtGitHub
        '
        Me.txtGitHub.Location = New System.Drawing.Point(186, 233)
        Me.txtGitHub.Name = "txtGitHub"
        Me.txtGitHub.Size = New System.Drawing.Size(148, 22)
        Me.txtGitHub.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(91, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(91, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(91, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Phone"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(91, 236)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "GitHub"
        '
        'lblStopwatch
        '
        Me.lblStopwatch.AutoSize = True
        Me.lblStopwatch.Location = New System.Drawing.Point(94, 319)
        Me.lblStopwatch.Name = "lblStopwatch"
        Me.lblStopwatch.Size = New System.Drawing.Size(48, 16)
        Me.lblStopwatch.TabIndex = 8
        Me.lblStopwatch.Text = "Label5"
        '
        'btnToggleStopwatch
        '
        Me.btnToggleStopwatch.Location = New System.Drawing.Point(502, 75)
        Me.btnToggleStopwatch.Name = "btnToggleStopwatch"
        Me.btnToggleStopwatch.Size = New System.Drawing.Size(150, 23)
        Me.btnToggleStopwatch.TabIndex = 9
        Me.btnToggleStopwatch.Text = "Toggle Stopwatch"
        Me.btnToggleStopwatch.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(502, 167)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(150, 23)
        Me.btnSubmit.TabIndex = 11
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'CreateSubmissionForm
        '
        Me.ClientSize = New System.Drawing.Size(752, 468)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnToggleStopwatch)
        Me.Controls.Add(Me.lblStopwatch)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtGitHub)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

End Class
