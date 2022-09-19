using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LivrariaAEDB
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public static string usuário;
        public static string CodUsuario;

        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-M210FP2\SQLEXPRESS;integrated security=SSPI;Initial Catalog=db_livraria");
        SqlCommand cm = new SqlCommand();
        //SqlDataReader dt;
        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BtnAcessar_Click(object sender, EventArgs e)
        {
            {
                if (TxtLogin.Text == "" || TxtSenha.Text == "")
                {
                    MessageBox.Show("Obrigatório preencher os campos login e senha", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    try
                    {
                        //abre o login---executa o comando na tabela Sql---conecta se tiver as linhas e executa a leita na variavel 'DT'
                        //só os atendentes ativos com status = 1 logarão no sistema da livraria
                        cn.Open();
                        cm.CommandText = "select * from tbl_atendente where ds_Login = ('" + TxtLogin.Text + "') and ds_Senha =('" + TxtSenha.Text + "') and ds_status = 1";
                        cm.Connection = cn;
                        SqlDataAdapter da = new SqlDataAdapter(cm);
                        DataTable dt = new DataTable();
                        da.Fill(dt);


                        //Feito acima abre o menu e fecha a caixa anterior
                        if (dt.Rows.Count > 0) //contagem das linhas no data table é maior que zero ?
                        {
                            usuário = dt.Rows[0]["ds_Login"].ToString();
                            CodUsuario = dt.Rows[0]["cd_atendente"].ToString();
                            frmMenu menu = new frmMenu();
                            menu.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Usuário ou Senha inválidos", "Ocorreu um Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            TxtLogin.Clear();
                            TxtSenha.Clear();
                            TxtLogin.Focus();
                        }
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message);
                        cn.Close();
                    }
                    finally
                    {
                        cn.Close();
                    }
                }
            }
        }
        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
        private void BtnSenha_MouseDown(object sender, MouseEventArgs e)
        {
            TxtSenha.UseSystemPasswordChar = false;
        }
        private void BtnSenha_MouseUp(object sender, MouseEventArgs e)
        {
            TxtSenha.UseSystemPasswordChar = true;
        }
    }
}
