namespace Teste
{
    public class ControleSai
    {
        private int quantidadesai;
        private string valor_vendasai;
        private string data_saida;
        private string cliente;
        private string motivo_sai;

        public ControleSai(int quantidadesai, string valor_vendasai, string data_saida, string cliente, string motivo_sai)
        {
            if (quantidadesai < 1) throw new ArgumentException("Quantidade inválida");
            if (string.IsNullOrEmpty(valor_vendasai)) throw new ArgumentException("Valor de venda inválido");
            if (string.IsNullOrEmpty(data_saida)) throw new ArgumentException("Data de saída inválida");
            if (string.IsNullOrEmpty(cliente)) throw new ArgumentException("Cliente inválido");
            if (string.IsNullOrEmpty(motivo_sai)) throw new ArgumentException("Motivo de saída inválido");

            this.Quantidadesai = quantidadesai;
            this.Valor_vendasai = valor_vendasai;
            this.Data_saida = data_saida;
            this.Cliente = cliente;
            this.Motivo_sai = motivo_sai;
        }

        public int Quantidadesai { get => quantidadesai; set => quantidadesai = value; }
        public string Valor_vendasai { get => valor_vendasai; set => valor_vendasai = value; }
        public string Data_saida { get => data_saida; set => data_saida = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public string Motivo_sai { get => motivo_sai; set => motivo_sai = value; }
    }
}