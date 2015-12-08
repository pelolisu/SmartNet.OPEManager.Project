using SmartNet.OPEManager.Data.Repositories;
using SmartNet.OPEManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangOfSeven.OPEManager.Application.Forms
{
    public class FormProfessor
    {
        public void incluirProfessor(Professor professor)
        {
            if (professor != null)
            {
                new ProfessorRep().Adicionar(professor);
            }
        }

        public void alterarProfessor(Professor professor)
        {
            if (professor != null)
            {
                new ProfessorRep().Atualizar(professor);
            }
        }

        public void excluirProfessor(int id)
        {
            var professor = new ProfessorRep().BuscarPorId(id);
            professor.ativo = false;

            new ProfessorRep().Atualizar(professor);
        }

        public ICollection<Professor> listarProfessor()
        {
            ICollection<Professor> professores = new ProfessorRep().BuscarTodos();

            return professores;
        }

        public Professor BuscarPorId(int id)
        {
            return new ProfessorRep().BuscarPorId(id);
        }

        public ICollection<Professor> buscaNomeProfessor(string nome)
        {
            ICollection<Professor> nomeProfessores = null;

            if (nome != null)
            {
                nomeProfessores = new ProfessorRep().BuscarPorNome(nome);
            }

            return nomeProfessores;
        }
    }
}