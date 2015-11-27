namespace LayoutGestaoOPE
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.pnlCabecalho = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlIcone = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCadastroGrupo = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnCadastroCurso = new System.Windows.Forms.Button();
            this.btnCadatroProjeto = new System.Windows.Forms.Button();
            this.btnAgendamento = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnSemestre = new System.Windows.Forms.Button();
            this.btnTurma = new System.Windows.Forms.Button();
            this.pnlCabecalho.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCabecalho
            // 
            this.pnlCabecalho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(181)))));
            this.pnlCabecalho.Controls.Add(this.lblTitulo);
            this.pnlCabecalho.Controls.Add(this.pnlIcone);
            this.pnlCabecalho.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecalho.Name = "pnlCabecalho";
            this.pnlCabecalho.Size = new System.Drawing.Size(916, 109);
            this.pnlCabecalho.TabIndex = 0;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(181)))));
            this.panel1.Controls.Add(this.btnTurma);
            this.panel1.Controls.Add(this.btnSemestre);
            this.panel1.Controls.Add(this.btnCadastroGrupo);
            this.panel1.Controls.Add(this.btnUsuario);
            this.panel1.Controls.Add(this.btnCadastroCurso);
            this.panel1.Controls.Add(this.btnCadatroProjeto);
            this.panel1.Controls.Add(this.btnAgendamento);
            this.panel1.Location = new System.Drawing.Point(0, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 586);
            this.panel1.TabIndex = 1;
            // 
            // btnCadastroGrupo
            // 
            this.btnCadastroGrupo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnCadastroGrupo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnCadastroGrupo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnCadastroGrupo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(92)))));
            this.btnCadastroGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroGrupo.ForeColor = System.Drawing.Color.White;
            this.btnCadastroGrupo.Location = new System.Drawing.Point(0, 117);
            this.btnCadastroGrupo.Name = "btnCadastroGrupo";
            this.btnCadastroGrupo.Size = new System.Drawing.Size(180, 33);
            this.btnCadastroGrupo.TabIndex = 10;
            this.btnCadastroGrupo.Text = "Cadastro de Grupo";
            this.btnCadastroGrupo.UseVisualStyleBackColor = false;
            this.btnCadastroGrupo.Click += new System.EventHandler(this.btnCadastroGrupo_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnUsuario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(92)))));
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.ForeColor = System.Drawing.Color.White;
            this.btnUsuario.Location = new System.Drawing.Point(0, 0);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(180, 33);
            this.btnUsuario.TabIndex = 4;
            this.btnUsuario.Text = "Cadastro de Usuarios";
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnCadastroCurso
            // 
            this.btnCadastroCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnCadastroCurso.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnCadastroCurso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnCadastroCurso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(92)))));
            this.btnCadastroCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroCurso.ForeColor = System.Drawing.Color.White;
            this.btnCadastroCurso.Location = new System.Drawing.Point(0, 78);
            this.btnCadastroCurso.Name = "btnCadastroCurso";
            this.btnCadastroCurso.Size = new System.Drawing.Size(180, 33);
            this.btnCadastroCurso.TabIndex = 9;
            this.btnCadastroCurso.Text = "Cadastro de Cursos";
            this.btnCadastroCurso.UseVisualStyleBackColor = false;
            this.btnCadastroCurso.Click += new System.EventHandler(this.btnCadastroCurso_Click);
            // 
            // btnCadatroProjeto
            // 
            this.btnCadatroProjeto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnCadatroProjeto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnCadatroProjeto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnCadatroProjeto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(92)))));
            this.btnCadatroProjeto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadatroProjeto.ForeColor = System.Drawing.Color.White;
            this.btnCadatroProjeto.Location = new System.Drawing.Point(0, 39);
            this.btnCadatroProjeto.Name = "btnCadatroProjeto";
            this.btnCadatroProjeto.Size = new System.Drawing.Size(180, 33);
            this.btnCadatroProjeto.TabIndex = 8;
            this.btnCadatroProjeto.Text = "Cadastro de Projeto";
            this.btnCadatroProjeto.UseVisualStyleBackColor = false;
            this.btnCadatroProjeto.Click += new System.EventHandler(this.btnCadatroProjeto_Click);
            // 
            // btnAgendamento
            // 
            this.btnAgendamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnAgendamento.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnAgendamento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAgendamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(92)))));
            this.btnAgendamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendamento.ForeColor = System.Drawing.Color.White;
            this.btnAgendamento.Location = new System.Drawing.Point(0, 234);
            this.btnAgendamento.Name = "btnAgendamento";
            this.btnAgendamento.Size = new System.Drawing.Size(180, 33);
            this.btnAgendamento.TabIndex = 7;
            this.btnAgendamento.Text = "Agendamento";
            this.btnAgendamento.UseVisualStyleBackColor = false;
            this.btnAgendamento.Click += new System.EventHandler(this.btnAgendamento_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(3, 3);
            this.monthCalendar1.Location = new System.Drawing.Point(207, 121);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // btnSemestre
            // 
            this.btnSemestre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnSemestre.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnSemestre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnSemestre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(92)))));
            this.btnSemestre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSemestre.ForeColor = System.Drawing.Color.White;
            this.btnSemestre.Location = new System.Drawing.Point(0, 156);
            this.btnSemestre.Name = "btnSemestre";
            this.btnSemestre.Size = new System.Drawing.Size(180, 33);
            this.btnSemestre.TabIndex = 11;
            this.btnSemestre.Text = "Cadastro de Semestre";
            this.btnSemestre.UseVisualStyleBackColor = false;
            this.btnSemestre.Click += new System.EventHandler(this.btnSemestre_Click);
            // 
            // btnTurma
            // 
            this.btnTurma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnTurma.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnTurma.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnTurma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(70)))), ((int)(((byte)(92)))));
            this.btnTurma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTurma.ForeColor = System.Drawing.Color.White;
            this.btnTurma.Location = new System.Drawing.Point(0, 195);
            this.btnTurma.Name = "btnTurma";
            this.btnTurma.Size = new System.Drawing.Size(180, 33);
            this.btnTurma.TabIndex = 12;
            this.btnTurma.Text = "Cadastro de Turma";
            this.btnTurma.UseVisualStyleBackColor = false;
            this.btnTurma.Click += new System.EventHandler(this.btnTurma_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(914, 689);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.pnlCabecalho.ResumeLayout(false);
            this.pnlCabecalho.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCabecalho;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnCadastroGrupo;
        private System.Windows.Forms.Button btnCadastroCurso;
        private System.Windows.Forms.Button btnCadatroProjeto;
        private System.Windows.Forms.Button btnAgendamento;
        private System.Windows.Forms.Panel pnlIcone;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnTurma;
        private System.Windows.Forms.Button btnSemestre;
    }
}

