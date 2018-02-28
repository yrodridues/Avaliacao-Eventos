using Eventos.AcessoADados.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eventos.AcessoADados.ObjetosDeAcesso
{
    public class ParticipanteDAO
    {
        public void Inserir(Participante participante)
        {
            using (var bancoDeDados = new BancoDeDados())
            {
                bancoDeDados.Participantes.Add(participante);
                bancoDeDados.SaveChanges();
            }
        }

        public void Deletar(int id)
        {
            using (var bancoDeDados = new BancoDeDados())
            {
                var participante = ObterPorId(id);
                bancoDeDados.Participantes.Remove(participante);
                bancoDeDados.SaveChanges();
            }
        }


        public void Atualizar(Participante participante)
        {
            using (var bancoDeDados = new BancoDeDados())
            {
                bancoDeDados.Participantes.Update(participante);
                bancoDeDados.SaveChanges();
            }
        }

        public List<Participante> ObterTodos()
        {
            using (var bancoDeDados = new BancoDeDados())
            {
                return bancoDeDados.Participantes.ToList();
            }
        }

        public Participante ObterPorId(int id)
        {
            using (var bancoDeDados = new BancoDeDados())
            {
                return bancoDeDados.Participantes.Find(id);
            }
        }
    }
}
