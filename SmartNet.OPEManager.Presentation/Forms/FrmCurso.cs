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
    public partial class FrmCurso : Form
    {
        private int tipoAcao;
        private int codigoCurso = 0;

        public FrmCurso()
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
            btnAlterar.Enabled = (tipoAcao != (int)Acao.incluir && codigoCurso != 0);
        }

        private void limparCampos()
        {
            txtNome.Clear(); 
        }

        private void FrmCurso_Load(object sender, EventArgs e)
        {
            tipoAcao = (int)Acao.nenhum;
            travarCampos(tipoAcao);

            ClsUtil clsUtil = new ClsUtil();
            clsUtil.criarGrid(dgvCurso);

            apresentarCursos();
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
            if (MessageBox.Show("Deseja excluir curso?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {
                    FormCurso cursoDao = new FormCurso();
                    cursoDao.excluirCurso(codigoCurso);    
                    limparCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            apresentarCursos();
            tipoAcao = (int)Acao.nenhum;
            travarCampos(tipoAcao);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            apresentarCursos();
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

            Curso curso = new Curso();
            FormCurso cursoDao = new FormCurso();

            curso.nome = txtNome.Text;
            curso.ativo = true;

            try
            {

                if (tipoAcao == (int)Acao.incluir)
                {
                    cursoDao.incluirCurso(curso);
                    MessageBox.Show("Curso salvo com sucesso.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (tipoAcao == (int)Acao.alterar)
                {
                    curso.cursoId = codigoCurso;
                    cursoDao.alterarCurso(curso);
                    MessageBox.Show("Curso salvo com sucesso.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            atualizarCampos();
            apresentarCursos();
            tipoAcao = (int)Acao.nenhum;
            travarCampos(tipoAcao);

        }

        private void apresentarCursos()
        {
            FormCurso cursoDao = new FormCurso();
            ICollection<Curso> cursos = cursoDao.listarCurso();

            carregarGrid(cursos);
        }

        private void carregarGrid(ICollection<Curso> cursos)
        {
            dgvCurso.Rows.Clear();

            foreach (Curso curso in cursos)
            {
                dgvCurso.Rows.Add(curso.cursoId, curso.nome);
            }
        }

        private void dgvCurso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow linhaCurso = dgvCurso.Rows[e.RowIndex];
            codigoCurso = int.Parse(linhaCurso.Cells["Codigo"].Value.ToString());
            atualizarCampos();
            tipoAcao = (int)Acao.nenhum;
            travarCampos(tipoAcao);
        }

        private void atualizarCampos()
        {
            try
            {
                Curso curso = new Curso();
                FormCurso cursoDao = new FormCurso();
                
                if (codigoCurso != 0)
                {
                    curso = cursoDao.BuscarPorId(codigoCurso);

                    txtNome.Text = curso.nome.ToString();
                    
                }

                tipoAcao = (int)Acao.nenhum;
                travarCampos(tipoAcao);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FormCurso cursoDao = new FormCurso();
            ICollection<Curso> cursos = cursoDao.buscaNomeCurso(txtPesquisaNome.Text);

            carregarGrid(cursos);
        }
    }
}
