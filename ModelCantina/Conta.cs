using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelCantina
{
    public class Conta
    {
        public int IDConta { get; set; }
        public Cliente Cliente { get; set; }
        public double Limite { get; set; }
        public double SaldoDevedor { get; set; }
        private IList<Pagamento> pagamentos;

        public IList<Pagamento> Pagamentos
        {
            get { return pagamentos; }
            
        }
        public Conta()
        {
            pagamentos = new List<Pagamento>();
        }
        
    }
}
