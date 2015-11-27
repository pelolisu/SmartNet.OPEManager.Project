namespace LayoutGestaoOPE.Forms
{
    partial class FrmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuario));
            this.pnlCabecalho = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlIcone = new System.Windows.Forms.Panel();
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.gbxPesquisa = new System.Windows.Forms.GroupBox();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.txtPesquisaEmail = new System.Windows.Forms.TextBox();
            this.lblPesquisaEmail = new System.Windows.Forms.Label();
            this.txtPesquisaNome = new System.Windows.Forms.TextBox();
            this.lblPesquisaNome = new System.Windows.Forms.Label();
            this.gbxCadastro = new System.Windows.Forms.GroupBox();
            this.grbTipoPerfil = new System.Windows.Forms.GroupBox();
            this.rbnProfesssor = new System.Windows.Forms.RadioButton();
            this.rbnAluno = new System.Windows.Forms.RadioButton();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.txtRA = new System.Windows.Forms.TextBox();
            this.lblRA = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pnlCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.gbxPesquisa.SuspendLayout();
            this.gbxCadastro.SuspendLayout();
            this.grbTipoPerfil.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCabecalho
            // 
            this.pnlCabecalho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(181)))));
            this.pnlCabecalho.Controls.Add(this.lblTitulo);
            this.pnlCabecalho.Controls.Add(this.pnlIcone);
            this.pnlCabecalho.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecalho.Name = "pnlCabecalho";
            this.pnlCabecalho.Size = new System.Drawing.Size(921, 109);
            this.pnlCabecalho.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(186, 45);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(149, 25);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "Gestão de OPE";
            // 
            // pnlIcone
            // 
            this.pnlIcone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlIcone.BackgroundImage")));
            this.pnlIcone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlIcone.Location = new System.Drawing.Point(3, 6);
            this.pnlIcone.Name = "pnlIcone";
            this.pnlIcone.Size = new System.Drawing.Size(177, 100);
            this.pnlIcone.TabIndex = 0;
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Location = new System.Drawing.Point(0, 259);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.Size = new System.Drawing.Size(335, 383);
            this.dgvUsuario.TabIndex = 7;
            this.dgvUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuario_CellContentClick);
            // 
            // gbxPesquisa
            // 
            this.gbxPesquisa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbxPesquisa.Controls.Add(this.btnUsuario);
            this.gbxPesquisa.Controls.Add(this.txtPesquisaEmail);
            this.gbxPesquisa.Controls.Add(this.lblPesquisaEmail);
            this.gbxPesquisa.Controls.Add(this.txtPesquisaNome);
            this.gbxPesquisa.Controls.Add(this.lblPesquisaNome);
            this.gbxPesquisa.Location = new System.Drawing.Point(0, 109);
            this.gbxPesquisa.Name = "gbxPesquisa";
            this.gbxPesquisa.Size = new System.Drawing.Size(335, 144);
            this.gbxPesquisa.TabIndex = 6;
            this.gbxPesquisa.TabStop = false;
            this.gbxPesquisa.Text = "Pesquisa";
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnUsuario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(92)))));
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.ForeColor = System.Drawing.Color.White;
            this.btnUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuario.Image")));
            this.btnUsuario.Location = new System.Drawing.Point(291, 103);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(38, 33);
            this.btnUsuario.TabIndex = 4;
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // txtPesquisaEmail
            // 
            this.txtPesquisaEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaEmail.Location = new System.Drawing.Point(15, 76);
            this.txtPesquisaEmail.Name = "txtPesquisaEmail";
            this.txtPesquisaEmail.Size = new System.Drawing.Size(314, 21);
            this.txtPesquisaEmail.TabIndex = 3;
            // 
            // lblPesquisaEmail
            // 
            this.lblPesquisaEmail.AutoSize = true;
            this.lblPesquisaEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisaEmail.Location = new System.Drawing.Point(12, 58);
            this.lblPesquisaEmail.Name = "lblPesquisaEmail";
            this.lblPesquisaEmail.Size = new System.Drawing.Size(43, 15);
            this.lblPesquisaEmail.TabIndex = 2;
            this.lblPesquisaEmail.Text = "E-Mail";
            // 
            // txtPesquisaNome
            // 
            this.txtPesquisaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaNome.Location = new System.Drawing.Point(15, 34);
            this.txtPesquisaNome.Name = "txtPesquisaNome";
            this.txtPesquisaNome.Size = new System.Drawing.Size(314, 21);
            this.txtPesquisaNome.TabIndex = 1;
            // 
            // lblPesquisaNome
            // 
            this.lblPesquisaNome.AutoSize = true;
            this.lblPesquisaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisaNome.Location = new System.Drawing.Point(12, 16);
            this.lblPesquisaNome.Name = "lblPesquisaNome";
            this.lblPesquisaNome.Size = new System.Drawing.Size(41, 15);
            this.lblPesquisaNome.TabIndex = 0;
            this.lblPesquisaNome.Text = "Nome";
            // 
            // gbxCadastro
            // 
            this.gbxCadastro.Controls.Add(this.grbTipoPerfil);
            this.gbxCadastro.Controls.Add(this.chkAtivo);
            this.gbxCadastro.Controls.Add(this.txtRA);
            this.gbxCadastro.Controls.Add(this.lblRA);
            this.gbxCadastro.Controls.Add(this.txtSenha);
            this.gbxCadastro.Controls.Add(this.lblSenha);
            this.gbxCadastro.Controls.Add(this.txtEmail);
            this.gbxCadastro.Controls.Add(this.lblEmail);
            this.gbxCadastro.Controls.Add(this.txtNome);
            this.gbxCadastro.Controls.Add(this.lblNome);
            this.gbxCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCadastro.Location = new System.Drawing.Point(341, 109);
            this.gbxCadastro.Name = "gbxCadastro";
            this.gbxCadastro.Size = new System.Drawing.Size(577, 458);
            this.gbxCadastro.TabIndex = 0;
            this.gbxCadastro.TabStop = false;
            this.gbxCadastro.Text = "Cadastro";
            // 
            // grbTipoPerfil
            // 
            this.grbTipoPerfil.Controls.Add(this.rbnProfesssor);
            this.grbTipoPerfil.Controls.Add(this.rbnAluno);
            this.grbTipoPerfil.Location = new System.Drawing.Point(9, 207);
            this.grbTipoPerfil.Name = "grbTipoPerfil";
            this.grbTipoPerfil.Size = new System.Drawing.Size(215, 49);
            this.grbTipoPerfil.TabIndex = 8;
            this.grbTipoPerfil.TabStop = false;
            this.grbTipoPerfil.Text = "Tipo Perfil";
            // 
            // rbnProfesssor
            // 
            this.rbnProfesssor.AutoSize = true;
            this.rbnProfesssor.Location = new System.Drawing.Point(6, 20);
            this.rbnProfesssor.Name = "rbnProfesssor";
            this.rbnProfesssor.Size = new System.Drawing.Size(77, 19);
            this.rbnProfesssor.TabIndex = 0;
            this.rbnProfesssor.TabStop = true;
            this.rbnProfesssor.Text = "Professor";
            this.rbnProfesssor.UseVisualStyleBackColor = true;
            // 
            // rbnAluno
            // 
            this.rbnAluno.AutoSize = true;
            this.rbnAluno.Location = new System.Drawing.Point(89, 20);
            this.rbnAluno.Name = "rbnAluno";
            this.rbnAluno.Size = new System.Drawing.Size(56, 19);
            this.rbnAluno.TabIndex = 1;
            this.rbnAluno.TabStop = true;
            this.rbnAluno.Text = "Aluno";
            this.rbnAluno.UseVisualStyleBackColor = true;
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Location = new System.Drawing.Point(9, 272);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(51, 19);
            this.chkAtivo.TabIndex = 9;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // txtRA
            // 
            this.txtRA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRA.Location = new System.Drawing.Point(9, 35);
            this.txtRA.Name = "txtRA";
            this.txtRA.Size = new System.Drawing.Size(215, 21);
            this.txtRA.TabIndex = 1;
            // 
            // lblRA
            // 
            this.lblRA.AutoSize = true;
            this.lblRA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRA.Location = new System.Drawing.Point(8, 17);
            this.lblRA.Name = "lblRA";
            this.lblRA.Size = new System.Drawing.Size(23, 15);
            this.lblRA.TabIndex = 0;
            this.lblRA.Text = "RA";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(9, 169);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(556, 21);
            this.txtSenha.TabIndex = 7;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(6, 149);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(43, 15);
            this.lblSenha.TabIndex = 6;
            this.lblSenha.Text = "Senha";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(9, 123);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(556, 21);
            this.txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(6, 105);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(43, 15);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "E-Mail";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(9, 77);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(556, 21);
            this.txtNome.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(6, 59);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(41, 15);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // btnIncluir
            // 
            this.btnIncluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnIncluir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnIncluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnIncluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(92)))));
            this.btnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncluir.ForeColor = System.Drawing.Color.White;
            this.btnIncluir.Location = new System.Drawing.Point(341, 587);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(109, 43);
            this.btnIncluir.TabIndex = 1;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = false;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(92)))));
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(456, 587);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(109, 43);
            this.btnAlterar.TabIndex = 2;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(92)))));
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(571, 587);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(109, 43);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(92)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(686, 587);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 43);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(92)))));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(801, 587);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(109, 43);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(918, 642);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.gbxCadastro);
            this.Controls.Add(this.gbxPesquisa);
            this.Controls.Add(this.dgvUsuario);
            this.Controls.Add(this.pnlCabecalho);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuario";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            this.pnlCabecalho.ResumeLayout(false);
            this.pnlCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.gbxPesquisa.ResumeLayout(false);
            this.gbxPesquisa.PerformLayout();
            this.gbxCadastro.ResumeLayout(false);
            this.gbxCadastro.PerformLayout();
            this.grbTipoPerfil.ResumeLayout(false);
            this.grbTipoPerfil.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCabecalho;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlIcone;
        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.GroupBox gbxPesquisa;
        private System.Windows.Forms.TextBox txtPesquisaEmail;
        private System.Windows.Forms.Label lblPesquisaEmail;
        private System.Windows.Forms.TextBox txtPesquisaNome;
        private System.Windows.Forms.Label lblPesquisaNome;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.GroupBox gbxCadastro;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox grbTipoPerfil;
        private System.Windows.Forms.RadioButton rbnProfesssor;
        private System.Windows.Forms.RadioButton rbnAluno;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.TextBox txtRA;
        private System.Windows.Forms.Label lblRA;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
    }
}