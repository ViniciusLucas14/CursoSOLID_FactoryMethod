using OCP_FactoryMethod_Vinicius;

namespace OCP_Aderente
{
    class DescontoClienteAssociado : Pedido
    {
        public override double DescontoPedido(double valorFinal)
        {
            return valorFinal - 10;
        }
    }
}
