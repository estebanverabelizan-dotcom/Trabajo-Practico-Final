Imports System.Drawing.Drawing2D
Imports System.Security.Cryptography.X509Certificates
Imports MySql.Data.MySqlClient

Public Class Registro
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Dim radius As Integer = 20
        Dim rect As New Rectangle(0, 0, Panel1.Width - 1, Panel1.Height - 1)

        Dim path As GraphicsPath = GetRoundPath(rect, radius)

        Panel1.Region = New Region(path)
    End Sub

    Private Function GetRoundPath(rect As Rectangle, radius As Integer) As GraphicsPath
        Dim path As New Drawing2D.GraphicsPath()
        Dim curveSize As Integer = radius * 2

        path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90)
        path.AddLine(rect.X + radius, rect.Y, rect.Right - radius, rect.Y)
        path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90)
        path.AddLine(rect.Right, rect.Y + radius, rect.Right, rect.Bottom - radius)
        path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90)
        path.AddLine(rect.Right - radius, rect.Bottom, rect.X + radius, rect.Bottom)
        path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90)
        path.AddLine(rect.X, rect.Bottom - radius, rect.X, rect.Y + radius)

        path.CloseFigure()
        Return path
    End Function
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Close()
        RegLog.Show()
    End Sub
    Dim conexiones As New MySqlConnection("server=localhost;port=3306;user id=root;password=;database=tpfinal")
    Private Sub Registrar_Click(sender As Object, e As EventArgs) Handles Registrar.Click
        Try
            conexiones.Open()

            Dim usuario As String = TextBox1.Text
            Dim email As String = TextBox2.Text
            Dim contraseña As String = TextBox4.Text
            Dim confirmarContraseña As String = TextBox3.Text

            If contraseña <> confirmarContraseña Then
                Panel2.Show()
                Label6.Show()
                Label7.Hide()
                MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim consulta As String = "SELECT COUNT(*) FROM cuentas WHERE Usuario=@Usuario OR Email=@Email;"
            Dim comando As New MySqlCommand(consulta, conexiones)
            comando.Parameters.AddWithValue("@Usuario", usuario)
            comando.Parameters.AddWithValue("@Email", email)

            Dim count As Integer = Convert.ToInt32(comando.ExecuteScalar())

            If count > 0 Then
                Panel2.Show()
                Label7.Show()
                Label6.Hide()
                MessageBox.Show("El usuario o el email ya están registrados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim consultaInsert As String = "INSERT INTO cuentas (Usuario, Email, Contraseña) VALUES (@Usuario, @Email, @Contraseña);"
                Dim comandoInsert As New MySqlCommand(consultaInsert, conexiones)
                comandoInsert.Parameters.AddWithValue("@Usuario", usuario)
                comandoInsert.Parameters.AddWithValue("@Email", email)
                comandoInsert.Parameters.AddWithValue("@Contraseña", contraseña)

                comandoInsert.ExecuteNonQuery()
                MessageBox.Show("Registro exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox3.Clear()
                TextBox4.Clear()
                Panel2.Hide()
                Label6.Hide()
                Label7.Hide()
            End If

        Catch ex As MySqlException
            MessageBox.Show("Error MySQL: " & ex.Message)
        Finally
            Conexiones.Close()
        End Try
    End Sub

End Class