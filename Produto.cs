using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroProduto_Study
{
    public class Produto
    {
        public string Nome { get; private set; }
        public string Preco { get; private set; }

        public Produto(string nome, string preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override string ToString()
        {
            return "Nome: " + Nome + "\n" +
                "Preço: " + Preco + "\n";
        }
    }
}
