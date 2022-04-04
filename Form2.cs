using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroProduto_Study
{
    public partial class Form2 : Form
    {
        public Produto produto;
        public Form2(Produto produto)
        {
            InitializeComponent();
            lblProduto.Text = produto.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
