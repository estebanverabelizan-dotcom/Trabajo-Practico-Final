Imports MySql.Data.MySqlClient

Public Class Buscar
    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Close()
        Menu.Show()
    End Sub
    Private Sub Buscar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatos()
    End Sub
    Private Sub CargarDatos()
        Dim c As New Conexion()
        Dim conexion As MySqlConnection = c.ObtenerConexion()

        Try
            conexion.Open()

            Dim consulta As String = "SELECT * FROM clientes"
            Dim adaptador As New MySqlDataAdapter(consulta, conexion)
            Dim tabla As New DataTable()

            adaptador.Fill(tabla)
            BDDC.DataSource = tabla

        Catch ex As Exception
            MessageBox.Show("Error al cargar datos: " & ex.Message)
        Finally
            conexion.Close()
        End Try
        Try
            conexion.Open()

            Dim consulta As String = "SELECT * FROM productos"
            Dim adaptador As New MySqlDataAdapter(consulta, conexion)
            Dim tabla As New DataTable()

            adaptador.Fill(tabla)
            BDDP.DataSource = tabla

        Catch ex As Exception
            MessageBox.Show("Error al cargar datos: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub BC_Click(sender As Object, e As EventArgs) Handles BC.Click
        Dim filtro = bus.Text

        If filtro = "" Then
            MessageBox.Show("Debe ingresar algo para buscar.", "Aviso")
            Exit Sub
        End If

        Try
            Dim cliente As New Cliente(0, 0, 0, 0, 0, 0, 0, Date.Now, 0, "", 0, "")
            Dim resultados As DataTable = cliente.Buscar(filtro)

            If resultados.Rows.Count > 0 Then
                BDDC.DataSource = resultados
            Else
                MessageBox.Show("No se encontraron clientes con ese criterio.", "Sin resultados")
                BDDC.DataSource = Nothing
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BP_Click(sender As Object, e As EventArgs) Handles BP.Click
        Dim filtro = bus.Text

        If filtro = "" Then
            MessageBox.Show("Debe ingresar algo para buscar.", "Aviso")
            Exit Sub
        End If

        Try
            Dim producto As New Productos(0, 0, 0, 0, 0, 0, 0, Date.Now, 0, "", 0, "", 0, 0, 0)
            Dim resultados As DataTable = producto.Buscar(filtro)

            If resultados.Rows.Count > 0 Then
                BDDP.DataSource = resultados
            Else
                MessageBox.Show("No se encontraron productos con ese criterio.", "Sin resultados")
                BDDP.DataSource = Nothing
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class