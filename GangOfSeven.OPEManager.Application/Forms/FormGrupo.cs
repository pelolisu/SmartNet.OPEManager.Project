using SmartNet.OPEManager.Data.Repositories;
using SmartNet.OPEManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangOfSeven.OPEManager.Application.Forms
{
    public class FormGrupo
    {
        public void incluirGrupo(Grupo grupo)
        {
            if (grupo != null)
            {
                new GrupoRep().Adicionar(grupo);
            }
        }

        public void alterarGrupo(Grupo grupo)
        {
            if (grupo != null)
            {
                new GrupoRep().Atualizar(grupo);
            }
        }

        public void excluirGrupo(int id)
        {
            var grupo = new GrupoRep().BuscarPorId(id);
            grupo.ativo = false;

            new GrupoRep().Atualizar(grupo);
        }

        public ICollection<Grupo> listarGrupo()
        {
            ICollection<Grupo> grupos = new GrupoRep().BuscarTodos();

            return grupos;
        }

        public Grupo BuscarPorId(int id)
        {
            return new GrupoRep().BuscarPorId(id);
        }
    }
}