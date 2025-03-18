using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_22_1_Udemy
{
    internal class Calculadora
    {
        public static int Soma(params int[] number)
        {

            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                sum += number[i];
            }

            return sum;
        }
    }
}
