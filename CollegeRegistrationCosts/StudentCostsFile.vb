' Class:        Student Costs File        
' Developer:    Diana Betances
' Date:         August 16, 2017
' Purpose:      This class represents the Student Costs File. The WriteRecord
'               procedure writes a comma-delimited student costs file that
'               contains the Student ID, Student Name, Major,
'               and Student Costs.

Option Strict On

Public Class StudentCostsFile


    ' Class variables
    Private _strStudentID As String
    Private _strStudentName As String
    Private _strMajor As String
    Private _decStudentCosts As Decimal

    Sub New(ByVal StudentID As String, ByVal StudentName As String, _
            ByVal Major As String, ByVal Costs As Decimal)
        ' This sub procedure is the constructor for the StudentCostsFile
        ' class

        ' The following code assigns the arguments to class variables
        _strStudentID = StudentID
        _strStudentName = StudentName
        _strMajor = Major
        _decStudentCosts = Costs

    End Sub

    Sub WriteRecord()
        ' This procedure opens the StudentCosts output text file and then
        ' writes a record in the comma-delimited file

        Dim strNameandLocationOfFile As String = My.Application.Info.DirectoryPath & "\StudentCosts.txt"

        Try
            Dim objWriter As IO.StreamWriter = IO.File.AppendText(strNameandLocationOfFile)

            objWriter.Write(_strStudentID & ",")
            objWriter.Write(_strStudentName & ",")
            objWriter.Write(_strMajor & ",")
            objWriter.WriteLine(_decStudentCosts)
            objWriter.Close()

        Catch ex As Exception
            MsgBox("No device available - program aborted", , "Error")
            Application.Exit()
        End Try

    End Sub


End Class

'