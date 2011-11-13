Public Class Form3

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MessageBox.Show("An untethered jailbreak is a jailbreak that does not require you to plug your devcie each time you boot", "Jailbreak Help rc4")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If tether = True Then
            Form4.Show()
            Me.Close()
        ElseIf tether = False Then
            Form5.Show()
            Me.Close()
        End If
    End Sub
End Class