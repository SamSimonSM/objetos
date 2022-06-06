

namespace estoque
{
    public enum EEstoque
    {
        Indisponivel = 0,
        Disponivel = 1,
        Transito = 2,
        Descontinuado = 3
    }
    public class Product
    {

        public Product(string name, double preco, EEstoque estoque, int quant)
        {
            _id = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 8);
            _nome = name;
            _preco = preco;
            _estoque = estoque;
            _quant = quant;
        }
        private string _id;
        private string _nome;
        private double _preco;
        private int _quant;
        private EEstoque _estoque;
        private double PrecoEmReal(double dolar)
        {
            return _preco * dolar;
        }

        public string GetId()
        {
            return _id;
        }
        public string GetNome() => _nome;
        public double GetPreco() => _preco;
        public int GetQuant() => _quant;
        public EEstoque GetEstoque() => _estoque;
        public double GetPrecoReal()
        {
            return PrecoEmReal(4.79);
        }

        public void SetNome(string nome) => _nome = nome;
        public void SetPreco(double preco) => _preco = preco;
        public void SetQuant(int quant) => _quant = quant;
        public void SetEstoque(EEstoque estoque) => _estoque = estoque;








        public override string ToString()
        {
            return
            "--------------------" +
            $"\nCodigo:{_id}" +
            $"\nNome:{_nome}" +
            $"\nQuantidade:{_quant}" +
            $"\nValor em Dolar:{_preco}" +
            $"\nValor em real:{PrecoEmReal(4.79)}" +
            $"\nStatus:{_estoque}\n";
        }


    }
}
