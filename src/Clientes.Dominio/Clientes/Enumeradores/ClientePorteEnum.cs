using System.ComponentModel;

namespace Clientes.Dominio.Clientes.Enumeradores
{
    public enum ClientePorteEnum
    {
        [Description("Pequena empresa")]
        Pequeno,
        [Description("Média empresa")]
        Medio,
        [Description("Grande empresa")]
        Grande
    }
}
