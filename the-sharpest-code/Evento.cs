using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_sharpest_code
{
    class Evento
    {
        private string nome;
        private DateTime data;
        private string descricao;
        private DateTime horario_inicio;
        private DateTime horario_termino;
        private int classificacao;
        private string local;
        private double valor;
        private User organizador;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public DateTime HorarioInicio
        {
            get { return horario_inicio; }
            set { horario_inicio = value; }
        }

        public DateTime HorarioTermino
        {
            get { return horario_termino; }
            set { horario_termino = value; }
        }

        public int Classificacao
        {
            get { return classificacao; }
            set { classificacao = value; }
        }

        public string Local
        {
            get { return local; }
            set { local = value; }
        }

        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public User Organizador
        {
            get { return organizador; }
            set { organizador = value; }
        }
    }
}
