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
    public partial class Form1 : Form
    {
        List<Produto> listaProdutos;   
        public Form1()
        {
            InitializeComponent();
            listaProdutos = new List<Produto>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Produto temp = new Produto(txtNome.Text, txtPreco.Text);
                listaProdutos.Add(temp);
                cbxProdutos.Items.Add(temp);

                txtNome.Text = "";
                txtPreco.Text = "";
                MessageBox.Show("Produto adicionado com suvesso");
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(listaProdutos[cbxProdutos.SelectedIndex]);
        }
    }
}
