namespace Teste
{
    public class Produto
    {
        private string desc_produto;
        private int cod_barras;
        private string preco_compra;
        private string preco_venda;

        public Produto(string desc_produto, int cod_barras, string preco_compra, string preco_venda)
        {
            if (string.IsNullOrEmpty(desc_produto)) throw new ArgumentException("Descrição inválida");
            if (cod_barras < 1) throw new ArgumentException("Código de barras inválido");
            if (string.IsNullOrEmpty(preco_compra)) throw new ArgumentException("Preço de compra inválido");
            if (string.IsNullOrEmpty(preco_venda)) throw new ArgumentException("Preço de venda inválido");

            this.Desc_produto = desc_produto;
            this.Cod_barras = cod_barras;
            this.Preco_compra = preco_compra;
            this.Preco_venda = preco_venda;
        }

        public string Desc_produto { get => desc_produto; set => desc_produto = value; }
        public int Cod_barras { get => cod_barras; set => cod_barras = value; }
        public string Preco_compra { get => preco_compra; set => preco_compra = value; }
        public string Preco_venda { get => preco_venda; set => preco_venda = value; }
    }
}