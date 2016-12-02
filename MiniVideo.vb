'' MiniVideo se va activa atunci cand aplicatia principala Form1.vb este minimizata
'' MiniVideo trebuie sa fie ON TOP (deasupra tuturor aplicatiilor)

Public Class MiniVideo
    '' Pozitia ferestrei MiniVideo pe desktop (dreapta jos - colt)
    Private Sub MiniVideo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - Me.Width, Screen.PrimaryScreen.WorkingArea.Height - Me.Height)
    End Sub

    'Reda postul tv in fereastra principala
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Form1.Player.SopAddress = Form1.ToolStripStatusLabel2.Text
        Form1.Player.Play()
        'Inchide mini video
        Me.Close()
    End Sub

End Class
