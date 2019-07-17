using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using spdNotaSegura;
namespace NotaSegura_CSHARP
{
    public partial class Form1 : Form
    {
        spdNotaSeguraX notasegura = new spdNotaSeguraX();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {

            notasegura.Login = txtLogin.Text;
            notasegura.Senha = txtSenha.Text;
            notasegura.Token = txtToken.Text;

            txtXML.Text = notasegura.EnviarXml(txtXML.Text);

        }
    }
}
