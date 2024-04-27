Public Class Form3
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim newStudent As New Form1.Student
        newStudent.SetUserCredentials(tbName.Text, tbPass.Text)
        newStudent.SetGrades(Val(tbEGrade.Text), Val(tbMGrade.Text), Val(tbSGrade.Text))
        Form1.listStudent.Add(newStudent)
        tbEGrade.Clear()
        tbMGrade.Clear()
        tbSGrade.Clear()
        MsgBox("Succesfully Enrolled", vbOKOnly + vbExclamation, "Success")
        Me.Close()
    End Sub
End Class