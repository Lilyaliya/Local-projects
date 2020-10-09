Public Class Form1
    Dim X1, Y1, X2, Y2 As Integer
    Dim Pen1 As New Pen(Color.Black, 5)



    Dim Brush1 As New SolidBrush(Color.Red)
    Private Sub PictureBox1_Click(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PictureBox1.MouseDown
        Select Case e.Button
            Case MouseButtons.Left
                X1 = e.X
                Y1 = e.Y
                Label1.Text = X1
                Label2.Text = Y1
            Case MouseButtons.Right
                X2 = e.X
                Y2 = e.Y
                Label3.Text = X2
                Label4.Text = Y2
        End Select
    End Sub
    Dim Image1 As New Bitmap(300, 300)

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        Dim Graph1 As Graphics = Graphics.FromImage(Image1)
        PictureBox1.Image = Image1
        Graph1.DrawLine(Pen1, X1, Y1, X2, Y2)
    End Sub
    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        Dim Graph1 As Graphics = Graphics.FromImage(Image1)
        PictureBox1.Image = Image1
        Graph1.DrawRectangle(Pen1, X1, Y1, Math.Abs(X2 - X1), Math.Abs(Y2 - Y1))
    End Sub
    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        Dim Graph1 As Graphics = Graphics.FromImage(Image1)
        PictureBox1.Image = Image1
        Graph1.DrawRectangle(Pen1, X1, Y1, Math.Abs(X2 - X1), Math.Abs(Y2 - Y1))
        Graph1.FillRectangle(Brush1, X1, Y1, Math.Abs(X2 - X1), Math.Abs(Y2 - Y1))
    End Sub
    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem8.Click
        Dim Graph1 As Graphics = Graphics.FromImage(Image1)
        PictureBox1.Image = Image1
        Graph1.DrawEllipse(Pen1, X1, Y1, Math.Abs(X2 - X1), Math.Abs(Y2 - Y1))
    End Sub
    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem9.Click
        Dim Graph1 As Graphics = Graphics.FromImage(Image1)
        PictureBox1.Image = Image1
        Graph1.DrawEllipse(Pen1, X1, Y1, Math.Abs(X2 - X1), Math.Abs(Y2 - Y1))
        Graph1.FillEllipse(Brush1, X1, Y1, Math.Abs(X2 - X1), Math.Abs(Y2 - Y1))
    End Sub
    Private Sub ToolStripMenuItem10_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem10.Click
        Dim Graph1 As Graphics = Graphics.FromImage(Image1)
        PictureBox1.Image = Image1
        Graph1.Clear(Color.White)
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As ToolBarButtonClickEventArgs) Handles ToolStripButton1.Click

    End Sub
    Private Sub ToolStripMenuItem12_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem12.Click
        ColorDialog1.ShowDialog()
        Pen1.Color = ColorDialog1.Color
    End Sub
    Private Sub ToolStripMenuItem13_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem13.Click
        ColorDialog1.ShowDialog()
        Brush1.Color = ColorDialog1.Color
    End Sub
End Class
