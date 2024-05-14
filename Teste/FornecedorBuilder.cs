using Bogus;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    public class FornecedorBuilder
    {
        private string nome_empresa = "magno alugueis";
        private string endereco_empresa = "Parque Yellowstone";
        private string telefone_empresa = "123";

        public static FornecedorBuilder NovoEmp()
        {
            return new FornecedorBuilder();
        }


        public Fornecedor CriarEmp()
        {
            return new Fornecedor(
                nome_empresa,
                endereco_empresa,
                telefone_empresa);
        }


        public FornecedorBuilder GerarDadosEmp()
        {
            Faker faker = new Faker();

            nome_empresa = faker.Person.FullName;
            endereco_empresa = faker.Address.FullAddress();
            telefone_empresa = faker.Person.Phone;

            return this;
        }
        public FornecedorBuilder ComNomeEmp(string nom_emp)
        {
            this.nome_empresa = nom_emp;
            return this;
        }


        public FornecedorBuilder ComEnderecoEmp(string end_emp)
        {
            this.endereco_empresa = end_emp;
            return this;
        }

        public FornecedorBuilder ComTelefoneEmp(string fon_emp)
        {
            this.telefone_empresa = fon_emp;
            return this;
        }
    }
}
