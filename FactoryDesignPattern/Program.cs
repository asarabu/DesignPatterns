using FactoryDesignPattern.Factory;

namespace FactoryDesignPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Please enter the CreditCard Type : ");
            var cardType = Console.ReadLine();

            ICreditCardFactory getInstance = new CreditCardFactory(null);
            getInstance.GetCreditCard(cardType);
            Console.WriteLine("Hello, World!");
        }
    }
}