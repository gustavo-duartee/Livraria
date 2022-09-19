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
    public partial class frmAtendente : UserControl
    {
        public frmAtendente()
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
            TxtNome.Enabled = false;
            Txt_Login.Enabled = false;
            TxtSenha.Enabled = false;
            BtnGravar.Enabled = false;
            BtnAlterar.Enabled = false;
            BtnExcluir.Enabled = false;
            BtnCancelar.Enabled = false;
        }

        private void HabilitaCampos()
        {
            TxtNome.Enabled = true;
            Txt_Login.Enabled = true;
            TxtSenha.Enabled = true;
            BtnGravar.Enabled = true;
            BtnExcluir.Enabled = true;
            BtnCancelar.Enabled = true;
            BtnNovo.Enabled = false;
            TxtNome.Focus();
            TxtBusca.Text = "";
            Dgv_Func.DataSource = null;
        }
        private void LimparCampos()
        {
            TxtNome.Text = "";
            Txt_Login.Clear();
            TxtSenha.Clear();
            TxtNome.Focus();
            TxtBusca.Clear();
            Dgv_Func.DataSource = null;
            Lbl_Cod.Visible = false;
        }

        private void ManipularDados()
        {
            lblCodigo.Visible = true;
            Lbl_Cod.Visible = true;
            BtnAlterar.Enabled = true;
            BtnCancelar.Enabled = true;
            BtnExcluir.Enabled = true;
            BtnNovo.Enabled = false;
            BtnGravar.Enabled = false;
            TxtNome.Enabled = true;
            Txt_Login.Enabled = true;
            TxtSenha.Enabled = true;
        }
        private void BtnNovo_Click(object sender, EventArgs e)
        {
            HabilitaCampos();
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            {
                if (TxtNome.Text == "")
                {
                    MessageBox.Show("Obrigatório informar o campo nome.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtNome.Focus();
                }
                else if (Txt_Login.Text == "")
                {
                    MessageBox.Show("Obrigatório informar o campo Login.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Txt_Login.Focus();
                }
                else if (TxtSenha.Text == "")
                {
                    MessageBox.Show("O campo Senha não pode estar vazio", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtSenha.Focus();
                }
                else if (TxtSenha.Text.Length < 8)
                {
                    MessageBox.Show("A Senha deve ter no mínimo 8 dígitos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtSenha.Focus();
                }
                else
                {
                    try
                    {
                        string nome = TxtNome.Text;
                        string login = Txt_Login.Text;
                        string senha = TxtSenha.Text;


                        string strsql = "insert into tbl_atendente(ds_Login,ds_Senha,nm_Atendente,ds_status)values(@Login,@Senha,@Atendente,1)";

                        cm.CommandText = strsql;
                        cm.Connection = cn;


                        cm.Parameters.Add("@Login", SqlDbType.VarChar).Value = login;
                        cm.Parameters.Add("@Senha", SqlDbType.Char).Value = senha;
                        cm.Parameters.Add("@Atendente", SqlDbType.VarChar).Value = nome;

                        cn.Open();
                        cm.ExecuteNonQuery();
                        cm.Parameters.Clear();
                        MessageBox.Show("Dados gravados com sucesso!", "Inserção de Dados Completa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TxtSenha.Focus();
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
        private void frmAtendente_Load(object sender, EventArgs e)
        {
            DesabilitaCampos();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitaCampos();
            LimparCampos();
            BtnNovo.Enabled = true;
            TxtBusca.Text = "";
            Dgv_Func.DataSource = null;
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
                        cm.CommandText = "select * from tbl_atendente where nm_Atendente like ('" + TxtBusca.Text + "%')";
                        cm.Connection = cn;
                        //o data adapter recebe os dados pelo select
                        SqlDataAdapter da = new SqlDataAdapter();

                        //representar varias tabelas de dados que ficam alocadas na memória
                        DataTable dt = new DataTable();

                        //recebe os dados do select 
                        da.SelectCommand = cm;
                        da.Fill(dt); //preenche a tabela com uma consulta dos dados do select
                        Dgv_Func.DataSource = dt;
                        cn.Close();

                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message);
                    }

                }
                else
                {
                    Dgv_Func.DataSource = null;
                }
            }
        }
        private void CarregaAtendente2()
        {
            
            cm.CommandText = "select * from tbl_atendente where nm_Atendente like ('" + TxtBusca.Text + "%')";
            cm.Connection = cn;
            //o data adapter recebe os dados pelo select
            SqlDataAdapter da = new SqlDataAdapter();

            //representar varias tabelas de dados que ficam alocadas na memória
            DataTable dt = new DataTable();

            //recebe os dados do select 
            da.SelectCommand = cm;
            da.Fill(dt); //preenche a tabela com uma consulta dos dados do select
            Dgv_Func.DataSource = dt;
        }
        private void CarregaAtendente()
        {
            Lbl_Cod.Text = Dgv_Func.SelectedRows[0].Cells[0].Value.ToString();
            Txt_Login.Text = Dgv_Func.SelectedRows[0].Cells[1].Value.ToString();
            TxtSenha.Text = Dgv_Func.SelectedRows[0].Cells[2].Value.ToString();
            TxtNome.Text = Dgv_Func.SelectedRows[0].Cells[3].Value.ToString();
            ManipularDados();
            string valor = Dgv_Func.SelectedRows[0].Cells[4].Value.ToString();         
        }
        private void Dgv_Func_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CarregaAtendente();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (TxtNome.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo nome.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtNome.Focus();
            }
            else if (Txt_Login.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Login.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Txt_Login.Focus();
            }
            else if (TxtSenha.Text == "")
            {
                MessageBox.Show("O campo Senha não pode estar vazio", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtSenha.Focus();
            }
            else if (TxtSenha.Text.Length < 8)
            {
                MessageBox.Show("A Senha deve ter no mínimo 8 dígitos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtSenha.Focus();
            }
            else
            {
                try
                {
                    string nome = TxtNome.Text;
                    string login = Txt_Login.Text;
                    string senha = TxtSenha.Text;
                    int cd = Convert.ToInt32(Lbl_Cod.Text);

                    string strsql = "update tbl_atendente set ds_login=@login,ds_senha=@senha,nm_Atendente=@Atendente, ds_status = 1  where cd_Atendente=@cd";
                    cm.CommandText = strsql;
                    cm.Connection = cn;


                    cm.Parameters.Add("@Login", SqlDbType.VarChar).Value = login;
                    cm.Parameters.Add("@Senha", SqlDbType.Char).Value = senha;
                    cm.Parameters.Add("@Atendente", SqlDbType.VarChar).Value = nome;
                    cm.Parameters.Add("@cd", SqlDbType.Int).Value = cd;

                    cn.Open();
                    cm.ExecuteNonQuery();
                    cm.Parameters.Clear();
                    MessageBox.Show("Dados alterados com sucesso!!", "Alteração de Dados Completa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtNome.Focus();
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

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (TxtNome.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo nome.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtNome.Focus();
            }
            else if (Txt_Login.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Login.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Txt_Login.Focus();
            }
            else if (TxtSenha.Text == "")
            {
                MessageBox.Show("O campo Senha não pode estar vazio", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtSenha.Focus();
            }
            else if (TxtSenha.Text.Length < 8)
            {
                MessageBox.Show("A Senha deve ter no mínimo 8 dígitos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtSenha.Focus();
            }
            else
            {
                //Deixa o atendente como ativo ou inativo pelo DS_STATUS da tabela 
                DialogResult exclusao = MessageBox.Show("Você tem certeza que deseja remover esse registro?", "Exclusão de Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (exclusao == DialogResult.No)
                {
                    return;
                }
                else
                {
                    try
                    {
                        int cd = Convert.ToInt32(Lbl_Cod.Text);
                        cn.Open();
                        string strsql = "delete tbl_atendente where cd_Atendente=@cd";
                        cm.CommandText = strsql;
                        cm.Connection = cn;
                        cm.Parameters.Add("@cd", SqlDbType.Int).Value = cd;

                        cm.ExecuteNonQuery();
                        cm.Parameters.Clear();
                        MessageBox.Show("Exclusão realizada com sucesso!!", "Exclusão de Registro Concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TxtNome.Focus();
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
        private void BtnCarregaFuncionario_Click(object sender, EventArgs e)
        {
            CarregaAtendente2();
        }
    }
}
