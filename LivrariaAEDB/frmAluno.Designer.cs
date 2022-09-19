namespace LivrariaAEDB
{
    partial class frmAluno
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
            this.Lbl_CodA = new System.Windows.Forms.Label();
            this.lblCodigoA = new System.Windows.Forms.Label();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCarregaAlunoA = new System.Windows.Forms.Button();
            this.BtnGravarA = new System.Windows.Forms.Button();
            this.BtnCancelarA = new System.Windows.Forms.Button();
            this.BtnExcluirA = new System.Windows.Forms.Button();
            this.BtnNovoA = new System.Windows.Forms.Button();
            this.DgvAluno = new System.Windows.Forms.GroupBox();
            this.TxtBuscaA = new System.Windows.Forms.TextBox();
            this.BtnAlterarA = new System.Windows.Forms.Button();
            this.Dgv_Aluno = new System.Windows.Forms.DataGridView();
            this.txtEmailAluno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCursoAluno = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DgvAluno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Aluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLivros
            // 
            this.lblLivros.AutoSize = true;
            this.lblLivros.Font = new System.Drawing.Font("Adobe Devanagari", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLivros.Location = new System.Drawing.Point(244, 0);
            this.lblLivros.Name = "lblLivros";
            this.lblLivros.Size = new System.Drawing.Size(108, 50);
            this.lblLivros.TabIndex = 0;
            this.lblLivros.Text = "Aluno";
            // 
            // Lbl_CodA
            // 
            this.Lbl_CodA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CodA.ForeColor = System.Drawing.Color.Red;
            this.Lbl_CodA.Location = new System.Drawing.Point(119, 80);
            this.Lbl_CodA.Name = "Lbl_CodA";
            this.Lbl_CodA.Size = new System.Drawing.Size(43, 24);
            this.Lbl_CodA.TabIndex = 38;
            this.Lbl_CodA.Visible = false;
            // 
            // lblCodigoA
            // 
            this.lblCodigoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoA.ForeColor = System.Drawing.Color.Black;
            this.lblCodigoA.Location = new System.Drawing.Point(30, 80);
            this.lblCodigoA.Name = "lblCodigoA";
            this.lblCodigoA.Size = new System.Drawing.Size(83, 24);
            this.lblCodigoA.TabIndex = 37;
            this.lblCodigoA.Text = "Código";
            this.lblCodigoA.Visible = false;
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeAluno.Location = new System.Drawing.Point(110, 110);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(450, 29);
            this.txtNomeAluno.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(38, 110);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(66, 24);
            this.lblTitulo.TabIndex = 40;
            this.lblTitulo.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 41;
            this.label1.Text = "Email";
            // 
            // BtnCarregaAlunoA
            // 
            this.BtnCarregaAlunoA.BackColor = System.Drawing.Color.White;
            this.BtnCarregaAlunoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCarregaAlunoA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnCarregaAlunoA.Location = new System.Drawing.Point(220, 326);
            this.BtnCarregaAlunoA.Name = "BtnCarregaAlunoA";
            this.BtnCarregaAlunoA.Size = new System.Drawing.Size(340, 41);
            this.BtnCarregaAlunoA.TabIndex = 8;
            this.BtnCarregaAlunoA.Text = "Carrega Alunos";
            this.BtnCarregaAlunoA.UseVisualStyleBackColor = false;
            this.BtnCarregaAlunoA.Click += new System.EventHandler(this.BtnCarregaAlunoA_Click);
            // 
            // BtnGravarA
            // 
            this.BtnGravarA.BackColor = System.Drawing.Color.White;
            this.BtnGravarA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGravarA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnGravarA.Location = new System.Drawing.Point(305, 279);
            this.BtnGravarA.Name = "BtnGravarA";
            this.BtnGravarA.Size = new System.Drawing.Size(79, 41);
            this.BtnGravarA.TabIndex = 5;
            this.BtnGravarA.Text = "Gravar";
            this.BtnGravarA.UseVisualStyleBackColor = false;
            this.BtnGravarA.Click += new System.EventHandler(this.BtnGravarA_Click);
            // 
            // BtnCancelarA
            // 
            this.BtnCancelarA.BackColor = System.Drawing.Color.White;
            this.BtnCancelarA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelarA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnCancelarA.Location = new System.Drawing.Point(475, 279);
            this.BtnCancelarA.Name = "BtnCancelarA";
            this.BtnCancelarA.Size = new System.Drawing.Size(85, 40);
            this.BtnCancelarA.TabIndex = 7;
            this.BtnCancelarA.Text = "Cancelar";
            this.BtnCancelarA.UseVisualStyleBackColor = false;
            this.BtnCancelarA.Click += new System.EventHandler(this.BtnCancelarA_Click);
            // 
            // BtnExcluirA
            // 
            this.BtnExcluirA.BackColor = System.Drawing.Color.White;
            this.BtnExcluirA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluirA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnExcluirA.Location = new System.Drawing.Point(390, 279);
            this.BtnExcluirA.Name = "BtnExcluirA";
            this.BtnExcluirA.Size = new System.Drawing.Size(79, 41);
            this.BtnExcluirA.TabIndex = 6;
            this.BtnExcluirA.Text = "Excluir";
            this.BtnExcluirA.UseVisualStyleBackColor = false;
            this.BtnExcluirA.Click += new System.EventHandler(this.BtnExcluirA_Click);
            // 
            // BtnNovoA
            // 
            this.BtnNovoA.BackColor = System.Drawing.Color.White;
            this.BtnNovoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNovoA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnNovoA.Location = new System.Drawing.Point(220, 279);
            this.BtnNovoA.Name = "BtnNovoA";
            this.BtnNovoA.Size = new System.Drawing.Size(79, 41);
            this.BtnNovoA.TabIndex = 4;
            this.BtnNovoA.Text = "Novo";
            this.BtnNovoA.UseVisualStyleBackColor = false;
            this.BtnNovoA.Click += new System.EventHandler(this.BtnNovoA_Click);
            // 
            // DgvAluno
            // 
            this.DgvAluno.Controls.Add(this.TxtBuscaA);
            this.DgvAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvAluno.Location = new System.Drawing.Point(6, 426);
            this.DgvAluno.Name = "DgvAluno";
            this.DgvAluno.Size = new System.Drawing.Size(436, 66);
            this.DgvAluno.TabIndex = 9;
            this.DgvAluno.TabStop = false;
            this.DgvAluno.Text = "Pesquisa por Aluno";
            // 
            // TxtBuscaA
            // 
            this.TxtBuscaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscaA.Location = new System.Drawing.Point(13, 23);
            this.TxtBuscaA.Name = "TxtBuscaA";
            this.TxtBuscaA.Size = new System.Drawing.Size(407, 29);
            this.TxtBuscaA.TabIndex = 0;
            this.TxtBuscaA.TextChanged += new System.EventHandler(this.TxtBuscaA_TextChanged);
            // 
            // BtnAlterarA
            // 
            this.BtnAlterarA.BackColor = System.Drawing.Color.White;
            this.BtnAlterarA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlterarA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAlterarA.Location = new System.Drawing.Point(445, 439);
            this.BtnAlterarA.Name = "BtnAlterarA";
            this.BtnAlterarA.Size = new System.Drawing.Size(151, 52);
            this.BtnAlterarA.TabIndex = 10;
            this.BtnAlterarA.Text = "Alterar";
            this.BtnAlterarA.UseVisualStyleBackColor = false;
            this.BtnAlterarA.Click += new System.EventHandler(this.BtnAlterarA_Click);
            // 
            // Dgv_Aluno
            // 
            this.Dgv_Aluno.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.Dgv_Aluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Aluno.Location = new System.Drawing.Point(3, 498);
            this.Dgv_Aluno.MultiSelect = false;
            this.Dgv_Aluno.Name = "Dgv_Aluno";
            this.Dgv_Aluno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Aluno.Size = new System.Drawing.Size(593, 210);
            this.Dgv_Aluno.TabIndex = 42;
            this.Dgv_Aluno.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Dgv_Aluno_MouseDoubleClick);
            // 
            // txtEmailAluno
            // 
            this.txtEmailAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailAluno.Location = new System.Drawing.Point(110, 150);
            this.txtEmailAluno.Name = "txtEmailAluno";
            this.txtEmailAluno.Size = new System.Drawing.Size(450, 29);
            this.txtEmailAluno.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 51;
            this.label2.Text = "Curso";
            // 
            // txtCursoAluno
            // 
            this.txtCursoAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCursoAluno.Location = new System.Drawing.Point(110, 190);
            this.txtCursoAluno.Name = "txtCursoAluno";
            this.txtCursoAluno.Size = new System.Drawing.Size(450, 29);
            this.txtCursoAluno.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LivrariaAEDB.Properties.Resources.aedb;
            this.pictureBox1.Location = new System.Drawing.Point(477, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // frmAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtCursoAluno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmailAluno);
            this.Controls.Add(this.BtnCarregaAlunoA);
            this.Controls.Add(this.BtnGravarA);
            this.Controls.Add(this.BtnCancelarA);
            this.Controls.Add(this.BtnExcluirA);
            this.Controls.Add(this.BtnNovoA);
            this.Controls.Add(this.DgvAluno);
            this.Controls.Add(this.BtnAlterarA);
            this.Controls.Add(this.Dgv_Aluno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtNomeAluno);
            this.Controls.Add(this.Lbl_CodA);
            this.Controls.Add(this.lblCodigoA);
            this.Controls.Add(this.lblLivros);
            this.Name = "frmAluno";
            this.Size = new System.Drawing.Size(599, 711);
            this.DgvAluno.ResumeLayout(false);
            this.DgvAluno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Aluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLivros;
        private System.Windows.Forms.Label Lbl_CodA;
        private System.Windows.Forms.Label lblCodigoA;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCarregaAlunoA;
        private System.Windows.Forms.Button BtnGravarA;
        private System.Windows.Forms.Button BtnCancelarA;
        private System.Windows.Forms.Button BtnExcluirA;
        private System.Windows.Forms.Button BtnNovoA;
        private System.Windows.Forms.GroupBox DgvAluno;
        private System.Windows.Forms.TextBox TxtBuscaA;
        private System.Windows.Forms.Button BtnAlterarA;
        private System.Windows.Forms.DataGridView Dgv_Aluno;
        private System.Windows.Forms.TextBox txtEmailAluno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCursoAluno;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
