Imports System.Runtime.InteropServices.JavaScript.JSType
Imports MySql.Data.MySqlClient
Imports Mysqlx.Cursor

Public Class Ventas
    Inherits VentasItems
    Public IDCliente As Integer
    Public Fecha As Date
    Public Total As Decimal

    Public Sub New(ID, IDVenta, IDProducto, PrecioUnitario, Cantidad, PrecioTotal, IDCliente, Fecha, Total)
        MyBase.New(ID, IDVenta, IDProducto, PrecioUnitario, Cantidad, PrecioTotal)

        Me.IDCliente = IDCliente
        Me.Fecha = Fecha
        Me.Total = Total
    End Sub

    Public Shared Function Infomar(fech1, fech2)
        Dim tabla As New DataTable()
        Try
            Using con As MySqlConnection = Conexion.ObtenerConexion()
                con.Open()
                Dim consulta As String = "SELECT * FROM ventas WHERE Fecha BETWEEN @fecha1 AND @fecha2"
                Using comando As New MySqlCommand(consulta, con)
                    comando.Parameters.AddWithValue("@fecha1", fech1)
                    comando.Parameters.AddWithValue("@fecha2", fech2)
                    Dim adaptador As New MySqlDataAdapter(comando)
                    adaptador.Fill(tabla)
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Error al buscar ventas: " & ex.Message)
        End Try
        Return tabla
    End Function
    Public Sub agregar()
        Using con As MySqlConnection = Conexion.ObtenerConexion()
            con.Open()
            Dim consulta As String = "INSERT INTO ventas (IDventa, IDCliente, Fecha, Total) VALUES (@idv, @idc, @fecha, @tot)"
            Using comando As New MySqlCommand(consulta, con)
                comando.Parameters.AddWithValue("@idv", IDVenta)
                comando.Parameters.AddWithValue("@idc", IDCliente)
                comando.Parameters.AddWithValue("@fecha", Date.Now)
                comando.Parameters.AddWithValue("@tot", PrecioTotal)
                comando.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class
