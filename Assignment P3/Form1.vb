Imports System.Runtime
' Nikki Johnson 
Public Class Form1
    ' Variables
    Dim decPlatter As Decimal
    Dim strPlatter As String
    Dim strPay
    Dim strPoints As String
    Dim decPoints As Decimal
    Dim numericCheck As Boolean
    Dim decDiscount As Decimal
    Dim decResults As Decimal
    Dim validDiscount As Boolean

    ' Found how to do a form load event from https://www.youtube.com/watch?v=wNpuFsuto3w&ab_channel=DeborahS
    ' This sub procedure performs the same operations as the btnClear_Click() sub procedure
    Private Sub Form1_Load(sender As Object, a As EventArgs) Handles MyBase.Load
        ' Points textbox is cleared and has focus
        txtPoints.Clear()
        txtPoints.Focus()
        ' Payment display label cleared
        lblResults.Text() = ""
        ' Return state of seven (7) radio butons to default (see screenshot)
        RadioButton1.Checked() = True
        RadioButton6.Checked() = True
    End Sub
    ' This sub procedure calculates the discount based on the amount of loyalty points and displays the payment information 
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        '1. Determine the cost of the plater selected.
        defPlatter()
        '2. Get the loyalty points value.
        strPoints = txtPoints.Text
        ' check the input for loyalty points to see if it is a valid number before converting
        numericCheck = IsNumeric(strPoints)
        If numericCheck Then
            decPoints = Convert.ToDecimal(strPoints)
            '3. Calculate the discount.
            decDiscount = (decPoints \ 10) * 0.05
            decResults = decPlatter * (1 - decDiscount)
            ' check to see that the discount from loyalty points does not make the order a 0 or nega�ve price.
            validDiscount = decResults > 0
            If validDiscount Then
                '4. Based on which plater was chosen, the radio buton selections, And the loyalty points discount, format a String that presents the final price.
                decPoints = (decPoints \ 10) * 10
                strPoints = Convert.ToString(decPoints)
                '5. Display the payment information in a label using this format: Your order Veggie Plater costs $28.49 using Pre-Pay a�er discount of 10 loyalty points. 
                lblResults.Text = "Your order " & strPlatter & " costs $" & FormatNumber(decResults, 2) & " using " & strPay & " after discount of " & strPoints & " loyalty points"
            Else
                ' If so, tell the user they cannot use that many points For the order In a message box
                MsgBox("You cannot enter that many loyalty points. Try again", MsgBoxStyle.OkOnly, "Entry Error")
                ' And clear the field And give it focus.
                txtPoints.Clear()
                txtPoints.Focus()
            End If
        Else
            ' If it is not a valid number, display a message box alerting the user that the entry is not valid.
            MsgBox("Input needs to be a numerical value. Try again", MsgBoxStyle.OkOnly, "Entry Error")
            ' When the message box has been closed, clear the loyalty points field And give it focus.
            txtPoints.Clear()
            txtPoints.Focus()
        End If
    End Sub

    ' This sub procedure clears and focuses the label text box, clears the results textbox and check the deafult radio buttons 
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Points textbox is cleared and has focus
        txtPoints.Clear()
        txtPoints.Focus()
        ' Payment display label cleared
        lblResults.Text() = ""
        ' Return state of seven (7) radio butons to default (see screenshot)
        RadioButton1.Checked() = True
        RadioButton6.Checked() = True
    End Sub

    ' This subprocedure determines the price and name of the platter selected as well as the payment method based on the radio buttons checked 
    Private Sub defPlatter()
        ' Determine the price and the name of the platter based on the radio button clicked
        If RadioButton1.Checked() = True Then
            decPlatter = 49.99
            strPlatter = "Gourmet Cheese"
        ElseIf RadioButton2.Checked() = True Then
            decPlatter = 59.99
            strPlatter = "Pinwheel Wraps"
        ElseIf RadioButton3.Checked() = True Then
            decPlatter = 29.99
            strPlatter = "Veggie"
        ElseIf RadioButton4.Checked() = True Then
            decPlatter = 49.99
            strPlatter = "Sausage and Cheese"
        ElseIf RadioButton5.Checked() = True Then
            decPlatter = 29.99
            strPlatter = "Fruit"
        End If
        ' Determine the payment method based on the radio button clicked
        If RadioButton6.Checked() = True Then
            strPay = "Pre-Pay"
        ElseIf RadioButton7.Checked() = True Then
            strPay = "Pay upon Pickup"
        End If
    End Sub

End Class
