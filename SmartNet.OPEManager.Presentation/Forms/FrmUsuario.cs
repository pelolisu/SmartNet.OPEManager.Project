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
        private int codigoUsuario = 0;

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
            tipoAcao = (int)Acao.nenhum;
            travarCampos(tipoAcao);

            ClsUtil clsUtil = new ClsUtil();
            clsUtil.criarGrid(dgvUsuario);

            apresentarUsuarios();
        }

        private void travarCampos(int tipoAcao)
        {
            txtRA.Enabled = (tipoAcao == (int)Acao.incluir);
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
            btnAlterar.Enabled = (tipoAcao != (int)Acao.incluir && codigoUsuario != 0);
        }

        private void limparCampos()
        {
            txtRA.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            chkAtivo.Checked = false;
            rbnProfesssor.Checked = true;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            limparCampos();
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
            if (MessageBox.Show("Deseja excluir usuario?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int RA = int.Parse(txtRA.Text);

                try
                {
                    FormUsuario usuarioDao = new FormUsuario();
                    usuarioDao.excluirUsuario(RA);
                    limparCampos();
                } catch(Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }

            apresentarUsuarios();
            tipoAcao = (int)Acao.nenhum;
            travarCampos(tipoAcao);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            atualizarCampos();
            tipoAcao = (int)Acao.nenhum;
            travarCampos(tipoAcao);
        }

        private Boolean consistir()
        {
            if (txtRA.Text.Length == 0)
            {
                MessageBox.Show("Informe o RA.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (txtNome.Text.Length == 0)
            {
                MessageBox.Show("Informe o nome.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (txtSenha.Text.Length == 0)
            {
                MessageBox.Show("Informe uma senha.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (consistir() == false)
            {
                return;
            }

            Usuario usuario = new Usuario();
            FormUsuario usuarioDao = new FormUsuario();

            usuario.RA = int.Parse(txtRA.Text);
            usuario.nome = txtNome.Text;
            usuario.email = txtEmail.Text;
            usuario.senha = txtSenha.Text;
            usuario.visualizacao = chkAtivo.Checked;
            usuario.ativo = true;
            
            if (rbnProfesssor.Checked)
            {
                usuario.perfil = Usuario.Perfil.Administrador;
            }
            else
            {
                usuario.perfil = Usuario.Perfil.Usuario;
            }

            try
            {

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

            } catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            atualizarCampos();
            apresentarUsuarios();
            tipoAcao = (int)Acao.nenhum;
            travarCampos(tipoAcao);
        }

        private void apresentarUsuarios()
        {
            dgvUsuario.Rows.Clear();

            FormUsuario usuarioDao = new FormUsuario();
            ICollection<Usuario> usuarios = usuarioDao.listarLogin();

            foreach (Usuario usuario in usuarios)
            {
                dgvUsuario.Rows.Add(usuario.RA, usuario.nome);
            }

        }

        private void dgvUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow linhaUsuario = dgvUsuario.Rows[e.RowIndex];
            codigoUsuario = int.Parse(linhaUsuario.Cells["Codigo"].Value.ToString());
            atualizarCampos();
            tipoAcao = (int)Acao.nenhum;
            travarCampos(tipoAcao);
        }

        private void atualizarCampos()
        {
            try
            {

                Usuario usuario = new Usuario();
                FormUsuario usuarioDao = new FormUsuario();

                if(codigoUsuario != 0)
                {
                    usuario = usuarioDao.buscaUsuario(codigoUsuario);

                    txtRA.Text = usuario.RA.ToString();
                    txtNome.Text = usuario.nome.ToString();
                    txtEmail.Text = usuario.email.ToString();
                    txtSenha.Text = usuario.senha.ToString();
                    chkAtivo.Checked = usuario.visualizacao;

                    if (Usuario.Perfil.Administrador == usuario.perfil)
                    {
                        rbnProfesssor.Checked = true;
                    }

                    if (Usuario.Perfil.Usuario == usuario.perfil)
                    {
                        rbnAluno.Checked = true;
                    }

                }
                
                tipoAcao = (int)Acao.nenhum;
                travarCampos(tipoAcao);

            } catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FormUsuario usuarioDao = new FormUsuario();
            
        }
    }
}
