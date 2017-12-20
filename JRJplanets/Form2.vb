Public Class Form2
    'This form is exclusively for giving instructions to the user
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Gets rid of the bar at the top with the close out
        'This prevents the user from bricking the system
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        'Makes this form the top form
        Me.TopMost = True
    End Sub

    'The user has acknowledged the instructions
    Private Sub btnO_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Form1.Enabled = True
        Me.Close()
    End Sub
End Class