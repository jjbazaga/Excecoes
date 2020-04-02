using System;

namespace EstudoExcecao_2.Entidades.Excecoes
{
    class DominioExcecao : ApplicationException
    {
        public DominioExcecao(string mensagem) 
            : base(mensagem)
        {
        }
    }
}