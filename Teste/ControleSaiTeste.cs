using ExpectedObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    public class ControleSaiTeste
    {
        [Fact]
        public void CriarObjetoControle()
        {
            // Arrange com objeto anônimo
            var con = ControleSaiBuilder.NovoConSai().GerarDadosConSai().CriarConSai();

            var controleSaiEsperado = new
            {
                Quantidadesai = con.Quantidadesai,
                Valor_vendasai = con.Valor_vendasai,
                Data_saida = con.Data_saida,
                Cliente = con.Cliente,
                Motivo_sai = con.Motivo_sai
            };

            // Act

            // Assert com ExpectedObject
            controleSaiEsperado.ToExpectedObject().ShouldMatch(con);
        }

        [Theory]
        [InlineData(null)]
        [InlineData(0)]
        [InlineData(-1)]
        public void ControleQuaSaiInvalido(int qua_conent)
        {
            Assert.Throws<ArgumentException>(
                () =>
                ControleSaiBuilder.NovoConSai().GerarDadosConSai().ComQuaConSai(qua_conent).CriarConSai()
            ).ComMensagem("Quantidade inválida");

        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ControleValVenConSaiInvalido(string valven_consai)
        {
            Assert.Throws<ArgumentException>(
                () =>
                ControleSaiBuilder.NovoConSai().GerarDadosConSai().ComValVenConSai(valven_consai).CriarConSai()
            ).ComMensagem("Valor de venda inválido");

        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ControleDatSaiInvalido(string datsai_con)
        {
            Assert.Throws<ArgumentException>(
                () =>
                ControleSaiBuilder.NovoConSai().GerarDadosConSai().ComDatConSai(datsai_con).CriarConSai()
            ).ComMensagem("Data de saída inválida");

        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ControleCliInvalido(string cli_consai)
        {
            Assert.Throws<ArgumentException>(
                () =>
                ControleSaiBuilder.NovoConSai().GerarDadosConSai().ComCliCon(cli_consai).CriarConSai()
            ).ComMensagem("Cliente inválido");

        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ControleMotSaiInvalido(string motsai_con)
        {
            Assert.Throws<ArgumentException>(
                () =>
                ControleSaiBuilder.NovoConSai().GerarDadosConSai().ComMotSaiCon(motsai_con).CriarConSai()
            ).ComMensagem("Motivo de saída inválido");

        }
    }
}
