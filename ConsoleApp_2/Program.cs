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
            // inclui um usuario
            new FormUsuario().incluirUsuario(1410403, "Eduardo", "r.eduardo00@gmail.com", "123456", 1, true);

            // altera um usuario
            new FormUsuario().alterarLogin(1410402, "Eduardo teste", "r.eduardo00@gmail.com", "123456", 1, true);

            // exclui um usuario
            new FormUsuario().excluirUsuario(1410402);

            // lista um usuario
            ICollection<Usuario> usuarios = new FormUsuario().listarLogin();

            foreach (Usuario usuario in usuarios)
            {
                System.Console.WriteLine(usuario.nome +" - "+ usuario.RA);                
            }
            System.Console.ReadKey();

            // validacao de usuario
            System.Console.WriteLine(new FormLogin().fazerLogin(1410401, "123456"));
            System.Console.ReadKey();
        }
    }
}