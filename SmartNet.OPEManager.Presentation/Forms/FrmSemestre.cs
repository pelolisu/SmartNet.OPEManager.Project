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
    public partial class FrmSemestre : Form
    {
        private int tipoAcao;
        private int codigoSemestre = 0;

        public FrmSemestre()
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
            btnAlterar.Enabled = (tipoAcao != (int)Acao.incluir && codigoSemestre != 0);
        }

        private void limparCampos()
        {
            txtNome.Clear();
        }

        private void FrmSemestre_Load(object sender, EventArgs e)
        {
            tipoAcao = (int)Acao.nenhum;
            travarCampos(tipoAcao);

            ClsUtil clsUtil = new ClsUtil();
            clsUtil.criarGrid(dgvSemestre);

            apresentarSemestre();
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
            if (MessageBox.Show("Deseja excluir semestre?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {
                    FormSemestre semestreDao = new FormSemestre();
                    semestreDao.excluirSemestre(codigoSemestre);
                    limparCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            apresentarSemestre();
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

            Semestre semestre = new Semestre();
            FormSemestre semestreDao = new FormSemestre();

            semestre.nome = txtNome.Text;
            semestre.ativo = true;

            try
            {

                if (tipoAcao == (int)Acao.incluir)
                {
                    semestreDao.incluirSemestre(semestre);
                    MessageBox.Show("Usuario salvo com sucesso.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (tipoAcao == (int)Acao.alterar)
                {
                    semestre.semestreId = codigoSemestre;
                    semestreDao.alterarSemestre(semestre);
                    MessageBox.Show("Usuario alterado com sucesso.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            atualizarCampos();
            apresentarSemestre();
            tipoAcao = (int)Acao.nenhum;
            travarCampos(tipoAcao);
        }

        private void apresentarSemestre()
        {
            dgvSemestre.Rows.Clear();

            FormSemestre semestreDao = new FormSemestre();
            ICollection<Semestre> semestres = semestreDao.listarSemestre();

            foreach(Semestre semestre in semestres)
            {
                dgvSemestre.Rows.Add(semestre.semestreId, semestre.nome);
            }

        }

        private void dgvSemestre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow linhaTurma = dgvSemestre.Rows[e.RowIndex];
            codigoSemestre = int.Parse(linhaTurma.Cells["Codigo"].Value.ToString());
            atualizarCampos();
            tipoAcao = (int)Acao.nenhum;
            travarCampos(tipoAcao);
        }

        private void atualizarCampos()
        {
            try
            {

                Semestre semestre = new Semestre();
                FormSemestre semestreDao = new FormSemestre();

                if (codigoSemestre != 0)
                {
                    semestre = semestreDao.buscaSemestre(codigoSemestre);
                    txtNome.Text = semestre.nome.ToString();
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
