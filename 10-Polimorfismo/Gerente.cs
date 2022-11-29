using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_teste_csharp.A10_Polimorfismo
{
    class Gerente : Imposto
    {   
        // Método valeAlimentação
        public override void valeAlimentacao(double salario) // override é uma reescrita do método valeAlimentalçao. Esse método vem da classe imposto e é sobrecarregado nesta classe
        {
            Console.WriteLine("Desconto do vale alimentação: R$" + (salario * 0.2));
        }
        public override void valeTransporte(double salario)
        {
            Console.WriteLine("Desconto do vale transporte: R$" + (salario * 0.15));
        }
    }
}
