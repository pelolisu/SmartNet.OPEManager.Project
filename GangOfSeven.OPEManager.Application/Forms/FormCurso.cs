﻿using SmartNet.OPEManager.Data.Repositories;
using SmartNet.OPEManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangOfSeven.OPEManager.Application.Forms
{
    public class FormCurso
    {
        public void incluirCurso(Curso curso)
        {
            if (curso != null)
            {
                new CursoRep().Adicionar(curso);
            }
        }

        public void alterarCurso(Curso curso)
        {
            if (curso != null)
            {
                new CursoRep().Atualizar(curso);
            }
        }

        public void excluirCurso(Curso curso)
        {
            if (curso != null)
            {
                new CursoRep().Remover(curso);
            }
        }

        public ICollection<Curso> listarCurso()
        {
            ICollection<Curso> cursos = new CursoRep().BuscarTodos();

            return cursos;
        }

        public Curso BuscarPorId(int id)
        {
            return new CursoRep().BuscarPorId(id);
        }
    }
}