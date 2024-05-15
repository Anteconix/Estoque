using ExpectedObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    public class Controleteste
    {
        [Fact]
        public void CriarObjetoControle()
        {
            // Arrange com objeto anônimo
            var con = ControleBuilder.NovoCon().GerarDadosCon().CriarCon();

            var controleEsperado = new
            {
                Quantidade = con.Quantidade,
                Valor_compra = con.Valor_compra,
                Data_entrada = con.Data_entrada,
                Fornecedor = con.Fornecedor,
                Num_fatura = con.Num_fatura,
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
        public void ControleQuaInvalido(int qua_con)
        {
            Assert.Throws<ArgumentException>(
                () =>
                ControleBuilder.NovoCon().GerarDadosCon().ComQuaCon(qua_con).CriarCon()
            ).ComMensagem("Quantidade inválida");

        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ControleValComInvalido(string valcom_con)
        {
            Assert.Throws<ArgumentException>(
                () =>
                ControleBuilder.NovoCon().GerarDadosCon().ComValComCon(valcom_con).CriarCon()
            ).ComMensagem("Valor da compra inválido");

        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ControleDatEntInvalido(string datent_con)
        {
            Assert.Throws<ArgumentException>(
                () =>
                ControleBuilder.NovoCon().GerarDadosCon().ComDatEntCon(datent_con).CriarCon()
            ).ComMensagem("Data de entrada inválida");

        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ControleForInvalido(string for_con)
        {
            Assert.Throws<ArgumentException>(
                () =>
                ControleBuilder.NovoCon().GerarDadosCon().ComForCon(for_con).CriarCon()
            ).ComMensagem("Fornecedor inválido");

        }

        [Theory]
        [InlineData(null)]
        [InlineData(0)]
        [InlineData(-1)]
        public void ControleNumFatInvalido(int numfat_con)
        {
            Assert.Throws<ArgumentException>(
                () =>
                ControleBuilder.NovoCon().GerarDadosCon().ComNumFatCon(numfat_con).CriarCon()
            ).ComMensagem("Número da fatura inválido");
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ControleMotEntInvalido(string motent_con)
        {
            Assert.Throws<ArgumentException>(
                () =>
                ControleBuilder.NovoCon().GerarDadosCon().ComMotEntCon(motent_con).CriarCon()
            ).ComMensagem("Motivo de entrada inválido");

        }
    }
}
