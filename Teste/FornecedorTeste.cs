using ExpectedObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    public class FornecedorTeste
    {
        [Fact]
        public void CriarObjetoFornecedor()
        {
            // Arrange com objeto anônimo
            var forn = FornecedorBuilder.NovoEmp().GerarDadosEmp().CriarEmp();

            var fornecedorEsperado = new
            {
                Nome_empresa = forn.Nome_empresa,
                Endereco_empresa = forn.Endereco_empresa,
                Telefone_empresa = forn.Telefone_empresa,
            };

            // Act

            // Assert com ExpectedObject
            fornecedorEsperado.ToExpectedObject().ShouldMatch(forn);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void FornecedorNomeInvalido(string nom_emp)
        {
            Assert.Throws<ArgumentException>(
                () =>
                FornecedorBuilder.NovoEmp().GerarDadosEmp().ComNomeEmp(nom_emp).CriarEmp()
            ).ComMensagem("Nome inválido");

        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void FornecedorEnderecoInvalido(string end_emp)
        {
            Assert.Throws<ArgumentException>(
                () =>
                FornecedorBuilder.NovoEmp().GerarDadosEmp().ComEnderecoEmp(end_emp).CriarEmp()
            ).ComMensagem("Endereço inválido");

        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void FornecedorTelefoneInvalido(string tel_emp)
        {
            Assert.Throws<ArgumentException>(
                () =>
                FornecedorBuilder.NovoEmp().GerarDadosEmp().ComTelefoneEmp(tel_emp).CriarEmp()
            ).ComMensagem("Telefone inválido");

        }
    }
}
