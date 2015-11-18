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
        public void incluirTurma(String nome, Boolean status)
        {
            var turma = new Turma
            {
                nome = nome,
                ativo = status
            };

            new TurmaRep().Adicionar(turma);
        }

        public void alterarTurma(int id, String nome, Boolean status)
        {
            var turma = new Turma
            {
                turmaId = id,
                nome = nome,
                ativo = status
            };

            new TurmaRep().Atualizar(turma);
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
    }
}