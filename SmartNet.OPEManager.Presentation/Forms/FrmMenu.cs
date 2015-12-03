using LayoutGestaoOPE.Forms;
using SmartNet.OPEManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LayoutGestaoOPE
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        public static Usuario usuario;

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuario frmUsuario = new FrmUsuario();
            frmUsuario.ShowDialog();
        }

        private void btnCadastroCurso_Click(object sender, EventArgs e)
        {
            FrmCurso frmCurso = new FrmCurso();
            frmCurso.ShowDialog();
        }

        private void btnCadastroGrupo_Click(object sender, EventArgs e)
        {
            FrmGrupo frmGrupo = new FrmGrupo();
            frmGrupo.ShowDialog();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            if(usuario.perfil != Usuario.Perfil.Administrador)
            {
                btnCadatroProjeto.Visible = false;
                btnAgendamento.Visible = false;
            }
        }

        private void btnAgendamento_Click(object sender, EventArgs e)
        {
            FrmAgendamento frmAgendamento = new FrmAgendamento();
            frmAgendamento.ShowDialog();
        }

        private void btnCadatroProjeto_Click(object sender, EventArgs e)
        {
            FrmProjeto frmProjeto = new FrmProjeto();
            frmProjeto.ShowDialog();
        }

        private void btnSemestre_Click(object sender, EventArgs e)
        {
            FrmSemestre frmSemestre = new FrmSemestre();
            frmSemestre.ShowDialog();
        }

        private void btnTurma_Click(object sender, EventArgs e)
        {
            FrmTurma frmTurma = new FrmTurma();
            frmTurma.ShowDialog();
        }
    }
}
