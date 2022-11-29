using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_teste_csharp._11_Atributos_e_metodos_Estaticos
{
    class Exemplo
    {   
        /* Método estatico permite que o método seja acessado sem ter que criar um objeto
         * a palavra static define um método estatico
         */


        // Método Estatico
        public static void soma (int num1, int num2)
        {
            Console.WriteLine("Resultado: "+ (num1 + num2));
        }

        // Atributo Estatico
        public static int valor1;
        public static int valor2;
    }
}
