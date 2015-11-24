using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartNet.OPEManager.Domain.Entities;
using GangOfSeven.OPEManager.Application.Forms;

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
            rbnProfesssor.Checked = true;
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
            if(MessageBox.Show("Deseja excluir usuario?", this.Text, MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int RA = int.Parse(txtRA.Text);

                FormUsuario usuarioDao = new FormUsuario();
                usuarioDao.excluirUsuario(RA);
            }

            tipoAcao = (int)Acao.nenhum;
            travarCampos(tipoAcao);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tipoAcao = (int)Acao.nenhum;
            travarCampos(tipoAcao);
        }

        private Boolean consistir()
        {
            if(txtRA.Text.Length == 0)
            {
                MessageBox.Show("Informe o RA.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if(txtNome.Text.Length == 0)
            {
                MessageBox.Show("Informe o nome.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if(txtSenha.Text.Length == 0)
            {
                MessageBox.Show("Informe uma senha.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            
            return true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if(consistir() == false)
            {
                return;
            }

            Usuario usuario = new Usuario();
            FormUsuario usuarioDao = new FormUsuario();

            usuario.RA = int.Parse(txtRA.Text);
            usuario.nome = txtNome.Text;
            usuario.email = txtEmail.Text;
            usuario.senha = txtSenha.Text;
            usuario.ativo = chkAtivo.Checked;

            //usuario.P

            //usuario.perfil = 1;

            if (tipoAcao == (int)Acao.incluir)
            {
                usuarioDao.incluirUsuario(usuario);
                MessageBox.Show("Usuario salvo com sucesso.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (tipoAcao == (int)Acao.alterar)
            {
                usuarioDao.alterarUsuario(usuario);
                MessageBox.Show("Usuario alterado com sucesso.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            tipoAcao = (int)Acao.nenhum;
            travarCampos(tipoAcao);
        }
    }
}
