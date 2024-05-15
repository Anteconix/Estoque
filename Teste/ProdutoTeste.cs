using ExpectedObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    public class Produtoteste
    {
        [Fact]
        public void CriarObjetoProduto()
        {
            // Arrange com objeto anônimo
            var prod = ProdutoBuilder.NovoPro().GerarDadosPro().CriarPro();

            var produtoEsperado = new
            {
                Desc_produto = prod.Desc_produto,
                Cod_barras = prod.Cod_barras,
                Preco_compra = prod.Preco_compra,
                Preco_venda = prod.Preco_venda
            };

            // Act

            // Assert com ExpectedObject
            produtoEsperado.ToExpectedObject().ShouldMatch(prod);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ProdutoDescInvalido(string des_pro)
        {
            Assert.Throws<ArgumentException>(
                () =>
                ProdutoBuilder.NovoPro().GerarDadosPro().ComDescPro(des_pro).CriarPro()
            ).ComMensagem("Descrição inválida");

        }

        [Theory]
        [InlineData(null)]
        [InlineData(0)]
        [InlineData(-1)]
        public void ProdutoCodInvalido(int cod_pro)
        {
            Assert.Throws<ArgumentException>(
                () =>
                ProdutoBuilder.NovoPro().GerarDadosPro().ComCodPro(cod_pro).CriarPro()
            ).ComMensagem("Código de barras inválido");

        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void produtoPreComInvalido(string precom_pro)
        {
            Assert.Throws<ArgumentException>(
                () =>
                ProdutoBuilder.NovoPro().GerarDadosPro().ComPreComPro(precom_pro).CriarPro()
            ).ComMensagem("Preço de compra inválido");

        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void produtoPreVemInvalido(string preven_pro)
        {
            Assert.Throws<ArgumentException>(
                () =>
                ProdutoBuilder.NovoPro().GerarDadosPro().ComPreVenPro(preven_pro).CriarPro()
            ).ComMensagem("Preço de venda inválido");

        }
    }
}
