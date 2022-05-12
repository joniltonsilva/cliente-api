using AutoMapper;
using Clientes.Dominio.Clientes.Entidades;
using Clientes.DTO.Clientes.Response;

namespace Clientes.Aplicacao.Clientes.AutoMapper
{
    public class ClienteProfile : Profile
    {
        public ClienteProfile()
        {
            CreateMap<Cliente, ClienteResponse>();
        }
    }
}
