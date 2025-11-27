Imports System.Drawing.Drawing2D
Imports Org.BouncyCastle.Crypto.Digests

Public Class Menu
    Private Sub Modificacione_Click(sender As Object, e As EventArgs) Handles Modificacione.Click
        Me.Hide()
        Modificaciones.Show()
    End Sub
    Private Sub Busca_Click(sender As Object, e As EventArgs) Handles Busca.Click
        Me.Hide()
        Buscar.Show()
    End Sub
    Private Sub Informe_Click(sender As Object, e As EventArgs) Handles Informe.Click
        Me.Hide()
        Informes.Show()
    End Sub
    Private Sub Registro_Click(sender As Object, e As EventArgs) Handles Registro.Click
        Me.Hide()
        RegistroVentas.Show()
    End Sub
    Private Sub Compra_Click(sender As Object, e As EventArgs) Handles Compra.Click
        Me.Hide()
        Comprar.Show()
    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button Then
                RedondearBoton(DirectCast(ctrl, Button), 20)
            End If
        Next
    End Sub
    Private Sub RedondearBoton(boton As Button, radio As Integer)
        Dim path As New GraphicsPath()
        path.AddArc(0, 0, radio, radio, 260, 90)
        path.AddArc(boton.Width - radio, 0, radio, radio, 270, 90)
        path.AddArc(boton.Width - radio, boton.Height - radio, radio, radio, 0, 90)
        path.AddArc(0, boton.Height - radio, radio, radio, 90, 90)
        path.CloseAllFigures()

        boton.Region = New Region(path)
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Me.Close()
        RegLog.Show()
    End Sub
End Class