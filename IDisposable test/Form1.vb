Public Class Form1
    Private Sub btnMessage_Click(sender As Object, e As EventArgs) Handles btnMessage.Click
        Using myDoStuff As New doStuff
            myDoStuff.ShowMoreMessages()
            myDoStuff.showMessage()

        End Using
    End Sub
End Class
