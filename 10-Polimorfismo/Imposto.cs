using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_teste_csharp.A10_Polimorfismo
{
    class Imposto
    {
        // Método valeAlimentacao
        public virtual void valeAlimentacao(double salario) // virtual quer dizer que esse método será herdado e aproveitado em outra classe
        {
            Console.WriteLine("Desconto do vale alimentação: R$" + (salario * 0.09));
        } 
        // Método valeTransporte 
        public virtual void valeTransporte(double salario)
        {
            Console.WriteLine("Desconto do vale transporte: R$" + (salario * 0.06));
        }

    }
}
