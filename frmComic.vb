' Program Name: Comic Convention registration
' Developer: Maria Jackson
' Date: Feb 25, 2023
' Purpose: This program calculates the registration cost for a comic convention.
''         The user can enter the expected group size and type of registration needed
''         The user can click calculate to get their expected total cost and
''         clear to cancel the group size input and prevous cost estimate and enter again
Public Class Form1

    Const cdecSuperhero As Decimal = 380D
    Const cdecAutograph As Decimal = 275D
    Const cdecConvention As Decimal = 209D

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' focus on txtGroup & set lblPrice to blank via btnClear
        btnClear.PerformClick()
    End Sub

    Dim strGroup As String
    Dim intGroup As Int32
    Dim decRegistration As Decimal
    Dim decTotal As Decimal
    Dim strTotal As String

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' clears input from txtPrice & resets focus onto txtGroup resests lblPrice display
        ' unchecks radio btns
        txtGroup.Clear()
        txtGroup.Focus()
        lblPrice.Text = ""
        radSuperhero.Checked = True

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        strGroup = txtGroup.Text

        If IsNumeric(strGroup) Then
            'convert string to int
            intGroup = Convert.ToInt32(strGroup)

            'determine the registration type
            If intGroup > 0 And intGroup < 21 Then
                If radSuperhero.Checked = True Then
                    decRegistration = cdecSuperhero 'cost for superhero option
                ElseIf radAutograph.Checked = True Then
                    decRegistration = cdecAutograph 'cost for autographs option
                ElseIf radConvention.Checked = True Then
                    decRegistration = cdecConvention 'cost for standard convention
                End If
                'calculate total
                decTotal = decRegistration * intGroup
                'display estimated price in lblPrice
                strTotal = decTotal.ToString("C2")
                lblPrice.Text = strTotal
            Else 'input must be positive integer
                MsgBox("You Entered: " & strGroup & " Please Enter a Positive Number Between 1-20",
                                    , "Input Error")
                txtGroup.Text = ""
                txtGroup.Focus()
            End If
        Else
            ' display msgBox of invalid input received
            ' clear txtGroup text & refocus on txtGroup
            MsgBox("Please Enter the Group Size", , "Input Error")
            txtGroup.Text = ""
            txtGroup.Focus()
        End If

    End Sub
End Class
