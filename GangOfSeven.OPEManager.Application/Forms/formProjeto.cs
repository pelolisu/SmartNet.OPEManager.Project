using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartNet.OPEManager.Data.Repositories;
using SmartNet.OPEManager.Domain.Entities;

namespace GangOfSeven.OPEManager.Application.Forms
{
    class formProjeto
    {

        public void incluirProjeto(Projeto projeto)
        {
            if (projeto != null)
            {
                new ProjetoRep().Adicionar(projeto);
            }
        }

        public void alterarProjeto(Projeto projeto)
        {
            if (projeto != null)
            {
                new ProjetoRep().Atualizar(projeto);
            }
        }

        public void excluirProjeto(int id)
        {

            var projeto = new ProjetoRep().BuscarPorId(id);
            projeto.ativo = false;
            new ProjetoRep().Atualizar(projeto);

        }

        public ICollection<Projeto> listarProjetos()
        {
            ICollection<Projeto> projetos = new ProjetoRep().BuscarTodos();

            return projetos;
        }

        public Projeto BuscarPorId(int id)
        {
            return new ProjetoRep().BuscarPorId(id);
        }
    }
}
