
using System.Data.Entity;
using System.Linq;
using SmartNet.OPEManager.Data.Contexto;
using SmartNet.OPEManager.Data.Repositories.Base;
using SmartNet.OPEManager.Domain.Entities;
using SmartNet.OPEManager.Domain.Interfaces.Repositories;
using System.Collections.Generic;

namespace SmartNet.OPEManager.Data.Repositories
{
    public class AgendamentoRep : Crud<Agendamento>, IAgendamentoRep
    {
        public new Agendamento BuscarPorId(int id)
        {
            using (Db = new OPEModelContext())
            {
                Db.Agendamentos.Include("fase").Include("convidados").Include("comentarios").ToList();
                return Db.Agendamentos.Find(id);

            }
        }

        public virtual ICollection<Agendamento> BuscarPorAssunto(string texto)
        {
            using (Db = new OPEModelContext())
            {
                return Db.Agendamentos.Where(o => o.assunto.Contains(texto)).ToList();

            }

        }

        public new Agendamento Atualizar(Agendamento obj)
        {
            using (Db = new OPEModelContext())
            {
                //Recupera o item atual que está armazenado no BD
                Agendamento itemAtual = Db.Agendamentos.Find(obj.agendamentoId);
                //Alteração dos dados que estão relacionados especificamente ao item
                itemAtual.assunto = obj.assunto;
                itemAtual.data = obj.data;
                itemAtual.horario = obj.horario;
                //... 

                //Consulta Linq para obter os convidados que devem ser excluídas do item atual
                var convidadosDeletados = (from c in itemAtual.convidados
                                           where !(from c1 in obj.convidados
                                                   select c1.RA).Contains(c.RA)
                                           select c).ToList();

                //Consulta Linq para obter os convidados que devem ser adicionadas ao item atual
                var convidadosAdicionados = (from c in obj.convidados
                                             where !(from c1 in itemAtual.convidados
                                                     select c1.RA).Contains(c.RA)
                                             select c).ToList();

                //Exclusão dos convidados relacionados ao item atual
                convidadosDeletados.ForEach(c => itemAtual.convidados.Remove(c));

                //Adição dos novos convidados relacionadas ao item atual
                foreach (Usuario c in convidadosAdicionados)
                {
                    //Como os objetos Usuarios vieram de outro contexto é necessário verificar se os mesmos já foram "Attachados" a esse
                    if (Db.Entry(c).State == EntityState.Detached)
                        Db.Usuarios.Attach(c);
                    itemAtual.convidados.Add(c);
                }

                //Confirmação dos dados no BD
                Db.SaveChanges();
                return obj;
            }
        }
    }
}
