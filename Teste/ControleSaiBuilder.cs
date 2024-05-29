using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    internal class ControleSaiBuilder
    {
        private int quantidadesai = 1;
        private string valor_vendasai = "100";
        private string data_saida = "100";
        private string cliente = "magno";
        private string motivo_saida = "venda";
        public static ControleSaiBuilder NovoConSai()
        {
            return new ControleSaiBuilder();
        }

        public ControleSai CriarConSai()
        {
            return new ControleSai(
                quantidadesai,
                valor_vendasai,
                data_saida,
                cliente,
                motivo_saida);
        }

        public ControleSaiBuilder GerarDadosConSai()
        {
            Faker faker = new Faker();

            quantidadesai = faker.Random.Int(1, 1000);
            valor_vendasai = faker.Random.Word();
            data_saida = faker.Random.Word();
            cliente = faker.Random.Word();
            motivo_saida = faker.Random.Word();
            return this;
        }
        public ControleSaiBuilder ComQuaConSai(int qua_consai)
        {
            this.quantidadesai = qua_consai;
            return this;
        }

        public ControleSaiBuilder ComValVenConSai(string valven_consai)
        {
            this.valor_vendasai = valven_consai;
            return this;
        }

        public ControleSaiBuilder ComDatConSai(string datsai_con)
        {
            this.data_saida = datsai_con;
            return this;
        }
        public ControleSaiBuilder ComCliCon(string cli_consai)
        {
            this.cliente = cli_consai;
            return this;
        }
        public ControleSaiBuilder ComMotSaiCon(string motsai_con)
        {
            this.motivo_saida = motsai_con;
            return this;
        }
    }
}
