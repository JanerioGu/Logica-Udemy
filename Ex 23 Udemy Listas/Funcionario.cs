using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_23_Udemy
{
    internal class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentarSalario(double aumentoPercentual)
        {
            Salario += Salario * (aumentoPercentual / 100);
        }


        public override string ToString()
        {
            return "funcionario ID: " + Id + "\n" + 
                "Nome: " + Nome + " \n" +
                "Salario: " + Salario;
        }
    }
}
