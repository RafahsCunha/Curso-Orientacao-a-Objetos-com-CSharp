using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_teste_csharp.Encapsulamento
{
    class Encapsulamento

    {
       
        /*
            ENCAPSULAMENTO
        */

        private double nota1, nota2; // atributos privados

        private double media() // método privado
        {
            return (nota1 + nota2)/2;
        }

        public void mensagem() // método publico
        {
            Console.WriteLine("Digire a primeira nota: ");
            nota1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            nota2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A média das notas " + nota1 + 
                " e "+nota2+ " é: " + media());
        }
    }
}
