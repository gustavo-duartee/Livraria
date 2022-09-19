namespace LivrariaAEDB
{
    partial class frmMenu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PneMenu = new System.Windows.Forms.Panel();
            this.btnPedido = new System.Windows.Forms.Button();
            this.LblUsuarioLogado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnLivros = new System.Windows.Forms.Button();
            this.BtnCliente = new System.Windows.Forms.Button();
            this.BtnFunc = new System.Windows.Forms.Button();
            this.PneLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.frmPedido1 = new LivrariaAEDB.frmPedido();
            this.frmAtendente1 = new LivrariaAEDB.frmAtendente();
            this.frmAluno1 = new LivrariaAEDB.frmAluno();
            this.principal1 = new LivrariaAEDB.principal();
            this.frmLivros1 = new LivrariaAEDB.frmLivros();
            this.PneMenu.SuspendLayout();
            this.PneLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // PneMenu
            // 
            this.PneMenu.BackColor = System.Drawing.Color.DodgerBlue;
            this.PneMenu.Controls.Add(this.btnPedido);
            this.PneMenu.Controls.Add(this.LblUsuarioLogado);
            this.PneMenu.Controls.Add(this.label2);
            this.PneMenu.Controls.Add(this.BtnSair);
            this.PneMenu.Controls.Add(this.BtnLivros);
            this.PneMenu.Controls.Add(this.BtnCliente);
            this.PneMenu.Controls.Add(this.BtnFunc);
            this.PneMenu.Controls.Add(this.PneLogo);
            this.PneMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PneMenu.Location = new System.Drawing.Point(0, 0);
            this.PneMenu.Name = "PneMenu";
            this.PneMenu.Size = new System.Drawing.Size(279, 710);
            this.PneMenu.TabIndex = 0;
            // 
            // btnPedido
            // 
            this.btnPedido.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPedido.FlatAppearance.BorderSize = 0;
            this.btnPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedido.ForeColor = System.Drawing.Color.White;
            this.btnPedido.Location = new System.Drawing.Point(0, 271);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(279, 59);
            this.btnPedido.TabIndex = 13;
            this.btnPedido.Text = "Pedido";
            this.btnPedido.UseVisualStyleBackColor = true;
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // LblUsuarioLogado
            // 
            this.LblUsuarioLogado.AutoSize = true;
            this.LblUsuarioLogado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuarioLogado.Location = new System.Drawing.Point(152, 674);
            this.LblUsuarioLogado.Name = "LblUsuarioLogado";
            this.LblUsuarioLogado.Size = new System.Drawing.Size(0, 20);
            this.LblUsuarioLogado.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 647);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Usuário Logado:";
            // 
            // BtnSair
            // 
            this.BtnSair.BackColor = System.Drawing.Color.Black;
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.ForeColor = System.Drawing.Color.White;
            this.BtnSair.Location = new System.Drawing.Point(-1, 657);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(98, 54);
            this.BtnSair.TabIndex = 10;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnLivros
            // 
            this.BtnLivros.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnLivros.FlatAppearance.BorderSize = 0;
            this.BtnLivros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLivros.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLivros.ForeColor = System.Drawing.Color.White;
            this.BtnLivros.Location = new System.Drawing.Point(0, 212);
            this.BtnLivros.Name = "BtnLivros";
            this.BtnLivros.Size = new System.Drawing.Size(279, 59);
            this.BtnLivros.TabIndex = 4;
            this.BtnLivros.Text = "Livros";
            this.BtnLivros.UseVisualStyleBackColor = true;
            this.BtnLivros.Click += new System.EventHandler(this.BtnLivros_Click);
            // 
            // BtnCliente
            // 
            this.BtnCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCliente.FlatAppearance.BorderSize = 0;
            this.BtnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCliente.ForeColor = System.Drawing.Color.White;
            this.BtnCliente.Location = new System.Drawing.Point(0, 153);
            this.BtnCliente.Name = "BtnCliente";
            this.BtnCliente.Size = new System.Drawing.Size(279, 59);
            this.BtnCliente.TabIndex = 2;
            this.BtnCliente.Text = "Aluno";
            this.BtnCliente.UseVisualStyleBackColor = true;
            this.BtnCliente.Click += new System.EventHandler(this.BtnCliente_Click);
            // 
            // BtnFunc
            // 
            this.BtnFunc.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnFunc.FlatAppearance.BorderSize = 0;
            this.BtnFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFunc.ForeColor = System.Drawing.Color.White;
            this.BtnFunc.Location = new System.Drawing.Point(0, 94);
            this.BtnFunc.Name = "BtnFunc";
            this.BtnFunc.Size = new System.Drawing.Size(279, 59);
            this.BtnFunc.TabIndex = 1;
            this.BtnFunc.Text = "Funcionário";
            this.BtnFunc.UseVisualStyleBackColor = true;
            this.BtnFunc.Click += new System.EventHandler(this.BtnFunc_Click);
            // 
            // PneLogo
            // 
            this.PneLogo.BackColor = System.Drawing.Color.Black;
            this.PneLogo.Controls.Add(this.label1);
            this.PneLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PneLogo.Location = new System.Drawing.Point(0, 0);
            this.PneLogo.Name = "PneLogo";
            this.PneLogo.Size = new System.Drawing.Size(279, 94);
            this.PneLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "LIVRARIA AEDB";
            // 
            // frmPedido1
            // 
            this.frmPedido1.BackColor = System.Drawing.Color.DodgerBlue;
            this.frmPedido1.Location = new System.Drawing.Point(285, 0);
            this.frmPedido1.Name = "frmPedido1";
            this.frmPedido1.Size = new System.Drawing.Size(599, 711);
            this.frmPedido1.TabIndex = 7;
            // 
            // frmAtendente1
            // 
            this.frmAtendente1.BackColor = System.Drawing.Color.DodgerBlue;
            this.frmAtendente1.Location = new System.Drawing.Point(285, 0);
            this.frmAtendente1.Name = "frmAtendente1";
            this.frmAtendente1.Size = new System.Drawing.Size(599, 711);
            this.frmAtendente1.TabIndex = 6;
            // 
            // frmAluno1
            // 
            this.frmAluno1.BackColor = System.Drawing.Color.DodgerBlue;
            this.frmAluno1.Location = new System.Drawing.Point(285, 0);
            this.frmAluno1.Name = "frmAluno1";
            this.frmAluno1.Size = new System.Drawing.Size(599, 711);
            this.frmAluno1.TabIndex = 5;
            // 
            // principal1
            // 
            this.principal1.BackColor = System.Drawing.Color.White;
            this.principal1.Location = new System.Drawing.Point(287, 0);
            this.principal1.Name = "principal1";
            this.principal1.Size = new System.Drawing.Size(599, 709);
            this.principal1.TabIndex = 1;
            // 
            // frmLivros1
            // 
            this.frmLivros1.BackColor = System.Drawing.Color.DodgerBlue;
            this.frmLivros1.ForeColor = System.Drawing.Color.Black;
            this.frmLivros1.Location = new System.Drawing.Point(287, -1);
            this.frmLivros1.Name = "frmLivros1";
            this.frmLivros1.Size = new System.Drawing.Size(599, 711);
            this.frmLivros1.TabIndex = 3;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(885, 710);
            this.Controls.Add(this.frmPedido1);
            this.Controls.Add(this.frmAtendente1);
            this.Controls.Add(this.frmAluno1);
            this.Controls.Add(this.principal1);
            this.Controls.Add(this.frmLivros1);
            this.Controls.Add(this.PneMenu);
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.PneMenu.ResumeLayout(false);
            this.PneMenu.PerformLayout();
            this.PneLogo.ResumeLayout(false);
            this.PneLogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PneMenu;
        private System.Windows.Forms.Button BtnLivros;
        private System.Windows.Forms.Button BtnCliente;
        private System.Windows.Forms.Button BtnFunc;
        private System.Windows.Forms.Panel PneLogo;
        private principal principal1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Label LblUsuarioLogado;
        private System.Windows.Forms.Label label2;
        private frmLivros frmLivros1;
        private frmAluno frmAluno1;
        private frmAtendente frmAtendente1;
        private System.Windows.Forms.Button btnPedido;
        private frmPedido frmPedido1;
    }
}