using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_26_Udemy_Projeto_usando_lógica_trabalhando_com_objetos.Entities.Enums
{
    internal enum OrderStatus : int
    {
        Pending_Payament = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3,
    }
}
