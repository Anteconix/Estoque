using ExpectedObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    public class ControleEntTeste
    {
        [Fact]
        public void CriarObjetoControle()
        {
            // Arrange com objeto anônimo
            var con = ControleEntBuilder.NovoConEnt().GerarDadosConEnt().CriarConEnt();

            var controleEntEsperado = new
            {
                Quantidadeent = con.Quantidadeent,
                Valor_compraent = con.Valor_compraent,
                Data_entrada = con.Data_entrada,
                Fornecedorent = con.Fornecedorent,
                Num_faturaent = con.Num_faturaent,
                Motivo_ent = con.Motivo_ent
            };

            // Act

            // Assert com ExpectedObject
            controleEntEsperado.ToExpectedObject().ShouldMatch(con);
        }

        [Theory]
        [InlineData(null)]
        [InlineData(0)]
        [InlineData(-1)]
        public void ControleQuaEntInvalido(int qua_conent)
        {
            Assert.Throws<ArgumentException>(
                () =>
                ControleEntBuilder.NovoConEnt().GerarDadosConEnt().ComQuaConEnt(qua_conent).CriarConEnt()
            ).ComMensagem("Quantidade inválida");

        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ControleValComEntInvalido(string valcom_conent)
        {
            Assert.Throws<ArgumentException>(
                () =>
                ControleEntBuilder.NovoConEnt().GerarDadosConEnt().ComValComConEnt(valcom_conent).CriarConEnt()
            ).ComMensagem("Valor da compra inválido");

        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ControleDatEntInvalido(string datent_con)
        {
            Assert.Throws<ArgumentException>(
                () =>
                ControleEntBuilder.NovoConEnt().GerarDadosConEnt().ComDatConEnt(datent_con).CriarConEnt()
            ).ComMensagem("Data de entrada inválida");

        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ControleForInvalido(string for_conent)
        {
            Assert.Throws<ArgumentException>(
                () =>
                ControleEntBuilder.NovoConEnt().GerarDadosConEnt().ComForConEnt(for_conent).CriarConEnt()
            ).ComMensagem("Fornecedor inválido");

        }

        [Theory]
        [InlineData(null)]
        [InlineData(0)]
        [InlineData(-1)]
        public void ControleNumFatInvalido(int numfat_conent)
        {
            Assert.Throws<ArgumentException>(
                () =>
                ControleEntBuilder.NovoConEnt().GerarDadosConEnt().ComNumFatConEnt(numfat_conent).CriarConEnt()
            ).ComMensagem("Número da fatura inválido");
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ControleMotEntInvalido(string motent_conent)
        {
            Assert.Throws<ArgumentException>(
                () =>
                ControleEntBuilder.NovoConEnt().GerarDadosConEnt().ComMotConEnt(motent_conent).CriarConEnt()
            ).ComMensagem("Motivo de entrada inválido");

        }
    }
}
