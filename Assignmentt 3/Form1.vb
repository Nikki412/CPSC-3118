Public Class frmBurgers
    ' When the Prime Beef Burger button is clicked, the image associated with that burger is displayed and the Veggie burger picture is not visible. 
    ' The Select Meal button is now enabled
    Private Sub btnPrime_Click(sender As Object, e As EventArgs) Handles btnPrime.Click
        picPrime.Visible = True
        picVeggie.Visible = False
        btnSelectMeal.Enabled = True
    End Sub

    ' When the Veggie Burger button is clicked, the image associated with that burger is displayed and the Prime Beef burger picture is not visible. 
    ' The Select Meal button is now enabled
    Private Sub btnVeggie_Click(sender As Object, e As EventArgs) Handles btnVeggie.Click
        picPrime.Visible = False
        picVeggie.Visible = True
        btnSelectMeal.Enabled = True
    End Sub

    ' The Prime Beef and Veggie Burger buttons are disabled as well as the Select Meal button. The confirmation label is now visible.
    ' The Exit button is now enabled and it is the only button the user can click on
    Private Sub btnSelectMeal_Click(sender As Object, e As EventArgs) Handles btnSelectMeal.Click
        btnPrime.Enabled = False
        btnVeggie.Enabled = False
        btnSelectMeal.Enabled = False
        lblConfirmation.Visible = True
        btnExit.Enabled = True
        btnExit.Visible = True
    End Sub

    ' Exits the program
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
