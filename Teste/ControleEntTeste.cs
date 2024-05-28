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
            var con = ControleEntBuilder.NovoCon().GerarDadosConEnt().CriarCon();

            var controleEsperado = new
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
            controleEsperado.ToExpectedObject().ShouldMatch(con);
        }

        [Theory]
        [InlineData(null)]
        [InlineData(0)]
        [InlineData(-1)]
        public void ControleQuaEntInvalido(int qua_conent)
        {
            Assert.Throws<ArgumentException>(
                () =>
                ControleEntBuilder.NovoCon().GerarDadosConEnt().ComQuaConEnt(qua_conent).CriarCon()
            ).ComMensagem("Quantidade inválida");

        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ControleValComEntInvalido(string valcom_conent)
        {
            Assert.Throws<ArgumentException>(
                () =>
                ControleEntBuilder.NovoCon().GerarDadosConEnt().ComValComConEnt(valcom_conent).CriarCon()
            ).ComMensagem("Valor da compra inválido");

        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ControleDatEntInvalido(string datent_con)
        {
            Assert.Throws<ArgumentException>(
                () =>
                ControleEntBuilder.NovoCon().GerarDadosConEnt().ComDatConEnt(datent_con).CriarCon()
            ).ComMensagem("Data de entrada inválida");

        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ControleForInvalido(string for_conent)
        {
            Assert.Throws<ArgumentException>(
                () =>
                ControleEntBuilder.NovoCon().GerarDadosConEnt().ComForConEnt(for_conent).CriarCon()
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
                ControleEntBuilder.NovoCon().GerarDadosConEnt().ComNumFatConEnt(numfat_conent).CriarCon()
            ).ComMensagem("Número da fatura inválido");
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ControleMotEntInvalido(string motent_conent)
        {
            Assert.Throws<ArgumentException>(
                () =>
                ControleEntBuilder.NovoCon().GerarDadosConEnt().ComMotConEnt(motent_conent).CriarCon()
            ).ComMensagem("Motivo de entrada inválido");

        }
    }
}
