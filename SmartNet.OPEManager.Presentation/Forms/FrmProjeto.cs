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
            txtEmpresa.Enabled = (tipoAcao != (int)Acao.nenhum);

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
            txtEmpresa.Clear();
        }

        private void FrmProjeto_Load(object sender, EventArgs e)
        {
            tipoAcao = (int)Acao.nenhum;
            travarCampos(tipoAcao);

            ClsUtil clsUtil = new ClsUtil();
            clsUtil.criarGrid(dgvProjeto);

            apresentarProjetos();
            carregarComboGrupo();
            carregarComboCurso();
            carregarComboSemestre();
            carregarComboTurma();
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
                    FormProjeto projetoDao = new FormProjeto();
                    projetoDao.excluirProjeto(codigoProjeto);
                    
                    limparCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            apresentarProjetos();
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

            if (txtEmpresa.Text.Length == 0)
            {
                MessageBox.Show("Informe a Empresa.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            
            try
            {

                Projeto projeto = new Projeto();
                FormProjeto projetoDao = new FormProjeto();

                projeto.titulo = txtTitulo.Text;
                projeto.urlSistema = txtURL.Text;
                projeto.descricao = txtDescricao.Text;
                projeto.empresa = txtEmpresa.Text;
                projeto.cursoId = int.Parse(cboCurso.SelectedValue.ToString());
                projeto.grupoId = int.Parse(cboGrupo.SelectedValue.ToString());
                projeto.ativo = true;
                
                if (tipoAcao == (int)Acao.incluir)
                {
                    int codigoProjeto = projetoDao.incluirProjeto(projeto);

                    Fase fase = new Fase();
                    fase.projetoId = codigoProjeto;
                    fase.semestreId = int.Parse(cboSemestre.SelectedValue.ToString());
                    fase.turmaId = int.Parse(cboTurma.SelectedValue.ToString());
                    fase.ativo = true;

                    FormFase faseDao = new FormFase();
                    faseDao.incluirFase(fase);

                    MessageBox.Show("Projeto salvo com sucesso.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (tipoAcao == (int)Acao.alterar)
                {
                    projeto.projetoId = codigoProjeto;
                    projetoDao.alterarProjeto(projeto);
                    MessageBox.Show("Projeto salvo com sucesso.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            } catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            atualizarCampos();
            apresentarProjetos();
            tipoAcao = (int)Acao.nenhum;
            travarCampos(tipoAcao);
        }

        private void apresentarProjetos()
        {
            dgvProjeto.Rows.Clear();

            FormProjeto projetoDao = new FormProjeto();
            ICollection<Projeto> projetos = projetoDao.listarProjetos();

            foreach(Projeto projeto in projetos)
            {
                dgvProjeto.Rows.Add(projeto.projetoId, projeto.titulo);
            }   
        }

        private void dgvProjeto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow linhaProjeto = dgvProjeto.Rows[e.RowIndex];
            codigoProjeto = int.Parse(linhaProjeto.Cells["Codigo"].Value.ToString());
            atualizarCampos();
            tipoAcao = (int)Acao.nenhum;
            travarCampos(tipoAcao);
        }

        private void atualizarCampos()
        {
            try
            {

                Projeto projeto = new Projeto();
                FormProjeto projetoDao = new FormProjeto();
                
                if (codigoProjeto != 0)
                {
                    projeto = projetoDao.BuscarPorId(codigoProjeto);

                    txtTitulo.Text = projeto.titulo.ToString();
                    txtURL.Text = projeto.urlSistema.ToString();
                    txtDescricao.Text = projeto.descricao.ToString();
                    txtEmpresa.Text = projeto.empresa.ToString();
                    
                }

                tipoAcao = (int)Acao.nenhum;
                travarCampos(tipoAcao);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void carregarComboGrupo()
        {

            FormGrupo grupoDao = new FormGrupo();
            ICollection<Grupo> grupos = grupoDao.listarGrupo();

            cboGrupo.DataSource = grupos;
            cboGrupo.ValueMember = "grupoId";
            cboGrupo.DisplayMember = "nome";
        }

        private void carregarComboCurso()
        {
            FormCurso cursoDao = new FormCurso();
            ICollection<Curso> cursos = cursoDao.listarCurso();

            cboCurso.DataSource = cursos;
            cboCurso.ValueMember = "cursoId";
            cboCurso.DisplayMember = "nome";
        }

        private void carregarComboSemestre()
        {
            FormSemestre semestreDao = new FormSemestre();
            ICollection<Semestre> semestres = semestreDao.listarSemestre();

            cboSemestre.DataSource = semestres;
            cboSemestre.ValueMember = "semestreId";
            cboSemestre.DisplayMember = "nome";
        }

        private void carregarComboTurma()
        {
            FormTurma turmaDao = new FormTurma();
            ICollection<Turma> turmas = turmaDao.listarTurmas();

            cboTurma.DataSource = turmas;
            cboTurma.ValueMember = "turmaId";
            cboTurma.DisplayMember = "nome";
        }

    }
}
