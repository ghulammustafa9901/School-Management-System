Public Class StartUpForm
    Private Sub StartUpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Public Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = ProgressBar1.Value + 4
        If ProgressBar1.Value = ProgressBar1.MaximumValue Then
            Me.Hide()
            LoginForm.Show()
            Timer1.Stop()
        End If
    End Sub
End Class
