<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtXML = New System.Windows.Forms.RichTextBox()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtToken = New System.Windows.Forms.TextBox()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtXML
        '
        Me.txtXML.Location = New System.Drawing.Point(12, 156)
        Me.txtXML.Name = "txtXML"
        Me.txtXML.Size = New System.Drawing.Size(880, 289)
        Me.txtXML.TabIndex = 18
        Me.txtXML.Text = ""
        '
        'btnEnviar
        '
        Me.btnEnviar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnEnviar.Location = New System.Drawing.Point(758, 451)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(129, 42)
        Me.btnEnviar.TabIndex = 17
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(9, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Token do Parceiro (Software House):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(508, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Senha do Cliente:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "E-Mail do Cliente:"
        '
        'txtToken
        '
        Me.txtToken.Location = New System.Drawing.Point(12, 79)
        Me.txtToken.Name = "txtToken"
        Me.txtToken.Size = New System.Drawing.Size(690, 20)
        Me.txtToken.TabIndex = 13
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(511, 29)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(191, 20)
        Me.txtSenha.TabIndex = 12
        '
        'txtLogin
        '
        Me.txtLogin.Location = New System.Drawing.Point(12, 29)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(472, 20)
        Me.txtLogin.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "XML"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(899, 506)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtXML)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtToken)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.txtLogin)
        Me.Name = "Form1"
        Me.Text = "Demonstração componente NotaSegura"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtXML As RichTextBox
    Friend WithEvents btnEnviar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtToken As TextBox
    Friend WithEvents txtSenha As TextBox
    Friend WithEvents txtLogin As TextBox
    Friend WithEvents Label4 As Label
End Class
