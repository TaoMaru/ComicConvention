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
        ' focus on txtGroup & set lblPrice to blank 000 price
        txtGroup.Focus()
        lblPrice.Text = "$000.00"
    End Sub

    Dim strSize As String
    Dim intSize As Int32
    Dim strType As String
    Dim decTotal As Decimal
    Dim strTotal As String

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' clears input from txtPrice & resets focus onto txtGroup resests lblPrice display
        ' unchecks radio btns
        txtGroup.Clear()
        txtGroup.Focus()
        lblPrice.Text = "$000.00"
        decTotal = 0
        strTotal = ""
        radSuperhero.Checked = False
        radAutograph.Checked = False
        radConvention.Checked = False

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        strSize = txtGroup.Text

        If IsNumeric(strSize) Then
            'convert string to int
            intSize = Convert.ToInt32(strSize)

            'calculate rate
            If intSize > 0 And intSize < 21 Then
                If radSuperhero.Checked = True Then
                    decTotal = intSize * cdecSuperhero 'cost for superhero option
                ElseIf radAutograph.Checked = True Then
                    decTotal = intSize * cdecAutograph 'cost for autographs option
                ElseIf radConvention.Checked = True Then
                    decTotal = intSize * cdecConvention 'cost for standard convention
                Else
                    'no badge type was select, display msgBox
                    MsgBox("Please Select a Badge Type", , "Badge Type Not Selected")
                    'reset total and txtGroup text, focus on txtGroup
                    decTotal = 000D
                    strTotal = "$000.00"
                End If
                'display estimated price in lblPrice
                strTotal = decTotal.ToString("C2")
                lblPrice.Text = strTotal
            Else 'input must be positive integer
                MsgBox("You Entered: " & strSize & " Please Enter a Positive Number Between 1-20",
                                    , "Input Error")
                'reset total
                decTotal = 000D
                strTotal = "$000.00"
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
