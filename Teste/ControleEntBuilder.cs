using Bogus;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    public class ControleEntBuilder
    {
        private int quantidadeent = 1;
        private string valor_compraent = "6969";
        private string data_entrada = "6969";
        private string fornecedorent = "magno";
        private int num_faturaent = 123;
        private string motivo_ent = "entrou";
        public static ControleEntBuilder NovoCon()
        {
            return new ControleEntBuilder();
        }

        public ControleEnt CriarCon()
        {
            return new ControleEnt(
                quantidadeent,
                valor_compraent,
                data_entrada,
                fornecedorent,
                num_faturaent,
                motivo_ent);
        }

        public ControleEntBuilder GerarDadosConEnt()
        {
            Faker faker = new Faker();

            quantidadeent = faker.Random.Int(1, 1000);
            valor_compraent = faker.Random.Word();
            data_entrada = faker.Random.Word();
            fornecedorent = faker.Random.Word();
            num_faturaent = faker.Random.Int(1, 1000);
            motivo_ent = faker.Random.Word();

            return this;
        }
        public ControleEntBuilder ComQuaConEnt(int qua_conent)
        {
            this.quantidadeent = qua_conent;
            return this;
        }

        public ControleEntBuilder ComValComConEnt(string valcom_conent)
        {
            this.valor_compraent = valcom_conent;
            return this;
        }

        public ControleEntBuilder ComDatConEnt(string datent_con)
        {
            this.data_entrada = datent_con;
            return this;
        }
        public ControleEntBuilder ComForConEnt(string for_conent)
        {
            this.fornecedorent = for_conent;
            return this;
        }
        public ControleEntBuilder ComNumFatConEnt(int numfat_conent)
        {
            this.num_faturaent = numfat_conent;
            return this;
        }
        public ControleEntBuilder ComMotConEnt(string motent_con)
        {
            this.motivo_ent = motent_con;
            return this;
        }
    }
}
