using Xunit;
namespace NerdStore.Vendas.Domain.Tests
{
    public class PedidoTestes
    {
        [Fact]
        public void Test1()
        {

        }

        [Fact(DisplayName = "Adicionar Item Novo Pedido")]
        [Trait("Categoria", "Pedido Testes")]
        public void AdicionarItemPedido_NovoPedido_DeveAtualizarValor()
        {
            // Arrange
            var pedido = new Pedido();
            var pedidoItem = new PedidoItem(Guid.NewGuid(), "Produto Teste", 2, 100);
            // Act

            pedido.AdicionarItem(pedidoItem);


            // Assert
            Assert.Equal(200, pedido.ValorTotal);

        }
    }
}