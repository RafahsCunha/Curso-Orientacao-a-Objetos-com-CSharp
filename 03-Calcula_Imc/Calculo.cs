using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_teste_csharp.Calcula_Imc
{
    public class Calculo
    {
        // Programa Calculando IMC 

        public double peso, altura; // atributos

        // Método calcula o IMC
        public double calculaImc()
        {
            return peso / (altura * altura);
        }

        // Método que retorna a situação em string
        public string situacao(double imc)
        {
            string retorno;

            if (imc <= 18.5)
            {
                retorno = "Abaixo do peso...";
            }
            else if (imc <= 25)
            {
                retorno = "Peso Normal, Parabéns.";
            }
            else if (imc <= 30)
            {
                retorno = "Acima do peso.";
            }
            else if (imc <= 35)
            {
                retorno = "Obesidade I.";
            }
            else if (imc <= 40)
            {
                retorno = "Obesidade II.";
            }
            else if (imc >= 41)
            {
                retorno = "Obesidade III";
            }
            else
            {
                retorno = "Peso ou Altura não informados corretamente!!!";
            }

            return retorno;

        }

        // Método imprime mensagem
        public void mensagem()
        {
            double obterCalculo = calculaImc();

            string obterSituacao = situacao(obterCalculo);

            Console.WriteLine("Seu IMC é de: " + obterCalculo + "\nSua situação é: " + obterSituacao);

        }
    }
}
