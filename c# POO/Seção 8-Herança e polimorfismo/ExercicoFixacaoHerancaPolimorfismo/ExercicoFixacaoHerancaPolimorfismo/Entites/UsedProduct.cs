using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicoFixacaoHerancaPolimorfismo.Entites
{
    sealed class UsedProduct : Product
    {
        public DateTime Date { get;private set; }

        public UsedProduct() { }

        public UsedProduct(string name, double price,DateTime date): base(name,price) {
            Date = date;
        }
        public sealed override string priceTag()
        {
            return $"{Name} (used) $ {Price.ToString("F2", CultureInfo.InvariantCulture)} (Manufacture date: {Date.ToString("dd/MM/yyyy")})";
        }
        
    }
}
