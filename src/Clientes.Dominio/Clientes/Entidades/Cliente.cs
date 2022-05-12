using Clientes.Biblioteca.Excecoes;
using Clientes.Dominio.Clientes.Enumeradores;

namespace Clientes.Dominio.Clientes.Entidades
{
    public class Cliente
    {
        public virtual int Id { get; private set; }
        public virtual string Nome { get; private set; }
        public virtual ClientePorteEnum Porte { get; private set; }

        public Cliente(string nome, ClientePorteEnum porte)
        {
            SetNome(nome);
            SetPorte(porte);
        }

        public virtual void SetNome(string nome)
        {
            if (nome is null) throw new AtributoNuloExcecao(nameof(Nome));

            Nome = nome;
        }

        public virtual void SetPorte(ClientePorteEnum porte)
        {
            Porte = porte;
        }
    }
}
