using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_teste_csharp.Metodos
{
    internal class Pessoa // Classe Pessoa. OBS começa com letra maiúscula
    {

        // EXEMPLO DE SOBRECARGA DE MÉTODOS

        public void pessoa()// método pessoa. OBS começa com letra minúscula
        {
            Console.WriteLine("Olá, esse método não possui parâmetros");
        }

        public void pessoa(string nome, int idade)// método pessoa. OBS começa com letra minúscula
        {
            Console.WriteLine("Nome: " + nome + "\nIdade: " + idade);

        }
        public void pessoa(string nome, string sobrenome,
            int idade, string nacionalidade)// método pessoa. OBS começa com letra minúscula
        {
            Console.WriteLine("Nome: " + nome + "\nSobrenome: " + sobrenome + "\nIdade: " + idade +
                "\nNacionalidade: " + nacionalidade);
        }
    }



}
