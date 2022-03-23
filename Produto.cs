using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroProduto_Study
{
    public class Produto
    {
        public string nome { get; private set; }
        public string preco { get; private set; }

        public Produto(string nome, string preco)
        {
            this.nome = nome;
            this.preco = preco;
        }

        public override string ToString()
        {
            return "Nome: " + nome + "\n" +
                "Preço: " + preco + "\n";
        }
    }
}
