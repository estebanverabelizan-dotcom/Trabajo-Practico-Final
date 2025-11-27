<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroVentas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistroVentas))
        Salir = New Button()
        InfoVentas = New DataGridView()
        PictureBox1 = New PictureBox()
        CType(InfoVentas, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Salir
        ' 
        Salir.BackColor = Color.DodgerBlue
        Salir.FlatStyle = FlatStyle.Popup
        Salir.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        Salir.Location = New Point(1026, 554)
        Salir.Name = "Salir"
        Salir.Size = New Size(82, 32)
        Salir.TabIndex = 1
        Salir.Text = "Volver"
        Salir.UseVisualStyleBackColor = False
        ' 
        ' InfoVentas
        ' 
        InfoVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        InfoVentas.Location = New Point(254, 12)
        InfoVentas.Name = "InfoVentas"
        InfoVentas.Size = New Size(643, 407)
        InfoVentas.TabIndex = 2
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(410, 425)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(303, 170)
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' RegistroVentas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(10), CByte(34))
        ClientSize = New Size(1120, 598)
        Controls.Add(PictureBox1)
        Controls.Add(InfoVentas)
        Controls.Add(Salir)
        Name = "RegistroVentas"
        StartPosition = FormStartPosition.CenterScreen
        Text = "RegistroVentas"
        CType(InfoVentas, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Salir As Button
    Friend WithEvents InfoVentas As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
End Class
