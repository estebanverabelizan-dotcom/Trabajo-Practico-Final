Imports MySql.Data.MySqlClient

Public Class Conexion
    Public Shared Function ObtenerConexion() As MySqlConnection
        Dim conexion As New MySqlConnection("server=localhost;port=3306;user id=root;password=;database=tpfinal")
        Return conexion
    End Function
End Class