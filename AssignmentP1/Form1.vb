Public Class Form1
    ' Nikki Johnson
    ' Project 1: French Numbers
    ' Description: This project displays the french numbers 1-5 when the corresponding button is clicked. The program ends when the exit button is clicked. 
    ' Class: CPSC 3118

    ' When btnOne is clicked, one in french is displayed in the label box
    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        lblFrench.Text = "un"
        lblFrench.Enabled = True
        lblFrench.Visible = True
    End Sub

    ' When btnTwo is clicked, two in french is displayed in the label box
    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        lblFrench.Text = "deux"
        lblFrench.Enabled = True
        lblFrench.Visible = True
    End Sub

    ' When btnThree is clicked, three in french is displayed in the label box
    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        lblFrench.Text = "trois"
        lblFrench.Enabled = True
        lblFrench.Visible = True
    End Sub

    ' When btnFour is clicked, four in french is displayed in the label box
    Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        lblFrench.Text = "quatre"
        lblFrench.Enabled = True
        lblFrench.Visible = True
    End Sub

    ' When btnFive is clicked, five in french is displayed in the label box
    Private Sub btnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        lblFrench.Text = "cinq"
        lblFrench.Enabled = True
        lblFrench.Visible = True
    End Sub

    ' The user clicks this button when they want to exit the program. The program closes once the exit putton is clicked
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
