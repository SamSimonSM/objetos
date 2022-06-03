

namespace objetos
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
            Id = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 8);
            Nome = name;
            Preco = preco;
            Estoque = estoque;
            Quant = quant;
        }
        public string Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quant { get; set; }
        public EEstoque Estoque { get; set; }
        public double PrecoEmReal(double dolar)
        {
            return Preco * dolar;
        }
    }
}
