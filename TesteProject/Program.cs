using SmartNet.OPEManager.Data.Contexto;

namespace TesteProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new OPEModelContext();
            db.Database.CreateIfNotExists();

            //Usuario aluno = new Aluno();

            //aluno.nome = "Eliseu";
            //aluno.RA = 1410139;
            //aluno.senha = "123";
            //aluno.email = "teste@teste.com";
            //aluno.perfil = Usuario.Perfil.Usuario;
            
            //db.Usuario.Add(aluno);
            db.SaveChanges();


        }
    }
}
