using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_teste_csharp._12_Abstracao
{
    class PessoaFisica : Padrao
    {
        // Implementando o método obrigatório (ASBTRATO) da classe abstrata Padrao
        // override = sobrecarga de método
        public override void taxaEmprestimo(double valor)
        {
            Console.WriteLine("Taxa de emprestimo para Pessoa Física R$ " + (valor * 0.1));
        }

    }
}
