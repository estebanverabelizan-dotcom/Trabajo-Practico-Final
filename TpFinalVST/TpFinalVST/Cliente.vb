Imports MySql.Data.MySqlClient

Public Class Cliente
    Inherits Ventas
    Private conexion As New Conexion()
    Private _NombreCliente As String
    Private _Telefono As String
    Private _Correo As String

    Public Property NombreCliente As String
        Get
            Return _NombreCliente
        End Get
        Set(value As String)
            If value = "" Then Throw New Exception("El nombre no puede estar vacío.")
            _NombreCliente = value
        End Set
    End Property

    Public Property Telefono As String
        Get
            Return _Telefono
        End Get
        Set(value As String)
            If value = "" Then Throw New Exception("El teléfono no puede estar vacío.")
            _Telefono = value
        End Set
    End Property

    Public Property Correo As String
        Get
            Return _Correo
        End Get
        Set(value As String)
            If value = "" Then Throw New Exception("El correo no puede estar vacío.")
            _Correo = value
        End Set
    End Property

    Public Sub New(ID, IDVenta, IDProducto, PrecioUnitario, Cantidad, PrecioTotal, IDCliente, Fecha, Total, nombre, telefono, correo)
        MyBase.New(ID, IDVenta, IDProducto, PrecioUnitario, Cantidad, PrecioTotal, IDCliente, Fecha, Total)
        Me.NombreCliente = nombre
        Me.Telefono = telefono
        Me.Correo = correo
    End Sub

    Public Sub agregar()
        Using con As MySqlConnection = Conexion.ObtenerConexion()
            con.Open()
            Dim consulta As String = "INSERT INTO clientes (IDCliente, Cliente, Telefono, Correo) VALUES (@id, @nombre, @tel, @correo)"
            Using comando As New MySqlCommand(consulta, con)
                comando.Parameters.AddWithValue("@id", IDCliente)
                comando.Parameters.AddWithValue("@nombre", NombreCliente)
                comando.Parameters.AddWithValue("@tel", Telefono)
                comando.Parameters.AddWithValue("@correo", Correo)
                comando.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Public Sub Eliminar(idCliente)
        Try
            Using con As MySqlConnection = Conexion.ObtenerConexion()
                con.Open()
                Dim consulta As String = "DELETE FROM clientes WHERE IDCliente = @id"
                Using comando As New MySqlCommand(consulta, con)
                    comando.Parameters.AddWithValue("@id", idCliente)
                    comando.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Error al eliminar cliente: " & ex.Message)
        End Try
    End Sub


    Public Sub Modificar(idCliente, nuevoNombre, nuevoTelefono, nuevoCorreo)
        Try
            Using con As MySqlConnection = Conexion.ObtenerConexion()
                con.Open()
                Dim consulta As String = "UPDATE clientes SET cliente = @nombre, Telefono = @tel, Correo = @correo WHERE IDCliente = @id"
                Using comando As New MySqlCommand(consulta, con)
                    comando.Parameters.AddWithValue("@nombre", nuevoNombre)
                    comando.Parameters.AddWithValue("@tel", nuevoTelefono)
                    comando.Parameters.AddWithValue("@correo", nuevoCorreo)
                    comando.Parameters.AddWithValue("@id", idCliente)
                    comando.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Error al modificar cliente: " & ex.Message)
        End Try
    End Sub

    Public Function Buscar(filtro As String) As DataTable
        Dim tabla As New DataTable()
        Try
            Using con As MySqlConnection = Conexion.ObtenerConexion()
                con.Open()
                Dim sql As String = "SELECT * FROM clientes WHERE Cliente LIKE @filtro OR Telefono LIKE @filtro OR Correo LIKE @filtro"
                Using cmd As New MySqlCommand(sql, con)
                    cmd.Parameters.AddWithValue("@filtro", "%" & filtro & "%")
                    Dim adaptador As New MySqlDataAdapter(cmd)
                    adaptador.Fill(tabla)
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Error al buscar clientes: " & ex.Message)
        End Try
        Return tabla
    End Function

    Public Shared Function ObtenerGmailUsuario(nombreUsuario As String) As String
        Dim gmail As String
        Dim conexion As New MySqlConnection("server=localhost;port=3306;user id=root;password=;database=loginregister")
        Using con As MySqlConnection = conexion
            con.Open()

            Dim cmd As New MySqlCommand("SELECT Email FROM cuentas WHERE usuario = @nombre", con)
            cmd.Parameters.AddWithValue("@nombre", nombreUsuario)

            Dim resultado = cmd.ExecuteScalar()

            If resultado IsNot Nothing AndAlso resultado IsNot DBNull.Value Then
                gmail = resultado.ToString()
            End If
        End Using

        Return gmail
    End Function

    Public Function ObtenerOcrearIDCliente(nombreUsuario As String) As Integer
        Dim idCliente As Integer = -1

        Using con As MySqlConnection = Conexion.ObtenerConexion()
            con.Open()

            Dim buscarCmd As New MySqlCommand("SELECT IDCliente FROM clientes WHERE CLiente = @nombre", con)
            buscarCmd.Parameters.AddWithValue("@nombre", nombreUsuario)

            Dim resultado = buscarCmd.ExecuteScalar()
            If resultado IsNot Nothing Then
                idCliente = Convert.ToInt32(resultado)
            Else
                Dim telefono As String = InputBox("Ingrese el número de teléfono del nuevo cliente:", "Nuevo cliente")

                If String.IsNullOrWhiteSpace(telefono) Then
                    MessageBox.Show("Debe ingresar un número de teléfono para registrar al cliente.", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return -1
                End If

                Dim comando As New MySqlCommand("SELECT IFNULL(MAX(IDcliente), 0) + 1 FROM Clientes", con)
                idCliente = Convert.ToInt32(comando.ExecuteScalar())


                Dim insertarCmd As New MySqlCommand("INSERT INTO Clientes (IDCliente, Cliente, Telefono, Correo) VALUES (@idc, @Cliente, @telefono, @correo)", con)
                insertarCmd.Parameters.AddWithValue("@idc", idCliente)
                insertarCmd.Parameters.AddWithValue("@Cliente", nombreUsuario)
                insertarCmd.Parameters.AddWithValue("@telefono", telefono)
                insertarCmd.Parameters.AddWithValue("@correo", gmailActual)
                insertarCmd.ExecuteNonQuery()

                MessageBox.Show("Nuevo cliente registrado correctamente.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Using

        Return idCliente
    End Function
End Class

