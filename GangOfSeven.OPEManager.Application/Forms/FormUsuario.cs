using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartNet.OPEManager.Data.Repositories;
using SmartNet.OPEManager.Domain.Entities;

namespace GangOfSeven.OPEManager.Application.Forms
{
    public class FormUsuario
    {
        public void incluirUsuario(int ra, String nome, String email, String senha, int tipoPerfil, Boolean status)
        {
            if (tipoPerfil == 1)
            {
                var professor = new Professor
                {
                    RA = ra,
                    nome = nome,
                    email = email,
                    senha = senha,
                    perfil = Usuario.Perfil.Administrador,
                    ativo = status
                };

                var professorRep = new ProfessorRep().Adicionar(professor);
            }
            else
            {
                var aluno = new Aluno
                {
                    RA = ra,
                    nome = nome,
                    email = email,
                    senha = senha,
                    perfil = Usuario.Perfil.Usuario,
                    ativo = status
                };

                var alunoRep = new AlunoRep().Adicionar(aluno);
            }
        }

        public void alterarLogin(int ra, String nome, String email, String senha, int tipoPerfil, Boolean status)
        {
            if (tipoPerfil == 1)
            {
                var professor = new Professor
                {
                    RA = ra,
                    nome = nome,
                    email = email,
                    senha = senha,
                    perfil = Usuario.Perfil.Administrador,
                    ativo = status
                };

                var professorRep = new ProfessorRep().Atualizar(professor);
            }
            else
            {
                var aluno = new Aluno
                {
                    RA = ra,
                    nome = nome,
                    email = email,
                    senha = senha,
                    perfil = Usuario.Perfil.Usuario,
                    ativo = status
                };

                var alunoRep = new AlunoRep().Atualizar(aluno);
            }
        }

        public void excluirUsuario(int ra)
        {
            var usuario = new UsuarioRep().BuscarPorId(ra);

            new UsuarioRep().Remover(usuario);
        }

        public ICollection<Usuario> listarLogin()
        {
            ICollection<Usuario> usuarios = new UsuarioRep().BuscarTodos();

            return usuarios;
        }
    }
}