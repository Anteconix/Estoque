using Bogus;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    public class ControleBuilder
    {
        private int quantidade = 1;
        private string valor_compra = "6969";
        private string data_entrada = "6969";
        private string fornecedor = "magno";
        private int num_fatura= 123;
        private string motivo_ent= "entrou";

        public static ControleBuilder NovoCon()
        {
            return new ControleBuilder();
        }


        public Controle CriarCon()
        {
            return new Controle(
                quantidade,
                valor_compra,
                data_entrada,
                fornecedor,
                num_fatura,
                motivo_ent);
        }


        public ControleBuilder GerarDadosCon()
        {
            Faker faker = new Faker();

            quantidade = faker.Random.Int(1, 1000);
            valor_compra = faker.Random.Word();
            data_entrada = faker.Random.Word();
            fornecedor = faker.Random.Word();
            num_fatura = faker.Random.Int(1, 1000);
            motivo_ent = faker.Random.Word();

            return this;
        }
        public ControleBuilder ComQuaCon(int qua_con)
        {
            this.quantidade = qua_con;
            return this;
        }


        public ControleBuilder ComValComCon(string valcom_con)
        {
            this.valor_compra = valcom_con;
            return this;
        }

        public ControleBuilder ComDatEntCon(string datent_con)
        {
            this.data_entrada = datent_con;
            return this;
        }
        public ControleBuilder ComForCon(string for_con)
        {
            this.fornecedor = for_con;
            return this;
        }
        public ControleBuilder ComNumFatCon(int numfat_con)
        {
            this.num_fatura = numfat_con;
            return this;
        }
        public ControleBuilder ComMotEntCon(string motent_con)
        {
            this.motivo_ent = motent_con;
            return this;
        }
    }
}
