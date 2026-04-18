using System.Globalization;

namespace SoluçãoSemInterface.Entites.Class
{
    sealed class Invoice
    {
        public double BasicPayment { get;private set; }
        public double Tax { get;private set; }

        public Invoice() { }

        public Invoice(double basicPayment, double tax) 
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment() 
        {
             return BasicPayment + Tax; 

        }
        public override string ToString()
        {
            return $"Basic payment: {BasicPayment.ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"Tax {Tax.ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"Total payment: {TotalPayment().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
