using Eventos.AcessoADados.ModelView;
using Eventos.AcessoADados.Modelos;
using Eventos.AcessoADados.ObjetosDeAcesso;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eventos.RegrasDeNegocios
{
    public class EventoBll
    {

        public void Inserir(EventoModelView eventoModelView)
        {
            var evento = new Evento();

            evento = PrepararEvento(eventoModelView, evento);

            var eventoDao = new EventoDAO();
            eventoDao.Inserir(evento);
        }

        public void Atualizar(int id, EventoModelView eventoModelView)
        {
            var eventoDao = new EventoDAO();
            var evento = eventoDao.ObterPorId(id);

            evento = PrepararEvento(eventoModelView, evento);
            eventoDao.Atualizar(evento);
        }

        public Evento ObterPorId(int id)
        {
            var eventoDao = new EventoDAO();
            return eventoDao.ObterPorId(id);
        }

        public void Deletar(int id)
        {
            var eventoDao = new EventoDAO();
            eventoDao.Deletar(id);
        }

        public List<Evento> obterTodos()
        {
            var eventoDao = new EventoDAO();
            return eventoDao.ObterTodos();
        }



        private Evento PrepararEvento(EventoModelView eventoModelView, Evento evento)
        { 
            evento.NomeEvento = eventoModelView.NomeEvento;
            evento.DataEvento = eventoModelView.DataEvento;
            evento.LocalEvento = eventoModelView.LocalEvento;
            evento.HorarioInicio = eventoModelView.HorarioInicio;
            evento.HorarioFinal = eventoModelView.HorarioFinal;
            evento.OpenBar = eventoModelView.OpenBar;
            evento.QuantidadeAmbientes = eventoModelView.QuantidadeAmbientes;
            evento.FaixaEtaria = eventoModelView.FaixaEtaria;

            if(evento.HorarioInicio > 10 && evento.HorarioFinal < 20 && evento.QuantidadeAmbientes > 2)
            {
                evento.FaixaEtaria = "Menor que 16 anos.";
            }
            else
                if (evento.HorarioInicio > 20 && evento.HorarioFinal < 2 && evento.OpenBar == false)
            {
                evento.FaixaEtaria = "Maior que 16 anos.";
            }
            else
            {
                evento.FaixaEtaria = "Maior que 18 anos.";
            }

            return evento;
        }
    }
}
