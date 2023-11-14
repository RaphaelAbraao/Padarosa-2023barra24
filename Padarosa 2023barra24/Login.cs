using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Padarosa_2023barra24
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Classes.Usuario usuario = new Classes.Usuario();
            usuario.Email = txbEmail.Text;
            usuario.Senha = txbSenha.Text;

            var resultado = usuario.Logar();           

            if(resultado.Rows.Count > 0)          
            {
                // Senha correta: Prosseguir..
                usuario.NomeCompleto = resultado.Rows[0]["nome_completo"].ToString();
                usuario.Id = (int)resultado.Rows[0]["id"];
                // Próximo passo: abrir a janela menu:
                MenuPrincipal janela = new MenuPrincipal(usuario);
                // Esconder a janela atual:
                this.Hide();
                // Mostrar o menu:
                janela.ShowDialog();
                // Mostrar o login quando o menu fechar:
                this.Show();
            }
            else
            {
                MessageBox.Show("Email ou senha incorretos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
