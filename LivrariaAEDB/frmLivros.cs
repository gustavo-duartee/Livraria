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
    public partial class frmLivros : UserControl
    {
        public frmLivros()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-M210FP2\SQLEXPRESS;integrated security=SSPI;Initial Catalog=db_livraria");

        SqlCommand cm = new SqlCommand();

        SqlDataReader dt;

       private void DesabilitaCampos()
        {
            lblCodigo.Visible = false;
            Lbl_Cod.Visible = false;
            txtTitulo.Enabled = false;
            txtAutor.Enabled = false;
            txtAssunto.Enabled = false;
            txtEditora.Enabled = false;
            BtnGravar.Enabled = false;
            BtnAlterar.Enabled = false;
            BtnExcluir.Enabled = false;
            BtnCancelar.Enabled = false;
        }

        private void HabilitaCampos()
        {
            txtTitulo.Enabled = true;
            txtAutor.Enabled = true;
            txtAssunto.Enabled = true;
            txtEditora.Enabled = true;
            BtnGravar.Enabled = true;
            BtnExcluir.Enabled = true;
            BtnCancelar.Enabled = true;
            BtnNovoL.Enabled = false;
            txtTitulo.Focus();
            TxtBusca.Text = "";
            Dgv_Livros.DataSource = null;
        }

        private void LimparCampos()
        {
            txtTitulo.Text = "";
            txtAutor.Clear();
            txtAssunto.Clear();
            txtEditora.Clear();
            txtTitulo.Focus();
            TxtBusca.Clear();
            Dgv_Livros.DataSource = null;
            Lbl_Cod.Visible = false;
        }

        private void ManipularDados()
        {
            lblCodigo.Visible = true;
            Lbl_Cod.Visible = true;
            BtnAlterar.Enabled = true;
            BtnCancelar.Enabled = true;
            BtnExcluir.Enabled = true;
            BtnNovoL.Enabled = false;
            BtnGravar.Enabled = false;
            txtTitulo.Enabled = true;
            txtAutor.Enabled = true;
            txtAssunto.Enabled = true;
            txtEditora.Enabled = true;
        }
        
        private void BtnNovoL_Click(object sender, EventArgs e)
        {
            HabilitaCampos();
        }

        private void BtnGravar_Click_1(object sender, EventArgs e)
        {
            {
                if (txtTitulo.Text == "")
                {
                    MessageBox.Show("Obrigatório informar o campo titulo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTitulo.Focus();
                }
                else if (txtAutor.Text == "")
                {
                    MessageBox.Show("Obrigatório informar o campo Autor.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAutor.Focus();
                }
                else if (txtAssunto.Text == "")
                {
                    MessageBox.Show("Obrigatório informar o campo Assunto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAssunto.Focus();
                }
                else if (txtEditora.Text == "")
                {
                    MessageBox.Show("Obrigatório informar o campo Editora.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEditora.Focus();
                }

                else
                {
                    try
                    {
                        string Titulo = txtTitulo.Text;
                        string Autor = txtAutor.Text;
                        string Assunto = txtAssunto.Text;
                        string Editora = txtEditora.Text;


                        string strsql = "insert into tbl_Livros(nm_Titulo,nm_Autor,nm_Assunto,nm_Editora)values(@titulo,@autor,@assunto,@editora)";

                        cm.CommandText = strsql;
                        cm.Connection = cn;


                        cm.Parameters.Add("@titulo", SqlDbType.VarChar).Value = Titulo;
                        cm.Parameters.Add("@autor", SqlDbType.VarChar).Value = Autor;
                        cm.Parameters.Add("@assunto", SqlDbType.VarChar).Value = Assunto;
                        cm.Parameters.Add("@editora", SqlDbType.VarChar).Value = Editora;

                        cn.Open();
                        cm.ExecuteNonQuery();
                        cm.Parameters.Clear();
                        MessageBox.Show("Dados gravados com sucesso!", "Inserção de Dados Completa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTitulo.Focus();
                        LimparCampos();
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
            {
                if (txtTitulo.Text == "")
                {
                    MessageBox.Show("Obrigatório informar o campo titulo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTitulo.Focus();
                }
                else if (txtAutor.Text == "")
                {
                    MessageBox.Show("Obrigatório informar o campo Autor.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAutor.Focus();
                }
                else if (txtAssunto.Text == "")
                {
                    MessageBox.Show("Obrigatório informar o campo Assunto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAssunto.Focus();
                }
                else if (txtEditora.Text == "")
                {
                    MessageBox.Show("Obrigatório informar o campo Editora.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEditora.Focus();
                }

                else
                {
                    try
                    {
                        int cd = Convert.ToInt32(Lbl_Cod.Text);
                        cn.Open();
                        string strsql = "delete tbl_Livros where cd_Livro = @cd";                      
                        cm.CommandText = strsql;
                        cm.Connection = cn;
                        cm.Parameters.Add("@cd", SqlDbType.Int).Value = cd;

                        cm.ExecuteNonQuery();
                        cm.Parameters.Clear();
                        MessageBox.Show("Exclusão realizada com sucesso!!", "Exclusão de Registro Concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTitulo.Focus();
                        LimparCampos();
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

        private void frmLivros_Load(object sender, EventArgs e)
        {
            DesabilitaCampos();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitaCampos();
            LimparCampos();
            BtnNovoL.Enabled = true;
            TxtBusca.Text = "";
            Dgv_Livros.DataSource = null;
        }

        private void TxtBusca_TextChanged(object sender, EventArgs e)
        {
            {
                //like esta fazendo a busca no Sql Server e a textbox foi concatenada com o comando de texto
                if (TxtBusca.Text != "")
                {
                    try
                    {
                        cn.Open();
                        cm.CommandText = "select * from tbl_Livros where nm_Titulo like ('" + TxtBusca.Text + "%')";
                        cm.Connection = cn;
                        //o data adapter recebe os dados pelo select
                        SqlDataAdapter da = new SqlDataAdapter();

                        //representar varias tabelas de dados que ficam alocadas na memória
                        DataTable dt = new DataTable();

                        //recebe os dados do select 
                        da.SelectCommand = cm;
                        da.Fill(dt); //preenche a tabela com uma consulta dos dados do select
                        Dgv_Livros.DataSource = dt;
                        cn.Close();

                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message);
                    }

                }
                else
                {
                    Dgv_Livros.DataSource = null;
                }
            }
        }
        private void CarregaAtendente2()
        {

            cm.CommandText = "select * from tbl_Livros where nm_Titulo like ('" + TxtBusca.Text + "%')";
            cm.Connection = cn;
            //o data adapter recebe os dados pelo select
            SqlDataAdapter da = new SqlDataAdapter();

            //representar varias tabelas de dados que ficam alocadas na memória
            DataTable dt = new DataTable();

            //recebe os dados do select 
            da.SelectCommand = cm;
            da.Fill(dt); //preenche a tabela com uma consulta dos dados do select
            Dgv_Livros.DataSource = dt;
        }
        private void CarregaAtendente()
        {
            
            Lbl_Cod.Text = Dgv_Livros.SelectedRows[0].Cells[0].Value.ToString();
            txtTitulo.Text = Dgv_Livros.SelectedRows[0].Cells[1].Value.ToString();
            txtAutor.Text = Dgv_Livros.SelectedRows[0].Cells[2].Value.ToString();
            txtAssunto.Text = Dgv_Livros.SelectedRows[0].Cells[3].Value.ToString();
            txtEditora.Text = Dgv_Livros.SelectedRows[0].Cells[4].Value.ToString();
            ManipularDados();
            string valor = Dgv_Livros.SelectedRows[0].Cells[4].Value.ToString();

        }
        private void Dgv_Livros_MouseDoubleClick(object sender, MouseEventArgs e)
        {
             CarregaAtendente();
        }


        private void BtnCarregaFuncionario_Click(object sender, EventArgs e)
        {
            CarregaAtendente2();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            {
                if (txtTitulo.Text == "")
                {
                    MessageBox.Show("Obrigatório informar o campo titulo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTitulo.Focus();
                }
                else if (txtAutor.Text == "")
                {
                    MessageBox.Show("Obrigatório informar o campo Autor.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAutor.Focus();
                }
                else if (txtAssunto.Text == "")
                {
                    MessageBox.Show("Obrigatório informar o campo Assunto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAssunto.Focus();
                }
                else if (txtEditora.Text == "")
                {
                    MessageBox.Show("Obrigatório informar o campo Editora.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEditora.Focus();
                }

                else
                {
                    try
                    {
                        string Titulo = txtTitulo.Text;
                        string Autor = txtAutor.Text;
                        string Assunto = txtAssunto.Text;
                        string Editora = txtEditora.Text;
                        int cd = Convert.ToInt32(Lbl_Cod.Text);

                        string strsql = "update tbl_Livros set nm_Titulo=@titulo,nm_Autor=@autor,nm_Assunto=@assunto,nm_Editora=@editora, ds_status = 1 where cd_Livro=@cd ";

                        cm.CommandText = strsql;
                        cm.Connection = cn;


                        cm.Parameters.Add("@titulo", SqlDbType.VarChar).Value = Titulo;
                        cm.Parameters.Add("@autor", SqlDbType.VarChar).Value = Autor;
                        cm.Parameters.Add("@assunto", SqlDbType.VarChar).Value = Assunto;
                        cm.Parameters.Add("@editora", SqlDbType.VarChar).Value = Editora;
                        cm.Parameters.Add("@cd", SqlDbType.Int).Value = cd;

                        cn.Open();
                        cm.ExecuteNonQuery();
                        cm.Parameters.Clear();
                        MessageBox.Show("Dados alterados com sucesso!", "Alteração de Dados Completa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTitulo.Focus();
                        LimparCampos();
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
