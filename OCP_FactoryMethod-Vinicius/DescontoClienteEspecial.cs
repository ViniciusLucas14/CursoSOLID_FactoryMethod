using OCP_FactoryMethod_Vinicius;

namespace OCP_Aderente
{
    class DescontoClienteEspecial : Pedido
    {
        public override double DescontoPedido(double valorFinal)
        {
            return valorFinal - 50;
        }
    }
}
