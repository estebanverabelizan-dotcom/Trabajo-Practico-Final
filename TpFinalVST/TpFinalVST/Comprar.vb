Imports System.Security.Cryptography.X509Certificates
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Crypto.Digests

Public Class Comprar
    Public tabla As New DataTable()

    Private Sub Comprar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatos("Productos")
    End Sub

    Public Sub CargarDatos(Database)
        Dim c As New Conexion()
        Using conexion As MySqlConnection = c.ObtenerConexion()
            conexion.Open()
            Dim consulta As String = "SELECT * FROM " & Database
            Dim adaptador As New MySqlDataAdapter(consulta, conexion)
            adaptador.Fill(tabla)
            BDDP.DataSource = tabla
        End Using
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Me.Close()
        Menu.Show()
    End Sub

    '-------------------------------------------------- CALCULAR PRECIO TOTAL --------------------------------------------------
    Private Sub CPT_Click(sender As Object, e As EventArgs) Handles CPT.Click
        Dim nombre = PRb.Text
        Dim PrecioTotal As Decimal

        If nombre = "" Then
            MessageBox.Show("Debe ingresar algo para comprar.", "Aviso")
            Exit Sub
        End If

        Try
            Dim producto As New Productos(0, 0, 0, 0, 0, 0, 0, Date.Now, 0, "", 0, "", 0, 0, 0)
            Dim resultados As DataTable = producto.CPT(nombre)

            For Each fila As DataRow In resultados.Rows
                Dim precioUnitario As Decimal = 0

                If Not IsDBNull(fila("Precio")) Then
                    precioUnitario = fila("Precio")
                End If

                Dim cantidad As Integer = Cant.Text
                PrecioTotal = precioUnitario * cantidad
            Next

            If resultados.Rows.Count > 0 Then
                PT.Text = PrecioTotal
            Else
                MessageBox.Show("No se encontraron productos con ese criterio.", "Sin resultados")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '-------------------------------------------------- BUSCAR PRODUCTOS --------------------------------------------------
    Private Sub Busc_Click(sender As Object, e As EventArgs) Handles Busc.Click
        Dim filtro = BusCat.Text

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

    '-------------------------------------------------- RESTAURAR DATOS --------------------------------------------------
    Private Sub Rest_Click(sender As Object, e As EventArgs) Handles Rest.Click
        CargarDatos("Productos")
    End Sub

    '-------------------------------------------------- GENERAR COMPRA --------------------------------------------------
    Private Sub CompP_Click(sender As Object, e As EventArgs) Handles CompP.Click
        Try
            Dim precioTotal As Decimal = Convert.ToDecimal(PT.Text)
            Dim cantidad As Integer = Convert.ToInt32(Cant.Text)
            Dim nombreProd As String = PRb.Text
            Dim IDVenta As Integer

            Dim prod As New Productos(0, 0, 0, 0, 0, 0, 0, Date.Now, 0, "", 0, "", 0, 0, 0)
            Dim datosProd As DataTable = prod.CPT(nombreProd)

            If datosProd.Rows.Count = 0 Then
                MessageBox.Show("No existe un producto con ese nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim fila As DataRow = datosProd.Rows(0)
            Dim idProd As Integer = fila("IDProducto")
            Dim precioUnitario As Decimal = fila("Precio")
            Dim stockActual As Integer = fila("Stock")
            Dim vendidasActual As Integer = fila("Vendidas")

            If cantidad > stockActual Then
                MessageBox.Show("No hay stock suficiente. Stock actual: " & stockActual, "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim clienteObj As New Cliente(0, 0, 0, 0, 0, 0, 0, Date.Now, 0, "", 0, "")
            Dim idCliente As Integer = clienteObj.ObtenerOcrearIDCliente(UsuarioActual)

            Using con As MySqlConnection = Conexion.ObtenerConexion()
                con.Open()

                Dim comando As New MySqlCommand("SELECT IFNULL(MAX(IDventa), 0) + 1 FROM ventas", con)
                IDVenta = Convert.ToInt32(comando.ExecuteScalar())

                Dim venta As New Ventas(0, IDVenta, 0, 0, 0, precioTotal, idCliente, Date.Now, 0)
                venta.agregar()

                Dim itemVenta As New VentasItems(0, IDVenta, idProd, precioUnitario, cantidad, precioTotal)
                itemVenta.agregar()

                Dim nuevoStock = stockActual - cantidad
                Dim nuevasVendidas = vendidasActual + cantidad

                Dim actualizar As New MySqlCommand("UPDATE productos SET Vendidas = @v, Stock = @s WHERE IDProducto = @id", con)
                actualizar.Parameters.AddWithValue("@v", nuevasVendidas)
                actualizar.Parameters.AddWithValue("@s", nuevoStock)
                actualizar.Parameters.AddWithValue("@id", idProd)
                actualizar.ExecuteNonQuery()

            End Using

            MessageBox.Show("Venta agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarDatos("Productos")

        Catch ex As Exception
            MessageBox.Show("Error al agregar venta: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
