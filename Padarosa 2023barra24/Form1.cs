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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            //instanciar a janela de login
            Login janela=new Login();
            //Mostrar janela:
            janela.ShowDialog();
            //Fechar tudo:
            Application.Exit();
        }
    }
}
