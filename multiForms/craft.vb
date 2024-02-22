Public Class craft
    Private Sub switchPanel(ByVal panel As Form)
        Panel1.Controls.Clear()
        panel.TopLevel = False
        Panel1.Controls.Add(panel)
    End Sub
    Private Sub smeltingButton_Click(sender As Object, e As EventArgs) Handles smeltingButton.Click
        switchPanel(craftSub)
        craftSub.Show()
    End Sub
End Class