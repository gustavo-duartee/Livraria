using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivrariaAEDB
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Login telalogin = new Login();
            telalogin.Show();
            this.Hide();
        }       

        private void frmMenu_Load(object sender, EventArgs e)
        { 
            LblUsuarioLogado.Text = Login.usuário;
            principal1.BringToFront();
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            frmAluno1.BringToFront();
        }

        private void BtnFunc_Click(object sender, EventArgs e)
        {
            frmAtendente1.BringToFront();
        }
    
        private void BtnLivros_Click(object sender, EventArgs e)
        {
            frmLivros1.BringToFront();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            frmPedido1.BringToFront();  
        }
    }
}
