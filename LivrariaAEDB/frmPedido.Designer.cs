namespace LivrariaAEDB
{
    partial class frmPedido
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Dgv_ALuno = new System.Windows.Forms.DataGridView();
            this.Lbl_CodC = new System.Windows.Forms.Label();
            this.BtnCarregaAlunoA = new System.Windows.Forms.Button();
            this.BtnCarregaFuncionario = new System.Windows.Forms.Button();
            this.btncarregaLivros = new System.Windows.Forms.Button();
            this.LblFuncio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Dgv_Livros = new System.Windows.Forms.DataGridView();
            this.Dgv_Atendente = new System.Windows.Forms.DataGridView();
            this.BtnGravar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.btnCarregaPedido = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.Dgv_Pedido = new System.Windows.Forms.DataGridView();
            this.TxtBus = new System.Windows.Forms.TextBox();
            this.txtAluno = new System.Windows.Forms.TextBox();
            this.txtLivro = new System.Windows.Forms.TextBox();
            this.txtAtendente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ALuno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Livros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Atendente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Pedido)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_ALuno
            // 
            this.Dgv_ALuno.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.Dgv_ALuno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_ALuno.Location = new System.Drawing.Point(3, 498);
            this.Dgv_ALuno.MultiSelect = false;
            this.Dgv_ALuno.Name = "Dgv_ALuno";
            this.Dgv_ALuno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_ALuno.Size = new System.Drawing.Size(593, 210);
            this.Dgv_ALuno.TabIndex = 67;
            this.Dgv_ALuno.Visible = false;
            this.Dgv_ALuno.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Dgv_ALuno_MouseDoubleClick);
            // 
            // Lbl_CodC
            // 
            this.Lbl_CodC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CodC.ForeColor = System.Drawing.Color.Red;
            this.Lbl_CodC.Location = new System.Drawing.Point(119, 80);
            this.Lbl_CodC.Name = "Lbl_CodC";
            this.Lbl_CodC.Size = new System.Drawing.Size(43, 24);
            this.Lbl_CodC.TabIndex = 75;
            this.Lbl_CodC.Visible = false;
            // 
            // BtnCarregaAlunoA
            // 
            this.BtnCarregaAlunoA.BackColor = System.Drawing.Color.White;
            this.BtnCarregaAlunoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCarregaAlunoA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnCarregaAlunoA.Location = new System.Drawing.Point(118, 285);
            this.BtnCarregaAlunoA.Name = "BtnCarregaAlunoA";
            this.BtnCarregaAlunoA.Size = new System.Drawing.Size(187, 40);
            this.BtnCarregaAlunoA.TabIndex = 76;
            this.BtnCarregaAlunoA.Text = "Carrega Alunos";
            this.BtnCarregaAlunoA.UseVisualStyleBackColor = false;
            this.BtnCarregaAlunoA.Click += new System.EventHandler(this.BtnCarregaAlunoA_Click);
            // 
            // BtnCarregaFuncionario
            // 
            this.BtnCarregaFuncionario.BackColor = System.Drawing.Color.White;
            this.BtnCarregaFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCarregaFuncionario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnCarregaFuncionario.Location = new System.Drawing.Point(118, 380);
            this.BtnCarregaFuncionario.Name = "BtnCarregaFuncionario";
            this.BtnCarregaFuncionario.Size = new System.Drawing.Size(187, 40);
            this.BtnCarregaFuncionario.TabIndex = 77;
            this.BtnCarregaFuncionario.Text = "Carregar Atendente";
            this.BtnCarregaFuncionario.UseVisualStyleBackColor = false;
            this.BtnCarregaFuncionario.Click += new System.EventHandler(this.BtnCarregaFuncionario_Click);
            // 
            // btncarregaLivros
            // 
            this.btncarregaLivros.BackColor = System.Drawing.Color.White;
            this.btncarregaLivros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncarregaLivros.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btncarregaLivros.Location = new System.Drawing.Point(118, 332);
            this.btncarregaLivros.Name = "btncarregaLivros";
            this.btncarregaLivros.Size = new System.Drawing.Size(187, 40);
            this.btncarregaLivros.TabIndex = 78;
            this.btncarregaLivros.Text = "Carrega Livros";
            this.btncarregaLivros.UseVisualStyleBackColor = false;
            this.btncarregaLivros.Click += new System.EventHandler(this.btncarregaLivros_Click);
            // 
            // LblFuncio
            // 
            this.LblFuncio.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFuncio.ForeColor = System.Drawing.Color.Black;
            this.LblFuncio.Location = new System.Drawing.Point(188, 0);
            this.LblFuncio.Name = "LblFuncio";
            this.LblFuncio.Size = new System.Drawing.Size(230, 41);
            this.LblFuncio.TabIndex = 79;
            this.LblFuncio.Text = "Pedido";
            this.LblFuncio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(42, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 80;
            this.label1.Text = "Aluno";
            // 
            // lblCodigo
            // 
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.Black;
            this.lblCodigo.Location = new System.Drawing.Point(30, 80);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(83, 24);
            this.lblCodigo.TabIndex = 81;
            this.lblCodigo.Text = "Código";
            this.lblCodigo.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LivrariaAEDB.Properties.Resources.aedb;
            this.pictureBox2.Location = new System.Drawing.Point(477, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(122, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 82;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(51, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 83;
            this.label2.Text = "Livro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(-1, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 84;
            this.label3.Text = "Atendente";
            // 
            // Dgv_Livros
            // 
            this.Dgv_Livros.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.Dgv_Livros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Livros.Location = new System.Drawing.Point(3, 498);
            this.Dgv_Livros.MultiSelect = false;
            this.Dgv_Livros.Name = "Dgv_Livros";
            this.Dgv_Livros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Livros.Size = new System.Drawing.Size(593, 210);
            this.Dgv_Livros.TabIndex = 87;
            this.Dgv_Livros.Visible = false;
            this.Dgv_Livros.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Dvg_Livros_MouseDoubleClick);
            // 
            // Dgv_Atendente
            // 
            this.Dgv_Atendente.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.Dgv_Atendente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Atendente.Location = new System.Drawing.Point(3, 498);
            this.Dgv_Atendente.MultiSelect = false;
            this.Dgv_Atendente.Name = "Dgv_Atendente";
            this.Dgv_Atendente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Atendente.Size = new System.Drawing.Size(593, 210);
            this.Dgv_Atendente.TabIndex = 88;
            this.Dgv_Atendente.Visible = false;
            this.Dgv_Atendente.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Dgv_Atendente_MouseDoubleClick);
            // 
            // BtnGravar
            // 
            this.BtnGravar.BackColor = System.Drawing.Color.White;
            this.BtnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGravar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnGravar.Location = new System.Drawing.Point(407, 332);
            this.BtnGravar.Name = "BtnGravar";
            this.BtnGravar.Size = new System.Drawing.Size(90, 40);
            this.BtnGravar.TabIndex = 90;
            this.BtnGravar.Text = "Gravar";
            this.BtnGravar.UseVisualStyleBackColor = false;
            this.BtnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.Color.White;
            this.BtnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnExcluir.Location = new System.Drawing.Point(311, 287);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(90, 40);
            this.BtnExcluir.TabIndex = 91;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.BackColor = System.Drawing.Color.White;
            this.BtnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlterar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAlterar.Location = new System.Drawing.Point(407, 287);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(90, 40);
            this.BtnAlterar.TabIndex = 93;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = false;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // btnCarregaPedido
            // 
            this.btnCarregaPedido.BackColor = System.Drawing.Color.White;
            this.btnCarregaPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregaPedido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCarregaPedido.Location = new System.Drawing.Point(311, 379);
            this.btnCarregaPedido.Name = "btnCarregaPedido";
            this.btnCarregaPedido.Size = new System.Drawing.Size(186, 41);
            this.btnCarregaPedido.TabIndex = 94;
            this.btnCarregaPedido.Text = "Carrega Pedidos";
            this.btnCarregaPedido.UseVisualStyleBackColor = false;
            this.btnCarregaPedido.Click += new System.EventHandler(this.btnCarregaPedido_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.White;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpar.Location = new System.Drawing.Point(311, 333);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(90, 40);
            this.btnLimpar.TabIndex = 95;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Dgv_Pedido
            // 
            this.Dgv_Pedido.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.Dgv_Pedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Pedido.Location = new System.Drawing.Point(3, 498);
            this.Dgv_Pedido.MultiSelect = false;
            this.Dgv_Pedido.Name = "Dgv_Pedido";
            this.Dgv_Pedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Pedido.Size = new System.Drawing.Size(593, 210);
            this.Dgv_Pedido.TabIndex = 96;
            this.Dgv_Pedido.Visible = false;
            this.Dgv_Pedido.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Dgv_Pedido_MouseDoubleClick);
            // 
            // TxtBus
            // 
            this.TxtBus.BackColor = System.Drawing.Color.DodgerBlue;
            this.TxtBus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBus.Location = new System.Drawing.Point(15, 463);
            this.TxtBus.Name = "TxtBus";
            this.TxtBus.Size = new System.Drawing.Size(10, 22);
            this.TxtBus.TabIndex = 0;
            this.TxtBus.Visible = false;
            // 
            // txtAluno
            // 
            this.txtAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAluno.Location = new System.Drawing.Point(113, 115);
            this.txtAluno.Name = "txtAluno";
            this.txtAluno.Size = new System.Drawing.Size(448, 29);
            this.txtAluno.TabIndex = 101;
            // 
            // txtLivro
            // 
            this.txtLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLivro.Location = new System.Drawing.Point(113, 150);
            this.txtLivro.Name = "txtLivro";
            this.txtLivro.Size = new System.Drawing.Size(448, 29);
            this.txtLivro.TabIndex = 102;
            // 
            // txtAtendente
            // 
            this.txtAtendente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAtendente.Location = new System.Drawing.Point(113, 185);
            this.txtAtendente.Name = "txtAtendente";
            this.txtAtendente.Size = new System.Drawing.Size(448, 29);
            this.txtAtendente.TabIndex = 103;
            // 
            // frmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.Controls.Add(this.txtAtendente);
            this.Controls.Add(this.txtLivro);
            this.Controls.Add(this.txtAluno);
            this.Controls.Add(this.TxtBus);
            this.Controls.Add(this.Dgv_Pedido);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCarregaPedido);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnGravar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.Dgv_Atendente);
            this.Controls.Add(this.Dgv_Livros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblFuncio);
            this.Controls.Add(this.btncarregaLivros);
            this.Controls.Add(this.BtnCarregaFuncionario);
            this.Controls.Add(this.BtnCarregaAlunoA);
            this.Controls.Add(this.Lbl_CodC);
            this.Controls.Add(this.Dgv_ALuno);
            this.Name = "frmPedido";
            this.Size = new System.Drawing.Size(599, 711);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ALuno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Livros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Atendente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Pedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Dgv_ALuno;
        private System.Windows.Forms.Label Lbl_CodC;
        private System.Windows.Forms.Button BtnCarregaAlunoA;
        private System.Windows.Forms.Button BtnCarregaFuncionario;
        private System.Windows.Forms.Button btncarregaLivros;
        private System.Windows.Forms.Label LblFuncio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView Dgv_Livros;
        private System.Windows.Forms.DataGridView Dgv_Atendente;
        private System.Windows.Forms.Button BtnGravar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button btnCarregaPedido;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridView Dgv_Pedido;
        private System.Windows.Forms.TextBox TxtBus;
        private System.Windows.Forms.TextBox txtAluno;
        private System.Windows.Forms.TextBox txtLivro;
        private System.Windows.Forms.TextBox txtAtendente;
    }
}
