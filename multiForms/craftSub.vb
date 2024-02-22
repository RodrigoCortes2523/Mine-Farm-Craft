Public Class craftSub
    Dim oreSelected As String
    Dim copperIngotImage As Image = My.Resources.copperIngotIcon
    Dim copperIngotAmount As Integer = 0
    Dim hasCopperIngot As Boolean = False
    Private Sub smeltButton_Click(sender As Object, e As EventArgs) Handles smeltButton.Click
        Select Case oreSelected
            Case "copper"
                craft(hasCopperIngot, mine.hasCopper, Form1.copperIngotLabel, copperIngotImage, mine.copperAmount, copperIngotAmount, Form1.copperAmountLabel, 2, 1)
            Case "pureCopper"
                craft(hasCopperIngot, mine.hasPureCopper, Form1.copperIngotLabel, copperIngotImage, mine.pureCopperAmount, copperIngotAmount, Form1.pureCopperLabel, 1, 5)
        End Select

    End Sub

    Private Sub selectOre(ByRef amount As Integer, image As Image, selected As String)
        If amount >= 2 Then
            ingrediantOneBox.BackgroundImage = image
            ingrediantOneBox.BackgroundImageLayout = ImageLayout.Stretch
            oreSelected = selected
        End If
    End Sub

    Private Sub craft(ByRef hasIngot As Boolean, ByRef hasMats As Boolean, Label As Label, outImage As Image, ByRef inAmount As Integer, ByRef outAmount As Integer, inLabel As Label,
                      ByRef matCost As Integer, ByRef resultAmount As Integer)

        resultBox.BackgroundImage = outImage
        resultBox.BackgroundImageLayout = ImageLayout.Stretch
        For i = 0 To 29
            If Form1.inventoryArray(i).BackgroundImage Is Nothing And hasIngot = False Then
                Form1.inventoryArray(i).Controls.Add(Label)
                Label.Location = New Point(0, 0)
                Form1.inventoryArray(i).BackgroundImage = outImage
                Form1.inventoryArray(i).BackgroundImageLayout = ImageLayout.Stretch
                inAmount -= matCost
                inLabel.Text = inAmount
                outAmount += resultAmount
                hasIngot = True
                Label.Text = outAmount
                If inAmount = 0 Then
                    inLabel.Parent.BackgroundImage = Nothing
                    inLabel.Parent.Controls.Remove(inLabel)
                    hasMats = False
                End If
                Exit For
            ElseIf hasIngot = True And inAmount >= matCost Then
                inAmount -= matCost
                inLabel.Text = inAmount.ToString
                outAmount += resultAmount
                Label.Text = outAmount
                If inAmount = 0 Then
                    inLabel.Parent.BackgroundImage = Nothing
                    inLabel.Parent.Controls.Remove(inLabel)
                    hasMats = False
                End If
                Exit For
            End If
        Next
    End Sub
    Public Sub showExtraButtons()
        normSelectButton.Visible = True
        pureSelectButton.Visible = True
    End Sub

    Private Sub copperIngotButton_Click(sender As Object, e As EventArgs) Handles copperIngotButton.Click
        showExtraButtons()
    End Sub

    Private Sub tinIngotButton_Click(sender As Object, e As EventArgs) Handles tinIngotButton.Click
        ingrediantOneBox.BackgroundImage = Nothing
        resultBox.BackgroundImage = Nothing
        oreSelected = "tin"
    End Sub

    Private Sub ironIngotButton_Click(sender As Object, e As EventArgs) Handles ironIngotButton.Click
        oreSelected = "iron"
    End Sub

    Private Sub normSelectButton_Click(sender As Object, e As EventArgs) Handles normSelectButton.Click
        selectOre(mine.copperAmount, mine.copperImage, "copper")
    End Sub

    Private Sub pureSelectButton_Click(sender As Object, e As EventArgs) Handles pureSelectButton.Click
        selectOre(mine.pureCopperAmount, mine.pureCopperImage, "pureCopper")
    End Sub
End Class