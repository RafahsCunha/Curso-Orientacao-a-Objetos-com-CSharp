using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_teste_csharp.A10_Polimorfismo
{
    class Atendente : Imposto
    {
        public override void valeAlimentacao(double salario)
        {
            Console.WriteLine("Desconto do vale alimentação: R$" + (salario * 0.1));
        }
        public override void valeTransporte(double salario)
        {
            Console.WriteLine("Desconto do vale transporte: R$" + (salario * 0.08));
        }
    }
}
