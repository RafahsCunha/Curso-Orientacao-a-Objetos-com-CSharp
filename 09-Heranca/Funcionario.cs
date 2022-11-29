using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_teste_csharp.Heranca
{
    class Funcionario
    {
        /*
         * Atributos protected
         * Atributos protected são visiveis dentro da classe ou pela classe herdada. 
         */
        protected string nome;
        protected int idade;


        // Método Protected
        // Possui a mesma característica de acesso dos atributos acima
        protected void mensagemFuncionario()
        {
            Console.WriteLine("Nome: " +this.nome); // OBS, poderia ser sem o this
            Console.WriteLine("Idade: " +this.idade); // OBS, poderia ser sem o this
            
        }

    }
}
