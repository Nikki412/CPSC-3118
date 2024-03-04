Imports System.IO
' Nikki Johnson
' Project: Comic Convention Registration 
' Class: CPSC 3118
' Desription: This Project calculates the registration cost based on the group size and the type of badge.

Public Class Form1
    ' Variables
    Dim strSize As String
    Dim decSize As Decimal
    Dim strCost As String
    Dim decCost As Decimal
    Dim numericCheck As Boolean

    ' Constants
    Const cdecSuper As Decimal = 380
    Const cdecAuto As Decimal = 275
    Const cdecConv As Decimal = 209

    ' When the calculate button is clicked, the program calculates the registration cost based on the group size and the type of badge
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Get the group size from the test box
        strSize = txtSize.Text
        ' check to see if the group size is a numerical value
        numericCheck = IsNumeric(strSize)
        ' If the group size is a numeerical value then check if it is a number greater than zero and less than 20
        If numericCheck = True Then
            decSize = Convert.ToDecimal(strSize)
            ' If the group size is valid (greater than 0, less than 20) calculate the registration cost based on the radio button selected
            If decSize > 0 And decSize < 20 Then
                If RadioButton1.Checked = True Then
                    decCost = decSize * cdecSuper
                ElseIf RadioButton2.Checked = True Then
                    decCost = decSize * cdecAuto
                ElseIf RadioButton3.Checked = True Then
                    decCost = decSize * cdecConv
                End If
                ' Convert the registration cost to a currency formatted string and add it to the lblText
                strCost = decCost.ToString("C2")
                lblTotal.Text += strCost
            Else
                ' Display an error message if the user entered a negative number or a number greater than 20
                MsgBox("Group size needs to be a positive number and less than 20. Try again", MsgBoxStyle.OkOnly, "Entry Error")
                txtSize.Clear()
                txtSize.Focus()
            End If
        Else
            ' Display an error message is the user entered a nonnumeric value
            MsgBox("Group size needs to be a numeric value. Try again", MsgBoxStyle.OkOnly, "Entry Error")
            txtSize.Clear()
            txtSize.Focus()
        End If
    End Sub

    ' When the clear button is clicked, the user textbox is cleat=red and focus anf the total label is cleared
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' clear the text box and focus it 
        txtSize.Clear()
        txtSize.Focus()

        ' Reset the default Radio Button and clear the total
        RadioButton3.Checked = True
        lblTotal.Text = ""
    End Sub
End Class
