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
            System.Console.WriteLine(new FormLogin().fazerLogin(1410401, "123456"));
            System.Console.ReadKey();

            // Form Usuario
            new FormUsuario().incluirUsuario(1410402, "Teste", "teste@teste.com", "123456", 1, true);
            new FormUsuario().alterarUsuario(1410402, "Teste teste", "teste@teste.com", "123456", 1, true);
            new FormUsuario().excluirUsuario(1410402);

            ICollection<Usuario> usuarios = new FormUsuario().listarLogin();

            foreach (Usuario usuario in usuarios)
            {
                System.Console.WriteLine(usuario.nome +" - "+ usuario.RA);                
            }
            System.Console.ReadKey();

            // Form Turma
            new FormTurma().incluirTurma("teste", true);
            new FormTurma().alterarTurma(2, "teste teste", true);
            new FormTurma().excluirTurma(2);

            ICollection<Turma> turmas = new FormTurma().listarTurmas();

            foreach (Turma turma in turmas)
            {
                System.Console.WriteLine(turma.turmaId + " - " + turma.nome);
            }
            System.Console.ReadKey();
        }
    }
}