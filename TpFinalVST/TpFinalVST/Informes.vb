Imports MySql.Data.MySqlClient

Public Class Informes
    Private Sub Informes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatos()
    End Sub
    Private Sub CargarDatos()
        Dim c As New Conexion()
        Dim conexion As MySqlConnection = c.ObtenerConexion()

        Try
            conexion.Open()

            Dim consulta As String = "SELECT * FROM Ventas"
            Dim adaptador As New MySqlDataAdapter(consulta, conexion)
            Dim tabla As New DataTable()

            adaptador.Fill(tabla)
            Info.DataSource = tabla

        Catch ex As Exception
            MessageBox.Show("Error al cargar datos: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub
    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Me.Close()
        Menu.Show()
    End Sub

    Private Sub Geninf_Click(sender As Object, e As EventArgs) Handles Geninf.Click
        Dim c As New Conexion()
        Dim conexion As MySqlConnection = c.ObtenerConexion()

        Dim fecha1 As Date = Date.Parse(Fech1.Text)
        Dim fecha2 As Date = Date.Parse(Fech2.Text)
        Try
            Dim cliente As New Ventas(0, 0, 0, 0, 0, 0, 0, Date.Now, 0)
            Dim resultados As DataTable = Ventas.Infomar(fecha1, fecha2)

            If resultados.Rows.Count > 0 Then
                Info.DataSource = resultados
            Else
                MessageBox.Show("No se encontraron ventas con ese criterio.", "Sin resultados")
                Info.DataSource = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("Error al buscar datos: " & ex.Message)
        Finally
            conexion.Close()

        End Try
    End Sub

End Class