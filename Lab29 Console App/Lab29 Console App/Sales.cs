using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab29_Console_App
{
    public class Sales
    {
        public List<Sale> AllSales { get; set; }

        public Sales()
        {
            AllSales = new List<Sale>();
        }

        public void AddSale(Sale sale)
        {
            AllSales.Add(sale);
        }

        public void RemoveSale(Sale sale)
        {
            AllSales.Remove(sale);
        }
    }
}
