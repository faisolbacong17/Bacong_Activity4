Public Class Form1
    Private Sub gar_Click(sender As Object, e As EventArgs) Handles gar.Click
        Dim j As Integer
        Dim f As Integer
        j = pogi.Text
        f = love.Text
        Label3.Text = j / f
    End Sub
End Class
