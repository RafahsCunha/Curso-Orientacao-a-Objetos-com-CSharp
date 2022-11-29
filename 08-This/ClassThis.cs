using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace projeto_teste_csharp.This
{
    class ClassThis
    {
        // Atributo privado 
        private string nome;

        // Construtor
        public ClassThis(string nome)
        {
            Console.WriteLine("Nome do costrutor: "+ nome);
            Console.WriteLine(this.nome = "Olá mundo");
        }

        public void tome() // método de teste para verificar o valor que está no atributo nome
        {
            string test = this.nome;
            Console.WriteLine("Imprime o alor do atributo nome: " + test);
        }
    }
}
