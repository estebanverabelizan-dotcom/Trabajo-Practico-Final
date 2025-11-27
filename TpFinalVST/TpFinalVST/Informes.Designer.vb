<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Informes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Informes))
        Salir = New Button()
        Info = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        Fech1 = New TextBox()
        Fech2 = New TextBox()
        Geninf = New Button()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        CType(Info, ComponentModel.ISupportInitialize).BeginInit()
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
        Salir.TabIndex = 2
        Salir.Text = "Volver"
        Salir.UseVisualStyleBackColor = False
        ' 
        ' Info
        ' 
        Info.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Info.Location = New Point(338, 41)
        Info.Name = "Info"
        Info.Size = New Size(443, 376)
        Info.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        Label1.ForeColor = Color.DodgerBlue
        Label1.Location = New Point(31, 81)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 25)
        Label1.TabIndex = 11
        Label1.Text = "Fecha 1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        Label2.ForeColor = Color.DodgerBlue
        Label2.Location = New Point(826, 81)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 25)
        Label2.TabIndex = 12
        Label2.Text = "Fecha 2"
        ' 
        ' Fech1
        ' 
        Fech1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        Fech1.Location = New Point(31, 128)
        Fech1.Name = "Fech1"
        Fech1.Size = New Size(260, 33)
        Fech1.TabIndex = 13
        ' 
        ' Fech2
        ' 
        Fech2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        Fech2.Location = New Point(826, 128)
        Fech2.Name = "Fech2"
        Fech2.Size = New Size(260, 33)
        Fech2.TabIndex = 14
        ' 
        ' Geninf
        ' 
        Geninf.BackColor = Color.DodgerBlue
        Geninf.FlatStyle = FlatStyle.Popup
        Geninf.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        Geninf.Location = New Point(481, 473)
        Geninf.Name = "Geninf"
        Geninf.Size = New Size(176, 41)
        Geninf.TabIndex = 15
        Geninf.Text = "Generar informe"
        Geninf.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        Label3.ForeColor = Color.DodgerBlue
        Label3.Location = New Point(807, 279)
        Label3.Name = "Label3"
        Label3.Size = New Size(288, 25)
        Label3.TabIndex = 16
        Label3.Text = "Formato pedido: DD-MM-YYYY"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(31, 185)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(260, 232)
        PictureBox1.TabIndex = 17
        PictureBox1.TabStop = False
        ' 
        ' Informes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(10), CByte(34))
        ClientSize = New Size(1120, 598)
        Controls.Add(PictureBox1)
        Controls.Add(Label3)
        Controls.Add(Geninf)
        Controls.Add(Fech2)
        Controls.Add(Fech1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Info)
        Controls.Add(Salir)
        Name = "Informes"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Informes"
        CType(Info, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Salir As Button
    Friend WithEvents Info As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Fech1 As TextBox
    Friend WithEvents Fech2 As TextBox
    Friend WithEvents Geninf As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
