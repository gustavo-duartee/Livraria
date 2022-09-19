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
    public partial class frmPedido : UserControl
    {
        public frmPedido()
        {
            InitializeComponent();
            desabilitaCampos();
            desabilitaBotoes();
        }
        //Conexao com o banco de dados
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-M210FP2\SQLEXPRESS;integrated security=SSPI;Initial Catalog=db_livraria");

        SqlCommand cm = new SqlCommand();

        SqlDataReader dt;
        
        private void desabilitaBotoes()
        {
            BtnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
            BtnAlterar.Enabled = false;
        }
        private void habilitaCampos()
        {
            txtAluno.Enabled = true;
            txtAtendente.Enabled = true;
            txtLivro.Enabled = true;
            BtnExcluir.Enabled = true;
            btnLimpar.Enabled = true;
            BtnGravar.Enabled = true;
            BtnAlterar.Enabled = true;
        }
        private void desabilitaCampos()
        {
            txtAluno.Enabled = false;
            txtAtendente.Enabled = false;
            txtLivro.Enabled = false;
        }
        private void LimparCampos()
        {
            txtAluno.Clear();
            txtAtendente.Clear();
            txtLivro.Clear();

            Dgv_ALuno.Visible = false;
            Dgv_Atendente.Visible = false;
            Dgv_Livros.Visible = false;
            Dgv_Pedido.Visible = false;
            Lbl_CodC.Visible = false;
        }
        private void ManipularDados()
        {
            lblCodigo.Visible = true;
            Lbl_CodC.Visible = true;
        }
        private void CarregaAluno()
        {
            cm.CommandText = "select * from tbl_Aluno where nm_Nome like ('" + TxtBus.Text + "%')";
            cm.Connection = cn;
            //o data adapter recebe os dados pelo select
            SqlDataAdapter da = new SqlDataAdapter();

            //representar varias tabelas de dados que ficam alocadas na memória
            DataTable dt = new DataTable();

            //recebe os dados do select 
            da.SelectCommand = cm;
            da.Fill(dt); //preenche a tabela com uma consulta dos dados do select
            Dgv_ALuno.DataSource = dt;
        }
        private void CarregaLivro()
        {
            cm.CommandText = "select * from tbl_Livros where nm_Titulo like ('" + TxtBus.Text + "%')";
            cm.Connection = cn;
            //o data adapter recebe os dados pelo select
            SqlDataAdapter df = new SqlDataAdapter();

            //representar varias tabelas de dados que ficam alocadas na memória
            DataTable du = new DataTable();

            //recebe os dados do select 
            df.SelectCommand = cm;
            df.Fill(du); //preenche a tabela com uma consulta dos dados do select
            Dgv_Livros.DataSource = du;

        }
        private void CarregaAtendente()
        {

            cm.CommandText = "select * from tbl_atendente where nm_Atendente like ('" + TxtBus.Text + "%')";
            cm.Connection = cn;
            //o data adapter recebe os dados pelo select
            SqlDataAdapter df = new SqlDataAdapter();

            //representar varias tabelas de dados que ficam alocadas na memória
            DataTable du = new DataTable();

            //recebe os dados do select 
            df.SelectCommand = cm;
            df.Fill(du); //preenche a tabela com uma consulta dos dados do select
            Dgv_Atendente.DataSource = du;
        }
        private void CarregaPedido()
        {
            cm.CommandText = "select * from tbl_Pedido where nm_Aluno like ('" + TxtBus.Text + "%')";
            cm.Connection = cn;
            //o data adapter recebe os dados pelo select
            SqlDataAdapter df = new SqlDataAdapter();

            //representar varias tabelas de dados que ficam alocadas na memória
            DataTable du = new DataTable();

            //recebe os dados do select 
            df.SelectCommand = cm;
            df.Fill(du); //preenche a tabela com uma consulta dos dados do select
            Dgv_Pedido.DataSource = du;
        }

        private void btncarregaLivros_Click(object sender, EventArgs e)
        {
            desabilitaBotoes();
            CarregaLivro();
            desabilitaCampos();
            Dgv_Livros.Visible = true;

            Dgv_Atendente.Visible = false;
            Dgv_Pedido.Visible = false;
            Dgv_ALuno.Visible = false;

        }
        private void BtnCarregaFuncionario_Click(object sender, EventArgs e)
        {
            desabilitaBotoes();
            CarregaAtendente();
            desabilitaCampos();
            Dgv_Atendente.Visible = true;

            Dgv_Livros.Visible = false;            
            Dgv_Pedido.Visible = false;
            Dgv_ALuno.Visible = false;
        }
        private void BtnCarregaAlunoA_Click(object sender, EventArgs e)
        {
            desabilitaBotoes();
            CarregaAluno();
            desabilitaCampos();
            Dgv_ALuno.Visible = true;

            Dgv_Livros.Visible = false;
            Dgv_Atendente.Visible = false;
            Dgv_Pedido.Visible = false;

        }
        private void btnCarregaPedido_Click(object sender, EventArgs e)
        {
            CarregaPedido();
            habilitaCampos(); 
            Dgv_Pedido.Visible = true;

            Dgv_Livros.Visible = false;
            Dgv_Atendente.Visible = false;
            Dgv_ALuno.Visible = false;
        }
        private void Dvg_Livros_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CarregaLivro2();
        }
        private void Dgv_Atendente_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CarregaAtendente2();
        }
        private void Dgv_ALuno_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CarregaAluno2();
        }
        private void Dgv_Pedido_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CarregaPedido2();
        }
        private void CarregaPedido2()
        {
            Lbl_CodC.Text = Dgv_Pedido.SelectedRows[0].Cells[0].Value.ToString();
            txtLivro.Text = Dgv_Pedido.SelectedRows[0].Cells[2].Value.ToString();
            txtAtendente.Text = Dgv_Pedido.SelectedRows[0].Cells[3].Value.ToString();
            txtAluno.Text = Dgv_Pedido.SelectedRows[0].Cells[1].Value.ToString();

            ManipularDados();
            string valor = Dgv_Pedido.SelectedRows[0].Cells[4].Value.ToString();
        }
        private void CarregaLivro2()
        {
            Lbl_CodC.Text = Dgv_Livros.SelectedRows[0].Cells[0].Value.ToString();
            txtLivro.Text = Dgv_Livros.SelectedRows[0].Cells[1].Value.ToString();

            ManipularDados();
            string valor = Dgv_Livros.SelectedRows[0].Cells[4].Value.ToString();
        }
        private void CarregaAluno2()
        {
            Lbl_CodC.Text = Dgv_ALuno.SelectedRows[0].Cells[0].Value.ToString();
            txtAluno.Text = Dgv_ALuno.SelectedRows[0].Cells[1].Value.ToString();

            ManipularDados();
            string valor = Dgv_ALuno.SelectedRows[0].Cells[4].Value.ToString();

        }
        private void CarregaAtendente2()
        {
            Lbl_CodC.Text = Dgv_Atendente.SelectedRows[0].Cells[0].Value.ToString();
            txtAtendente.Text = Dgv_Atendente.SelectedRows[0].Cells[3].Value.ToString();

            ManipularDados();
            string valor = Dgv_Atendente.SelectedRows[0].Cells[4].Value.ToString();

        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Dgv_ALuno.Visible = false;
            Dgv_Atendente.Visible = false;
            Dgv_Livros.Visible = false;
            Dgv_Pedido.Visible = false;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            desabilitaBotoes();
            LimparCampos();
            desabilitaCampos();
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            {   //Validação dos campos
                if (txtAluno.Text == "")
                {
                    MessageBox.Show("Obrigatório informar o campo titulo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAluno.Focus();
                }
                else if (txtLivro.Text == "")
                {
                    MessageBox.Show("Obrigatório informar o campo Autor.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLivro.Focus();
                }
                else if (txtAtendente.Text == "")
                {
                    MessageBox.Show("Obrigatório informar o campo Assunto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAtendente.Focus();
                }
                else
                {
                    try
                    {
                        string aluno = txtAluno.Text;
                        string livro = txtLivro.Text;
                        string atendente = txtAtendente.Text;


                        string strsql = "insert into tbl_Pedido(nm_Aluno,nm_Livro,nm_Atendente)values(@aluno,@livro,@atendente)";

                        cm.CommandText = strsql;
                        cm.Connection = cn;


                        cm.Parameters.Add("@aluno", SqlDbType.VarChar).Value = aluno;
                        cm.Parameters.Add("@livro", SqlDbType.VarChar).Value = livro;
                        cm.Parameters.Add("@atendente", SqlDbType.VarChar).Value = atendente;

                        cn.Open();
                        cm.ExecuteNonQuery();
                        cm.Parameters.Clear();
                        MessageBox.Show("Dados gravados com sucesso!", "Inserção de Dados Completa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparCampos();
                        desabilitaBotoes();
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

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            {   //Validação dos campos
                if (txtAluno.Text == "")
                {
                    MessageBox.Show("Obrigatório informar o campo titulo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAluno.Focus();
                }
                else if (txtLivro.Text == "")
                {
                    MessageBox.Show("Obrigatório informar o campo Autor.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLivro.Focus();
                }
                else if (txtAtendente.Text == "")
                {
                    MessageBox.Show("Obrigatório informar o campo Assunto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAtendente.Focus();
                }
                else
                {
                    try
                    {
                        int cd = Convert.ToInt32(Lbl_CodC.Text);
                        cn.Open();
                        string strsql = "delete tbl_Pedido where cd_Pedido = @cd";
                        cm.CommandText = strsql;
                        cm.Connection = cn;
                        cm.Parameters.Add("@cd", SqlDbType.Int).Value = cd;

                        cm.ExecuteNonQuery();
                        cm.Parameters.Clear();
                        MessageBox.Show("Exclusão realizada com sucesso!!", "Exclusão de Registro Concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtAluno.Focus();
                        LimparCampos();
                        desabilitaCampos();
                        desabilitaBotoes();
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

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            {   //Validação dos campos
                if (txtAluno.Text == "")
                {
                    MessageBox.Show("Obrigatório informar o campo titulo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAluno.Focus();
                }
                else if (txtLivro.Text == "")
                {
                    MessageBox.Show("Obrigatório informar o campo Autor.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLivro.Focus();
                }
                else if (txtAtendente.Text == "")
                {
                    MessageBox.Show("Obrigatório informar o campo Assunto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAtendente.Focus();
                }

                else
                {
                    try
                    {
                        string aluno = txtAluno.Text;
                        string livro = txtLivro.Text;
                        string atendente = txtAtendente.Text;
                        int cd = Convert.ToInt32(Lbl_CodC.Text);

                        string strsql = "update tbl_Pedido set nm_Aluno=@aluno,nm_Livro=@livro,nm_Atendente=@atendente, ds_status = 1 where cd_Pedido=@cd ";

                        cm.CommandText = strsql;
                        cm.Connection = cn;


                        cm.Parameters.Add("@aluno", SqlDbType.VarChar).Value = aluno;
                        cm.Parameters.Add("@livro", SqlDbType.VarChar).Value = livro;
                        cm.Parameters.Add("@atendente", SqlDbType.VarChar).Value = atendente;
                        cm.Parameters.Add("@cd", SqlDbType.Int).Value = cd;

                        cn.Open();
                        cm.ExecuteNonQuery();
                        cm.Parameters.Clear();
                        MessageBox.Show("Dados alterados com sucesso!", "Alteração de Dados Completa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparCampos();
                        desabilitaBotoes();
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
    }
}

