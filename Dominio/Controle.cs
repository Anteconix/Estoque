namespace Teste
{
    public class Controle
    {
        private int quantidade;
        private string valor_compra;
        private string data_entrada;
        private string fornecedor;
        private int num_fatura;
        private string motivo_ent;

        public Controle(int quantidade, string valor_compra, string data_entrada, string fornecedor, int num_fatura, string motivo_ent)
        {
            if (quantidade < 1) throw new ArgumentException("Quantidade inválida");
            if (string.IsNullOrEmpty(valor_compra)) throw new ArgumentException("Valor da compra inválido");
            if (string.IsNullOrEmpty(data_entrada)) throw new ArgumentException("Data de entrada inválida");
            if (string.IsNullOrEmpty(fornecedor)) throw new ArgumentException("Fornecedor inválido");
            if (num_fatura < 1) throw new ArgumentException("Número da fatura inválido");
            if (string.IsNullOrEmpty(motivo_ent)) throw new ArgumentException("Motivo de entrada inválido");

            this.Quantidade = quantidade;
            this.Valor_compra = valor_compra;
            this.Data_entrada = data_entrada;
            this.Fornecedor = fornecedor;
            this.Num_fatura = num_fatura;
            this.Motivo_ent = motivo_ent;
        }

        public int Quantidade { get => quantidade; set => quantidade = value; }
        public string Valor_compra { get => valor_compra; set => valor_compra = value; }
        public string Data_entrada { get => data_entrada; set => data_entrada = value; }
        public string Fornecedor { get => fornecedor; set => fornecedor = value; }
        public int Num_fatura { get => num_fatura; set => num_fatura = value; }
        public string Motivo_ent { get => motivo_ent; set => motivo_ent = value; }
    }
}