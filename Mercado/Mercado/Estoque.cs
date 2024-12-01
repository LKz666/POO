namespace Mercado
{
    internal class Estoque
    {
        public string Nome;
        public double Valor;
        public int Quantidade;

        public double ValorTotal()
        {
            return Valor * Quantidade;
        }

        public void AdicionarProduto(int quantidade) 
        { 
            Quantidade += quantidade;
        }

        public void RemoverProduto(int quantidade) 
        { 
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome + " " + Valor + " " + Quantidade + " " + ValorTotal();
        }
    }
}
