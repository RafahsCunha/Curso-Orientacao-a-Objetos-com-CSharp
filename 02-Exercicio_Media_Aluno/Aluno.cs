using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_teste_csharp.Exercicio_Media_Aluno
{
    public class Aluno
    {
        // EXERCICIO CALCULA MÉDIA DO ALUNO               
        
        // Atributos
        public string nome;
        public double nota1, nota2;

        // Método Média
        public double media(double nota1, double nota2)
        {
            double resultado = (nota1 + nota2) / 2;
            
            return resultado;
        }
         
        // Método Aprovado ou Reprovado
        public string situacao(double media)
        {
            
            return media >= 6 ? " 'aprovado' " : " reprovado"; // Operador ternário

        }

        // Método Mensagem
        public void mensagem()
        {
            // Obter Media
            double getMedia = media(nota1, nota2);

            // Obter situação
            string pegarSituacao = situacao(getMedia);

            string parabens;

            if (getMedia >= 6)
            { 
                parabens = " - Parabéns ^_^ ";
            }
            else
            {
                parabens = " - Vixi, tente novamente depois!";
            }

            Console.WriteLine("O Aluno " + nome + "está " + pegarSituacao + " com média " + getMedia + parabens); 
        }
    } 
}
