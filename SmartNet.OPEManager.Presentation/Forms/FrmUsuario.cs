using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LayoutGestaoOPE.Forms
{
    public partial class FrmUsuario : Form
    {
        private int tipoAcao;

        public FrmUsuario()
        {
            InitializeComponent();
        }

        public enum Acao
        {
            nenhum,
            incluir,
            alterar,
            excluir
        }
        
        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            tipoAcao = (int) Acao.nenhum;
            travarCampos(tipoAcao);
        }
        
        private void travarCampos(int tipoAcao)
        {
            txtRA.Enabled = (tipoAcao != (int) Acao.nenhum);
            txtNome.Enabled = (tipoAcao != (int)Acao.nenhum);
            txtEmail.Enabled = (tipoAcao != (int)Acao.nenhum);
            txtSenha.Enabled = (tipoAcao != (int)Acao.nenhum);
            rbnProfesssor.Enabled = (tipoAcao != (int)Acao.nenhum);
            rbnAluno.Enabled = (tipoAcao != (int)Acao.nenhum);
            chkAtivo.Enabled = (tipoAcao != (int)Acao.nenhum);

            btnSalvar.Enabled = (tipoAcao != (int)Acao.nenhum);
            btnCancelar.Enabled = (tipoAcao != (int)Acao.nenhum);
            btnExcluir.Enabled = (tipoAcao != (int)Acao.incluir) && (txtNome.Text.Length > 0);
            btnIncluir.Enabled = (tipoAcao != (int)Acao.alterar);
            btnAlterar.Enabled = (tipoAcao != (int)Acao.incluir);

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            tipoAcao = (int)Acao.incluir;
            travarCampos(tipoAcao);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            tipoAcao = (int)Acao.alterar;
            travarCampos(tipoAcao);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tipoAcao = (int)Acao.nenhum;
            travarCampos(tipoAcao);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            tipoAcao = (int)Acao.nenhum;
            travarCampos(tipoAcao);
        }
    }
}
