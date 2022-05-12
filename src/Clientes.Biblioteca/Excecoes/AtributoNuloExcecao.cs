using System;

namespace Clientes.Biblioteca.Excecoes
{
    public class AtributoNuloExcecao : Exception
    {
        public AtributoNuloExcecao(string nomeAtributo) : base($"Atributo {nomeAtributo} não pode ser nulo.") { }
       
    }
}
