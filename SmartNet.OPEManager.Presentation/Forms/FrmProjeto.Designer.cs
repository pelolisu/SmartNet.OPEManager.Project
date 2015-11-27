namespace LayoutGestaoOPE.Forms
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
            this.btnUsuario = new System.Windows.Forms.Button();
            this.txtPesquisaNome = new System.Windows.Forms.TextBox();
            this.lblPesquisaNome = new System.Windows.Forms.Label();
            this.txtDescricaoPesquisa = new System.Windows.Forms.TextBox();
            this.lblDescricaoPesquisa = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbxCadastro = new System.Windows.Forms.GroupBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblTituloOpe = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.lblURL = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.pnlCabecalho.SuspendLayout();
            this.gbxPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.btnUsuario.TabIndex = 5;
            this.btnUsuario.UseVisualStyleBackColor = false;
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
            // txtDescricaoPesquisa
            // 
            this.txtDescricaoPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoPesquisa.Location = new System.Drawing.Point(15, 76);
            this.txtDescricaoPesquisa.Name = "txtDescricaoPesquisa";
            this.txtDescricaoPesquisa.Size = new System.Drawing.Size(314, 21);
            this.txtDescricaoPesquisa.TabIndex = 7;
            // 
            // lblDescricaoPesquisa
            // 
            this.lblDescricaoPesquisa.AutoSize = true;
            this.lblDescricaoPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaoPesquisa.Location = new System.Drawing.Point(12, 58);
            this.lblDescricaoPesquisa.Name = "lblDescricaoPesquisa";
            this.lblDescricaoPesquisa.Size = new System.Drawing.Size(62, 15);
            this.lblDescricaoPesquisa.TabIndex = 6;
            this.lblDescricaoPesquisa.Text = "Descrição";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 260);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(335, 383);
            this.dataGridView1.TabIndex = 7;
            // 
            // gbxCadastro
            // 
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
            this.gbxCadastro.TabIndex = 17;
            this.gbxCadastro.TabStop = false;
            this.gbxCadastro.Text = "Cadastro";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(6, 35);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(556, 21);
            this.txtTitulo.TabIndex = 6;
            // 
            // lblTituloOpe
            // 
            this.lblTituloOpe.AutoSize = true;
            this.lblTituloOpe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloOpe.Location = new System.Drawing.Point(6, 17);
            this.lblTituloOpe.Name = "lblTituloOpe";
            this.lblTituloOpe.Size = new System.Drawing.Size(37, 15);
            this.lblTituloOpe.TabIndex = 6;
            this.lblTituloOpe.Text = "Titulo";
            // 
            // txtURL
            // 
            this.txtURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURL.Location = new System.Drawing.Point(6, 77);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(556, 21);
            this.txtURL.TabIndex = 14;
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblURL.Location = new System.Drawing.Point(6, 59);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(32, 15);
            this.lblURL.TabIndex = 15;
            this.lblURL.Text = "URL";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(6, 123);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(556, 126);
            this.txtDescricao.TabIndex = 16;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(6, 104);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(62, 15);
            this.lblDescricao.TabIndex = 17;
            this.lblDescricao.Text = "Descricao";
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
            this.btnSalvar.TabIndex = 22;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
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
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
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
            this.btnExcluir.TabIndex = 20;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
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
            this.btnAlterar.TabIndex = 19;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
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
            this.btnIncluir.TabIndex = 18;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = false;
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
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbxPesquisa);
            this.Controls.Add(this.pnlCabecalho);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmProjeto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProjeto";
            this.pnlCabecalho.ResumeLayout(false);
            this.pnlCabecalho.PerformLayout();
            this.gbxPesquisa.ResumeLayout(false);
            this.gbxPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
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
    }
}