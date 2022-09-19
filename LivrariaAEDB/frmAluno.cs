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
    public partial class frmAluno : UserControl
    {
        public frmAluno()
        {
            InitializeComponent();
            DesabilitaCampos();
        }
        //Fazendo conexão com o banco de dados
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-M210FP2\SQLEXPRESS;integrated security=SSPI;Initial Catalog=db_livraria");

        SqlCommand cm = new SqlCommand();

        SqlDataReader dt;

        //Desabilita os campos
        private void DesabilitaCampos()
        {
            lblCodigoA.Visible = false;
            Lbl_CodA.Visible = false;
            txtNomeAluno.Enabled = false;
            txtEmailAluno.Enabled = false;
            txtCursoAluno.Enabled = false;
            BtnGravarA.Enabled = false;
            BtnAlterarA.Enabled = false;
            BtnExcluirA.Enabled = false;
            BtnCancelarA.Enabled = false;
        }
        //Habilita os campos
        private void HabilitaCampos()
        {
            txtNomeAluno.Enabled = true;
            txtEmailAluno.Enabled = true;
            txtCursoAluno.Enabled = true;
            BtnGravarA.Enabled = true;
            BtnExcluirA.Enabled = true;
            BtnCancelarA.Enabled = true;
            BtnNovoA.Enabled = false;
            txtNomeAluno.Focus();
            TxtBuscaA.Text = "";
            Dgv_Aluno.DataSource = null;
        }
        //Limpa os campos
        private void LimparCampos()
        {
            txtNomeAluno.Text = "";
            txtEmailAluno.Clear();
            txtCursoAluno.Clear();
            txtNomeAluno.Focus();
            TxtBuscaA.Clear();
            Dgv_Aluno.DataSource = null;
            Lbl_CodA.Visible = false;
        }
        //Manipula os Dados
        private void ManipularDados()
        {
            lblCodigoA.Visible = true;
            Lbl_CodA.Visible = true;
            BtnAlterarA.Enabled = true;
            BtnCancelarA.Enabled = true;
            BtnExcluirA.Enabled = true;
            BtnNovoA.Enabled = false;
            BtnGravarA.Enabled = false;
            txtNomeAluno.Enabled = true;
            txtEmailAluno.Enabled = true;
            txtCursoAluno.Enabled = true;
        }
        private void BtnNovoA_Click(object sender, EventArgs e)
        {
            HabilitaCampos();
        }

        private void BtnGravarA_Click(object sender, EventArgs e)
        {
            {
                {
                    if (txtNomeAluno.Text == "")
                    {
                        MessageBox.Show("Obrigatório informar o campo Nome.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNomeAluno.Focus();
                    }
                    else if (txtEmailAluno.Text == "")
                    {
                        MessageBox.Show("Obrigatório informar o campo Email.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtEmailAluno.Focus();
                    }
                    else if (txtCursoAluno.Text == "")
                    {
                        MessageBox.Show("Obrigatório informar o campo Curso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCursoAluno.Focus();
                    }
                    else
                    {
                        try
                        {
                            string nome = txtNomeAluno.Text;
                            string email = txtEmailAluno.Text;
                            string curso = txtCursoAluno.Text;



                            string strsql = "insert into tbl_Aluno(nm_Nome, nm_Email, nm_Curso)values(@Nome,@Email,@Curso)";

                            cm.CommandText = strsql;
                            cm.Connection = cn;

                            cm.Parameters.Add("@Nome", SqlDbType.VarChar).Value = nome;
                            cm.Parameters.Add("@Email", SqlDbType.VarChar).Value = email;
                            cm.Parameters.Add("@Curso", SqlDbType.VarChar).Value = curso;

                            cn.Open();
                            cm.ExecuteNonQuery();
                            cm.Parameters.Clear();
                            MessageBox.Show("Dados gravados com sucesso!", "Inserção de Dados Completa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtNomeAluno.Focus();
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

        private void BtnExcluirA_Click(object sender, EventArgs e)
        {
            {
                {
                    if (txtNomeAluno.Text == "")
                    {
                        MessageBox.Show("Obrigatório informar o campo Nome.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNomeAluno.Focus();
                    }
                    else if (txtEmailAluno.Text == "")
                    {
                        MessageBox.Show("Obrigatório informar o campo Email.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtEmailAluno.Focus();
                    }
                    else if (txtCursoAluno.Text == "")
                    {
                        MessageBox.Show("Obrigatório informar o campo Curso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCursoAluno.Focus();
                    }
                    else
                    {
                        try
                        {
                            int cd = Convert.ToInt32(Lbl_CodA.Text);
                            cn.Open();
                            string strsql = "delete tbl_Aluno where cd_Aluno = @cd";
                            cm.CommandText = strsql;
                            cm.Connection = cn;
                            cm.Parameters.Add("@cd", SqlDbType.Int).Value = cd;

                            cm.ExecuteNonQuery();
                            cm.Parameters.Clear();
                            MessageBox.Show("Exclusão realizada com sucesso!!", "Exclusão de Registro Concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtNomeAluno.Focus();
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

        private void frmAluno_Load(object sender, EventArgs e)
        {
            DesabilitaCampos();
        }
        private void BtnCancelarA_Click(object sender, EventArgs e)
        {
            DesabilitaCampos();
            LimparCampos();
            BtnNovoA.Enabled = true;
            TxtBuscaA.Text = "";
            Dgv_Aluno.DataSource = null;
        }

        private void BtnAlterarA_Click(object sender, EventArgs e)
        {
            {
                {
                    if (txtNomeAluno.Text == "")
                    {
                        MessageBox.Show("Obrigatório informar o campo Nome.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNomeAluno.Focus();
                    }
                    else if (txtEmailAluno.Text == "")
                    {
                        MessageBox.Show("Obrigatório informar o campo Email.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtEmailAluno.Focus();
                    }
                    else if (txtCursoAluno.Text == "")
                    {
                        MessageBox.Show("Obrigatório informar o campo Curso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCursoAluno.Focus();
                    }
                    else
                    {
                        try
                        {
                            string nome = txtNomeAluno.Text;
                            string email = txtEmailAluno.Text;
                            string curso = txtCursoAluno.Text;
                            int cd = Convert.ToInt32(Lbl_CodA.Text);

                            string strsql = "update tbl_Aluno set nm_Nome=@Nome,nm_Email=@Email,nm_Curso=@Curso, ds_status = 1 where cd_Aluno=@cd ";

                            cm.CommandText = strsql;
                            cm.Connection = cn;


                            cm.Parameters.Add("@Nome", SqlDbType.VarChar).Value = nome;
                            cm.Parameters.Add("@Email", SqlDbType.VarChar).Value = email;
                            cm.Parameters.Add("@Curso", SqlDbType.VarChar).Value = curso;
                            cm.Parameters.Add("@cd", SqlDbType.Int).Value = cd;

                            cn.Open();
                            cm.ExecuteNonQuery();
                            cm.Parameters.Clear();
                            MessageBox.Show("Dados alterados com sucesso!", "Alteração de Dados Completa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtNomeAluno.Focus();
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

        private void TxtBuscaA_TextChanged(object sender, EventArgs e)
        {
            {
                //like esta fazendo a busca no Sql Server e a textbox foi concatenada com o comando de texto
                if (TxtBuscaA.Text != "")
                {
                    try
                    {
                        cn.Open();
                        cm.CommandText = "select * from tbl_Aluno where nm_Nome like ('" + TxtBuscaA.Text + "%')";
                        cm.Connection = cn;
                        //o data adapter recebe os dados pelo select
                        SqlDataAdapter da = new SqlDataAdapter();

                        //representar varias tabelas de dados que ficam alocadas na memória
                        DataTable dt = new DataTable();

                        //recebe os dados do select 
                        da.SelectCommand = cm;
                        da.Fill(dt); //preenche a tabela com uma consulta dos dados do select
                        Dgv_Aluno.DataSource = dt;
                        cn.Close();

                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message);
                    }

                }
                else
                {
                    Dgv_Aluno.DataSource = null;
                }
            }
        }
        private void CarregaAtendente()
        {
            Lbl_CodA.Text = Dgv_Aluno.SelectedRows[0].Cells[0].Value.ToString();
            txtNomeAluno.Text = Dgv_Aluno.SelectedRows[0].Cells[1].Value.ToString();
            txtEmailAluno.Text = Dgv_Aluno.SelectedRows[0].Cells[2].Value.ToString();
            txtCursoAluno.Text = Dgv_Aluno.SelectedRows[0].Cells[3].Value.ToString();
            ManipularDados();
            string valor = Dgv_Aluno.SelectedRows[0].Cells[4].Value.ToString();
        }
        private void CarregaAtendente2()
        {
            cm.CommandText = "select * from tbl_Aluno where nm_Nome like ('" + TxtBuscaA.Text + "%')";
            cm.Connection = cn;
            //o data adapter recebe os dados pelo select
            SqlDataAdapter da = new SqlDataAdapter();

            //representar varias tabelas de dados que ficam alocadas na memória
            DataTable dt = new DataTable();

            //recebe os dados do select 
            da.SelectCommand = cm;
            da.Fill(dt); //preenche a tabela com uma consulta dos dados do select
            Dgv_Aluno.DataSource = dt;
        }
        private void Dgv_Aluno_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CarregaAtendente();
        }

        private void BtnCarregaAlunoA_Click(object sender, EventArgs e)
        {
            CarregaAtendente2();
        }
    }
}