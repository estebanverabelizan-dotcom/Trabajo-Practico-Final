<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Buscar
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
        Salir = New Button()
        BDDC = New DataGridView()
        BDDP = New DataGridView()
        BC = New Button()
        BP = New Button()
        bus = New TextBox()
        fil = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        CType(BDDC, ComponentModel.ISupportInitialize).BeginInit()
        CType(BDDP, ComponentModel.ISupportInitialize).BeginInit()
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
        ' BDDC
        ' 
        BDDC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        BDDC.Location = New Point(12, 12)
        BDDC.Name = "BDDC"
        BDDC.Size = New Size(443, 343)
        BDDC.TabIndex = 5
        ' 
        ' BDDP
        ' 
        BDDP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        BDDP.Location = New Point(665, 12)
        BDDP.Name = "BDDP"
        BDDP.Size = New Size(443, 343)
        BDDP.TabIndex = 4
        ' 
        ' BC
        ' 
        BC.BackColor = Color.DodgerBlue
        BC.FlatStyle = FlatStyle.Popup
        BC.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        BC.Location = New Point(99, 372)
        BC.Name = "BC"
        BC.Size = New Size(260, 41)
        BC.TabIndex = 6
        BC.Text = "Buscar Cliente"
        BC.UseVisualStyleBackColor = False
        ' 
        ' BP
        ' 
        BP.BackColor = Color.DodgerBlue
        BP.FlatStyle = FlatStyle.Popup
        BP.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        BP.Location = New Point(757, 372)
        BP.Name = "BP"
        BP.Size = New Size(260, 41)
        BP.TabIndex = 7
        BP.Text = "Buscar Producto"
        BP.UseVisualStyleBackColor = False
        ' 
        ' bus
        ' 
        bus.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        bus.Location = New Point(286, 466)
        bus.Name = "bus"
        bus.Size = New Size(260, 33)
        bus.TabIndex = 8
        ' 
        ' fil
        ' 
        fil.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        fil.FormattingEnabled = True
        fil.Items.AddRange(New Object() {"Cliente", "Telefono", "Correo", "Nombre", "Precio", "Categoria"})
        fil.Location = New Point(578, 466)
        fil.Name = "fil"
        fil.Size = New Size(260, 33)
        fil.TabIndex = 9
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        Label1.ForeColor = Color.DodgerBlue
        Label1.Location = New Point(375, 438)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 25)
        Label1.TabIndex = 10
        Label1.Text = "Buscar"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        Label2.ForeColor = Color.DodgerBlue
        Label2.Location = New Point(634, 438)
        Label2.Name = "Label2"
        Label2.Size = New Size(150, 25)
        Label2.TabIndex = 11
        Label2.Text = "Campo de filtro"
        ' 
        ' Buscar
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(10), CByte(34))
        ClientSize = New Size(1120, 598)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(fil)
        Controls.Add(bus)
        Controls.Add(BP)
        Controls.Add(BC)
        Controls.Add(BDDC)
        Controls.Add(BDDP)
        Controls.Add(Salir)
        Name = "Buscar"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Buscar"
        CType(BDDC, ComponentModel.ISupportInitialize).EndInit()
        CType(BDDP, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Salir As Button
    Friend WithEvents BDDC As DataGridView
    Friend WithEvents BDDP As DataGridView
    Friend WithEvents BC As Button
    Friend WithEvents BP As Button
    Friend WithEvents bus As TextBox
    Friend WithEvents fil As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
