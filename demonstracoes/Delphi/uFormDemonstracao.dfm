object Form1: TForm1
  Left = 0
  Top = 0
  Caption = 'Demonstra'#231#227'o Nota Segura com Componente'
  ClientHeight = 485
  ClientWidth = 908
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  OldCreateOrder = False
  PixelsPerInch = 96
  TextHeight = 13
  object Label1: TLabel
    Left = 24
    Top = 16
    Width = 79
    Height = 13
    Caption = 'E-Mail do Cliente'
  end
  object Label2: TLabel
    Left = 488
    Top = 16
    Width = 81
    Height = 13
    Caption = 'Senha do Cliente'
  end
  object Label3: TLabel
    Left = 24
    Top = 66
    Width = 174
    Height = 13
    Caption = 'Token do Parceiro (Software House)'
  end
  object Label4: TLabel
    Left = 24
    Top = 141
    Width = 19
    Height = 13
    Caption = 'XML'
  end
  object memXML: TMemo
    Left = 24
    Top = 160
    Width = 873
    Height = 281
    TabOrder = 0
  end
  object edtEmailCliente: TEdit
    Left = 24
    Top = 35
    Width = 441
    Height = 21
    TabOrder = 1
    Text = 'vitor.beal@tecnospeed.com.br'
  end
  object edtSenhaCliente: TEdit
    Left = 488
    Top = 35
    Width = 249
    Height = 21
    PasswordChar = '*'
    TabOrder = 2
    Text = '123mudar'
  end
  object edtToken: TEdit
    Left = 24
    Top = 84
    Width = 713
    Height = 21
    TabOrder = 3
    Text = 'e1260095f9df4c7c748d59d43b0658b9351d1c11'
  end
  object btnEnviar: TButton
    Left = 825
    Top = 447
    Width = 75
    Height = 25
    Caption = 'Enviar'
    TabOrder = 4
    OnClick = btnEnviarClick
  end
end
