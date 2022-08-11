using System;
using System.Collections.Generic;
using System.Text;

namespace agenda001
{
    public class Contato
    {

        public Contato()
        {
            this.Codigo = 0;
            this.Nome = "";
            this.Descricao = "";
            this.Data = "";
            this.Participantes = "";

        }
        public Contato(int codigo, string nome, string descricao, string data, string participantes)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Descricao = descricao;
            this.Data = data_local;
            this.Participantes = participantes;

        }

        private int codigo;
        public int Codigo
        {
            get { return this.codigo; }
            set { this.codigo = value; }
        }

        private string nome;
        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }
        private string descricao;

        public string Descricao
        {
            get { return this.descricao; }
            set { this.descricao = value; }
        }
        public string data_local;
        public string Data
        {
            get { return this.data_local; }
            set { this.data_local = value; }
        }
        private string participantes;

        public  static string Email;

        public static int Exclusivo;

        public string Participantes
        {
            get { return this.participantes; }
            set { this.participantes = value; }
        }

    }
}
