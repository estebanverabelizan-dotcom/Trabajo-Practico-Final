<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro
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
        Panel1 = New Panel()
        Panel2 = New Panel()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        LinkLabel1 = New LinkLabel()
        Registrar = New Button()
        Label3 = New Label()
        Label4 = New Label()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(14), CByte(26), CByte(56))
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(LinkLabel1)
        Panel1.Controls.Add(Registrar)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(TextBox4)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(TextBox1)
        Panel1.Location = New Point(211, 28)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(372, 392)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label6)
        Panel2.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Panel2.Location = New Point(3, 274)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(372, 34)
        Panel2.TabIndex = 18
        Panel2.Visible = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.ForeColor = Color.Red
        Label7.Location = New Point(81, 9)
        Label7.Name = "Label7"
        Label7.Size = New Size(199, 15)
        Label7.TabIndex = 10
        Label7.Text = "USUARIO O EMAIL YA REGISTRADOS"
        Label7.Visible = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = Color.Red
        Label6.Location = New Point(81, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(199, 15)
        Label6.TabIndex = 9
        Label6.Text = "LAS CONTRASEÑAS NO COINCIDEN"
        Label6.Visible = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Black", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.DodgerBlue
        Label5.Location = New Point(120, 10)
        Label5.Name = "Label5"
        Label5.Size = New Size(115, 32)
        Label5.TabIndex = 17
        Label5.Text = "SIGN UP"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.LinkColor = Color.White
        LinkLabel1.Location = New Point(120, 353)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(115, 15)
        LinkLabel1.TabIndex = 16
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Ya tengo una cuenta"
        ' 
        ' Registrar
        ' 
        Registrar.BackColor = Color.DodgerBlue
        Registrar.FlatStyle = FlatStyle.Popup
        Registrar.Location = New Point(109, 327)
        Registrar.Name = "Registrar"
        Registrar.Size = New Size(137, 23)
        Registrar.TabIndex = 15
        Registrar.Text = "Registrar"
        Registrar.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.DodgerBlue
        Label3.Location = New Point(57, 211)
        Label3.Name = "Label3"
        Label3.Size = New Size(122, 15)
        Label3.TabIndex = 14
        Label3.Text = "Confirmar contraseña"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.DodgerBlue
        Label4.Location = New Point(57, 99)
        Label4.Name = "Label4"
        Label4.Size = New Size(36, 15)
        Label4.TabIndex = 13
        Label4.Text = "Email"
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.FromArgb(CByte(13), CByte(23), CByte(51))
        TextBox3.ForeColor = Color.DodgerBlue
        TextBox3.Location = New Point(57, 229)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(259, 23)
        TextBox3.TabIndex = 12
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = Color.FromArgb(CByte(13), CByte(23), CByte(51))
        TextBox4.ForeColor = Color.DodgerBlue
        TextBox4.Location = New Point(57, 171)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(259, 23)
        TextBox4.TabIndex = 11
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.DodgerBlue
        Label2.Location = New Point(57, 153)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 15)
        Label2.TabIndex = 10
        Label2.Text = "Contraseña"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.DodgerBlue
        Label1.Location = New Point(57, 46)
        Label1.Name = "Label1"
        Label1.Size = New Size(47, 15)
        Label1.TabIndex = 9
        Label1.Text = "Usuario"
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.FromArgb(CByte(13), CByte(23), CByte(51))
        TextBox2.ForeColor = Color.DodgerBlue
        TextBox2.Location = New Point(57, 117)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(259, 23)
        TextBox2.TabIndex = 8
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(13), CByte(23), CByte(51))
        TextBox1.ForeColor = Color.DodgerBlue
        TextBox1.Location = New Point(57, 64)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(259, 23)
        TextBox1.TabIndex = 7
        ' 
        ' Registro
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(10), CByte(34))
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Name = "Registro"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Registro Venta Libre"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Registrar As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
