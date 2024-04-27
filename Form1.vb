Public Class Form1

    Public listStudent As New List(Of Student)
    Public strCurrentUser As Student

    Public Sub New()
        InitializeComponent()
        Dim stud1 As New Student("Jose", "1234", 74, 75, 80)
        Dim stud2 As New Student("Juana", "abcd", 90, 95, 90)
        Dim stud3 As New Student("Cardo", "juana", 75, 75, 75)
        listStudent.Add(stud1)
        listStudent.Add(stud2)
        listStudent.Add(stud3)
    End Sub
    Class Student
        Private strName As String
        Private strPass As String
        Private dblEGrade As Double
        Private dblMGrade As Double
        Private dblSGrade As Double

        Public Sub New(ByVal strTempName As String, ByVal strTempPass As String, ByVal dblEnglish As Double, dblMath As Double, dblScience As Double)
            strName = strTempName
            strPass = strTempPass
            dblEGrade = dblEnglish
            dblMGrade = dblMath
            dblSGrade = dblScience
        End Sub

        Public Sub New()

        End Sub

        Public Sub SetUserCredentials(ByVal strTempName As String, ByVal strTempPass As String)
            strName = strTempName
            strPass = strTempPass
        End Sub

        Public Sub SetGrades(ByVal dblEnglish As Double, ByVal dblMath As Double, ByVal dblScience As Double)
            dblEGrade = dblEnglish
            dblMGrade = dblMath
            dblSGrade = dblScience
        End Sub

        Public Function GetName() As String

            Return strName
        End Function

        Public Function GetPass() As String

            Return strPass
        End Function

        Public Function GetGrades() As Array
            Dim arrayGrades(3) As Double
            arrayGrades(0) = dblEGrade
            arrayGrades(1) = dblMGrade
            arrayGrades(2) = dblSGrade
            Return arrayGrades
        End Function
    End Class

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click

        Dim intCounter = 0
        Dim loginFailed = 0
        Do While intCounter < listStudent.Count
            If tbUName.Text = listStudent(intCounter).GetName And tbPassword.Text = listStudent(intCounter).GetPass Then
                MsgBox("Welcome", vbOKOnly + vbInformation, "Log In Successful")

                Form2.Show()
                Me.Hide()
                strCurrentUser = listStudent(intCounter)
            End If
            intCounter += 1
        Loop
    End Sub

    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click
        Form3.Show()
    End Sub
End Class
