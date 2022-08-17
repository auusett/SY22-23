Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DisplayPictureBox.Image = PictureBox1.Image
        colorLabel.Text = "Black"
        sizeLabel.Text = "4.5lbs - 6.5lbs"
        furLabel.Text = "short, soft, flyback"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DisplayPictureBox.Image = CBPictureBox1.Image
        colorLabel.Text = "Cinnamon brown"
        sizeLabel.Text = "8.5lbs - 11lbs"
        furLabel.Text = "short, soft, rarely long"

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DisplayPictureBox.Image = PictureBoxChinchilla.Image
        colorLabel.Text = "Grey & White"
        sizeLabel.Text = "9lbs - 12lbs"
        furLabel.Text = "Short & Thick"

    End Sub
End Class

