
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_20_Udemy_PROJETINHO
{
    internal class DadosBancarios
    {
        public string NomeUsuario { get; set; }
        public int NumeroConta { get; }
        public double Saldo { get; private set; }


        public DadosBancarios(string nomeUsuario, int numeroConta)
        {
            NomeUsuario = nomeUsuario;
            NumeroConta = numeroConta;
        }

        public DadosBancarios(string nommeUsuario, int numeroConta, double saldo) : this(nommeUsuario, numeroConta)
        {
            Saldo = saldo;
        }

        public void Depositar(double vlr)
        {
            Saldo += vlr;
        }

        public void Sacar(double vlr)
        {
            Saldo = (Saldo - vlr) - 5.0;
        }

        public static DadosBancarios Escolha(string escolha, string nome, int numeroConta)
        {
            if (escolha.ToUpper() == "S")
            {
                Console.WriteLine("Insira o saldo incial: ");
                double saldoIncial = Double.Parse(Console.ReadLine());

                return new DadosBancarios(nome, numeroConta, saldoIncial);

            }
            else
            {
                return new DadosBancarios(nome, numeroConta);
            }
        }

        public override string ToString()
        {
            return "Nome Usuario: " + NomeUsuario 
                + ", Numero da conta: " + NumeroConta 
                + ", Saldo: " + Saldo.ToString("F2");
        }

    }
}
