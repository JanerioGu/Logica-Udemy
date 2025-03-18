using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_26_Udemy_Projeto_usando_lógica_trabalhando_com_objetos.Entities
{
    internal class Cliente
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Cliente()
        {

        }
        public Cliente(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return "Name: " + Name + " " +
                "Email: " + Email + " " +
                "BirthDate" + BirthDate;
        }
    }
}
