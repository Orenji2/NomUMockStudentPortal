Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub btnShowGrades_Click(sender As Object, e As EventArgs) Handles btnShowGrades.Click

        Dim tempGrades() As Double = Form1.strCurrentUser.GetGrades

        lblEGrade.Text = tempGrades(0)
        lblMGrade.Text = tempGrades(1)
        lblSGrade.Text = tempGrades(2)
        lblNameCredential.Text = Form1.strCurrentUser.GetName
        lblEGrade.Visible = True
        lblMGrade.Visible = True
        lblSGrade.Visible = True
        lblNameCredential.Visible = True

    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class