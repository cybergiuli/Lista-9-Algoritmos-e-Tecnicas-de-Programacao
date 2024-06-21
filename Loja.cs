using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_1
{
    internal class Loja
    {

        static void ImprimirClientes(Cliente[] clientes)
        {
            for (int i = 0; i < clientes.Length; i++)
            {
                Console.WriteLine(clientes[i]);
            }
        }

        static void LerClientes(Cliente[] clientes)
        {
            string nome, ende, op, tel;

            for (int i = 0; i < clientes.Length; i++)
            {
                Console.WriteLine("Escreva o seu nome:");
                nome = Console.ReadLine();

                Console.WriteLine("Escreva seu endereço:");
                ende = Console.ReadLine();

                Console.WriteLine("Você possi número de telefone? Digite sim ou não");
                op = Console.ReadLine();

                if (op == "sim")
                {
                    Console.WriteLine("Escreva seu telefone:");
                    tel = Console.ReadLine();
                    clientes[i] = new Cliente(nome, ende, tel);
                }
                else
                {
                    clientes[i] = new Cliente(nome, ende);
                }

                

            }
        }
        static void Main(string[] args)
        {
            Cliente[] clientes = new Cliente[3];
            LerClientes(clientes);
            ImprimirClientes(clientes);
            Console.Read();
        }
    }
}
