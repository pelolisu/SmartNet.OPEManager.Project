using System;
using SmartNet.OPEManager.Data.Repositories;
using SmartNet.OPEManager.Domain.Entities;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cadastra Turma
            var turma = new Turma
            {
                nome = "4A",
                ativo = true
            };
            var turmaRep = new TurmaRep();
            turma = turmaRep.Adicionar(turma);

            //Cadastra Semestre
            var semestre = new Semestre
            {
                nome = "4º Semestre",
                ativo = true
            };
            var semestreRep = new SemestreRep();
            semestre = semestreRep.Adicionar(semestre);

            //Cadastra Grupo
            var grupo = new Grupo
            {
                nome = "Smart.NET",
                ativo = true
            };
            var grupoRep = new GrupoRep();
            grupo = grupoRep.Adicionar(grupo);

            //Cadastra Curso
            var curso = new Curso
            {
                nome = "ADS - Análise e Desenvolvimentos de Sistemas",
                ativo = true

            };
            var cursoRep = new CursoRep();
            curso = cursoRep.Adicionar(curso);

            //Cadastra um Aluno
            var aluno = new Aluno
            {
                nome = "Eliseu",
                RA = 1410139,
                senha = "123",
                email = "teste@teste.com",
                perfil = Usuario.Perfil.Usuario,
                ativo = true,
                grupoId = grupo.grupoId
            };

            var alunoRep = new AlunoRep();
            aluno = alunoRep.Adicionar(aluno);

            //Cadastra um Professor
            var professor = new Professor
            {
                nome = "Vanderson",
                RA = 1400000,
                senha = "123",
                email = "varnderson@teste.com",
                perfil = Usuario.Perfil.Administrador,
                ativo = true
            };

            var professorRep = new ProfessorRep();
            professor = professorRep.Adicionar(professor);

            //Cadastra um Projeto
            var projeto = new Projeto
            {
                titulo = "4U - Sistema Gerenciador de Vendas Diretas",
                empresa = "Mary Kay",
                descricao = "Projeto para a empresa .....",
                urlSistema = "http://4u.com",
                cursoId = curso.cursoId,
                grupoId = grupo.grupoId,
                ativo = true,
            };

            var projetoRep = new ProjetoRep();
            projeto = projetoRep.Adicionar(projeto);

            //Adicionar uma fase ao projeto 
            var fase = new Fase()
            {
                projetoId = projeto.projetoId,
                semestreId = semestre.semestreId,
                turmaId = turma.turmaId
            };

            var faseRep = new FaseRep();
            fase = faseRep.Adicionar(fase);

            //Adicionar agendamento à fase do projeto
            var agendamento = new Agendamento
            {
                assunto = "Reunião de último encontro da OPE",
                data = DateTime.Parse("05/12/2015"),
                horario = TimeSpan.Parse("08:30"),
                faseId = fase.faseId
            };
            var agendamentoRep = new AgendamentoRep();
            agendamento = agendamentoRep.Adicionar(agendamento);

            //Adicionar Convidado
            var convidado1 = new UsuarioRep().BuscarPorId(1410139);
            var convidado2 = new UsuarioRep().BuscarPorId(1400000);
            agendamento.convidados.Add(convidado1);
            agendamento.convidados.Add(convidado2);
            agendamentoRep.Atualizar(agendamento);

            //Adicionar Comentários
            var comentario1 = new Comentario
            {
                comentario = "Comentário de teste 1",
                data = DateTime.Now,
                RA = 1410139,
                agendamentoId = agendamento.agendamentoId
            };
            var comentario2 = new Comentario
            {
                comentario = "Comentário de teste 2",
                data = DateTime.Now,
                RA = 1410139,
                agendamentoId = agendamento.agendamentoId
            };
            var comentarioRep = new ComentarioRep();
            comentarioRep.Adicionar(comentario1);
            comentarioRep.Adicionar(comentario2);

            ////Valida dados cadastrados
            //var agendamento = new AgendamentoRep().BuscarPorId(1);//
            //var aluno = new AlunoRep().BuscarPorId(1410139);//
            //var comentario = new ComentarioRep().BuscarPorId(1);
            //var curso = new CursoRep().BuscarPorId(1);
            //var fase = new FaseRep().BuscarPorId(1);//
            //var grupo = new GrupoRep().BuscarPorId(1);
            //var professor = new ProfessorRep().BuscarPorId(1400000);//
            //var projeto = new ProjetoRep().BuscarPorId(1);//
            //var semestre = new SemestreRep().BuscarPorId(1);
            //var turma = new TurmaRep().BuscarPorId(1);
            //var usuario = new UsuarioRep().BuscarPorId(1400000);


        }
    }
}
