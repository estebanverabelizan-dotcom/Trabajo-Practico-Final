Imports System.Runtime.InteropServices.JavaScript.JSType
Imports MySql.Data.MySqlClient

Public Class Modificaciones

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatos()
    End Sub



    '-------------------------------------------------------------- CARGA DE DATOS --------------------------------------------------------------
    Private Sub CargarDatos()
        Dim c As New Conexion()

        Using conexion As MySqlConnection = c.ObtenerConexion()
            conexion.Open()
            Dim consulta As String = "SELECT * FROM clientes"
            Dim adaptador As New MySqlDataAdapter(consulta, conexion)
            Dim tabla As New DataTable()
            adaptador.Fill(tabla)
            BDDC.DataSource = tabla
        End Using

        Using conexion As MySqlConnection = c.ObtenerConexion()
            conexion.Open()
            Dim consulta As String = "SELECT * FROM productos"
            Dim adaptador As New MySqlDataAdapter(consulta, conexion)
            Dim tabla As New DataTable()
            adaptador.Fill(tabla)
            BDDP.DataSource = tabla
        End Using
    End Sub



    '-------------------------------------------------------------- AGREGAR CLIENTE --------------------------------------------------------------
    Private Sub AltaC_Click(sender As Object, e As EventArgs) Handles AltaC.Click
        Try
            Dim idCliente As Integer = InputBox("Ingrese ID del cliente:")
            Dim nombre As String = InputBox("Ingrese nombre:")
            Dim tel As String = InputBox("Ingrese teléfono:")
            Dim correo As String = InputBox("Ingrese correo:")

            Dim ClienteC As New Cliente(0, 0, 0, 0, 0, 0, idCliente, Date.Now, 0, nombre, tel, correo)
            ClienteC.agregar()

            MessageBox.Show("Cliente agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarDatos()

        Catch ex As Exception
            MessageBox.Show("Error al agregar cliente: " & ex.Message)
        End Try
    End Sub



    '-------------------------------------------------------------- ELIMINAR CLIENTE --------------------------------------------------------------
    Private Sub BajaC_Click(sender As Object, e As EventArgs) Handles BajaC.Click
        Try
            Dim idCliente As Integer = InputBox("Ingrese el ID del cliente a eliminar:", "Eliminar cliente")

            If idCliente = 0 Then
                MessageBox.Show("Debe ingresar un ID válido.", "Aviso")
                Exit Sub
            End If

            Dim cliente As New Cliente(0, 0, 0, 0, 0, 0, idCliente, Date.Now, 0, "", 0, "")
            cliente.Eliminar(idCliente)

            MessageBox.Show("Cliente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarDatos()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    '-------------------------------------------------------------- MODIFICAR CLIENTE --------------------------------------------------------------
    Private Sub ModC_Click(sender As Object, e As EventArgs) Handles ModC.Click
        Try
            Dim idCliente As Integer = InputBox("Ingrese el ID del cliente a modificar:", "Modificar cliente")

            If idCliente = 0 Then
                MessageBox.Show("Debe ingresar un ID válido.", "Aviso")
                Exit Sub
            End If

            Dim nuevoNombre As String = InputBox("Ingrese el nuevo nombre del cliente:")
            Dim nuevoTel As Integer = InputBox("Ingrese el nuevo teléfono del cliente:")
            Dim nuevoCorreo As String = InputBox("Ingrese el nuevo correo del cliente:")

            Dim cliente As New Cliente(0, 0, 0, 0, 0, 0, idCliente, Date.Now, 0, "", 0, "")
            cliente.Modificar(idCliente, nuevoNombre, nuevoTel, nuevoCorreo)

            MessageBox.Show("Cliente modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            CargarDatos()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    '-------------------------------------------------------------- SALIR --------------------------------------------------------------
    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Close()
        Menu.Show()
    End Sub



    '-------------------------------------------------------------- AGREGAR PRODUCTO --------------------------------------------------------------
    Private Sub AltaP_Click(sender As Object, e As EventArgs) Handles AltaP.Click
        Try
            Dim idProd As Integer = InputBox("Ingrese ID del producto:")
            Dim nombre As String = InputBox("Ingrese nombre del producto:")
            Dim pre As Decimal = InputBox("Ingrese precio del producto:")
            Dim cat As String = InputBox("Ingrese categoría:")

            Dim compradas As Integer = InputBox("Ingrese cantidad comprada:")
            Dim vendidas As Integer = InputBox("Ingrese cantidad vendida:")
            Dim stock As Integer = InputBox("Ingrese stock actual:")


            Dim ProC As New Productos(0, 0, idProd, 0, 0, 0, 0, Date.Now, 0, nombre, pre, cat, compradas, vendidas, stock)

            ProC.agregar()

            MessageBox.Show("Producto agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarDatos()

        Catch ex As Exception
            MessageBox.Show("Error al agregar el producto: " & ex.Message)
        End Try
    End Sub



    '-------------------------------------------------------------- ELIMINAR PRODUCTO --------------------------------------------------------------
    Private Sub BajaP_Click(sender As Object, e As EventArgs) Handles BajaP.Click
        Try
            Dim idProd As Integer = InputBox("Ingrese el ID del producto a eliminar:", "Eliminar producto")

            If idProd = 0 Then
                MessageBox.Show("Debe ingresar un ID válido.", "Aviso")
                Exit Sub
            End If

            Dim prod As New Productos(0, 0, idProd, 0, 0, 0, 0, Date.Now, 0, "", 0, "", 0, 0, 0)
            prod.Eliminar(idProd)

            MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            CargarDatos()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    '-------------------------------------------------------------- MODIFICAR PRODUCTO --------------------------------------------------------------
    Private Sub ModP_Click(sender As Object, e As EventArgs) Handles ModP.Click
        Try
            Dim idProd As Integer = InputBox("Ingrese el ID del producto a modificar:", "Modificar producto")

            If idProd = 0 Then
                MessageBox.Show("Debe ingresar un ID válido.", "Aviso")
                Exit Sub
            End If

            Dim nuevoNombre As String = InputBox("Ingrese el nuevo nombre del producto:")
            Dim nuevoPre As Decimal = InputBox("Ingrese el nuevo precio del producto:")
            Dim nuevoCat As String = InputBox("Ingrese la nueva categoría del producto:")

            Dim compradas As Integer = InputBox("Ingrese el total comprado:")
            Dim vendidas As Integer = InputBox("Ingrese el total vendido:")
            Dim stock As Integer = InputBox("Ingrese el stock actual:")

            Dim producto As New Productos(0, 0, idProd, 0, 0, 0, 0, Date.Now, 0, "", 0, "", 0, 0, 0)

            producto.Modificar(idProd, nuevoNombre, nuevoPre, nuevoCat, compradas, vendidas, stock)

            MessageBox.Show("Producto modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            CargarDatos()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
