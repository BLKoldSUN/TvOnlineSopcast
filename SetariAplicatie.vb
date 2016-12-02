Public Class Setari_aplicatie

    'Declarea variabilelor
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True 'variabilele penru a putea muta mouse-ul
        mousex = Windows.Forms.Cursor.Position.X - Me.Left 'mouse in X
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top 'mouse in Y
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        'daca este activa functia drag, atunci do this
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False 'se opreste drag
    End Sub

    Private Sub Setari_aplicatie_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    'Salveaza setarile
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'salveaza status mini video
        If ChkStatusMiniVideo.Checked = True Then
            My.Settings.statusminivideo = True
        Else
            My.Settings.statusminivideo = False
        End If
        'salveaza afisarea meniului in minivideo
        If ChkMenuVideo.Checked = True Then
            My.Settings.meniuminivideo = True
        Else
            My.Settings.meniuminivideo = False
        End If
        My.Settings.Save()
    End Sub
End Class
