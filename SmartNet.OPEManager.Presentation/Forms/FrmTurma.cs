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
    public partial class FrmTurma : Form
    {
        private int tipoAcao;
        private int codigoTurma = 0;

        public FrmTurma()
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
            btnAlterar.Enabled = (tipoAcao != (int)Acao.incluir && codigoTurma != 0);
        }

        private void limparCampos()
        {
            txtNome.Clear();
        }

        private void FrmTurma_Load(object sender, EventArgs e)
        {
            tipoAcao = (int)Acao.nenhum;
            travarCampos(tipoAcao);

            ClsUtil clsUtil = new ClsUtil();
            clsUtil.criarGrid(dgvTurmas);

            apresentarTurma();
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

            if (MessageBox.Show("Deseja excluir turma?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //int RA = int.Parse(txtRA.Text);
                
                try
                {
                    FormTurma turmaDao = new FormTurma();
                    turmaDao.excluirTurma(codigoTurma);
                    limparCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            apresentarTurma();
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
                MessageBox.Show("Informe a turma.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

            Turma turma = new Turma();
            FormTurma turmaDao = new FormTurma();
            
            turma.nome = txtNome.Text;
            turma.ativo = true;

            try
            {

                if (tipoAcao == (int)Acao.incluir)
                {
                    turmaDao.incluirTurma(turma);
                    MessageBox.Show("Usuario salvo com sucesso.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (tipoAcao == (int)Acao.alterar)
                {
                    turma.turmaId = codigoTurma;
                    turmaDao.alterarTurma(turma);
                    MessageBox.Show("Usuario alterado com sucesso.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            } catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            atualizarCampos();
            apresentarTurma();
            tipoAcao = (int)Acao.nenhum;
            travarCampos(tipoAcao);

        }

        private void apresentarTurma()
        {
            FormTurma turmaDao = new FormTurma();
            ICollection<Turma> turmas = turmaDao.listarTurmas();

            carregarTurma(turmas);
        }

        private void carregarTurma(ICollection<Turma> turmas)
        {
            dgvTurmas.Rows.Clear();

            foreach (Turma turma in turmas)
            {
                dgvTurmas.Rows.Add(turma.turmaId, turma.nome);
            }
        }

        private void dgvTurma_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow linhaTurma = dgvTurmas.Rows[e.RowIndex];
            codigoTurma = int.Parse(linhaTurma.Cells["Codigo"].Value.ToString());
            atualizarCampos();
            tipoAcao = (int)Acao.nenhum;
            travarCampos(tipoAcao);
        }

        private void atualizarCampos()
        {
            try
            {

                Turma turma = new Turma();
                FormTurma turmaDao = new FormTurma();

                if(codigoTurma != 0)
                {
                    turma = turmaDao.buscaTurma(codigoTurma);
                    txtNome.Text = turma.nome.ToString();
                }

                tipoAcao = (int)Acao.nenhum;
                travarCampos(tipoAcao);

            } catch(Exception  ex)
            {
                MessageBox.Show("Erro: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FormTurma turmaDao = new FormTurma();
            ICollection<Turma> turmas = turmaDao.buscaNomeTurma(txtPesquisaNome.Text);

            carregarTurma(turmas);
        }
    }
}
