using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_teste_csharp.Heranca
{
    class Colaborador : Funcionario // Classe Colaborador está herdando a classe Funcionário
        /*
         * No C# não existe herança multipla
         * o sinal para estender uma classe é o :
         */
    {

        // Atributos privados
        private double salario;

        // Construtor
        public Colaborador(string nome, int idade, double salario)
        {
            this.nome = nome; // herda os atributos da classe Funcionario e passa para os parâmetros do construtor Colaborador
            this.idade = idade;
            this.salario = salario;

            mensagemFuncionario();
            mensagemColaborador();

        }

        // Método privado
        private void mensagemColaborador()
        {
            Console.WriteLine("Salario: " + salario);
        }

    }
}
