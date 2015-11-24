using System;
using GangOfSeven.OPEManager.Application.Forms;
using System.Collections.Generic;
using SmartNet.OPEManager.Domain.Entities;

namespace ConsoleApp_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // From login
            System.Console.WriteLine(new FormLogin().fazerLogin(1410403));
            System.Console.ReadKey();

            // Form Usuario            
            var incluiUsuario = new Usuario
            {
                RA = 14104,
                nome = "Teste",
                email = "teste@teste.com",
                senha = "123456",
                perfil = Usuario.Perfil.Usuario,
                ativo = true
            };
            new FormUsuario().incluirUsuario(incluiUsuario);

            var alteraUsuario = new Usuario
            {
                RA = 14104,
                nome = "Teste teste",
                email = "teste@teste.com",
                senha = "123456",
                perfil = Usuario.Perfil.Usuario,
                ativo = true
            };
            new FormUsuario().alterarUsuario(alteraUsuario);

            new FormUsuario().excluirUsuario(1410402);

            ICollection<Usuario> usuarios = new FormUsuario().listarLogin();
            foreach (Usuario usuario in usuarios)
            {
                System.Console.WriteLine(usuario.nome +" - "+ usuario.RA);                
            }
            System.Console.ReadKey();

            var buscaUsuario = new FormUsuario().buscaUsuario(1410403);
            System.Console.WriteLine(buscaUsuario.RA + " - " + buscaUsuario.nome);

            // Form Turma
            var incluiTurma = new Turma
            {
                nome = "teste",
                ativo = true
            };
            new FormTurma().incluirTurma(incluiTurma);

            var alteraTurma = new Turma
            {
                turmaId = 4,
                nome = "teste teste",
                ativo = true
            };
            new FormTurma().alterarTurma(alteraTurma);

            new FormTurma().excluirTurma(2);

            ICollection<Turma> turmas = new FormTurma().listarTurmas();

            foreach (Turma turma in turmas)
            {
                System.Console.WriteLine(turma.turmaId + " - " + turma.nome);
            }
            System.Console.ReadKey();

            var buscaTurma = new FormTurma().buscaTurma(3);
            System.Console.WriteLine(buscaTurma.turmaId + " - " + buscaTurma.nome);

            // Form Semestre
            var incluiSemestre = new Semestre
            {
                nome = "teste",
                ativo = true
            };
            new FormSemestre().incluirSemestre(incluiSemestre);

            var alteraSemestre = new Semestre
            {
                semestreId = 4,
                nome = "teste teste",
                ativo = true
            };
            new FormSemestre().alterarSemestre(alteraSemestre);

            new FormSemestre().excluirSemestre(2);

            ICollection<Semestre> semestres = new FormSemestre().listarSemestre();

            foreach (Semestre semestre in semestres)
            {
                System.Console.WriteLine(semestre.semestreId + " - " + semestre.nome);
            }
            System.Console.ReadKey();
            
            var buscaSemestre = new FormSemestre().buscaSemestre(3);
            System.Console.WriteLine(buscaSemestre.semestreId + " - " + buscaSemestre.nome);
        }
    }
}