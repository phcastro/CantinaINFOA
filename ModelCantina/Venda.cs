using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelCantina
{
    public class Venda
    {
        public int IDVenda { get; set; }
        public Cliente Cliente { get; set;}
        public Funcionario Funcionario { get; set; }
        public DateTime DataVenda { get; set; }
        private IList<VendaProduto> produtos;
        public IList<VendaProduto> Produtos
        {
            get { return produtos; }
            
        }
        public Venda()
        {
            produtos = new List<VendaProduto>();
          
        }

        public double Total
        {
            get {

                double total = 0.0;
                foreach (VendaProduto vp in produtos)
                {
                    total += vp.Quantidade * vp.Produto.PrecoUnitario;
                }
                return total;
            
            }
        }

    }
}
