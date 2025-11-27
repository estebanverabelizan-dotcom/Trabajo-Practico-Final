<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Salir = New Button()
        Modificacione = New Button()
        Busca = New Button()
        Registro = New Button()
        Informe = New Button()
        Compra = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Salir
        ' 
        Salir.BackColor = Color.DodgerBlue
        Salir.FlatStyle = FlatStyle.Popup
        Salir.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        Salir.Location = New Point(805, 520)
        Salir.Name = "Salir"
        Salir.Size = New Size(82, 32)
        Salir.TabIndex = 0
        Salir.Text = "Volver"
        Salir.UseVisualStyleBackColor = False
        ' 
        ' Modificacione
        ' 
        Modificacione.BackColor = Color.DodgerBlue
        Modificacione.FlatStyle = FlatStyle.Popup
        Modificacione.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        Modificacione.ForeColor = SystemColors.ControlText
        Modificacione.Location = New Point(128, 201)
        Modificacione.Name = "Modificacione"
        Modificacione.Size = New Size(154, 138)
        Modificacione.TabIndex = 1
        Modificacione.Text = "Modificaciones"
        Modificacione.UseVisualStyleBackColor = False
        ' 
        ' Busca
        ' 
        Busca.BackColor = Color.DodgerBlue
        Busca.FlatStyle = FlatStyle.Popup
        Busca.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        Busca.ForeColor = SystemColors.ControlText
        Busca.Location = New Point(361, 201)
        Busca.Name = "Busca"
        Busca.Size = New Size(154, 138)
        Busca.TabIndex = 2
        Busca.Text = "Buscar"
        Busca.UseVisualStyleBackColor = False
        ' 
        ' Registro
        ' 
        Registro.BackColor = Color.DodgerBlue
        Registro.FlatStyle = FlatStyle.Popup
        Registro.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        Registro.ForeColor = SystemColors.ControlText
        Registro.Location = New Point(238, 371)
        Registro.Name = "Registro"
        Registro.Size = New Size(154, 138)
        Registro.TabIndex = 3
        Registro.Text = "Registro"
        Registro.UseVisualStyleBackColor = False
        ' 
        ' Informe
        ' 
        Informe.BackColor = Color.DodgerBlue
        Informe.FlatStyle = FlatStyle.Popup
        Informe.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        Informe.ForeColor = SystemColors.ControlText
        Informe.Location = New Point(583, 201)
        Informe.Name = "Informe"
        Informe.Size = New Size(154, 138)
        Informe.TabIndex = 4
        Informe.Text = "Informe"
        Informe.UseVisualStyleBackColor = False
        ' 
        ' Compra
        ' 
        Compra.BackColor = Color.DodgerBlue
        Compra.FlatStyle = FlatStyle.Popup
        Compra.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        Compra.ForeColor = SystemColors.ControlText
        Compra.Location = New Point(473, 371)
        Compra.Name = "Compra"
        Compra.Size = New Size(154, 138)
        Compra.TabIndex = 5
        Compra.Text = "Comprar"
        Compra.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(294, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(280, 150)
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' Menu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(10), CByte(34))
        ClientSize = New Size(908, 564)
        Controls.Add(PictureBox1)
        Controls.Add(Compra)
        Controls.Add(Informe)
        Controls.Add(Registro)
        Controls.Add(Busca)
        Controls.Add(Modificacione)
        Controls.Add(Salir)
        Name = "Menu"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Menu"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Salir As Button
    Friend WithEvents Modificacione As Button
    Friend WithEvents Busca As Button
    Friend WithEvents Registro As Button
    Friend WithEvents Informe As Button
    Friend WithEvents Compra As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
