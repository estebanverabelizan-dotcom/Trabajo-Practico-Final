Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Dim myBar As New ColorProgresbar()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myBar.Location = New Point(215, 367)
        myBar.Size = New Size(370, 23)
        myBar.Value = 60
        Me.Controls.Add(myBar)
        myBar.Minimum = 0
        myBar.Maximum = 200
        myBar.Value = 0
        Timer1.Interval = 1
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If myBar.Value < mybar.Maximum Then
            myBar.Value += 2
        Else
            Timer1.Stop()
            Me.Hide()
            RegLog.Show()
        End If
    End Sub


End Class
