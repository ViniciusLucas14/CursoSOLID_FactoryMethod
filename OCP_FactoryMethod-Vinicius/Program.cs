using System;

namespace OCP_FactoryMethod_Vinicius
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o tipo do Cliente: ");
            Console.WriteLine("Vip(0) / Associado(1) / Especial(2)");
            int tipoCliente = Convert.ToInt32(Console.ReadLine());
            try
            {
                CriarDescontoCliente factory = new CriarDescontoCliente();

                Pedido desconto = factory.CriarDescontoTipoCliente(tipoCliente);

                Console.WriteLine(desconto.DescontoPedido(100));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro" + ex.Message);
            }
        }
    }
}
