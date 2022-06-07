namespace estoque
{
    internal class Conj
    {
        public Conj()
        {
            Items = new List<Produto>(); ;
        }

        public IList<Produto> Items { get; set; }

    }
}
