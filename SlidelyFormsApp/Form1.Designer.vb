<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class btnViewSubmissions
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
        Me.btnCreateNewSubmission = New System.Windows.Forms.Button()
        Me.btnViewSubmissionss = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCreateNewSubmission
        '
        Me.btnCreateNewSubmission.Location = New System.Drawing.Point(74, 141)
        Me.btnCreateNewSubmission.Name = "btnCreateNewSubmission"
        Me.btnCreateNewSubmission.Size = New System.Drawing.Size(190, 23)
        Me.btnCreateNewSubmission.TabIndex = 1
        Me.btnCreateNewSubmission.Text = "Create New Submission"
        Me.btnCreateNewSubmission.UseVisualStyleBackColor = True
        '
        'btnViewSubmissionss
        '
        Me.btnViewSubmissionss.Location = New System.Drawing.Point(74, 76)
        Me.btnViewSubmissionss.Name = "btnViewSubmissionss"
        Me.btnViewSubmissionss.Size = New System.Drawing.Size(190, 23)
        Me.btnViewSubmissionss.TabIndex = 3
        Me.btnViewSubmissionss.Text = "View Submissions"
        Me.btnViewSubmissionss.UseVisualStyleBackColor = True
        '
        'btnViewSubmissions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnViewSubmissionss)
        Me.Controls.Add(Me.btnCreateNewSubmission)
        Me.Name = "btnViewSubmissions"
        Me.Text = "View Submissions"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCreateNewSubmission As Button
    Friend WithEvents btnViewSubmissionss As Button
End Class
