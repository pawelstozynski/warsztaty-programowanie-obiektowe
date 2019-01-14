using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warsztaty_1
{
    class Account
    {
        public string name;
        private double amount;

        public Account(string name)
        {
            this.name = name;
            this.amount = 100.0;
        }

        public void Deposit(double amount)
        {
            this.amount += amount;
        }

        public void Withdraw(double amount)
        {
            if (this.amount >= amount)
            {
                this.amount -= amount;
            }
            else
            {
                Console.WriteLine("Not enough money :(");
            }
        }

        public double GetAmount()
        {
            return this.amount;
        }

        public override string ToString()
        {
            return $"{this.amount} PLN on {this.name}";
        }

    }
}
