using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartNet.OPEManager.Data.Repositories;
using SmartNet.OPEManager.Domain.Entities;

namespace GangOfSeven.OPEManager.Application.Forms
{
    public class FormSemestre
    {
        public void incluirSemestre(String nome, Boolean status)
        {
            var semestre = new Semestre
            {
                nome = nome,
                ativo = status
            };

            new SemestreRep().Adicionar(semestre);
        }

        public void alterarSemestre(int id, String nome, Boolean status)
        {
            var semestre = new Semestre
            {
                semestreId = id,
                nome = nome,
                ativo = status
            };

            new SemestreRep().Atualizar(semestre);
        }

        public void excluirSemestre(int id)
        {
            var semestre = new SemestreRep().BuscarPorId(id);

            new SemestreRep().Remover(semestre);
        }

        public ICollection<Semestre> listarSemestre()
        {
            ICollection<Semestre> semestres = new SemestreRep().BuscarTodos();

            return semestres;
        }

        public Semestre buscaSemestre(int id)
        {
            return new SemestreRep().BuscarPorId(id);
        }
    }
}
