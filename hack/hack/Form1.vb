Public Class Form1

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Dim intCount As Integer

        For intCount = 16 To 328 ' (int intCount = 16; intCount <= 328; intCount++)
            picCT.Left = intCount
        Next
    End Sub
End Class
