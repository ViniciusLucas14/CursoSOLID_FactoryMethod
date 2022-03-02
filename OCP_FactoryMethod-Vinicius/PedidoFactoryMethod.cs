using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_FactoryMethod_Vinicius
{
    public abstract class PedidoFactoryMethod
    {
        public abstract Pedido CriarDescontoTipoCliente(int tipoCliente);
    }
}
