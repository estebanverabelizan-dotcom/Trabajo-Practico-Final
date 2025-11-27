<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegLog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegLog))
        Salir = New Button()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Label4 = New Label()
        bntVer = New Button()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        LinkLabel1 = New LinkLabel()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Logear = New Button()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Salir
        ' 
        Salir.BackColor = Color.DodgerBlue
        Salir.FlatStyle = FlatStyle.Popup
        Salir.Location = New Point(713, 225)
        Salir.Name = "Salir"
        Salir.Size = New Size(75, 23)
        Salir.TabIndex = 0
        Salir.Text = "Salir"
        Salir.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(14), CByte(26), CByte(56))
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(bntVer)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(LinkLabel1)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Logear)
        Panel1.Controls.Add(Salir)
        Panel1.Location = New Point(0, 190)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(801, 263)
        Panel1.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Panel2.Controls.Add(Label4)
        Panel2.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Panel2.Location = New Point(0, 148)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(806, 34)
        Panel2.TabIndex = 10
        Panel2.Visible = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.Red
        Label4.Location = New Point(277, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(227, 15)
        Label4.TabIndex = 9
        Label4.Text = "USUARIO O CONTRASEÑA INCORRECTOS"
        ' 
        ' bntVer
        ' 
        bntVer.BackgroundImage = CType(resources.GetObject("bntVer.BackgroundImage"), Image)
        bntVer.BackgroundImageLayout = ImageLayout.Stretch
        bntVer.FlatStyle = FlatStyle.Popup
        bntVer.Location = New Point(533, 119)
        bntVer.Name = "bntVer"
        bntVer.Size = New Size(28, 23)
        bntVer.TabIndex = 8
        bntVer.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Black", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.DodgerBlue
        Label3.Location = New Point(351, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 32)
        Label3.TabIndex = 7
        Label3.Text = "LOGIN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.DodgerBlue
        Label2.Location = New Point(268, 101)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 15)
        Label2.TabIndex = 6
        Label2.Text = "Contraseña"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.DodgerBlue
        Label1.Location = New Point(268, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(47, 15)
        Label1.TabIndex = 5
        Label1.Text = "Usuario"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.LinkColor = Color.White
        LinkLabel1.Location = New Point(351, 228)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(96, 15)
        LinkLabel1.TabIndex = 4
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "No tengo cuenta"
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.FromArgb(CByte(13), CByte(23), CByte(51))
        TextBox2.ForeColor = Color.DodgerBlue
        TextBox2.Location = New Point(268, 119)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(259, 23)
        TextBox2.TabIndex = 3
        TextBox2.UseSystemPasswordChar = True
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(13), CByte(23), CByte(51))
        TextBox1.ForeColor = Color.DodgerBlue
        TextBox1.Location = New Point(268, 66)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(259, 23)
        TextBox1.TabIndex = 2
        ' 
        ' Logear
        ' 
        Logear.BackColor = Color.DodgerBlue
        Logear.FlatStyle = FlatStyle.Popup
        Logear.Location = New Point(330, 202)
        Logear.Name = "Logear"
        Logear.Size = New Size(137, 23)
        Logear.TabIndex = 1
        Logear.Text = "Iniciar Sesion"
        Logear.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(268, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(259, 163)
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' RegLog
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(10), CByte(34))
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Name = "RegLog"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Venta Libre"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Salir As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Logear As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents bntVer As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
End Class
