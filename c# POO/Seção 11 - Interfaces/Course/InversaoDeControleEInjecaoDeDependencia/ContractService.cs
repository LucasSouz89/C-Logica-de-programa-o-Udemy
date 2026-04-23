using InversaoDeControleEInjecaoDeDependencia.Entites.Interface;
using System;
using System.Collections.Generic;
using InversaoDeControleEInjecaoDeDependencia.Entites.Class;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversaoDeControleEInjecaoDeDependencia
{
    sealed class ContractService
    {
        public IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }
        public void ProcessContract(Contract contract,int months)
        {
            double baseCot = contract.TotalValue / months;
            for (int i = 1; i <= months; i++) {
                double interest = _onlinePaymentService.Interest(baseCot, i);
                double PaymentFee = _onlinePaymentService.PaymentFee(interest);
                contract.AddInstallments(new Installment(contract.Date.AddMonths(i),PaymentFee));
            }
            
        }
    }
}
