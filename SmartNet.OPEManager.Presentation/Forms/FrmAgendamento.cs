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
    public partial class FrmAgendamento : Form
    {
        private int tipoAcao;
        private int codigoAgendamento = 0;

        public FrmAgendamento()
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
            txtAssunto.Enabled = (tipoAcao != (int)Acao.nenhum);
            txtDataHora.Enabled = (tipoAcao != (int)Acao.nenhum);
            
            btnSalvar.Enabled = (tipoAcao != (int)Acao.nenhum);
            btnCancelar.Enabled = (tipoAcao != (int)Acao.nenhum);
            btnExcluir.Enabled = (tipoAcao != (int)Acao.incluir) && (txtAssunto.Text.Length > 0);
            btnIncluir.Enabled = (tipoAcao != (int)Acao.alterar);
            btnAlterar.Enabled = (tipoAcao != (int)Acao.incluir && codigoAgendamento != 0);
        }

        private void limparCampos()
        {
            txtAssunto.Clear();
        }

        private void FrmAgendamento_Load(object sender, EventArgs e)
        {
            tipoAcao = (int)Acao.nenhum;
            travarCampos(tipoAcao);

            ClsUtil clsUtil = new ClsUtil();
            clsUtil.criarGrid(dgvAgendamento);

            apresentarAgendamento();
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
            if (MessageBox.Show("Deseja excluir agendamento?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {
                    FormAgendamento agendamentoDao = new FormAgendamento();
                    agendamentoDao.excluirAgendamento(codigoAgendamento);
                    
                    limparCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            apresentarAgendamento();
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
            if (txtDataHora.Text.Length == 0)
            {
                MessageBox.Show("Informe uma data.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (txtAssunto.Text.Length == 0)
            {
                MessageBox.Show("Informe o assunto.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

            FormAgendamento agendamentoDao = new FormAgendamento();
            Agendamento agendamento = new Agendamento();
 
            try
            {
                agendamento.data = Convert.ToDateTime(txtDataHora.Text);
                agendamento.horario = TimeSpan.Parse(ClsUtil.converterNumero(txtDataHora.Text));
                agendamento.assunto = txtAssunto.Text;
                agendamento.faseId = 2;
                agendamento.ativo = true;

                if (tipoAcao == (int)Acao.incluir)
                {
                    agendamentoDao.incluirAgendamento(agendamento);
                    MessageBox.Show("Projeto salvo com sucesso.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (tipoAcao == (int)Acao.alterar)
                {
                    agendamento.agendamentoId = codigoAgendamento;
                    agendamentoDao.alterarAgendamento(agendamento);
                    MessageBox.Show("Projeto salvo com sucesso.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            atualizarCampos();
            apresentarAgendamento();
            tipoAcao = (int)Acao.nenhum;
            travarCampos(tipoAcao);
        }

        private void apresentarAgendamento()
        {
            dgvAgendamento.Rows.Clear();

            FormAgendamento agendamentoDao = new FormAgendamento();
            ICollection<Agendamento> agendamentos = agendamentoDao.listarAgendamento();

            foreach (Agendamento agendamento in agendamentos)
            {
                dgvAgendamento.Rows.Add(agendamento.agendamentoId, agendamento.assunto);
            }
        }

        private void dgvAgendamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow linhaAgendamento = dgvAgendamento.Rows[e.RowIndex];
            codigoAgendamento = int.Parse(linhaAgendamento.Cells["Codigo"].Value.ToString());
            atualizarCampos();
            tipoAcao = (int)Acao.nenhum;
            travarCampos(tipoAcao);
        }

        private void atualizarCampos()
        {
            try
            {
                Agendamento agendamento = new Agendamento();
                FormAgendamento agendamentoDao = new FormAgendamento();
                
                if (codigoAgendamento != 0)
                {
                    agendamento = agendamentoDao.BuscarPorId(codigoAgendamento);

                    txtAssunto.Text = agendamento.assunto.ToString();
                    txtDataHora.Text = agendamento.data.ToString();

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
