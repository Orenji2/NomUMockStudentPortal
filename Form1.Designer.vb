<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblNomU = New Label()
        lblStudPort = New Label()
        lblPassword = New Label()
        lblUName = New Label()
        tbUName = New TextBox()
        tbPassword = New TextBox()
        btnLogIn = New Button()
        btnAddStudent = New Button()
        SuspendLayout()
        ' 
        ' lblNomU
        ' 
        lblNomU.AutoSize = True
        lblNomU.Font = New Font("Playbill", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNomU.ForeColor = SystemColors.Control
        lblNomU.Location = New Point(141, 9)
        lblNomU.Name = "lblNomU"
        lblNomU.Size = New Size(140, 65)
        lblNomU.TabIndex = 0
        lblNomU.Text = "NOM U"
        ' 
        ' lblStudPort
        ' 
        lblStudPort.AutoSize = True
        lblStudPort.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStudPort.ForeColor = SystemColors.Control
        lblStudPort.Location = New Point(141, 87)
        lblStudPort.Name = "lblStudPort"
        lblStudPort.Size = New Size(146, 21)
        lblStudPort.TabIndex = 1
        lblStudPort.Text = "STUDENT PORTAL"
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPassword.ForeColor = SystemColors.Control
        lblPassword.Location = New Point(44, 183)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(65, 15)
        lblPassword.TabIndex = 2
        lblPassword.Text = "Password: "
        ' 
        ' lblUName
        ' 
        lblUName.AutoSize = True
        lblUName.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUName.ForeColor = SystemColors.Control
        lblUName.Location = New Point(36, 146)
        lblUName.Name = "lblUName"
        lblUName.Size = New Size(75, 15)
        lblUName.TabIndex = 3
        lblUName.Text = "User Name: "
        ' 
        ' tbUName
        ' 
        tbUName.Location = New Point(141, 146)
        tbUName.Name = "tbUName"
        tbUName.Size = New Size(199, 23)
        tbUName.TabIndex = 4
        ' 
        ' tbPassword
        ' 
        tbPassword.Location = New Point(141, 183)
        tbPassword.Name = "tbPassword"
        tbPassword.PasswordChar = "*"c
        tbPassword.Size = New Size(199, 23)
        tbPassword.TabIndex = 5
        ' 
        ' btnLogIn
        ' 
        btnLogIn.BackColor = Color.YellowGreen
        btnLogIn.FlatStyle = FlatStyle.Flat
        btnLogIn.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogIn.Location = New Point(0, 314)
        btnLogIn.Name = "btnLogIn"
        btnLogIn.Size = New Size(203, 94)
        btnLogIn.TabIndex = 6
        btnLogIn.Text = "LOG IN"
        btnLogIn.UseVisualStyleBackColor = False
        ' 
        ' btnAddStudent
        ' 
        btnAddStudent.BackColor = Color.IndianRed
        btnAddStudent.FlatStyle = FlatStyle.Flat
        btnAddStudent.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddStudent.Location = New Point(200, 314)
        btnAddStudent.Name = "btnAddStudent"
        btnAddStudent.Size = New Size(211, 94)
        btnAddStudent.TabIndex = 7
        btnAddStudent.Text = "ADD STUDENT"
        btnAddStudent.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Coral
        ClientSize = New Size(410, 408)
        Controls.Add(btnAddStudent)
        Controls.Add(btnLogIn)
        Controls.Add(tbPassword)
        Controls.Add(tbUName)
        Controls.Add(lblUName)
        Controls.Add(lblPassword)
        Controls.Add(lblStudPort)
        Controls.Add(lblNomU)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNomU As Label
    Friend WithEvents lblStudPort As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUName As Label
    Friend WithEvents tbUName As TextBox
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents btnLogIn As Button
    Friend WithEvents btnAddStudent As Button

End Class
