using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    internal class TravelCreditCard : ICreditCard
    {
        public void Limit()
        {
            Console.WriteLine("This is Travel Credit Card with Limit $1000");
        }

        public void Transcation()
        {
            Console.WriteLine("This is Travel Card with Transation Limit $1000");
        }
    }
}
