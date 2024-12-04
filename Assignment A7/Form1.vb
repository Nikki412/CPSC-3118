Imports System.ComponentModel.Design
Imports System.IO
Imports System.Windows.Forms.Design

' Nikki Johnson 
' Project: Smart Home Application
' Class: CPSC 3118
' Description: This application gets the month and the amount saved from a textfile and allows the user to select a month to see the monthly savings for the month
' The user can then see the average savings and the month with the most savings after pressing the display statistics month. 
Public Class Form1
    ' declare the arrays for the months and the savings 
    Dim strMonths(11) As String
    Dim decSavings(11) As Decimal
    ' Upon loading the application, we get the data from the file, populate the arrays based on the data, and populate the comboBox (cboMonth) based on the strMonths array
    ' Displays error message if unable to open the file or if an error occurs
    Private Sub Form1_Load(sender As Object, a As EventArgs) Handles MyBase.Load
        ' create a StreamReader object to read from the file
        Dim fileReader As IO.StreamReader
        ' Open file to read
        Try
            Dim fileName As String
            Dim line As String
            fileName = "C:\users\kyrie\Downloads\savings.txt"
            fileReader = New StreamReader(fileName)
            ' populate strMonths and strSavings using data from the file
            Dim i As Integer = 0
            Do Until fileReader.Peek = -1
                line = fileReader.ReadLine()
                strMonths(i) = line
                line = fileReader.ReadLine()
                decSavings(i) = line
                i += 1
            Loop
            fileReader.Close()
            ' populate combo box with data from strMonths
            For Each month As String In strMonths
                cboMonth.Items.Add(month)
            Next
            ' Display message box if there is an exception when opening the file
        Catch ex As FileNotFoundException
            MsgBox("There is an error while opening the File")
            ' display a message box is there is an exception
        Catch ex As Exception
            MsgBox("There is an error")
        End Try
    End Sub
    ' Only when the user has already seleected a month; when the display statistics button is clicked, display the average monthly savings (by averaging the values in the decSavings array
    ' and finding the month with the most savings then display the results
    Private Sub btnStatistics_Click(sender As Object, e As EventArgs) Handles btnStatistics.Click
        If cboMonth.SelectedItem = "" Then
            ' User has not selected a month from the cboMonth
            MsgBox("Please select a month from the ComboBox")
        Else
            ' user has selected a month from the cboMonth
            ' get the average of the monthly savings from the array 
            Dim average As Decimal = decSavings.Average()
            ' add the result to the proper label with proper formating 
            lblAverageSavings.Text = average.ToString("C2")
            ' get the index of the element with the most savings
            Dim maxElement As Decimal = decSavings.Max
            ' https://stackoverflow.com/questions/3670244/indexof-with-string-array-in-vb-net
            ' use that index to get the month with the most savings and assign it to the proper label 
            Dim maxIndex As Integer = Array.IndexOf(decSavings, maxElement)
            lblBestMonth.Text = strMonths(maxIndex)
            ' Make all appropriate labels visible 
            lblMonthySavings.Visible = True
            lblAverageSavings.Visible = True
            lblBestMonth.Visible = True
            lblSigSavings.Visible = True
        End If

    End Sub

    ' Using the selectedIndex from the combobox (cboMonth) determine the appropriate month and savings to be displayed as the results 
    Private Sub selectedMonth()
        ' change the contents of lblResults.Text depending on the selectedIndex of the comboBox cboMonth
        If cboMonth.SelectedIndex = 0 Then
            lblResults.Text = strMonths(0) & " is $" & Convert.ToString(decSavings(0))
        End If
        If cboMonth.SelectedIndex = 1 Then
            lblResults.Text = strMonths(1) & " is $" & Convert.ToString(decSavings(1))
        End If
        If cboMonth.SelectedIndex = 2 Then
            lblResults.Text = strMonths(2) & " is $" & Convert.ToString(decSavings(2))
        End If
        If cboMonth.SelectedIndex = 3 Then
            lblResults.Text = strMonths(3) & " is $" & Convert.ToString(decSavings(3))
        End If
        If cboMonth.SelectedIndex = 4 Then
            lblResults.Text = strMonths(4) & " is $" & Convert.ToString(decSavings(4))
        End If
        If cboMonth.SelectedIndex = 5 Then
            lblResults.Text = strMonths(5) & " is $" & Convert.ToString(decSavings(5))
        End If
        If cboMonth.SelectedIndex = 6 Then
            lblResults.Text = strMonths(6) & " is $" & Convert.ToString(decSavings(6))
        End If
        If cboMonth.SelectedIndex = 7 Then
            lblResults.Text = strMonths(7) & " is $" & Convert.ToString(decSavings(7))
        End If
        If cboMonth.SelectedIndex = 8 Then
            lblResults.Text = strMonths(0) & " is $" & Convert.ToString(decSavings(8))
        End If
        If cboMonth.SelectedIndex = 9 Then
            lblResults.Text = strMonths(0) & " is $" & Convert.ToString(decSavings(9))
        End If
        If cboMonth.SelectedIndex = 10 Then
            lblResults.Text = strMonths(10) & " is $" & Convert.ToString(decSavings(10))
        End If
        If cboMonth.SelectedIndex = 11 Then
            lblResults.Text = strMonths(11) & " is $" & Convert.ToString(decSavings(11))
        End If
    End Sub

    ' Whenever the selected index changes in the combobox display the appropriate month and savings
    Private Sub cboMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMonth.SelectedIndexChanged
        ' determine the correct month and savings to be displayed
        selectedMonth()
        ' Make the savings and results lables visible 
        lblSavings.Visible = True
        lblResults.Visible = True
    End Sub
End Class
