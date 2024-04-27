<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        lblName = New Label()
        lblEng = New Label()
        lblMath = New Label()
        lblSci = New Label()
        lblSGrade = New Label()
        lblMGrade = New Label()
        lblEGrade = New Label()
        btnShowGrades = New Button()
        btnLogOut = New Button()
        lblNameCredential = New Label()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblName.ForeColor = SystemColors.Control
        lblName.Location = New Point(52, 72)
        lblName.Name = "lblName"
        lblName.Size = New Size(55, 20)
        lblName.TabIndex = 0
        lblName.Text = "Name:"
        ' 
        ' lblEng
        ' 
        lblEng.AutoSize = True
        lblEng.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblEng.ForeColor = SystemColors.Control
        lblEng.Location = New Point(52, 138)
        lblEng.Name = "lblEng"
        lblEng.Size = New Size(113, 20)
        lblEng.TabIndex = 1
        lblEng.Text = "English Grade: "
        ' 
        ' lblMath
        ' 
        lblMath.AutoSize = True
        lblMath.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblMath.ForeColor = SystemColors.Control
        lblMath.Location = New Point(52, 197)
        lblMath.Name = "lblMath"
        lblMath.Size = New Size(100, 20)
        lblMath.TabIndex = 2
        lblMath.Text = "Math Grade: "
        ' 
        ' lblSci
        ' 
        lblSci.AutoSize = True
        lblSci.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblSci.ForeColor = SystemColors.Control
        lblSci.Location = New Point(51, 260)
        lblSci.Name = "lblSci"
        lblSci.Size = New Size(110, 20)
        lblSci.TabIndex = 3
        lblSci.Text = "Science Grade:"
        ' 
        ' lblSGrade
        ' 
        lblSGrade.AutoSize = True
        lblSGrade.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblSGrade.ForeColor = SystemColors.Control
        lblSGrade.Location = New Point(224, 260)
        lblSGrade.Name = "lblSGrade"
        lblSGrade.Size = New Size(18, 20)
        lblSGrade.TabIndex = 6
        lblSGrade.Text = "0"
        lblSGrade.Visible = False
        ' 
        ' lblMGrade
        ' 
        lblMGrade.AutoSize = True
        lblMGrade.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblMGrade.ForeColor = SystemColors.Control
        lblMGrade.Location = New Point(225, 197)
        lblMGrade.Name = "lblMGrade"
        lblMGrade.Size = New Size(18, 20)
        lblMGrade.TabIndex = 5
        lblMGrade.Text = "0"
        lblMGrade.Visible = False
        ' 
        ' lblEGrade
        ' 
        lblEGrade.AutoSize = True
        lblEGrade.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblEGrade.ForeColor = SystemColors.Control
        lblEGrade.Location = New Point(224, 138)
        lblEGrade.Name = "lblEGrade"
        lblEGrade.Size = New Size(18, 20)
        lblEGrade.TabIndex = 4
        lblEGrade.Text = "0"
        lblEGrade.Visible = False
        ' 
        ' btnShowGrades
        ' 
        btnShowGrades.BackColor = Color.Green
        btnShowGrades.FlatStyle = FlatStyle.Flat
        btnShowGrades.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnShowGrades.ForeColor = Color.White
        btnShowGrades.Location = New Point(-2, 328)
        btnShowGrades.Name = "btnShowGrades"
        btnShowGrades.Size = New Size(220, 83)
        btnShowGrades.TabIndex = 7
        btnShowGrades.Text = "SHOW GRADES"
        btnShowGrades.UseVisualStyleBackColor = False
        ' 
        ' btnLogOut
        ' 
        btnLogOut.BackColor = Color.Red
        btnLogOut.FlatStyle = FlatStyle.Flat
        btnLogOut.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        btnLogOut.ForeColor = Color.White
        btnLogOut.Location = New Point(215, 328)
        btnLogOut.Name = "btnLogOut"
        btnLogOut.Size = New Size(223, 83)
        btnLogOut.TabIndex = 8
        btnLogOut.Text = "LOG OUT"
        btnLogOut.UseVisualStyleBackColor = False
        ' 
        ' lblNameCredential
        ' 
        lblNameCredential.AutoSize = True
        lblNameCredential.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblNameCredential.ForeColor = SystemColors.Control
        lblNameCredential.Location = New Point(225, 72)
        lblNameCredential.Name = "lblNameCredential"
        lblNameCredential.Size = New Size(0, 20)
        lblNameCredential.TabIndex = 9
        lblNameCredential.Visible = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Coral
        ClientSize = New Size(439, 409)
        Controls.Add(lblNameCredential)
        Controls.Add(btnLogOut)
        Controls.Add(btnShowGrades)
        Controls.Add(lblSGrade)
        Controls.Add(lblMGrade)
        Controls.Add(lblEGrade)
        Controls.Add(lblSci)
        Controls.Add(lblMath)
        Controls.Add(lblEng)
        Controls.Add(lblName)
        Name = "Form2"
        Text = "Student Portal"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblEng As Label
    Friend WithEvents lblMath As Label
    Friend WithEvents lblSci As Label
    Friend WithEvents lblSGrade As Label
    Friend WithEvents lblMGrade As Label
    Friend WithEvents lblEGrade As Label
    Friend WithEvents btnShowGrades As Button
    Friend WithEvents btnLogOut As Button
    Friend WithEvents lblNameCredential As Label
End Class
