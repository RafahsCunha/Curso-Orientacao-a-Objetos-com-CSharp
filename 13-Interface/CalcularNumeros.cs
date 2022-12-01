using Projeto_Orientacao_a_Objetos_com_CSharp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Orientacao_a_Objetos_com_CSharp._13_Interface
{
    class CalcularNumeros : IPadrao
    {   
        public void somar(int n1, int n2)
        {
            Console.WriteLine("A soma é: " + (n1 + n2));
        }
        public void subtrair(int n1, int n2)
        {
            Console.WriteLine("A subtração é: " + (n1 - n2));
        }
    }
}
