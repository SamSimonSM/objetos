namespace objetos
{
    internal class Metodos
    {
        static public void Menu(Conj conj)
        {
            Console.Clear();
            Console.Write("1-Cadastrar Produto" +
                "\n2-Mostar Produto" +
                "\n3-Alterar Produto" +
                "\n4-Sair" +
                "\nInforme a Operação: "
                );
            var escolha = int.Parse(Console.ReadLine());
            switch (escolha)
            {
                case 1: CadastraProduto(conj); break;
                case 2: MostraProduto(conj); break;
                case 3: AlteraProduto(conj); break;
                case 4: System.Environment.Exit(0); break;
            }
        }


        static public void CadastraProduto(Conj conj)
        {
            var valor = 0d;
            var eEstoque = new EEstoque();
            var nome = "";
            var quant = 0;
            Console.Clear();
            Console.Write("Insira o nome do produto: ");
            nome = Console.ReadLine();
            Console.Write("Insira a quantidade do produto: ");
            quant = int.Parse(Console.ReadLine());
            Console.Write("Insira o valor do produto: ");
            valor = double.Parse(Console.ReadLine());
            Console.Write("Insira a disponibilidade: ");
            eEstoque = (EEstoque)Enum.Parse(typeof(EEstoque), Console.ReadLine());

            Product item = new(nome, valor, eEstoque, quant);

            Console.Clear();
            Console.WriteLine("Produto Cadastrado");
            MostraProduto(item);
            Console.WriteLine("Pressione enter para continuar !");
            Console.ReadLine();
            Console.Clear();
            conj.Items.Add(item);

        }

        static public void MostraProduto(Conj conj)
        {
            Console.Clear();
            var cont = 0;
            foreach (var item in conj.Items)
            {
                MostraProduto(item, cont);
                cont++;
            }
        }

        static public void AlteraProduto(Conj conj)
        {
            Console.Clear();
            Console.Write("Informe o numero do produto que deseja alterar: ");
            var altProduto = int.Parse(Console.ReadLine());

            MostraAlt(conj, altProduto);

            Console.Write("\n--------------------" +
                "\nQual informação deseja alterar? (1-Nome 2-Quantidade 3-Valor 4-Disponibilidade) : ");
            var altTipo = int.Parse(Console.ReadLine());

            Console.Clear();
            switch (altTipo)
            {
                case 1:
                    Console.Write($"Informe o novo nome do produto {altProduto} : ");
                    conj.Items[altProduto].Nome = Console.ReadLine();
                    MostraAlt(conj, altProduto);
                    break;
                case 2:
                    Console.Write($"Informe a nova quantidade do produto {altProduto} : ");
                    conj.Items[altProduto].Quant = int.Parse(Console.ReadLine());
                    MostraAlt(conj, altProduto);
                    break;
                case 3:
                    Console.Write($"Informe o novo Valor do produto {altProduto} : ");
                    conj.Items[altProduto].Preco = double.Parse(Console.ReadLine());
                    MostraAlt(conj, altProduto);
                    break;
                case 4:
                    Console.Write($"Informe a status do produto {altProduto} : ");
                    conj.Items[altProduto].Estoque = (EEstoque)Enum.Parse(typeof(EEstoque), Console.ReadLine());
                    MostraAlt(conj, altProduto);
                    break;
                default:
                    Console.WriteLine("Voce não informou uma opção valida!!");
                    Console.ReadLine();
                    AlteraProduto(conj);
                    break;
            }

        }

        static public void MostraAlt(Conj conj, int altProduto)
        {
            Console.WriteLine(
            "\nProduto" +
            "\n--------------------" +
            $"\nCodigo:{conj.Items[altProduto].Id}" +
            $"\nNome:{conj.Items[altProduto].Nome}" +
            $"\nQuantidade:{conj.Items[altProduto].Quant}" +
            $"\nValor em Dolar:{conj.Items[altProduto].Preco}" +
            $"\nValor em real:{conj.Items[altProduto].PrecoEmReal(4.79)}" +
            $"\nStatus:{conj.Items[altProduto].Estoque}");
        }




        static public void MostraProduto(Product item)
        {
            Console.WriteLine(
            "--------------------" +
            $"\nCodigo:{item.Id}" +
            $"\nNome:{item.Nome}" +
            $"\nQuantidade:{item.Quant}" +
            $"\nValor em Dolar:{item.Preco}" +
            $"\nValor em real:{item.PrecoEmReal(4.79)}" +
            $"\nStatus:{item.Estoque}");
        }
        static public void MostraProduto(Product item, int cont)
        {
            Console.WriteLine("--------------------" +
            $"\nCadastro Numero:{cont}" +
            $"\nProduto:{item.Nome}" +
            $"\nCodigo:{item.Id}" +
            $"\nQuantidade:{item.Quant}" +
            $"\nValor em Dolar:{item.Preco}" +
            $"\nValor em real:{item.PrecoEmReal(4.79)}" +
            $"\nStatus:{item.Estoque}\n");
        }



    }

}
