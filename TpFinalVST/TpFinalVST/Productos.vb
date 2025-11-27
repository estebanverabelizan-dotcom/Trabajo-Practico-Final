Imports MySql.Data.MySqlClient

Public Class Productos
    Inherits VentasItems

    Private conexion As New Conexion()

    Private _Nombre As String
    Private _Precio As Decimal
    Private _Categoria As String
    Private _Compradas As Integer
    Private _Vendidas As Integer
    Private _Stock As Integer

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            If value = "" Then Throw New Exception("El nombre no puede estar vacío.")
            _Nombre = value
        End Set
    End Property

    Public Property Precio As Decimal
        Get
            Return _Precio
        End Get
        Set(value As Decimal)
            If value < 0 Then Throw New Exception("El precio no puede ser negativo.")
            _Precio = value
        End Set
    End Property

    Public Property Categoria As String
        Get
            Return _Categoria
        End Get
        Set(value As String)
            _Categoria = value
        End Set
    End Property

    Public Property Compradas As Integer
        Get
            Return _Compradas
        End Get
        Set(value As Integer)
            If value < 0 Then Throw New Exception("Compradas no puede ser negativo.")
            _Compradas = value
        End Set
    End Property

    Public Property Vendidas As Integer
        Get
            Return _Vendidas
        End Get
        Set(value As Integer)
            If value < 0 Then Throw New Exception("Vendidas no puede ser negativo.")
            _Vendidas = value
        End Set
    End Property

    Public Property Stock As Integer
        Get
            Return _Stock
        End Get
        Set(value As Integer)
            If value < 0 Then Throw New Exception("El stock no puede ser negativo.")
            _Stock = value
        End Set
    End Property


    Public Sub New(ID, IDVenta, IDProducto, PrecioUnitario, Cantidad, PrecioTotal, IDCliente, Fecha, Total, nombre, precioProd, categoriaProd, Compradas, Vendidas, Stock)
        MyBase.New(ID, IDVenta, IDProducto, PrecioUnitario, Cantidad, PrecioTotal)
        Me.Nombre = nombre
        Me.Precio = precioProd
        Me.Categoria = categoriaProd
        Me.compradas = Compradas
        Me.vendidas = Vendidas
        Me.stock = Stock
    End Sub


    '=============================================================== AGREGAR PRODUCTO ===============================================================
    Public Sub agregar()
        Using con As MySqlConnection = Conexion.ObtenerConexion()
            con.Open()
            Dim consulta As String = "INSERT INTO productos (IDProducto, Nombre, Precio, Categoria, Compradas, Vendidas, Stock) VALUES (@id, @nombre, @precio, @categoria, @compradas, @vendidas, @stock)"
            Using comando As New MySqlCommand(consulta, con)
                comando.Parameters.AddWithValue("@id", IDProducto)
                comando.Parameters.AddWithValue("@nombre", Nombre)
                comando.Parameters.AddWithValue("@precio", Precio)
                comando.Parameters.AddWithValue("@categoria", Categoria)
                comando.Parameters.AddWithValue("@compradas", compradas)
                comando.Parameters.AddWithValue("@vendidas", vendidas)
                comando.Parameters.AddWithValue("@stock", stock)
                comando.ExecuteNonQuery()
            End Using
        End Using
    End Sub


    '=============================================================== ELIMINAR PRODUCTO ===============================================================
    Public Sub Eliminar(idProd)
        Try
            Using con As MySqlConnection = Conexion.ObtenerConexion()
                con.Open()
                Dim consulta As String = "DELETE FROM productos WHERE IDProducto = @id"
                Using comando As New MySqlCommand(consulta, con)
                    comando.Parameters.AddWithValue("@id", idProd)
                    comando.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Error al eliminar producto: " & ex.Message)
        End Try
    End Sub


    '=============================================================== MODIFICAR PRODUCTO ===============================================================
    Public Sub Modificar(idProd, nuevoNombre, nuevoPrecio, nuevaCategoria, nuevasCompradas, nuevasVendidas, nuevoStock)
        Try
            Using con As MySqlConnection = Conexion.ObtenerConexion()
                con.Open()
                Dim consulta As String = "UPDATE productos SET Nombre = @nombre, Precio = @precio, Categoria = @categoria, Compradas = @compradas, Vendidas = @vendidas, Stock = @stock WHERE IDProducto = @id"
                Using comando As New MySqlCommand(consulta, con)
                    comando.Parameters.AddWithValue("@nombre", nuevoNombre)
                    comando.Parameters.AddWithValue("@precio", nuevoPrecio)
                    comando.Parameters.AddWithValue("@categoria", nuevaCategoria)
                    comando.Parameters.AddWithValue("@compradas", nuevasCompradas)
                    comando.Parameters.AddWithValue("@vendidas", nuevasVendidas)
                    comando.Parameters.AddWithValue("@stock", nuevoStock)
                    comando.Parameters.AddWithValue("@id", idProd)
                    comando.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Error al modificar producto: " & ex.Message)
        End Try
    End Sub


    '=============================================================== BUSCAR ===============================================================
    Public Function Buscar(filtro As String) As DataTable
        Dim tabla As New DataTable()
        Try
            Using con As MySqlConnection = Conexion.ObtenerConexion()
                con.Open()
                Dim consulta As String = "SELECT * FROM productos WHERE Nombre LIKE @filtro OR Precio LIKE @filtro OR Categoria LIKE @filtro"
                Using comando As New MySqlCommand(consulta, con)
                    comando.Parameters.AddWithValue("@filtro", "%" & filtro & "%")
                    Dim adaptador As New MySqlDataAdapter(comando)
                    adaptador.Fill(tabla)
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Error al buscar productos: " & ex.Message)
        End Try
        Return tabla
    End Function


    '=============================================================== BUSCAR POR NOMBRE ===============================================================
    Public Function CPT(nombreProd)
        Dim tabla As New DataTable()
        Try
            Using con As MySqlConnection = Conexion.ObtenerConexion()
                con.Open()
                Dim consulta As String = "SELECT * FROM productos WHERE Nombre = @nombre"
                Using comando As New MySqlCommand(consulta, con)
                    comando.Parameters.AddWithValue("@nombre", nombreProd)
                    Dim adaptador As New MySqlDataAdapter(comando)
                    adaptador.Fill(tabla)
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Error al buscar productos: " & ex.Message)
        End Try
        Return tabla
    End Function


    '=============================================================== BUSCAR POR CATEGORÍA ===============================================================
    Public Function BuscarCat(filtro As String) As DataTable
        Dim tabla As New DataTable()
        Try
            Using con As MySqlConnection = Conexion.ObtenerConexion()
                con.Open()
                Dim consulta As String = "SELECT * FROM productos WHERE Categoria LIKE @filtro"
                Using comando As New MySqlCommand(consulta, con)
                    comando.Parameters.AddWithValue("@filtro", "%" & filtro & "%")
                    Dim adaptador As New MySqlDataAdapter(comando)
                    adaptador.Fill(tabla)
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Error al buscar productos: " & ex.Message)
        End Try
        Return tabla
    End Function

End Class