using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Orientacao_a_Objetos_com_CSharp.Interface
{
    interface IPadrao
    {
        // CONCEITO DE INTERFACE

        /* Interface é utilizada para criar exclusivamente métodos obrigatórios
         * 
         * Uma classe pode implementar várias interfaces, diferentemente da classe abstrata que só pode ser herdada 1 vez
         * 
         * Os métodos da interface não possuem cálculos, condicionais, laços e demais ações. 
         * ex. de métodos da interface: double calculo(double numero);
         * string texto();
         * void mensagem(string nome, int idade);
         * A regra ou calculo é definido na classe que implementa a interface, por isso o método é sobrecarregado com override
         *  
         * No c#, por padrão, um método criado na Interface é abstrato e público, por isso não é necessário passar esses tipos antes de criar o método
         * 
         *  Nas boas práticas de C#, toda interface tem a inicial I antes do nome da interface. Ex: 
         *  IPadrao
         *  ICalculo
         *  IConsulta
         *  IAcoes
         */


        // Métodos da Interface. OBS não precisa passar o tipo do método:
        void somar(int n1, int n2);

        void subtrair(int n1, int n2); 



    }
}
