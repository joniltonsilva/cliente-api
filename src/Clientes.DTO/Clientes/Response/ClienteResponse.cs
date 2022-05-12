using Clientes.Dominio.Clientes.Enumeradores;

namespace Clientes.DTO.Clientes.Response
{
    public class ClienteResponse
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ClientePorteEnum Porte { get; set; }
    }
}
