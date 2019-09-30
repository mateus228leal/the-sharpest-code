using System;
using System.Collections.Generic;
using System.Text;

namespace the_sharpest_code
{
    class EventoList
    {
        private List<Evento> eventos = new List<Evento>();

        public void addEvento(Evento evento)
        {
            Evento even = new Evento();
            even.Nome = evento.Nome;
            even.Data = evento.Data;
            even.Descricao = evento.Descricao;
            even.HorarioInicio = evento.HorarioInicio;
            even.HorarioTermino = evento.HorarioTermino;
            even.Classificacao = evento.Classificacao;
            even.Local = evento.Local;
            even.Valor = evento.Valor;
            even.Organizador = evento.Organizador;

            eventos.Add(even);
        }
    }
}
