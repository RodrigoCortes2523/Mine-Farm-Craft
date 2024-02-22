Public Class Form1
    Public energy As Integer = 100
    Public inventoryArray(29) As PictureBox
    Dim pressedImage As Image = My.Resources.button1Pressed
    Dim buttonImage As Image = My.Resources.button1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        switchPanel(mine)
        mine.Show()
    End Sub

    Private Sub switchPanel(ByVal panel As Form)
        Panel1.Controls.Clear()
        panel.TopLevel = False
        Panel1.Controls.Add(panel)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        switchPanel(farm)
        farm.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        switchPanel(craft)
        craft.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        inventoryArray(0) = PictureBox1
        inventoryArray(1) = PictureBox2
        inventoryArray(2) = PictureBox3
        inventoryArray(3) = PictureBox4
        inventoryArray(4) = PictureBox5
        inventoryArray(5) = PictureBox6
        inventoryArray(6) = PictureBox7
        inventoryArray(7) = PictureBox8
        inventoryArray(8) = PictureBox9
        inventoryArray(9) = PictureBox10
        inventoryArray(10) = PictureBox11
        inventoryArray(11) = PictureBox12
        inventoryArray(12) = PictureBox13
        inventoryArray(13) = PictureBox14
        inventoryArray(14) = PictureBox15
        inventoryArray(15) = PictureBox16
        inventoryArray(16) = PictureBox17
        inventoryArray(17) = PictureBox18
        inventoryArray(18) = PictureBox19
        inventoryArray(19) = PictureBox20
        inventoryArray(20) = PictureBox21
        inventoryArray(21) = PictureBox22
        inventoryArray(22) = PictureBox23
        inventoryArray(23) = PictureBox24
        inventoryArray(24) = PictureBox25
        inventoryArray(25) = PictureBox26
        inventoryArray(26) = PictureBox27
        inventoryArray(27) = PictureBox28
        inventoryArray(28) = PictureBox29
        inventoryArray(29) = PictureBox30

    End Sub

    Private Sub Button1_MouseDown(sender As Object, e As MouseEventArgs) Handles Button1.MouseDown
        Button1.BackgroundImage = pressedImage
    End Sub

    Private Sub Button1_MouseUp(sender As Object, e As MouseEventArgs) Handles Button1.MouseUp
        Button1.BackgroundImage = buttonImage
    End Sub
End Class
