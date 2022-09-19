namespace LivrariaAEDB
{
    partial class frmLivros
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
            this.lblLivros = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblAssunto = new System.Windows.Forms.Label();
            this.lblEditora = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.Dgv_Livros = new System.Windows.Forms.DataGridView();
            this.DgvLivros = new System.Windows.Forms.GroupBox();
            this.TxtBusca = new System.Windows.Forms.TextBox();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnCarregaFuncionario = new System.Windows.Forms.Button();
            this.BtnGravar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnNovoL = new System.Windows.Forms.Button();
            this.Lbl_Cod = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Livros)).BeginInit();
            this.DgvLivros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLivros
            // 
            this.lblLivros.AutoSize = true;
            this.lblLivros.Font = new System.Drawing.Font("Adobe Devanagari", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLivros.Location = new System.Drawing.Point(240, 0);
            this.lblLivros.Name = "lblLivros";
            this.lblLivros.Size = new System.Drawing.Size(108, 50);
            this.lblLivros.TabIndex = 0;
            this.lblLivros.Text = "Livros";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(44, 115);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(62, 24);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Título";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(46, 155);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(60, 24);
            this.lblAutor.TabIndex = 2;
            this.lblAutor.Text = "Autor";
            // 
            // lblAssunto
            // 
            this.lblAssunto.AutoSize = true;
            this.lblAssunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssunto.Location = new System.Drawing.Point(21, 195);
            this.lblAssunto.Name = "lblAssunto";
            this.lblAssunto.Size = new System.Drawing.Size(85, 24);
            this.lblAssunto.TabIndex = 3;
            this.lblAssunto.Text = "Assunto";
            // 
            // lblEditora
            // 
            this.lblEditora.AutoSize = true;
            this.lblEditora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditora.Location = new System.Drawing.Point(30, 235);
            this.lblEditora.Name = "lblEditora";
            this.lblEditora.Size = new System.Drawing.Size(76, 24);
            this.lblEditora.TabIndex = 4;
            this.lblEditora.Text = "Editora";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(112, 115);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(448, 29);
            this.txtTitulo.TabIndex = 1;
            // 
            // txtAutor
            // 
            this.txtAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutor.Location = new System.Drawing.Point(112, 155);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(448, 29);
            this.txtAutor.TabIndex = 2;
            // 
            // txtAssunto
            // 
            this.txtAssunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssunto.Location = new System.Drawing.Point(112, 195);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(448, 29);
            this.txtAssunto.TabIndex = 3;
            // 
            // txtEditora
            // 
            this.txtEditora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditora.Location = new System.Drawing.Point(112, 235);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(448, 29);
            this.txtEditora.TabIndex = 4;
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
            this.Dgv_Livros.TabIndex = 23;
            this.Dgv_Livros.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Dgv_Livros_MouseDoubleClick);
            // 
            // DgvLivros
            // 
            this.DgvLivros.Controls.Add(this.TxtBusca);
            this.DgvLivros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvLivros.Location = new System.Drawing.Point(3, 426);
            this.DgvLivros.Name = "DgvLivros";
            this.DgvLivros.Size = new System.Drawing.Size(436, 66);
            this.DgvLivros.TabIndex = 10;
            this.DgvLivros.TabStop = false;
            this.DgvLivros.Text = "Pesquisa por Livro";
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
            // BtnAlterar
            // 
            this.BtnAlterar.BackColor = System.Drawing.Color.White;
            this.BtnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlterar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAlterar.Location = new System.Drawing.Point(445, 437);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(151, 52);
            this.BtnAlterar.TabIndex = 11;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = false;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnCarregaFuncionario
            // 
            this.BtnCarregaFuncionario.BackColor = System.Drawing.Color.White;
            this.BtnCarregaFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCarregaFuncionario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnCarregaFuncionario.Location = new System.Drawing.Point(220, 328);
            this.BtnCarregaFuncionario.Name = "BtnCarregaFuncionario";
            this.BtnCarregaFuncionario.Size = new System.Drawing.Size(340, 41);
            this.BtnCarregaFuncionario.TabIndex = 9;
            this.BtnCarregaFuncionario.Text = "Carrega Livros";
            this.BtnCarregaFuncionario.UseVisualStyleBackColor = false;
            this.BtnCarregaFuncionario.Click += new System.EventHandler(this.BtnCarregaFuncionario_Click);
            // 
            // BtnGravar
            // 
            this.BtnGravar.BackColor = System.Drawing.Color.White;
            this.BtnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGravar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnGravar.Location = new System.Drawing.Point(305, 281);
            this.BtnGravar.Name = "BtnGravar";
            this.BtnGravar.Size = new System.Drawing.Size(79, 41);
            this.BtnGravar.TabIndex = 6;
            this.BtnGravar.Text = "Gravar";
            this.BtnGravar.UseVisualStyleBackColor = false;
            this.BtnGravar.Click += new System.EventHandler(this.BtnGravar_Click_1);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.White;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnCancelar.Location = new System.Drawing.Point(475, 282);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(85, 40);
            this.BtnCancelar.TabIndex = 8;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.Color.White;
            this.BtnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnExcluir.Location = new System.Drawing.Point(390, 282);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(79, 41);
            this.BtnExcluir.TabIndex = 7;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnNovoL
            // 
            this.BtnNovoL.BackColor = System.Drawing.Color.White;
            this.BtnNovoL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNovoL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnNovoL.Location = new System.Drawing.Point(220, 282);
            this.BtnNovoL.Name = "BtnNovoL";
            this.BtnNovoL.Size = new System.Drawing.Size(79, 41);
            this.BtnNovoL.TabIndex = 5;
            this.BtnNovoL.Text = "Novo";
            this.BtnNovoL.UseVisualStyleBackColor = false;
            this.BtnNovoL.Click += new System.EventHandler(this.BtnNovoL_Click);
            // 
            // Lbl_Cod
            // 
            this.Lbl_Cod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Cod.ForeColor = System.Drawing.Color.Red;
            this.Lbl_Cod.Location = new System.Drawing.Point(119, 80);
            this.Lbl_Cod.Name = "Lbl_Cod";
            this.Lbl_Cod.Size = new System.Drawing.Size(43, 24);
            this.Lbl_Cod.TabIndex = 36;
            this.Lbl_Cod.Visible = false;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.Black;
            this.lblCodigo.Location = new System.Drawing.Point(30, 80);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(83, 24);
            this.lblCodigo.TabIndex = 35;
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
            this.pictureBox2.TabIndex = 55;
            this.pictureBox2.TabStop = false;
            // 
            // frmLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Lbl_Cod);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.BtnCarregaFuncionario);
            this.Controls.Add(this.BtnGravar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnNovoL);
            this.Controls.Add(this.DgvLivros);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.Dgv_Livros);
            this.Controls.Add(this.txtEditora);
            this.Controls.Add(this.txtAssunto);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblEditora);
            this.Controls.Add(this.lblAssunto);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblLivros);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmLivros";
            this.Size = new System.Drawing.Size(599, 711);
            this.Load += new System.EventHandler(this.frmLivros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Livros)).EndInit();
            this.DgvLivros.ResumeLayout(false);
            this.DgvLivros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLivros;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblAssunto;
        private System.Windows.Forms.Label lblEditora;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.DataGridView Dgv_Livros;
        private System.Windows.Forms.GroupBox DgvLivros;
        private System.Windows.Forms.TextBox TxtBusca;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnCarregaFuncionario;
        private System.Windows.Forms.Button BtnGravar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnNovoL;
        private System.Windows.Forms.Label Lbl_Cod;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
