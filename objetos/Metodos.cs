using controleEstoque.Entities;

namespace Programa
{


    static internal class Metodos
    {
        public static void Menu()
        {
            try
            {
                Console.Write("1-Cadastrar Produto" +
                "\n2-Mostar Produtos" +
                "\n3-Alterar Produto" +
                "\n4-Remover Produto" +
                "\n5-Sair" +
                "\nInforme a Operação: "
                );
                var escolha = int.Parse(Console.ReadLine());

                Console.Clear();
                switch (escolha)
                {
                    case 1: Estoques.CadastraProduto(); break;
                    case 2: Estoques.MostraEstoque(); break;
                    case 3: Estoques.AlteraProduto(); break;
                    case 4: Estoques.RemoveProduto(); break;
                    case 5: Environment.Exit(0); break;
                    default:
                        Console.WriteLine("*****Insira um Numero Valido****");
                        Menu(); break;
                }
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("*****Insira um Valor Valido****");
                Menu();

            }
        }
    }


}
