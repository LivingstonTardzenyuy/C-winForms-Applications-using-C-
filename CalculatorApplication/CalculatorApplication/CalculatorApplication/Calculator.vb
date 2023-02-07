Public Class Calculator

    Private Sub Calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDisplay.Focus()

    End Sub

    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        txtDisplay.Text += btnAdd.Text
    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        txtDisplay.Text += btnTwo.Text

    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        txtDisplay.Text += btnThree.Text

    End Sub

    Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        txtDisplay.Text += btnFour.Text

    End Sub

    Private Sub btnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        txtDisplay.Text += btnFive.Text

    End Sub

    Private Sub btnSix_Click(sender As Object, e As EventArgs) Handles btnSix.Click
        txtDisplay.Text += btnSix.Text
    End Sub

    Private Sub btnSeven_Click(sender As Object, e As EventArgs) Handles btnSeven.Click
        txtDisplay.Text += btnSeven.Text

    End Sub

    Private Sub btnEight_Click(sender As Object, e As EventArgs) Handles btnEight.Click

        txtDisplay.Text += btnEight.Text
    End Sub

    Private Sub btnNine_Click(sender As Object, e As EventArgs) Handles btnNine.Click
        txtDisplay.Text += btnNine.Text
    End Sub

    Private Sub btnZero_Click(sender As Object, e As EventArgs) Handles btnZero.Click
        txtDisplay.Text += btnZero.Text
    End Sub

    Private Sub btnFactorial_Click(sender As Object, e As EventArgs) Handles btnFactorial.Click
        txtDisplay.Text += btnFactorial.Text

    End Sub

    Private Sub btnClearAll_Click(sender As Object, e As EventArgs) Handles btnClearAll.Click
        txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1)
    End Sub

    Private Sub btnpoint_Click(sender As Object, e As EventArgs) Handles btnpoint.Click
        txtDisplay.Text = btnpoint.Text
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDisplay.Clear()
        txtDisplay.Focus()

    End Sub
    Bool addition=false
End Class
