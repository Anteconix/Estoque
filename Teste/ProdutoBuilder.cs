using Bogus;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    public class ProdutoBuilder
    {
        private string desc_produto = "magno alugueis";
        private int cod_barras = 6969;
        private string preco_compra = "6969";
        private string preco_venda = "123";

        public static ProdutoBuilder NovoPro()
        {
            return new ProdutoBuilder();
        }


        public Produto CriarPro()
        {
            return new Produto(
                desc_produto,
                cod_barras,
                preco_compra,
                preco_venda); ;
        }


        public ProdutoBuilder GerarDadosPro()
        {
            Faker faker = new Faker();

            desc_produto = faker.Random.Word();
            cod_barras = faker.Random.Int(1, 1000);
            preco_compra = faker.Random.Word();
            preco_venda = faker.Random.Word();

            return this;
        }
        public ProdutoBuilder ComDescPro(string des_pro)
        {
            this.desc_produto = des_pro;
            return this;
        }


        public ProdutoBuilder ComCodPro(int cod_pro)
        {
            this.cod_barras = cod_pro;
            return this;
        }

        public ProdutoBuilder ComPreComPro(string precom_pro)
        {
            this.preco_compra = precom_pro;
            return this;
        }
        public ProdutoBuilder ComPreVenPro(string preven_pro)
        {
            this.preco_venda = preven_pro;
            return this;
        }
    }
}
