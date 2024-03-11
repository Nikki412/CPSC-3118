' Nikki Johnson
' Class CPSC 3118
' Project: Midterm Project - Inches and Meters Conversion 
' Description: This program converts a user's input from inches to meters or vice versa depending on the radio button selected.
' The program then displays the results, The user is able to clear and calculate conversions multiple times until the exit button is clicked. 
Public Class Form1
    ' Variables
    Dim strInput As String
    Dim decInput As Decimal
    dim strResults As String
    Dim decResults As Decimal
    Dim numericCheck As Boolean

    ' Constants
    Const cdecInchToMeters As Decimal = 0.0254
    Const cdecMetersToInch As Decimal = 39.3701


    ' When the convert button is clicked, check to see if the input is a positive numerical value. If not display error messages. If it is, convert the input and display the results based on the radio button selected.
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        ' Get the conversion number from the text box
        strInput = txtInput.Text
        ' Check to see if the input was a numerical 
        numericCheck = IsNumeric(strInput)
        ' If the input is a numeric value 
        If numericCheck Then
            ' Check to see that the input is positive
            decInput = Convert.ToDecimal(strInput)
            ' If input is positive, calculate the conversion based on the radio button selected and display the results
            If decInput > 0 Then
                ' If RadioButton1 is selected, convert inches to meters
                If RadioButton1.Checked = True Then
                    decResults = decInput * cdecInchToMeters
                    ' display the results to 3 decimal places
                    ' used https://www.vbforums.com/showthread.php?669463-3-decimal-places to figure out how to round the result to 3 decimal places
                    lblResults.Text = strInput + " inches are " + FormatNumber(decResults, 3) + " meters."
                    ' If RadioButton2 is selected, convert meters to inches 
                ElseIf RadioButton2.Checked = True Then
                    decResults = decInput * cdecMetersToInch
                    ' display the results to 3 decimal places
                    lblResults.Text = strInput + " meters are " + FormatNumber(decResults, 3) + " inches."
                End If

            Else
                ' Display an error message if the input is not positive
                MsgBox("Input needs to be a positive number. Try again", MsgBoxStyle.OkOnly, "Entry Error")
                txtInput.Clear()
                txtInput.Focus()
            End If
        Else
            ' Display an error message if the input is not a numerical value
            MsgBox("Input needs to be a numerical value. Try again", MsgBoxStyle.OkOnly, "Entry Error")
            txtInput.Clear()
            txtInput.Focus()
        End If
    End Sub

    ' When the clear button is clicked, clear and focus the input textbox, select the default radio button, and clear the results label
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtInput.Clear()
        txtInput.Focus()

        RadioButton1.Checked = True
        lblResults.Text = ""
    End Sub

    ' When the exit button is clicked, exit the program
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
