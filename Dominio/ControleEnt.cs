namespace Teste
{
    public class ControleEnt
    {
        private int quantidadeent;
        private string valor_compraent;
        private string data_entrada;
        private string fornecedorent;
        private int num_faturaent;
        private string motivo_ent;

        public ControleEnt(int quantidadeent, string valor_compraent, string data_entrada, string fornecedorent, int num_faturaent, string motivo_ent)
        {
            if (quantidadeent < 1) throw new ArgumentException("Quantidade inválida");
            if (string.IsNullOrEmpty(valor_compraent)) throw new ArgumentException("Valor da compra inválido");
            if (string.IsNullOrEmpty(data_entrada)) throw new ArgumentException("Data de entrada inválida");
            if (string.IsNullOrEmpty(fornecedorent)) throw new ArgumentException("Fornecedor inválido");
            if (num_faturaent < 1) throw new ArgumentException("Número da fatura inválido");
            if (string.IsNullOrEmpty(motivo_ent)) throw new ArgumentException("Motivo de entrada inválido");

            this.Quantidadeent = quantidadeent;
            this.Valor_compraent = valor_compraent;
            this.Data_entrada = data_entrada;
            this.Fornecedorent = fornecedorent;
            this.Num_faturaent = num_faturaent;
            this.Motivo_ent = motivo_ent;
        }

        public int Quantidadeent { get => quantidadeent; set => quantidadeent = value; }
        public string Valor_compraent { get => valor_compraent; set => valor_compraent = value; }
        public string Data_entrada { get => data_entrada; set => data_entrada = value; }
        public string Fornecedorent { get => fornecedorent; set => fornecedorent = value; }
        public int Num_faturaent { get => num_faturaent; set => num_faturaent = value; }
        public string Motivo_ent { get => motivo_ent; set => motivo_ent = value; }
    }
}