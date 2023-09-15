using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    internal class CashRewardsCard : ICreditCard
    {
        public void Limit()
        {
            Console.WriteLine("This is Cash Rewards Credit Card with Limit $1000");
        }

        public void Transcation()
        {
            Console.WriteLine("This is Balance Transfer Credit Card with Transation Limit $1000");
        }
    }
}
