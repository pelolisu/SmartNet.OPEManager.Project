using GangOfSeven.OPEManager.Application.Forms;
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

namespace LayoutGestaoOPE.Forms
{
    public partial class FrmGrupo : Form
    {
        private int tipoAcao;
        private int codigoGrupo = 0;

        public FrmGrupo()
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

        private void travarCampos(int tipoAcao)
        {
            txtNome.Enabled = (tipoAcao != (int)Acao.nenhum);
            
            btnSalvar.Enabled = (tipoAcao != (int)Acao.nenhum);
            btnCancelar.Enabled = (tipoAcao != (int)Acao.nenhum);
            btnExcluir.Enabled = (tipoAcao != (int)Acao.incluir) && (txtNome.Text.Length > 0);
            btnIncluir.Enabled = (tipoAcao != (int)Acao.alterar);
            btnAlterar.Enabled = (tipoAcao != (int)Acao.incluir && codigoGrupo != 0);
        }

        private void limparCampos()
        {
            txtNome.Clear();
        }

        private void FrmGrupo_Load(object sender, EventArgs e)
        {
            tipoAcao = (int)Acao.nenhum;
            travarCampos(tipoAcao);

            ClsUtil clsUtil = new ClsUtil();
            clsUtil.criarGrid(dgvGrupo);

            apresentarGrupos();
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
            if (MessageBox.Show("Deseja excluir grupo?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {
                    FormGrupo grupoDao = new FormGrupo();
                    grupoDao.excluirGrupo(codigoGrupo);

                    limparCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            apresentarGrupos();
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
            if (txtNome.Text.Length == 0)
            {
                MessageBox.Show("Informe o nome.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

            Grupo grupo = new Grupo();
            FormGrupo grupoDao = new FormGrupo();

            grupo.nome = txtNome.Text;
            grupo.ativo = true;

            try
            {

                if (tipoAcao == (int)Acao.incluir)
                {
                    grupoDao.incluirGrupo(grupo);
                    MessageBox.Show("Grupo salvo com sucesso.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (tipoAcao == (int)Acao.alterar)
                {
                    grupo.grupoId = codigoGrupo;
                    grupoDao.alterarGrupo(grupo);
                    MessageBox.Show("Grupo salvo com sucesso.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            atualizarCampos();
            apresentarGrupos();
            tipoAcao = (int)Acao.nenhum;
            travarCampos(tipoAcao);

        }

        private void apresentarGrupos()
        {
            dgvGrupo.Rows.Clear();

            FormGrupo grupoDao = new FormGrupo();
            ICollection<Grupo> grupos = grupoDao.listarGrupo();

            foreach (Grupo grupo in grupos)
            {
                dgvGrupo.Rows.Add(grupo.grupoId, grupo.nome);
            }
        }

        private void dgvGrupo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow linhaGrupo = dgvGrupo.Rows[e.RowIndex];
            codigoGrupo = int.Parse(linhaGrupo.Cells["Codigo"].Value.ToString());
            atualizarCampos();
            tipoAcao = (int)Acao.nenhum;
            travarCampos(tipoAcao);
        }

        private void atualizarCampos()
        {
            try
            {

                Grupo grupo = new Grupo();
                FormGrupo grupoDao = new FormGrupo();

                if (codigoGrupo != 0)
                {
                    grupo = grupoDao.BuscarPorId(codigoGrupo);

                    txtNome.Text = grupo.nome.ToString();

                }

                tipoAcao = (int)Acao.nenhum;
                travarCampos(tipoAcao);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

}
