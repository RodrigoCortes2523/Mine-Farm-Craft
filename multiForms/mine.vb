Public Class mine
    Dim randomGen As New Random()

    Public coalImage As Image = My.Resources.coalIcon, pureCoalImage As Image = My.Resources.pureCoalIcon
    Public copperImage As Image = My.Resources.copperIcon, pureCopperImage As Image = My.Resources.pureCopperIcon
    Dim tinImage As Image = My.Resources.tinIcon, pureTinImage As Image = My.Resources.pureTinIcon
    Dim diamondImage As Image = My.Resources.diamondIcon, malachiteImage As Image = My.Resources.greenGemIcon
    Dim silverImage As Image = My.Resources.silverIcon, sapphireImage As Image = My.Resources.sapphireIcon
    Dim ironImage As Image = My.Resources.ironIcon, goldImage As Image = My.Resources.goldIcon
    Dim topazImage As Image = My.Resources.topazIcon, rubyImage As Image = My.Resources.rubyIcon
    Dim crystalImage As Image = My.Resources.crystalIcon

    Public coalAmount As Integer = 0, pureCoalAmount As Integer = 0, copperAmount As Integer = 0, pureCopperAmount As Integer = 0
    Dim tinAmount As Integer = 0, pureTinAmount As Integer = 0
    Dim malachiteAmount As Integer = 0, diamondAmount As Integer = 0, silverAmount As Integer = 0
    Dim ironAmount As Integer = 0, goldAmount As Integer = 0, crystalAmount As Integer = 0
    Dim sapphireAmount As Integer = 0, topazAmount As Integer = 0, rubyAmount As Integer = 0

    Public hasCoal As Boolean = False, hasCopper As Boolean = False, hasTin As Boolean = False
    Public hasPureCoal As Boolean = False, hasPureCopper As Boolean = False, hasPureTin As Boolean = False
    Dim hasIron As Boolean = False, hasGold As Boolean = False, hasCrystal As Boolean = False
    Dim hasSapphire As Boolean = False, hasRuby As Boolean = False, hasTopaz As Boolean = False
    Dim coalAttempt As String, copperAttempt As String, tinAttempt As String, ironAttempt As String, goldAttempt As String

    Dim hasMalachite As Boolean = False, hasDiamond As Boolean = False, hasSilver As Boolean = False

    Private Sub coalButton_Click(sender As Object, e As EventArgs) Handles coalButton.Click

        mineRoll(coalAttempt, 100, "diamond", 90, "pureCoal", "coal")
        Select Case coalAttempt
            Case "coal"
                mineMain(hasCoal, Form1.coalAmountLabel, coalImage, coalAmount, 1)
            Case "pureCoal"
                mineMain(hasPureCoal, Form1.pureCoalAmountLabel, pureCoalImage, pureCoalAmount, 1)
            Case "diamond"
                mineMain(hasDiamond, Form1.diamondLabel, diamondImage, diamondAmount, 1)
        End Select

    End Sub
    Private Sub copperButton_Click(sender As Object, e As EventArgs) Handles copperButton.Click

        mineRoll(copperAttempt, 95, "malachite", 80, "pureCopper", "copper")

        Select Case copperAttempt
            Case "copper"
                mineMain(hasCopper, Form1.copperAmountLabel, copperImage, copperAmount, 5)
            Case "pureCopper"
                mineMain(hasPureCopper, Form1.pureCopperLabel, pureCopperImage, pureCopperAmount, 5)
            Case "malachite"
                mineMain(hasMalachite, Form1.malachiteLabel, malachiteImage, malachiteAmount, 5)
        End Select

    End Sub
    Private Sub tinButton_Click(sender As Object, e As EventArgs) Handles tinButton.Click
        mineRoll(tinAttempt, 95, "silver", 90, "pureTin", "tin")
        Select Case tinAttempt
            Case "tin"
                mineMain(hasTin, Form1.tinLabel, tinImage, tinAmount, 10)
            Case "pureTin"
                mineMain(hasPureTin, Form1.pureTinLabel, pureTinImage, pureTinAmount, 10)
            Case "silver"
                mineMain(hasSilver, Form1.silverLabel, silverImage, silverAmount, 10)
        End Select
    End Sub
    Private Sub ironButton_Click(sender As Object, e As EventArgs) Handles ironButton.Click
        mineRoll(ironAttempt, 100, "sapphire", 95, "crystal", "iron")
        Select Case ironAttempt
            Case "iron"
                mineMain(hasIron, Form1.ironLabel, ironImage, ironAmount, 15)
            Case "crystal"
                mineMain(hasCrystal, Form1.crystalLabel, crystalImage, crystalAmount, 15)
            Case "sapphire"
                mineMain(hasSapphire, Form1.sapphireLabel, sapphireImage, sapphireAmount, 15)
        End Select
    End Sub
    Private Sub goldButton_Click(sender As Object, e As EventArgs) Handles goldButton.Click
        mineRoll(goldAttempt, 100, "ruby", 99, "topaz", "gold")
        Select Case goldAttempt
            Case "gold"
                mineMain(hasGold, Form1.goldLabel, goldImage, goldAmount, 25)
            Case "topaz"
                mineMain(hasTopaz, Form1.topazLabel, topazImage, topazAmount, 25)
            Case "ruby"
                mineMain(hasRuby, Form1.rubyLabel, rubyImage, rubyAmount, 25)
        End Select

    End Sub
    Private Sub mineRoll(ByRef attempt As String, tierOneNumber As Integer, tierOneName As String, tierTwoNumber As Integer, tierTwoName As String, tierThreeName As String)
        Dim number As Integer = randomGen.Next(0, 101)
        If number >= tierOneNumber Then
            attempt = tierOneName
        ElseIf number >= tierTwoNumber Then
            attempt = tierTwoName
        Else
            attempt = tierThreeName
        End If
        Form1.tempLabel.Text = attempt & " " & number
    End Sub
    Private Sub mineMain(ByRef has As Boolean, label As Label, image As Image, ByRef amount As Integer, energyCost As Integer)
        If has = False And Form1.energy > 0 Then

            For i = 0 To 29
                If Form1.inventoryArray(i).BackgroundImage Is Nothing And has = False Then
                    Form1.inventoryArray(i).Controls.Add(label)
                    label.Location = New Point(0, 0)
                    Form1.inventoryArray(i).BackgroundImage = image
                    Form1.inventoryArray(i).BackgroundImageLayout = ImageLayout.Stretch
                    amount += 1
                    label.Text = amount
                    Form1.energy -= energyCost
                    Form1.energyAmountLabel.Text = Form1.energy
                    has = True
                End If
            Next
        ElseIf has = True And Form1.energy > 0 Then
            amount += 1
            label.Text = amount
            Form1.energy -= energyCost
            Form1.energyAmountLabel.Text = Form1.energy
        Else
            MessageBox.Show("Not enough energy")
        End If
    End Sub
End Class