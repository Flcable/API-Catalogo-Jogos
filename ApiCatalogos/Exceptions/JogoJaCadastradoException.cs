using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogos.Exceptions
{
    public class JogoJaCadastradoExceptions : Exception
    {
        public JogoJaCadastradoExceptions()
            : base("Este Jogo já está cadastrado")
        {

        }
    }
}
