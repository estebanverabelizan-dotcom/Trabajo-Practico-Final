Imports MySql.Data.MySqlClient
Imports Windows.Win32.System

Public Class RegistroVentas

    Private Sub RegistroVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatos()
    End Sub
    Private Sub CargarDatos()
        Dim c As New Conexion()
        Using conexion As MySqlConnection = c.ObtenerConexion()
            conexion.Open()
            Dim consulta As String = "SELECT * FROM ventasitems"
            Dim adaptador As New MySqlDataAdapter(consulta, conexion)
            Dim tabla As New DataTable()
            adaptador.Fill(tabla)
            InfoVentas.DataSource = tabla
            For Each fila As DataRow In tabla.Rows
                Dim precioUnitario As Decimal = 0
                Dim cantidad As Integer = 0

                If Not IsDBNull(fila("PrecioUnit")) Then
                    precioUnitario = fila("PrecioUnit")
                End If
                If Not IsDBNull(fila("Cantidad")) Then
                    cantidad = fila("Cantidad")
                End If
                Dim PrecioTotal = precioUnitario * cantidad
                fila("PrecioTotal") = precioUnitario * cantidad

                consulta = "UPDATE ventasitems SET PrecioTotal = @pre WHERE IDvi = @idp"
                Using comando As New MySqlCommand(consulta, conexion)
                    comando.Parameters.AddWithValue("@pre", PrecioTotal)
                    comando.Parameters.AddWithValue("@idp", fila("IDvi"))
                    comando.ExecuteNonQuery()
                End Using
                consulta = "UPDATE ventas SET Total = @pre WHERE IDventa = @idp"
                Using comando As New MySqlCommand(consulta, conexion)
                    comando.Parameters.AddWithValue("@pre", PrecioTotal)
                    comando.Parameters.AddWithValue("@idp", fila("IDvi"))
                    comando.ExecuteNonQuery()
                End Using
            Next
            InfoVentas.DataSource = tabla
        End Using
    End Sub
    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Me.Close()
        Menu.Show()
    End Sub
End Class