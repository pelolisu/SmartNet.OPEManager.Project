﻿namespace LayoutGestaoOPE.Forms
{
    partial class FrmProjeto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProjeto));
            this.pnlCabecalho = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlIcone = new System.Windows.Forms.Panel();
            this.gbxPesquisa = new System.Windows.Forms.GroupBox();
            this.txtDescricaoPesquisa = new System.Windows.Forms.TextBox();
            this.lblDescricaoPesquisa = new System.Windows.Forms.Label();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.txtPesquisaNome = new System.Windows.Forms.TextBox();
            this.lblPesquisaNome = new System.Windows.Forms.Label();
            this.dgvProjeto = new System.Windows.Forms.DataGridView();
            this.gbxCadastro = new System.Windows.Forms.GroupBox();
            this.cboTurma = new System.Windows.Forms.ComboBox();
            this.lblTurma = new System.Windows.Forms.Label();
            this.cboSemestre = new System.Windows.Forms.ComboBox();
            this.lblSemestre = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.cboCurso = new System.Windows.Forms.ComboBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.cboGrupo = new System.Windows.Forms.ComboBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.lblURL = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblTituloOpe = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.pnlCabecalho.SuspendLayout();
            this.gbxPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjeto)).BeginInit();
            this.gbxCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCabecalho
            // 
            this.pnlCabecalho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(181)))));
            this.pnlCabecalho.Controls.Add(this.lblTitulo);
            this.pnlCabecalho.Controls.Add(this.pnlIcone);
            this.pnlCabecalho.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecalho.Name = "pnlCabecalho";
            this.pnlCabecalho.Size = new System.Drawing.Size(918, 109);
            this.pnlCabecalho.TabIndex = 3;
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
            // gbxPesquisa
            // 
            this.gbxPesquisa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbxPesquisa.Controls.Add(this.txtDescricaoPesquisa);
            this.gbxPesquisa.Controls.Add(this.lblDescricaoPesquisa);
            this.gbxPesquisa.Controls.Add(this.btnUsuario);
            this.gbxPesquisa.Controls.Add(this.txtPesquisaNome);
            this.gbxPesquisa.Controls.Add(this.lblPesquisaNome);
            this.gbxPesquisa.Location = new System.Drawing.Point(0, 111);
            this.gbxPesquisa.Name = "gbxPesquisa";
            this.gbxPesquisa.Size = new System.Drawing.Size(335, 143);
            this.gbxPesquisa.TabIndex = 6;
            this.gbxPesquisa.TabStop = false;
            this.gbxPesquisa.Text = "Pesquisa";
            // 
            // txtDescricaoPesquisa
            // 
            this.txtDescricaoPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoPesquisa.Location = new System.Drawing.Point(15, 76);
            this.txtDescricaoPesquisa.Name = "txtDescricaoPesquisa";
            this.txtDescricaoPesquisa.Size = new System.Drawing.Size(314, 21);
            this.txtDescricaoPesquisa.TabIndex = 3;
            // 
            // lblDescricaoPesquisa
            // 
            this.lblDescricaoPesquisa.AutoSize = true;
            this.lblDescricaoPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaoPesquisa.Location = new System.Drawing.Point(12, 58);
            this.lblDescricaoPesquisa.Name = "lblDescricaoPesquisa";
            this.lblDescricaoPesquisa.Size = new System.Drawing.Size(62, 15);
            this.lblDescricaoPesquisa.TabIndex = 2;
            this.lblDescricaoPesquisa.Text = "Descrição";
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
            this.lblPesquisaNome.Size = new System.Drawing.Size(37, 15);
            this.lblPesquisaNome.TabIndex = 0;
            this.lblPesquisaNome.Text = "Titulo";
            // 
            // dgvProjeto
            // 
            this.dgvProjeto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjeto.Location = new System.Drawing.Point(0, 260);
            this.dgvProjeto.Name = "dgvProjeto";
            this.dgvProjeto.Size = new System.Drawing.Size(335, 383);
            this.dgvProjeto.TabIndex = 7;
            this.dgvProjeto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProjeto_CellContentClick);
            // 
            // gbxCadastro
            // 
            this.gbxCadastro.Controls.Add(this.cboTurma);
            this.gbxCadastro.Controls.Add(this.lblTurma);
            this.gbxCadastro.Controls.Add(this.cboSemestre);
            this.gbxCadastro.Controls.Add(this.lblSemestre);
            this.gbxCadastro.Controls.Add(this.txtEmpresa);
            this.gbxCadastro.Controls.Add(this.lblEmpresa);
            this.gbxCadastro.Controls.Add(this.cboCurso);
            this.gbxCadastro.Controls.Add(this.lblCurso);
            this.gbxCadastro.Controls.Add(this.lblGrupo);
            this.gbxCadastro.Controls.Add(this.cboGrupo);
            this.gbxCadastro.Controls.Add(this.txtDescricao);
            this.gbxCadastro.Controls.Add(this.lblDescricao);
            this.gbxCadastro.Controls.Add(this.txtURL);
            this.gbxCadastro.Controls.Add(this.lblURL);
            this.gbxCadastro.Controls.Add(this.txtTitulo);
            this.gbxCadastro.Controls.Add(this.lblTituloOpe);
            this.gbxCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCadastro.Location = new System.Drawing.Point(342, 110);
            this.gbxCadastro.Name = "gbxCadastro";
            this.gbxCadastro.Size = new System.Drawing.Size(576, 463);
            this.gbxCadastro.TabIndex = 0;
            this.gbxCadastro.TabStop = false;
            this.gbxCadastro.Text = "Cadastro";
            // 
            // cboTurma
            // 
            this.cboTurma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTurma.FormattingEnabled = true;
            this.cboTurma.Location = new System.Drawing.Point(6, 293);
            this.cboTurma.Name = "cboTurma";
            this.cboTurma.Size = new System.Drawing.Size(556, 23);
            this.cboTurma.TabIndex = 13;
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurma.Location = new System.Drawing.Point(6, 275);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(43, 15);
            this.lblTurma.TabIndex = 12;
            this.lblTurma.Text = "Turma";
            // 
            // cboSemestre
            // 
            this.cboSemestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSemestre.FormattingEnabled = true;
            this.cboSemestre.Location = new System.Drawing.Point(6, 249);
            this.cboSemestre.Name = "cboSemestre";
            this.cboSemestre.Size = new System.Drawing.Size(556, 23);
            this.cboSemestre.TabIndex = 11;
            // 
            // lblSemestre
            // 
            this.lblSemestre.AutoSize = true;
            this.lblSemestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemestre.Location = new System.Drawing.Point(6, 231);
            this.lblSemestre.Name = "lblSemestre";
            this.lblSemestre.Size = new System.Drawing.Size(60, 15);
            this.lblSemestre.TabIndex = 10;
            this.lblSemestre.Text = "Semestre";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpresa.Location = new System.Drawing.Point(6, 119);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(556, 21);
            this.txtEmpresa.TabIndex = 5;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.Location = new System.Drawing.Point(6, 101);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(57, 15);
            this.lblEmpresa.TabIndex = 4;
            this.lblEmpresa.Text = "Empresa";
            // 
            // cboCurso
            // 
            this.cboCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCurso.FormattingEnabled = true;
            this.cboCurso.Location = new System.Drawing.Point(6, 205);
            this.cboCurso.Name = "cboCurso";
            this.cboCurso.Size = new System.Drawing.Size(556, 23);
            this.cboCurso.TabIndex = 9;
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.Location = new System.Drawing.Point(6, 187);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(39, 15);
            this.lblCurso.TabIndex = 8;
            this.lblCurso.Text = "Curso";
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupo.Location = new System.Drawing.Point(6, 143);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(41, 15);
            this.lblGrupo.TabIndex = 6;
            this.lblGrupo.Text = "Grupo";
            // 
            // cboGrupo
            // 
            this.cboGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrupo.FormattingEnabled = true;
            this.cboGrupo.Location = new System.Drawing.Point(6, 161);
            this.cboGrupo.Name = "cboGrupo";
            this.cboGrupo.Size = new System.Drawing.Size(556, 23);
            this.cboGrupo.TabIndex = 7;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(9, 337);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(556, 111);
            this.txtDescricao.TabIndex = 15;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(6, 319);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(62, 15);
            this.lblDescricao.TabIndex = 14;
            this.lblDescricao.Text = "Descricao";
            // 
            // txtURL
            // 
            this.txtURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURL.Location = new System.Drawing.Point(6, 77);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(556, 21);
            this.txtURL.TabIndex = 3;
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblURL.Location = new System.Drawing.Point(6, 59);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(32, 15);
            this.lblURL.TabIndex = 2;
            this.lblURL.Text = "URL";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(6, 35);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(556, 21);
            this.txtTitulo.TabIndex = 1;
            // 
            // lblTituloOpe
            // 
            this.lblTituloOpe.AutoSize = true;
            this.lblTituloOpe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloOpe.Location = new System.Drawing.Point(6, 17);
            this.lblTituloOpe.Name = "lblTituloOpe";
            this.lblTituloOpe.Size = new System.Drawing.Size(37, 15);
            this.lblTituloOpe.TabIndex = 0;
            this.lblTituloOpe.Text = "Titulo";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(92)))));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(806, 587);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(109, 43);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(92)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(691, 587);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 43);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(92)))));
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(576, 587);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(109, 43);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(92)))));
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(461, 587);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(109, 43);
            this.btnAlterar.TabIndex = 2;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnIncluir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnIncluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnIncluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(92)))));
            this.btnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncluir.ForeColor = System.Drawing.Color.White;
            this.btnIncluir.Location = new System.Drawing.Point(346, 587);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(109, 43);
            this.btnIncluir.TabIndex = 1;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = false;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // FrmProjeto
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
            this.Controls.Add(this.dgvProjeto);
            this.Controls.Add(this.gbxPesquisa);
            this.Controls.Add(this.pnlCabecalho);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmProjeto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProjeto";
            this.Load += new System.EventHandler(this.FrmProjeto_Load);
            this.pnlCabecalho.ResumeLayout(false);
            this.pnlCabecalho.PerformLayout();
            this.gbxPesquisa.ResumeLayout(false);
            this.gbxPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjeto)).EndInit();
            this.gbxCadastro.ResumeLayout(false);
            this.gbxCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCabecalho;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlIcone;
        private System.Windows.Forms.GroupBox gbxPesquisa;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.TextBox txtPesquisaNome;
        private System.Windows.Forms.Label lblPesquisaNome;
        private System.Windows.Forms.TextBox txtDescricaoPesquisa;
        private System.Windows.Forms.Label lblDescricaoPesquisa;
        private System.Windows.Forms.DataGridView dgvProjeto;
        private System.Windows.Forms.GroupBox gbxCadastro;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblTituloOpe;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.ComboBox cboCurso;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.ComboBox cboGrupo;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.ComboBox cboTurma;
        private System.Windows.Forms.Label lblTurma;
        private System.Windows.Forms.ComboBox cboSemestre;
        private System.Windows.Forms.Label lblSemestre;
    }
}