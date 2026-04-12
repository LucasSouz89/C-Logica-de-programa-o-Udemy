using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExercicoFixacaoHerancaPolimorfismo.Entites
{
    sealed class ImportedProduct : Product
    {
        public double CustomsFee { get; private set; }

        public ImportedProduct() { }

        public ImportedProduct(string name, double price,double customFee): base(name,price) 
        {
            CustomsFee = customFee;
        }
        public sealed override string priceTag()
        {
            double newPrice = CustomsFee + Price;
            return $"{Name} $ {newPrice.ToString("F2", CultureInfo.InvariantCulture)} (Customs fee: $ {CustomsFee})";
        }
        
        
    }
}
