Public Class Form1
    Public Property guest As String = "bawal" 'disable the 2 buttons <<<<'
    
  
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Form4.Show()
        guest = "bawal"



    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Timer1.Start()
        




    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Me.Hide()
            Form2.Show()
            Timer1.Stop()


        End If

    End Sub
End Class
