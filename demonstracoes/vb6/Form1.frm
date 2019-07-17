VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   6855
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   11700
   LinkTopic       =   "Form1"
   ScaleHeight     =   6855
   ScaleWidth      =   11700
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton btnEnviar 
      Caption         =   "Enviar"
      Height          =   495
      Left            =   9720
      TabIndex        =   8
      Top             =   6240
      Width           =   1815
   End
   Begin VB.TextBox txtXML 
      Height          =   3975
      Left            =   240
      MultiLine       =   -1  'True
      TabIndex        =   6
      Top             =   2040
      Width           =   11295
   End
   Begin VB.TextBox txtToken 
      Height          =   285
      Left            =   240
      TabIndex        =   5
      Top             =   1320
      Width           =   7095
   End
   Begin VB.TextBox txtSenha 
      Height          =   285
      IMEMode         =   3  'DISABLE
      Left            =   5040
      PasswordChar    =   "*"
      TabIndex        =   1
      Top             =   480
      Width           =   2295
   End
   Begin VB.TextBox txtLogin 
      Height          =   285
      Left            =   240
      TabIndex        =   0
      Top             =   480
      Width           =   4455
   End
   Begin VB.Label Label4 
      Caption         =   "XML:"
      Height          =   255
      Left            =   240
      TabIndex        =   7
      Top             =   1800
      Width           =   975
   End
   Begin VB.Label Label3 
      Caption         =   "Token do Parceiro (Software House):"
      Height          =   255
      Left            =   240
      TabIndex        =   4
      Top             =   1080
      Width           =   6975
   End
   Begin VB.Label Label2 
      Caption         =   "Senha do Cliente:"
      Height          =   255
      Left            =   5040
      TabIndex        =   3
      Top             =   240
      Width           =   1575
   End
   Begin VB.Label Label1 
      Caption         =   "E-mail do Cliente:"
      Height          =   255
      Left            =   240
      TabIndex        =   2
      Top             =   240
      Width           =   1335
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Public notasegura As spdNotaSegura.spdNotaSeguraX


Private Sub btnEnviar_Click()

    notasegura.Login = txtLogin.Text
    notasegura.Senha = txtSenha.Text
    notasegura.Token = txtToken.Text
    
    txtXML.Text = notasegura.EnviarXml(txtXML.Text)
    
End Sub

Private Sub Form_Load()
    Set notasegura = New spdNotaSegura.spdNotaSeguraX

End Sub
