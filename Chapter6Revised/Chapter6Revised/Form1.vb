Imports System.IO
Public Class Form1
    Public sayings() As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Open file and read data into array
        If File.Exists("EightBData.txt") Then
            sayings = File.ReadAllLines("EightBData.txt")
            MessageBox.Show(sayings.Length)
        Else
            MessageBox.Show("The file is not available. Check that the file exists.", "ERROR")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

    End Sub
End Class
