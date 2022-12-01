using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_teste_csharp._12_Abstracao
{
    abstract class Padrao
    {
        /* CONCEITO DE ABSTRAÇÃO
         * 1 - É uma classe que pode conter métodos obrigatórios para todas as classes que a herdarem
         * Ex: toda classe que herdá-la terá um método para calcular imposto ou um método para conectar com um banco de dados
         * 
         * 2 - também é possível criar métodos opcionais, não obrigatórios 
         * 
         * 3 - Não é possivel instanciar uma classe abstrata, ex: Padrao padrao = new Padra(); não é possível
         * 
         * 4 - As outros classes só pode herdar apenas 1 classe abstrata, não dá para herdar multiplas classes 
         * 
         */


        // Método Obrigatório = pode ser público ou privado
        public abstract void taxaEmprestimo(double valor); // Esse método foi sobrecarrecado nas classes que herdam a classe Padrao

        public void calculaPoupanca(double valor, double taxa)
        {
            Console.WriteLine("Ganhos obtidos pela poupança: R$ "+(valor*taxa));
        }

    }
}
