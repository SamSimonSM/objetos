namespace Programa
{
    internal class Estoque
    {
        public Estoque()
        {
            Items = new List<Produto>();
        }

        private static IList<Produto> Items { get; set; }

        public static void CadastraProduto()
        {
            
            Items.Add(Produto.CadastraProduto());
        }  
        public static void MostraEstoque()
        {
            Console.Clear();
            var cont = 0;
            foreach (var item in Items)
            {
                MostraProduto(item, cont);
                cont++;
            }
            Console.WriteLine("Pressione enter para continuar !");
            Console.ReadLine();
            Console.Clear();
        } 
        public static void AlteraProduto()
        {
            Console.Clear();
            Console.Write("Informe o numero do produto que deseja alterar: ");
            var altProduto = int.Parse(Console.ReadLine());
            Console.Write("Produto Em Alteração");
            MostraAlt(altProduto);

            Console.Write("\n--------------------" +
                "\nQual informação deseja alterar? (1-Nome 2-Quantidade 3-Valor 4-Disponibilidade) : ");
            var altTipo = int.Parse(Console.ReadLine());


            switch (altTipo)
            {
                case 1:

                    Console.Write($"Informe o novo nome do produto {altProduto} : ");
                    Items[altProduto].Nome = Console.ReadLine();
                    Console.Write("Produto Alterado");
                    MostraAlt(altProduto);
                    Console.Clear(); break;
                case 2:
                    Console.Write($"Informe a nova quantidade do produto {altProduto} : ");
                    Items[altProduto].Quant = int.Parse(Console.ReadLine());
                    Console.Write("Produto Alterado");
                    MostraAlt(altProduto);
                    Console.Clear();
                    break;
                case 3:
                    Console.Write($"Informe o novo valor do produto {altProduto} : ");
                    Items[altProduto].Preco = double.Parse(Console.ReadLine());
                    Console.Write("Produto Alterado");
                    MostraAlt(altProduto);
                    Console.Clear();
                    break;
                case 4:
                    Console.Write($"Informe a status do produto {altProduto} : ");
                    Items[altProduto].Estoque = (EEstoque)Enum.Parse(typeof(EEstoque), Console.ReadLine());
                    Console.Write("Produto Alterado");
                    MostraAlt(altProduto);
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Voce não informou uma opção valida!!");
                    Console.ReadLine();
                    AlteraProduto();
                    break;

                    Console.WriteLine("Pressione enter para continuar !");
                    Console.ReadLine();
                    Console.Clear();
            }

        }
        public static void RemoveProduto()
        {
            Console.Clear();
            Console.Write("Informe o numero do produto que deseja alterar: ");
            var altProduto = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Produto Removido");
            MostraAlt(altProduto);
            Console.WriteLine("Pressione enter para continuar !");
            Console.ReadLine();
            Console.Clear();
            Items.Remove(Items[altProduto]);

        }    
        public static void MostraProduto(Produto item, int cont)
        {
            Console.WriteLine($"Produto Numero:{cont}");
            Console.WriteLine(item);
        }
        public static void MostraAlt(int altProduto)
        {
            Console.WriteLine(
            "\n--------------------" +
            $"\nCodigo:{Items[altProduto].Id}" +
            $"\nNome:{Items[altProduto].Nome}" +
            $"\nQuantidade:{Items[altProduto].Quant}" +
            $"\nValor em Dolar:{Items[altProduto].Preco}" +
            $"\nValor em real:{Items[altProduto].PrecoReal}" +
            $"\nStatus:{Items[altProduto].Estoque}");
        }
        
    }
}
