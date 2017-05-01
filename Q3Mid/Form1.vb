Public Class Form1


    Private Sub RedRa_CheckedChanged(sender As Object, e As EventArgs) Handles RedRa.CheckedChanged
        PBox.BackColor = Color.Red
    End Sub

    Private Sub GreenRa_CheckedChanged(sender As Object, e As EventArgs) Handles GreenRa.CheckedChanged
        PBox.BackColor = Color.Green

    End Sub

    Private Sub BlueRa_CheckedChanged(sender As Object, e As EventArgs) Handles BlueRa.CheckedChanged
        PBox.BackColor = Color.Blue

    End Sub

    Private Sub LoadRa_CheckedChanged(sender As Object, e As EventArgs) Handles LoadRa.CheckedChanged
        PBox.Image = My.Resources.bb
    End Sub
End Class
