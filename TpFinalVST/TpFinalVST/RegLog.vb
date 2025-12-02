Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient

Public Class RegLog
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Dim radius As Integer = 20
        Dim rect As New Rectangle(0, 0, Panel1.Width - 1, Panel1.Height - 1)

        Dim path As GraphicsPath = GetRoundPath(rect, radius)

        Panel1.Region = New Region(path)
    End Sub

    Private Function GetRoundPath(rect As Rectangle, radius As Integer) As GraphicsPath
        Dim path As New GraphicsPath()
        Dim curveSize As Integer = radius * 3

        path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90)
        path.AddLine(rect.X + radius, rect.Y, rect.Right - radius, rect.Y)
        path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90)
        path.AddLine(rect.Right, rect.Bottom, rect.X, rect.Bottom)

        Return path
    End Function
    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Form1.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
        Registro.Show()
    End Sub
    Private Sub bntVer_Click(sender As Object, e As EventArgs) Handles bntVer.Click
        If TextBox2.UseSystemPasswordChar Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub


    Dim conexion As New MySqlConnection("server=localhost;port=3306;user id=root;password=;database=tpfinal")
    Private Sub Logear_Click(sender As Object, e As EventArgs) Handles Logear.Click
        UsuarioActual = TextBox1.Text
        gmailActual = Cliente.ObtenerGmailUsuario(UsuarioActual)

        Try
            conexion.Open()

            Dim Usuario As String = TextBox1.Text
            Dim Contraseña As String = TextBox2.Text

            Dim consulta As String = "SELECT COUNT(*) FROM cuentas WHERE Usuario = @Usuario AND Contraseña = @Contraseña;"

            Dim comando As New MySqlCommand(consulta, conexion)
            comando.Parameters.AddWithValue("@Usuario", Usuario)
            comando.Parameters.AddWithValue("@Contraseña", Contraseña)

            Dim count As Integer = Convert.ToInt32(comando.ExecuteScalar())
            If count > 0 Then
                Panel2.Hide()
                Me.Close()
                Menu.Show()
            Else
                Panel2.Show()
                MessageBox.Show("Usuario o contraseña incorrectos")
            End If

        Catch ex As MySqlException
            MessageBox.Show("Error MySQL: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub
End Class