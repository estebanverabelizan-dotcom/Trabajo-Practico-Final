<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Comprar
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
        BDDP = New DataGridView()
        Busc = New Button()
        Cant = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        PRb = New TextBox()
        Label3 = New Label()
        PT = New TextBox()
        Label4 = New Label()
        BusCat = New TextBox()
        CompP = New Button()
        CPT = New Button()
        Rest = New Button()
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
        ' BDDP
        ' 
        BDDP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        BDDP.Location = New Point(12, 45)
        BDDP.Name = "BDDP"
        BDDP.Size = New Size(443, 372)
        BDDP.TabIndex = 3
        ' 
        ' Busc
        ' 
        Busc.BackColor = Color.DodgerBlue
        Busc.FlatStyle = FlatStyle.Popup
        Busc.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        Busc.Location = New Point(90, 524)
        Busc.Name = "Busc"
        Busc.Size = New Size(260, 41)
        Busc.TabIndex = 9
        Busc.Text = "Buscar"
        Busc.UseVisualStyleBackColor = False
        ' 
        ' Cant
        ' 
        Cant.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        Cant.Location = New Point(833, 126)
        Cant.Name = "Cant"
        Cant.Size = New Size(260, 33)
        Cant.TabIndex = 12
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        Label1.ForeColor = Color.DodgerBlue
        Label1.Location = New Point(912, 98)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 25)
        Label1.TabIndex = 13
        Label1.Text = "Cantidad"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        Label2.ForeColor = Color.DodgerBlue
        Label2.Location = New Point(575, 98)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 25)
        Label2.TabIndex = 15
        Label2.Text = "Producto"
        ' 
        ' PRb
        ' 
        PRb.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        PRb.Location = New Point(496, 126)
        PRb.Name = "PRb"
        PRb.Size = New Size(260, 33)
        PRb.TabIndex = 14
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        Label3.ForeColor = Color.DodgerBlue
        Label3.Location = New Point(743, 194)
        Label3.Name = "Label3"
        Label3.Size = New Size(115, 25)
        Label3.TabIndex = 17
        Label3.Text = "Precio total"
        ' 
        ' PT
        ' 
        PT.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        PT.Location = New Point(673, 222)
        PT.Name = "PT"
        PT.Size = New Size(260, 33)
        PT.TabIndex = 16
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        Label4.ForeColor = Color.DodgerBlue
        Label4.Location = New Point(12, 464)
        Label4.Name = "Label4"
        Label4.Size = New Size(168, 25)
        Label4.TabIndex = 19
        Label4.Text = "Buscar Categoria:"
        ' 
        ' BusCat
        ' 
        BusCat.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        BusCat.Location = New Point(186, 461)
        BusCat.Name = "BusCat"
        BusCat.Size = New Size(269, 33)
        BusCat.TabIndex = 18
        ' 
        ' CompP
        ' 
        CompP.BackColor = Color.DodgerBlue
        CompP.FlatStyle = FlatStyle.Popup
        CompP.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        CompP.Location = New Point(673, 363)
        CompP.Name = "CompP"
        CompP.Size = New Size(260, 41)
        CompP.TabIndex = 10
        CompP.Text = "Comprar"
        CompP.UseVisualStyleBackColor = False
        ' 
        ' CPT
        ' 
        CPT.BackColor = Color.DodgerBlue
        CPT.FlatStyle = FlatStyle.Popup
        CPT.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        CPT.Location = New Point(673, 280)
        CPT.Name = "CPT"
        CPT.Size = New Size(260, 41)
        CPT.TabIndex = 20
        CPT.Text = "Cargar Precio Total"
        CPT.UseVisualStyleBackColor = False
        ' 
        ' Rest
        ' 
        Rest.BackColor = Color.DodgerBlue
        Rest.FlatStyle = FlatStyle.Popup
        Rest.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        Rest.Location = New Point(366, 524)
        Rest.Name = "Rest"
        Rest.Size = New Size(107, 41)
        Rest.TabIndex = 21
        Rest.Text = "Restaurar"
        Rest.UseVisualStyleBackColor = False
        ' 
        ' Comprar
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(10), CByte(34))
        ClientSize = New Size(1120, 598)
        Controls.Add(Rest)
        Controls.Add(CPT)
        Controls.Add(Label4)
        Controls.Add(BusCat)
        Controls.Add(Label3)
        Controls.Add(PT)
        Controls.Add(Label2)
        Controls.Add(PRb)
        Controls.Add(Label1)
        Controls.Add(Cant)
        Controls.Add(CompP)
        Controls.Add(Busc)
        Controls.Add(BDDP)
        Controls.Add(Salir)
        Name = "Comprar"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Comprar"
        CType(BDDP, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Salir As Button
    Friend WithEvents BDDP As DataGridView
    Friend WithEvents Busc As Button
    Friend WithEvents Cant As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PRb As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PT As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BusCat As TextBox
    Friend WithEvents CompP As Button
    Friend WithEvents CPT As Button
    Friend WithEvents Rest As Button
End Class
