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
    public partial class FrmProjeto : Form
    {
        private int tipoAcao;
        private int codigoProjeto = 0;

        public FrmProjeto()
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
            txtTitulo.Enabled = (tipoAcao != (int)Acao.nenhum);
            txtURL.Enabled = (tipoAcao != (int)Acao.nenhum);
            txtDescricao.Enabled = (tipoAcao != (int)Acao.nenhum);

            btnSalvar.Enabled = (tipoAcao != (int)Acao.nenhum);
            btnCancelar.Enabled = (tipoAcao != (int)Acao.nenhum);
            btnExcluir.Enabled = (tipoAcao != (int)Acao.incluir) && (txtTitulo.Text.Length > 0);
            btnIncluir.Enabled = (tipoAcao != (int)Acao.alterar);
            btnAlterar.Enabled = (tipoAcao != (int)Acao.incluir && codigoProjeto != 0);
        }

        private void limparCampos()
        {
            txtTitulo.Clear();
            txtURL.Clear();
            txtDescricao.Clear();
        }

        private void FrmProjeto_Load(object sender, EventArgs e)
        {
            tipoAcao = (int)Acao.nenhum;
            travarCampos(tipoAcao);

            ClsUtil clsUtil = new ClsUtil();
            clsUtil.criarGrid(dgvProjeto);

            //apresentarSemestre();
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
            if (MessageBox.Show("Deseja excluir projeto?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {
                    //FormTurma turmaDao = new FormTurma();
                    //turmaDao.excluirTurma(codigoTurma);
                    limparCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            //apresentarUsuarios();
            tipoAcao = (int)Acao.nenhum;
            travarCampos(tipoAcao);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //atualizarCampos();
            tipoAcao = (int)Acao.nenhum;
            travarCampos(tipoAcao);
        }

        private Boolean consistir()
        {
            if (txtTitulo.Text.Length == 0)
            {
                MessageBox.Show("Informe o titulo.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (txtURL.Text.Length == 0)
            {
                MessageBox.Show("Informe a URL.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (txtDescricao.Text.Length == 0)
            {
                MessageBox.Show("Informe a Descrição.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            try
            {

            } catch(Exception ex)
            {

            }

            //atualizarCampos();
            //apresentarSemestre();
            tipoAcao = (int)Acao.nenhum;
            travarCampos(tipoAcao);
        }

        private void apresentarProjetos()
        {
            dgvProjeto.Rows.Clear();

            //FormProjeto semestreDao = new FormProjeto();
            //ICollection<Semestre> semestres = semestreDao.listarSemestre();

            /*foreach (Semestre semestre in semestres)
            {
                dgvSemestre.Rows.Add(semestre.semestreId, semestre.nome);
            }*/

        }

    }
}
