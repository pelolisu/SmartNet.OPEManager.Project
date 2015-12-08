using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartNet.OPEManager.Data.Repositories;
using SmartNet.OPEManager.Domain.Entities;

namespace GangOfSeven.OPEManager.Application.Forms
{
    public class FormTurma
    {
        public void incluirTurma(Turma turma)
        {
            if (turma != null)
            {
                new TurmaRep().Adicionar(turma);
            }
        }

        public void alterarTurma(Turma turma)
        {
            if (turma != null)
            {
                new TurmaRep().Atualizar(turma);
            }
        }

        public void excluirTurma(int id)
        {
            var turma = new TurmaRep().BuscarPorId(id);

            new TurmaRep().Remover(turma);
        }

        public ICollection<Turma> listarTurmas()
        {
            ICollection<Turma> turmas = new TurmaRep().BuscarTodos();

            return turmas;
        }

        public Turma buscaTurma(int id)
        {
            return new TurmaRep().BuscarPorId(id);
        }

        public ICollection<Turma> buscaNomeTurma(string nome)
        {
            ICollection<Turma> nomeTurmas = null;

            if (nome != null)
            {
                nomeTurmas = new TurmaRep().BuscarPorNome(nome);
            }

            return nomeTurmas;
        }
    }
}