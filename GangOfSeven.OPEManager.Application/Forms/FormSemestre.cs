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
        public void incluirSemestre(Semestre semestre)
        {
            if (semestre != null)
            {
                new SemestreRep().Adicionar(semestre);
            }
        }

        public void alterarSemestre(Semestre semestre)
        {
            if (semestre != null)
            {
                new SemestreRep().Atualizar(semestre);
            }
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

        public ICollection<Semestre> buscaNomeSemestre(string nome)
        {
            ICollection<Semestre> nomeSemestre = null;

            if (nome != null)
            {
                nomeSemestre = new SemestreRep().BuscarPorNome(nome);
            }

            return nomeSemestre;
        }
    }
}