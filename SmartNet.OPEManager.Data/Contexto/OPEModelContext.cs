using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using SmartNet.OPEManager.Data.EntityConfig;
using SmartNet.OPEManager.Domain.Entities;

namespace SmartNet.OPEManager.Data.Contexto
{
    public class OPEModelContext : DbContext
    {
        public OPEModelContext()
            : base("name=OPEModel")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        //Mapeia Entidades para tabelas em banco de dados
        public virtual DbSet<Agendamento> Agendamentos { get; set; }
        public virtual DbSet<Aluno> Alunos { get; set; }
        public virtual DbSet<Comentario> Comentarios { get; set; }
        public virtual DbSet<Curso> Cursos { get; set; }
        public virtual DbSet<Fase> Fases { get; set; }
        public virtual DbSet<Grupo> Grupos { get; set; }
        public virtual DbSet<Professor> Professores { get; set; }
        public virtual DbSet<Projeto> Projetos { get; set; }
        public virtual DbSet<Semestre> Semestre { get; set; }
        public virtual DbSet<Turma> Turmas { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //Redefine o padrão de reconhecimento do campo de Primary Key
            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            //Redifine padrões de tipos de campo do banco de dados
            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            //Chama configuração das entidades por Fluent API
            modelBuilder.Configurations.Add(new UsuarioConfig());
            modelBuilder.Configurations.Add(new AlunoConfig());
            modelBuilder.Configurations.Add(new ProfessorConfig());
            modelBuilder.Configurations.Add(new GrupoConfig());
            modelBuilder.Configurations.Add(new ProjetoConfig());
            modelBuilder.Configurations.Add(new CursoConfig());
            modelBuilder.Configurations.Add(new FaseConfig());
            modelBuilder.Configurations.Add(new AgendamentoConfig());
            modelBuilder.Configurations.Add(new TurmaConfig());
            modelBuilder.Configurations.Add(new SemestreConfig());
            modelBuilder.Configurations.Add(new ComentarioConfig());
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("dataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("dataCadastro").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("dataCadastro").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }


}