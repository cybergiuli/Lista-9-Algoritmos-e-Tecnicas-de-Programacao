using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_1
{
    internal class Cliente
    {
		private string nome;
		private string endere;
		private string tel;

		public Cliente (string nome, string endere, string tel)
		{
			this.nome = nome;
			this.endere = endere;
			this.tel = tel;
		}

        public Cliente(string nome, string endere)
        {
            this.nome = nome;
            this.endere = endere;
            tel = "0";
        }

        public string Nome
        {
            get { return Nome; }
            set { Nome = value; }
        }
        public string Endere
		{
			get { return Endere; }
			set { Endere = value; }
		}

        public string Tel
        {
            get { return Tel; }
            set { Tel = value; }
        }

        public override string ToString()
        {
            return ($"Nome: {nome}, Endereço: {endere}, Telefone: {tel}");
        }

    }
}
