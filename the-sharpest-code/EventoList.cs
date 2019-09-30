using System;
using System.Collections.Generic;
using System.Text;

namespace the_sharpest_code
{
    class EventoList
    {
        private List<Evento> eventos = new List<Evento>();

        public void createEvento(Evento evento)
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

        public Evento selectEvento(Evento evento)
        {
            Evento eventoSelecionado = new Evento();
            eventoSelecionado.Nome = evento.Nome;
            eventoSelecionado.Data = evento.Data;
            eventoSelecionado.Descricao = evento.Descricao;
            eventoSelecionado.HorarioInicio = evento.HorarioInicio;
            eventoSelecionado.HorarioTermino = evento.HorarioTermino;
            eventoSelecionado.Classificacao = evento.Classificacao;
            eventoSelecionado.Local = evento.Local;
            eventoSelecionado.Valor = evento.Valor;
            eventoSelecionado.Organizador = evento.Organizador;

            return eventoSelecionado;
        }

        public void updateEvento(int index, Evento e)
        {
            eventos[index].Nome = e.Nome;
            eventos[index].Data = e.Data;
            eventos[index].Descricao = e.Descricao;
            eventos[index].HorarioInicio = e.HorarioInicio;
            eventos[index].HorarioTermino = e.HorarioTermino;
            eventos[index].Classificacao = e.Classificacao;
            eventos[index].Local = e.Local;
            eventos[index].Valor = e.Valor;
            eventos[index].Organizador = e.Organizador;
        }

        public void deleteEvento(int index)
        {
            eventos.RemoveAt(index);
        }
    }
}
