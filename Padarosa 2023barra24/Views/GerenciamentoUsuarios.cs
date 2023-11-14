using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Padarosa_2023barra24.Views
{
    public partial class dgvGerenciamentoUsuarios : Form
    {
        public dgvGerenciamentoUsuarios()
        {
            InitializeComponent();
            Classes.Usuario usuario= new Classes.Usuario();
            //Atribuir a tabela (resultado do select) no DGV:
            dGVUsuarios.DataSource = usuario.ListarTudo();
        }

        private void Cadastro_Enter(object sender, EventArgs e)
        {

        }

        private void lblCadNomeCompleto_Click(object sender, EventArgs e)
        {

        }

        private void lblEdiSenha_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Instanciar o usuário:
            Classes.Usuario usuario = new Classes.Usuario();
            usuario.NomeCompleto = txbCadNome.Text;
            usuario.Email = txbCadEmail.Text;
            usuario.Senha = txbCadSenha.Text;

            if (usuario.Cadastrar() == true)
            {
                MessageBox.Show("o usuário " + usuario.NomeCompleto + " foi adicionado!");
                //Limpar campos:
                txbCadNome.Clear();
                txbCadEmail.Clear();
                txbCadSenha.Clear();
                //Atualizar o DGV:
                dGVUsuarios.DataSource=usuario.ListarTudo(); 

            }
            else
            {
                MessageBox.Show("Não foi possível adicionar!");
            }
        }
    }
}
