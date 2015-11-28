using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartNet.OPEManager.Data.Repositories;
using SmartNet.OPEManager.Domain.Entities;

namespace GangOfSeven.OPEManager.Application.Forms
{
    class FormFase
    {

        public void incluirFase(Fase fase)
        {
            if (fase != null)
            {
                new FaseRep().Adicionar(fase);
            }
        }

        public void alterarFase(Fase fase)
        {
            if (fase != null)
            {
                new FaseRep().Atualizar(fase);
            }
        }

        public void excluirFase(int id)
        {

            var fase = new FaseRep().BuscarPorId(id);
            fase.ativo = false;
            new FaseRep().Atualizar(fase);

        }

        public ICollection<Fase> listarFases()
        {
            ICollection<Fase> fases = new FaseRep().BuscarTodos();

            return fases;
        }

        public Fase BuscarPorId(int id)
        {
            return new FaseRep().BuscarPorId(id);
        }
    }
}
