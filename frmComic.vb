' Program Name: Comic Convention registration
' Developer: Maria Jackson
' Date: Feb 25, 2023
' Purpose: This program calculates the registration cost for a comic convention.
''         The user can enter the expected group size and type of registration needed
''         The user can click calculate to get their expected total cost and
''         clear to cancel the group size input and prevous cost estimate and enter again
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' focus on txtGroup & set lblPrice to blank 000 price
        txtGroup.Focus()
        lblPrice.Text = "$000.00"
    End Sub

    Dim strSize As String
    Dim intSize As Int32
    Dim strType As String

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' clears input from txtPrice & resets focus onto txtGroup resests lblPrice display
        txtGroup.Clear()
        txtGroup.Focus()
        lblPrice.Text = "$000.00"

    End Sub
End Class
