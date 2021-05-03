using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogos.Exceptions
{
    public class JogoNaoCadastradoExceptions : Exception
    {
        public JogoNaoCadastradoExceptions()
            : base("Este jogo não está cadastrado")
        {

        }
    }
}
