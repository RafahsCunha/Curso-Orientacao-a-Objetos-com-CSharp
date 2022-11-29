using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_teste_csharp.Get_e_Set
{
    class Get_Set
    {
        // atributo nome
        private string nome ;

        /* get e set
             Get pega o valor, Set envia o valor 
             Todo get e set são publicos para que outras classes tenham acesso
         */

        public string Nome // Get e Set possui o mesmo nome do atributo, só que com a primeira letra maiuscula
        {
            get { return nome; }
            set { nome = value; }
        }
    }
}
