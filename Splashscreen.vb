Public Class Form22

    Private Sub Form22_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        PBar1.Increment(1)
        If PBar1.Value = 100 Then
            Form1.Show()
            Me.Hide()
        End If
    End Sub
End Class