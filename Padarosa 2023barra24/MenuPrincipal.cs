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
    public partial class MenuPrincipal : Form
    {
        //Objetos globais:
        Classes.Usuario usuario = new Classes.Usuario();
        public MenuPrincipal(Classes.Usuario usuario)
        {
            InitializeComponent();
            //Atribuir o usuário local no global:
            this.usuario = usuario;
            //Mudar a label de apresentação:
            lblSaudacao.Text = "Olá, " + usuario.NomeCompleto;
        }

        private void lblMenuPrinc_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            //Instanciar a janela
            Views.dgvGerenciamentoUsuarios janela = new Views.dgvGerenciamentoUsuarios();
            janela.Show();
        }
    }
}
