using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_teste_csharp.Construtores
{
    class Construtor
    {
        // Construtor da classe. Possui o mesmo nome da classe Todo construtor é publico.
        public Construtor() 
        {
            Console.WriteLine("<<< Programa da classe construtor >>>");
        }

        /* Podem existir vários construtores com o mesmo nome,
           porém as características precisam ser diferentes
        */
        public Construtor(string mensagem) // Construtor com parâmetro
        {
            Console.WriteLine("Escreva uma mensagem: " + mensagem);
        }
    }
}
