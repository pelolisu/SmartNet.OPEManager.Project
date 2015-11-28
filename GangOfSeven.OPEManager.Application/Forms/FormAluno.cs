using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartNet.OPEManager.Data.Repositories;
using SmartNet.OPEManager.Domain.Entities;

namespace GangOfSeven.OPEManager.Application.Forms
{
    class FormAluno
    {

        public void incluirAluno(Aluno aluno)
        {
            if (aluno != null)
            {
                new AlunoRep().Adicionar(aluno);
            }
        }

        public void alterarAluno(Aluno aluno)
        {
            if (aluno != null)
            {
                new AlunoRep().Atualizar(aluno);
            }
        }

        public void excluirAluno(int id)
        {

            var aluno = new AlunoRep().BuscarPorId(id);
            aluno.ativo = false;
            new AlunoRep().Atualizar(aluno);

        }

        public ICollection<Aluno> listarAlunos()
        {
            ICollection<Aluno> projetos = new AlunoRep().BuscarTodos();

            return projetos;
        }

        public Aluno BuscarPorId(int id)
        {
            return new AlunoRep().BuscarPorId(id);
        }
    }
}
