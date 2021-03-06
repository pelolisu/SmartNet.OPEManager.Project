﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartNet.OPEManager.Data.Repositories;
using SmartNet.OPEManager.Domain.Entities;

namespace GangOfSeven.OPEManager.Application.Forms
{
    public class FormAgendamento
    {
        public void incluirAgendamento(Agendamento agendamento)
        {
            if (agendamento != null)
            {
                new AgendamentoRep().Adicionar(agendamento);
            }
        }

        public void alterarAgendamento(Agendamento agendamento)
        {
            if (agendamento != null)
            {
                new AgendamentoRep().Atualizar(agendamento);
            }
        }

        public void excluirAgendamento(int id)
        {

            var agendamento = new AgendamentoRep().BuscarPorId(id);
            agendamento.ativo = false;
            new AgendamentoRep().Atualizar(agendamento);

        }

        public ICollection<Agendamento> listarAgendamento()
        {
            ICollection<Agendamento> agendamentos = new AgendamentoRep().BuscarTodos();

            return agendamentos;
        }

        public Agendamento BuscarPorId(int id)
        {
            return new AgendamentoRep().BuscarPorId(id);
        }

        public ICollection<Agendamento> buscaAssuntoAgendameto(string assunto)
        {
            ICollection<Agendamento> assuntoAgendamentos = null;

            if (assunto != null)
            {
                assuntoAgendamentos = new AgendamentoRep().BuscarPorAssunto(assunto);
            }

            return assuntoAgendamentos;
        }
    }
}