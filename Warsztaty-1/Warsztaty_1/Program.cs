using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warsztaty_1
{

    class Program
    {
        static void Main(string[] args)
        {
            /*Account normal = new Account();
            normal.name = "Konto zwykłe";
            normal.amount = 2000.0;

            Account savings = new Account();
            savings.name = "Konto oszczędnościowe";
            savings.amount = 5000.0;*/

            Account normal = new Account("Konto zwykłe");
            Account savings = new Account("Konto oszczędnościowe");

            normal.Deposit(5000.0);
            normal.Withdraw(2000.0);

            Console.WriteLine(normal.ToString());
            Console.WriteLine(savings.ToString());
            Console.WriteLine(normal.GetAmount());

            Console.ReadKey();
        }
    }
}
