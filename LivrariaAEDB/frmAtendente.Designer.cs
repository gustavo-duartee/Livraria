namespace LivrariaAEDB
{
    partial class frmAtendente
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblFuncio = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lbl_Login = new System.Windows.Forms.Label();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnGravar = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.Txt_Login = new System.Windows.Forms.TextBox();
            this.DgvFunc = new System.Windows.Forms.GroupBox();
            this.TxtBusca = new System.Windows.Forms.TextBox();
            this.Dgv_Func = new System.Windows.Forms.DataGridView();
            this.Lbl_Cod = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.BtnCarregaFuncionario = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.DgvFunc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Func)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // LblFuncio
            // 
            this.LblFuncio.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFuncio.ForeColor = System.Drawing.Color.Black;
            this.LblFuncio.Location = new System.Drawing.Point(192, 0);
            this.LblFuncio.Name = "LblFuncio";
            this.LblFuncio.Size = new System.Drawing.Size(230, 41);
            this.LblFuncio.TabIndex = 0;
            this.LblFuncio.Text = "Funcionário";
            this.LblFuncio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.Black;
            this.lblCodigo.Location = new System.Drawing.Point(30, 80);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(83, 24);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Código:";
            this.lblCodigo.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(41, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome:";
            // 
            // Lbl_Login
            // 
            this.Lbl_Login.AutoSize = true;
            this.Lbl_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Login.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Lbl_Login.Location = new System.Drawing.Point(45, 155);
            this.Lbl_Login.Name = "Lbl_Login";
            this.Lbl_Login.Size = new System.Drawing.Size(68, 24);
            this.Lbl_Login.TabIndex = 6;
            this.Lbl_Login.Text = "Login:";
            // 
            // BtnNovo
            // 
            this.BtnNovo.BackColor = System.Drawing.Color.White;
            this.BtnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNovo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnNovo.Location = new System.Drawing.Point(227, 282);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(79, 41);
            this.BtnNovo.TabIndex = 5;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = false;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.Color.White;
            this.BtnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnExcluir.Location = new System.Drawing.Point(397, 282);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(79, 41);
            this.BtnExcluir.TabIndex = 7;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.White;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnCancelar.Location = new System.Drawing.Point(482, 283);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(85, 40);
            this.BtnCancelar.TabIndex = 8;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnGravar
            // 
            this.BtnGravar.BackColor = System.Drawing.Color.White;
            this.BtnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGravar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnGravar.Location = new System.Drawing.Point(312, 282);
            this.BtnGravar.Name = "BtnGravar";
            this.BtnGravar.Size = new System.Drawing.Size(79, 41);
            this.BtnGravar.TabIndex = 6;
            this.BtnGravar.Text = "Gravar";
            this.BtnGravar.UseVisualStyleBackColor = false;
            this.BtnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.BackColor = System.Drawing.Color.White;
            this.BtnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlterar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAlterar.Location = new System.Drawing.Point(444, 439);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(151, 52);
            this.BtnAlterar.TabIndex = 11;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = false;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // TxtNome
            // 
            this.TxtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNome.Location = new System.Drawing.Point(119, 115);
            this.TxtNome.MaxLength = 60;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(448, 29);
            this.TxtNome.TabIndex = 2;
            // 
            // Txt_Login
            // 
            this.Txt_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Login.Location = new System.Drawing.Point(119, 156);
            this.Txt_Login.MaxLength = 20;
            this.Txt_Login.Name = "Txt_Login";
            this.Txt_Login.Size = new System.Drawing.Size(187, 29);
            this.Txt_Login.TabIndex = 3;
            // 
            // DgvFunc
            // 
            this.DgvFunc.Controls.Add(this.TxtBusca);
            this.DgvFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvFunc.Location = new System.Drawing.Point(2, 428);
            this.DgvFunc.Name = "DgvFunc";
            this.DgvFunc.Size = new System.Drawing.Size(436, 66);
            this.DgvFunc.TabIndex = 10;
            this.DgvFunc.TabStop = false;
            this.DgvFunc.Text = "Pesquisa por Funcionário";
            // 
            // TxtBusca
            // 
            this.TxtBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBusca.Location = new System.Drawing.Point(13, 23);
            this.TxtBusca.Name = "TxtBusca";
            this.TxtBusca.Size = new System.Drawing.Size(407, 29);
            this.TxtBusca.TabIndex = 0;
            this.TxtBusca.TextChanged += new System.EventHandler(this.TxtBusca_TextChanged);
            // 
            // Dgv_Func
            // 
            this.Dgv_Func.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.Dgv_Func.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Func.Location = new System.Drawing.Point(3, 498);
            this.Dgv_Func.MultiSelect = false;
            this.Dgv_Func.Name = "Dgv_Func";
            this.Dgv_Func.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Func.Size = new System.Drawing.Size(593, 210);
            this.Dgv_Func.TabIndex = 22;
            this.Dgv_Func.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Dgv_Func_MouseDoubleClick);
            // 
            // Lbl_Cod
            // 
            this.Lbl_Cod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Cod.ForeColor = System.Drawing.Color.Red;
            this.Lbl_Cod.Location = new System.Drawing.Point(119, 80);
            this.Lbl_Cod.Name = "Lbl_Cod";
            this.Lbl_Cod.Size = new System.Drawing.Size(43, 24);
            this.Lbl_Cod.TabIndex = 1;
            this.Lbl_Cod.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(321, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Senha:";
            // 
            // TxtSenha
            // 
            this.TxtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSenha.Location = new System.Drawing.Point(394, 155);
            this.TxtSenha.MaxLength = 8;
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Size = new System.Drawing.Size(173, 29);
            this.TxtSenha.TabIndex = 4;
            this.TxtSenha.UseSystemPasswordChar = true;
            // 
            // BtnCarregaFuncionario
            // 
            this.BtnCarregaFuncionario.BackColor = System.Drawing.Color.White;
            this.BtnCarregaFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCarregaFuncionario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnCarregaFuncionario.Location = new System.Drawing.Point(227, 327);
            this.BtnCarregaFuncionario.Name = "BtnCarregaFuncionario";
            this.BtnCarregaFuncionario.Size = new System.Drawing.Size(340, 41);
            this.BtnCarregaFuncionario.TabIndex = 9;
            this.BtnCarregaFuncionario.Text = "Carregar Funcionários";
            this.BtnCarregaFuncionario.UseVisualStyleBackColor = false;
            this.BtnCarregaFuncionario.Click += new System.EventHandler(this.BtnCarregaFuncionario_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LivrariaAEDB.Properties.Resources.aedb;
            this.pictureBox2.Location = new System.Drawing.Point(477, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(122, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 54;
            this.pictureBox2.TabStop = false;
            // 
            // frmAtendente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BtnCarregaFuncionario);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl_Cod);
            this.Controls.Add(this.Dgv_Func);
            this.Controls.Add(this.DgvFunc);
            this.Controls.Add(this.Txt_Login);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnGravar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.Lbl_Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.LblFuncio);
            this.Name = "frmAtendente";
            this.Size = new System.Drawing.Size(599, 711);
            this.Load += new System.EventHandler(this.frmAtendente_Load);
            this.DgvFunc.ResumeLayout(false);
            this.DgvFunc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Func)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblFuncio;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lbl_Login;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGravar;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.TextBox TxtNome;
        public System.Windows.Forms.TextBox Txt_Login;
        private System.Windows.Forms.GroupBox DgvFunc;
        private System.Windows.Forms.TextBox TxtBusca;
        private System.Windows.Forms.DataGridView Dgv_Func;
        private System.Windows.Forms.Label Lbl_Cod;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.Button BtnCarregaFuncionario;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
