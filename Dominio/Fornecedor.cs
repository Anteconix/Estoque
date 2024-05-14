namespace Dominio
{
    public class Fornecedor
    {
        private string nome_empresa;
        private string endereco_empresa;
        private string telefone_empresa;

        public Fornecedor(string nome_empresa, string endereco_empresa, string telefone_empresa)
        {
            if (string.IsNullOrEmpty(nome_empresa)) throw new ArgumentException("Nome inválido");
            if (string.IsNullOrEmpty(endereco_empresa)) throw new ArgumentException("Endereço inválido");
            if (string.IsNullOrEmpty(telefone_empresa)) throw new ArgumentException("Telefone inválido");


            this.Nome_empresa = nome_empresa;
            this.Endereco_empresa = endereco_empresa;
            this.Telefone_empresa = telefone_empresa;
        }

        public string Nome_empresa { get => nome_empresa; set => nome_empresa = value; }
        public string Endereco_empresa { get => endereco_empresa; set => endereco_empresa = value; }
        public string Telefone_empresa { get => telefone_empresa; set => telefone_empresa = value; }
    }
}