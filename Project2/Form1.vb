Imports System.ComponentModel.Design.Serialization
Imports System.Runtime.CompilerServices
' Name: Nikki Johnson
' Project: Paycheck Calculator
' Class: CPSC 3118
' Description: This program takes a user's gross pay, calculates the FICA, federal tax, and state tax to be taken from the check, displays those amount as well as the Net Income pay after the deductions.
' The user is able to enter gross pay, calculate taxes and net income, and clear the form over and over. The user can exit the program with the exit button. 
Public Class Form1
    ' Variabes
    Dim strIncome As String
    Dim decIncome As Decimal
    Dim decFica As Decimal
    Dim decFederal As Decimal
    Dim decState As Decimal
    Dim decNet As Decimal

    ' Constants
    Const cdecFica As Decimal = 0.0765
    Const cdecFed As Decimal = 0.22
    Const cdesState As Decimal = 0.04

    ' Calculate the FICa, federal, and state taxes to be taken from the user's gross pay and display those results as well as the net income in currency format 
    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        ' Convert the string strIncome value from the income textbox to the floating point decIncome
        strIncome = txtPay.Text
        decIncome = Convert.ToDecimal(strIncome)

        ' Calculate the three tax amounts
        decFica = decIncome * cdecFica
        decFederal = decIncome * cdecFed
        decState = decIncome * cdesState

        ' Calculate the net income 
        decNet = decIncome - (decFica + decFederal + decState)

        ' Convert appropriate numbers to currency 
        ' used information from https://stackoverflow.com/questions/9265389/money-format-number-vb-net
        ' Convert the three tax amounts and net income amount to String and assign each to the Text property of the matching label control 
        lblFica.Text += decFica.ToString("C2")
        lblFederal.Text += decFederal.ToString("C2")
        lblState.Text += decState.ToString("C2")
        lblIncome.Text += decNet.ToString("C2")
    End Sub

    ' Clear the text box and return the label's to their default text
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' clear the text box and focus it 
        txtPay.Clear()
        txtPay.Focus()

        ' return the labels to their default text without the calculations 
        lblFica.Text = "FICA: "
        lblFederal.Text = "Federal Tax: "
        lblState.Text = "State Tax: "
        lblIncome.Text = "Net Paycheck Income: "
    End Sub

    ' Exit the program
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub


End Class
