using OCP_Aderente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_FactoryMethod_Vinicius
{
    internal class CriarDescontoCliente : PedidoFactoryMethod
    {
        public override Pedido CriarDescontoTipoCliente(int tipoCliente)
        {

            if (tipoCliente == (int)TipoCliente.Associado) return new DescontoClienteAssociado();

            else if (tipoCliente == (int)TipoCliente.Especial) return new DescontoClienteEspecial();

            else if (tipoCliente == (int)TipoCliente.Vip) return new DescontoClienteVIP();

            else throw new System.ArgumentException("Cliente não existe");
        }
    }
}
