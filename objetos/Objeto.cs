namespace objetos
{


    internal class NewBaseType
    {
        static void Main(string[] args)
        {

            var conj = new Conj();

            var seguir = 1;

            while(seguir == 1)
            {
                Metodos.Menu(conj);
                Console.WriteLine("Deseja Continunar? (1-Sim 2-Não)");
                seguir = int.Parse(Console.ReadLine());

            }
           
        }

    }
}

