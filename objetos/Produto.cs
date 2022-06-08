

namespace Programa
{
   internal enum EEstoque
    {
        Indisponivel = 0,
        Disponivel = 1,
        Transito = 2,
        Descontinuado = 3
    }
    internal  class Produto
    {
        private string _id;
        private string _nome;
        private double _preco;
        private int _quant;
        private EEstoque _estoque;
        private double PrecoEmReal(double dolar)
        {
            return _preco * dolar;
        }
     
        private Produto(string name, double preco, EEstoque estoque, int quant)
        {
            _id = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 8);
            _nome = name;
            _preco = preco;
            _estoque = estoque;
            _quant = quant;
        }
     
        public string Id => _id;
        public string Nome { get => _nome; set => _nome = value; }
        public double Preco { get => _preco; set => _preco = value; }
        public int Quant { get => _quant; set => _quant = value; }
        public EEstoque Estoque { get => _estoque; set => _estoque = value; }
        public double PrecoReal => PrecoEmReal(4.79);
        public static Produto CadastraProduto()
        {
            Console.Clear();
            Console.Write("Insira o nome do produto: ");
            var nome = Console.ReadLine();
            Console.Write("Insira a quantidade do produto: ");
            var quant = int.Parse(Console.ReadLine());
            Console.Write("Insira o valor do produto: ");
            var valor = double.Parse(Console.ReadLine());
            Console.Write("Insira a disponibilidade: ");
            var eEstoque = (EEstoque)Enum.Parse(typeof(EEstoque), Console.ReadLine());

            Produto item = new(nome, valor, eEstoque, quant);

            Console.Clear();
            Console.WriteLine("Produto Cadastrado");
            Console.WriteLine(item);
            Console.WriteLine("Pressione enter para continuar !");
            Console.ReadLine();
            Console.Clear();
            return item;
        }
        public override string ToString()
        {
            return
            "--------------------" +
            $"\nCodigo:{Id}" +
            $"\nNome:{Nome}" +
            $"\nQuantidade:{Quant}" +
            $"\nValor em Dolar:{Preco}" +
            $"\nValor em real:{PrecoReal}" +
            $"\nStatus:{Estoque}\n";
        }
      
        static public void MostraProduto(Produto item, int cont)
        {
            Console.WriteLine($"Produto Numero:{cont}");
            Console.WriteLine(item);
        }
    }
}
