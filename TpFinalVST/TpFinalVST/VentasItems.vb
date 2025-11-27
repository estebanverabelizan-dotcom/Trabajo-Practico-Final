Imports MySql.Data.MySqlClient

Public Class VentasItems
    Public ID As Integer
    Public IDVenta As Integer
    Public IDProducto As Integer
    Public PrecioUnitario As Decimal
    Public Cantidad As Integer
    Public PrecioTotal As Decimal

    Public Sub New(ID, IDVenta, IDProducto, PrecioUnitario, Cantidad, PrecioTotal)
        Me.ID = ID
        Me.IDVenta = IDVenta
        Me.IDProducto = IDProducto
        Me.PrecioUnitario = PrecioUnitario
        Me.Cantidad = Cantidad
        Me.PrecioTotal = PrecioTotal
    End Sub

    Public Sub agregar()
        Using con As MySqlConnection = Conexion.ObtenerConexion()
            con.Open()
            Dim consulta As String = "INSERT INTO VentasItems (IDvi, IDventa, IDProducto, PrecioUnit, Cantidad, PrecioTotal) VALUES (@idvi, @idv, @idp, @pu, @cant, @pt)"
            Using comando As New MySqlCommand(consulta, con)
                comando.Parameters.AddWithValue("@idvi", ID)
                comando.Parameters.AddWithValue("@idv", IDVenta)
                comando.Parameters.AddWithValue("@idp", IDProducto)
                comando.Parameters.AddWithValue("@pu", PrecioUnitario)
                comando.Parameters.AddWithValue("@cant", Cantidad)
                comando.Parameters.AddWithValue("@pt", PrecioTotal)
                comando.ExecuteNonQuery()
            End Using
        End Using
    End Sub

End Class
