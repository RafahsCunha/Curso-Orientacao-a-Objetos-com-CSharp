using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_teste_csharp.ModificadoresDeAcesso
{
    class Produto
    {
        /* MODIFICADORES DE ACESSO
         
         public    -> Atributos e métodos visiveis em qualquer classe
         private   -> Atributos e métodos visíveis apenas na classe onde são criados
         protected -> Atributos e métodos visiveis em classe onde são criados ou herdados
        
         */

        public string nomeProd; // Visivel na classe Program.cs

        private double valorProd; // Não visivel na classe Program.cs
    }
}
