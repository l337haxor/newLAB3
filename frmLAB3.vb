Option Strict On

Public Class frmLAB3

    'Course: NETD-2202-01
    'Assignment: Lab 3
    'Name: Sterling Wenzelbach
    'Date : Created: 2019-0-13; Modifed 2019-0-13
    'Program description: The user will input 7 values in the input text box, one for each day of the week(7). 
    'Inputs are validated and must be a whole number, numeric and between 0 - 1000 (inclusive).
    'Each valid input will be displayed vertically inside another textbox.
    'When 7 valid inputs are entered, the user can then press the enter button to calculate the average of all the inputs.
    'The average will then be diplayed in the output label, at this point the user can only reset the form or exit the program.

    'DECLARATIONS
    Public Const MINIMUM_VALUE As Integer = 0                               'stores the minimum value a user can input 
    Public Const MAXIMUM_VALUE As Integer = 1000                            'stores the maximum value a user can input
    Public Const MAX_DAYS As Integer = 7                                    'stores the maximum days/inputs that can be entered
    Dim numberOfEmployees As Integer = 3
    Dim arraySize As Integer = MAX_DAYS * numberOfEmployees
    Dim arrayEmployees(numberOfEmployees - 1, MAX_DAYS - 1) As Integer      'create an array that holds 7 values
    Dim dayNumber As Integer = 1                                            'create an array that holds 7 values
    Dim arrayRowCounter As Integer = 0                                      'stores value for the array counter
    Dim arrayColumnCounter As Integer = -1
    Dim entry As String                                                     'stores input from txtInput
    Dim total As Integer
    Dim total1 As Integer                                                   'stores value for the total of the array values
    Dim total2 As Integer                                                   'stores value for the total of the array values
    Dim total3 As Integer                                                   'stores value for the total of the array values
    Dim employee1Average As Double
    Dim employee2Average As Double
    Dim employee3Average As Double

    Sub ResetForm()

        'reset values        
        ReDim arrayEmployees(numberOfEmployees - 1, MAX_DAYS - 1)
        arrayRowCounter = 0                    'stores value for the array counter
        arrayColumnCounter = -1
        total = 0
        total1 = 0
        total2 = 0
        total3 = 0
        '============

        'reset true/false 
        txtInput.ReadOnly = False     'enable user from entering values into txtInput
        btnEnter.Enabled = True    'enable the calculate button
        txtInput.Enabled = True
        txtInput.Select()
        '================

        'clear text/labels
        txtEmployee1.Text = ""
        txtEmployee2.Text = ""
        txtEmployee3.Text = ""
        lblOutput.Text = ""
        txtInput.Text = ""
        lblOutputEmployee1.Text = ""
        lblOutputEmployee2.Text = ""
        lblOutputEmployee3.Text = ""
        '================
    End Sub

    Function ValidInput(ByVal input As String) As Boolean

        Dim validOut As Integer
        Dim validGrade As Boolean

        If Integer.TryParse(input, validOut) Then
            If validOut >= MINIMUM_VALUE And validOut <= MAXIMUM_VALUE Then
                validGrade = True
            Else
                validGrade = False
            End If
        End If

        Return validGrade

    End Function

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        entry = txtInput.Text  'store the input into entry(string)  

        If (ValidInput(entry)) Then                        'Call validation on entry and if true
            If (dayNumber <= MAX_DAYS) Then                'If the day number is 7 or less
                lblOutput.Text = ""                        'clear output label of any potential messages
                arrayColumnCounter += 1                    'increase array column count by 1
                dayNumber += 1                             'increase the day by 1

                'check which employee is active to determine where to display the input text
                'the row number determines this
                If arrayRowCounter = 0 Then
                    txtEmployee1.Text += entry & vbCrLf
                ElseIf arrayRowCounter = 1 Then
                    txtEmployee2.Text += entry & vbCrLf
                Else
                    txtEmployee3.Text += entry & vbCrLf
                End If

                'store entry value into the array [row,column]
                arrayEmployees(arrayRowCounter, arrayColumnCounter) = CInt(entry)

                lblDay.Text = "Day: " & dayNumber.ToString                          'change the day label
                txtInput.Select()                                                   'set focus to the input text box

                If dayNumber > MAX_DAYS Then                                        'if the day goes over 7
                    dayNumber = 1                                                   'set day back to 1 for next employee
                    lblDay.Text = "Day: " & dayNumber.ToString                      'change the day label

                    'check which employee is active 
                    'determine average for active employee
                    If arrayRowCounter = 0 Then
                        For Each value As Integer In arrayEmployees
                            total1 += value
                        Next
                        'calculate the average; (total/7, in this case)
                        employee1Average = total1 / MAX_DAYS
                        'display the average, rounded to 2 decimals places
                        lblOutputEmployee1.Text = "Average: " & Math.Round(employee1Average, 2)
                        'change which employee label is bold
                        lblEmployee1.Font = New Font(lblEmployee1.Font, FontStyle.Regular)
                        lblEmployee2.Font = New Font(lblEmployee2.Font, FontStyle.Bold)

                    ElseIf arrayRowCounter = 1 Then

                        For Each value As Integer In arrayEmployees
                            total2 += value
                        Next
                        'calculate the average; (this total minus the previous employee total) / 7
                        employee2Average = (total2 - total1) / MAX_DAYS                     'calculate the average; (total/7, in this case)
                        lblOutputEmployee2.Text = "Average: " & Math.Round(employee2Average, 2)
                        lblEmployee2.Font = New Font(lblEmployee2.Font, FontStyle.Regular)
                        lblEmployee3.Font = New Font(lblEmployee3.Font, FontStyle.Bold)

                    Else

                        For Each value As Integer In arrayEmployees
                            total3 += value
                        Next
                        'calculate the average; (this total minus the previous employee total) / 7
                        employee3Average = (total3 - total2) / MAX_DAYS                     'calculate the average; (total/7, in this case)
                        lblOutputEmployee3.Text = "Average: " & Math.Round(employee3Average, 2)

                        'Calculate total average of all employees
                        Dim totalAverage As Double

                        For Each value As Integer In arrayEmployees
                            total += value
                        Next
                        'total of all employees values / size of the array (21)
                        totalAverage = total / arraySize
                        lblOutput.ForeColor = Color.Black
                        lblOutput.Text = "The total average for all employees is: " & Math.Round(totalAverage, 2)

                        'disable enter button and input textbox,set focus to reset button and clear value stored in entry
                        btnEnter.Enabled = False
                        txtInput.Enabled = False
                        btnReset.Select()
                        entry = ""

                    End If
                    'increase array row by 1(switch to next employee) and reset the column back to 0
                    'ready for the next employees first value
                    arrayRowCounter += 1
                    arrayColumnCounter = -1

                End If

            End If
        Else
            'display error message if validation fails
            txtInput.Select()
            txtInput.SelectionStart = 0
            txtInput.SelectionLength = Len(txtInput.Text)
            lblOutput.ForeColor = Color.Red
            lblOutput.Text = "ERROR: Input must be numeric and between " & MINIMUM_VALUE & "-" & MAXIMUM_VALUE & "."
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Call ResetForm() 'call the resetform subroutine (resets the program)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit() ' exit program
    End Sub

    Private Sub frmLAB3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'start the form off with the 'Employee 1' label as bold
        lblEmployee1.Font = New Font(lblEmployee1.Font, FontStyle.Bold)
        ''start the form off with the day label as "Day:1"
        lblDay.Text = "Day: " & dayNumber.ToString

    End Sub
End Class