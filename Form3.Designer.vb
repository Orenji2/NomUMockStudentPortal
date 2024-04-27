<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        labelName = New Label()
        labelPassword = New Label()
        lblEnglishGrade = New Label()
        lblMathGrade = New Label()
        lblScienceGrade = New Label()
        tbName = New TextBox()
        tbMGrade = New TextBox()
        tbSGrade = New TextBox()
        tbEGrade = New TextBox()
        tbPass = New TextBox()
        btnCancel = New Button()
        btnConfirm = New Button()
        SuspendLayout()
        ' 
        ' labelName
        ' 
        labelName.AutoSize = True
        labelName.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        labelName.ForeColor = SystemColors.Control
        labelName.Location = New Point(52, 52)
        labelName.Name = "labelName"
        labelName.Size = New Size(59, 20)
        labelName.TabIndex = 0
        labelName.Text = "Name: "
        ' 
        ' labelPassword
        ' 
        labelPassword.AutoSize = True
        labelPassword.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        labelPassword.ForeColor = SystemColors.Control
        labelPassword.Location = New Point(52, 89)
        labelPassword.Name = "labelPassword"
        labelPassword.Size = New Size(80, 20)
        labelPassword.TabIndex = 1
        labelPassword.Text = "Password:"
        ' 
        ' lblEnglishGrade
        ' 
        lblEnglishGrade.AutoSize = True
        lblEnglishGrade.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblEnglishGrade.ForeColor = SystemColors.Control
        lblEnglishGrade.Location = New Point(52, 190)
        lblEnglishGrade.Name = "lblEnglishGrade"
        lblEnglishGrade.Size = New Size(109, 20)
        lblEnglishGrade.TabIndex = 2
        lblEnglishGrade.Text = "English Grade:"
        ' 
        ' lblMathGrade
        ' 
        lblMathGrade.AutoSize = True
        lblMathGrade.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblMathGrade.ForeColor = SystemColors.Control
        lblMathGrade.Location = New Point(52, 229)
        lblMathGrade.Name = "lblMathGrade"
        lblMathGrade.Size = New Size(96, 20)
        lblMathGrade.TabIndex = 3
        lblMathGrade.Text = "Math Grade:"
        ' 
        ' lblScienceGrade
        ' 
        lblScienceGrade.AutoSize = True
        lblScienceGrade.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        lblScienceGrade.ForeColor = SystemColors.Control
        lblScienceGrade.Location = New Point(52, 265)
        lblScienceGrade.Name = "lblScienceGrade"
        lblScienceGrade.Size = New Size(110, 20)
        lblScienceGrade.TabIndex = 4
        lblScienceGrade.Text = "Science Grade:"
        ' 
        ' tbName
        ' 
        tbName.Location = New Point(172, 52)
        tbName.Name = "tbName"
        tbName.Size = New Size(182, 23)
        tbName.TabIndex = 5
        ' 
        ' tbMGrade
        ' 
        tbMGrade.Location = New Point(172, 226)
        tbMGrade.Name = "tbMGrade"
        tbMGrade.Size = New Size(182, 23)
        tbMGrade.TabIndex = 6
        ' 
        ' tbSGrade
        ' 
        tbSGrade.Location = New Point(172, 262)
        tbSGrade.Name = "tbSGrade"
        tbSGrade.Size = New Size(182, 23)
        tbSGrade.TabIndex = 7
        ' 
        ' tbEGrade
        ' 
        tbEGrade.Location = New Point(172, 185)
        tbEGrade.Name = "tbEGrade"
        tbEGrade.Size = New Size(182, 23)
        tbEGrade.TabIndex = 8
        ' 
        ' tbPass
        ' 
        tbPass.Location = New Point(172, 86)
        tbPass.Name = "tbPass"
        tbPass.PasswordChar = "*"c
        tbPass.Size = New Size(182, 23)
        tbPass.TabIndex = 9
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.IndianRed
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel.Location = New Point(188, 317)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(193, 93)
        btnCancel.TabIndex = 11
        btnCancel.Text = "CANCEL"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnConfirm
        ' 
        btnConfirm.BackColor = Color.YellowGreen
        btnConfirm.FlatStyle = FlatStyle.Flat
        btnConfirm.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnConfirm.Location = New Point(2, 317)
        btnConfirm.Name = "btnConfirm"
        btnConfirm.Size = New Size(188, 93)
        btnConfirm.TabIndex = 10
        btnConfirm.Text = "CONFIRM"
        btnConfirm.UseVisualStyleBackColor = False
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Coral
        ClientSize = New Size(382, 412)
        Controls.Add(btnCancel)
        Controls.Add(btnConfirm)
        Controls.Add(tbPass)
        Controls.Add(tbEGrade)
        Controls.Add(tbSGrade)
        Controls.Add(tbMGrade)
        Controls.Add(tbName)
        Controls.Add(lblScienceGrade)
        Controls.Add(lblMathGrade)
        Controls.Add(lblEnglishGrade)
        Controls.Add(labelPassword)
        Controls.Add(labelName)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents labelName As Label
    Friend WithEvents labelPassword As Label
    Friend WithEvents lblEnglishGrade As Label
    Friend WithEvents lblMathGrade As Label
    Friend WithEvents lblScienceGrade As Label
    Friend WithEvents tbName As TextBox
    Friend WithEvents tbMGrade As TextBox
    Friend WithEvents tbSGrade As TextBox
    Friend WithEvents tbEGrade As TextBox
    Friend WithEvents tbPass As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnConfirm As Button
End Class
