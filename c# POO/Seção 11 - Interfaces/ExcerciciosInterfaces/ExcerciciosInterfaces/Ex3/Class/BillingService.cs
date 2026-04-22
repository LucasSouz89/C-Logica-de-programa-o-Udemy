using ExcerciciosInterfaces.Ex3.Class.Entites1;
using ExcerciciosInterfaces.Ex3.Class.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciciosInterfaces.Ex3.Class
{
    sealed class BillingService
    {
        
        

        IDiscountService _discountService;

        public BillingService() { }

        public BillingService(IDiscountService discountService) 
        {
            
            _discountService = discountService; 
        }
        public Invoice ProcessBilling(Subscription sub)
        {
            double subtotal =(double) sub.MotlyPrice * sub.Months;
            double discount = _discountService.ApplyDiscount(subtotal);
            double total = subtotal - discount;
            return new Invoice(subtotal, discount, total);
        }




    }
}
