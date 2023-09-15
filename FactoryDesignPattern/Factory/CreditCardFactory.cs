using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Factory
{
    public enum CardSource
    {
        BalanceTransfer = 1,
        CashRewards = 2,
        Travel = 3
    }
    public class CreditCardFactory : ICreditCardFactory
    {
        private readonly Func<string, ICreditCard> _creditCard;
        public CreditCardFactory(Func<string, ICreditCard> creditCard)
        {
            _creditCard = creditCard;
        }
        public object GetCreditCard(string s)
        {
            return _creditCard(s).Limit;
        }
    }
}
