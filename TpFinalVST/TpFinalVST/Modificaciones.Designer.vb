<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modificaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Modificaciones))
        Salir = New Button()
        BDDP = New DataGridView()
        BDDC = New DataGridView()
        AltaC = New Button()
        ModC = New Button()
        AltaP = New Button()
        ModP = New Button()
        BajaC = New Button()
        BajaP = New Button()
        PictureBox1 = New PictureBox()
        CType(BDDP, ComponentModel.ISupportInitialize).BeginInit()
        CType(BDDC, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Salir
        ' 
        Salir.BackColor = Color.DodgerBlue
        Salir.FlatStyle = FlatStyle.Popup
        Salir.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        Salir.Location = New Point(1018, 554)
        Salir.Name = "Salir"
        Salir.Size = New Size(90, 32)
        Salir.TabIndex = 1
        Salir.Text = "Volver"
        Salir.UseVisualStyleBackColor = False
        ' 
        ' BDDP
        ' 
        BDDP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        BDDP.Location = New Point(665, 54)
        BDDP.Name = "BDDP"
        BDDP.Size = New Size(443, 343)
        BDDP.TabIndex = 2
        ' 
        ' BDDC
        ' 
        BDDC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        BDDC.Location = New Point(12, 54)
        BDDC.Name = "BDDC"
        BDDC.Size = New Size(443, 343)
        BDDC.TabIndex = 3
        ' 
        ' AltaC
        ' 
        AltaC.BackColor = Color.DodgerBlue
        AltaC.FlatStyle = FlatStyle.Popup
        AltaC.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        AltaC.Location = New Point(51, 423)
        AltaC.Name = "AltaC"
        AltaC.Size = New Size(90, 41)
        AltaC.TabIndex = 4
        AltaC.Text = "Alta"
        AltaC.UseVisualStyleBackColor = False
        ' 
        ' ModC
        ' 
        ModC.BackColor = Color.DodgerBlue
        ModC.FlatStyle = FlatStyle.Popup
        ModC.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        ModC.Location = New Point(288, 423)
        ModC.Name = "ModC"
        ModC.Size = New Size(115, 41)
        ModC.TabIndex = 5
        ModC.Text = "Modificar"
        ModC.UseVisualStyleBackColor = False
        ' 
        ' AltaP
        ' 
        AltaP.BackColor = Color.DodgerBlue
        AltaP.FlatStyle = FlatStyle.Popup
        AltaP.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        AltaP.Location = New Point(716, 423)
        AltaP.Name = "AltaP"
        AltaP.Size = New Size(90, 41)
        AltaP.TabIndex = 6
        AltaP.Text = "Alta"
        AltaP.UseVisualStyleBackColor = False
        ' 
        ' ModP
        ' 
        ModP.BackColor = Color.DodgerBlue
        ModP.FlatStyle = FlatStyle.Popup
        ModP.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        ModP.Location = New Point(953, 423)
        ModP.Name = "ModP"
        ModP.Size = New Size(115, 41)
        ModP.TabIndex = 7
        ModP.Text = "Modificar"
        ModP.UseVisualStyleBackColor = False
        ' 
        ' BajaC
        ' 
        BajaC.BackColor = Color.DodgerBlue
        BajaC.FlatStyle = FlatStyle.Popup
        BajaC.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        BajaC.Location = New Point(173, 423)
        BajaC.Name = "BajaC"
        BajaC.Size = New Size(90, 41)
        BajaC.TabIndex = 8
        BajaC.Text = "Baja"
        BajaC.UseVisualStyleBackColor = False
        ' 
        ' BajaP
        ' 
        BajaP.BackColor = Color.DodgerBlue
        BajaP.FlatStyle = FlatStyle.Popup
        BajaP.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        BajaP.Location = New Point(838, 423)
        BajaP.Name = "BajaP"
        BajaP.Size = New Size(90, 41)
        BajaP.TabIndex = 9
        BajaP.Text = "Baja"
        BajaP.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(437, 403)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(233, 159)
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        ' 
        ' Modificaciones
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(10), CByte(34))
        ClientSize = New Size(1120, 598)
        Controls.Add(PictureBox1)
        Controls.Add(BajaP)
        Controls.Add(BajaC)
        Controls.Add(ModP)
        Controls.Add(AltaP)
        Controls.Add(ModC)
        Controls.Add(AltaC)
        Controls.Add(BDDC)
        Controls.Add(BDDP)
        Controls.Add(Salir)
        Name = "Modificaciones"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Modificaciones"
        CType(BDDP, ComponentModel.ISupportInitialize).EndInit()
        CType(BDDC, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Salir As Button
    Friend WithEvents BDDP As DataGridView
    Friend WithEvents BDDC As DataGridView
    Friend WithEvents AltaC As Button
    Friend WithEvents ModC As Button
    Friend WithEvents AltaP As Button
    Friend WithEvents ModP As Button
    Friend WithEvents BajaC As Button
    Friend WithEvents BajaP As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
